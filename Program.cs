namespace LongestArithmeticSubsequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LongestArithmeticSubsequence longestArithmeticSubsequence = new();
            Console.WriteLine(longestArithmeticSubsequence.LongestArithSeqLength(new int[] { 3, 6, 9, 12 }));
			Console.WriteLine(longestArithmeticSubsequence.LongestArithSeqLength(new int[] { 9, 4, 7, 2, 10 }));
			Console.WriteLine(longestArithmeticSubsequence.LongestArithSeqLength(new int[] { 20, 1, 15, 3, 10, 5, 8 }));
		}
	}
}