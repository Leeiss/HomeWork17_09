using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashnee_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков 2.1 приветствие");
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("Тумаков 2.2 деление");
            Console.WriteLine("Введите делимое: ");
            int chislo_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель: ");
            int chislo_2 = int.Parse(Console.ReadLine());
            if (chislo_2 == 0)
            {
                Console.WriteLine("Ошибка, на 0 делить нельзя");
            }
            else
            {
                double div = chislo_1 / chislo_2;
                Console.WriteLine($"Результат деления чисел: {div}");
            }
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Тумаков 2.1дз вывод следующей буквы");
            Console.WriteLine("Введите букву латинского алфавита: ");
            Console.WriteLine("Следующая за этой буква латинского алфавита: " + Convert.ToChar(Convert.ToInt32(Convert.ToChar(Console.ReadLine())) + 1));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Тумаков 2.2дз решение квадратного уравнения");
            Console.WriteLine("Введите коэффициенты a,b,c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Корни уравнения: ");
            if (D > 0)
            {
                Console.WriteLine("x1= " + ((-b) + Math.Sqrt(D) / 2 * a));
                Console.WriteLine("x1= " + ((-b) - Math.Sqrt(D) / 2 * a));
            }
            if (D == 0)
            {
                Console.WriteLine("x1= " + ((-b) + Math.Sqrt(D) / 2 * a));
            }
            if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("1 задание, вывод числа Е");
            double x = Math.E;
            Console.WriteLine("Число Е, округленное до десятых: " + (x - x % 0.01));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("2 задание, вывод числа одно за другим");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("3 задание, вывод чисел столбиком");
            Console.WriteLine("Введите 4 числа:");
            int ch1 = int.Parse(Console.ReadLine());
            int ch2 = int.Parse(Console.ReadLine());
            int ch3 = int.Parse(Console.ReadLine());
            int ch4 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(ch4);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("4 задание, прибавление 10");
            Console.WriteLine("Введите число");
            int aa = int.Parse(Console.ReadLine()) + 10;
            Console.WriteLine("x+10=" + aa);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("5 задание, периметр квадрата");
            Console.WriteLine("Введите сторону квадрата: ");
            int storona = int.Parse(Console.ReadLine());
            int per = 4 * storona;
            Console.WriteLine("Периметр квадрата = " + per);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("6 задание длина и площадь окружности");
            Console.WriteLine("Введите радиус окружности: ");
            int rad = int.Parse(Console.ReadLine());
            double pi = Math.PI;
            Console.WriteLine("Длина откужности равна " + 2 * pi * rad);
            Console.WriteLine("Площадь окружности равна " + pi * rad * rad);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("7 задание найти занчение косинуса");
            Console.WriteLine("Введите занчение х: ");
            int xx = int.Parse(Console.ReadLine());
            Console.WriteLine("Сosx = " + Math.Cos(xx));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("8 задание найти периметр равнобедренной трапеции");
            Console.WriteLine("Введите значение верхнего основания равнобедренной трапеции: ");
            double osnovanie1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение нижнего основания равнобедренной трапеции: ");
            double osnovanie2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение высоты равнобедренной трапеции: ");
            double visotat = double.Parse(Console.ReadLine());
            double bok = Math.Sqrt((osnovanie2 - osnovanie1) / 2) * ((osnovanie2 - osnovanie1) / 2) + (visotat * visotat);
            Console.WriteLine("Периметр равнобедренной трапеции равен " + 2 * bok + osnovanie1 + osnovanie2);
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("9 задание печенье яблоки конфеты");
            Console.WriteLine("Введите стоимость печенья за кг: ");
            double pech = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость яблок за кг: ");
            double apple = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость конфет за кг: ");
            double sweet = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес печенья, яблок и конфет: ");
            double st1 = double.Parse(Console.ReadLine());
            double st2 = double.Parse(Console.ReadLine());
            double st3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Общая стоимость покупки: " + pech * st1 + apple * st2 + sweet * st3);
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("10 задание, мир труд май");
            Console.WriteLine("Мир" + " " + "Труд" + " " + "Май");
            Console.WriteLine("Мир" + "\n" + "  " + "Труд" + "\n" + "      " + "Май");
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("11 задание поменять местами числовые переменные");
            Console.WriteLine("Введите 2 числовые переменные");
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            Console.WriteLine($"{two}{one}");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("12 задание подсчет периметра и площади фигур");
            Console.WriteLine("Выберите фигуру(треугольник, четырехугольник, окружность)");
            string figura = Console.ReadLine();
            if ((figura == "треугольник") || (figura == "Треугольник"))
            {
                Console.WriteLine("Введите значение высоты треуголника: ");
                double H = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение основания треугольника: ");
                double osn = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение 1 боковой стороны треугольника: ");
                double bok1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение 2 боковой стороны треугольника: ");
                double bok2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь треугольника равна " + osn * H / 2);
                Console.WriteLine("Периметр треугольника равен " + osn + bok1 + bok2);
            }
            if ((figura == "четырехугольник") || (figura == "Четырехугольник"))
            {
                Console.WriteLine("Введите значения сторон четырехугольника: ");
                double a11 = double.Parse(Console.ReadLine());
                double a22 = double.Parse(Console.ReadLine());
                double a33 = double.Parse(Console.ReadLine());
                double a44 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значения диагоналей четырехугольника: ");
                double dig1 = double.Parse(Console.ReadLine());
                double dig2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значениe угла между диагоналями: ");
                double ugol = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь четырехуголника равна " + dig1 * dig2 * Math.Sin(ugol) / 2);
                Console.WriteLine("Периметр четырехуголника равен" + a11 + a22 + a33 + a44);
            }

            if ((figura == "окружность") || (figura == "Окружность"))
            {
                Console.WriteLine("Введите значение радиуса окружности: ");
                double R = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь окружности равна " + pi * R * R);
                Console.WriteLine("Периметр окружности равен " + 2 * pi * R);

            }
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("13 задание введение числа");
            Console.WriteLine("Введите число: ");
            int chisloo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {chisloo}");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("14 задание вывод на экран информации");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("15 задание рандомные числа столбиком");
            Random rnd = new Random();
            int ch11 = rnd.Next(0, 1000);
            int ch22 = rnd.Next(0, 1000);
            int ch33 = rnd.Next(0, 1000);
            int ch44 = rnd.Next(0, 1000);
            Console.WriteLine(ch11);
            Console.WriteLine(ch22);
            Console.WriteLine(ch33);
            Console.WriteLine(ch44);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("16 задание нахождение корней квадратного уравнения");
            Console.WriteLine("Введите коэффициенты a,b,c: ");
            double a_1 = double.Parse(Console.ReadLine());
            double b_1 = double.Parse(Console.ReadLine());
            double c_1 = double.Parse(Console.ReadLine());
            double DDD = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Корни уравнения: ");
            if (D > 0)
            {
                Console.WriteLine("x1= " + ((-b) + Math.Sqrt(D) / 2 * a_1));
                Console.WriteLine("x1= " + ((-b) - Math.Sqrt(D) / 2 * a_1));
            }
            if (D == 0)
            {
                Console.WriteLine("x1= " + ((-b) + Math.Sqrt(D) / 2 * a));
            }
            if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("17 задание нахождение ср арифметического и геометрического");
            Console.WriteLine("Введите 2 целых числа:");
            int chiislo1 = int.Parse(Console.ReadLine());
            int chiislo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое равно " + (chiislo1 + chiislo2) / 2);
            Console.WriteLine("Стреднее геометрическое равно " + Math.Sqrt(chiislo1 * chiislo2));
            Console.ReadKey();
            Console.WriteLine();



            Console.WriteLine("18 задание нахождение расстояния между точками");
            Console.WriteLine("Введите координаты х и у первой точки");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты х и у второй точки");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между этими точками равно " + Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("19 задание обмен значениями a, b,c");
            Console.WriteLine("Введите значения a,b,c");
            int aaa = int.Parse(Console.ReadLine());
            int bbb = int.Parse(Console.ReadLine());
            int ccc = int.Parse(Console.ReadLine());
            Console.WriteLine($"Пункт А: b={ccc},a={bbb},c={aaa}");
            Console.WriteLine($"Пункт В: b={aaa}, c={bbb},a={ccc} ");
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("20 задание задача про сутки");
            Console.WriteLine("Введите количество секунд: ");
            int sek = int.Parse(Console.ReadLine());
            Console.WriteLine("Полных часов с начала сток прошло " + sek / 60 * 60);
            Console.WriteLine("Полных минут с начала очередного час прошло " + ((sek / 60) - ((sek / 60) / 60) * 60));
            Console.WriteLine("Секунд с начало последней минуты прошло " + sek % 60);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("21 задание разрезание прямоугольника ");
            Console.WriteLine("Если дан прямоугольник размером 543х130, то  квадратов размером 130х130 можно от него отрезать" + 543 / 130);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("22 задание зачеркивание цифры и приписывание в начало");
            Console.WriteLine("Введите трехзначное число: ");
            int tr_ch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tr_ch % 10}{tr_ch / 10}");
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("23 задание количество сотен и тычяч в четырехзначном числе");
            Console.WriteLine("Введите четырехзначное число: ");
            int tr_ch1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество сотен: " + (tr_ch1 / 100) % 10);
            Console.WriteLine("Количество тысяч: " + (tr_ch1 / 1000));
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("24 задание перестановка чисел ");
            Console.WriteLine("Введите четырезначное число, большее 999");
            string tr_ch2 = Console.ReadLine();
            char[] ch = tr_ch2.ToCharArray();
            Console.WriteLine($"Число при прочтении спарва налево: {tr_ch2[3]}{tr_ch2[2]}{tr_ch2[1]}{tr_ch2[0]}");
            Console.WriteLine($"Число при перестановке 1 и 2, 3 и 4 цифр: {tr_ch2[1]}{tr_ch2[1]}{tr_ch2[3]}{tr_ch2[2]}");
            Console.WriteLine($"Число при пестановке 2 и 3 цифр: {tr_ch2[0]}{tr_ch2[2]}{tr_ch2[1]}{tr_ch2[3]}");
            Console.WriteLine($"Число при перестановке первых двух и последних цифр: {tr_ch2[2]}{tr_ch2[3]}{tr_ch2[0]}{tr_ch2[1]}");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("25 задание задача ");
            Console.WriteLine("Введите число n в интервале от 100 до 999 включительно: ");
            string NN = Console.ReadLine();
            if ((int.Parse(NN) / 10) % 10 == 0)
            {
                Console.WriteLine("Данное число не подходит");
            }
            else
            {
                Console.WriteLine("x= " + NN[1] + NN[2] + NN[0]);
            }
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("26 задача определение угла");
            Console.WriteLine("Введите час, минуту и секунду");
            int chas = int.Parse(Console.ReadLine());
            int minuta = int.Parse(Console.ReadLine());
            int sekunda = int.Parse(Console.ReadLine());
            Console.WriteLine("Угол между стрелкой в начальный момент суток и в нынешний составляет " + chas * 30 + minuta * 0.5 + sekunda * 0.0083 + " градусов");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("28 наибольшее по модулю число");
            Console.WriteLine("Введите 3 числа:");
            int aaaa = int.Parse(Console.ReadLine());
            int bbbb = int.Parse(Console.ReadLine());
            int cccc = int.Parse(Console.ReadLine());
            int Aa = Math.Abs(aaaa);
            int Bb = Math.Abs(bbbb);
            int Cc = Math.Abs(cccc);
            Console.WriteLine("Наименьшее по модулю число" + Math.Min(Math.Min(Aa, Bb), c));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Задание 29 сумма минимального и максимального");
            Console.WriteLine("Введите 3 числа: ");
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double max = Math.Max(Math.Max(a, b), c);
            double min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Сумма минимального и максимального значений равна " + max + min);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Задание 30 нахождение количества делителей");
            Console.WriteLine("Введите число: ");
            int vvedennoe = int.Parse(Console.ReadLine());
            int Result = 0;
            for (int i = 1; vvedennoe >= i + 1; i++)
            {
                if (vvedennoe % i == 0)
                {
                    Result++;
                }

            }
            Console.WriteLine($"Количество делителей для данного числа равно {Result}");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Задание 31 решение кубических уравнений");
            Console.WriteLine("Введите значения коэффициентов а,b,c,d: ");
            int koif_1 = int.Parse(Console.ReadLine());
            int koif_2 = int.Parse(Console.ReadLine());
            int koif_3 = int.Parse(Console.ReadLine());
            int koif_4 = int.Parse(Console.ReadLine());
            for (int koren = -100; koren <= 100; koren++)
            {
                if (koif_1 * Math.Pow(koren, 3) + koif_2 * Math.Pow(koren, 2) + koif_3 * koren + koif_4 == 0)
                {
                    Console.WriteLine("Корень уравнения равен " + koren);
                }
                else
                {
                    Console.WriteLine("Это кубическое уранение не имеет действительного корня");
                }
            }
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("32 элемент прогрессии по номеру ");
            Console.WriteLine("Введите целое число ");
            Console.WriteLine("Введите первый элемент последовательности:");
            double elem_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент последовательности:");
            double elem_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности:");
            double nomer = double.Parse(Console.ReadLine());
            Console.WriteLine("Член прогрессии равен " + elem_1 + (elem_2 - elem_1) * (nomer - 1));

            Console.WriteLine("33 кредит");
            Console.WriteLine("Являеетесь ли вы пенсионером? да/нет");
            string pens = Console.ReadLine();
            Console.WriteLine("Являеетесь ли вы cтудентом? да/нет");
            string stud = Console.ReadLine();
            Console.WriteLine("Вы трудоустроены? да/нет");
            string trud = Console.ReadLine();
            if (pens == "да")
            {
                if (trud == "нет")
                {
                    Console.WriteLine("Поздравляю! Вам одобрен кредит!");
                }
                else
                {
                    Console.WriteLine("К сожалению, Вам не одобрен кредит");
                }
            }
            if (stud == "да")
            {
                if (trud == "нет")
                {
                    Console.WriteLine("Поздравляю! Вам одобрен кредит!");
                }
                else
                {
                    Console.WriteLine("К сожалению, Вам не одобрен кредит");
                }
            }
            if (pens == "да")
            {
                if (stud == "да")
                {
                    Console.WriteLine("К сожалению, Вам не одобрен кредит");
                }

            }
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("34 имя");
            Console.WriteLine("Как тебя зовут? ");
            string namee = Console.ReadLine();
            Console.WriteLine($"{namee}");
            string namee2 = Console.ReadLine();
            Console.WriteLine($"Привет,{namee2}");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("35 задание Гарри и дневник тома Реддла");
            Console.WriteLine("Поздоровайтесь с консолью");
            string privet = Console.ReadLine();
            Console.WriteLine("Как Вас зовут?");
            string imia = Console.ReadLine();
            Console.WriteLine($"Привет,{imia}");
            Console.WriteLine("Cпросите о тайной комнате)");
            string vopros = Console.ReadLine();
            Console.WriteLine("да");
            Console.WriteLine("Попросите рассказать о тайной комнате");
            string prosba = Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать..");
            Random color = new Random();
            Console.BackgroundColor = (ConsoleColor)color.Next(0, 16);
            Console.ReadKey();
            Console.WriteLine();



        }
    }
}
