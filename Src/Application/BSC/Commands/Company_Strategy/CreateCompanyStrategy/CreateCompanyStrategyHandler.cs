using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Company_Strategy.CreateCompanyStrategy
{
    public class CreateCompanyStrategyHandler : IRequestHandler<CreateCompanyStrategyCommand, IList<Proc_Company_Strategy_Strategy_NO>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateCompanyStrategyHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_Company_Strategy_Strategy_NO>> Handle(CreateCompanyStrategyCommand request, CancellationToken cancellationToken)
        {
            string Strategy_NO = request.Strategy_NO;
            Guid Organization_code = request.Organization_code;
            string Title = request.Title;
            string Version = request.Version;
            string Vision = request.Vision;
            string Mission = request.Mission;
            string Values = request.Values;
            byte [] File = request.File;
            int? Start_Year = request.Start_Year;
            int? End_Year = request.End_Year;
            System.Guid?ApplicationCode = request.ApplicationCode;
            string Application_NO = request.Application_NO;
            string DocNo = request.DocNo;
            string Log = request.Log;
            bool? ISActive = request.ISActive;
            IList<Proc_Company_Strategy_Strategy_NO> result = await _procedureAdabter
                .Execute<Proc_Company_Strategy_Strategy_NO>("[BSC].[proc_Company_StrategyInsert]", (nameof(Strategy_NO), Strategy_NO),
                (nameof(Organization_code), Organization_code), (nameof(Title), Title),
                (nameof(Version), Version), (nameof(Vision), Vision), (nameof(Mission), Mission),
                (nameof(Values), Values), (nameof(File), File), (nameof(Start_Year), Start_Year),
                (nameof(End_Year), End_Year), (nameof(ApplicationCode), ApplicationCode)
                , (nameof(Application_NO), Application_NO), (nameof(DocNo), DocNo)
                , (nameof(Log), Log), (nameof(ISActive), ISActive));

            return result;
        }

    }
}
