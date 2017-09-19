using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------
 * Input format :-
 *      Line1)   CeaserCipher -> Plaintext(string)
 *      Line2)   2              -> Key(integer)
 *      
 * For example :-
 *      CeaserCipher
 *      2
 -------------------------*/ 

namespace Tools
{
    class CeaserCipher
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            if (k >= 26)
            {
                k = k % 26;
            }

            foreach (char c in s)
            {
                if (((int)c >= 65 && (int)c <= 90) || ((int)c >= 97 && (int)c <= 122))
                {
                    if (((int)c >= 97 && (int)c <= 122 && ((int)c + k) > 122) || ((int)c >= 65 && (int)c <= 90 && ((int)c + k) > 90))
                        Console.Write((char)((int)c + k - 26));
                    else
                        Console.Write((char)((int)c + k));
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}
