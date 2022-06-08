﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie8.Helpers
{
    public enum DbAnswer
    {
        OK = 200,
        PasswordLengthIsNotProper,
        UserIsAlreadyRegistered,
        BadPassword,
        UserNotFound,
        RefreshTokenIsExpired
    }
}