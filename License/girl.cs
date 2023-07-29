using System;
class girl
{
    public static void Main(string[] args)
    {
        int demerit;
        Console.WriteLine("Enter the speed limit");
        int sl=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the speed");
        int s=Convert.ToInt32(Console.ReadLine());
        if(s<=sl)
        {
            Console.WriteLine("OK");
        }
        else
        {
            demerit=(s-sl)/5;
            Console.WriteLine(demerit);
            if(demerit>12)
            {
                Console.WriteLine("License suspended");
            }
        }
    }
}
