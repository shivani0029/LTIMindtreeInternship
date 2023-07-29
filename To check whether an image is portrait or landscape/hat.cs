using Systems;
class hat
{
  public static void Main(String[] args)
  {
    Console.WriteLine("Enter the width");
    int w=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the height");
    int h=Convert.ToInt32(Console.ReadLine());
    if(w>h)
    {
      Console.WriteLine("image is landscape");
    }
    else
    {
      Console.WriteLine("Image is portrait");
    }
  }
}
