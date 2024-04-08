using System.Net;

namespace api.ViewResponse
{
    public class ResultResponseException(HttpStatusCode errorCode, string errorMessage) : Exception
    {
        private HttpStatusCode ErrorCode { get; set; } = errorCode;
        private string ErrorMessage { get; set; } = errorMessage;

        public HttpStatusCode GetErrorCode() => ErrorCode;
        public string GetErrorMessage() => ErrorMessage;
    }
}