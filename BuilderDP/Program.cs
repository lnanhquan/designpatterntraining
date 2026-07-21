//Tạo class
class Computer
{
    public string CPU;
    public int RAM;
    public string GPU;

    public void Show()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM} GB");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine("----------------------");
    }
}

//Tạo builder
class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetRAM(int ram)
    {
        computer.RAM = ram;
        return this;
    }

    public ComputerBuilder SetGPU(string gpu)
    {
        computer.GPU = gpu;
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
        Computer office = new ComputerBuilder()
            .SetCPU("Intel i3")
            .SetRAM(8)
            .Build();

        Computer gaming = new ComputerBuilder()
            .SetCPU("Intel i9")
            .SetRAM(32)
            .SetGPU("RTX 4090")
            .Build();

        office.Show();
        gaming.Show();
    }
}
