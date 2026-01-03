using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procCourtOrderDeduction.GetprocCourtOrderDeductionLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procCourtOrderDeduction.GetprocCourtOrderDeductionByPrimaryKey
{
    public class GetprocCourtOrderDeductionQueryHandler : IRequestHandler<GetprocCourtOrderDeductionByPrimaryKey, GetprocCourtOrderDeductionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCourtOrderDeductionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCourtOrderDeductionLoadAllListVm> Handle(GetprocCourtOrderDeductionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CourtOrderDeduction> procCourtOrderDeductions = await _procedureAdabter
               .Execute<CourtOrderDeduction>("[HRA].[proc_Court_Order_DeductionLoadByPrimaryKey]", request);
            GetprocCourtOrderDeductionLoadAllListVm vm = new GetprocCourtOrderDeductionLoadAllListVm
            {
                procCourtOrderDeductions = _mapper.Map<IList<CourtOrderDeduction>, IList<GetprocCourtOrderDeductionLoadAllVm>>(procCourtOrderDeductions)
            };

            return vm;
        }
    }
}
