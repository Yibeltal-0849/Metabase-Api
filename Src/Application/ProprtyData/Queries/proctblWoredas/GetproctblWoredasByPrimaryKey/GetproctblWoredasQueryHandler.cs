using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblWoredas.GetproctblWoredasLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblWoredas.GetproctblWoredasByPrimaryKey
{
    public class GetproctblWoredasQueryHandler : IRequestHandler<GetproctblWoredasByPrimaryKey, GetproctblWoredasLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblWoredasQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblWoredasLoadAllListVm> Handle(GetproctblWoredasByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblWoredas> proctblWoredass = await _procedureAdabter
               .Execute<tblWoredas>("[ProprtyData].[proc_tblWoredasLoadByPrimaryKey]", request);
            GetproctblWoredasLoadAllListVm vm = new GetproctblWoredasLoadAllListVm
            {
                proctblWoredass = _mapper.Map<IList<tblWoredas>, IList<GetproctblWoredasLoadAllVm>>(proctblWoredass)
            };

            return vm;
        }
    }
}
