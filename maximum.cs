using System;
class Demo
{
    public static void Main(string[]args)
    {
        
        string s=Console.ReadLine();
        int[] a=s.Split(',')Select(int.Parse).ToArray();
        int maxn=a[0];
        for(int i=0;i<a.Length;i++)
        {
            if(maxn>a[i])
            {
                maxn=a[i];
            }
        }
        Console.WriteLine(maxn);
    }
}
