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
    public class RoleService : BaseService<Role>, IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoleService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override Task<Role> AddAsync(Role entity)
        {
            entity.NormalizedName = entity.Name.ToUpper();
            return base.AddAsync(entity);
        }

        public override Task UpdateAsync(Role entity)
        {
            entity.NormalizedName = entity.Name.ToUpper();
            return base.UpdateAsync(entity);
        }
        public async Task<JqueryDataTablesPagedResults<RoleDTO>> GetRole(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<Role>().GetAll().Where(v => v.IsActive)
                                                   .AsNoTracking();
            query = SearchOptionsProcessor<RoleDTO, Role>.Apply(query, table.Columns);
            query = SortOptionsProcessor<RoleDTO, Role>.Apply(query, table);

            var size = await query.CountAsync();

            List<Role> items;

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

            return new JqueryDataTablesPagedResults<RoleDTO>
            {
                Items = _mapper.Map<List<RoleDTO>>(items),
                TotalSize = size
            };
        }
    }
}
