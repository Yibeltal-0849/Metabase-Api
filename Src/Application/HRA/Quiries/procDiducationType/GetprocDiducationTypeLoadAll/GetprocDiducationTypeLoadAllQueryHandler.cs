using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procDiducationType.GetprocDiducationTypeLoadAll
{
    class GetprocDiducationTypeLoadAllQueryHandler : IRequestHandler<GetprocDiducationTypeLoadAllQuery, GetprocDiducationTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocDiducationTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDiducationTypeLoadAllListVm> Handle(GetprocDiducationTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<DiducationType> procDiducationTypes = await _procedureAdabter
               .Execute<DiducationType>("[HRA].[proc_Diducation_TypeLoadAll]");
            GetprocDiducationTypeLoadAllListVm vm = new GetprocDiducationTypeLoadAllListVm
            {
                procDiducationTypes = _mapper.Map<IList<DiducationType>, IList<GetprocDiducationTypeLoadAllVm>>(procDiducationTypes)
            };

            return vm;
        }
    }
}
