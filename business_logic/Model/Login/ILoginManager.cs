namespace business_logic.Model.Login
{
    public interface ILoginManager
    {
        void MakeUserCode(string email);
        bool IsCorrectCode(string email, string code);
        string MakeUserToken(string email);
        string getUserWithToken(string token);
    }
}