using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dizparcpuzzle
{
 
    class Program
    {
        static void Main(string[] args)
        {

            List<int> inputList = new List<int>();
            StreamReader inputFile = new StreamReader(@"input.txt");
            // Part 1
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] arr = line.Trim().Split(',');
                foreach (var item in arr)
                {
                    inputList.Add(Convert.ToInt32(item));
                }
            }
            inputFile.Close();
            System.Console.WriteLine("--------------------------Answer part 1:---------------------------");
            System.Console.WriteLine("Resulting frequency is : {0}", inputList.Sum().ToString()); //536
            /*End Part1*/

            // Part 2

            HashSet<int> latestFrequencies = new HashSet<int>(); //Hash = unique
            int frequency = 0;
            int firstRepeatedFrequency = 0;
            bool duplicateFound = false;
            //Ny version
            while (!duplicateFound) 
            {
                foreach (var item in inputList)
                {
                    frequency += item;
                    if (latestFrequencies.Contains(frequency))
                    {
                        firstRepeatedFrequency = frequency;
                        duplicateFound = true;
                        break;
                    }
                    latestFrequencies.Add(frequency);
                }
            }

            //gamla versionen fast förbättrad
            //while (!duplicateFound)
            //{
            //    for (int i = 0; i < inputList.Count; i++)
            //    {
            //        int change = inputList[i];
            //        frequency = frequency + change;

            //        if (latestFrequencies.Add(frequency) == false) //false if freq exists
            //        {
            //            firstRepeatedFrequency = frequency;
            //            duplicateFound = true;
            //            break;

            //        }

            //        if (i == inputList.Count - 1)
            //        {
            //            i -= 1;
            //            break;
            //        }
            //    }
            //}

            System.Console.WriteLine("--------------------------Answer part 2:---------------------------");
            System.Console.WriteLine("The first repeated frequency is: {0}", firstRepeatedFrequency.ToString()); //75108
            System.Console.WriteLine("--------------------------The end----------------------------");
            ///*End part2*/





        }
    }

}

