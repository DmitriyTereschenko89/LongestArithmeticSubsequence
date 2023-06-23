using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestArithmeticSubsequence
{
	internal class LongestArithmeticSubsequence
	{
		public int LongestArithSeqLength(int[] nums)
		{
			int n = nums.Length;
			int longestArithmeticSuseqLength = 0;
			Dictionary<int, int>[] dp = new Dictionary<int, int>[n];
			for (int i = 0; i < n; ++i)
			{
				dp[i] = new Dictionary<int, int>();
				for (int j = 0; j < i; ++j)
				{
					int difference = nums[i] - nums[j];
					dp[i][difference] = dp[j].GetValueOrDefault(difference, 1) + 1;
					longestArithmeticSuseqLength = Math.Max(longestArithmeticSuseqLength, dp[i][difference]);
				}
			}
			return longestArithmeticSuseqLength;
		}
	}
}
