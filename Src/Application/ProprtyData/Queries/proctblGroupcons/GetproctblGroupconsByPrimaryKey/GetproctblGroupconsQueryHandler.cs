using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblGroupcons.GetproctblGroupconsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblGroupcons.GetproctblGroupconsByPrimaryKey
{
    public class GetproctblGroupconsQueryHandler : IRequestHandler<GetproctblGroupconsByPrimaryKey, GetproctblGroupconsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblGroupconsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblGroupconsLoadAllListVm> Handle(GetproctblGroupconsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblGroupcons> proctblGroupconss = await _procedureAdabter
               .Execute<tblGroupcons>("[ProprtyData].[proc_tblGroup_consLoadByPrimaryKey]", request);
            GetproctblGroupconsLoadAllListVm vm = new GetproctblGroupconsLoadAllListVm
            {
                proctblGroupconss = _mapper.Map<IList<tblGroupcons>, IList<GetproctblGroupconsLoadAllVm>>(proctblGroupconss)
            };

            return vm;
        }
    }
}
