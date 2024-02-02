namespace OnlineMakeUpStore
{
    partial class Haircare
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Haircare));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            haircareListBox = new ListBox();
            priceLabel = new Label();
            haircareCartButton = new Button();
            goBackToHomePageButton = new Button();
            haircareToolTip = new ToolTip(components);
            priceLabel2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 35);
            label1.TabIndex = 1;
            label1.Text = "Haircare";
            // 
            // haircareListBox
            // 
            haircareListBox.BackColor = Color.CadetBlue;
            haircareListBox.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            haircareListBox.FormattingEnabled = true;
            haircareListBox.ItemHeight = 20;
            haircareListBox.Location = new Point(2, 92);
            haircareListBox.Margin = new Padding(2);
            haircareListBox.Name = "haircareListBox";
            haircareListBox.Size = new Size(201, 204);
            haircareListBox.TabIndex = 2;
            haircareListBox.SelectedIndexChanged += haircareListBox_SelectedIndexChanged;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(2, 322);
            priceLabel.Margin = new Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(0, 20);
            priceLabel.TabIndex = 3;
            // 
            // haircareCartButton
            // 
            haircareCartButton.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            haircareCartButton.Location = new Point(44, 377);
            haircareCartButton.Margin = new Padding(2);
            haircareCartButton.Name = "haircareCartButton";
            haircareCartButton.Size = new Size(99, 31);
            haircareCartButton.TabIndex = 4;
            haircareCartButton.Text = "Add To Cart";
            haircareCartButton.UseVisualStyleBackColor = true;
            haircareCartButton.Click += haircareCartButton_Click;
            // 
            // goBackToHomePageButton
            // 
            goBackToHomePageButton.FlatStyle = FlatStyle.Flat;
            goBackToHomePageButton.Image = (Image)resources.GetObject("goBackToHomePageButton.Image");
            goBackToHomePageButton.Location = new Point(16, 444);
            goBackToHomePageButton.Margin = new Padding(2);
            goBackToHomePageButton.Name = "goBackToHomePageButton";
            goBackToHomePageButton.Size = new Size(28, 22);
            goBackToHomePageButton.TabIndex = 5;
            goBackToHomePageButton.UseVisualStyleBackColor = true;
            goBackToHomePageButton.Click += goBackToHomePageButton_Click;
            // 
            // priceLabel2
            // 
            priceLabel2.AutoSize = true;
            priceLabel2.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel2.Location = new Point(16, 309);
            priceLabel2.Name = "priceLabel2";
            priceLabel2.Size = new Size(0, 16);
            priceLabel2.TabIndex = 6;
            // 
            // Haircare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(priceLabel2);
            Controls.Add(goBackToHomePageButton);
            Controls.Add(haircareCartButton);
            Controls.Add(priceLabel);
            Controls.Add(haircareListBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Haircare";
            Size = new Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label priceLabel;
        private Button haircareCartButton;
        private Button goBackToHomePageButton;
        private ToolTip haircareToolTip;
        public ListBox haircareListBox;
        private Label priceLabel2;
    }
}
