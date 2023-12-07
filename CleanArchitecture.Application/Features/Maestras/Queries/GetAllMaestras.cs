using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Maestras.Queries
{
    public class GetAllMaestras : IRequest<List<Maestra>>
    {

    }

    public class GetAllMaestrasHandler : IRequestHandler<GetAllMaestras, List<Maestra>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllMaestrasHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<Maestra>> Handle(GetAllMaestras request, CancellationToken cancellationToken)
        {
            var entityList = await _unitOfWork.MaestraRepository.GetAllAsync();
            return _mapper.Map<List<Maestra>>(entityList);
        }
    }
}
