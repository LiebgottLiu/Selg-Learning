class ForLoop {
    static void Main(String[] args) {
        //for loop exe 1 
        for (int i = 100; i <= 999; i++)
        {
            int handers = 1 / 100;
            int tens = i % 100 / 10;
            int ge = i % 10;

            if (handers * handers * handers + tens * tens * tens + ge * ge * ge == i)
            {
                Console.WriteLine(i);
            }
        }


        //exe 2 乘法口诀

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                int sums = i * j;
                Console.Write("{0}*{1} is {2} \t", i, j, sums);
            }
            Console.Write("\n");

        }

        Console.ReadKey();



        //使用convert转换 实际调用int.Parse
        //int number = int.Parse("123");
        //number = Convert.ToInt32("123");


        int number = 0;
        bool b = int.TryParse("123",out number);


        //for loop exe 1 
        int sum = 0;
        bool x = true;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter the age of {0} people", i);
            try
            {
                int ages = int.Parse(Console.ReadLine());
                if (ages < 0 || ages > 100)
                {
                    Console.WriteLine("Error");
                    x = false;
                    break;
                }
                else
                {
                    sum += ages;

                }
            }
            catch
            {
                Console.WriteLine("you should input number");
                x = false;
            }



        }
        if (x)
        {
            Console.WriteLine("average age is {0}", sum / 5);
        }



        // exe2
        string name = "";
        string password = "";
        while (true)
        {
            Console.WriteLine("enter user name");
            name = Console.ReadLine();

            Console.WriteLine("Enter password");
            password = Console.ReadLine();

            if (name == "admin" && password == "88881")
            {
                Console.WriteLine("login");
                break;
            }
            else
            {
                Console.WriteLine("in currect");
            }
        }

        //exe 3
        int sum1 = 0;
        for (int i = 0; i <= 100; i++)
        {
            if (i % 7 == 0)
            {
                continue;

            }
            else
            {
                sum1 += i;
            }
        }

        //素数 只能被1和数字本身整除的数字
        
        for (int i = 2; i <= 100; i++) {
            bool is_num = true;
            for (int j = 2; j < i-1; j++) {
                //出尽了 说明就是质数
                if (i % j == 0)
                {
                    is_num = false;
                    break;
                }
                
            }
            if (is_num) {
                Console.WriteLine(i);
            }
            
        }
        Console.ReadKey();

    }
} 