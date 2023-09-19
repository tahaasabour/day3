namespace Modules
{
    public class Trainee : IComparable 
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
        public int CompareTo(object? obj)
        {
            Trainee t = obj as Trainee;
            return Id.CompareTo(t.Id);
        }

        public override string ToString()
        {
            return $"ID : {Id} , Name: {Name}";
        }

        public void AddTrainees()
        {
            Console.WriteLine("Enter a number of objects you want to add into: ");
            int x = int.Parse(Console.ReadLine());
            Trainee[] arr = new Trainee[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter name : ");
                arr[i] = new Trainee();
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("Enter ID");
                arr[i].Id = int.Parse(Console.ReadLine());

            }
        }



    }
}