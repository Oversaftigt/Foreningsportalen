﻿using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member;
using ForeningsPortalen.Website.Pages;
using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Address
{
    public class AddressIndexModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Vej navn")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Vej nummer")]
        public int StreetNumber { get; set; }

        [Display(Name = "Etage")]
        public string? Floor { get; set; }

        [Required]
        [Display(Name = "Dør, eks. th eller 2D")]
        public string? Door { get; set; }

        [Required]
        [Display(Name = "By")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postnummer")]
        public int ZipCode { get; set; }

        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]

        [Display(Name = "Nuværende beboer")]
        public IEnumerable<Guid>? CurrentMember { get; set; }
        //[Timestamp]
        //public byte[] RowVersion { get; set; }
    }
}
