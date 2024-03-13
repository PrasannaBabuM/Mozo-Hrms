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
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service
{
    public class CityService : BaseService<City>, ICityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CityService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override IQueryable<City> FindBy(Expression<System.Func<City, bool>> predicate)
        {
            return base.FindBy(predicate).Include(v => v.State);
        }

        public override Task<City> AddAsync(City entity)
        {
            entity.State = null;
            return base.AddAsync(entity);
        }

        public override Task UpdateAsync(City entity)
        {
            entity.State = null;
            return base.UpdateAsync(entity);
        }

        public async Task<JqueryDataTablesPagedResults<CityDTO>> GetCity(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<City>().GetAll().Include(v => v.State).Where(v => !v.IsArchived)
                                                   .AsNoTracking();

            query = SearchOptionsProcessor<CityDTO, City>.Apply(query, table.Columns);
            query = SortOptionsProcessor<CityDTO, City>.Apply(query, table);

            var size = await query.CountAsync();

            List<City> items;

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

            return new JqueryDataTablesPagedResults<CityDTO>
            {
                Items = _mapper.Map<List<CityDTO>>(items),
                TotalSize = size
            };
        }
    }
}
