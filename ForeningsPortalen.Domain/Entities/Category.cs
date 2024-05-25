﻿using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Shared;
using Microsoft.Extensions.DependencyInjection;

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
            if (services is null) throw new ArgumentNullException(nameof(services));
            if (name is null) throw new ArgumentNullException(nameof(name));

            if (IsMaxBookingOfThisCategoryValid(maxBookingsOfThisCategory) is false)
                throw new InvalidOperationException("Invalid value for MaxBookingOfThisCategory: " + maxBookingsOfThisCategory);

            var domainService = services.GetService<ICategoryDomainService>();
            if (domainService is null) throw new ArgumentNullException(nameof(domainService));
            if (DoesCategoryAlreadyExist(domainService.OtherCategoriesFromUnion(union.UnionId), name) is true)
                throw new InvalidOperationException("Category with that Name already exists");

            //the out parameter contains the bookingDurationType
            if (IsBookingDurationTypeValid(durationType, out BookingDurationType bookingDurationType) is false)
                throw new InvalidOperationException("Invalid BookingDurationType" + nameof(durationType));

            var newCategory = new Category(name, bookingDurationType, maxBookingsOfThisCategory, union);

            return newCategory;
        }

        private static bool DoesCategoryAlreadyExist(IEnumerable<Category> otherCategories, string newCategoryName)
        {
            return otherCategories.Any(x => x.Name == newCategoryName);
        }

        private static bool IsMaxBookingOfThisCategoryValid(int maxBookingOfThisCategory)
        {
            return maxBookingOfThisCategory > 0;
        }

        private static bool IsBookingDurationTypeValid(string durationType, out BookingDurationType bookingDurationType)
        {
            //checks if durationType is part of the enum BookingDurationType,
            //if it is then return true and an out parameter to get the parsed enum value
            return Enum.TryParse(durationType, true, out bookingDurationType);
        }

    }
}
