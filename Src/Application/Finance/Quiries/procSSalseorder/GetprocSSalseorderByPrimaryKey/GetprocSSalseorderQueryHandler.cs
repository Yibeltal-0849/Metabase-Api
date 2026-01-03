using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSSalseorder.GetprocSSalseorderLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalseorder.GetprocSSalseorderByPrimaryKey
{
    public class GetprocSSalseorderQueryHandler : IRequestHandler<GetprocSSalseorderByPrimaryKey, GetprocSSalseorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSSalseorderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalseorderLoadAllListVm> Handle(GetprocSSalseorderByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SSalseOrder> procSSalseorders = await _procedureAdabter
               .Execute<SSalseOrder>("[FINA].[proc_S_Salse_orderLoadByPrimaryKey]", request);
            GetprocSSalseorderLoadAllListVm vm = new GetprocSSalseorderLoadAllListVm
            {
                procSSalseorders = _mapper.Map<IList<SSalseOrder>, IList<GetprocSSalseorderLoadAllVm>>(procSSalseorders)
            };

            return vm;
        }
    }
}
