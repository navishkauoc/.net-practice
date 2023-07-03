using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDetails
{
    public partial class FormMain : Form
    {

        FormAddressDetails formAddressDetails;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAddressDetails = new FormAddressDetails(this);
            formAddressDetails.Activate();
            formAddressDetails.ShowDialog();
        }

        public void UpdateLabel(string message)
        {
            // Update the label text with the new value
            labelMessage.Text = message;
        }
    }
}
