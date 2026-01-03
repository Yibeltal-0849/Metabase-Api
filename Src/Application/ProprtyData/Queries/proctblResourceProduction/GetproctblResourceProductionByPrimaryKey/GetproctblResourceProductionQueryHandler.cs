using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceProduction.GetproctblResourceProductionLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceProduction.GetproctblResourceProductionByPrimaryKey
{
    public class GetproctblResourceProductionQueryHandler : IRequestHandler<GetproctblResourceProductionByPrimaryKey, GetproctblResourceProductionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceProductionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceProductionLoadAllListVm> Handle(GetproctblResourceProductionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceProduction> proctblResourceProductions = await _procedureAdabter
               .Execute<tblResourceProduction>("[ProprtyData].[proc_tblResourceProductionLoadByPrimaryKey]", request);
            GetproctblResourceProductionLoadAllListVm vm = new GetproctblResourceProductionLoadAllListVm
            {
                proctblResourceProductions = _mapper.Map<IList<tblResourceProduction>, IList<GetproctblResourceProductionLoadAllVm>>(proctblResourceProductions)
            };

            return vm;
        }
    }
}
