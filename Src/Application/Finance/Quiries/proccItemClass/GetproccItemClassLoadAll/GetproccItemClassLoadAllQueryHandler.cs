using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccItemClass.GetproccItemClassLoadAll
{
    class GetproccItemClassLoadAllQueryHandler : IRequestHandler<GetproccItemClassLoadAllQuery, GetproccItemClassLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccItemClassLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccItemClassLoadAllListVm> Handle(GetproccItemClassLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CItemClass> proccItemClasss = await _procedureAdabter
               .Execute<CItemClass>("[FINA].[proc_c_ItemClassLoadAll]");
            GetproccItemClassLoadAllListVm vm = new GetproccItemClassLoadAllListVm
            {
                proccItemClasss = _mapper.Map<IList<CItemClass>, IList<GetproccItemClassLoadAllVm>>(proccItemClasss)
            };

            return vm;
        }
    }
}
