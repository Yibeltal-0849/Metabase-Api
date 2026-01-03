using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Diducation_Type.DeleteDiducation_Type
{
    public class DeleteDiducation_TypeHandler : IRequestHandler<DeleteDiducation_TypeCommand, IList<DiducationType_DiductionCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteDiducation_TypeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DiducationType_DiductionCode>> Handle(DeleteDiducation_TypeCommand request, CancellationToken cancellationToken)
        {
            string DiductionCode = request.DiductionCode;
            IList<DiducationType_DiductionCode> result = await _procedureAdabter
                .Execute<DiducationType_DiductionCode>("[HRA].[Diducation_TypeDelete]",
                (nameof(DiductionCode), DiductionCode));

            return result;
        }
    }
}
