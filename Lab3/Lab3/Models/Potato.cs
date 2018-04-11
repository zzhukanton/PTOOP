using System.Xml.Serialization;

namespace Models
{
    [XmlType("Potato")]
    public class Potato : Vegetable
    {
        public Potato(string name) : base(name) { }

        public Potato() : base("Shmotato") { }
    }
}