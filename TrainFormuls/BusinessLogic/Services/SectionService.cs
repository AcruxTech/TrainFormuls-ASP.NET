using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Interfaces;
using TrainFormuls.BusinessLogic.Models;

namespace TrainFormuls.BusinessLogic.Services
{
    public class SectionService : ISectionService
    {
        public Task<bool> Add(SectionInformationBlo sectionInformationBlo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string title)
        {
            throw new NotImplementedException();
        }

        public Task<SectionInformationBlo> Get(string title)
        {
            throw new NotImplementedException();
        }

        public Task<List<SectionInformationBlo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SectionInformationBlo> Update(string title, SectionUpdateBlo sectionUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
