using ListOfInstitutions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfInstitutions.DTO
{
    
    public class CreateCountryDTO 
    {

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too Long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Name Is Too Long")]
        public string ShortName { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<School> Schools { get; set; }

    }

}
