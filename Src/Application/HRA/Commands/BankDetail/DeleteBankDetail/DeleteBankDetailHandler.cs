using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.BankDetail.DeleteBankDetail
{
    public class DeleteBankDetailHandler : IRequestHandler<DeleteBankDetailCommand, IList<BankDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteBankDetailHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BankDetail_id>> Handle(DeleteBankDetailCommand request, CancellationToken cancellationToken)
        {
            Guid bankid = request.bankid;
            IList<BankDetail_id> result = await _procedureAdabter
                .Execute<BankDetail_id>("[HRA].[proc_DeleteBankDetail]",
                (nameof(bankid), bankid));

            return result;
        }
    }
}
