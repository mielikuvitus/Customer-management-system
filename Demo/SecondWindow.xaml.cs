using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObjects;

namespace Demo
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    
    /*Suvi Helin (40325472)
     * Second window
     * gets its data from the mailinglist,
     * has a loop that finds the ids added to the store and get the id, name and surname
     * and the preferred contact using the getPreferredContact method from the customer class
     * builds a treeview of the data
     * 31.10.2018
     */

    public partial class SecondWindow : Window
    {
        MailingList store;
        public SecondWindow(MailingList store)
        {
            this.store = store;
            InitializeComponent();

            for (int i = 0; i < store.ids.Count; i++)
            {
                Customer aCust = store.find(store.ids[i]);
                string preferredContact = aCust.getPreferredContact();
                TreeViewItem tv = new TreeViewItem();
                tv.Header = (aCust.ID.ToString() + " " + aCust.FirstName + " " + aCust.SurName);
                tv.Items.Add("Preferred contact: " + preferredContact);
                st.Children.Add(tv);
            }
 
           
        }

     
        
    }
}
