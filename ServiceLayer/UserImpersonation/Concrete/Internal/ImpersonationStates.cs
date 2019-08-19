﻿// Copyright (c) 2019 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

namespace ServiceLayer.UserImpersonation.Concrete.Internal
{
    internal enum ImpersonationStates
    {
        Normal,
        Starting,           //causes a recalc in AuthCookieValidate
        Impersonating,
        Stopping            //causes a recalc in AuthCookieValidate
    }
}