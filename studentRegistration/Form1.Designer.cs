namespace StudentRegistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lastName = new TextBox();
            firstName = new TextBox();
            middleName = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            monthBox = new ComboBox();
            yearBox = new ComboBox();
            dayBox = new ComboBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 28);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "Last name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 2;
            label3.Text = "First name*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(147, 28);
            label4.TabIndex = 3;
            label4.Text = "Middle name*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 4;
            label5.Text = "Gender*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 279);
            label6.Name = "label6";
            label6.Size = new Size(145, 28);
            label6.TabIndex = 5;
            label6.Text = "Date of birth*";
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastName.Location = new Point(14, 77);
            lastName.Name = "lastName";
            lastName.Size = new Size(272, 34);
            lastName.TabIndex = 6;
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstName.Location = new Point(14, 142);
            firstName.Name = "firstName";
            firstName.Size = new Size(272, 34);
            firstName.TabIndex = 7;
            // 
            // middleName
            // 
            middleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            middleName.Location = new Point(14, 208);
            middleName.Name = "middleName";
            middleName.Size = new Size(272, 34);
            middleName.TabIndex = 8;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbMale.Location = new Point(109, 248);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(77, 32);
            rbMale.TabIndex = 10;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbFemale.Location = new Point(194, 248);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(98, 32);
            rbFemale.TabIndex = 11;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // monthBox
            // 
            monthBox.FormattingEnabled = true;
            monthBox.Location = new Point(16, 311);
            monthBox.Name = "monthBox";
            monthBox.Size = new Size(89, 28);
            monthBox.TabIndex = 12;
            // 
            // yearBox
            // 
            yearBox.FormattingEnabled = true;
            yearBox.Location = new Point(194, 311);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(92, 28);
            yearBox.TabIndex = 13;
            // 
            // dayBox
            // 
            dayBox.FormattingEnabled = true;
            dayBox.Location = new Point(111, 311);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(77, 28);
            dayBox.TabIndex = 14;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Firebrick;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = SystemColors.ControlLightLight;
            registerButton.Location = new Point(57, 354);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(176, 46);
            registerButton.TabIndex = 15;
            registerButton.Text = "Register student";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 422);
            Controls.Add(registerButton);
            Controls.Add(dayBox);
            Controls.Add(yearBox);
            Controls.Add(monthBox);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox lastName;
        private TextBox firstName;
        private TextBox middleName;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private ComboBox monthBox;
        private ComboBox yearBox;
        private ComboBox dayBox;
        private Button registerButton;
    }
}