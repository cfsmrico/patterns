using Patterns;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var s1 = Singleton.Instance();
var s2 = Singleton.Instance();

if (s1 == s2) { Console.WriteLine("First instance of Singleton is == second instance of Singleton"); }