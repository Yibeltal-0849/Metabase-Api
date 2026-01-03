using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime.GetCEmployeVacationAndSickTimeLoadAll
{
    public class GetCEmployeVacationAndSickTimeLoadAllQueryHandler : IRequestHandler<GetCEmployeVacationAndSickTimeLoadAllQuery, GetCEmployeVacationAndSickTimeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCEmployeVacationAndSickTimeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCEmployeVacationAndSickTimeLoadAllListVm> Handle(GetCEmployeVacationAndSickTimeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_Employe_VacationAndSickTime> employeVacationAndSickTimes = await _procedureAdabter
               .Execute<Proc_C_Employe_VacationAndSickTime>("[HRA].[proc_c_Employe_VacationAndSickTimeLoadAll]");
            GetCEmployeVacationAndSickTimeLoadAllListVm vm = new GetCEmployeVacationAndSickTimeLoadAllListVm
            {
                EmployeVacationAndSickTimes = _mapper.Map<IList<Proc_C_Employe_VacationAndSickTime>, IList<GetCEmployeVacationAndSickTimeLoadAllVM>>(employeVacationAndSickTimes)
   };

            return vm;
        }
    }
}
