using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Persist Security Info=False;User ID=sa;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-L2H4HG4\\SQLEXPRESS");

        private SqlConnection conn1 = new SqlConnection("dsfasd");
    }
}
