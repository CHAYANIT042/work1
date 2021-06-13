using System;

namespace test4
{
    class Program
    {
        enum Status
        {
            Low,
            Normal,
            High,
            Extreme
        }

        struct Town
        {
            public string Name;
            public int[] TownContacts;
            public Status stat;

            public Town(string name, int[] contact)
            {
                Name = name;
                TownContacts = contact;
                stat = Status.Low;
            }
        }

        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            Town[] towns = new Town[count];
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                int contactCount = Convert.ToInt32(Console.ReadLine());
                int[] contacts = new int[contactCount];
                for (int j = 0; j < contactCount; j++)
                {
                    bool isCorrect = false;
                    while (isCorrect == false)
                    {
                        int townID = Convert.ToInt32(Console.ReadLine());
                        int num = j;
                        bool valid = true;
                        if (j != 0)
                        {
                            while (num >= 0)
                            {
                                if (townID == contacts[num])
                                {
                                    valid = false;
                                    break;
                                }
                                else
                                {
                                    num--;
                                }
                            }
                            if(valid == true)
                            {
                                if(townID >= count)
                                {
                                    valid = false;
                                }
                                else if(townID == i)
                                {
                                    valid = false;
                                }
                            }
                        }
                        else
                        {
                            if (townID >= count)
                            {
                                valid = false;
                            }
                            if (townID == i)
                            {
                                valid = false;
                            }
                        }

                        if (valid == true)
                        {
                            contacts[j] = townID;
                            isCorrect = true;
                        }
                        else if(valid == false)
                        {
                            Console.WriteLine("Invalid ID.");
                        }
                    }
                }
                towns[i] = new Town(name, contacts);
            }

            bool isTrue = false;
            while(isTrue == false)
            {
                string situation = Console.ReadLine();
                if(situation == "Outbreak" || situation == "Vaccinate" || situation == "Lock down"){
                    int townID = Convert.ToInt32(Console.ReadLine());
                    if(situation == "Outbreak")
                    {
                        if((int)towns[townID].stat <= 1)
                        {
                            towns[townID].stat += 2;
                        }
                        else if((int)towns[townID].stat == 2)
                        {
                            towns[townID].stat += 1;
                        }
                        for (int k = 0; k < towns[townID].TownContacts.Length; k++)
                        {
                            if((int)towns[towns[townID].TownContacts[k]].stat <= 2)
                            {
                                towns[towns[townID].TownContacts[k]].stat += 1;
                            }
                        }
                    }
                    else if(situation == "Vaccinate")
                    {
                        towns[townID].stat = 0;
                    }
                    else if(situation == "Lock down")
                    {
                        if ((int)towns[townID].stat > 0)
                        {
                            towns[townID].stat -= 1;
                        }
                        for (int k = 0; k < towns[townID].TownContacts.Length; k++)
                        {
                            if ((int)towns[towns[townID].TownContacts[k]].stat > 0)
                            {
                                towns[towns[townID].TownContacts[k]].stat -= 1;
                            }
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("{0} {1} {2}", i, towns[i].Name, (int)towns[i].stat);
                    }
                }
                else if(situation == "Spread")
                {
                    bool canFind = false;
                    for (int j = 0; j < count; j++)
                    {
                        for (int k = 0; k < towns[j].TownContacts.Length; k++)
                        {
                            if ((int)towns[towns[j].TownContacts[k]].stat > (int)towns[j].stat)
                            {
                                canFind = true;
                                break;
                            }
                        }
                        if(canFind == true)
                        {
                            for (int l = 0; l < count; l++)
                            {
                                if ((int)towns[l].stat <= 2)
                                {
                                    towns[l].stat += 1;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("{0} {1} {2}", i, towns[i].Name, (int)towns[i].stat);
                    }
                }
                else if (situation == "Exit")
                {
                    isTrue = true;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }
}
