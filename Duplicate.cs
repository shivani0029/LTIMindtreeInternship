using System;
class Demo
{
    public static void Main(string[]args)
    {
        //Get the numbers from the user
        string a=Console.ReadLine();
        //check if the input is empty
        if(a.Length==0)
        {
            return;
            
        }
        //Split the input into array of string
        int []numbers=a.Split('-');
        //Create a list to store the numbers
        List<int> numbersList=new List<int>;
        for(int i=0;i<numbers.Length;i++)
        {
            numbersList.Add(int.Parse(numbers));
        }
        //Check if they are duplicates
        bool isDuplicate=false;
        for(int i=0;i<numbersList.Count;i++)
        {
            for(int j=i+1;j<numbersList.Count;j++)
            {
                if(numbersList[i]==numbersList[j])
                {
                    isDuplicate=true;
                    break;
                }
            }
            if(isDuplicate)
            {
                break;
            }
            
        }
        if(isDuplicate)
        {
            Console.WriteLine("Duplicate");
        }
        else
        {
            Console.WriteLine("Not Duplicate");
        }
    }
}
