using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 *Suvi Helin (40325472)
 * A blueprint for the customer object.
 * Gets and sets ID, firstname, surname, emailaddress, skypeid, telephone and preferredcontact details
 * Also has a method called PreferredContact which gets a customers preferred contact
 * 18.10.2018
 */

namespace BusinessObjects
{
    public class Customer
    {
        private int _customerID;
        private string _firstName;
        private string _surName;
        private string _emailAddress;
        private string _skypeID;
        private string _telephone;
        private string _preferredContact;


        public int ID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string SurName
        {
            get
            {
                return _surName;
            }
            set
            {
                _surName = value;
            }
        }

        public string Email
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                _emailAddress = value;
            }
        }

        public string SkypeID
        {
            get
            {
                return _skypeID;
            }
            set
            {
                _skypeID = value;
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
            }
        }

        public string PreferredContact
        {
            get
            {
                return _preferredContact;
            }
            set
            {
                _preferredContact = value;
            }
        }

            
         public string getPreferredContact()
            {
            

                if (PreferredContact == "email")
                {
                    string result = ("Email: " + Email);
                    return result;
                }

                if (PreferredContact == "skype")
                {
                    string result =("Skype: " + SkypeID);
                    return result;
                }

                if (PreferredContact == "tel")
                {
                    string result = ("Tel: " + Telephone);
                    return result;
                }
                return "";

            }
    }
}
