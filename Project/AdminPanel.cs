using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            permissionList.ItemCheck += new ItemCheckEventHandler(permissionList_ItemCheck); // Attach the ItemCheck event handler.
            // should add a function to check who's the user and change the Welcome message
        }

        private void permissionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // the list should display existed user(s)
        }

        private void permissionList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // If an item is being checked
            if (e.NewValue == CheckState.Checked)
            {
                // Iterate through all items
                for (int i = 0; i < permissionList.Items.Count; i++)
                {
                    // and uncheck all except the one that is currently being checked.
                    if (i != e.Index)
                    {
                        permissionList.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
