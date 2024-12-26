using System;

class ComputerNetwork
{
    protected string organizationName;
    protected int workstationCount;
    protected double averageDistance;
    public ComputerNetwork(string organizationName, int workstationCount, double averageDistance)
    {
        this.organizationName = organizationName;
        this.workstationCount = workstationCount;
        this.averageDistance = averageDistance;
    }
    public virtual double CalculateQuality()
    {
        return workstationCount * averageDistance;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Орга: {organizationName}");
        Console.WriteLine($"Раб станции: {workstationCount}");
        Console.WriteLine($"Ср.р: {averageDistance} м");
        Console.WriteLine($"Качество q: {CalculateQuality()}");
    }
}
class AdvancedComputerNetwork : ComputerNetwork
{
    private double dataTransferSpeed;
    public AdvancedComputerNetwork(string organizationName, int workstationCount, double averageDistance, double dataTransferSpeed)
        : base(organizationName, workstationCount, averageDistance)
    {
        this.dataTransferSpeed = dataTransferSpeed;
    }
    public override double CalculateQuality()
    {
        double Q = base.CalculateQuality();
        return Q * dataTransferSpeed;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Скорость передачи данных: {dataTransferSpeed} Мб/с");
        Console.WriteLine($"Качество Qp: {CalculateQuality()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите данные:");
        Console.Write("Название орги: ");
        string orgName = Console.ReadLine();
        Console.Write("Количество рабочих станций: ");
        int workstations = int.Parse(Console.ReadLine());
        Console.Write("Среднее расстояние (м): ");
        double distance = double.Parse(Console.ReadLine());
        ComputerNetwork network = new ComputerNetwork(orgName, workstations, distance);
        Console.WriteLine("\nИнфо о компьютерных сетях:");
        network.DisplayInfo();
        Console.WriteLine("\nВведите данные для компа:");
        Console.Write("Скорость передачи данных (Мб/с): ");
        double speed = double.Parse(Console.ReadLine());
        AdvancedComputerNetwork advancedNetwork = new AdvancedComputerNetwork(orgName, workstations, distance, speed);
        Console.WriteLine("\nРасширенная инфа о комп сетях:");
        advancedNetwork.DisplayInfo();
    }
}

