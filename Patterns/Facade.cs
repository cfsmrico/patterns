namespace Patterns
{
    public class Facade
    {
        SubsystemOne one;
        SubsystemTwo two;
        SubsystemThree three;

        public Facade()
        {
            one = new SubsystemOne();
            two = new SubsystemTwo();
            three = new SubsystemThree();
        }

        public void WrapperOne()
        {
            Console.WriteLine("Invoking WrapperOne");
            one.Method();
            two.Method();
        }

        public void WrapperTwo()
        {
            Console.WriteLine("Invoking WrapperTwo");
            two.Method();
            three.Method();
        }
    }

    public class SubsystemOne
    {
        public void Method()
        {
            Console.WriteLine("invoked S1-M");
        }
    }

    public class SubsystemTwo
    {
        public void Method()
        {
            Console.WriteLine("invoked S2-M");
        }
    }

    public class SubsystemThree
    {
        public void Method()
        {
            Console.WriteLine("invoked S3-M");
        }
    }
}
