using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSSalesorder.GetprocSSalesorderLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalesorder.GetprocSSalesorderByPrimaryKey
{
    public class GetprocSSalesorderQueryHandler : IRequestHandler<GetprocSSalesorderByPrimaryKey, GetprocSSalesorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSSalesorderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalesorderLoadAllListVm> Handle(GetprocSSalesorderByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SSalesOrder> procSSalesorders = await _procedureAdabter
               .Execute<SSalesOrder>("[FINA].[proc_S_Sales_orderLoadByPrimaryKey]", request);
            GetprocSSalesorderLoadAllListVm vm = new GetprocSSalesorderLoadAllListVm
            {
                procSSalesorders = _mapper.Map<IList<SSalesOrder>, IList<GetprocSSalesorderLoadAllVm>>(procSSalesorders)
            };

            return vm;
        }
    }
}
