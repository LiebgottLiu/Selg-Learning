class Loop {
    static void Main(String[] args)
    {
        //exe1
        int count = 0;
        while (count <= 100) {
            Console.WriteLine("Learn harder");
            count++;
        }

        //exe2
        Console.WriteLine("Enter class people");
        int num = Convert.ToInt32(Console.ReadLine());
        int i =0 ,total = 0;
        while (i < num)
        {
            Console.WriteLine("please enter mark for {0}", i);
            int mark = Convert.ToInt32(Console.ReadLine());
            total += mark;
            i++;

        }
        int avg = total / num;
        Console.WriteLine("total mark is {0} avg mark is {1}", total, avg);

        //exe3
        
        string response = "n";
        int counts = 0;
        while (response != "y" && counts < 10) {
            Console.WriteLine("do you get it? ");
            response = Console.ReadLine();
            if (response == "y") {
                break;
            }
            Console.WriteLine("Teach again");
            counts++;
        }

        //exe4
        double num2006 = 80000;
        int year = 2006;
        while (num2006 < 200000) {
            year++;
            num2006 = num2006 * 1.25;
        }


        // do while loop 
        string ans = "";
        
        do
        {
            Console.WriteLine("you ok with this?");
            ans = Console.ReadLine();
        }
        while (ans == "no");


        // home work 1
        int j = 1;
        int totle = 0;
        while (j <= 100)
        {
            total += j;
            j++;
        }

        // home work 2
        string useInput = "";
        while (useInput != "q")
        {
            Console.WriteLine("Enter a number or quit with q");
                useInput = Console.ReadLine();
            if (useInput == "q") { 
                break ;
            }
            try
            {
                int numberInput = Convert.ToInt32(useInput);
                Console.WriteLine("number is {0}", numberInput * 2);
            }
            catch {
                Console.WriteLine("input error");
            }
                
           
            
        }
    }
}