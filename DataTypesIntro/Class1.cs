using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesIntro
{
    internal class Class1
    {
        
            static float GetAverageScore(int[] scores)
            {
                float average = 0;
                for (int i = 0; i < scores.Length; i++)
                {
                    average += scores[i];
                }
                average /= scores.Length;

                return average;
            }

            static int FindMax(int[] scores)
            {
                int maxValue = scores[0];

                for (int i = 1; i < scores.Length; i++)
                {
                    if (scores[i] > maxValue)
                    {
                        maxValue = scores[i];

                    }
                }

                return maxValue;
            }

            static int FindMin(int[] scores)
            {
                int minValue = scores[0];

                for (int i = 1; i < scores.Length; i++)
                {
                    if (scores[i] < minValue)
                    {
                        minValue = scores[i];

                    }
                }

                return minValue;
            }

            static void Main(string[] args)
            {
                int[] scoresFirst = { 9, 10, 8, 9, 7, 8, 6, 8, 9, 10 };

                float average = GetAverageScore(scoresFirst);

                int min = FindMin(scoresFirst);

                int max = FindMax(scoresFirst);

                Console.WriteLine("Average score of student No. 1:  " + average);

                Console.WriteLine("Minimum grade of student No. 1:  " + min);

                Console.WriteLine("Maximum grade of student No. 1:  " + max);

                int[] scoresSecond = { 8, 10, 9, 9, 10, 8, 2, 8, 3, 3 };

                average = GetAverageScore(scoresSecond);

                min = FindMin(scoresSecond);

                max = FindMax(scoresSecond);

                Console.WriteLine("Average score of student No. 2:  " + average);

                Console.WriteLine("Minimum grade of student No. 2:  " + min);

                Console.WriteLine("Maximum grade of student No. 2:  " + max);

                int[] scoresThird = { 9, 9, 9, 9, 10, 10, 10, 8, 8, 3 };

                average = GetAverageScore(scoresThird);

                min = FindMin(scoresThird);

                max = FindMax(scoresThird);

                Console.WriteLine("Average score of student No. 3:  " + average);

                Console.WriteLine("Minimum grade of student No. 3:  " + min);

                Console.WriteLine("Maximum grade of student No. 3:  " + max);


                int[] scoresFourth = { 8, 8, 9, 6, 10, 6, 2, 7, 3, 7 };

                average = GetAverageScore(scoresFourth);

                min = FindMin(scoresFourth);

                max = FindMax(scoresFourth);

                Console.WriteLine("Average score of student No. 4:  " + average);

                Console.WriteLine("Minimum grade of student No. 4:  " + min);

                Console.WriteLine("Maximum grade of student No. 4:  " + max);

                int[] scoresFifth = { 9, 10, 9, 9, 6, 8, 6, 8, 3, 3 };

                average = GetAverageScore(scoresFifth);

                min = FindMin(scoresFifth);

                max = FindMax(scoresFifth);

                Console.WriteLine("Average score of student No. 5:  " + average);

                Console.WriteLine("Minimum grade of student No. 5:  " + min);

                Console.WriteLine("Maximum grade of student No. 5:  " + max);
            }

        }

  }

