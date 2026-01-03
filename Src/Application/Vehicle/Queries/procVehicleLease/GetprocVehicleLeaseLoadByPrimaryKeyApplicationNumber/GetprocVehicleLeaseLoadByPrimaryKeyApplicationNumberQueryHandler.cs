using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procVehicleLease.GetprocVehicleLeaseLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleLease.GetprocVehicleLeaseLoadByPrimaryKeyApplicationNumber
{
    public class GetprocVehicleLeaseQueryHandler : IRequestHandler<GetprocVehicleLeaseLoadByPrimaryKeyApplicationNumber, GetprocVehicleLeaseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVehicleLeaseQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleLeaseLoadAllListVm> Handle(GetprocVehicleLeaseLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
           
            IList<VehicleLease> procVehicleLeases = await _procedureAdabter
               .Execute<VehicleLease>("[Vehicle].[proc_Vehicle_LeaseLoadByPrimaryKey_Application_Number]", request);
            GetprocVehicleLeaseLoadAllListVm vm = new GetprocVehicleLeaseLoadAllListVm
            {
                procVehicleLeases = _mapper.Map<IList<VehicleLease>, IList<GetprocVehicleLeaseLoadAllVm>>(procVehicleLeases)
            };

            return vm;
        }
    }
}
