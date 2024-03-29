﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Common.Utils.Utils
{
    public class Utils
    {
        public static bool ValidateEmail(string email)
        {
            bool result = false;
            string expresion = "^[a-zA-z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    result = true;
                else
                    result = false;
            }
            else
                result = false;
            return result;

        }
    }
}
