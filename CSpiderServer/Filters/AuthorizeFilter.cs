using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CSpiderServer.Filters
{
    public class AuthorizeFilter : Microsoft.AspNetCore.Mvc.Authorization.AuthorizeFilter
    {
        private AuthorizationPolicy Policy { get; set; }
        public AuthorizeFilter(AuthorizationPolicy policy) : base(policy)
        {
            this.Policy = policy;
        }

        public override Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var a = base.OnAuthorizationAsync(context);
            return a;
        }
    }
}
