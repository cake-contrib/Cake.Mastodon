using System.Net;

namespace Cake.Mastodon
{
    public readonly struct TootResponse
    {
        public bool IsSuccess { get; }
        public HttpStatusCode StatusCode { get; }
        public string ReasonPhrase { get; }
        public string Body { get; }
        public TootResponse(bool isSuccess, HttpStatusCode statusCode, string reasonPhrase, string body)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
            Body = body;
        }

    }
}
