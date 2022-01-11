using AutoMapper;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Element;
using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Services
{
    public class ElementService : IElementService
    {
        private readonly IElementRepository _elementRepository;
        private readonly IMapper _mapper;
        public ElementService(IMapper mapper, IElementRepository elementRepository)
        {
            _elementRepository = elementRepository;
            _mapper = mapper;
        }

        public int AddElement(AddElementVm element)
        {
            var elementDto = _mapper.Map<RP_IT_ERP.Domain.Model.Element>(element);
            var id = _elementRepository.AddElement(elementDto);
            return id;
        }
    }
}
