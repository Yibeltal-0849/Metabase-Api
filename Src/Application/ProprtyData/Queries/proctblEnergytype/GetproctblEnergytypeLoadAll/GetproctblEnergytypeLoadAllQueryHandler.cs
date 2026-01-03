using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergytype.GetproctblEnergytypeLoadAll
{
    class GetproctblEnergytypeLoadAllQueryHandler : IRequestHandler<GetproctblEnergytypeLoadAllQuery, GetproctblEnergytypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblEnergytypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergytypeLoadAllListVm> Handle(GetproctblEnergytypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblEnergytype> proctblEnergytypes = await _procedureAdabter
               .Execute<tblEnergytype>("[ProprtyData].[proc_tblEnergy_typeLoadAll]");
            GetproctblEnergytypeLoadAllListVm vm = new GetproctblEnergytypeLoadAllListVm
            {
                proctblEnergytypes = _mapper.Map<IList<tblEnergytype>, IList<GetproctblEnergytypeLoadAllVm>>(proctblEnergytypes)
            };

            return vm;
        }
    }
}
