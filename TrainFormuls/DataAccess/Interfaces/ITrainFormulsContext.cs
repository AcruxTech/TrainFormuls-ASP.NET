using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TrainFormuls.DataAccess.Models;

namespace TrainFormuls.DataAccess.Interfaces
{
    public interface ITrainFormulsContext : IDisposable, IAsyncDisposable
    {
        DbSet<QuantityRto> Quantities { get; set; }
        DbSet<FormulaRto> Formulas { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
