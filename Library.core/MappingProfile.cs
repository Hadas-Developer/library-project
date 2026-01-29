using AutoMapper;
using Library.Core.DTO;
using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core
{
    public class MappingProfile : Profile
    {
        MappingProfile()
        {
            CreateMap<Loan,LoanDTO>().ReverseMap(); 
        }
    }
}
