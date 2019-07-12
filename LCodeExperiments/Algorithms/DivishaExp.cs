using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperiments.Algorithms
{
    public class DivishaExp
    {
        public int findCharCountInstring(string s, char c)
        {
            var resultCount = 0;

            var charArray = s.ToCharArray();
            foreach ( var chara in charArray)
            {
                if (c == chara)
                    resultCount++;

            }

            return resultCount;
        }
    }
}
