namespace Personal_Information
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fathersNameTextBox = new System.Windows.Forms.TextBox();
            this.mothersNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllInformationButton = new System.Windows.Forms.Button();
            this.nameButtonBox = new System.Windows.Forms.Button();
            this.parentsbuttonBox = new System.Windows.Forms.Button();
            this.addressButtonBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Father\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mother\'s Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(203, 102);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(203, 132);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // fathersNameTextBox
            // 
            this.fathersNameTextBox.Location = new System.Drawing.Point(203, 158);
            this.fathersNameTextBox.Name = "fathersNameTextBox";
            this.fathersNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.fathersNameTextBox.TabIndex = 2;
            // 
            // mothersNameTextBox
            // 
            this.mothersNameTextBox.Location = new System.Drawing.Point(203, 193);
            this.mothersNameTextBox.Name = "mothersNameTextBox";
            this.mothersNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.mothersNameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(203, 225);
            this.addressTextBox.MinimumSize = new System.Drawing.Size(4, 5);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 83);
            this.addressTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(203, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllInformationButton
            // 
            this.showAllInformationButton.Location = new System.Drawing.Point(299, 335);
            this.showAllInformationButton.Name = "showAllInformationButton";
            this.showAllInformationButton.Size = new System.Drawing.Size(205, 23);
            this.showAllInformationButton.TabIndex = 3;
            this.showAllInformationButton.Text = "Show All Information";
            this.showAllInformationButton.UseVisualStyleBackColor = true;
            this.showAllInformationButton.Click += new System.EventHandler(this.showAllInformationButton_Click);
            // 
            // nameButtonBox
            // 
            this.nameButtonBox.Location = new System.Drawing.Point(203, 377);
            this.nameButtonBox.Name = "nameButtonBox";
            this.nameButtonBox.Size = new System.Drawing.Size(75, 23);
            this.nameButtonBox.TabIndex = 3;
            this.nameButtonBox.Text = "Name";
            this.nameButtonBox.UseVisualStyleBackColor = true;
            this.nameButtonBox.Click += new System.EventHandler(this.nameButtonBox_Click);
            // 
            // parentsbuttonBox
            // 
            this.parentsbuttonBox.Location = new System.Drawing.Point(299, 377);
            this.parentsbuttonBox.Name = "parentsbuttonBox";
            this.parentsbuttonBox.Size = new System.Drawing.Size(113, 23);
            this.parentsbuttonBox.TabIndex = 3;
            this.parentsbuttonBox.Text = "Parent\'s Name";
            this.parentsbuttonBox.UseVisualStyleBackColor = true;
            this.parentsbuttonBox.Click += new System.EventHandler(this.parentsbuttonBox_Click);
            // 
            // addressButtonBox
            // 
            this.addressButtonBox.Location = new System.Drawing.Point(429, 377);
            this.addressButtonBox.Name = "addressButtonBox";
            this.addressButtonBox.Size = new System.Drawing.Size(75, 23);
            this.addressButtonBox.TabIndex = 3;
            this.addressButtonBox.Text = "Address";
            this.addressButtonBox.UseVisualStyleBackColor = true;
            this.addressButtonBox.Click += new System.EventHandler(this.addressButtonBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addressButtonBox);
            this.Controls.Add(this.parentsbuttonBox);
            this.Controls.Add(this.nameButtonBox);
            this.Controls.Add(this.showAllInformationButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.mothersNameTextBox);
            this.Controls.Add(this.fathersNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fathersNameTextBox;
        private System.Windows.Forms.TextBox mothersNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllInformationButton;
        private System.Windows.Forms.Button nameButtonBox;
        private System.Windows.Forms.Button parentsbuttonBox;
        private System.Windows.Forms.Button addressButtonBox;
    }
}

