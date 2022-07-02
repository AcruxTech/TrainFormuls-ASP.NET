using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Models;

namespace TrainFormuls.BusinessLogic.Interfaces
{
    public interface IQuantityService
    {
        Task<bool> Add(QuantityInformationBlo quantityInformationBlo);
        Task<QuantityInformationBlo> Get();
        Task<QuantityInformationBlo> Get(string title);
        Task<QuantityInformationBlo> Update(string title, QuantityUpdateBlo quantityUpdateBlo);
        Task<bool> Delete(string title);
    }
}
