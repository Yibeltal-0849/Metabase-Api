using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadByOrgCode;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadByOrgCode
{
    public class GetprocItemActivityLoadByPrimaryKeyOrgnizationCodeQueryHandler : IRequestHandler<GetprocItemActivityLoadByOrgnizationCode, GetprocItemActivityLoadAllOrgCodeListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocItemActivityLoadByPrimaryKeyOrgnizationCodeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemActivityLoadAllOrgCodeListVm> Handle(GetprocItemActivityLoadByOrgnizationCode request, CancellationToken cancellationToken)
        {

            IList<ItemActivityOrgCode> procItemActivityOrgCode = await _procedureAdabter
               .Execute<ItemActivityOrgCode>("[Inventory].[proc_Item_ActivityLoadByOrgnization_Code]", request);
            GetprocItemActivityLoadAllOrgCodeListVm vm = new GetprocItemActivityLoadAllOrgCodeListVm
            {
                procItemActivityOrgCode = _mapper.Map<IList<ItemActivityOrgCode>, IList<GetprocItemActivityLoadAllOrgCodeVm>>(procItemActivityOrgCode)
            };

            return vm;
        }
    }
}
