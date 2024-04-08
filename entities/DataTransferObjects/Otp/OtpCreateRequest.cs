namespace entities.DataTransferObjects.Otp;

public class OtpCreateRequest
{
    public string Email { get; set; }
    public string Key { get; set; }
    public string Message { get; set; }
}