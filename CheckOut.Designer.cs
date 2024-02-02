namespace OnlineMakeUpStore
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            pictureBox1 = new PictureBox();
            goBackButton = new Button();
            totalPriceLabel = new Label();
            label2 = new Label();
            removeFromCartbutton = new Button();
            checkOutButton = new Button();
            label1 = new Label();
            cartListBox = new ListBox();
            cardNumTexBox = new TextBox();
            purchaseButton = new Button();
            label4 = new Label();
            cartGoBackToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.LavenderBlush;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.Location = new Point(11, 417);
            goBackButton.Margin = new Padding(2, 2, 2, 2);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(28, 22);
            goBackButton.TabIndex = 3;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.BackColor = Color.LavenderBlush;
            totalPriceLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(275, 289);
            totalPriceLabel.Margin = new Padding(2, 0, 2, 0);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(42, 16);
            totalPriceLabel.TabIndex = 5;
            totalPriceLabel.Text = "total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 253);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 16);
            label2.TabIndex = 4;
            label2.Text = "Your total:";
            // 
            // removeFromCartbutton
            // 
            removeFromCartbutton.BackColor = Color.LavenderBlush;
            removeFromCartbutton.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeFromCartbutton.Location = new Point(86, 349);
            removeFromCartbutton.Margin = new Padding(2, 2, 2, 2);
            removeFromCartbutton.Name = "removeFromCartbutton";
            removeFromCartbutton.Size = new Size(64, 33);
            removeFromCartbutton.TabIndex = 2;
            removeFromCartbutton.Text = "Remove";
            removeFromCartbutton.UseVisualStyleBackColor = false;
            removeFromCartbutton.Click += removeFromCartbutton_Click;
            // 
            // checkOutButton
            // 
            checkOutButton.BackColor = Color.LavenderBlush;
            checkOutButton.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOutButton.Location = new Point(188, 349);
            checkOutButton.Margin = new Padding(2, 2, 2, 2);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(83, 33);
            checkOutButton.TabIndex = 6;
            checkOutButton.Text = "Check Out";
            checkOutButton.UseVisualStyleBackColor = false;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Your Cart";
            // 
            // cartListBox
            // 
            cartListBox.BackColor = Color.LavenderBlush;
            cartListBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartListBox.FormattingEnabled = true;
            cartListBox.Location = new Point(86, 109);
            cartListBox.Margin = new Padding(2, 2, 2, 2);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(185, 196);
            cartListBox.TabIndex = 0;
            // 
            // cardNumTexBox
            // 
            cardNumTexBox.BackColor = Color.LavenderBlush;
            cardNumTexBox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardNumTexBox.Location = new Point(512, 208);
            cardNumTexBox.Margin = new Padding(2, 2, 2, 2);
            cardNumTexBox.Name = "cardNumTexBox";
            cardNumTexBox.PlaceholderText = "Write your card number";
            cardNumTexBox.Size = new Size(145, 21);
            cardNumTexBox.TabIndex = 8;
            cardNumTexBox.Visible = false;
            // 
            // purchaseButton
            // 
            purchaseButton.BackColor = Color.LavenderBlush;
            purchaseButton.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaseButton.Location = new Point(551, 274);
            purchaseButton.Margin = new Padding(2, 2, 2, 2);
            purchaseButton.Name = "purchaseButton";
            purchaseButton.Size = new Size(78, 31);
            purchaseButton.TabIndex = 9;
            purchaseButton.Text = "Purchase";
            purchaseButton.UseVisualStyleBackColor = false;
            purchaseButton.Visible = false;
            purchaseButton.Click += purchaseButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(538, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 10;
            label4.Text = "Check Out";
            label4.Visible = false;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(purchaseButton);
            Controls.Add(cardNumTexBox);
            Controls.Add(checkOutButton);
            Controls.Add(totalPriceLabel);
            Controls.Add(label2);
            Controls.Add(goBackButton);
            Controls.Add(removeFromCartbutton);
            Controls.Add(label1);
            Controls.Add(cartListBox);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CheckOut";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button goBackButton;
        private Label totalPriceLabel;
        private Label label2;
        private Button removeFromCartbutton;
        private Button checkOutButton;
        private Label label1;
        private TextBox cardNumTexBox;
        private Button purchaseButton;
        private Label label4;
        private ToolTip cartGoBackToolTip;
        public ListBox cartListBox;
    }
}