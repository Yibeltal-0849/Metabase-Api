using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Quiries.procTINERCA.GetprocTINERCALoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.procTINERCA.GetprocTINERCALoadByPrimaryKeyLicenceID
{
    public class GetprocTINERCAQueryHandler : IRequestHandler<GetprocTINERCALoadByPrimaryKeyLicenceID, GetprocTINERCALoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTINERCAQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTINERCALoadAllListVm> Handle(GetprocTINERCALoadByPrimaryKeyLicenceID request, CancellationToken cancellationToken)
        {
           
            IList<TINERCA> procTINERCAs = await _procedureAdabter
               .Execute<TINERCA>("[JOB_Creation].[Tax].[proc_TIN_ERCALoadByPrimaryKey_Licence_ID]", request);
            GetprocTINERCALoadAllListVm vm = new GetprocTINERCALoadAllListVm
            {
                procTINERCAs = _mapper.Map<IList<TINERCA>, IList<GetprocTINERCALoadAllVm>>(procTINERCAs)
            };

            return vm;
        }
    }
}
