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
    public class DepartmentTypeServices : BaseService<DepartmentType>, IDepartmentTypeServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentTypeServices(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<JqueryDataTablesPagedResults<DepartmentTypeDTO>> GetDepartmentType(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<DepartmentType>().GetAll().Where(v => !v.IsArchived)
                                                   .AsNoTracking();
            query = SearchOptionsProcessor<DepartmentTypeDTO, DepartmentType>.Apply(query, table.Columns);
            query = SortOptionsProcessor<DepartmentTypeDTO, DepartmentType>.Apply(query, table);

            var size = await query.CountAsync();

            List<DepartmentType> items;

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

            return new JqueryDataTablesPagedResults<DepartmentTypeDTO>
            {
                Items = _mapper.Map<List<DepartmentTypeDTO>>(items),
                TotalSize = size
            };
        }
    }
}
