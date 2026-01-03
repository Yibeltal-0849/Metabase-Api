using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procPostionLoockup.GetprocPostionLoockupLoadAll
{
    class GetprocPostionLoockupQueryHandler : IRequestHandler<GetprocPostionLoockupQuery, GetprocPostionLoockupListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPostionLoockupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPostionLoockupListVm> Handle(GetprocPostionLoockupQuery request, CancellationToken cancellationToken)
        {
            IList<PostionLoockup> procPostionloockup = await _procedureAdabter
               .Execute<PostionLoockup>("[ProprtyData].[proc_PostionLockup_LoadAll]");
            GetprocPostionLoockupListVm vm = new GetprocPostionLoockupListVm
            {
                procPostionloockup = _mapper.Map<IList<PostionLoockup>, IList<GetprocPostionLoockupLoadAllVm>>(procPostionloockup)
            };

            return vm;
        }
    }
}
