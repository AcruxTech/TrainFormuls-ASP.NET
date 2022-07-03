using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Models;
using TrainFormuls.DataAccess.Models;

namespace TrainFormuls.Shared.Automapper
{
    public class MicroserviceProfile : Profile
    {
        public MicroserviceProfile()
        {
            CreateMap<QuantityRto, QuantityInformationBlo>()
                .ForMember(x => x.Symbol, x => x.MapFrom(m => m.Symbol))
                .ForMember(x => x.Title, x => x.MapFrom(m => m.Title))
                .ForMember(x => x.Description, x => x.MapFrom(m => m.Description))
                .ForMember(x => x.SectionTitle, x => x.MapFrom(m => m.SectionTitle));
        }
    }
}
