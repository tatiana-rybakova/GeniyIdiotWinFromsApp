using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class InputValidator
    {
        public static bool TryParseToNumber(string input, out string errorMessage)
        {
            int countNumbers = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i])) countNumbers++;
            }

            if (countNumbers == input.Length)
            {
                if (input.Length < 33)
                {                    
                    errorMessage = "";
                    return true;
                }
                else
                {                    
                    errorMessage = "Слишком большое число!";
                    return false;
                }
            }
            else
            {                
                errorMessage = "Пожалуйста, введите число!";
                return false;
            }
        }

        public static bool CheckFiling(string text, out string errorMessage)
        {
            if (text != "")
            {
                errorMessage = "";
                return true;
            }
            else
            {
                errorMessage = "Заполните поле!";
                return false;
            }
        }
    }
}

