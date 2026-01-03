using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCTax.GetprocCTaxLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCTax.GetprocCTaxByPrimaryKey
{
    public class GetprocCTaxQueryHandler : IRequestHandler<GetprocCTaxByPrimaryKey, GetprocCTaxLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCTaxQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCTaxLoadAllListVm> Handle(GetprocCTaxByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CTax> procCTaxs = await _procedureAdabter
               .Execute<CTax>("[FINA].[proc_C_TaxLoadByPrimaryKey]", request);
            GetprocCTaxLoadAllListVm vm = new GetprocCTaxLoadAllListVm
            {
                procCTaxs = _mapper.Map<IList<CTax>, IList<GetprocCTaxLoadAllVm>>(procCTaxs)
            };

            return vm;
        }
    }
}
