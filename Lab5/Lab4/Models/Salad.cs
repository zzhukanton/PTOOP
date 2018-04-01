using System.Collections.Generic;

namespace Models
{
    public class Salad
    {
        public List<Vegetable> Ingridients { get; private set; }

        public Salad()
        {
            Ingridients = new List<Vegetable>();
        }

        public Salad(List<Vegetable> food)
        {
            Ingridients = food ?? new List<Vegetable>();
        }
    }
}