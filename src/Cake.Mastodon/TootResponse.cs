using System.Net;

namespace Cake.Mastodon
{
    /// <summary>
    /// Response from sending a toot.
    /// </summary>
    public readonly struct TootResponse
    {
        /// <summary>
        /// If the HTTP response status code is a success.
        /// </summary>
        public bool IsSuccess { get; }
        /// <summary>
        /// Actual status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; }
        /// <summary>
        /// Reason phrase given by response.
        /// </summary>
        public string? ReasonPhrase { get; }
        /// <summary>
        /// The body of response.
        /// </summary>
        public string Body { get; }
        /// <summary>
        /// Creates an instance of <see cref="TootResponse"/>.
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="statusCode"></param>
        /// <param name="reasonPhrase"></param>
        /// <param name="body"></param>
        internal TootResponse(bool isSuccess, HttpStatusCode statusCode, string? reasonPhrase, string body)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
            Body = body;
        }

    }
}
