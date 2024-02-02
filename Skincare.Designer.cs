namespace OnlineMakeUpStore
{
    partial class Skincare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skincare));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            skincareListBox = new ListBox();
            skincareCartButton = new Button();
            priceLabel = new Label();
            backToHomePageButton = new Button();
            skincareToolTip = new ToolTip(components);
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
            label1.Location = new Point(25, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 35);
            label1.TabIndex = 1;
            label1.Text = "Skincare";
            // 
            // skincareListBox
            // 
            skincareListBox.BackColor = Color.LemonChiffon;
            skincareListBox.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skincareListBox.FormattingEnabled = true;
            skincareListBox.ItemHeight = 20;
            skincareListBox.Location = new Point(2, 83);
            skincareListBox.Margin = new Padding(2);
            skincareListBox.Name = "skincareListBox";
            skincareListBox.Size = new Size(201, 224);
            skincareListBox.TabIndex = 2;
            skincareListBox.SelectedIndexChanged += skincareListBox_SelectedIndexChanged;
            // 
            // skincareCartButton
            // 
            skincareCartButton.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skincareCartButton.Location = new Point(53, 387);
            skincareCartButton.Margin = new Padding(2);
            skincareCartButton.Name = "skincareCartButton";
            skincareCartButton.Size = new Size(98, 30);
            skincareCartButton.TabIndex = 3;
            skincareCartButton.Text = "Add To Cart";
            skincareCartButton.UseVisualStyleBackColor = true;
            skincareCartButton.Click += skincareCartButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(12, 322);
            priceLabel.Margin = new Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(0, 16);
            priceLabel.TabIndex = 4;
            // 
            // backToHomePageButton
            // 
            backToHomePageButton.FlatStyle = FlatStyle.Flat;
            backToHomePageButton.Image = (Image)resources.GetObject("backToHomePageButton.Image");
            backToHomePageButton.Location = new Point(2, 447);
            backToHomePageButton.Margin = new Padding(2);
            backToHomePageButton.Name = "backToHomePageButton";
            backToHomePageButton.Size = new Size(28, 22);
            backToHomePageButton.TabIndex = 5;
            backToHomePageButton.UseVisualStyleBackColor = true;
            backToHomePageButton.Click += backToHomePageButton_Click;
            // 
            // Skincare
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            Controls.Add(backToHomePageButton);
            Controls.Add(priceLabel);
            Controls.Add(skincareCartButton);
            Controls.Add(skincareListBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "Skincare";
            Size = new Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button skincareCartButton;
        private Label priceLabel;
        private Button backToHomePageButton;
        private ToolTip skincareToolTip;
        public ListBox skincareListBox;
    }
}
