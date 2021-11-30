using ListOfInstitutions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfInstitutions.DTO
{
    public class CreateSchoolDTO
    {

        [Required]
        [StringLength(maximumLength:160, ErrorMessage ="School Name Is Too Long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength:255, ErrorMessage ="School Address Too Long.")]
        public string Address { get; set; }

        [Range(1,5)]
        public double Rating { get; set; }

       [Required]
        public int CountryId { get; set; }
    }

    public class SchoolDTO : CreateSchoolDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }

    }
}
