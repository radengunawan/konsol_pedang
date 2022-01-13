using System;

namespace konsol_pedang
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ngacak = new Random();
            KerusakanPedang kped = new KerusakanPedang();

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, "+
                    "3 for both, anything else to quit:");

                char kunchee = Console.ReadKey().KeyChar;

                if (kunchee != '0' && kunchee != '1' && kunchee != '2' && kunchee != '3') return;

                int roll = ngacak.Next(1, 7) + ngacak.Next(1, 7) + ngacak.Next(1, 7);

                kped.Roll = roll;
                kped.AturKeajaiban (kunchee == '1' || kunchee == '3');
                kped.AturNyalaApi (kunchee == '2' || kunchee == '3');


                Console.WriteLine("\nRolled " + roll + " for " + kped.Kerusakan + " HP\n");
            }


        }
    }
}
