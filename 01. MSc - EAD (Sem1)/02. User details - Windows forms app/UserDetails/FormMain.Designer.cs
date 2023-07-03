
namespace UserDetails
{
    partial class FormMain
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
            this.buttonEnterDetails = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnterDetails
            // 
            this.buttonEnterDetails.Location = new System.Drawing.Point(560, 297);
            this.buttonEnterDetails.Name = "buttonEnterDetails";
            this.buttonEnterDetails.Size = new System.Drawing.Size(123, 23);
            this.buttonEnterDetails.TabIndex = 0;
            this.buttonEnterDetails.Text = "Enter your details";
            this.buttonEnterDetails.UseVisualStyleBackColor = true;
            this.buttonEnterDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Review your details";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(133, 73);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEnterDetails);
            this.Name = "FormMain";
            this.Text = "Your Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterDetails;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMessage;
    }
}

