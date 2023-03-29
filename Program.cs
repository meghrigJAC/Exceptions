namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;
            int numberOfScores = 0;

            
                Console.Write("How many scores will you enter? ");
                inValue = Console.ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Console.Write($"Enter score {i + 1} ");
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += i;
                }

                averageTestScore = totalScores / numberOfScores;
                Console.WriteLine("Average is {0}", averageTestScore);   

        }
    }
}