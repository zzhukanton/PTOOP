namespace Models
{
    public abstract class Vegetable
    {
        public virtual string Name { get; set; }
        public virtual string FullName => GetType().Name + " " + Name;

        protected Vegetable(string name)
        {
            Name = name;
        }

        protected Vegetable() { }
    }
}
