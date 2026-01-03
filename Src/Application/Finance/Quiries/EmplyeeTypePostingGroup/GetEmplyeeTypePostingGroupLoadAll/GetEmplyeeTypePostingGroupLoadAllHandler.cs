using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.EmplyeeTypePostingGroup.GetEmplyeeTypePostingGroupLoadAll
{
    class GetEmplyeeTypePostingGroupLoadAllHandler : IRequestHandler<GetEmplyeeTypePostingGroupLoadAllQuery, GetEmplyeeTypePostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetEmplyeeTypePostingGroupLoadAllHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetEmplyeeTypePostingGroupLoadAllListVm> Handle(GetEmplyeeTypePostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Emplyee_Type_Posting_Group> procEmployeeType = await _procedureAdabter
               .Execute<Emplyee_Type_Posting_Group>("[FINA].[proc_Emplyee_Type_Posting_GroupLoadAll]");
            GetEmplyeeTypePostingGroupLoadAllListVm vm = new GetEmplyeeTypePostingGroupLoadAllListVm
            {
                procEmployeeType = _mapper.Map<IList<Emplyee_Type_Posting_Group>, IList<GetEmplyeeTypePostingGroupLoadAllVm>>(procEmployeeType)
            };

            return vm;
        }
    }
}
