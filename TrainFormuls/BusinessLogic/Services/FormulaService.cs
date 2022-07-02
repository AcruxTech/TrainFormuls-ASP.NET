using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Interfaces;
using TrainFormuls.BusinessLogic.Models;

namespace TrainFormuls.BusinessLogic.Services
{
    public class FormulaService : IFormulaService
    {
        public Task<bool> Add(FormulaInformationBlo formulaInformationBlo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string title)
        {
            throw new NotImplementedException();
        }

        public Task<FormulaInformationBlo> Get()
        {
            throw new NotImplementedException();
        }

        public Task<FormulaInformationBlo> Get(string title)
        {
            throw new NotImplementedException();
        }

        public Task<FormulaInformationBlo> Update(string title, FormulaUpdateBlo formulaUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
