using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.EmplyeeTypePostingGroup.GetEmplyeeTypePostingGroupLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.EmplyeeTypePostingGroup.GetEmplyeeTypePostingGroupByPrimaryKey
{
    public class GetEmplyeeTypePostingGroupByPrimaryKeyQueryHandler : IRequestHandler<GetEmplyeeTypePostingGroupByPrimaryKey, GetEmplyeeTypePostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetEmplyeeTypePostingGroupByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetEmplyeeTypePostingGroupLoadAllListVm> Handle(GetEmplyeeTypePostingGroupByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Emplyee_Type_Posting_Group> procEmployeeType = await _procedureAdabter
               .Execute<Emplyee_Type_Posting_Group>("[FINA].[proc_Emplyee_Type_Posting_GroupLoadByPrimaryKey]", request);
            GetEmplyeeTypePostingGroupLoadAllListVm vm = new GetEmplyeeTypePostingGroupLoadAllListVm
            {
                procEmployeeType = _mapper.Map<IList<Emplyee_Type_Posting_Group>, IList<GetEmplyeeTypePostingGroupLoadAllVm>>(procEmployeeType)
            };

            return vm;
        }
    }
}
