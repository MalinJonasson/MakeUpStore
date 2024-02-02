namespace OnlineMakeUpStore
{
    partial class UserLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogIn));
            logInLabel = new Label();
            userNameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            logInUserButton = new Button();
            newCostumerMessageLabel = new Label();
            toRegisterMemberButton = new Button();
            emailLabel = new Label();
            userNameLabel2 = new Label();
            passwordLabel2 = new Label();
            nameLabel = new Label();
            addEmailTextBox = new TextBox();
            addPasswordTextBox = new TextBox();
            addUserNameTextBox = new TextBox();
            addNameTextBox = new TextBox();
            registerButton = new Button();
            goBackButton = new Button();
            logOutButton = new Button();
            SuspendLayout();
            // 
            // logInLabel
            // 
            logInLabel.AutoSize = true;
            logInLabel.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInLabel.Location = new Point(293, 9);
            logInLabel.Name = "logInLabel";
            logInLabel.Size = new Size(145, 21);
            logInLabel.TabIndex = 0;
            logInLabel.Text = "Log in costumer";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(316, 83);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(63, 16);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(316, 156);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(63, 16);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(316, 102);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 21);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(316, 175);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 21);
            passwordTextBox.TabIndex = 4;
            // 
            // logInUserButton
            // 
            logInUserButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInUserButton.Location = new Point(326, 250);
            logInUserButton.Name = "logInUserButton";
            logInUserButton.Size = new Size(75, 29);
            logInUserButton.TabIndex = 5;
            logInUserButton.Text = "Log In";
            logInUserButton.UseVisualStyleBackColor = true;
            logInUserButton.Click += logInUserButton_Click;
            // 
            // newCostumerMessageLabel
            // 
            newCostumerMessageLabel.AutoSize = true;
            newCostumerMessageLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newCostumerMessageLabel.Location = new Point(12, 44);
            newCostumerMessageLabel.Name = "newCostumerMessageLabel";
            newCostumerMessageLabel.Size = new Size(238, 16);
            newCostumerMessageLabel.TabIndex = 6;
            newCostumerMessageLabel.Text = "Not a member yet? Register today!";
            // 
            // toRegisterMemberButton
            // 
            toRegisterMemberButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toRegisterMemberButton.Location = new Point(12, 69);
            toRegisterMemberButton.Name = "toRegisterMemberButton";
            toRegisterMemberButton.Size = new Size(75, 30);
            toRegisterMemberButton.TabIndex = 7;
            toRegisterMemberButton.Text = "Register";
            toRegisterMemberButton.UseVisualStyleBackColor = true;
            toRegisterMemberButton.Click += toRegisterMemberButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(316, 251);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(42, 16);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            emailLabel.Visible = false;
            // 
            // userNameLabel2
            // 
            userNameLabel2.AutoSize = true;
            userNameLabel2.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel2.Location = new Point(316, 134);
            userNameLabel2.Name = "userNameLabel2";
            userNameLabel2.Size = new Size(63, 16);
            userNameLabel2.TabIndex = 9;
            userNameLabel2.Text = "Username";
            userNameLabel2.Visible = false;
            // 
            // passwordLabel2
            // 
            passwordLabel2.AutoSize = true;
            passwordLabel2.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel2.Location = new Point(316, 193);
            passwordLabel2.Name = "passwordLabel2";
            passwordLabel2.Size = new Size(63, 16);
            passwordLabel2.TabIndex = 10;
            passwordLabel2.Text = "Password";
            passwordLabel2.Visible = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(316, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(35, 16);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name";
            nameLabel.Visible = false;
            // 
            // addEmailTextBox
            // 
            addEmailTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmailTextBox.Location = new Point(316, 270);
            addEmailTextBox.Name = "addEmailTextBox";
            addEmailTextBox.Size = new Size(100, 21);
            addEmailTextBox.TabIndex = 12;
            addEmailTextBox.Visible = false;
            // 
            // addPasswordTextBox
            // 
            addPasswordTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPasswordTextBox.Location = new Point(316, 212);
            addPasswordTextBox.Name = "addPasswordTextBox";
            addPasswordTextBox.Size = new Size(100, 21);
            addPasswordTextBox.TabIndex = 13;
            addPasswordTextBox.Visible = false;
            // 
            // addUserNameTextBox
            // 
            addUserNameTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUserNameTextBox.Location = new Point(316, 153);
            addUserNameTextBox.Name = "addUserNameTextBox";
            addUserNameTextBox.Size = new Size(100, 21);
            addUserNameTextBox.TabIndex = 14;
            addUserNameTextBox.Visible = false;
            // 
            // addNameTextBox
            // 
            addNameTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNameTextBox.Location = new Point(316, 102);
            addNameTextBox.Name = "addNameTextBox";
            addNameTextBox.Size = new Size(100, 21);
            addNameTextBox.TabIndex = 15;
            addNameTextBox.Visible = false;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(326, 328);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 34);
            registerButton.TabIndex = 16;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Visible = false;
            registerButton.Click += registerButton_Click;
            // 
            // goBackButton
            // 
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.Location = new Point(12, 415);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(28, 22);
            goBackButton.TabIndex = 17;
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOutButton.Location = new Point(326, 184);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 35);
            logOutButton.TabIndex = 18;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Visible = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // UserLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(logOutButton);
            Controls.Add(goBackButton);
            Controls.Add(registerButton);
            Controls.Add(addNameTextBox);
            Controls.Add(addUserNameTextBox);
            Controls.Add(addPasswordTextBox);
            Controls.Add(addEmailTextBox);
            Controls.Add(nameLabel);
            Controls.Add(passwordLabel2);
            Controls.Add(userNameLabel2);
            Controls.Add(emailLabel);
            Controls.Add(toRegisterMemberButton);
            Controls.Add(newCostumerMessageLabel);
            Controls.Add(logInUserButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(logInLabel);
            Name = "UserLogIn";
            Text = "UserLogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logInLabel;
        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button logInUserButton;
        private Label newCostumerMessageLabel;
        private Button toRegisterMemberButton;
        private Label emailLabel;
        private Label userNameLabel2;
        private Label passwordLabel2;
        private Label nameLabel;
        private TextBox addEmailTextBox;
        private TextBox addPasswordTextBox;
        private TextBox addUserNameTextBox;
        private TextBox addNameTextBox;
        private Button registerButton;
        private Button goBackButton;
        private Button logOutButton;
    }
}