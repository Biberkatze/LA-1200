namespace Faschlsche_Wérter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test = new string[3];
            test[0] = "gagalaris";
            test[1] = "gagalaris 2";
            test[2] = "gagalaris 3";

            int counter = 0;
           
            Random number = new Random();  //random rumber
            int x = number.Next(1, 4);
            x -= 1;
            Console.WriteLine(test[x]);
            
            string eingabe = Console.ReadLine();
           
            if (eingabe == test[1])
            {
                counter++;
                Console.WriteLine("Glückwunsch");
            }

            else if (eingabe != test[1])
            {
                Console.WriteLine("versuche noch mal");
            }
        }
    }
}