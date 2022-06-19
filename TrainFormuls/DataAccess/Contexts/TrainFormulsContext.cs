using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.DataAccess.Interfaces;
using TrainFormuls.DataAccess.Models;

namespace TrainFormuls.DataAccess.Contexts
{
    public class TrainFormulsContext : DbContext, ITrainFormulsContext
    {
        public TrainFormulsContext(DbContextOptions<TrainFormulsContext> options) : base(options) { }
        public DbSet<QuantityRto> Quantities { get; set; }
        public DbSet<FormulaRto> Formulas { get; set; }
        public DbSet<SectionRto> Sections { get; set; }
    }
}
