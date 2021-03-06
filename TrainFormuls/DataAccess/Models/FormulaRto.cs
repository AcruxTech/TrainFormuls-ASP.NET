using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.Shared.Models;

namespace TrainFormuls.DataAccess.Models
{
    public class FormulaRto : QuantityBase
    {
        public int Id { get; set; }
        public List<QuantityRto> Quantities { get; set; }
    }
}
