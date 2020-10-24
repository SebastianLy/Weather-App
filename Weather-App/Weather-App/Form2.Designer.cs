namespace Weather_App
{
    partial class Form2
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginInputTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailInputTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordInputTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.password2InputTextBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.failedLoginTextBox = new System.Windows.Forms.TextBox();
            this.failedEmailTextBox = new System.Windows.Forms.TextBox();
            this.failedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox.Location = new System.Drawing.Point(40, 15);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(200, 38);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TabStop = false;
            this.titleTextBox.Text = "Sign up";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTextBox.Location = new System.Drawing.Point(12, 94);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(150, 21);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.TabStop = false;
            this.loginTextBox.Text = "Login:";
            // 
            // loginInputTextBox
            // 
            this.loginInputTextBox.Location = new System.Drawing.Point(170, 95);
            this.loginInputTextBox.Name = "loginInputTextBox";
            this.loginInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginInputTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.Location = new System.Drawing.Point(12, 134);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(150, 21);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TabStop = false;
            this.emailTextBox.Text = "Email:";
            // 
            // emailInputTextBox
            // 
            this.emailInputTextBox.Location = new System.Drawing.Point(170, 134);
            this.emailInputTextBox.Name = "emailInputTextBox";
            this.emailInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailInputTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 172);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(150, 21);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Text = "Password:";
            // 
            // passwordInputTextBox
            // 
            this.passwordInputTextBox.Location = new System.Drawing.Point(171, 171);
            this.passwordInputTextBox.Name = "passwordInputTextBox";
            this.passwordInputTextBox.PasswordChar = '*';
            this.passwordInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordInputTextBox.TabIndex = 2;
            // 
            // password2TextBox
            // 
            this.password2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password2TextBox.Location = new System.Drawing.Point(12, 210);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.ReadOnly = true;
            this.password2TextBox.Size = new System.Drawing.Size(152, 21);
            this.password2TextBox.TabIndex = 7;
            this.password2TextBox.TabStop = false;
            this.password2TextBox.Text = "Confirm password:";
            // 
            // password2InputTextBox
            // 
            this.password2InputTextBox.Location = new System.Drawing.Point(170, 209);
            this.password2InputTextBox.Name = "password2InputTextBox";
            this.password2InputTextBox.PasswordChar = '*';
            this.password2InputTextBox.Size = new System.Drawing.Size(100, 22);
            this.password2InputTextBox.TabIndex = 3;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(95, 246);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(95, 35);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // failedLoginTextBox
            // 
            this.failedLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failedLoginTextBox.Location = new System.Drawing.Point(12, 287);
            this.failedLoginTextBox.Name = "failedLoginTextBox";
            this.failedLoginTextBox.ReadOnly = true;
            this.failedLoginTextBox.Size = new System.Drawing.Size(150, 15);
            this.failedLoginTextBox.TabIndex = 8;
            this.failedLoginTextBox.Text = "Login already exists";
            this.failedLoginTextBox.Visible = false;
            // 
            // failedEmailTextBox
            // 
            this.failedEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failedEmailTextBox.Location = new System.Drawing.Point(12, 308);
            this.failedEmailTextBox.Name = "failedEmailTextBox";
            this.failedEmailTextBox.ReadOnly = true;
            this.failedEmailTextBox.Size = new System.Drawing.Size(150, 15);
            this.failedEmailTextBox.TabIndex = 9;
            this.failedEmailTextBox.Text = "Email is already taken";
            this.failedEmailTextBox.Visible = false;
            // 
            // failedPasswordTextBox
            // 
            this.failedPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failedPasswordTextBox.Location = new System.Drawing.Point(12, 329);
            this.failedPasswordTextBox.Name = "failedPasswordTextBox";
            this.failedPasswordTextBox.ReadOnly = true;
            this.failedPasswordTextBox.Size = new System.Drawing.Size(150, 15);
            this.failedPasswordTextBox.TabIndex = 10;
            this.failedPasswordTextBox.Text = "Passwords are different";
            this.failedPasswordTextBox.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.failedPasswordTextBox);
            this.Controls.Add(this.failedEmailTextBox);
            this.Controls.Add(this.failedLoginTextBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.password2InputTextBox);
            this.Controls.Add(this.password2TextBox);
            this.Controls.Add(this.passwordInputTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailInputTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.loginInputTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox loginInputTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox emailInputTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordInputTextBox;
        private System.Windows.Forms.TextBox password2TextBox;
        private System.Windows.Forms.TextBox password2InputTextBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox failedLoginTextBox;
        private System.Windows.Forms.TextBox failedEmailTextBox;
        private System.Windows.Forms.TextBox failedPasswordTextBox;
    }
}