using AutoMapper;
using ListOfInstitutions.DTO;
using ListOfInstitutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfInstitutions.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<School, SchoolDTO>().ReverseMap();
            CreateMap<School, CreateSchoolDTO>().ReverseMap();
        }
    }
}
