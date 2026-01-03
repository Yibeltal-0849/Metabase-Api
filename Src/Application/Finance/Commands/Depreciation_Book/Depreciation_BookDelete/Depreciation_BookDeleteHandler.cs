using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.Depreciation_Book.Depreciation_BookDelete.Depreciation_BookDeleteCommand
{

    /// @author  Shimels Alem  Document_TypeDelete stored procedure.


    public class Depreciation_BookDeleteHandler : IRequestHandler<Depreciation_BookDeleteCommand, IList<Depreciation_Bookid>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Depreciation_BookDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Depreciation_Bookid>> Handle( Depreciation_BookDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Depreciation_Bookid> result = await _procedureAdabter
                .Execute<Depreciation_Bookid>("[FINA].[proc_Depreciation_BookDelete]", request);
           

            return result;
        }
    }
}
  