using System;

namespace NetCore.Questions.Array
{
    public class SecondHighestMaxima: IQuestion
    {
        public void Run()
        {
            AnswerQuestion(new int[] { 0, 1, 2, 3, 4, 5, 2, 3, 5, 6, 5 });
            AnswerQuestion(new int[] { 1, 1, 2, 3, 100000 });
            AnswerQuestion(new int[] { 100000, 100, 1 });
        }

        public void AnswerQuestion(int[] arr)
        {
            Console.WriteLine($"Finding the second highest maxima for array: [{string.Join(",", arr)}]");
            Console.WriteLine(FindSecondHighestMaxima(arr));
        }


        public int FindSecondHighestMaxima(int[] arr)
        {
            var buckets = new int[2];

            foreach(var a in arr)
            {
                buckets = TryInsert(buckets, a);
            }

            return buckets[0];
        }

        public int[] TryInsert(int[] buckets, int a)
        {
            if (buckets.Length == 0)
            {
                return new int[] { a };
            }
            else if (buckets.Length == 1)
            {
                if (buckets[0] > a)
                {
                    return new int[] { a, buckets[0]};
                }
                else
                {
                    return new int[] { buckets[0], a };
                }
            }
            else
            {
                if (a > buckets[1])
                {
                    return new int[] { buckets[1], a };
                }
                else if (a > buckets[0])
                {
                    return new int[] { a, buckets[1] };
                }
                else
                {
                    return buckets;
                }
            }
        }
    }
}