using AutoMapper;
using Library.Core.Models;
using LibraryApplicastion.Models;

namespace LibraryApplicastion
{
    public class MappingModels : Profile
    {
        public MappingModels()
        {
            CreateMap<CustomerPostModel, Customer>();
            CreateMap<LoanPostModel, Loan>();
            CreateMap<CustomerPutModel, Customer>();
        }

    }
}
