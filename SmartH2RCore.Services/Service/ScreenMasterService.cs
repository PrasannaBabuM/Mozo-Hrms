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
    public class ScreenMasterService : BaseService<ScreenMaster>, IScreenMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ScreenMasterService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<JqueryDataTablesPagedResults<ScreenMasterDTO>> GetScreens(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<ScreenMaster>().GetAll().Include(v => v.ModuleMaster).Where(v => !v.IsArchived)
                                                   .AsNoTracking();
            query = SearchOptionsProcessor<ScreenMasterDTO, ScreenMaster>.Apply(query, table.Columns);
            query = SortOptionsProcessor<ScreenMasterDTO, ScreenMaster>.Apply(query, table);

            var size = await query.CountAsync();

            List<ScreenMaster> items;

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

            return new JqueryDataTablesPagedResults<ScreenMasterDTO>
            {
                Items = _mapper.Map<List<ScreenMasterDTO>>(items.Select(v => new ScreenMasterDTO { Id = v.Id, Name = v.Name, ModuleName = v.ModuleMaster?.Name })),
                TotalSize = size
            };
        }
    }

}