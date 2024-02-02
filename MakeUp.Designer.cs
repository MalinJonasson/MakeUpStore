namespace OnlineMakeUpStore
{
    partial class MakeUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeUp));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            makeUpListBox = new ListBox();
            makeUpCartButton = new Button();
            priceLabel = new Label();
            backToHomePageButton = new Button();
            makeUpToolTip = new ToolTip(components);
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
            label1.ForeColor = Color.Violet;
            label1.Location = new Point(40, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 35);
            label1.TabIndex = 1;
            label1.Text = "MakeUp";
            // 
            // makeUpListBox
            // 
            makeUpListBox.BackColor = Color.LavenderBlush;
            makeUpListBox.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeUpListBox.FormattingEnabled = true;
            makeUpListBox.ItemHeight = 20;
            makeUpListBox.Location = new Point(5, 88);
            makeUpListBox.Margin = new Padding(2);
            makeUpListBox.Name = "makeUpListBox";
            makeUpListBox.Size = new Size(198, 224);
            makeUpListBox.TabIndex = 2;
            makeUpListBox.SelectedIndexChanged += makeUpListBox_SelectedIndexChanged;
            // 
            // makeUpCartButton
            // 
            makeUpCartButton.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeUpCartButton.Location = new Point(40, 378);
            makeUpCartButton.Margin = new Padding(2);
            makeUpCartButton.Name = "makeUpCartButton";
            makeUpCartButton.Size = new Size(98, 32);
            makeUpCartButton.TabIndex = 3;
            makeUpCartButton.Text = "Add To Cart";
            makeUpCartButton.UseVisualStyleBackColor = true;
            makeUpCartButton.Click += makeUpCartButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(2, 327);
            priceLabel.Margin = new Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(0, 16);
            priceLabel.TabIndex = 4;
            // 
            // backToHomePageButton
            // 
            backToHomePageButton.FlatStyle = FlatStyle.Flat;
            backToHomePageButton.Image = (Image)resources.GetObject("backToHomePageButton.Image");
            backToHomePageButton.Location = new Point(5, 439);
            backToHomePageButton.Margin = new Padding(2);
            backToHomePageButton.Name = "backToHomePageButton";
            backToHomePageButton.Size = new Size(28, 22);
            backToHomePageButton.TabIndex = 5;
            backToHomePageButton.UseVisualStyleBackColor = true;
            backToHomePageButton.Click += goBackToHomePageButton_Click;
            // 
            // MakeUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            Controls.Add(backToHomePageButton);
            Controls.Add(priceLabel);
            Controls.Add(makeUpCartButton);
            Controls.Add(makeUpListBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "MakeUp";
            Size = new Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button makeUpCartButton;
        private Label priceLabel;
        private Button backToHomePageButton;
        private ToolTip makeUpToolTip;
        public ListBox makeUpListBox;
    }
}
