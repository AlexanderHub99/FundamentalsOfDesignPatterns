using FundamentalsOfDesignPatterns;

/*Console.WriteLine("Hello, World!");


Test1 tesst1 = new();
tesst1.Print1();

Test2 test2 = (Test2)tesst1;
test2.Print2();

Test3? test3 = tesst1 as Test3;
test3?.Print3();

if (test3 is Test2)
{
    test3.Print2();
}
else
{
    Console.WriteLine("НЕ приводиться");
}

Person tom = new Employee("Tom", "Microsoft");


tom.Print();*/


Test1 test1 = new Test1("TEST1");
Test1 test2 = test1;
test1.test1 = "Home";
test1.Print1();
test2.Print1();
Console.WriteLine("____________________________");
test1.Print1();
testref.test2(ref test1);
test1?.Print1();
testref.test2(ref test1);
test1.Print1();


Console.WriteLine("____________________________");
Employee employee = new Employee("Sasha", "Home");
Console.WriteLine($"{employee.Name},{employee.Company}");
Person Person = Cast.UpCast(employee);
Console.WriteLine($"{Person.Name}");
Person.Name = "Изменил";
Console.WriteLine($"{employee.Name},{employee.Company}");
Console.WriteLine($"{Person.Name}");
Employee employee2 = Cast.DownCast(Person);
Console.WriteLine($"{employee2.Name},{employee2.Company}");
Console.WriteLine($"{Person.Name}");
employee2.Name = "1";
Console.WriteLine($"{employee.Name},{employee.Company}");
Console.WriteLine($"{employee2.Name},{employee2.Company}");
Console.WriteLine($"{Person.Name}");

