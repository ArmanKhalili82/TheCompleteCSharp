using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompleteCSharp
{
    public class ShowMaxChar
    {
        public void Show()
        {
            Console.WriteLine("Enter Your Name:");
            var str = Console.ReadLine();
            var res = str.GroupBy(p => p).Select(p => new { Count = p.Count(), Char = p.Key }).GroupBy(p => p.Count, p => p.Char).OrderByDescending(p => p.Key).First();

            foreach (var r in res)
            {
                Console.WriteLine("{0}: {1}", res.Key, r);
            }
        }

        public void Findname()
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Console.WriteLine("Enter Your Name:");
            var word = Console.ReadLine();
            word = word.ToLower();

            int max = 0;

            foreach (char c in word)
            {
                int i;
                dict.TryGetValue(c, out i);
                i++;
                if (i > max)
                {
                    max = i;
                }
                dict[c] = i;
            }

            foreach (KeyValuePair<char, int> chars in dict)
            {
                if (chars.Value == max)
                {
                    Console.WriteLine("{0}: {1}", chars.Key, chars.Value);
                }
            }

        }
    }
}
