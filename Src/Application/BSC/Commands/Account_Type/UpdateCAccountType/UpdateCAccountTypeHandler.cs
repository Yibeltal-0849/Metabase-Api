using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Account_Type.UpdateCAccountType
{
    public class UpdateCAccountTypeHandler : IRequestHandler<UpdateCAccountTypeCommand, IList<Proc_C_Account_Type_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCAccountTypeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Account_Type_Id>> Handle(UpdateCAccountTypeCommand request, CancellationToken cancellationToken)
        {
            long? Id = request.Id;
            string Name = request.Name;
            int? Catagory = request.Catagory;
            IList<Proc_C_Account_Type_Id> result = await _procedureAdabter
                .Execute<Proc_C_Account_Type_Id>("[BSC].[proc_c_Account_TypeUpdate]", (nameof(Id), Id), (nameof(Name), Name),
                (nameof(Catagory), Catagory));

            return result;
        }
    }
}
