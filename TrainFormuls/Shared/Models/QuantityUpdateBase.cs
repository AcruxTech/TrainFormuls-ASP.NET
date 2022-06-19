using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.DataAccess.Models;

namespace TrainFormuls.Shared.Models
{
    public class QuantityUpdateBase
    {
        public string NewSymbol { get; set; }
        public string NewTitle { get; set; }
        public string NewDescription { get; set; }
        public string NewSectionTitle { get; set; }
    }
}
