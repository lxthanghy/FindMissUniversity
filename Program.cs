using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLearn
{
    class Program
    {
        int[] FindMissUniversity(int numberOfJudges, int[][] selectedContestants)
        {
            List<int> ans = new List<int>();
            int[] scores = new int[25000];
            int[] top1 = new int[25000];
            int[] top2 = new int[25000];
            for (int i = 0; i < 25000; ++i)
                scores[i] = 0;
            for (int i = 0; i < 25000; ++i)
                top1[i] = 0;
            for (int i = 0; i < 25000; ++i)
                top2[i] = 0;
            int row = selectedContestants.Length;
            int max_score_all = 0;
            for (int i = 0; i < row; ++i)
            {
                int col = selectedContestants[i].Length;
                int max_score = 3;
                for (int j = 0; j < col; ++j)
                {
                    scores[selectedContestants[i][j] - 1] += max_score;
                    if (scores[selectedContestants[i][j] - 1] > max_score_all)
                        max_score_all = scores[selectedContestants[i][j] - 1];
                    --max_score;
                    if (j == 0)
                        ++top1[selectedContestants[i][j] - 1];
                    if (j == 1)
                        ++top2[selectedContestants[i][j] - 1];
                }
            }
            int top_1 = 0;
            int top_2 = 0;
            for (int i = 0; i < 25000; ++i)
            {
                if (scores[i] == max_score_all)
                {
                    if (top1[i] > top_1)
                    {
                        ans = new List<int>();
                        ans.Add(i + 1);
                        top_1 = top1[i];
                        top_2 = top2[i];
                    }
                    else if (top1[i] == top_1)
                    {
                        if (top2[i] == top_2)
                            ans.Add(i + 1);
                        else if (top2[i] > top_2)
                        {
                            ans = new List<int>();
                            ans.Add(i + 1);
                            top_2 = top2[i];
                        }
                    }
                }
            }
            return ans.ToArray();
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
