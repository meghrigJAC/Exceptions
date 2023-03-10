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


            try
            {
                Console.Write("How many scores will you enter? ");
                inValue = Console.ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Console.Write("Enter score {0}: ", i + 1);
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += i;
                }

                averageTestScore = totalScores / countOfScores;
                Console.WriteLine("Average is {0}", averageTestScore);
            }
            catch (Exception e)
            {
                //TODO
            }
            //add a finally

            ReadKey();

        }
    }
}