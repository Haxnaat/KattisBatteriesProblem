using System;
using System.Collections.Generic;

namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much number you want to Input");
            var inputCount = Convert.ToInt32(Console.ReadLine());
            string input = string.Empty;
            List<int>InputList =  new List<int>();
            for (int a = 0; a < inputCount; a++)
            {
                input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                if (num == 0)
                    break;
                else if(num > 4711)
                {
                    break;
                }
                else
                {
                    InputList.Add(num);
                }
            }

            foreach (var item in InputList)
            {
                List<int> list = new List<int>();
                list.Add(0);
                list.Add(0);
                int i = 1;
                while (list.Count - 1 < item)
                {
                    for (int j = 0; j < i; j++)
                    {
                        list.Add(i);
                    }

                    i++;
                }
                Console.WriteLine(list[item]);
            }
            
           

        }
      
    }
}
