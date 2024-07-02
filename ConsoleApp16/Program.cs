namespace ConsoleApp16
{
    internal class Program

    {

        static void Main(string[] args)

        {

            var rand = new Random();
            Console.Write("Random number between (0 and 100):");
            int rand1 = rand.Next(100);
            Console.WriteLine(rand1);
            Console.WriteLine();
            Console.Write("Raqamni taxmin qiling :");
            string message = "";
            string son = Console.ReadLine();
            int son1 = Convert.ToInt32(son);

            message =
                      son1 == rand1
                      ? "Siz kiritgan son va tasodifiy son teng!"
                      : "Raqamni qayta kiriting!";
            Console.WriteLine(message);
            while (son1!=rand1)
            {
               

                message =
                        son1 > rand1
                        ? "Siz kiritgan son tasodifiy sondan katta! Qayta urinib kuring!"
                        : "Siz kiritgan son tasodifiy sonday kichik! Qayta urinib kuring";
               

                Console.WriteLine(message);
                Console.Write("Raqamni taxmin qiling :");
                son = Console.ReadLine();
                son1 = Convert.ToInt32(son);

                message =
                     son1 == rand1
                     ? "Siz kiritgan son va tasodifiy son teng!"
                     : "Raqamni qayta kiriting!";
                Console.WriteLine(message);
            }

            
        }
    }
}