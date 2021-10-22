using System;

namespace b_vcthncdx_vtfcgujch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            string welcome = "Gissa talet som är mellan 1-100";
            int num = rand.Next(1,100);
            Console.WriteLine(welcome);
            
 
            int i = 0;
            
            while(guess != num)
            {
                try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > num)
                            {
                                Console.WriteLine("talet är lägre");
                            }
                        else
                            {
                                Console.WriteLine("talet är högre");
                            } 
                    }

                catch
                    {
                        Console.WriteLine("retard alert det måste vara ett number");
                        i--;
                    }
                
                
                i++;
            }
            Console.WriteLine("Congrats, it took you " + i + " tries");
            Console.ReadLine();
        }
    }
}
