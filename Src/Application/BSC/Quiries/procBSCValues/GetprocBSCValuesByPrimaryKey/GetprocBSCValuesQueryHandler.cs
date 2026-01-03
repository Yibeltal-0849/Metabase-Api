using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.procBSCValues.GetprocBSCValuesLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procBSCValues.GetprocBSCValuesByPrimaryKey
{
    public class GetprocBSCValuesQueryHandler : IRequestHandler<GetprocBSCValuesByPrimaryKey, GetprocBSCValuesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBSCValuesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBSCValuesLoadAllListVm> Handle(GetprocBSCValuesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<BSCValues> procBSCValuess = await _procedureAdabter
               .Execute<BSCValues>("[BSC].[proc_BSC_ValuesLoadByPrimaryKey]", request);
            GetprocBSCValuesLoadAllListVm vm = new GetprocBSCValuesLoadAllListVm
            {
                procBSCValuess = _mapper.Map<IList<BSCValues>, IList<GetprocBSCValuesLoadAllVm>>(procBSCValuess)
            };

            return vm;
        }
    }
}
