using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.House_Rent_Application.UpdateHouse_Rent_Application
{
    public class UpdateHouse_Rent_ApplicationHandler : IRequestHandler<UpdateHouse_Rent_ApplicationCommand, IList<House_Rent_Application_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateHouse_Rent_ApplicationHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<House_Rent_Application_ID>> Handle(UpdateHouse_Rent_ApplicationCommand request, CancellationToken cancellationToken)
        {

            IList<House_Rent_Application_ID> result = await _procedureAdabter
                .Execute<House_Rent_Application_ID>("[HRA].[proc_House_Rent_ApplicationUpdate]", request);

            return result;
        }
    }
}
