﻿using System;
using EventOrganizer.Data;

namespace EventOrganizer.Controller
{
    public class LoginController
    {
        internal static readonly LoginController Instance = new LoginController();

        private LoginController() { }

        internal Session Login(string username, string password, out string fehlermeldung)
        {
            fehlermeldung = "";
            return null;
        }

        internal void Register(string username, string password, out string fehlermeldung)
        {
            fehlermeldung = String.Empty;
        }
    }
}
