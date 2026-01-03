using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblVarableBasedTableDetail.GetproctblVarableBasedTableDetailLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblVarableBasedTableDetail.GetproctblVarableBasedTableDetailByPrimaryKey
{
    public class GetproctblVarableBasedTableDetailQueryHandler : IRequestHandler<GetproctblVarableBasedTableDetailByPrimaryKey, GetproctblVarableBasedTableDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblVarableBasedTableDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblVarableBasedTableDetailLoadAllListVm> Handle(GetproctblVarableBasedTableDetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblVarableBasedTableDetail> proctblVarableBasedTableDetails = await _procedureAdabter
               .Execute<tblVarableBasedTableDetail>("[ProprtyData].[proc_tblVarableBasedTable_DetailLoadByPrimaryKey]", request);
            GetproctblVarableBasedTableDetailLoadAllListVm vm = new GetproctblVarableBasedTableDetailLoadAllListVm
            {
                proctblVarableBasedTableDetails = _mapper.Map<IList<tblVarableBasedTableDetail>, IList<GetproctblVarableBasedTableDetailLoadAllVm>>(proctblVarableBasedTableDetails)
            };

            return vm;
        }
    }
}
