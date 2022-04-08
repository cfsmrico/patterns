namespace Patterns
{
    /// <summary>
    /// Provide a unified interface to a set of interfaces in a subsytem.
    /// </summary>
    public class Facade
    {
        SubsystemOne one = new();
        SubsystemTwo two = new();
        SubsystemThree three = new();
        SubsystemFour four = new();
        SubsystemFive five = new();

        public Facade()
        {
        }

        public void Wrapper1()
        {
            Console.WriteLine("Invoking WrapperOne");
            one.Access();
            two.Access();
            three.Access();
        }

        public void Wrapper2()
        {
            Console.WriteLine("Invoking WrapperTwo");
            two.Access();
            four.Access();
            five.Access();
        }
    }

    public class SubsystemOne
    {
        public void Access()
        {
            Console.WriteLine("Invoked S1.Access");
        }
    }

    public class SubsystemTwo
    {
        public void Access()
        {
            Console.WriteLine("Invoked S2.Access");
        }
    }

    public class SubsystemThree
    {
        public void Access()
        {
            Console.WriteLine("Invoked S3.Access");
        }
    }

    public class SubsystemFour
    {
        public void Access()
        {
            Console.WriteLine("Invoked S4.Access");
        }
    }

    public class SubsystemFive
    {
        public void Access()
        {
            Console.WriteLine("Invoked S5.Access");
        }
    }
}
