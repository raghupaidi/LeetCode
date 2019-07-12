using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperiments.Algorithms
{
    /* 3. Longest Substring Without Repeating Characters
     * Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
             */
    public class LongestSubString
    {
        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            
            var maxLength = 0;
            for(int i=0; i<s.Length; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = i; j < s.Length-i; j++)
                {
                    sb.Append(s.Substring(j, 1));
                    if (s.Substring(j + 1).StartsWith(sb.ToString()))
                    {
                        if (maxLength < sb.ToString().Length)
                        {
                            maxLength = sb.ToString().Length;
                        }
                        break;
                    } 
                }
            }
            return result;
        }
    }
}
