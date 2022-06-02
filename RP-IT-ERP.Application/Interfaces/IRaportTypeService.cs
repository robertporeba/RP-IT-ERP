using RP_IT_ERP.Application.ViewModels.RaportType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Interfaces
{
    public interface IRaportTypeService
    {
        int AddRaportType(AddRaportTypeVm raportType);
        void DeleteRaportType(int raportTypeId);
        ListGetRaportTypesVm GetAllRaportTypes();
    }
}
