﻿using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Interfaces
{
    public interface IRaportRepository
    {
        int AddRaport(Raport raport);
        void DeleteRaport(int raportId);
        IQueryable<Raport> GetAllRaports();
        Raport GetRaport(int raportId);
    }
}
