using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainFormuls.BusinessLogic.Interfaces;
using TrainFormuls.BusinessLogic.Models;
using TrainFormuls.DataAccess.Interfaces;
using TrainFormuls.DataAccess.Models;
using TrainFormuls.Shared.Exceptions;

namespace TrainFormuls.BusinessLogic.Services
{
    public class QuantityService : IQuantityService
    {
        private readonly IMapper _mapper;
        private readonly ITrainFormulsContext _context;

        public QuantityService(IMapper mapper, ITrainFormulsContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<bool> Add(QuantityInformationBlo quantityInformationBlo)
        {
            QuantityRto newQuantity = new QuantityRto()
            {
                Symbol = quantityInformationBlo.Symbol,
                Title = quantityInformationBlo.Title,
                Description = quantityInformationBlo.Description,
                SectionTitle = quantityInformationBlo.SectionTitle
            };

            _context.Quantities.Add(newQuantity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string title)
        {
            List<QuantityRto> quantities = await _context.Quantities.Where(q => q.Title == title).ToListAsync();

            if (quantities.Count == 0)
                throw new NotFound($"Quantity with title {title} not found");

            foreach (QuantityRto quantity in quantities)
                _context.Quantities.Remove(quantity);

            await _context.SaveChangesAsync();

            return true;
        }

        public Task<QuantityInformationBlo> Get()
        {
            throw new NotImplementedException();
        }

        public Task<QuantityInformationBlo> Get(string title)
        {
            throw new NotImplementedException();
        }

        public Task<QuantityInformationBlo> Update(string title, QuantityUpdateBlo quantityUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
