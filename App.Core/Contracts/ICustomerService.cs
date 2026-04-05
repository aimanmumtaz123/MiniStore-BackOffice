using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Models;

namespace App.Core.Contracts
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(String id);
        void Add (Customer customer);
        void Update (Customer customer);
        void Delete(String id);
        List<Customer> Search(string query);

    }
}
