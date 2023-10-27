IWorker[] workers = new IWorker[3]
        {
            new Manager(),
            new Worker(),
            new Robot()
        };

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
            new Worker(),
            new Manager()
};

foreach (var eat in eats)
{
    eat.Eat();
}

interface IWorker
{
    void Work();

}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}
//Bir sınıf birden fazla interface'i implemente edebilir
class Manager : IWorker, IEat, ISalary
{
    public void Work()
    {
        Console.WriteLine("Manager can work");
    }

    public void Eat()
    {
        Console.WriteLine("Manager can eat");
    }

    public void GetSalary()
    {
        Console.WriteLine("Manager can earn salary");
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Work()
    {
        Console.WriteLine("Workers can work");
    }

    public void Eat()
    {
        Console.WriteLine("Workers can eat");
    }

    public void GetSalary()
    {
        Console.WriteLine("Workers can earn salary");
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robots can work");
    }
}