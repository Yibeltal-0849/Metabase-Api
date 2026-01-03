using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procRentContract.GetprocRentContractLoadAll
{
    class GetprocRentContractLoadAllQueryHandler : IRequestHandler<GetprocRentContractLoadAllQuery, GetprocRentContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocRentContractLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRentContractLoadAllListVm> Handle(GetprocRentContractLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<RentContract> procRentContracts = await _procedureAdabter
               .Execute<RentContract>("[ProprtyData].[proc_Rent_ContractLoadAll]");
            GetprocRentContractLoadAllListVm vm = new GetprocRentContractLoadAllListVm
            {
                procRentContracts = _mapper.Map<IList<RentContract>, IList<GetprocRentContractLoadAllVm>>(procRentContracts)
            };

            return vm;
        }
    }
}
