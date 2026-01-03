using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.EmployeeDoucment.DeleteEmployeeDoucment
{
    public class DeleteEmployeeDoucmentHandler : IRequestHandler<DeleteEmployeeDoucmentCommand, IList<EmployeeDoucment_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteEmployeeDoucmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmployeeDoucment_ID>> Handle(DeleteEmployeeDoucmentCommand request, CancellationToken cancellationToken)
        {
            Guid ID = request.ID;
            IList<EmployeeDoucment_ID> result = await _procedureAdabter
                .Execute<EmployeeDoucment_ID>("[HRA].[proc_Emplyee_DocumentsDelete]",
                (nameof(ID), ID));

            return result;
        }
    }
}
