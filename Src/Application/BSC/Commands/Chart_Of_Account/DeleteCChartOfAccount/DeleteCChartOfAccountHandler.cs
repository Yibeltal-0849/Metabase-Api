using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Chart_Of_Account.DeleteCChartOfAccount
{
    public class DeleteCChartOfAccountHandler : IRequestHandler<DeleteCChartOfAccountCommand, IList<Proc_C_Chart_Of_Account_Account_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCChartOfAccountHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Chart_Of_Account_Account_ID>> Handle(DeleteCChartOfAccountCommand request, CancellationToken cancellationToken)
        {
            string Account_ID = request.Account_ID;
            IList<Proc_C_Chart_Of_Account_Account_ID> result = await _procedureAdabter
                .Execute<Proc_C_Chart_Of_Account_Account_ID>("[BSC].[proc_c_Chart_Of_AccountDelete]", (nameof(Account_ID), Account_ID));

            return result;
        }
    }
}
