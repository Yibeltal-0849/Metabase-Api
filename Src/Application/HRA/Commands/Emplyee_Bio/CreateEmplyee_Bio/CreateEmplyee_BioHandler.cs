using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Emplyee_Bio.CreateEmplyee_Bio
{
    public class CreateEmplyee_BioHandler : IRequestHandler<CreateEmplyee_BioCommand, IList<EmplyeeBio_Emp_Bio>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateEmplyee_BioHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmplyeeBio_Emp_Bio>> Handle(CreateEmplyee_BioCommand request, CancellationToken cancellationToken)
        {

            IList<EmplyeeBio_Emp_Bio> result = await _procedureAdabter
                .Execute<EmplyeeBio_Emp_Bio>("[HRA].[Emplyee_BioInsert]", request);

            return result;
        }

    }
}
