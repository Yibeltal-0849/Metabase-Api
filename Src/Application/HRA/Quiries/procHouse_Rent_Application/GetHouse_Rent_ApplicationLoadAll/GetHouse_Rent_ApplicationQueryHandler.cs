using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.procHouse_Rent_Application.GetHouse_Rent_ApplicationLoadAll
{
    class GetHouse_Rent_ApplicationQueryHandler : IRequestHandler<GetHouse_Rent_ApplicationLoadAllQuery, GetHouse_Rent_ApplicationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetHouse_Rent_ApplicationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetHouse_Rent_ApplicationLoadAllListVm> Handle(GetHouse_Rent_ApplicationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<House_Rent_Application> procHouseRentApplication = await _procedureAdabter
               .Execute<House_Rent_Application>("[HRA].[proc_House_Rent_ApplicationLoadAll]");
            GetHouse_Rent_ApplicationLoadAllListVm vm = new GetHouse_Rent_ApplicationLoadAllListVm
            {
                procHouseRentApplication = _mapper.Map<IList<House_Rent_Application>, IList<GetHouse_Rent_ApplicationLoadAllVm>>(procHouseRentApplication)
            };

            return vm;
        }
    }
}
