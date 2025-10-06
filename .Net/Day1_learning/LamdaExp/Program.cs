public enum gender
{
        male,
        famale

}


class LamdaExp {

    static void Main(String[] args) { 
        Random r = new Random();

        int rNumber = r.Next(1, 10);

        const int n = 10;

        // 枚举
        gender gender = gender.male;
        int ns = (int)gender;
        string ss = gender.ToString();
        Console.WriteLine(ns);
        Console.WriteLine(ss);
        Console.ReadLine();


        string s = "0";
        Enum.Parse(typeof(gender), s);
    }

    
}