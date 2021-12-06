using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Data;
using ClientApp.Model;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace ClientApp.Authentication 
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
                private readonly IJSRuntime jsRuntime;
        private readonly IUserController userService;
        
        private User cachedUser;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserController userService)
        {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
        }
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (cachedUser == null)
            {
                string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    User tmp = JsonSerializer.Deserialize<User>(userAsJson);
                    ValidateLogin(tmp.email, tmp.code);
                }
            } 
            else
            {
                identity = SetupClaimsForUser(cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
           
        }

        public async Task ValidateLogin(string username, string code)
        {
            Console.WriteLine("Validating log in");
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(code)) throw new Exception("Enter code");

            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
               // User user =await userService.Login(username, code);
                // identity = SetupClaimsForUser(user);
                // string serialisedData = JsonSerializer.Serialize(user);
                // jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", user);
                // cachedUser = user;
                Console.WriteLine("CAched user" +cachedUser);
            }
            catch (Exception e)
            {
                throw e;
            }
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }

        public void Logout()
        {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.name));
            claims.Add(new Claim("Email", user.email));
            
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}