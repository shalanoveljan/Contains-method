using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsMethod
{
    internal static class Extension
    {

 public static bool CustomContains(this string Sentence, string SearchSentence)
        {
            
            int count = 0;
            int times = 0;
            bool result = false;
            for(int i=0; i<SearchSentence.Length; i++)
            {
                for (int j = i+times; j < Sentence.Length; j++)
                {
                    if (Sentence[j] == SearchSentence[i])
                    {
                        count++;

                        if (SearchSentence.Length == count)
                        {
                            result = true;
                        }
                        else
                        {

                            result = false;
                        }
                        break;



                    }
            
                    else
                    {
                        times++;
                        count = 0;
                    }

                  



                }



            }



            return result;



        }
    }
}
