using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Cost_Method.DeleteCCostMethod
{
    class DeleteCCostMethodHandler : IRequestHandler<DeleteCCostMethodCommand, IList<Proc_C_Cost_Method_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCCostMethodHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Cost_Method_ID>> Handle(DeleteCCostMethodCommand request, CancellationToken cancellationToken)
        {
            string ID = request.ID;
            IList<Proc_C_Cost_Method_ID> result = await _procedureAdabter
                .Execute<Proc_C_Cost_Method_ID>("[BSC].[proc_c_Cost_MethodDelete]", (nameof(ID), ID));

            return result;
        }
    }
}
