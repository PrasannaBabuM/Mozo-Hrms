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
    public class BranchService : BaseService<Branch>, IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BranchService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<JqueryDataTablesPagedResults<BranchDTO>> GetBranch(JqueryDataTablesParameters table, int companyId)
        {
            var query = _unitOfWork.GetRepository<Branch>().GetAll().Include(v => v.Company).Where(v => v.Company.OwnerId == companyId).AsNoTracking();

            query = SearchOptionsProcessor<BranchDTO, Branch>.Apply(query, table.Columns);
            query = SortOptionsProcessor<BranchDTO, Branch>.Apply(query, table);

            var size = await query.CountAsync();

            List<Branch> items;

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

            return new JqueryDataTablesPagedResults<BranchDTO>
            {
                Items = _mapper.Map<List<BranchDTO>>(items),
                TotalSize = size
            };
        }
    }
}
