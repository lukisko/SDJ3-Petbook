using System.Collections.Generic;

namespace ClientApp.Model
{
    public class StaticVariables
    {
        public static string URL = "https://localhost:5001";
        public static string AccessToken = "_authenticationToken";
        public static IDictionary<string, string> AccessTokensLibrary = new Dictionary<string, string>();
    }
}