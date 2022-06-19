using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Models;

namespace TrainFormuls.BusinessLogic.Interfaces
{
    public interface IQuantityService
    {
        Task<bool> Add(QuantityInformationBlo formulaInformationBlo);
        Task<QuantityInformationBlo> Get(string title);
        Task<QuantityInformationBlo> GetRandom();
        Task<QuantityInformationBlo> Update(string title, QuantityUpdateBlo quantityUpdateBlo);
        Task<bool> Delete(string title);
    }
}
