using System;

namespace ProblemB
{
    public class Program
    {
		static void Main(string[] args)
		{
			int N = 11000;
			double G = 9.8;
			double[] A = new double[N + 100];

			string input = Console.ReadLine();
			while (input != null && !string.IsNullOrEmpty(input))
			{
				int i, j;
				double neginf = -1.0 / 0;
				for (i = 1; i < N; i++)
				{
					A[i] = neginf;
				}
				A[0] = 0;
				int stages = to_i(input);
				for (i = 0; i < stages; i++)
				{
					String[] vs = Console.ReadLine().Split(" ");
					int ms = to_i(vs[0]), mf = to_i(vs[1]), th = to_i(vs[2]), fc = to_i(vs[3]);
					for (j = N; j >= 0; j--)
					{
						int newm = j + ms;
						int totm = newm + mf;
						if (totm > 10000)
							continue;
						if (th / totm < G)
							continue;
						double time = 1.0 * mf / fc;
						double acc = th * (Math.Log(newm + mf) - Math.Log(newm)) / fc - time * G;
						acc = acc + A[j];
						if (acc <= A[newm + mf])
							continue;
						A[newm + mf] = acc;
					}
				}
				double mx = 0;
				for (i = 0; i < N; i++)
				{
					if (A[i] > mx)
						mx = A[i];
				}
			    Console.WriteLine(Math.Floor(mx));
				input = Console.ReadLine();
			}
			
		}
		public static int to_i(string s)
        {
			return Convert.ToInt32(s);
        }
    }
}
