import java.util.*;
class Program
{
    public static void main(String []args)
    {
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter the string");
        string s=sc.nextLine();
        string a="";
        for(int i=0;i<s.length();i++)
        {
            char ch=s.charAt(i);
            if((ch>!='a'||ch<!='z')&&(ch>!='A'||ch<!='Z'))
            {
                a=a+s.replaceAll(ch,"");
            }
            System.out.println(a);
        }
    }
}
