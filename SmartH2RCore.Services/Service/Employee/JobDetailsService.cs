using AutoMapper;
using DocumentFormat.OpenXml.Spreadsheet;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Infrastructure;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;
using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.EmployeeDTO;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class JobDetailsService : BaseService<JobDetails>, IJobDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public JobDetailsService(IUnitOfWork unitOfWork,IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<JobDetails> GetJobDetailsByEmployeeIdByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<JobDetails>().FindBy(x => x.EmployeeId == employeeId).FirstOrDefaultAsync();

          
        }
        public async Task<JqueryDataTablesPagedResults<JobDetailsDTO>> GetJobDetailes(JqueryDataTablesParameters param, int jobId)
        {
            var query = _unitOfWork.GetRepository<JobDetails>().GetAll().Include(v => v.CompanyId).Where(v => v.Branch.CompanyId == jobId).AsNoTracking();

            query = SearchOptionsProcessor<JobDetailsDTO, JobDetails>.Apply(query, param.Columns);
            query = SortOptionsProcessor<JobDetailsDTO, JobDetails>.Apply(query, param);

            var size = await query.CountAsync();

            List<JobDetails> items;

            if (param.Length > 0)
            {
                items = await query
                .Skip((param.Start / param.Length) * param.Length)
                .Take(param.Length)
                .ToListAsync();
            }
            else
            {
                items = await query.ToListAsync();
            }

            return new JqueryDataTablesPagedResults<JobDetailsDTO>
            {
                Items = _mapper.Map<List<JobDetailsDTO>>(items),
                TotalSize = size
            };

        }
    }
}
