using ObjectP;

class Program {

    public static void Main(String[] args)
    {
        Person person = new Person();
        person._age = 1;
        person._gender = 'M';
        person._name = "Test";
        person.Daily();
    }
}