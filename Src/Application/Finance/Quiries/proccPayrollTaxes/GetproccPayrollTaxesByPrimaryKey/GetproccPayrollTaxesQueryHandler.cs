using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccPayrollTaxes.GetproccPayrollTaxesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccPayrollTaxes.GetproccPayrollTaxesByPrimaryKey
{
    public class GetproccPayrollTaxesQueryHandler : IRequestHandler<GetproccPayrollTaxesByPrimaryKey, GetproccPayrollTaxesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccPayrollTaxesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccPayrollTaxesLoadAllListVm> Handle(GetproccPayrollTaxesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CPayrollTaxes> proccPayrollTaxess = await _procedureAdabter
               .Execute<CPayrollTaxes>("[FINA].[proc_c_PayrollTaxesLoadByPrimaryKey]", request);
            GetproccPayrollTaxesLoadAllListVm vm = new GetproccPayrollTaxesLoadAllListVm
            {
                proccPayrollTaxess = _mapper.Map<IList<CPayrollTaxes>, IList<GetproccPayrollTaxesLoadAllVm>>(proccPayrollTaxess)
            };

            return vm;
        }
    }
}
