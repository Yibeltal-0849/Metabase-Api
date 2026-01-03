using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.House_Rent_Application.DeleteHouse_Rent_Application
{
    public class DeleteHouse_Rent_ApplicationHandler : IRequestHandler<DeleteHouse_Rent_ApplicationCommand, IList<House_Rent_Application_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteHouse_Rent_ApplicationHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<House_Rent_Application_ID>> Handle(DeleteHouse_Rent_ApplicationCommand request, CancellationToken cancellationToken)
        {
            Guid? Rent_App_ID = request.Rent_App_ID;
            IList<House_Rent_Application_ID> result = await _procedureAdabter
                .Execute<House_Rent_Application_ID>("[HRA].[proc_House_Rent_ApplicationDelete]", (nameof(Rent_App_ID), Rent_App_ID));

            return result;
        }
    }
}
