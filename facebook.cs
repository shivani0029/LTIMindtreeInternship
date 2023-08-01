using System;
class Demo
{
    public static void Main(string[] args)
    {
        string names=new string[10];
        int numNames=0;
        while(true)
        {
            string name=Console.ReadLine();
            if(name=="")
            {
            break;
            }
            names[numNames]=name;
            numNames++;
        }
        if(numNames==0)
        {
            message="No one likes your post";
        }
        else if(numNames==1)
        {
            message=$"{names[0]} likes your post.";
        }
        else if(numNames==2)
        {
            message=$"{names[0]} and {names[1]} likes your post";
            
        }
        else
        {
            int otherLikes=numNames-2;
            message=$"{names[0]},{names[1]} and {otherLikes} your post."
        }
        Console.WriteLine(message);
    }
}
