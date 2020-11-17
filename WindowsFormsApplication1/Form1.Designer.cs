namespace Race
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Pet1 = new System.Windows.Forms.PictureBox();
            this.Pet2 = new System.Windows.Forms.PictureBox();
            this.Pet3 = new System.Windows.Forms.PictureBox();
            this.Pet4 = new System.Windows.Forms.PictureBox();
            this.GoRace = new System.Windows.Forms.Button();
            this.MinBLabel = new System.Windows.Forms.Label();
            this.JoeButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.BetsLabel = new System.Windows.Forms.Label();
            this.JoeBLabel = new System.Windows.Forms.Label();
            this.BobBLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BetsButton = new System.Windows.Forms.Button();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPet = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPet)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(18, 18);
            this.Photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(908, 311);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // Pet1
            // 
            this.Pet1.Image = ((System.Drawing.Image)(resources.GetObject("Pet1.Image")));
            this.Pet1.Location = new System.Drawing.Point(33, 37);
            this.Pet1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pet1.Name = "Pet1";
            this.Pet1.Size = new System.Drawing.Size(112, 32);
            this.Pet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pet1.TabIndex = 1;
            this.Pet1.TabStop = false;
            this.Pet1.Click += new System.EventHandler(this.Pet1_Click);
            // 
            // Pet2
            // 
            this.Pet2.Image = ((System.Drawing.Image)(resources.GetObject("Pet2.Image")));
            this.Pet2.Location = new System.Drawing.Point(33, 105);
            this.Pet2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pet2.Name = "Pet2";
            this.Pet2.Size = new System.Drawing.Size(112, 34);
            this.Pet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pet2.TabIndex = 2;
            this.Pet2.TabStop = false;
            // 
            // Pet3
            // 
            this.Pet3.Image = ((System.Drawing.Image)(resources.GetObject("Pet3.Image")));
            this.Pet3.Location = new System.Drawing.Point(33, 168);
            this.Pet3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pet3.Name = "Pet3";
            this.Pet3.Size = new System.Drawing.Size(112, 37);
            this.Pet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pet3.TabIndex = 3;
            this.Pet3.TabStop = false;
            // 
            // Pet4
            // 
            this.Pet4.Image = ((System.Drawing.Image)(resources.GetObject("Pet4.Image")));
            this.Pet4.Location = new System.Drawing.Point(33, 242);
            this.Pet4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pet4.Name = "Pet4";
            this.Pet4.Size = new System.Drawing.Size(112, 37);
            this.Pet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pet4.TabIndex = 4;
            this.Pet4.TabStop = false;
            // 
            // GoRace
            // 
            this.GoRace.Location = new System.Drawing.Point(702, 371);
            this.GoRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoRace.Name = "GoRace";
            this.GoRace.Size = new System.Drawing.Size(219, 61);
            this.GoRace.TabIndex = 5;
            this.GoRace.Text = "Race!";
            this.GoRace.UseVisualStyleBackColor = true;
            this.GoRace.Click += new System.EventHandler(this.GoRace_Click);
            // 
            // MinBLabel
            // 
            this.MinBLabel.AutoSize = true;
            this.MinBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBLabel.Location = new System.Drawing.Point(14, 371);
            this.MinBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinBLabel.Name = "MinBLabel";
            this.MinBLabel.Size = new System.Drawing.Size(0, 20);
            this.MinBLabel.TabIndex = 6;
            // 
            // JoeButton
            // 
            this.JoeButton.AutoSize = true;
            this.JoeButton.Location = new System.Drawing.Point(18, 414);
            this.JoeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JoeButton.Name = "JoeButton";
            this.JoeButton.Size = new System.Drawing.Size(126, 24);
            this.JoeButton.TabIndex = 7;
            this.JoeButton.TabStop = true;
            this.JoeButton.Text = "radioButton1";
            this.JoeButton.UseVisualStyleBackColor = true;
            this.JoeButton.CheckedChanged += new System.EventHandler(this.JoeButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(18, 451);
            this.bobRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(126, 24);
            this.bobRadioButton.TabIndex = 8;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "radioButton1";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged_1);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(18, 488);
            this.alRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(126, 24);
            this.alRadioButton.TabIndex = 9;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "radioButton2";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged_1);
            // 
            // BetsLabel
            // 
            this.BetsLabel.AutoSize = true;
            this.BetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetsLabel.Location = new System.Drawing.Point(246, 371);
            this.BetsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetsLabel.Name = "BetsLabel";
            this.BetsLabel.Size = new System.Drawing.Size(48, 20);
            this.BetsLabel.TabIndex = 10;
            this.BetsLabel.Text = "Bets";
            // 
            // JoeBLabel
            // 
            this.JoeBLabel.AutoSize = true;
            this.JoeBLabel.Location = new System.Drawing.Point(246, 414);
            this.JoeBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JoeBLabel.Name = "JoeBLabel";
            this.JoeBLabel.Size = new System.Drawing.Size(51, 20);
            this.JoeBLabel.TabIndex = 11;
            this.JoeBLabel.Text = "label1";
            // 
            // BobBLabel
            // 
            this.BobBLabel.AutoSize = true;
            this.BobBLabel.Location = new System.Drawing.Point(246, 451);
            this.BobBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BobBLabel.Name = "BobBLabel";
            this.BobBLabel.Size = new System.Drawing.Size(51, 20);
            this.BobBLabel.TabIndex = 12;
            this.BobBLabel.Text = "label1";
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(246, 488);
            this.alBetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(51, 20);
            this.alBetLabel.TabIndex = 13;
            this.alBetLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(14, 552);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 20);
            this.NameLabel.TabIndex = 14;
            // 
            // BetsButton
            // 
            this.BetsButton.Location = new System.Drawing.Point(182, 563);
            this.BetsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(112, 35);
            this.BetsButton.TabIndex = 15;
            this.BetsButton.Text = "Bets";
            this.BetsButton.UseVisualStyleBackColor = true;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(316, 568);
            this.numericUpDownBet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(184, 26);
            this.numericUpDownBet.TabIndex = 16;
            this.numericUpDownBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 568);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "bucks on Cat number ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownPet
            // 
            this.numericUpDownPet.Location = new System.Drawing.Point(702, 563);
            this.numericUpDownPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownPet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPet.Name = "numericUpDownPet";
            this.numericUpDownPet.Size = new System.Drawing.Size(219, 26);
            this.numericUpDownPet.TabIndex = 18;
            this.numericUpDownPet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(702, 451);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(219, 63);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(939, 631);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.numericUpDownPet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownBet);
            this.Controls.Add(this.BetsButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.alBetLabel);
            this.Controls.Add(this.BobBLabel);
            this.Controls.Add(this.JoeBLabel);
            this.Controls.Add(this.BetsLabel);
            this.Controls.Add(this.alRadioButton);
            this.Controls.Add(this.bobRadioButton);
            this.Controls.Add(this.JoeButton);
            this.Controls.Add(this.MinBLabel);
            this.Controls.Add(this.GoRace);
            this.Controls.Add(this.Pet4);
            this.Controls.Add(this.Pet3);
            this.Controls.Add(this.Pet2);
            this.Controls.Add(this.Pet1);
            this.Controls.Add(this.Photo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.PictureBox Pet1;
        private System.Windows.Forms.PictureBox Pet2;
        private System.Windows.Forms.PictureBox Pet3;
        private System.Windows.Forms.PictureBox Pet4;
        private System.Windows.Forms.Button GoRace;
        private System.Windows.Forms.Label MinBLabel;
        private System.Windows.Forms.RadioButton JoeButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Label BetsLabel;
        private System.Windows.Forms.Label JoeBLabel;
        private System.Windows.Forms.Label BobBLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPet;
        private System.Windows.Forms.Button ResetButton;
    }
}