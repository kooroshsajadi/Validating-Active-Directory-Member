namespace LoginForm
{
    partial class Form
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
            this.TxtBoxUsername = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.TxtBoxAddress = new System.Windows.Forms.TextBox();
            this.labelDomain = new System.Windows.Forms.Label();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.groupBoxDomain = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchUser = new System.Windows.Forms.GroupBox();
            this.groupBoxCredentials.SuspendLayout();
            this.groupBoxDomain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBoxUsername
            // 
            this.TxtBoxUsername.Location = new System.Drawing.Point(157, 34);
            this.TxtBoxUsername.Name = "TxtBoxUsername";
            this.TxtBoxUsername.Size = new System.Drawing.Size(132, 20);
            this.TxtBoxUsername.TabIndex = 0;
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Location = new System.Drawing.Point(157, 69);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.PasswordChar = '*';
            this.TxtBoxPassword.Size = new System.Drawing.Size(132, 20);
            this.TxtBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(87, 37);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(53, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(87, 72);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(52, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "password";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(264, 253);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.labelUsername);
            this.groupBoxCredentials.Controls.Add(this.TxtBoxPassword);
            this.groupBoxCredentials.Controls.Add(this.TxtBoxUsername);
            this.groupBoxCredentials.Controls.Add(this.labelPassword);
            this.groupBoxCredentials.Location = new System.Drawing.Point(23, 39);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(316, 120);
            this.groupBoxCredentials.TabIndex = 5;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "Credentials";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(631, 457);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(132, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Visible = false;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(470, 457);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(134, 13);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Email/Username to Search";
            this.labelSearch.Visible = false;
            // 
            // TxtBoxAddress
            // 
            this.TxtBoxAddress.Location = new System.Drawing.Point(157, 38);
            this.TxtBoxAddress.Name = "TxtBoxAddress";
            this.TxtBoxAddress.Size = new System.Drawing.Size(132, 20);
            this.TxtBoxAddress.TabIndex = 6;
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(97, 41);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(43, 13);
            this.labelDomain.TabIndex = 5;
            this.labelDomain.Text = "Domain";
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(871, 457);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.Size = new System.Drawing.Size(14, 33);
            this.textBoxInformation.TabIndex = 6;
            this.textBoxInformation.Visible = false;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(811, 441);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(74, 13);
            this.labelInformation.TabIndex = 7;
            this.labelInformation.Text = "Search Result";
            this.labelInformation.Visible = false;
            // 
            // groupBoxDomain
            // 
            this.groupBoxDomain.Controls.Add(this.labelDomain);
            this.groupBoxDomain.Controls.Add(this.TxtBoxAddress);
            this.groupBoxDomain.Location = new System.Drawing.Point(23, 165);
            this.groupBoxDomain.Name = "groupBoxDomain";
            this.groupBoxDomain.Size = new System.Drawing.Size(316, 82);
            this.groupBoxDomain.TabIndex = 8;
            this.groupBoxDomain.TabStop = false;
            this.groupBoxDomain.Text = "Domain";
            // 
            // groupBoxSearchUser
            // 
            this.groupBoxSearchUser.Location = new System.Drawing.Point(287, 432);
            this.groupBoxSearchUser.Name = "groupBoxSearchUser";
            this.groupBoxSearchUser.Size = new System.Drawing.Size(150, 45);
            this.groupBoxSearchUser.TabIndex = 9;
            this.groupBoxSearchUser.TabStop = false;
            this.groupBoxSearchUser.Text = "Search User";
            this.groupBoxSearchUser.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 316);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.groupBoxSearchUser);
            this.Controls.Add(this.groupBoxDomain);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.groupBoxCredentials);
            this.Name = "Form";
            this.groupBoxCredentials.ResumeLayout(false);
            this.groupBoxCredentials.PerformLayout();
            this.groupBoxDomain.ResumeLayout(false);
            this.groupBoxDomain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxUsername;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox TxtBoxAddress;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.GroupBox groupBoxDomain;
        private System.Windows.Forms.GroupBox groupBoxSearchUser;
    }
}

