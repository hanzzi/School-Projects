    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Ekstraopgave
{
    class StringAnalysisAdvanced : StringAnalysisBase
    {
        protected char AnalysisChar;

        public void AssignCharacter(char c)
        {
            AnalysisChar = c;
        }

        public double GetNumberOfCharacters()
        {
            return CalculateNumberOfChars();
        }

        private double CalculateNumberOfChars()
        {
            int matchingChars = 0;
            foreach (char c in StringToBeAnalyzed)
            {
                if (c == AnalysisChar)
                    matchingChars++;
            }
            return matchingChars;
        }

        public string PercentageOfChars()
        {
            double Percentage = (CalculateNumberOfChars() / GetLength()) * 100;

            if (Percentage == 0)
                return "Cannot Divide By Zero";

            return Percentage.ToString();
        }
    }
}
