using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.procHouse_Rent_Application.GetHouse_Rent_ApplicationLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.procHouse_Rent_Application.GetHouse_Rent_ApplicationByPrimaryKey
{
    public class GetHouse_Rent_ApplicationQueryHandler : IRequestHandler<GetHouse_Rent_ApplicationByPrimaryKey, GetHouse_Rent_ApplicationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetHouse_Rent_ApplicationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetHouse_Rent_ApplicationLoadAllListVm> Handle(GetHouse_Rent_ApplicationByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid Rent_App_ID = request.Rent_App_ID;
            IList<House_Rent_Application> procHouseRentApplication = await _procedureAdabter
               .Execute<House_Rent_Application>("[HRA].[proc_House_Rent_ApplicationLoadByPrimaryKey]", (nameof(Rent_App_ID), Rent_App_ID));
            GetHouse_Rent_ApplicationLoadAllListVm vm = new GetHouse_Rent_ApplicationLoadAllListVm
            {
                procHouseRentApplication = _mapper.Map<IList<House_Rent_Application>, IList<GetHouse_Rent_ApplicationLoadAllVm>>(procHouseRentApplication)
            };

            return vm;
        }
    }
}
