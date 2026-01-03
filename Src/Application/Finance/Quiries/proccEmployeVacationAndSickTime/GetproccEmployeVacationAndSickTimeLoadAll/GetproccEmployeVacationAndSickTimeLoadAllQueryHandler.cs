using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccEmployeVacationAndSickTime.GetproccEmployeVacationAndSickTimeLoadAll
{
    class GetproccEmployeVacationAndSickTimeLoadAllQueryHandler : IRequestHandler<GetproccEmployeVacationAndSickTimeLoadAllQuery, GetproccEmployeVacationAndSickTimeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccEmployeVacationAndSickTimeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccEmployeVacationAndSickTimeLoadAllListVm> Handle(GetproccEmployeVacationAndSickTimeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CEmployeVacationAndSickTime> proccEmployeVacationAndSickTimes = await _procedureAdabter
               .Execute<CEmployeVacationAndSickTime>("[FINA].[proc_c_Employe_VacationAndSickTimeLoadAll]");
            GetproccEmployeVacationAndSickTimeLoadAllListVm vm = new GetproccEmployeVacationAndSickTimeLoadAllListVm
            {
                proccEmployeVacationAndSickTimes = _mapper.Map<IList<CEmployeVacationAndSickTime>, IList<GetproccEmployeVacationAndSickTimeLoadAllVm>>(proccEmployeVacationAndSickTimes)
            };

            return vm;
        }
    }
}
