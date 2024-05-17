using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Category : Entity
    {

        internal Category() : base(Guid.NewGuid())
        {

        }

        public Category(Guid id, string name, BookingDurationType durationType, int maxBookingsOfThisCategory) : base(id)
        {
            Name = name;
            DurationType = durationType;
            MaxBookingsOfThisCategory = maxBookingsOfThisCategory;
        }

        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }

        public bool DoesCategoryAlreadyExist()
        {
            throw new NotImplementedException();
        }
    }
}
