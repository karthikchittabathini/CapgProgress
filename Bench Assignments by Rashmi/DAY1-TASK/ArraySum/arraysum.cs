using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesessions
{
    public class arraysum
    {
        
        public static int CalculateArraySum(int[] input)
        {
            int answer = 0;
            for(int i = 0; i < input.Length; i++)
            {
                answer += input[i];
            }
            return answer;
        }
    }
}
