using System.Net;

namespace api.ViewResponse;

public class ApiResponse
{
    public bool IsSuccess { get; set; }
    public object? Data { get; set; }
    public string? Message { get; set; }

    private ApiResponse(bool isSuccess, object? data, string? message = null)
    {
        IsSuccess = isSuccess;
        Data = data;
        Message = message;
    }

    public static ApiResponse Success(object? data, string? message = "Success")
    {
        ArgumentNullException.ThrowIfNull(data);
        return new ApiResponse(true, data, message);
    }

    public static ApiResponse NotSuccess(HttpStatusCode statusCode, string? message = "error")
    {
        var data = $"Error status code {statusCode}";
        return new ApiResponse(false, data, message);
    }
}