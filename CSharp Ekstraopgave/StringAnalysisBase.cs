using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Ekstraopgave
{
    class StringAnalysisBase
    {
        protected string StringToBeAnalyzed;

        public void AssignString(string s)
        {
            StringToBeAnalyzed = s;
        }

        public double GetLength()
        {
            return StringToBeAnalyzed.Length;
        }
    }
}
