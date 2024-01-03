//Keep taking numbers as inputs till the user enters ‘x’, after that print sum of all.//
import java.util.Scanner;
class Demo
  {
    public static void main(String []args)
    {
     
      Scanner sc=new Scanner(System.in);
      double sum=0;
      while(true)
        {
           System.out.println("enter a number or else enter x to exit");
            string input=sc.nextLine();
            if(iput.equalIgnoreCase("x"))
      {
        break;
      }
        
      try{
        double num=Double.parseDouble(input);
        sum=sum+num;
      }
          catch(NumberFormatException e)
        {
          System.out.println("Invalid input");
        }
          System.out.println("Sum of numbers:" +sum);
        }
    }
  }
        
        
        
