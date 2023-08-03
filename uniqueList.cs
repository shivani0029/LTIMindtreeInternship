using System;
class Demo
{
    public static void Main(string[] args)
    {
        //Create a list to store the unique number 
        List<int> uniqueNumbers=new List<int>;
        //Prompt the user to enter a number 
        string input=Console.ReadLine();
        //Loop until the user enters Quit
        while(input!="Quit")
        {
            //Convert the user input to integer
            int number=Convert.ToInt32(input);
            //Check if the number is already in the list 
            if(!uniqueNumbers.Contains(number))
            {
                //Add the unique numbers 
                uniqueNumbers.Add(number);
            }
            //Prompt the user to enter another number
            input=Console.ReadLine();
        }
        //Display the unique numbers
        foreach(int number in uniqueNumbers)
        {
            Console.ReadLine(number);
        }
    }
}
