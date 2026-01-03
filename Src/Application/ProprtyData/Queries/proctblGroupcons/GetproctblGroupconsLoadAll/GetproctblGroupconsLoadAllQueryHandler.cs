using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblGroupcons.GetproctblGroupconsLoadAll
{
    class GetproctblGroupconsLoadAllQueryHandler : IRequestHandler<GetproctblGroupconsLoadAllQuery, GetproctblGroupconsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblGroupconsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblGroupconsLoadAllListVm> Handle(GetproctblGroupconsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblGroupcons> proctblGroupconss = await _procedureAdabter
               .Execute<tblGroupcons>("[ProprtyData].[proc_tblGroup_consLoadAll]");
            GetproctblGroupconsLoadAllListVm vm = new GetproctblGroupconsLoadAllListVm
            {
                proctblGroupconss = _mapper.Map<IList<tblGroupcons>, IList<GetproctblGroupconsLoadAllVm>>(proctblGroupconss)
            };

            return vm;
        }
    }
}
