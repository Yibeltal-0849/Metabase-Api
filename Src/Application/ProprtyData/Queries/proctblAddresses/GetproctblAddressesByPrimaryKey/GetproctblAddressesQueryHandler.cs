using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblAddresses.GetproctblAddressesLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblAddresses.GetproctblAddressesByPrimaryKey
{
    public class GetproctblAddressesQueryHandler : IRequestHandler<GetproctblAddressesByPrimaryKey, GetproctblAddressesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblAddressesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblAddressesLoadAllListVm> Handle(GetproctblAddressesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblAddresses> proctblAddressess = await _procedureAdabter
               .Execute<tblAddresses>("[ProprtyData].[proc_tblAddressesLoadByPrimaryKey]", request);
            GetproctblAddressesLoadAllListVm vm = new GetproctblAddressesLoadAllListVm
            {
                proctblAddressess = _mapper.Map<IList<tblAddresses>, IList<GetproctblAddressesLoadAllVm>>(proctblAddressess)
            };

            return vm;
        }
    }
}
