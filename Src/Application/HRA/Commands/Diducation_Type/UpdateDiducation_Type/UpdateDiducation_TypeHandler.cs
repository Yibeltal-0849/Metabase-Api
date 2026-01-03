using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Diducation_Type.UpdateDiducation_Type
{
    public class UpdateDiducation_TypeHandler : IRequestHandler<UpdateDiducation_TypeCommand, IList<DiducationType_DiductionCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateDiducation_TypeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DiducationType_DiductionCode>> Handle(UpdateDiducation_TypeCommand request, CancellationToken cancellationToken)
        {

            IList<DiducationType_DiductionCode> result = await _procedureAdabter
                .Execute<DiducationType_DiductionCode>("[HRA].[Diducation_TypeUpdate]", request);

            return result;
        }
    }
}
