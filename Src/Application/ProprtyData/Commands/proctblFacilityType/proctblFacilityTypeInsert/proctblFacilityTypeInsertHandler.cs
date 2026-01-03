



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblFacilityType.proctblFacilityTypeInsert.proctblFacilityTypeInsertCommand
{

    /// @author  Shimels Alem  proc_tblFacility_TypeInsert stored procedure.


    public class proctblFacilityTypeInsertHandler : IRequestHandler<proctblFacilityTypeInsertCommand, IList<tblFacility_Type_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFacilityTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFacility_Type_id>> Handle( proctblFacilityTypeInsertCommand request, CancellationToken cancellationToken)
        {
            long? id = request.id;
            string Name = request.Name;
            string Enable = request.Enable;
            System.DateTime? Created_Date = request.Created_Date;
            long? Created_By = request.Created_By;
            System.DateTime? Update_Date = request.Update_Date;
            byte[] Last_Modified = request.Last_Modified;

            IList<tblFacility_Type_id> result = await _procedureAdabter
                    .Execute<tblFacility_Type_id>("[ProprtyData].proc_tblFacility_TypeInsert",
                     (nameof(id), id),
                     (nameof(Name), Name),
                     (nameof(Enable), Enable),
                     (nameof(Created_Date), Created_Date),
                     (nameof(Created_By), Created_By), 
                     (nameof(Update_Date), Update_Date),
                     (nameof(Last_Modified), Last_Modified));
           

                return result;
        }
    }
}
 