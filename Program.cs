using System;

namespace DNA_Replication
{
    class Program
    {
        static void Main(string[] args)
        {
            string halfDNA, repDNA;
            char ans, go;
            bool again = true;

            while (again == true)
            {
                bool going = true, correct = false;
                halfDNA = Convert.ToString(Console.ReadLine());
                if (IsvalidSequence(halfDNA))
                {
                    Console.WriteLine("Current half DNA sequence : " + halfDNA);
                    while (going == true)
                    {
                        Console.Write("Do you want to replicate it? (Y/N): ");
                        ans = Convert.ToChar(Console.ReadLine());
                        if (ans == 'Y')
                        {
                            going = false;
                            repDNA = ReplicateSequence(halfDNA);
                            Console.WriteLine("Replicated half DNA sequence: " + repDNA);
                        }
                        else if (ans == 'N')
                        {
                            going = false;
                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                while (correct == false)
                {
                    Console.Write("Do you want to process another sequence? (Y/N): ");
                    go = Convert.ToChar(Console.ReadLine());
                    if (go == 'Y')
                    {
                        again = true;
                        correct = true;
                    }
                    else if (go == 'N')
                    {
                        again = false;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                    }
                }
            }
        }

        static bool IsvalidSequence(string halfDNASequence)
        {
            foreach(char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
    }
}
