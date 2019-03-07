using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TourCalifornia
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request
                    .CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authToken = actionContext.Request.Headers
                                            .Authorization.Parameter;
                string decodedAuthToken = Encoding.UTF8.GetString(
                    Convert.FromBase64String(authToken));
                string[] unamepwdVal = decodedAuthToken.Split(':');
                string username = unamepwdVal[0];
                string password = unamepwdVal[1];

                if (LoginPolicy.Validate(username, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(
                        new GenericIdentity(username),null);
                }
                else
                {
                    actionContext.Response = actionContext.Request
                        .CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }

    public class LoginPolicy
    {
        public static bool Validate(string username, string password)
        {
            // you can read username and password value from database and can easly use here to validate. 
            if (username.Equals("user@abc", StringComparison.OrdinalIgnoreCase) && password == "user@123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}