using AutoMapper;
using AutoMapper.QueryableExtensions;
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

        public void DeleteClient(int clientId)
        {
            _clientRepository.DeleteClient(clientId);
        }

        public ListGetClientsVm GetAllClients()
        {
            var clients = _clientRepository.GetAllClients().ProjectTo<GetClientVm>(_mapper.ConfigurationProvider).ToList();
            var clientsList = new ListGetClientsVm()
            {
                Clients = clients
            };
            return clientsList;
        }

        public GetClientVm GetClient(int clientId)
        {
            var client = _clientRepository.GetClient(clientId);
            var clientVm = _mapper.Map<GetClientVm>(client);
            return clientVm;
        }

        public void UpdateClient(UpdateClientVm client)
        {
            var clientDto = _mapper.Map<RP_IT_ERP.Domain.Model.Client>(client);
            _clientRepository.UpdateClient(clientDto);
        }
    }
}
