using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCTax.GetprocCTaxLoadAll
{
    class GetprocCTaxLoadAllQueryHandler : IRequestHandler<GetprocCTaxLoadAllQuery, GetprocCTaxLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCTaxLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCTaxLoadAllListVm> Handle(GetprocCTaxLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CTax> procCTaxs = await _procedureAdabter
               .Execute<CTax>("[FINA].[proc_C_TaxLoadAll]");
            GetprocCTaxLoadAllListVm vm = new GetprocCTaxLoadAllListVm
            {
                procCTaxs = _mapper.Map<IList<CTax>, IList<GetprocCTaxLoadAllVm>>(procCTaxs)
            };

            return vm;
        }
    }
}
