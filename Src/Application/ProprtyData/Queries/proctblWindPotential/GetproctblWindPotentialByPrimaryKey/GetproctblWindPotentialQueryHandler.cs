using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblWindPotential.GetproctblWindPotentialLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblWindPotential.GetproctblWindPotentialByPrimaryKey
{
    public class GetproctblWindPotentialQueryHandler : IRequestHandler<GetproctblWindPotentialByPrimaryKey, GetproctblWindPotentialLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblWindPotentialQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblWindPotentialLoadAllListVm> Handle(GetproctblWindPotentialByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblWindPotential> proctblWindPotentials = await _procedureAdabter
               .Execute<tblWindPotential>("[ProprtyData].[proc_tblWindPotentialLoadByPrimaryKey]", request);
            GetproctblWindPotentialLoadAllListVm vm = new GetproctblWindPotentialLoadAllListVm
            {
                proctblWindPotentials = _mapper.Map<IList<tblWindPotential>, IList<GetproctblWindPotentialLoadAllVm>>(proctblWindPotentials)
            };

            return vm;
        }
    }
}
