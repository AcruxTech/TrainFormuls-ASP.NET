using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.DataAccess.Models;

namespace TrainFormuls.Shared.Models
{
    public class QuantityBase
    {
        public string Symbol { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public SectionRto Section { get; set; }
    }
}
