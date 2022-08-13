using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class DiagnosisCalculate
    {
        public static string GetMeaning(int percent)
        {            
            if (percent == 0) return "кретин";
            if (percent < 25) return "идиот";
            if (percent < 50) return "дурак";
            if (percent < 75) return "нормальный";
            if (percent < 99) return "талант";
            return "гений";
        }

        public static string GetDiagnosis(int countQuestions, User user)
        {
            int percent = user.CountCorrectAnswers * 100 / countQuestions;            
            return GetMeaning(percent);
        }
    }
}
