namespace InternetShop.SiteApp.Services.EmailService
{
    public class MailRequestModel
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}