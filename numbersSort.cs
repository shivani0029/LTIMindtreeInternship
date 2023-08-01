using System;
class Demo
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Enter 5 numbers");
        int []numbers=new int[5];
        bool []usedNumbers=new bool[100];
        for(int i=0;i<5;i++)
        {
            int number=Convert.ToInt32(Console.ReadLine());
            if(usedNumbers[number])
            {
                Console.WriteLine("Error Retry");
                i--;
                continue;
            }
            usedNumbers[number]=true;
            numbers[i]=number;
        }
        Array.Sort(numbers);
        for(int i=0;i<5;i++)
        {
            Console.WriteLine("The unique numbers are");
            Console.WriteLine(numbers[i]);
        }
    }
}
