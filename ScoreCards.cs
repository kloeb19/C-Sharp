using System;

namespace ScoreCards
{
    class ScoreCards
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            String text;
            int minScore;
            int maxScore;
            int hole;
            int golfer; 
            int[] par = new int[] { 4, 3, 4, 4, 5, 4, 5, 3, 4, 4, 3, 5, 4, 4, 5, 3, 4, 5 };
            int[,] scores = new int[18, 4];

            for(int i=0; i<18; i++)
            {
                for(int j=0; j<4;j++)
                {
                    minScore = par[i] - 2;
                    maxScore = par[i] + 2;
                    scores[i, j] = rnd.Next(minScore, maxScore);
                }
            }
            for (int i = 0; i < 18; i++)

            {
                hole = i + 1;
                text = "hole" +  hole.ToString();
                for (int j = 0; j < 4; j++)
                {
                    golfer = j + 1;
                    text += " golfer " + golfer.ToString() + " " + scores[i, j].ToString();
                }

                Console.WriteLine(text);
            }
        }
    }
}
