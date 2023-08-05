using System;
class Demo
{
    public static void Main(string[]args)
    {
        //read the path
        string path=Console.ReadLine();
        //create a stream reader object to read the text file
        StreamReader reader=new StreamReader(path);
        //read the ntire text file into a a string
        string text=reader.ReadToEnd();
        //Close the stream reader object
        reader.Close();
        //Split the text into words
        string words=tect.Split(' ');
        //count the number of words
        int count=words.Length;
        Console.WriteLine(count);
    }
}
