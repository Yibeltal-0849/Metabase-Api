using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Proc_GeneratePaySlipreport.Proc_GeneratePaySlipreportLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Proc_GeneratePaySlipreport.Proc_GeneratePaySlipreportByPrimaryKey
{
    public class GetProc_GeneratePaySlipreportByPrimaryKeyQueryHandler : IRequestHandler<GetProc_GeneratePaySlipreportByPrimaryKey, GetProc_GeneratePaySlipreportLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetProc_GeneratePaySlipreportByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProc_GeneratePaySlipreportLoadAllListVm> Handle(GetProc_GeneratePaySlipreportByPrimaryKey request, CancellationToken cancellationToken)
        {
            string Employee_ID = request.Employee_ID;
            IList<GeneratePaySlipreport> GeneratePaySlip = await _procedureAdabter
               .Execute<GeneratePaySlipreport>("[HRA].[usp_Generate_PaySlip_report]", (nameof(Employee_ID), Employee_ID));
            GetProc_GeneratePaySlipreportLoadAllListVm vm = new GetProc_GeneratePaySlipreportLoadAllListVm
            {
                GeneratePaySlip = _mapper.Map<IList<GeneratePaySlipreport>, IList<GetProc_GeneratePaySlipreportLoadAllVm>>(GeneratePaySlip)
            };

            return vm;
        }
    }
}
