namespace Patterns.Behavioral
{
    /// <summary>
    /// Allow an object to alter its behavior when its internal state changes
    /// </summary>
    interface State
    {
        public void Handle(Context context);
    }

    class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            this.State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }

    class ConcreteStateA : State
    {
        public void Handle(Context context)
        {
            // toggle state
            Console.WriteLine("In State A, toggling to State B");
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : State
    {
        public void Handle(Context context)
        {
            // toggle state
            Console.WriteLine("In State B, toggling to State A");
            context.State = new ConcreteStateA();
        }
    }
}
