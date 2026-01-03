

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cAccountCat.cAccountCatUpdate.cAccountCatUpdateCommand
{

    /// @author  Shimels Alem  c_Account_CatUpdate stored procedure.


    public class cAccountCatUpdateHandler : IRequestHandler<cAccountCatUpdateCommand, IList<Proc_C_Account_Cat_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cAccountCatUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Account_Cat_Code>> Handle( cAccountCatUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Proc_C_Account_Cat_Code> result = await _procedureAdabter
                .Execute<Proc_C_Account_Cat_Code>("[FINA].c_Account_CatUpdate", request);
           

            return result;
        }
    }
}
 