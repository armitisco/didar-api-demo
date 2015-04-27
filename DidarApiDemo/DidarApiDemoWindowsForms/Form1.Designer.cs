namespace DidarApiDemoWindowsForms
{
	partial class Form1
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
			this.apiKeyTextBox = new System.Windows.Forms.TextBox();
			this.getBizDomainDataButton = new System.Windows.Forms.Button();
			this.getUsersButton = new System.Windows.Forms.Button();
			this.getContactsButton = new System.Windows.Forms.Button();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
			this.addContactButton = new System.Windows.Forms.Button();
			this.workPhoneTextBox = new System.Windows.Forms.TextBox();
			this.workPhoneExtensionTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// apiKeyTextBox
			// 
			this.apiKeyTextBox.Location = new System.Drawing.Point(12, 12);
			this.apiKeyTextBox.Name = "apiKeyTextBox";
			this.apiKeyTextBox.Size = new System.Drawing.Size(280, 20);
			this.apiKeyTextBox.TabIndex = 0;
			// 
			// getBizDomainDataButton
			// 
			this.getBizDomainDataButton.Location = new System.Drawing.Point(12, 38);
			this.getBizDomainDataButton.Name = "getBizDomainDataButton";
			this.getBizDomainDataButton.Size = new System.Drawing.Size(280, 23);
			this.getBizDomainDataButton.TabIndex = 1;
			this.getBizDomainDataButton.Text = "Get BizDomain Data";
			this.getBizDomainDataButton.UseVisualStyleBackColor = true;
			this.getBizDomainDataButton.Click += new System.EventHandler(this.getBizDomainDataButton_Click);
			// 
			// getUsersButton
			// 
			this.getUsersButton.Location = new System.Drawing.Point(12, 67);
			this.getUsersButton.Name = "getUsersButton";
			this.getUsersButton.Size = new System.Drawing.Size(280, 23);
			this.getUsersButton.TabIndex = 2;
			this.getUsersButton.Text = "Get Users";
			this.getUsersButton.UseVisualStyleBackColor = true;
			this.getUsersButton.Click += new System.EventHandler(this.getUsersButton_Click);
			// 
			// getContactsButton
			// 
			this.getContactsButton.Location = new System.Drawing.Point(12, 96);
			this.getContactsButton.Name = "getContactsButton";
			this.getContactsButton.Size = new System.Drawing.Size(280, 23);
			this.getContactsButton.TabIndex = 3;
			this.getContactsButton.Text = "Get Contacts";
			this.getContactsButton.UseVisualStyleBackColor = true;
			this.getContactsButton.Click += new System.EventHandler(this.getContactsButton_Click);
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new System.Drawing.Point(12, 125);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(60, 20);
			this.titleTextBox.TabIndex = 4;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(78, 125);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.firstNameTextBox.TabIndex = 5;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(184, 125);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.lastNameTextBox.TabIndex = 6;
			// 
			// mobilePhoneTextBox
			// 
			this.mobilePhoneTextBox.Location = new System.Drawing.Point(12, 151);
			this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
			this.mobilePhoneTextBox.Size = new System.Drawing.Size(109, 20);
			this.mobilePhoneTextBox.TabIndex = 7;
			// 
			// addContactButton
			// 
			this.addContactButton.Location = new System.Drawing.Point(12, 176);
			this.addContactButton.Name = "addContactButton";
			this.addContactButton.Size = new System.Drawing.Size(280, 23);
			this.addContactButton.TabIndex = 8;
			this.addContactButton.Text = "Add Contact";
			this.addContactButton.UseVisualStyleBackColor = true;
			this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
			// 
			// workPhoneTextBox
			// 
			this.workPhoneTextBox.Location = new System.Drawing.Point(127, 151);
			this.workPhoneTextBox.Name = "workPhoneTextBox";
			this.workPhoneTextBox.Size = new System.Drawing.Size(104, 20);
			this.workPhoneTextBox.TabIndex = 9;
			// 
			// workPhoneExtensionTextBox
			// 
			this.workPhoneExtensionTextBox.Location = new System.Drawing.Point(237, 151);
			this.workPhoneExtensionTextBox.Name = "workPhoneExtensionTextBox";
			this.workPhoneExtensionTextBox.Size = new System.Drawing.Size(47, 20);
			this.workPhoneExtensionTextBox.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 266);
			this.Controls.Add(this.workPhoneExtensionTextBox);
			this.Controls.Add(this.workPhoneTextBox);
			this.Controls.Add(this.addContactButton);
			this.Controls.Add(this.mobilePhoneTextBox);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.titleTextBox);
			this.Controls.Add(this.getContactsButton);
			this.Controls.Add(this.getUsersButton);
			this.Controls.Add(this.getBizDomainDataButton);
			this.Controls.Add(this.apiKeyTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox apiKeyTextBox;
		private System.Windows.Forms.Button getBizDomainDataButton;
		private System.Windows.Forms.Button getUsersButton;
		private System.Windows.Forms.Button getContactsButton;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox mobilePhoneTextBox;
		private System.Windows.Forms.Button addContactButton;
		private System.Windows.Forms.TextBox workPhoneTextBox;
		private System.Windows.Forms.TextBox workPhoneExtensionTextBox;
	}
}

