using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.procRentContract.GetprocRentContractLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;
namespace Application.ProprtyData.Queries.procRentContract.GetprocRentContractByOrgCode
{
    class GetprocRentContractOrgCodeQueryHandler : IRequestHandler<GetprocRentContractByOrgCode, GetprocRentContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocRentContractOrgCodeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRentContractLoadAllListVm> Handle(GetprocRentContractByOrgCode request, CancellationToken cancellationToken)
        {

            IList<RentContract> procRentContracts = await _procedureAdabter
               .Execute<RentContract>("[ProprtyData].[proc_Rent_ContractLoadByOrgCode]", request);
            GetprocRentContractLoadAllListVm vm = new GetprocRentContractLoadAllListVm
            {
                procRentContracts = _mapper.Map<IList<RentContract>, IList<GetprocRentContractLoadAllVm>>(procRentContracts)
            };

            return vm;
        }
    }
}
