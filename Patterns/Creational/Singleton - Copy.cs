namespace Patterns.Creational
{
    /// <summary>
    /// Prototype specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype
    /// </summary>
    public abstract class Prototype
    {
        private string id;

        public Prototype(string id)
        {
            this.id = id;
        }
        
        public string Id { get { return id;  } }

        public abstract Prototype Clone();
    }

    public class ConcreteType1 : Prototype
    {
        public ConcreteType1(string id) : base(id) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();   // shallow copy
        }
    }

    public class ConcreteType2 : Prototype
    {
        public ConcreteType2(string id) : base(id) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();   // shallow copy
        }
    }
}
