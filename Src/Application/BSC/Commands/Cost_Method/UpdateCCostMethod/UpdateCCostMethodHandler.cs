using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Cost_Method.UpdateCCostMethod
{
    public class UpdateCCostMethodHandler : IRequestHandler<UpdateCCostMethodCommand, IList<Proc_C_Cost_Method_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCCostMethodHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Cost_Method_ID>> Handle(UpdateCCostMethodCommand request, CancellationToken cancellationToken)
        {
            string ID = request.ID;
            string Name = request.Name;
            IList<Proc_C_Cost_Method_ID> result = await _procedureAdabter
                .Execute<Proc_C_Cost_Method_ID>("[BSC].[proc_c_Cost_MethodUpdate]",
                (nameof(ID), ID), (nameof(Name), Name));

            return result;
        }

    }
}
