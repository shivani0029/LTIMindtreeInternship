class demo
{
    public static void main(String args[])
    {
        int sum1=0;
        int sum2=0;
        Scanner sc=new Scanner (System.in);
        int a=sc.nextInt();
        int b=sc.nextInt();
        for(int i=1;i<a;i++)
        {
            if(a%i==0)
            sum1=sum1+i;
        }
        for(int i=1;i<b;i++)
        {
            if(b%i==0)
            sum2=sum2+i;
        }
        if(sum1==a&&sum2==b)
        {
            System.out.println("Friendly pair");
        }
        else
        {
            System.out.println("Not a Friendly pair");
        }
    }
}
