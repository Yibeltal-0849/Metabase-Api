using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.ProcorganizationType.GetProcorganizationTypeLoadAll
{
    class GetProcorganizationTypeLoadAllQueryHandler : IRequestHandler<GetProcorganizationTypeLoadAllQuery, GetProcorganizationTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetProcorganizationTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcorganizationTypeLoadAllListVm> Handle(GetProcorganizationTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<organization_Type> ProcorganizationTypes = await _procedureAdabter
               .Execute<organization_Type>("[FINA].[proc_organization_TypeLoadAll]");
            GetProcorganizationTypeLoadAllListVm vm = new GetProcorganizationTypeLoadAllListVm
            {
                ProcorganizationTypes = _mapper.Map<IList<organization_Type>, IList<GetProcorganizationTypeLoadAllVm>>(ProcorganizationTypes)
            };

            return vm;
        }
    }
}
