using System;

namespace ConsoleApp7
{
    enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }

    struct Problem
    {
        public string Message;
        public int Answer;

        public Problem(string message, int answer)
        {
            Message = message;
            Answer = answer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Difficulty level = Difficulty.Easy;
            Problem[] problems = GenerateRandomProblems(3);
            int go = 0, ans;
            bool running = true;
            long startTime, endTime, totalTime;
            double score = 0;

            while (running)
            {
                Console.WriteLine("Score: {0:R}, Difficulty: {1}", score, level);
                go = Convert.ToInt32(Console.ReadLine());
                switch (go)
                {
                    case 0:
                        if ((int)level == 0)
                            problems = GenerateRandomProblems(3);
                        else if ((int)level == 1)
                            problems = GenerateRandomProblems(5);
                        else if ((int)level == 2)
                            problems = GenerateRandomProblems(7);

                        double point = 0;
                        double rightAns = 0, amount = problems.Length;
                        int levelNum = (int)level;

                        startTime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        for (int i = 0; i < amount; i++)
                        {
                            Console.WriteLine(problems[i].Message);
                            ans = Convert.ToInt32(Console.ReadLine());
                            if (ans == problems[i].Answer)
                                rightAns += 1;
                        }
                        endTime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        totalTime = endTime - startTime;
                        point = (rightAns / amount) * (25 - Math.Pow(levelNum, 2) / (Math.Max(totalTime, (25 - Math.Pow(levelNum, 2))))) * Math.Pow((2 * levelNum) + 1, 2);
                        score += point;
                        break;

                    case 1:
                        bool inValid = true;
                        int setting;
                        while (inValid)
                        {
                            setting = Convert.ToInt32(Console.ReadLine());
                            switch (setting)
                            {
                                case 0:
                                    level = Difficulty.Easy;
                                    inValid = false;
                                    break;
                                case 1:
                                    level = Difficulty.Normal;
                                    inValid = false;
                                    break;
                                case 2:
                                    level = Difficulty.Hard;
                                    inValid = false;
                                    break;
                                default:
                                    Console.WriteLine("Please input 0-2.");
                                    break;
                            }
                        }
                        break;

                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please input 0-2.");
                        break;
                }
            }
        }

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                        new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                        new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }
    }
}
