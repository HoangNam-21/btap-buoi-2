using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtapT2
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txt_LastName.Text);
            it.SubItems.Add(txt_FirstName.Text);
            it.SubItems.Add(txt_Phone.Text);
            lvStudent.Items.Add(it);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem item = lvStudent.SelectedItems[0];
                item.SubItems[0].Text = txt_LastName.Text;
                item.SubItems[1].Text = txt_FirstName.Text;
                item.SubItems[2].Text = txt_Phone.Text;

            }
            else
            {
                MessageBox.Show("Chon dong de sua!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                lvStudent.Items.RemoveAt(lvStudent.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Chon dong de xoa!");
            }
        }
    }
}
