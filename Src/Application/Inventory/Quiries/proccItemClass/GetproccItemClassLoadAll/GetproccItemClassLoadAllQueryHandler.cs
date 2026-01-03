using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.proccItemClass.GetproccItemClassLoadAll
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
            IList<c_ItemClass> proccItemClasss = await _procedureAdabter
               .Execute<c_ItemClass>("[Inventory].[proc_c_ItemClassLoadAll]");
            GetproccItemClassLoadAllListVm vm = new GetproccItemClassLoadAllListVm
            {
                proccItemClasss = _mapper.Map<IList<c_ItemClass>, IList<GetproccItemClassLoadAllVm>>(proccItemClasss)
            };

            return vm;
        }
    }
}
