class Computer
{
    public string CPU;
    public string GPU;
    public int RAM;
    public int Storage;
    public string Motherboard;
    public string Case;
    public int PowerSupply;
    public string OS;
    
    public void ShowInfo()
    {
        Console.WriteLine($"Процессор - {CPU}");
        Console.WriteLine($"Видеокарта - {GPU}");
        Console.WriteLine($"Оперативная память - {RAM} ГБ");
        Console.WriteLine($"Жесткий диск - {Storage} ГБ");
        Console.WriteLine($"Материнская плата - {Motherboard}");
        Console.WriteLine($"Корпус - {Case}");
        Console.WriteLine($"Блок питания - {PowerSupply} W");
        Console.WriteLine($"Операционная система - {OS}");
    }
}

class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder SetProcessor(string CPU)
    {
        computer.CPU = CPU;
        return this;
    }

    public ComputerBuilder SetVideoCard(string GPU)
    {
        computer.GPU = GPU;
        return this;
    }

    public ComputerBuilder SetRAM(int RAM)
    {
        computer.RAM = RAM;
        return this;
    }

    public ComputerBuilder SetStorage(int Storage)
    {
        computer.Storage = Storage;
        return this;
    }

    public ComputerBuilder SetMotherboard(string Motherboard)
    {
        computer.Motherboard = Motherboard;
        return this;
    }

    public ComputerBuilder SetCase(string Case)
    {
        computer.Case = Case;
        return this;
    }

    public ComputerBuilder SetPowerSupply(int PowerSupply)
    {
        computer.PowerSupply = PowerSupply;
        return this;
    }

    public ComputerBuilder SetOperatingSystem(string OS)
    {
        computer.OS = OS;
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}

class Program
{
    static void Main()
    {
        ComputerBuilder builder = new ComputerBuilder();
        Computer computer = builder
            .SetProcessor("AMD Ryzen 5 7600x")
            .SetVideoCard("AMD Radeon RX 7800")
            .SetRAM(32)
            .SetStorage(500)
            .SetMotherboard("Standart-ATX")
            .SetCase("Transparent")
            .SetPowerSupply(750)
            .SetOperatingSystem("Windows 11 PRO")
            .Build();
        computer.ShowInfo();
    }
}