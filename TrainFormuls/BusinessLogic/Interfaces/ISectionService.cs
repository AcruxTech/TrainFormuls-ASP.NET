using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Models;

namespace TrainFormuls.BusinessLogic.Interfaces
{
    public interface ISectionService
    {
        Task<bool> Add(SectionInformationBlo sectionInformationBlo);
        Task<SectionInformationBlo> Get(string title);
        Task<List<SectionInformationBlo>> GetAll();
        Task<SectionInformationBlo> Update(string title, SectionUpdateBlo sectionUpdateBlo);
        Task<bool> Delete(string title);
    }
}
