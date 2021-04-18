using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>(); 
            HashSet<string> regGuests = new HashSet<string>();            

            while (true)
            {
                string inputData = Console.ReadLine();    
                
                if (inputData == "PARTY")
                {
                    bool IsEndCome = false;

                    while (true)
                    {
                        inputData = Console.ReadLine();

                        if (inputData == "END")
                        {                           
                            IsEndCome = true;                            
                            break;
                        }

                        vipGuests.Remove(inputData);                                               
                        regGuests.Remove(inputData);                       
                    }

                    if (IsEndCome == true)
                    {
                        //break;
                        int countNotCameGuests = vipGuests.Count + regGuests.Count;
                        Console.WriteLine(countNotCameGuests);

                        if (vipGuests.Count != 0)
                        {
                            PrintRemainingGuests(vipGuests);
                        }
                        
                        if (regGuests.Count != 0)
                        {
                            PrintRemainingGuests(regGuests);
                        }                        

                        Environment.Exit(0);
                    }
                }
                else if (inputData.Length == 8)
                {
                    if (Char.IsDigit(inputData[0]) == true)
                    {
                        vipGuests.Add(inputData);
                    }
                    else
                    {
                        regGuests.Add(inputData);
                    }
                }
            }
        }

        private static void PrintRemainingGuests(HashSet<string> guests)
        {
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
