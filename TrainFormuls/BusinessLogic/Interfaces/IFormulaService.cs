using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Models;

namespace TrainFormuls.BusinessLogic.Interfaces
{
    public interface IFormulaService
    {
        Task<bool> Add(FormulaInformationBlo formulaInformationBlo);
        Task<FormulaInformationBlo> Get(string title);
        Task<FormulaInformationBlo> GetRandom();
        Task<FormulaInformationBlo> Update(string title, FormulaUpdateBlo formulaUpdateBlo);
        Task<bool> Delete(string title);
    }
}
