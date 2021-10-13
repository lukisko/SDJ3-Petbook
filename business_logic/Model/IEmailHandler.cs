namespace business_logic.Model
{
    public interface IEmailHandler
    {
        void sendEmail(string EmailAddress, string title, string content);
        void sendLoginLink(string EmailAddress, string LoginCode);
    }
}