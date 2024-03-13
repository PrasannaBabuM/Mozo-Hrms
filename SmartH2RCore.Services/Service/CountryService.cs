using AutoMapper;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Infrastructure;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;

using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SmartH2RCore.Services.Service
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CountryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override Task<Country> AddAsync(Country entity)
        {
            entity.Currency = null;
            return base.AddAsync(entity);
        }

        public override Task UpdateAsync(Country entity)
        {
            entity.Currency = null;
            return base.UpdateAsync(entity);
        }

        public async Task<JqueryDataTablesPagedResults<CountryDTO>> GetCountry(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<Country>().GetAll().Include(v => v.Currency).Where(v => !v.IsArchived)
                                                   .AsNoTracking();
            query = SearchOptionsProcessor<CountryDTO, Country>.Apply(query, table.Columns);
            query = SortOptionsProcessor<CountryDTO, Country>.Apply(query, table);

            var size = await query.CountAsync();

            List<Country> items;

            if (table.Length > 0)
            {
                items = await query
                .Skip((table.Start / table.Length) * table.Length)
                .Take(table.Length)
                .ToListAsync();
            }
            else
            {
                items = await query.ToListAsync();
            }

            return new JqueryDataTablesPagedResults<CountryDTO>
            {
                Items = _mapper.Map<List<CountryDTO>>(items),
                TotalSize = size
            };
        }
    }
}
