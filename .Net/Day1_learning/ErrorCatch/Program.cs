class ErrorCatch {
    static void Main(String[] args) {
        Console.WriteLine("Enter a numer ");
        int num = 0 ;
        bool b = true ;
        try{
            num = Convert.ToInt32(Console.ReadLine());
            
        
        }catch{
            Console.WriteLine("not a number please reenter");
            b = false ;

        }

        if (b) {
            Console.WriteLine(num * 2);
        }



        // switch 
        int salery = 25000;
        Console.WriteLine("enter working level");
        string level = Console.ReadLine() ;

        switch (level) {
            case  "a":
                salery += 500;
                break;

            default:
                salery -= 500;
                Console.WriteLine("remove 500 from salery");
                break;
        }

        //exe
        Console.WriteLine("Enter a name");
        string name = Console.ReadLine() ;
        switch (name) {
            case "Lip":
                Console.WriteLine("Lip was a great rich people");
                break;
            case "Jiao":
                Console.WriteLine(" Jiao was a great people too");
                break;

            default : Console.WriteLine("something went worrn");
                break;
        }
            
        // If else 
        Console.WriteLine("Enter a mark");
        int scoure = Convert.ToInt32(Console.ReadLine());
        //if (scoure >= 90) {
        //    Console.WriteLine("A");
        //} else if (scoure >= 80 && scoure < 90) {
        //    Console.WriteLine("B");
        //}
        //else if (scoure >= 70 && scoure < 980)
        //{
        //    Console.WriteLine("C");
        //}
        //else if (scoure >= 60 && scoure < 70)
        //{
        //    Console.WriteLine("D");
        //}
        //else {
        //    Console.WriteLine("E");
        //}

        switch (scoure) {
            case >= 90:
                Console.WriteLine("A"); 
                break;
            case  >=80:
                Console.WriteLine("B");
                break;
            case >= 70:
                Console.WriteLine("C");
                break;
            case >= 60:
                Console.WriteLine("D");
                break;
            default:
                Console.WriteLine("E");
                break;

        }
        


        //exe 
        Console.WriteLine("Enter a year");
        int years = 0;
        int months = 0;
        int days = 0;
        try {  years = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Enter a month");
            try { months = Convert.ToInt32(Console.ReadLine());
                if (months >= 1 && months <= 12)
                {

                    days = 0;
                    switch (months)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            days = 31;
                            break;
                        case 2:
                            if (years % 400 == 0 || (years % 100 != 0 && years % 4 == 0))
                            {
                                days = 29;
                            }
                            else
                            {
                                days = 28;

                            }
                            break;
                        default:
                            days = 30;
                            break;
                    }
                    Console.WriteLine("{0}Year {1} month have {2} day", years, months, days);
                }
                else {
                    Console.WriteLine("Month should between 1 - 12");
                }

            }

            catch {
                Console.WriteLine("month error");
            }


        }
        
        catch {
            Console.WriteLine("yeasr error");
        }
        
       

        
        Console.ReadKey();





    }
}