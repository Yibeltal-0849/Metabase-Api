using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblGroup.GetproctblGroupLoadAll
{
    class GetproctblGroupLoadAllQueryHandler : IRequestHandler<GetproctblGroupLoadAllQuery, GetproctblGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblGroupLoadAllListVm> Handle(GetproctblGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblGroup> proctblGroups = await _procedureAdabter
               .Execute<tblGroup>("[ProprtyData].[proc_tblGroupLoadAll]");
            GetproctblGroupLoadAllListVm vm = new GetproctblGroupLoadAllListVm
            {
                proctblGroups = _mapper.Map<IList<tblGroup>, IList<GetproctblGroupLoadAllVm>>(proctblGroups)
            };

            return vm;
        }
    }
}
