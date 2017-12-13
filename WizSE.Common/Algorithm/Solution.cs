using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace WizSE.Common.Algorithm
{

  [TestClass]
   public  class Solution
    {
       public string LongestPalindrome(string s)
       {
           var chars = s.ToCharArray();
           var results = new List<string>();


           for (var step = 1; step <=2; step++)
           {
               var endIndex = 0;
               var palindrome = s.Substring(0, step); 
               for (var startIndex = 0; startIndex < chars.Length; startIndex++)
               {
                   endIndex = startIndex + step;
                   if (endIndex >= chars.Length)
                   {
                       break;
                   }

                   if (s.Substring(startIndex, step) == s.Substring(endIndex,step))
                   {
                       palindrome += s.Substring(endIndex, step);
                       results.Add(palindrome);

                   }
                   else
                   {
                       startIndex = endIndex - 1;
                       if(startIndex+step+step>=chars.Length)
                       {
                           palindrome = s.Substring(startIndex + step, step);
                       }

                   }



               }        
           
           }

 
           return results.Last();
       
       }


      [TestMethod]
       public void TestLongestPalindrome()
       {
           var testString = "babad";
           var expected = "baba";
           var actual = LongestPalindrome(testString);
           Assert.IsTrue(expected == actual);
       
       }
    }
}
