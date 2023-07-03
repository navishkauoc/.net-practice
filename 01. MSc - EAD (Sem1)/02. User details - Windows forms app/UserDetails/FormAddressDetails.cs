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
    public partial class FormAddressDetails : Form
    {

        User user;
        FormMain formMain;

        public FormAddressDetails(FormMain mainForm)
        {
            InitializeComponent();
            formMain = mainForm;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            user = new User();
            user.FirstName = this.textBoxFirstName.Text;
            user.LastName = this.textBoxLastName.Text;
            user.Address = this.textBoxAddress.Text;
            user.City = this.textBoxCity.Text;
            user.Postcode = this.textBoxPostCode.Text;
            formMain.UpdateLabel("User successfully saved!");
            this.Close();
        }
    }
}
