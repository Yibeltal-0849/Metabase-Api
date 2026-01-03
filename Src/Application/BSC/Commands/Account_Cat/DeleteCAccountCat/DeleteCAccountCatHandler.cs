using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Account_Cat.DeleteCAccountCat
{
    public class DeleteCAccountCatHandler : IRequestHandler<DeleteCAccountCatCommand, IList<Proc_C_Account_Cat_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCAccountCatHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Account_Cat_Code>> Handle(DeleteCAccountCatCommand request, CancellationToken cancellationToken)
        {
            int Code = request.Code;

            IList<Proc_C_Account_Cat_Code> result = await _procedureAdabter
                .Execute<Proc_C_Account_Cat_Code>("[BSC].[proc_c_Account_CatDelete]", (nameof(Code), Code));

            return result;
        }
    }
}
