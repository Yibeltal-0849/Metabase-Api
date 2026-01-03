using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmploye_VacationAndSickTime.DeleteCEmployeVacationAndSickTime
{
    public class DeleteCEmployeVacationAndSickTimeHandler : IRequestHandler<DeleteCEmployeVacationAndSickTimeCommand, IList<Proc_C_Employe_VacationAndSickTime_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCEmployeVacationAndSickTimeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Employe_VacationAndSickTime_id>> Handle(DeleteCEmployeVacationAndSickTimeCommand request, CancellationToken cancellationToken)
        {
            long Id = request.Id;

            IList<Proc_C_Employe_VacationAndSickTime_id> result = await _procedureAdabter
                .Execute<Proc_C_Employe_VacationAndSickTime_id>("[HRA].[proc_c_Employe_VacationAndSickTimeDelete]", (nameof(Id), Id));

            return result;
        }
    }
}
