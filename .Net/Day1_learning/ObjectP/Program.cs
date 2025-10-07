using ObjectP;

class Program {

    public static void Main(String[] args)
    {
        Person person = new Person();
        person._age = 1;
        person._gender = 'M';
        person._name = "Test";
        person.Daily();

        Student student = new Student();
        student.Name = "Test";
        student.Age = 18;
        student.Gender = 'M';
        student.math = 120;
        student.Chinese = 120;
        student.Geng = 120;
        student.SayHello();
        student.showScore();


    }
}