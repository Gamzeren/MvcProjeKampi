﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContactcService
    {
        List<Contact> GetList();
        void ContactAdd(Contact contact);

        Contact GetByID(int id);

        void ContactDelete(Contact contact);

        void ContactUpdate(Contact contact);
    }
}
