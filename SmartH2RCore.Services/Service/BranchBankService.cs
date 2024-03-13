using AutoMapper;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface;

namespace SmartH2RCore.Services.Service
{
    public class BranchBankService : BaseService<BranchBank>, IBranchBankService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BranchBankService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
