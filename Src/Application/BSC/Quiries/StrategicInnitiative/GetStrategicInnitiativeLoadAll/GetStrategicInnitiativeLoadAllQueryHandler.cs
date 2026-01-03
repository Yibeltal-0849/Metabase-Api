using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.StrategicInnitiative.GetStrategicInnitiativeLoadAll
{
    class GetStrategicInnitiativeLoadAllQueryHandler : IRequestHandler<GetStrategicInnitiativeLoadAllQuery, GetStrategicInnitiativeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetStrategicInnitiativeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStrategicInnitiativeLoadAllListVm> Handle(GetStrategicInnitiativeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Strategic_Innitiative> StrategicInnitiatives = await _procedureAdabter
               .Execute<Strategic_Innitiative>("[BSC].[Strategic_InnitiativeLoad_all]");
            GetStrategicInnitiativeLoadAllListVm vm = new GetStrategicInnitiativeLoadAllListVm
            {
                StrategicInnitiatives = _mapper.Map<IList<Strategic_Innitiative>, IList<GetStrategicInnitiativeLoadAllVm>>(StrategicInnitiatives)
            };

            return vm;
        }
    }
}
