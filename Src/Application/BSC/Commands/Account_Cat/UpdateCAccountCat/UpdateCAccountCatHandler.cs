using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Account_Cat.UpdateCAccountCat
{
    public class UpdateCAccountCatHandler : IRequestHandler<UpdateCAccountCatCommand, IList<Proc_C_Account_Cat_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCAccountCatHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Account_Cat_Code>> Handle(UpdateCAccountCatCommand request, CancellationToken cancellationToken)
        {
            int? Code = request.Code;
            string Name = request.Name;

            IList<Proc_C_Account_Cat_Code> result = await _procedureAdabter
                .Execute<Proc_C_Account_Cat_Code>("[BSC].[proc_c_Account_CatUpdate]", (nameof(Code), Code), (nameof(Name), Name));

            return result;
        }
    }
}
