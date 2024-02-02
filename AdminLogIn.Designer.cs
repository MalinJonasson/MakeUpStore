namespace OnlineMakeUpStore
{
    partial class AdminLogIn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogIn));
            label1 = new Label();
            enterAddProductButton = new Button();
            enterRemoveProductButton = new Button();
            categoryLabel = new Label();
            addProductButton = new Button();
            removeProductListBox = new ListBox();
            removeProductButton = new Button();
            nameTextBox = new TextBox();
            priceNumeric = new NumericUpDown();
            priceLabel = new Label();
            categoryComboBox = new ComboBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            adminLogInButton = new Button();
            logInLabel = new Label();
            listOfProductsLabel = new Label();
            removeAProductLabel = new Label();
            addAProductLabel = new Label();
            goBackButton = new Button();
            adminGoBackToolTip = new ToolTip(components);
            chooseToEditLabel = new Label();
            editButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            editNameTextBox = new TextBox();
            editCategoryComboBox = new ComboBox();
            editPriceTextBox = new TextBox();
            usersAndCarts = new Button();
            usersAndCartListBox = new ListBox();
            usersAndCartsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Cascadia Mono", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(471, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 37);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            // 
            // enterAddProductButton
            // 
            enterAddProductButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterAddProductButton.Location = new Point(166, 320);
            enterAddProductButton.Name = "enterAddProductButton";
            enterAddProductButton.Size = new Size(161, 67);
            enterAddProductButton.TabIndex = 2;
            enterAddProductButton.Text = "Add a product";
            enterAddProductButton.UseVisualStyleBackColor = true;
            enterAddProductButton.Visible = false;
            enterAddProductButton.Click += enterAddProductButton_Click;
            // 
            // enterRemoveProductButton
            // 
            enterRemoveProductButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterRemoveProductButton.Location = new Point(659, 320);
            enterRemoveProductButton.Name = "enterRemoveProductButton";
            enterRemoveProductButton.Size = new Size(197, 67);
            enterRemoveProductButton.TabIndex = 3;
            enterRemoveProductButton.Text = "Edit/Remove product";
            enterRemoveProductButton.UseVisualStyleBackColor = true;
            enterRemoveProductButton.Visible = false;
            enterRemoveProductButton.Click += enterRemoveProductButton_Click;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryLabel.Location = new Point(229, 243);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(98, 24);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category";
            categoryLabel.Visible = false;
            // 
            // addProductButton
            // 
            addProductButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductButton.Location = new Point(450, 587);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(111, 50);
            addProductButton.TabIndex = 8;
            addProductButton.Text = "Add";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Visible = false;
            addProductButton.Click += addProductButton_Click;
            // 
            // removeProductListBox
            // 
            removeProductListBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeProductListBox.FormattingEnabled = true;
            removeProductListBox.Location = new Point(64, 248);
            removeProductListBox.Name = "removeProductListBox";
            removeProductListBox.Size = new Size(378, 268);
            removeProductListBox.TabIndex = 9;
            removeProductListBox.Visible = false;
            removeProductListBox.SelectedIndexChanged += removeProductListBox_SelectedIndexChanged_1;
            // 
            // removeProductButton
            // 
            removeProductButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeProductButton.Location = new Point(189, 587);
            removeProductButton.Name = "removeProductButton";
            removeProductButton.Size = new Size(111, 50);
            removeProductButton.TabIndex = 10;
            removeProductButton.Text = "Remove";
            removeProductButton.UseVisualStyleBackColor = true;
            removeProductButton.Visible = false;
            removeProductButton.Click += removeProductButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(229, 423);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(150, 28);
            nameTextBox.TabIndex = 11;
            nameTextBox.Visible = false;
            // 
            // priceNumeric
            // 
            priceNumeric.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceNumeric.Location = new Point(634, 278);
            priceNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            priceNumeric.Name = "priceNumeric";
            priceNumeric.Size = new Size(150, 28);
            priceNumeric.TabIndex = 14;
            priceNumeric.Visible = false;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(634, 248);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(65, 24);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Price";
            priceLabel.Visible = false;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(229, 273);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(150, 32);
            categoryComboBox.TabIndex = 18;
            categoryComboBox.Visible = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(450, 215);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(143, 28);
            usernameTextBox.TabIndex = 19;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(450, 345);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(143, 28);
            passwordTextBox.TabIndex = 20;
            // 
            // adminLogInButton
            // 
            adminLogInButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminLogInButton.Location = new Point(456, 490);
            adminLogInButton.Name = "adminLogInButton";
            adminLogInButton.Size = new Size(111, 50);
            adminLogInButton.TabIndex = 21;
            adminLogInButton.Text = "Log In";
            adminLogInButton.UseVisualStyleBackColor = true;
            adminLogInButton.Click += adminLogInButton_Click;
            // 
            // logInLabel
            // 
            logInLabel.AutoSize = true;
            logInLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInLabel.Location = new Point(431, 92);
            logInLabel.Name = "logInLabel";
            logInLabel.Size = new Size(182, 32);
            logInLabel.TabIndex = 22;
            logInLabel.Text = "Log in Admin";
            // 
            // listOfProductsLabel
            // 
            listOfProductsLabel.AutoSize = true;
            listOfProductsLabel.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listOfProductsLabel.Location = new Point(87, 210);
            listOfProductsLabel.Name = "listOfProductsLabel";
            listOfProductsLabel.Size = new Size(98, 24);
            listOfProductsLabel.TabIndex = 23;
            listOfProductsLabel.Text = "Category";
            listOfProductsLabel.Visible = false;
            // 
            // removeAProductLabel
            // 
            removeAProductLabel.AutoSize = true;
            removeAProductLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeAProductLabel.Location = new Point(360, 92);
            removeAProductLabel.Name = "removeAProductLabel";
            removeAProductLabel.Size = new Size(350, 32);
            removeAProductLabel.TabIndex = 24;
            removeAProductLabel.Text = "Remove or edit a product";
            removeAProductLabel.Visible = false;
            // 
            // addAProductLabel
            // 
            addAProductLabel.AutoSize = true;
            addAProductLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addAProductLabel.Location = new Point(431, 92);
            addAProductLabel.Name = "addAProductLabel";
            addAProductLabel.Size = new Size(196, 32);
            addAProductLabel.TabIndex = 25;
            addAProductLabel.Text = "Add a product";
            addAProductLabel.Visible = false;
            // 
            // goBackButton
            // 
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.Location = new Point(16, 647);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(40, 37);
            goBackButton.TabIndex = 26;
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // chooseToEditLabel
            // 
            chooseToEditLabel.AutoSize = true;
            chooseToEditLabel.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseToEditLabel.Location = new Point(700, 168);
            chooseToEditLabel.Name = "chooseToEditLabel";
            chooseToEditLabel.Size = new Size(186, 24);
            chooseToEditLabel.TabIndex = 27;
            chooseToEditLabel.Text = "Choose a product";
            chooseToEditLabel.Visible = false;
            // 
            // editButton
            // 
            editButton.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editButton.Location = new Point(717, 587);
            editButton.Name = "editButton";
            editButton.Size = new Size(111, 50);
            editButton.TabIndex = 30;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Visible = false;
            editButton.Click += editButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(659, 195);
            label2.Name = "label2";
            label2.Size = new Size(274, 24);
            label2.TabIndex = 32;
            label2.Text = "from the listbox to edit";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 210);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 33;
            label3.Text = "Name";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(346, 210);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 34;
            label4.Text = "Price";
            label4.Visible = false;
            // 
            // editNameTextBox
            // 
            editNameTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editNameTextBox.Location = new Point(700, 378);
            editNameTextBox.Name = "editNameTextBox";
            editNameTextBox.PlaceholderText = "Name";
            editNameTextBox.Size = new Size(150, 28);
            editNameTextBox.TabIndex = 28;
            editNameTextBox.Visible = false;
            // 
            // editCategoryComboBox
            // 
            editCategoryComboBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editCategoryComboBox.FormattingEnabled = true;
            editCategoryComboBox.Location = new Point(700, 240);
            editCategoryComboBox.Name = "editCategoryComboBox";
            editCategoryComboBox.Size = new Size(150, 32);
            editCategoryComboBox.TabIndex = 36;
            editCategoryComboBox.Visible = false;
            // 
            // editPriceTextBox
            // 
            editPriceTextBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editPriceTextBox.Location = new Point(700, 505);
            editPriceTextBox.Name = "editPriceTextBox";
            editPriceTextBox.PlaceholderText = "Price";
            editPriceTextBox.Size = new Size(150, 28);
            editPriceTextBox.TabIndex = 37;
            editPriceTextBox.Visible = false;
            // 
            // usersAndCarts
            // 
            usersAndCarts.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersAndCarts.Location = new Point(416, 320);
            usersAndCarts.Name = "usersAndCarts";
            usersAndCarts.Size = new Size(197, 65);
            usersAndCarts.TabIndex = 38;
            usersAndCarts.Text = "View users and their carts";
            usersAndCarts.UseVisualStyleBackColor = true;
            usersAndCarts.Visible = false;
            usersAndCarts.Click += usersAndCarts_Click;
            // 
            // usersAndCartListBox
            // 
            usersAndCartListBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersAndCartListBox.FormattingEnabled = true;
            usersAndCartListBox.Location = new Point(87, 183);
            usersAndCartListBox.Name = "usersAndCartListBox";
            usersAndCartListBox.Size = new Size(891, 316);
            usersAndCartListBox.TabIndex = 39;
            usersAndCartListBox.Visible = false;
            // 
            // usersAndCartsLabel
            // 
            usersAndCartsLabel.AutoSize = true;
            usersAndCartsLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersAndCartsLabel.Location = new Point(321, 92);
            usersAndCartsLabel.Name = "usersAndCartsLabel";
            usersAndCartsLabel.Size = new Size(378, 32);
            usersAndCartsLabel.TabIndex = 40;
            usersAndCartsLabel.Text = "View users and their carts";
            usersAndCartsLabel.Visible = false;
            // 
            // AdminLogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1061, 702);
            Controls.Add(usersAndCartsLabel);
            Controls.Add(usersAndCartListBox);
            Controls.Add(usersAndCarts);
            Controls.Add(editPriceTextBox);
            Controls.Add(editCategoryComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(editButton);
            Controls.Add(editNameTextBox);
            Controls.Add(chooseToEditLabel);
            Controls.Add(goBackButton);
            Controls.Add(addAProductLabel);
            Controls.Add(removeAProductLabel);
            Controls.Add(listOfProductsLabel);
            Controls.Add(logInLabel);
            Controls.Add(adminLogInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(categoryComboBox);
            Controls.Add(priceLabel);
            Controls.Add(priceNumeric);
            Controls.Add(nameTextBox);
            Controls.Add(removeProductButton);
            Controls.Add(removeProductListBox);
            Controls.Add(addProductButton);
            Controls.Add(categoryLabel);
            Controls.Add(enterRemoveProductButton);
            Controls.Add(enterAddProductButton);
            Controls.Add(label1);
            Name = "AdminLogIn";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)priceNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label categoryLabel;
        private Button addProductButton;
        private ListBox removeProductListBox;
        private Button removeProductButton;
        private TextBox nameTextBox;
        private NumericUpDown priceNumeric;
        private Label priceLabel;
        private ComboBox categoryComboBox;
        private Label listOfProductsLabel;
        private Label removeAProductLabel;
        private Label addAProductLabel;
        private Button goBackButton;
        private ToolTip adminGoBackToolTip;
        public TextBox usernameTextBox;
        public TextBox passwordTextBox;
        public Button enterAddProductButton;
        public Button enterRemoveProductButton;
        public Button adminLogInButton;
        public Label logInLabel;
        private Label chooseToEditLabel;
        private Button editButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox editNameTextBox;
        private ComboBox editCategoryComboBox;
        private TextBox editPriceTextBox;
        private Button usersAndCarts;
        private ListBox usersAndCartListBox;
        private Label usersAndCartsLabel;
    }
}