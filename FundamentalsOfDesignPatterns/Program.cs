﻿using FundamentalsOfDesignPatterns;

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
