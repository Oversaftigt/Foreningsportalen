using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Category : Entity
    {

        public Category()
        {

        }

        internal Category(string name, BookingDurationType durationType, int maxBookingsOfThisCategory)
        {
            Name = name;
            DurationType = durationType;
            MaxBookingsOfThisCategory = maxBookingsOfThisCategory;
        }
        //public Category(string name, BookingDurationType durationType, int maxBookingsOfThisCategory)
        //{
        //    Name = name;
        //    DurationType = durationType;
        //    MaxBookingsOfThisCategory = maxBookingsOfThisCategory;
        //}

        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }

        public bool DoesCategoryAlreadyExist()
        {
            throw new NotImplementedException();
        }

        public static Category CreateCategory(string name, BookingDurationType durationType, int maxBookingsOfThisCategory)
        {
            var newCategory = new Category(name, durationType, maxBookingsOfThisCategory);
            //Er der her vi indfører noget if sætning på om metoden DoesCategoryAlreadyExist er true eller false? 

            return newCategory;
        }
    }
}
