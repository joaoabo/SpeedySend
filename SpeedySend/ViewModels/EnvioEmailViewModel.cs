namespace SpeedySend.ViewModels
{
    public class EnvioEmailViewModel
    {
        public string[]? Emails { get; set; }

        public string? Subject { get; set; }

        public string? Body { get; set; }

        public bool IsHtml { get; set; }
    }
}
