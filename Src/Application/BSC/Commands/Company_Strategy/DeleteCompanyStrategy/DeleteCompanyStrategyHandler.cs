using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Company_Strategy.DeleteCompanyStrategy
{
    public class DeleteCompanyStrategyHandler : IRequestHandler<DeleteCompanyStrategyCommand, IList<Proc_Company_Strategy_Strategy_NO>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCompanyStrategyHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_Company_Strategy_Strategy_NO>> Handle(DeleteCompanyStrategyCommand request, CancellationToken cancellationToken)
        {
            string Strategy_NO = request.Strategy_NO;
            IList<Proc_Company_Strategy_Strategy_NO> result = await _procedureAdabter
                .Execute<Proc_Company_Strategy_Strategy_NO>("[BSC].[proc_Company_StrategyDelete]", (nameof(Strategy_NO), Strategy_NO));

            return result;
        }
    }
}
