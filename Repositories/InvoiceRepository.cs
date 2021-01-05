using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZenBD_API.Models;

namespace ZenBD_API.Repositories
{
    public class InvoiceRepository:Repository<Invoice>
    {
        public List<Invoice> GetAllInvoice(int id)
        {
            return GetAll().Where(x=>x.UserId ==id).ToList();
        }
        public int GetLatestInvoice()
        {
            return GetAll().Max(x=>x.InvoiceNumber);
        }
        
    }
}