namespace Interfaces;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        //IPersonManager customerManager = new CustomerManager();

        //IPersonManager employeeManager = new EmployeeManager();

        ProjectManager projectManager = new ProjectManager();
        projectManager.Add(new InternManager());

    }

    interface IPersonManager //unimplemented operation
    {
        void Add(); 
        void Update();

    }
    //inherits - class --------------implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated!");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added!");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated!");
        }
    }


    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern added!");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated");
        }
    }

}