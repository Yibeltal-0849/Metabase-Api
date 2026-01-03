

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.Depreciation_Book.Depreciation_BookUpdate.Depreciation_BookUpdateCommand
{

    /// @author  Shimels Alem  Document_TypeUpdate stored procedure.


    public class Depreciation_BookUpdateHandler : IRequestHandler<Depreciation_BookUpdateCommand, IList<Depreciation_Bookid>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Depreciation_BookUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Depreciation_Bookid>> Handle( Depreciation_BookUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Depreciation_Bookid> result = await _procedureAdabter
                .Execute<Depreciation_Bookid>("[FINA].[proc_Depreciation_BookUpdate]", request);
           

            return result;
        }
    }
}
 