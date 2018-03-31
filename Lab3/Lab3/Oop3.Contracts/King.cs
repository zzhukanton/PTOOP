using System.Xml.Serialization;

namespace Oop3.Contracts
{
    [XmlType("King")]
    public class King : Person
    {
        public King(string name) : base(name)
        {
        }

        public King() : base("Henry III")
        {
        }
    }
}