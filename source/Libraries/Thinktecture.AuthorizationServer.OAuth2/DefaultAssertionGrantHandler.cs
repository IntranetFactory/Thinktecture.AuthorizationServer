﻿using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.AuthorizationServer.Interfaces;
using Thinktecture.AuthorizationServer.Models;

namespace Thinktecture.AuthorizationServer.OAuth2
{
    public class DefaultAssertionGrantValidator : IAssertionGrantValidation
    {
        public ClaimsPrincipal ValidateAssertion(ValidatedRequest validatedRequest)
        {
            return null;
        }

        public IEnumerable<string> SupportedAssertionTypes
        {
            get { return new string[] { }; }
        }
    }
}
