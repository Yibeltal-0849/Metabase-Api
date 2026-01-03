

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.EmplyeeTypePostingGroup.EmplyeeTypePostingGroupUpdate.EmplyeeTypePostingGroupUpdateCommand
{

    /// @author  Shimels Alem  c_Account_CatUpdate stored procedure.


    public class EmplyeeTypePostingGroupUpdateHandler : IRequestHandler<EmplyeeTypePostingGroupUpdateCommand, IList<Emplyee_Type_Posting_GroupID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public EmplyeeTypePostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Emplyee_Type_Posting_GroupID>> Handle(EmplyeeTypePostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Emplyee_Type_Posting_GroupID> result = await _procedureAdabter
                .Execute<Emplyee_Type_Posting_GroupID>("[FINA].[proc_Emplyee_Type_Posting_GroupUpdate]", request);
           

            return result;
        }
    }
}
 