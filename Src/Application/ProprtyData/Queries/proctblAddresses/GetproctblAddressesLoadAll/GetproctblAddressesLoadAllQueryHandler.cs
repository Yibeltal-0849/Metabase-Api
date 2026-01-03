using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblAddresses.GetproctblAddressesLoadAll
{
    class GetproctblAddressesLoadAllQueryHandler : IRequestHandler<GetproctblAddressesLoadAllQuery, GetproctblAddressesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblAddressesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblAddressesLoadAllListVm> Handle(GetproctblAddressesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblAddresses> proctblAddressess = await _procedureAdabter
               .Execute<tblAddresses>("[ProprtyData].[proc_tblAddressesLoadAll]");
            GetproctblAddressesLoadAllListVm vm = new GetproctblAddressesLoadAllListVm
            {
                proctblAddressess = _mapper.Map<IList<tblAddresses>, IList<GetproctblAddressesLoadAllVm>>(proctblAddressess)
            };

            return vm;
        }
    }
}
