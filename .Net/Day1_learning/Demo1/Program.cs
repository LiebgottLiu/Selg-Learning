// See https://aka.ms/new-console-template for more information



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


    }
}