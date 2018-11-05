using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Neil Urquhart
 *A blueprint for the Mailinglist object. 
 *Has methods for adding a customer to the mailing list,
 * finding a customer from the list using customer id,
 * deleting a customer from the list using customer id 
 * and keeping a list of ids with a possibility to get them from the list
 */

namespace BusinessObjects
{
    public class MailingList
    {
        private List<Customer> _list = new List<Customer>();

        
        // method for adding a customer to the list od customers
       
        public void add(Customer newCustomer)
        {
            _list.Add(newCustomer);
        }

        // method for finding a customer from the list using id
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

        // method for deleting a customer from the list using id
        public void delete(int id)
        {
            Customer c = this.find(id);
            if (c != null)
            {
                _list.Remove(c);
            }

        }

        // a list for all the ids and a get funcion for the ids
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
