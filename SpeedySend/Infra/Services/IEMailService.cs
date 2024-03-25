namespace SpeedySend.Infra.Services
{
    public interface IEMailService
    {
        void EnviaEmail(string[] emails, string subject, string body, bool isHtml = false);
    }
}
