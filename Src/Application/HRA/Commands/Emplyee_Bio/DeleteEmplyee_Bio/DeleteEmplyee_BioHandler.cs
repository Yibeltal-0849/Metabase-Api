using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Emplyee_Bio.DeleteEmplyee_Bio
{
    public class DeleteEmplyee_BioHandler : IRequestHandler<DeleteEmplyee_BioCommand, IList<EmplyeeBio_Emp_Bio>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteEmplyee_BioHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmplyeeBio_Emp_Bio>> Handle(DeleteEmplyee_BioCommand request, CancellationToken cancellationToken)
        {
            Guid Emp_Bio = request.Emp_Bio;
            IList<EmplyeeBio_Emp_Bio> result = await _procedureAdabter
                .Execute<EmplyeeBio_Emp_Bio>("[HRA].[Emplyee_BioDelete]",
                (nameof(Emp_Bio), Emp_Bio));

            return result;
        }
    }
}
