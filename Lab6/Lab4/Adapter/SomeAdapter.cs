using Models;
using UnknownModels;

namespace Adapter
{
    public class SomeAdapter : Vegetable
    {
        private readonly IUnknown _unknownVegetable;

        public SomeAdapter(string name) : base(name)
        {
            _unknownVegetable = new Nut();
        }

        public SomeAdapter()
        {
            _unknownVegetable = new Nut();
        }

        public override string FullName
        {
            get
            {
                if (_unknownVegetable == null)
                {
                    return "SomeAdapter for something unexpected";
                }

                return _unknownVegetable.GetType().Name + " " + _unknownVegetable.UnknownName;
            }
        }

        public override string Name
        {
            get
            {
                return _unknownVegetable?.UnknownName;
            }
            set
            {
                if (_unknownVegetable != null)
                {
                    _unknownVegetable.UnknownName = value;
                }
            }
        }
    }
}
