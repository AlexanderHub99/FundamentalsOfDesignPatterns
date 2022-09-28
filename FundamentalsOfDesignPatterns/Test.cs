namespace FundamentalsOfDesignPatterns
{
    internal class Test1
    {
        public  const string test1 = " Test1";
        public void Print1()
        {
            Console.WriteLine($"{test1}");
        }
    }

    internal class Test2 : Test1
    {
        public const string test2 = " Test2";
        public void Print2()
        {
            Console.WriteLine($"{test1},{test2}");
        }
    }

    internal class Test3 : Test2
    {
        public const string test3 = " Test1";
        public void Print3()
        {
            Console.WriteLine($"{test1},{test2},{test3}");
        }
    }

    internal class Test4 : Test3
    {
        public const string test4 = " Test1";

        public void Print4()
        {
            Console.WriteLine($"{test1},{test2},{test3},{test4},");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }
}
