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
Console.WriteLine();


Console.WriteLine("Creational - Prototype");
Console.WriteLine("======================");
var p1 = new ConcreteType1("I");
var c1 = (ConcreteType1)p1.Clone();
Console.WriteLine("Cloned: {0}", c1.Id);
var p2 = new ConcreteType1("II");
var c2 = (ConcreteType1)p2.Clone();
Console.WriteLine("Cloned: {0}", c2.Id);



Console.ReadKey();
