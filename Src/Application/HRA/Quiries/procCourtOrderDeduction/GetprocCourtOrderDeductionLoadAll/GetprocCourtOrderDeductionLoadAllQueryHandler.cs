using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procCourtOrderDeduction.GetprocCourtOrderDeductionLoadAll
{
    class GetprocCourtOrderDeductionLoadAllQueryHandler : IRequestHandler<GetprocCourtOrderDeductionLoadAllQuery, GetprocCourtOrderDeductionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCourtOrderDeductionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCourtOrderDeductionLoadAllListVm> Handle(GetprocCourtOrderDeductionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CourtOrderDeduction> procCourtOrderDeductions = await _procedureAdabter
               .Execute<CourtOrderDeduction>("[HRA].[proc_Court_Order_DeductionLoadAll]");
            GetprocCourtOrderDeductionLoadAllListVm vm = new GetprocCourtOrderDeductionLoadAllListVm
            {
                procCourtOrderDeductions = _mapper.Map<IList<CourtOrderDeduction>, IList<GetprocCourtOrderDeductionLoadAllVm>>(procCourtOrderDeductions)
            };

            return vm;
        }
    }
}
