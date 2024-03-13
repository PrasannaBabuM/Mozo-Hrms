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
    public class EmployeeSubTypeServices : BaseService<EmployeeSubType>, IEmployeeSubTypeServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeSubTypeServices(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override Task<EmployeeSubType> AddAsync(EmployeeSubType entity)
        {
            entity.EmployeeType = null;
            return base.AddAsync(entity);
        }

        public override Task UpdateAsync(EmployeeSubType entity)
        {
            entity.EmployeeType = null;
            return base.UpdateAsync(entity);
        }

        public async Task<JqueryDataTablesPagedResults<EmployeeSubTypeDTO>> GetEmployeeSubType(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<EmployeeSubType>().GetAll().Include(v => v.EmployeeType).Where(v => !v.IsArchived)
                                                   .AsNoTracking();



            query = SearchOptionsProcessor<EmployeeSubTypeDTO, EmployeeSubType>.Apply(query, table.Columns);
            query = SortOptionsProcessor<EmployeeSubTypeDTO, EmployeeSubType>.Apply(query, table);

            var size = await query.CountAsync();

            List<EmployeeSubType> items;

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

            return new JqueryDataTablesPagedResults<EmployeeSubTypeDTO>
            {
                Items = _mapper.Map<List<EmployeeSubTypeDTO>>(items),
                TotalSize = size
            };
        }
    }
}
