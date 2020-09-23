using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Interfaces
{
    public class MyProfileService : IProfileService
    {
        public MyProfileService() { }
        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var roleClaims = context.Subject.FindAll(JwtClaimTypes.Role);
            List<string> list = context.RequestedClaimTypes.ToList();
            context.IssuedClaims.AddRange(roleClaims);
            return Task.CompletedTask;
        }

        //public Task GetProfileDataAsync(ProfileDataRequestContext context)
        //{
        //    throw new NotImplementedException();
        //}

        public Task IsActiveAsync(IsActiveContext context)
        {
            return Task.CompletedTask;
        }

        //public Task IsActiveAsync(IsActiveContext context)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
