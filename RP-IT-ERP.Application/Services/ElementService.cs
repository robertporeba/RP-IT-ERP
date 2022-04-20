using AutoMapper;
using AutoMapper.QueryableExtensions;
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

        public void DeleteElement(int elementId)
        {
            _elementRepository.DeleteElement(elementId);
        }

        public ListGetElementsVm GetAllElements()
        {
            var elements = _elementRepository.GetAllElements().ProjectTo<GetElementVm>(_mapper.ConfigurationProvider).ToList();
            var elementsList = new ListGetElementsVm()
            {
                Elements = elements
            };
            return elementsList;
        }

        public GetElementVm GetElement(int elementId)
        {
            var element = _elementRepository.GetElement(elementId);
            var elementVm = _mapper.Map<GetElementVm>(element);
            return elementVm;
        }

        public void UpdateElement(UpdateElementVm element)
        {
            var elementDto = _mapper.Map<RP_IT_ERP.Domain.Model.Element>(element);
            _elementRepository.UpdateElement(elementDto);
        }
    }
}