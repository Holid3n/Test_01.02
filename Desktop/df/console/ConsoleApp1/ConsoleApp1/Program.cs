using System;
using System.Collections.Generic;
using System.Linq;

namespace Password
{
    public class Password
    {
        public static void Main() {}
        public static string checkPassword(string password)
        {
            string correct = "все хорошо";
            string error = "Попробуйте снова";
            string symbol = "!@#$%^&*()";
            if (password.Length >= 8 && password.Length <= 20)
            {
                if (password.Intersect(symbol).Count() != 0)
                {
                    if (password.Any(Char.IsUpper))
                    {
                        if (password.Any(Char.IsLower))
                        {
                            if (password.Any(Char.IsDigit))
                            {
                                return correct;
                            }
                            else return error;
                        }
                        else return error;
                    }
                    else return error;
                }
                else return error;
            }
            else return error;
        }
    }
}

