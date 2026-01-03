using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccPayrollTaxes.GetproccPayrollTaxesLoadAll
{
    class GetproccPayrollTaxesLoadAllQueryHandler : IRequestHandler<GetproccPayrollTaxesLoadAllQuery, GetproccPayrollTaxesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccPayrollTaxesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccPayrollTaxesLoadAllListVm> Handle(GetproccPayrollTaxesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CPayrollTaxes> proccPayrollTaxess = await _procedureAdabter
               .Execute<CPayrollTaxes>("[FINA].[proc_c_PayrollTaxesLoadAll]");
            GetproccPayrollTaxesLoadAllListVm vm = new GetproccPayrollTaxesLoadAllListVm
            {
                proccPayrollTaxess = _mapper.Map<IList<CPayrollTaxes>, IList<GetproccPayrollTaxesLoadAllVm>>(proccPayrollTaxess)
            };

            return vm;
        }
    }
}
