using RP_IT_ERP.Application.ViewModels.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Interfaces
{
    public interface IClientService
    {
        int AddClient(AddClientVm client);
    }
}
