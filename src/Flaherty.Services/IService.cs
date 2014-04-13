// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IService.cs" company="James Flaherty">
//   2013-2014
// </copyright>
// <summary>
//   Defines the IService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    using System;

    /// <summary>
    /// The Service interface.
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Gets a response.
        /// </summary>
        /// <typeparam name="TResponse">
        /// The response type.
        /// </typeparam>
        /// <typeparam name="TRequest">
        /// The request type.
        /// </typeparam>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        TResponse Get<TResponse, TRequest>(TRequest request) 
            where TRequest : IRequest 
            where TResponse : IResponse;

        /// <summary>
        /// Kicks off an asynchronous request.
        /// </summary>
        /// <typeparam name="TResponse">
        /// The response type.
        /// </typeparam>
        /// <typeparam name="TRequest">
        /// The request type.
        /// </typeparam>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="callback">
        /// The callback.
        /// </param>
        void Get<TResponse, TRequest>(TRequest request, Action<TResponse> callback) 
            where TRequest : IRequest
            where TResponse : IResponse;
    }

    /// <summary>
    /// The Service interface.
    /// </summary>
    /// <typeparam name="TResponse">
    /// The response type.
    /// </typeparam>
    public interface IService<out TResponse>
        where TResponse : IResponse
    {
        /// <summary>
        /// Gets a response.
        /// </summary>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        TResponse Get();
    }

    /// <summary>
    /// The Service interface.
    /// </summary>
    /// <typeparam name="TRequest">
    /// The request type.
    /// </typeparam>
    /// <typeparam name="TResponse">
    /// The response type.
    /// </typeparam>
    public interface IService<in TRequest, TResponse> : IService<TResponse>
        where TRequest : IRequest
        where TResponse : IResponse
    {
        /// <summary>
        /// Gets a response.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="TResponse"/>.
        /// </returns>
        TResponse Get(TRequest request);

        /// <summary>
        /// Kicks off an asynchronous request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="callback">
        /// The callback.
        /// </param>
        void Get(TRequest request, Action<TResponse> callback);
    }
}
