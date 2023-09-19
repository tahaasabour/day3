
namespace Module
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Number");
            int number=Convert.ToInt32(Console.ReadLine());
            trainee [] trans=new trainee[number];

            do
            {
                for (int i = 0; i < number; i++)
                {
                    trans[i] = new trainee();
                    Console.Write("please Enter id");
                    trans[i].Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please Enter name");
                    trans[i].Name = Console.ReadLine();
                }
                Console.WriteLine("Please Enter Number");
                 number = Convert.ToInt32(Console.ReadLine());
                
                Array.Resize(ref trans, number);    
            } while (number > 0 );
        }
    }
}
