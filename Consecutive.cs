using System;
class Demo
{
    public static void Main(string[]args)
    {
        //Get the numbers from the user
        string a=Console.ReadLine();
        //Split the numbers into an array of integers
        int []numbers=a.Split('-');
        //Create an array of integers from the string
        int []intNumbers=new int[numbers.Length];
        for(int i=0;i<numbers.Length;i++)
        {
            int intNumbers[i]=int.Parse(numbers[i]);
        }
        //Check if numbers are consecutive
        bool isConsecutive=true;
        for(int i=1;i<intNumbers.Length;i++)
        {
            if(intNumbers[i]!=intNumbers[i-1]+1)
            {
                isConsecutive=true;
                break;
            }
        }
        //Display the result
        if(isConsecutive)
        {
            Console.WriteLine("Consecutive");
            
        }
        else
        {
            Console.WriteLine("Not Consecutive");
        }
    }
}
