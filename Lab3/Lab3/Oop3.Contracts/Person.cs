namespace Oop3.Contracts
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string FullName => GetType().Name + " " + Name;

        protected Person(string name)
        {
            Name = name;
        }

        protected Person()
        {
        }
    }
}
