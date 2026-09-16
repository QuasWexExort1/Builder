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

        Computer gamingcomputer = builder
            .SetProcessor("AMD Ryzen 7 9800x3d")
            .SetVideoCard("RTX 4090 TI")
            .SetRAM(64)
            .SetStorage(2000)
            .SetMotherboard("Standart-ATX")
            .SetCase("RGB")
            .SetPowerSupply(1250)
            .SetOperatingSystem("Windows 11 PRO")
            .Build();

        Computer officecomputer = builder
            .SetProcessor("Intel Pentium")
            .SetVideoCard("-")
            .SetRAM(8)
            .SetStorage(1000)
            .SetMotherboard("Standart-ATX")
            .SetCase("black")
            .SetPowerSupply(350)
            .SetOperatingSystem("Windows 10 Office")
            .Build();

        Computer budgetcomputer = builder
            .SetProcessor("AMD Ryzen 5 5600x")
            .SetVideoCard("RTX 4060 ")
            .SetRAM(32)
            .SetStorage(1000)
            .SetMotherboard("Standart-ATX")
            .SetCase("black")
            .SetPowerSupply(650)
            .SetOperatingSystem("Windows 11 HOME")
            .Build();


        Console.WriteLine("=== СБОРКА КОМПЬЮТЕРА === \n 1 — Игровой компьютер \n 2 — Офисный компьютер \n 3 — Бюджетный компьютер \n 4 — Собрать самостоятельно");
        string build = Console.ReadLine();
        if (build == "1")
        {
            gamingcomputer.ShowInfo();
        }

        if ( build == "2")
        {
            officecomputer.ShowInfo();
        }
        if (build == "3")
        {
            budgetcomputer.ShowInfo();
        }
        if (build  == "4")
        {

        }

        else
        {
            Console.WriteLine();
        }



    }
}



//Console.WriteLine("Название процессора: ");
//computer.CPU
//            Console.WriteLine("Название видеокарты:");

//Console.WriteLine("Количество ГБ оперативной памяти: ");

//Console.WriteLine("Количество ГБ на жестком диске: ");

//Console.WriteLine("Название материнской платы: ");

//Console.WriteLine("Цвет корпуса: ");

//Console.WriteLine("Количество ватт на блоке питания: ");

//Console.WriteLine("Название операционной системы: ");
