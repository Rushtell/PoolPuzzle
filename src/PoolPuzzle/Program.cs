using System;

namespace PoolPuzzle.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();

            airplane.SetSpeed(300);

            Console.WriteLine(airplane.GetSpeed());

            Jet jepack = new Jet();

            jepack.SetSpeed(500);

            Console.WriteLine(jepack.GetSpeed());

            int count = 0;

            while (count < 4)
            {
                jepack.Accelerate();

                Console.WriteLine(jepack.GetSpeed());

                if (jepack.GetSpeed() > 5000)
                {
                    airplane.SetSpeed(airplane.GetSpeed() * 2);
                }
                else
                {
                    jepack.Accelerate();
                }
                count++;

            }

            Console.WriteLine(airplane.GetSpeed());
        }
    }
}
