namespace FundamentalsOfDesignPatterns
{
    internal class Test1
    {
        public string test1 { get; set; }

        public Test1(string test1)
        {
            this.test1 = test1;
        }

        public void Print1()
        {
            Console.WriteLine($"{test1}");
        }
    }

    internal class testref
    {
        public static void test1(ref Test1? test1)
        {
            test1.test1 = "11111";

            if (test1 == null)
            {
                Console.WriteLine("noNull");
            }
            else
            {
                Console.WriteLine(test1?.test1);
            }
        }

        public static void test2(ref Test1 test1)
        {
            test1.test1 = "11111";
            if (test1 == null)
            {
                Console.WriteLine("noNull");
                return;
            }
            else
            {
                Console.WriteLine(test1?.test1);
            }

            Console.WriteLine(test1.test1);
        }
    }

    internal class Test2 : Test1
    {
        public const string test2 = " Test2";

        public Test2(string test1) : base(test1)
        {
        }

        public void Print2()
        {
            Console.WriteLine($"{test1},{test2}");
        }
    }

    internal class Test3 : Test2
    {
        public const string test3 = " Test1";

        public Test3(string test1) : base(test1)
        {
        }

        public void Print3()
        {
            Console.WriteLine($"{test1},{test2},{test3}");
        }
    }

    internal class Test4 : Test3
    {
        public const string test4 = " Test1";

        public Test4(string test1) : base(test1)
        {
        }

        public void Print4()
        {
            Console.WriteLine($"{test1},{test2},{test3},{test4},");
        }
    }

    public class Person
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
    public class Employee : Person
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

    public static class Cast
    {
        public static Person UpCast(Employee employee)
        {
            return (Person)employee;
        }

        public static Employee DownCast(Person person)
        {
            return (Employee)person;
        }
    }
}
