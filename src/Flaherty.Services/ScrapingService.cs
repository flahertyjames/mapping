// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScrapingService.cs" company="James Flaherty">
//   2013
// </copyright>
// <summary>
//   Defines the ScrapingService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;

    using HtmlAgilityPack;

    /// <summary>
    /// The scraping service.
    /// </summary>
    /// <typeparam name="TResponse">
    /// The response type.
    /// </typeparam>
    public abstract class ScrapingService<TResponse> : IService<TResponse>
        where TResponse : IResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapingService{TResponse}"/> class.
        /// </summary>
        /// <param name="baseUri">
        /// The base uri.
        /// </param>
        /// <param name="method">
        /// The method.
        /// </param>
        protected ScrapingService(Uri baseUri, string method)
        {
            this.BaseUri = baseUri;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapingService{TResponse}"/> class.
        /// </summary>
        /// <param name="baseUri">
        /// The base uri.
        /// </param>
        protected ScrapingService(Uri baseUri) :
            this(baseUri, "GET")
        {
        }

        /// <summary>
        /// Gets the base uri.
        /// </summary>
        /// <value>
        /// The base uri.
        /// </value>
        protected Uri BaseUri { get; private set; }

        /// <summary>
        /// Gets the method.
        /// </summary>
        /// <value>
        /// The method.
        /// </value>
        protected string Method { get; private set; }

        /// <summary>
        /// Gets a response.
        /// </summary>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        public virtual TResponse Get()
        {
            var document = this.Get(this.BaseUri);
            return this.ParseDocument(document);
        }

        /// <summary>
        /// The parse document.
        /// </summary>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        protected abstract TResponse ParseDocument(HtmlDocument document);

        /// <summary>
        /// Gets an html document for the uri.
        /// </summary>
        /// <param name="uri">
        /// The uri to get.
        /// </param>
        /// <returns>
        /// The <see cref="HtmlDocument"/>.
        /// </returns>
        protected HtmlDocument Get(Uri uri)
        {
            var document = new HtmlDocument();
            var request = WebRequest.Create(uri) as HttpWebRequest;
            if (request != null)
            {
                request.Method = this.Method;
                request.UserAgent =
                    "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.0.8) Gecko/2009032609 Firefox/3.0.8 (.NET CLR 3.5.30729)";
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        document.Load(response.GetResponseStream(), true);
                    }
                }
            }

            return document;
        }
    }

    /// <summary>
    /// The scraping service.
    /// </summary>
    /// <typeparam name="TRequest">
    /// The request type.
    /// </typeparam>
    /// <typeparam name="TResponse">
    /// The response type.
    /// </typeparam>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed. Suppression is OK here.")]
    public abstract class ScrapingService<TRequest, TResponse> : ScrapingService<TResponse>
        where TRequest : IRequest
        where TResponse : IResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapingService{TRequest,TResponse}"/> class.
        /// </summary>
        /// <param name="uri">
        /// The uri to scrape.
        /// </param>
        /// <param name="method">
        /// The method.
        /// </param>
        protected ScrapingService(Uri uri, string method)
            : base(uri, method)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapingService{TRequest,TResponse}"/> class.
        /// </summary>
        /// <param name="uri">
        /// The uri to scrape.
        /// </param>
        protected ScrapingService(Uri uri)
            : base(uri)
        {
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
            var uri = this.ConstructUri(request);
            var document = this.Get(uri);
            return this.ParseDocument(document);
        }

        /// <summary>
        /// The construct uri.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Uri"/> to construct.
        /// </returns>
        protected abstract Uri ConstructUri(TRequest request);
    }
}
