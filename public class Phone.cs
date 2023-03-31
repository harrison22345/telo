public class Phone

{
    public int Number { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
    public Phone(int number, string model, int weight)

    {
        Number = number;
        Model = model;
        Weight = weight;
        
        static void Main()
        {
            Phone phone1 = new Phone(78934261, "KISImISSI");
            Phone phone2 = new Phone(72345677, "Sa.SU");
            Phone phone3 = new Phone(79308321, "Hopper");
        }
        
    }

    public Phone(int number, string model)

    {
        Number = number;
        Model = model;
       
    }

    public Phone()

    {
        return;   
    }


}

class Program

{
    static void Main()

    {
        Phone phone1 = new Phone(89156764245, "KISImISSI", 52);
        Console.WriteLine(ReceiveCall("Venik"));
        Console.WriteLine(GetNumber(89156764245));
        Console.WriteLine("number = {0} model = {1} weight = {2}", phone1.Number, phone1.Model, phone1.Weight);

        Phone phone2 = new Phone(89374457782, "Sa.SU", 63);
        Console.WriteLine(ReceiveCall("Sipliy"));
        Console.WriteLine(GetNumber(89374457782));
        Console.WriteLine("number = {0} model = {1} weight = {2}", phone2.Number, phone2.Model, phone2.Weight);

        Phone phone3 = new Phone(89970489673, "Hopper", 185);
        Console.WriteLine(ReceiveCall("FatBoy"));
        Console.WriteLine(GetNumber(89970489673));
        Console.WriteLine("number = {0} model = {1} weight = {2}", phone3.Number, phone3.Model, phone3.Weight);

        sendMessege(123, 456, 789, 012, 345);
    }

    public static string ReceiveCall(string name)

    {
        return name;
    }

    public static int GetNumber(int number)

    {
        return number;
    }

    string receiveCall(string name, int number)

    {
        string var = "call" + name + "number" + number;
        return var;
    }

    static void sendMessege(params int[] parameters)

    {
        foreach (int parameter in parameters)
        
        {
            Console.WriteLine(parameter);
        }
    }
}