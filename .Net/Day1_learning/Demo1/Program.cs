// See https://aka.ms/new-console-template for more information



using System.Numerics;

class Demo1
{
    static void Main(string[] args)
    {
        //print functions
        Console.WriteLine("Hello, World!");
        Console.ReadKey();

        // veriable value
        //int number;
        //number = 100;

        double n = 3.14;

        string name = "Lip";
        char id = 'a';
        float me = 1.0f;

        //same class or variable 
        String s = "test";
        string ss = "test";


        double d = 36.6;
        Console.WriteLine(d);
        Console.ReadKey();

        // given value = 
        int number = 10;
        number = 5;
        if (number == 5) {
            Console.WriteLine(number);
            Console.ReadKey();
        }

        // Uisng + 
        // Console.WriteLine("Hi " + name);
        name = "Hi " + name;
        Console.WriteLine(name);
        Console.ReadKey();

        //exe 
        string k_name = "kakaxi";
        string k_location = "woden city";
        int k_age = 30;
        string k_email = "kakxi@qq.com";
        int k_salery = 2000;

        // the use of {} block hold
        // if we have 3 {} and we put two value it will have an error popup
        Console.WriteLine("My name is {0}, " , k_age);

        int age;
        age = 18;
        age = 81;


        //exchange 
        int n1 = 10;
        int n2 = 20;

        //int temp;
        //temp = n1;
        //n1 = n2;
        //n2 = temp;
        //Console.WriteLine("after exchange  n1 is {0} n2 is {1} ", n1, n2);

        n1 = n1 - n2;
        n2 = n2 + n1;
        n1 =  n2 - n1;
        Console.WriteLine("after exchange  n1 is {0} n2 is {1} ", n1, n2);
        // 保留小数 {0 ： 0.00 }


        // read user in put Console.ReadLine()
        // the infor read from user input must be a string 
        Console.WriteLine("Please entert your name");
        string userInput = Console.ReadLine();
        Console.WriteLine("Hi ",userInput);
        Console.ReadKey();


        // using /t /" /b /n \b 
        char c = '\b';

        // @ 控制只需要使用一个/  将字符串按照原格式输出

        //calculation + - * / % 二元运算符
        //exe 
        int a = 100;
        int b = 20;
        int sum = a + b;

        int r = 5;
        double pi = 3.14;
        double area = r * pi * pi;
        double perimeter = r * 2 * pi;

        int tShirt = 35;
        int trousers = 120;
        double total = 3 * tShirt + 2 & trousers;
        double dTotal = total * 0.88;

        //exe 
        int totalDay = 46;
        int week = totalDay / 7;
        int day = totalDay % 7;

        int totalSec = 107653;
        //int days = totalSec / (3600 * 24);
        //int hours = (totalSec % (3600*24)) / 3600;
        //int mins = (totalSec % (3600*24) % 3600) / 60;
        //int sec = (totalSec % (3600 * 24) % 3600) % 60;

        int days = totalSec / 86400;
        int secs = totalSec % 86400;
        int hours = secs / 3600;
        secs = secs % 3600;
        int mins = secs / 60;
        secs = secs % 60;


        //显示类型转换 （ 类型兼容）
        //int -- double  double --int (丢失精度）

        // 类型不兼容  使用 convert 功能转换
        string srt = "123";
        double l = Convert.ToDouble(s);


        Console.WriteLine("Enter a numer");
        //string strNumber = Console.ReadLine();
        l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(l * 2);
        Console.ReadKey();

        // ++ and --  一元运算符 优先级更高
        // 最终的结果都是加1， ++ 在后，先运算在加1. ++ 在前，先加1再运算
        int num = 10;
        num++;
        num--;

        //int result = 10 + num++;  //result = 20 num = 11
        //int result = 10 + ++num;    // result = 21 num =11

        int i = 5;
        int j = i++ + ++i * 2 + --i + i++;
        // j = 5 + 7*x + 6 +6 = 14+12+5 = 31 i =7

        //> < >= <= == != 
        // += -= *= /+ %= || &&

        //year jugement 
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine(b);
        }
        else 
        { 
            Console.WriteLine("not this year");
        }

        // if else exe
        Console.WriteLine("Please enter your password");
        int password = Convert.ToInt32(Console.ReadLine());
        while (password != 8888) {
            Console.WriteLine("please enter currect one");
            password = Convert.ToInt32(Console.ReadLine());
            if (password == 8888) { 
                Console.WriteLine("currect");
                Console.ReadKey();
            }
        }
    }
}