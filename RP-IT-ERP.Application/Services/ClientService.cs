using AutoMapper;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Client;
using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
        public ClientService(IMapper mapper, IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public int AddClient(AddClientVm client)
        {
            var clientDto = _mapper.Map<RP_IT_ERP.Domain.Model.Client>(client);
            var id = _clientRepository.AddClient(clientDto);
            return id;
        }
    }
}
