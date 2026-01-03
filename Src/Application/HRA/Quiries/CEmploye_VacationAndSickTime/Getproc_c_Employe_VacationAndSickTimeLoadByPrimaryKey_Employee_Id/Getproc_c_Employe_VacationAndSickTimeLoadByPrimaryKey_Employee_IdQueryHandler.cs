using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime.GetCEmployeVacationAndSickTimeLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime.Getproc_c_Employe_VacationAndSickTimeLoadByPrimaryKey_Employee_Id
{
    public class GetCEmployeVacationAndSickTimeQueryHandler : IRequestHandler<Getproc_c_Employe_VacationAndSickTimeLoadByPrimaryKey_Employee_Id, GetCEmployeVacationAndSickTimeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCEmployeVacationAndSickTimeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCEmployeVacationAndSickTimeLoadAllListVm> Handle(Getproc_c_Employe_VacationAndSickTimeLoadByPrimaryKey_Employee_Id request, CancellationToken cancellationToken)
        {
            string Employee_Id = request.Employee_Id;
            IList<Proc_C_Employe_VacationAndSickTime> employeVacationAndSickTimes = await _procedureAdabter
               .Execute<Proc_C_Employe_VacationAndSickTime>("[HRA].[proc_c_Employe_VacationAndSickTimeLoadByPrimaryKey_Employee_Id]", (nameof(Employee_Id), Employee_Id));

            GetCEmployeVacationAndSickTimeLoadAllListVm vm = new GetCEmployeVacationAndSickTimeLoadAllListVm
            {
                EmployeVacationAndSickTimes = _mapper.Map<IList<Proc_C_Employe_VacationAndSickTime>, IList<GetCEmployeVacationAndSickTimeLoadAllVM>>(employeVacationAndSickTimes)
            };

            return vm;
        }
    }
}
