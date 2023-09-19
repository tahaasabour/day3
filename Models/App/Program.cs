namespace Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Trainee[] tran = new Trainee[number];

            do
            {
               
                for (int i = 0; i < number; i++)
                {
                    tran[i] = new Trainee();
                   Console.WriteLine("please Enter Id");
                    tran[i].id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please Enter name");
                    tran[i].name = Console.ReadLine();

                }

                Console.WriteLine("Please Enter number agin");
                number = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref tran, number);
               
            } while (number > 0);

           

        }
      
    }
}
