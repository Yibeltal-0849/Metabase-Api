using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.StrategicInnitiative.GetStrategicInnitiativeLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.StrategicInnitiative.GetprocStrategicInnitiativeLoadByPrimaryKeyparentInnitiativeID
{
    public class GetStrategicInnitiativeQueryHandler : IRequestHandler<GetprocStrategicInnitiativeLoadByPrimaryKeyparentInnitiativeID, GetStrategicInnitiativeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetStrategicInnitiativeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStrategicInnitiativeLoadAllListVm> Handle(GetprocStrategicInnitiativeLoadByPrimaryKeyparentInnitiativeID request, CancellationToken cancellationToken)
        {
            
            IList<Strategic_Innitiative> StrategicInnitiatives = await _procedureAdabter
               .Execute<Strategic_Innitiative>("[BSC].[proc_Strategic_InnitiativeLoadByPrimaryKey_ParentInnitiative_ID]", request);
            GetStrategicInnitiativeLoadAllListVm vm = new GetStrategicInnitiativeLoadAllListVm
            {
                StrategicInnitiatives = _mapper.Map<IList<Strategic_Innitiative>, IList<GetStrategicInnitiativeLoadAllVm>>(StrategicInnitiatives)
            };

            return vm;
        }
    }
}
