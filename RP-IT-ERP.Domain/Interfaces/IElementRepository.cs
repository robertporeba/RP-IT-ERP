﻿using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Interfaces
{
    public interface IElementRepository
    {
        int AddElement(Element element);
        void DeleteElement(int elementId);
        IQueryable<Element> GetAllElements();
        void UpdateElement(Element element);
        Element GetElement(int elementId);
    }
}
