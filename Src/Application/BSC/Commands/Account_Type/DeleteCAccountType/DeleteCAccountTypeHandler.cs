using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Account_Type.DeleteCAccountType
{
    public class DeleteCAccountTypeHandler : IRequestHandler<DeleteCAccountTypeCommand, IList<Proc_C_Account_Type_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCAccountTypeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Account_Type_Id>> Handle(DeleteCAccountTypeCommand request, CancellationToken cancellationToken)
        {
            long? Id = request.Id;
            IList<Proc_C_Account_Type_Id> result = await _procedureAdabter
                .Execute<Proc_C_Account_Type_Id>("[BSC].[proc_c_Account_TypeDelete]", (nameof(Id), Id));

            return result;
        }
    }
}
