using Patterns;
using Patterns.Behavioral;
using Patterns.Creational;
using Patterns.Structural;

Console.WriteLine("Creational - Singleton");
Console.WriteLine("======================");
var s1 = Singleton.Instance();
var s2 = Singleton.Instance();

if (s1 == s2) { Console.WriteLine("First instance of Singleton is == second instance of Singleton"); }
Console.WriteLine();

Console.WriteLine("Structural - Facade");
Console.WriteLine("======================");
var facade = new Facade();
facade.Wrapper1();
facade.Wrapper2();
Console.WriteLine();


Console.WriteLine("Behavioral - State");
Console.WriteLine("======================");
var context = new Context(new ConcreteStateA());
context.Request();
context.Request();
context.Request();
context.Request();

Console.ReadKey();