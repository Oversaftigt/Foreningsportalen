﻿using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models
{
    public class IndexMemberModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name ="Fornavn")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Efternavn")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Email")]
        public string EmailAddress { get; set; }

        [Required]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
