using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procBSCValues.GetprocBSCValuesLoadAll
{
    class GetprocBSCValuesLoadAllQueryHandler : IRequestHandler<GetprocBSCValuesLoadAllQuery, GetprocBSCValuesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBSCValuesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBSCValuesLoadAllListVm> Handle(GetprocBSCValuesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<BSCValues> procBSCValuess = await _procedureAdabter
               .Execute<BSCValues>("[BSC].[proc_BSC_ValuesLoadAll]");
            GetprocBSCValuesLoadAllListVm vm = new GetprocBSCValuesLoadAllListVm
            {
                procBSCValuess = _mapper.Map<IList<BSCValues>, IList<GetprocBSCValuesLoadAllVm>>(procBSCValuess)
            };

            return vm;
        }
    }
}
