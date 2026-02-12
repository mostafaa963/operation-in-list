using System.Security.Cryptography;

List<int> list =new List<int>();
while (true)
{
    char oparation;
    Console.WriteLine("=========Main Menu========");
    Console.WriteLine($"P - Print numbers");
    Console.WriteLine($"A - Add a numbers");
    Console.WriteLine($"M - Display mean of the numbers");
    Console.WriteLine($"S - Display the smallest numbers");
    Console.WriteLine($"L - Display the Largest numbers");
    Console.WriteLine($"F - Find a numbers");
    Console.WriteLine($"C - Clear the whole a list");
    Console.WriteLine($"[a/d] - Sorting a list ascending or descending");
    Console.WriteLine($"W - Swapping to number");
    Console.WriteLine($"Q - quit");
    Console.Write(": ");
    oparation = Convert.ToChar(Console.ReadLine());
    bool exit=false;
    switch (oparation)
    {
        case 'P':
            if (list.Count > 0)
                Console.WriteLine($"[{string.Join(",", list)}]");
            else
                Console.WriteLine($"{string.Join(",", list)} the list is Empty");
            break;
        case 'A':
            Console.Write("How many  number you want added: ");
            int  count_number=Convert.ToInt32(Console.ReadLine());
            List<int> x=new List<int>();
            bool a = true;
            for (int J = 0; J < count_number; J++)
            {
                Console.Write("Enter the number to add: ");
                x.Add(Convert.ToInt32(Console.ReadLine()));
               
                for (int i = 0; i < list.Count; i++)
                {
                    if (x[J] == list[i])
                    {
                        Console.WriteLine($"the number[{x[J]}] is already added!");
                        a = false;
                        if (!false)
                        {
                            Console.Write("enter the number to add: ");
                            x[J] = Convert.ToInt32(Console.ReadLine());
                            a = true;
                            i = 0;
                        }

                    }
                }
                if (a)
                    list.Add(x[J]);
            }
            if (a)
            {
                Console.WriteLine($"[{string.Join(",",x)}] Added");
                x.Clear();
            }
            break;
        case 'M':
            double mean;
            if (list.Count == 0)
            {
                Console.WriteLine($"{string.Join(",", list)} the list is Empty");
            }
            else
            {
                double count = list.Count();
                mean = list.Sum() / count;
                Console.WriteLine($"the mean of list:{mean}");
            }
            break;
        case 'L':
            if (list.Count > 0)
            {
                int large = int.MinValue;
                for (int i = 0; i < list.Count; i++)
                {
                    if (large < list[i])
                        large = list[i];
                }
                Console.WriteLine($"Largest number: {large}");
            }
            else
                Console.WriteLine($"{string.Join(", ", list)} the list is Empty");
            break;
        case 'S':
            if (list.Count > 0)
            {
                int smal = int.MaxValue;
                for (int i = 0; i < list.Count; i++)
                {
                    if (smal > list[i])
                        smal = list[i];
                }
                Console.WriteLine($"Smalest number: {smal}");
            }
            else
                Console.WriteLine($"{string.Join(", ", list)} the list is Empty");
            break;
        case 'F':
            int f, index = 0;
            Console.Write($"Enter the number you want find it: ");
            f = Convert.ToInt32(Console.ReadLine());
            bool find = false;
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (f == list[i])
                    {
                        find = true;
                        index = i;
                        break;
                    }
                }
                if (find)
                    Console.WriteLine($"needed number  the index is  {index}");
                else
                    Console.WriteLine($"the number you want needed is not in list []");
            }
            else
                Console.WriteLine($"{string.Join(", ", list)} the list is Empty");
            break;
        case 'C':
            list.Clear();
            Console.WriteLine("the Clear is succussfully");
            break;
        case 'Q':
            exit = true;
            break;
        case 'a':
        case 'd':
            if (oparation == 'd')
            {
                for (int i = 0; i < list.Count; i++)
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[i] > list[j])
                        {
                            int temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
            }
            else {
                for (int i = 0; i < list.Count; i++)
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[i] < list[j])
                        {
                            int temp = list[j];
                            list[j] = list[i];
                            list[i] = temp;
                        }
                    }

            }
                break;
        case 'W':
            if (list.Count > 0)
            {
                Console.WriteLine($"Enter the index you want swapping between[0-{list.Count()}");
                int num = Convert.ToInt32(Console.ReadLine());
                int num1 = Convert.ToInt32(Console.ReadLine());
                num--;num1--;
                int tmp = list[num];
                list[num] = list[num1];
                list[num1] = tmp;
                Console.WriteLine("swapping successfully");
            }
            else
                Console.WriteLine($"{string.Join(",", list)} the list is Empty");
                break;
        default:
            Console.WriteLine("=====invaild Character=====");
            break;
    }
    if (exit)
        break;
}
Console.ReadKey();