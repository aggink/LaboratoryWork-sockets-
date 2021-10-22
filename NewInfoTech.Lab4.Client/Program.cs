﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NewInfoTech.Lab4.Client
{
    class Program
    {
        private const string IP = "127.0.0.1";
        private const int Port = 1213;

        private static List<String> menu = new List<string>()
        {
            "МЕНЮ:",
            "Разминка:",
            "11. Отправить с клиента 3 числа(ввести с клавиатуры), получить их возведённые в квадрат(тоже три).",
            "12. Отправить на север 2 строки (ввод с клавиатуры), получить их конкатенацию (сумму).",
            "13. Реализовать следующий протокол: Клиент отправляет серверу команду (число). Если команда == 0, сервер ожидает приёма другого числа, и возвращает квадрат этого числа. Если команда == 1, сервер ждет приема.",
            "Первые задачи:",
            "201. Ввести три числа, вывести наибольшее.",
            "202. Ввести три числа, вывести их произведение.",
            "203. Ввести три числа, вывести их квадраты.",
            "204. Ввести три числа, вывести их сумму.",
            "205. Ввести три числа, вывести их среднее, арифметическое.",
            "206. Вводить числа, пока не будет введен 0. Вернуть количество ненулевых чисел.",
            "207. Ввести три числа, вывести количество кратных трем.",
            "208. Ввести число, вывести составляющие его цифры (можно одной строкой, через запятую).",
            "209. Ввести 2 числа, вывести их произведение и сумму.",
            "210. Ввести одно число, вывести его столько же раз (ввожу 5, затем пять раз вывожу 5. Ввожу 3, затем 3 раза вывожу три ). Каждое выведенное число, отдельное сообщение от сервера.",
            "211. Ввести два числа, вывеси делится ли второе на первое без остатка.",
            "212. Ввести 4 числа, вывести две суммы –первое + второе и третье + четвертое.",
            "213. Ввести 2 числа, если первое больше второго вернуть их сумму, если нет то их квадраты.",
            "214. Ввести 2 числа, вывести их разность, и если она меньше нуля, вернуть их сумму.",
            "215. Ввести три числа, вывести их сумму.",
            "Вторые задачи:",
            "301. Ввести массив числе из Nэлементов, вывести массив их квадратов, и массив их кубов.",
            "302. Ввести массив из Nэлементов, вывести массив четных (по номеру) элементов, вывести массив нечетных (по номеру).",
            "303. Ввести массив строк из Nстрок, ввести букву. Вернуть массив строк, в которых отсутствует введённая буква.",
            "304. Ввести квадратное уравнение (три числа), решить его на сервере и вернуть два корня, или один корень или «корней нет». На клиенте вычислений не проводить!",
            "305. Ввести массив из Nчисел, если их сумма больше их количества вернуть три максимальных, если нет вернуть квадраты элементов массива.",
            "306. Ввести массив из Nчисел и Mстрок. Вернуть массив строк, как их декартово произведение. Например, числа 1, 2;строки: «мир», «труд», «май»; результат:«1 мир»,«1 труд», «1 май», «2 мир», «2 труд», «2 май».",
            "307. Ввести массив N*M, передать его на сервер и вернуть обратно.",
            "308. Ввести сгенерировать на сервере случайное число, передать на клиент. Попросить клиента ввести массив строк в размере этого числа, передать массив на сервер и вернуть конкатенацию этих строк.",
            "309. Ввести число, если оно равно 0, отправить на сервер массив из Nстрок и вернуть их конкатенацию, если не 0, отправить на сервер массив чисел и вернуть их среднее.",
            "310. Ввести строку. Отправить ее на сервер и получить массив из слов этой строки.",
            "311. Ввести три числа, отправить на сервер. Если их сумма четная, клиент должен отправить строку и получить количество символов. Если нет, клиент отправляет массив из Nсимволов и получает их сумму.",
            "312. Ввести строку, вывести количество букв и слов в ней и четные(по номеру) слова.",
            "313. Сгенерировать случайное число. Rот 1 до 20, создать массив случайных чисел от -10 до 10 и отправить его на сервер, вывести количество ненулевых элементов.",
            "Для выхода введите любое число не из нумерации меню."
        };

        static void Main(string[] args)
        {
            try
            {
                bool start = true;

                while (start)
                {
                    Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ip = new IPEndPoint(IPAddress.Parse(IP), Port);

                    // Соединяем сокет с удаленной точкой
                    socket.Connect(ip);

                    // Выводим текст меню
                    foreach(var item in menu)
                    {
                        Console.WriteLine(item);
                    }

                    // Действия с меню
                    bool type = false;
                    int typeOfCommand = 0;
                    while (!type)
                    {
                        Console.Write("Введите номер пункта меню: ");
                        type = Int32.TryParse(Console.ReadLine(), out typeOfCommand);
                    }

                    switch (typeOfCommand)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        default:
                            start = false;
                            break;
                    }

                    // Освобождаем сокет
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }

                Console.WriteLine("Программа завершена. Нажмите что-нибудь!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}