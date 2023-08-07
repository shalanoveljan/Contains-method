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
            //string EmptySentence=string.Empty;
            int count = 0;
            bool result = false;
            for(int i=0; i<SearchSentence.Length; i++)
            {
                for (int j = 0; j < Sentence.Length; j++)
                {
                    if (Sentence[j]== SearchSentence[i])
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
                       count=0;
                        continue;

                    }

                  



                }



            }



            return result;



        }


    }
}
