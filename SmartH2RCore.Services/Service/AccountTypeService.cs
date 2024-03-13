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
    public class AccountTypeService : BaseService<AccountType>, IAccountTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccountTypeService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<JqueryDataTablesPagedResults<AccountTypeDTO>> GetAccountType(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<AccountType>().GetAll().Where(v => !v.IsArchived)
                                                   .AsNoTracking();
            query = SearchOptionsProcessor<AccountTypeDTO, AccountType>.Apply(query, table.Columns);
            query = SortOptionsProcessor<AccountTypeDTO, AccountType>.Apply(query, table);

            var size = await query.CountAsync();

            List<AccountType> items;

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

            return new JqueryDataTablesPagedResults<AccountTypeDTO>
            {
                Items = _mapper.Map<List<AccountTypeDTO>>(items),
                TotalSize = size
            };
        }
    }
}
