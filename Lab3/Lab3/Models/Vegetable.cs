namespace Models
{
    public abstract class Vegetable
    {
        public string Name { get; set; }
        public string FullName => GetType().Name + " " + Name;

        protected Vegetable(string name)
        {
            Name = name;
        }

        protected Vegetable() { }
    }
}
