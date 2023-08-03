using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsMethod
{
    internal static class Extension
    {

        public static bool Contains(this string Sentence, string newSentence)
        {
            bool result = false;

            if (Sentence.IndexOf(newSentence) != -1)
                result = true;

            return result;
        }


    }
}
