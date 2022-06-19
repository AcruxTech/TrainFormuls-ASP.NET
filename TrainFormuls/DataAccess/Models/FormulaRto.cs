using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainFormuls.DataAccess.Models
{
    public class FormulaRto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<QuantityRto> Quantities { get; set; }
    }
}
