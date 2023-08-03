using System;
class Demo
{
    public static void Main(string[]args)
    {
        //Prompt the user to enter a list of numbers
        string input=Console.ReadLine();
        //Split the input string into a list of numbers
        string []numbers=input.Split(',');
        //Check if the list is empty or less than 5 numbers
        if(numbers.length==0||numbers.length<5)
        {
            Console.WriteLine("Invalid List");
            return;
        }
        //Create a list to store 3 smallest numbers
        List<int> smallestNumbers=new List<int>;
        for(int i=0;i<numbers.length;i++)
        {
            //Convert the number to an integer
            int number=Convert.ToInt32(numbers[i]);
            //Check if the number is one of 3 the smallest number
            if(smallestNumbers.Count<3||number<smallestNumbers[0])
            {
                //Add the number the the smallest number List
                smallestNumbers.Insert(0,number);
                //if the list is already full
                if(smallestNumbers.Count>3)
                {
                    //remove the largest number
                    smallestNumbers.RemoveAt(smallestNumbers.Count-1)
                }
            }
            
        }
        //Display the 3 smallest number
        foreach(int number in smallestNumbers)
        {
            Console.WriteLine(number);
        }
        
        
        
    }
}
