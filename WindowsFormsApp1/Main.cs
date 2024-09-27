using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenContactsDetailDialog();
        }
        #endregion

        #region METHODS
        private void OpenContactsDetailDialog()
        {
            ContactDetails contactsDetail = new ContactDetails();
            contactsDetail.ShowDialog();
        }
        #endregion

    }
}
