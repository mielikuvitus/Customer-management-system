using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//if(textBox1.Text == string.Empty || textBox2.Text == string.Empty) VALIDATION

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

        /* public string getPreferredContact()
            {
            //string preferredContact = null;
            //preferredContact = txtboxPreferredContact.Text;

                if (PreferredContact == "email")
                {
                    Console.WriteLine("Email: " + Email);
                }

                if (PreferredContact == "skype")
                {
                    Console.WriteLine("Skype: " + SkypeID);       
                }

                if (PreferredContact == "telephone")
                {
                    Console.WriteLine("Tel: " + Telephone);
                }
            }*/
    }
}
