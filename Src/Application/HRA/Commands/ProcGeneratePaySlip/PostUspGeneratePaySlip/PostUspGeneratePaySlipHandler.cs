using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.ProcGeneratePaySlip.PostUspGeneratePaySlip
{
    public class PostUspGeneratePaySlipHandler : IRequestHandler<PostUspGeneratePaySlipCommand, IList<UspGeneratePaySlip>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PostUspGeneratePaySlipHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<UspGeneratePaySlip>> Handle(PostUspGeneratePaySlipCommand request, CancellationToken cancellationToken)
        {
            string Payrole_Trans_Id = request.Payrole_Trans_Id;
            IList<UspGeneratePaySlip> result = await _procedureAdabter
                .Execute<UspGeneratePaySlip>("[HRA].[usp_Generate_PaySlip]", (nameof(Payrole_Trans_Id), Payrole_Trans_Id));

            return result;
        }
    }
}
