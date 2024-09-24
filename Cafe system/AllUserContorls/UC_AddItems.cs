using System;
using System.Windows.Forms;

namespace CafeManagementVideo.AllUserContorls
{
    public partial class UC_AddItems : UserControl
    {

        function fn = new function() { };
        string query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name, category, price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void btnAddItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
