using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Category : Entity
    {
        public Category() { }

        internal Category(string name, BookingDurationType durationType, int maxBookingsOfThisCategory, Union union)
        {
            Name = name;
            DurationType = durationType;
            MaxBookingsOfThisCategory = maxBookingsOfThisCategory;
            Union = union;
        }

        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
        public Union Union { get; set; }

        public static Category CreateCategory(string name, string durationType,
                                              int maxBookingsOfThisCategory, Union union, IServiceProvider services)
        {
            //if (services is null) throw new ArgumentNullException(nameof(services));
            //if (name is null) throw new ArgumentNullException(nameof(name));

            //if (IsMaxBookingOfThisCategoryValid(maxBookingsOfThisCategory))
            //    throw new InvalidOperationException("Invalid value for MaxBookingOfThisCategory: " + maxBookingsOfThisCategory);

            //var domainService = services.GetService<ICategoryDomainService>();
            //if (domainService is null) throw new ArgumentNullException(nameof(domainService));
            //if (DoesCategoryAlreadyExist(domainService.OtherCategoriesFromUnion(Guid.NewGuid()/*To be replaced with unionId*/), name))
            //    throw new InvalidOperationException("Categrory with that Name already exists");

            //if(durationType == )
            //var newCategory = new Category(name, durationType, maxBookingsOfThisCategory, union);
            ////Er der her vi indfører noget if sætning på om metoden DoesCategoryAlreadyExist er true eller false? 
            ////Ja
            var testCategory = new Category();

            return testCategory;
        }

        private static bool DoesCategoryAlreadyExist(IEnumerable<Category> otherCategories, string newCategoryName)
        {
            return otherCategories.Any(x => x.Name == newCategoryName);
        }

        private static bool IsMaxBookingOfThisCategoryValid(int maxBookingOfThisCategory)
        {
            return maxBookingOfThisCategory > 0;
        }

    }
}
