using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblEnergytype.GetproctblEnergytypeLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergytype.GetproctblEnergytypeByPrimaryKey
{
    public class GetproctblEnergytypeQueryHandler : IRequestHandler<GetproctblEnergytypeByPrimaryKey, GetproctblEnergytypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblEnergytypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergytypeLoadAllListVm> Handle(GetproctblEnergytypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblEnergytype> proctblEnergytypes = await _procedureAdabter
               .Execute<tblEnergytype>("[ProprtyData].[proc_tblEnergy_typeLoadByPrimaryKey]", request);
            GetproctblEnergytypeLoadAllListVm vm = new GetproctblEnergytypeLoadAllListVm
            {
                proctblEnergytypes = _mapper.Map<IList<tblEnergytype>, IList<GetproctblEnergytypeLoadAllVm>>(proctblEnergytypes)
            };

            return vm;
        }
    }
}
