using System;
class secretnumber
{
    public static void Main(string[] args)
    {
        Random random=new Random();
        int snumber=random.Next(1,11);
        Console.WriteLine(snumber);
        int chances=4;
        bool won=false;
        for(int i=1;i<=chances;i++)
        {
            int guess=Convert.ToInt32(Console.ReadLine());
            if(guess==snumber)
            {
                won=true;
                
            }
        
            if(won)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You lost");
            }
        }
        
        
    }
}
