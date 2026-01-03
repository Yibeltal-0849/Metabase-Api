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

namespace Application.ProprtyData.Queries.procRentContract.GetprocRentContractByPrimaryKey
{
    public class GetprocRentContractQueryHandler : IRequestHandler<GetprocRentContractByPrimaryKey, GetprocRentContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocRentContractQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRentContractLoadAllListVm> Handle(GetprocRentContractByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<RentContract> procRentContracts = await _procedureAdabter
               .Execute<RentContract>("[ProprtyData].[proc_Rent_ContractLoadByPrimaryKey]", request);
            GetprocRentContractLoadAllListVm vm = new GetprocRentContractLoadAllListVm
            {
                procRentContracts = _mapper.Map<IList<RentContract>, IList<GetprocRentContractLoadAllVm>>(procRentContracts)
            };

            return vm;
        }
    }
}
