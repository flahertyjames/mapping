// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RestService.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Abstract class for a REST based service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Net;

    /// <summary>
    /// Abstract class for a REST based service.
    /// </summary>
    /// <typeparam name="TRequest">
    /// The request type.
    /// </typeparam>
    /// <typeparam name="TResponse">
    /// The response type.
    /// </typeparam>
    public abstract class RestService<TRequest, TResponse> : IService<TRequest, TResponse>
        where TRequest : IRequest
        where TResponse : IResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestService{TRequest,TResponse}"/> class.
        /// </summary>
        /// <param name="baseUri">
        /// The base uri.
        /// </param>
        /// <param name="usernameOrApiKey">
        /// The username or API key.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="readTimeout">
        /// The read timeout.
        /// </param>
        /// <param name="writeTimeout">
        /// The write timeout.
        /// </param>
        protected RestService(
            Uri baseUri,
            string usernameOrApiKey = null,
            string password = null,
            int? readTimeout = null,
            int? writeTimeout = null)
        {
            this.BaseUri = baseUri;
            this.UsernameOrApiKey = usernameOrApiKey;
            this.Password = password;
            this.ReadTimeout = readTimeout;
            this.WriteTimeout = writeTimeout;
        }

        /// <summary>
        /// Gets or sets the read timeout.
        /// </summary>
        /// <value>
        /// The read timeout.
        /// </value>
        public int? ReadTimeout { get; set; }

        /// <summary>
        /// Gets or sets the write timeout.
        /// </summary>
        /// <value>
        /// The write timeout.
        /// </value>
        public int? WriteTimeout { get; set; }

        /// <summary>
        /// Gets or sets the username or API key.
        /// </summary>
        /// <value>
        /// The username or API key.
        /// </value>
        protected string UsernameOrApiKey { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        protected string Password { get; set; }

        /// <summary>
        /// Gets the base uri.
        /// </summary>
        /// <value>
        /// The base uri.
        /// </value>
        protected Uri BaseUri { get; private set; }

        /// <summary>
        /// Gets a response.
        /// </summary>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is not supported.
        /// </exception>
        [Browsable(false)]
        public TResponse Get()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Gets a response.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        public virtual TResponse Get(TRequest request)
        {
            var wc = new ServiceWebClient(this.ReadTimeout);
            var result = wc.OpenRead(this.ConstructRequestUri(request));
            return this.ParseResponse(result);
        }

        /// <summary>
        /// Kicks off an asynchronous request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void Get(TRequest request, Action<TResponse> callback)
        {
            var wc = new ServiceWebClient(this.ReadTimeout);
            wc.OpenReadCompleted += (o, a) =>
            {
                if (callback != null)
                {
                    callback(this.ParseResponse(a.Result));
                }
            };
            wc.OpenReadAsync(this.ConstructRequestUri(request));
        }

        /// <summary>
        /// Constructs the request URI for the supplied request object.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The request <see cref="Uri"/>.
        /// </returns>
        protected abstract Uri ConstructRequestUri(TRequest request);

        /// <summary>
        /// Parses the response.
        /// </summary>
        /// <param name="stream">
        /// The stream.
        /// </param>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        protected abstract TResponse ParseResponse(Stream stream);

        /// <summary>
        /// The service web client.
        /// </summary>
        internal class ServiceWebClient : WebClient
        {
            private readonly int? timeout;

            /// <summary>
            /// Initializes a new instance of the <see cref="ServiceWebClient"/> class.
            /// </summary>
            /// <param name="timeout">
            /// The timeout.
            /// </param>
            internal ServiceWebClient(int? timeout)
            {
                this.timeout = timeout;
            }

            /// <summary>
            /// Gets a web request.
            /// </summary>
            /// <param name="uri">
            /// The uri.
            /// </param>
            /// <returns>
            /// The <see cref="WebRequest"/>.
            /// </returns>
            protected override WebRequest GetWebRequest(Uri uri)
            {
                var w = base.GetWebRequest(uri);
                if (w != null && this.timeout.HasValue)
                {
                    w.Timeout = this.timeout.Value;
                }

                return w;
            }
        }
    }
}
