using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.Shared.Models;

namespace TrainFormuls.BusinessLogic.Models
{
    public class FormulaInformationBlo : QuantityBase
    {
        public List<QuantityInformationBlo> QuantityInformationBlos { get; set; }
    }
}
