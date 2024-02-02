namespace OnlineMakeUpStore
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            searchCatagorysTextBox = new TextBox();
            label1 = new Label();
            cartButton = new Button();
            cartToolTip = new ToolTip(components);
            logInUserButton = new Button();
            userLogInToolTip = new ToolTip(components);
            logInAdminButton = new Button();
            logInAdminToolTip = new ToolTip(components);
            skincareButton = new Button();
            makeUpButton = new Button();
            haircareButton = new Button();
            haircarePage = new Haircare();
            makeUpPage = new MakeUp();
            skincarePage = new Skincare();
            SuspendLayout();
            // 
            // searchCatagorysTextBox
            // 
            searchCatagorysTextBox.Location = new Point(8, 75);
            searchCatagorysTextBox.Margin = new Padding(2, 2, 2, 2);
            searchCatagorysTextBox.Name = "searchCatagorysTextBox";
            searchCatagorysTextBox.PlaceholderText = "Search products and catagorys";
            searchCatagorysTextBox.Size = new Size(329, 23);
            searchCatagorysTextBox.TabIndex = 6;
            searchCatagorysTextBox.KeyDown += searchCatagorysTextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 39);
            label1.TabIndex = 7;
            label1.Text = "GlowHub";
            // 
            // cartButton
            // 
            cartButton.FlatStyle = FlatStyle.Flat;
            cartButton.Image = (Image)resources.GetObject("cartButton.Image");
            cartButton.Location = new Point(749, 9);
            cartButton.Margin = new Padding(2, 2, 2, 2);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(40, 39);
            cartButton.TabIndex = 8;
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += cartButton_Click;
            // 
            // logInUserButton
            // 
            logInUserButton.FlatStyle = FlatStyle.Flat;
            logInUserButton.Image = (Image)resources.GetObject("logInUserButton.Image");
            logInUserButton.Location = new Point(696, 9);
            logInUserButton.Margin = new Padding(2, 2, 2, 2);
            logInUserButton.Name = "logInUserButton";
            logInUserButton.Size = new Size(40, 39);
            logInUserButton.TabIndex = 9;
            logInUserButton.UseVisualStyleBackColor = true;
            logInUserButton.Click += logInUserButton_Click;
            // 
            // logInAdminButton
            // 
            logInAdminButton.FlatStyle = FlatStyle.Flat;
            logInAdminButton.Image = (Image)resources.GetObject("logInAdminButton.Image");
            logInAdminButton.Location = new Point(642, 9);
            logInAdminButton.Margin = new Padding(2, 2, 2, 2);
            logInAdminButton.Name = "logInAdminButton";
            logInAdminButton.Size = new Size(40, 39);
            logInAdminButton.TabIndex = 10;
            logInAdminButton.UseVisualStyleBackColor = true;
            logInAdminButton.Click += logInAdminButton_Click;
            // 
            // skincareButton
            // 
            skincareButton.FlatStyle = FlatStyle.Flat;
            skincareButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skincareButton.Image = (Image)resources.GetObject("skincareButton.Image");
            skincareButton.Location = new Point(-2, 102);
            skincareButton.Margin = new Padding(2, 2, 2, 2);
            skincareButton.Name = "skincareButton";
            skincareButton.Size = new Size(266, 354);
            skincareButton.TabIndex = 11;
            skincareButton.Text = "Skincare";
            skincareButton.UseVisualStyleBackColor = true;
            skincareButton.Click += skincareButton_Click;
            // 
            // makeUpButton
            // 
            makeUpButton.FlatStyle = FlatStyle.Flat;
            makeUpButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeUpButton.Image = (Image)resources.GetObject("makeUpButton.Image");
            makeUpButton.Location = new Point(258, 102);
            makeUpButton.Margin = new Padding(2, 2, 2, 2);
            makeUpButton.Name = "makeUpButton";
            makeUpButton.Size = new Size(282, 354);
            makeUpButton.TabIndex = 12;
            makeUpButton.Text = "MakeUp";
            makeUpButton.UseVisualStyleBackColor = true;
            makeUpButton.Click += makeUpButton_Click;
            // 
            // haircareButton
            // 
            haircareButton.FlatStyle = FlatStyle.Flat;
            haircareButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haircareButton.Image = (Image)resources.GetObject("haircareButton.Image");
            haircareButton.Location = new Point(534, 102);
            haircareButton.Margin = new Padding(2, 2, 2, 2);
            haircareButton.Name = "haircareButton";
            haircareButton.Size = new Size(267, 354);
            haircareButton.TabIndex = 13;
            haircareButton.Text = "Haircare";
            haircareButton.UseVisualStyleBackColor = true;
            haircareButton.Click += haircareButton_Click;
            // 
            // haircarePage
            // 
            haircarePage.BackColor = Color.CadetBlue;
            haircarePage.Location = new Point(-2, -26);
            haircarePage.Margin = new Padding(1, 1, 1, 1);
            haircarePage.Name = "haircarePage";
            haircarePage.Size = new Size(803, 482);
            haircarePage.TabIndex = 14;
            haircarePage.Visible = false;
            // 
            // makeUpPage
            // 
            makeUpPage.BackColor = Color.LavenderBlush;
            makeUpPage.Location = new Point(-2, -26);
            makeUpPage.Margin = new Padding(1, 1, 1, 1);
            makeUpPage.Name = "makeUpPage";
            makeUpPage.Size = new Size(803, 482);
            makeUpPage.TabIndex = 15;
            makeUpPage.Visible = false;
            // 
            // skincarePage
            // 
            skincarePage.BackColor = Color.LemonChiffon;
            skincarePage.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skincarePage.HomePage = null;
            skincarePage.Location = new Point(-2, -26);
            skincarePage.Manager = null;
            skincarePage.Margin = new Padding(1, 1, 1, 1);
            skincarePage.Name = "skincarePage";
            skincarePage.Size = new Size(803, 482);
            skincarePage.TabIndex = 16;
            skincarePage.Visible = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(makeUpPage);
            Controls.Add(skincarePage);
            Controls.Add(haircarePage);
            Controls.Add(haircareButton);
            Controls.Add(makeUpButton);
            Controls.Add(skincareButton);
            Controls.Add(logInAdminButton);
            Controls.Add(logInUserButton);
            Controls.Add(cartButton);
            Controls.Add(label1);
            Controls.Add(searchCatagorysTextBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HomePage";
            Text = "Home Page";
            FormClosing += HomePage_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchCatagorysTextBox;
        private Label label1;
        private Button cartButton;
        private ToolTip cartToolTip;
        private Button logInUserButton;
        private ToolTip userLogInToolTip;
        private Button logInAdminButton;
        private ToolTip logInAdminToolTip;
        private Button skincareButton;
        private Button makeUpButton;
        private Button haircareButton;
        private Haircare haircarePage;
        private MakeUp makeUpPage;
        private Skincare skincarePage;
    }
}
