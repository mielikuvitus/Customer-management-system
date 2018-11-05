using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class MailingList
    {
        private List<Customer> _list = new List<Customer>();

        public void add(Customer newCustomer)
        {
            _list.Add(newCustomer);
        }

        public Customer find(int id)
        {
            foreach (Customer c in _list)
            {
                if (id == c.ID)
                {
                    return c;
                }
            }

            return null;

        }

        public void delete(int id)
        {
            Customer c = this.find(id);
            if (c != null)
            {
                _list.Remove(c);
            }

        }

        public List<int> ids
        {
            get
            {
               List<int> res = new List<int>();
               foreach(Customer p in _list)
                   res.Add(p.ID);
                return res;
            }
           
        }
    }
}
