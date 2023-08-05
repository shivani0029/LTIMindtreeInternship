using System;
class Demo
{
    public static void Main(string[]args)
    {
        string inputTime=Console.ReadLine();
        if(inputTime.Length==0)
        {
            Console.WriteLine("Invalid");
            return;
        }
        int []time=inputTime.Split(':');
        if(time.Length!=2)
        {
            Console.WriteLine("Invalid");
            return;
        }
        int hour=int.Parse(time[0]);
        int minutes=int.Parse(time[1]);
        if(hour<0||hour>23)
        {
            Console.WriteLine("Invalid");
            return;
        }
        if(minutes<0||minutes>59)
        {
            Console.WriteLine("Invalid");
            return;
        }
        Console.WriteLine("Ok");
        
        
    }
}
