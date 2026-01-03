using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccEmployeVacationAndSickTime.GetproccEmployeVacationAndSickTimeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccEmployeVacationAndSickTime.GetproccEmployeVacationAndSickTimeByPrimaryKey
{
    public class GetproccEmployeVacationAndSickTimeQueryHandler : IRequestHandler<GetproccEmployeVacationAndSickTimeByPrimaryKey, GetproccEmployeVacationAndSickTimeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccEmployeVacationAndSickTimeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccEmployeVacationAndSickTimeLoadAllListVm> Handle(GetproccEmployeVacationAndSickTimeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CEmployeVacationAndSickTime> proccEmployeVacationAndSickTimes = await _procedureAdabter
               .Execute<CEmployeVacationAndSickTime>("[FINA].[proc_c_Employe_VacationAndSickTimeLoadByPrimaryKey]", request);
            GetproccEmployeVacationAndSickTimeLoadAllListVm vm = new GetproccEmployeVacationAndSickTimeLoadAllListVm
            {
                proccEmployeVacationAndSickTimes = _mapper.Map<IList<CEmployeVacationAndSickTime>, IList<GetproccEmployeVacationAndSickTimeLoadAllVm>>(proccEmployeVacationAndSickTimes)
            };

            return vm;
        }
    }
}
