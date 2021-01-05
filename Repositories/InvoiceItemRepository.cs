using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZenBD_API.Models;

namespace ZenBD_API.Repositories
{
    public class InvoiceItemRepository:Repository<InvoiceItem>
    {
        public List<InvoiceItem> GetAllItem(int id)
        {
            return GetAll().Where(x=>x.InvoiceNumber==id).ToList();
        }
    }
}