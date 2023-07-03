
namespace UserDetails
{
    partial class FormAddressDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelfirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelfirstName
            // 
            this.labelfirstName.AutoSize = true;
            this.labelfirstName.Location = new System.Drawing.Point(103, 89);
            this.labelfirstName.Name = "labelfirstName";
            this.labelfirstName.Size = new System.Drawing.Size(57, 13);
            this.labelfirstName.TabIndex = 0;
            this.labelfirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(104, 116);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Second Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(104, 142);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(104, 168);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(62, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City / Town";
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Location = new System.Drawing.Point(104, 194);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(56, 13);
            this.labelPostCode.TabIndex = 4;
            this.labelPostCode.Text = "Post Code";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(210, 86);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(129, 20);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(210, 113);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(129, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(210, 139);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(129, 20);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(210, 165);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(129, 20);
            this.textBoxCity.TabIndex = 8;
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Location = new System.Drawing.Point(210, 191);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(129, 20);
            this.textBoxPostCode.TabIndex = 9;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(373, 277);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormAddressDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxPostCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPostCode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelfirstName);
            this.Name = "FormAddressDetails";
            this.Text = "Enter Your Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.Button buttonSubmit;
    }
}