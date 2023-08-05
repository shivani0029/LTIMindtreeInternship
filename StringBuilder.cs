using System;
class Demo
{
    public static void Main(string[]args)
    {
        //Get words from the user
        string input=Console.ReadLine();
        //Create a string builder to store variable names
        StringBuilder variableName=new StringBuilder();
        //Iterate over the words
        for(int i=0;i<int.Length;i++)
        {
            char currentCharacter=input[i];
            //If currentCharacter is a character add to the variableName
            if(char.IsLetter(currentCharacter))
            {
                variableName.Append(currentCharacter);
            }
            //if the character is a spcae capitalize the next character
            else if(currentCharacter==' ')
            {
                i++;
                if(i<input.Length)
                {
                    variableName.Append(char.ToUpper(input[i]));
                }
            }
            
        }
        string variableN=variableName.ToString();
        Console.WriteLine(variableN);
        
    }
}
