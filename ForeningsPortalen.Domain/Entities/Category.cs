using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Category : Entity
    {

        internal Category()
        {

        }

        public Category(string name, BookingDurationType durationType, int maxBookingsOfThisCategory)
        {
            Name = name;
            DurationType = durationType;
            MaxBookingsOfThisCategory = maxBookingsOfThisCategory;
        }

        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }

        public bool DoesCategoryAlreadyExist()
        {
            throw new NotImplementedException();
        }
    }
}
