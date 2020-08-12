namespace FormUI
{
    partial class PlantInformationDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantInformationDisplayForm));
            this.mainLabel = new System.Windows.Forms.Label();
            this.plantPictureBox = new System.Windows.Forms.PictureBox();
            this.fertilizerRequirementLabel = new System.Windows.Forms.Label();
            this.waterRequirementLabel = new System.Windows.Forms.Label();
            this.lightRequirementLabel = new System.Windows.Forms.Label();
            this.botanicalNameLabel = new System.Windows.Forms.Label();
            this.commonNameLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.editPlantButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.moreInfoTextBox = new System.Windows.Forms.TextBox();
            this.fertilizerRequirementTextBox = new System.Windows.Forms.TextBox();
            this.waterRequirementTextBox = new System.Windows.Forms.TextBox();
            this.lightRequirementTextBox = new System.Windows.Forms.TextBox();
            this.botanicalNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.commonNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.plantPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(24, 23);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(676, 69);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Plant Information";
            // 
            // plantPictureBox
            // 
            this.plantPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plantPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plantPictureBox.Location = new System.Drawing.Point(874, 92);
            this.plantPictureBox.Name = "plantPictureBox";
            this.plantPictureBox.Size = new System.Drawing.Size(544, 312);
            this.plantPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantPictureBox.TabIndex = 13;
            this.plantPictureBox.TabStop = false;
            // 
            // fertilizerRequirementLabel
            // 
            this.fertilizerRequirementLabel.AutoSize = true;
            this.fertilizerRequirementLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizerRequirementLabel.ForeColor = System.Drawing.Color.White;
            this.fertilizerRequirementLabel.Location = new System.Drawing.Point(31, 346);
            this.fertilizerRequirementLabel.Name = "fertilizerRequirementLabel";
            this.fertilizerRequirementLabel.Size = new System.Drawing.Size(334, 27);
            this.fertilizerRequirementLabel.TabIndex = 14;
            this.fertilizerRequirementLabel.Text = "Fertilizer Requirement:";
            // 
            // waterRequirementLabel
            // 
            this.waterRequirementLabel.AutoSize = true;
            this.waterRequirementLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterRequirementLabel.ForeColor = System.Drawing.Color.White;
            this.waterRequirementLabel.Location = new System.Drawing.Point(31, 290);
            this.waterRequirementLabel.Name = "waterRequirementLabel";
            this.waterRequirementLabel.Size = new System.Drawing.Size(264, 27);
            this.waterRequirementLabel.TabIndex = 15;
            this.waterRequirementLabel.Text = "Water Requirement:";
            // 
            // lightRequirementLabel
            // 
            this.lightRequirementLabel.AutoSize = true;
            this.lightRequirementLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightRequirementLabel.ForeColor = System.Drawing.Color.White;
            this.lightRequirementLabel.Location = new System.Drawing.Point(32, 234);
            this.lightRequirementLabel.Name = "lightRequirementLabel";
            this.lightRequirementLabel.Size = new System.Drawing.Size(264, 27);
            this.lightRequirementLabel.TabIndex = 16;
            this.lightRequirementLabel.Text = "Light Requirement:";
            // 
            // botanicalNameLabel
            // 
            this.botanicalNameLabel.AutoSize = true;
            this.botanicalNameLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botanicalNameLabel.ForeColor = System.Drawing.Color.White;
            this.botanicalNameLabel.Location = new System.Drawing.Point(31, 178);
            this.botanicalNameLabel.Name = "botanicalNameLabel";
            this.botanicalNameLabel.Size = new System.Drawing.Size(222, 27);
            this.botanicalNameLabel.TabIndex = 17;
            this.botanicalNameLabel.Text = "Botanical Name:";
            // 
            // commonNameLabel
            // 
            this.commonNameLabel.AutoSize = true;
            this.commonNameLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonNameLabel.ForeColor = System.Drawing.Color.White;
            this.commonNameLabel.Location = new System.Drawing.Point(32, 122);
            this.commonNameLabel.Name = "commonNameLabel";
            this.commonNameLabel.Size = new System.Drawing.Size(180, 27);
            this.commonNameLabel.TabIndex = 18;
            this.commonNameLabel.Text = "Common Name:";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Black;
            this.homeButton.Location = new System.Drawing.Point(36, 721);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(153, 29);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // editPlantButton
            // 
            this.editPlantButton.BackColor = System.Drawing.Color.White;
            this.editPlantButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlantButton.ForeColor = System.Drawing.Color.Black;
            this.editPlantButton.Location = new System.Drawing.Point(1265, 721);
            this.editPlantButton.Name = "editPlantButton";
            this.editPlantButton.Size = new System.Drawing.Size(153, 29);
            this.editPlantButton.TabIndex = 0;
            this.editPlantButton.Text = "Edit Plant";
            this.editPlantButton.UseVisualStyleBackColor = false;
            this.editPlantButton.Click += new System.EventHandler(this.editPlantButton_Click);
            this.editPlantButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(31, 415);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(180, 27);
            this.descriptionLabel.TabIndex = 19;
            this.descriptionLabel.Text = "Description:";
            // 
            // moreInfoTextBox
            // 
            this.moreInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moreInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moreInfoTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfoTextBox.ForeColor = System.Drawing.Color.White;
            this.moreInfoTextBox.Location = new System.Drawing.Point(36, 450);
            this.moreInfoTextBox.Multiline = true;
            this.moreInfoTextBox.Name = "moreInfoTextBox";
            this.moreInfoTextBox.ReadOnly = true;
            this.moreInfoTextBox.Size = new System.Drawing.Size(1382, 265);
            this.moreInfoTextBox.TabIndex = 7;
            this.moreInfoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // fertilizerRequirementTextBox
            // 
            this.fertilizerRequirementTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fertilizerRequirementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fertilizerRequirementTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizerRequirementTextBox.ForeColor = System.Drawing.Color.White;
            this.fertilizerRequirementTextBox.Location = new System.Drawing.Point(370, 350);
            this.fertilizerRequirementTextBox.Multiline = true;
            this.fertilizerRequirementTextBox.Name = "fertilizerRequirementTextBox";
            this.fertilizerRequirementTextBox.ReadOnly = true;
            this.fertilizerRequirementTextBox.Size = new System.Drawing.Size(498, 92);
            this.fertilizerRequirementTextBox.TabIndex = 6;
            this.fertilizerRequirementTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // waterRequirementTextBox
            // 
            this.waterRequirementTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waterRequirementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waterRequirementTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterRequirementTextBox.ForeColor = System.Drawing.Color.White;
            this.waterRequirementTextBox.Location = new System.Drawing.Point(301, 294);
            this.waterRequirementTextBox.Multiline = true;
            this.waterRequirementTextBox.Name = "waterRequirementTextBox";
            this.waterRequirementTextBox.ReadOnly = true;
            this.waterRequirementTextBox.Size = new System.Drawing.Size(566, 50);
            this.waterRequirementTextBox.TabIndex = 5;
            this.waterRequirementTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // lightRequirementTextBox
            // 
            this.lightRequirementTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lightRequirementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lightRequirementTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightRequirementTextBox.ForeColor = System.Drawing.Color.White;
            this.lightRequirementTextBox.Location = new System.Drawing.Point(302, 238);
            this.lightRequirementTextBox.Multiline = true;
            this.lightRequirementTextBox.Name = "lightRequirementTextBox";
            this.lightRequirementTextBox.ReadOnly = true;
            this.lightRequirementTextBox.Size = new System.Drawing.Size(566, 50);
            this.lightRequirementTextBox.TabIndex = 4;
            this.lightRequirementTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // botanicalNameTextBox
            // 
            this.botanicalNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botanicalNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.botanicalNameTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botanicalNameTextBox.ForeColor = System.Drawing.Color.White;
            this.botanicalNameTextBox.Location = new System.Drawing.Point(259, 182);
            this.botanicalNameTextBox.Multiline = true;
            this.botanicalNameTextBox.Name = "botanicalNameTextBox";
            this.botanicalNameTextBox.ReadOnly = true;
            this.botanicalNameTextBox.Size = new System.Drawing.Size(609, 49);
            this.botanicalNameTextBox.TabIndex = 3;
            this.botanicalNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // commonNameTextBox
            // 
            this.commonNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.commonNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commonNameTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonNameTextBox.ForeColor = System.Drawing.Color.White;
            this.commonNameTextBox.Location = new System.Drawing.Point(218, 126);
            this.commonNameTextBox.Multiline = true;
            this.commonNameTextBox.Name = "commonNameTextBox";
            this.commonNameTextBox.ReadOnly = true;
            this.commonNameTextBox.Size = new System.Drawing.Size(650, 49);
            this.commonNameTextBox.TabIndex = 2;
            this.commonNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // PlantInformationDisplayForm
            // 
            this.AcceptButton = this.editPlantButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1467, 765);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fertilizerRequirementTextBox);
            this.Controls.Add(this.waterRequirementTextBox);
            this.Controls.Add(this.lightRequirementTextBox);
            this.Controls.Add(this.botanicalNameTextBox);
            this.Controls.Add(this.commonNameTextBox);
            this.Controls.Add(this.moreInfoTextBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.editPlantButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.fertilizerRequirementLabel);
            this.Controls.Add(this.waterRequirementLabel);
            this.Controls.Add(this.lightRequirementLabel);
            this.Controls.Add(this.botanicalNameLabel);
            this.Controls.Add(this.commonNameLabel);
            this.Controls.Add(this.plantPictureBox);
            this.Controls.Add(this.mainLabel);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PlantInformationDisplayForm";
            this.Text = "Project Plant";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            ((System.ComponentModel.ISupportInitialize)(this.plantPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        public System.Windows.Forms.PictureBox plantPictureBox;
        private System.Windows.Forms.Label fertilizerRequirementLabel;
        private System.Windows.Forms.Label waterRequirementLabel;
        private System.Windows.Forms.Label lightRequirementLabel;
        private System.Windows.Forms.Label botanicalNameLabel;
        private System.Windows.Forms.Label commonNameLabel;
        private System.Windows.Forms.Button homeButton;
        public System.Windows.Forms.Button editPlantButton;
        private System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.TextBox moreInfoTextBox;
        public System.Windows.Forms.TextBox fertilizerRequirementTextBox;
        public System.Windows.Forms.TextBox waterRequirementTextBox;
        public System.Windows.Forms.TextBox lightRequirementTextBox;
        public System.Windows.Forms.TextBox botanicalNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox commonNameTextBox;
    }
}