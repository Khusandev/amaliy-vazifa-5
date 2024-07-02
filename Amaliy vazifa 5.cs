//Basics.Tanlash bo'limi uchun 2-amaliy vazifa

//1. Vaqt kalkulyatori:
//Kirish sifatida daqiqalar sonini oladigan va uni soat:daqiqa formatida chiqaradigan dastur yozing. Misol uchun, agar foydalanuvchi 135 daqiqani kiritsa, dastur "2:15" chiqishi kerak. Hisoblash uchun arifmetik amallardan foydalaning.

namespace ConsoleApp16
{
    internal class Program

    {

        static void Main(string[] args)

        {
            Console.Write(" Daqiqalarni kiriting :");
            string vaqt = Console.ReadLine();
            int vaqt1 = Convert.ToInt32(vaqt);
            int soat = vaqt1 / 60;
            int minut = vaqt1 - soat * 60;
            Console.WriteLine($" Ayni Vaqt {soat}:{minut}");
        }
    }
}

//2.Yosh toifasini aniqlash:
//Foydalanuvchining yoshini so'ragan va uning yosh toifasini aniqlaydigan dastur yarating: "bola" (0-12 yosh), "o'smir" (13-19 yosh), "kattalar" (20-59 yosh) yoki " katta” (60 yosh) va undan katta). Bu vazifa uchun if-else iboralaridan foydalaning. 
namespace ConsoleApp16
{
    internal class Program

    {

        static void Main(string[] args)

        {
            Console.Write(" Yoshni kiriting :");
            string yosh = Console.ReadLine();
            int yosh1 = Convert.ToInt32(yosh);
            Console.Write("Yosh toifasi buyicha Natija:");
            if (yosh1 >= 0 && 12 >= yosh1) Console.Write($" Bola!");
            if (yosh1 >= 13 && 19 >= yosh1) Console.Write($" O'smir!");
            if (yosh1 >= 20 && 59 >= yosh1) Console.Write($" Kattalar!");
            if (60 <= yosh1) Console.Write($" Katta!");
        }
    }
}
//3.O'rtacha ballni hisoblash:
//Foydalanuvchidan uchta fan bo'yicha (0 dan 100 gacha) baholarni so'raydigan va ularning o'rtacha ballini hisoblaydigan dastur yozing. Keyin dastur natija haqida xabarni ko'rsatadi: "A'lo"(o'rtacha ball 80 dan 100 gacha), "Yaxshi" (o'rtacha ball 60 dan 79 gacha), "Qoniqarli"(o'rtacha ball 40 dan 59 gacha) yoki "Qoniqarsiz" ( o'rtacha ball 40 dan kam).Shartlarni tekshirish uchun ternary operatoridan foydalaning. 
//using System.Threading.Channels;

namespace ConsoleApp16
{
    internal class Program

    {

        static void Main(string[] args)

        {
            Console.Write(" 1 chi fan buyicha ballni kiriting :");
            string fan1 = Console.ReadLine();
            int fanA1 = Convert.ToInt32(fan1);
            Console.Write(" 2 chi fan buyicha ballni kiriting :");
            string fan2 = Console.ReadLine();
            int fanA2 = Convert.ToInt32(fan2);
            Console.Write(" 3 chi fan buyicha ballni kiriting :");
            string fan3 = Console.ReadLine();
            int fanA3 = Convert.ToInt32(fan3);

            Console.Write("Ortacha baho buyicha Natija:");
            double summa = (fanA1 + fanA2 + fanA3) / 3;
            string message =
                summa >= 80 && summa <= 100
                 ? " a'lo!"
                 : summa >= 60 && summa <= 79
                 ? "yaxshi!"
                 : summa >= 40 && summa <= 59
                 ? "qoniqarli"
                 : summa < 40
                 ? "ortacha ball 40 dan kam"
                 : "malumotni qata kiriting";

            Console.WriteLine($"{message} ,ortacha ball: {summa} ");
        }
    }
}
//4. "Raqamni toping" o'yini:
//1 dan 100 gacha bo'lgan tasodifiy sonni yaratadigan dastur yarating va keyin foydalanuvchidan bu raqamni taxmin qilishni so'raydi. Dastur sirli raqam foydalanuvchi kiritgan raqamdan katta yoki kichik ekanligi haqida maslahatlar berishi kerak. Ternary operatoridan va Random dan foydalaning

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
            while (son1 != rand1)
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