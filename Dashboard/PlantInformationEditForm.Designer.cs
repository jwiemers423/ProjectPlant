namespace FormUI
{
    partial class PlantInformationEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantInformationEditForm));
            this.mainLabel = new System.Windows.Forms.Label();
            this.commonNameLabel = new System.Windows.Forms.Label();
            this.botanicalNameLabel = new System.Windows.Forms.Label();
            this.lightRequirementLabel = new System.Windows.Forms.Label();
            this.waterRequirementLabel = new System.Windows.Forms.Label();
            this.fertilizerRequirementLabel = new System.Windows.Forms.Label();
            this.commonNameTextBox = new System.Windows.Forms.TextBox();
            this.botanicalNameTextBox = new System.Windows.Forms.TextBox();
            this.lightRequirementTextBox = new System.Windows.Forms.TextBox();
            this.waterRequirementTextBox = new System.Windows.Forms.TextBox();
            this.fertilizerRequirementTextBox = new System.Windows.Forms.TextBox();
            this.plantPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.moreInfoTextBox = new System.Windows.Forms.TextBox();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.addPlantButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Plant Information";
            // 
            // commonNameLabel
            // 
            this.commonNameLabel.AutoSize = true;
            this.commonNameLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonNameLabel.ForeColor = System.Drawing.Color.White;
            this.commonNameLabel.Location = new System.Drawing.Point(32, 122);
            this.commonNameLabel.Name = "commonNameLabel";
            this.commonNameLabel.Size = new System.Drawing.Size(180, 27);
            this.commonNameLabel.TabIndex = 0;
            this.commonNameLabel.Text = "Common Name:";
            // 
            // botanicalNameLabel
            // 
            this.botanicalNameLabel.AutoSize = true;
            this.botanicalNameLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botanicalNameLabel.ForeColor = System.Drawing.Color.White;
            this.botanicalNameLabel.Location = new System.Drawing.Point(31, 178);
            this.botanicalNameLabel.Name = "botanicalNameLabel";
            this.botanicalNameLabel.Size = new System.Drawing.Size(222, 27);
            this.botanicalNameLabel.TabIndex = 0;
            this.botanicalNameLabel.Text = "Botanical Name:";
            // 
            // lightRequirementLabel
            // 
            this.lightRequirementLabel.AutoSize = true;
            this.lightRequirementLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightRequirementLabel.ForeColor = System.Drawing.Color.White;
            this.lightRequirementLabel.Location = new System.Drawing.Point(32, 234);
            this.lightRequirementLabel.Name = "lightRequirementLabel";
            this.lightRequirementLabel.Size = new System.Drawing.Size(264, 27);
            this.lightRequirementLabel.TabIndex = 0;
            this.lightRequirementLabel.Text = "Light Requirement:";
            // 
            // waterRequirementLabel
            // 
            this.waterRequirementLabel.AutoSize = true;
            this.waterRequirementLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterRequirementLabel.ForeColor = System.Drawing.Color.White;
            this.waterRequirementLabel.Location = new System.Drawing.Point(31, 290);
            this.waterRequirementLabel.Name = "waterRequirementLabel";
            this.waterRequirementLabel.Size = new System.Drawing.Size(264, 27);
            this.waterRequirementLabel.TabIndex = 0;
            this.waterRequirementLabel.Text = "Water Requirement:";
            // 
            // fertilizerRequirementLabel
            // 
            this.fertilizerRequirementLabel.AutoSize = true;
            this.fertilizerRequirementLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizerRequirementLabel.ForeColor = System.Drawing.Color.White;
            this.fertilizerRequirementLabel.Location = new System.Drawing.Point(31, 346);
            this.fertilizerRequirementLabel.Name = "fertilizerRequirementLabel";
            this.fertilizerRequirementLabel.Size = new System.Drawing.Size(334, 27);
            this.fertilizerRequirementLabel.TabIndex = 0;
            this.fertilizerRequirementLabel.Text = "Fertilizer Requirement:";
            // 
            // commonNameTextBox
            // 
            this.commonNameTextBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commonNameTextBox.Location = new System.Drawing.Point(399, 119);
            this.commonNameTextBox.Name = "commonNameTextBox";
            this.commonNameTextBox.Size = new System.Drawing.Size(441, 35);
            this.commonNameTextBox.TabIndex = 1;
            this.commonNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // botanicalNameTextBox
            // 
            this.botanicalNameTextBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botanicalNameTextBox.Location = new System.Drawing.Point(399, 175);
            this.botanicalNameTextBox.Name = "botanicalNameTextBox";
            this.botanicalNameTextBox.Size = new System.Drawing.Size(441, 35);
            this.botanicalNameTextBox.TabIndex = 2;
            this.botanicalNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // lightRequirementTextBox
            // 
            this.lightRequirementTextBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightRequirementTextBox.Location = new System.Drawing.Point(399, 231);
            this.lightRequirementTextBox.Name = "lightRequirementTextBox";
            this.lightRequirementTextBox.Size = new System.Drawing.Size(441, 35);
            this.lightRequirementTextBox.TabIndex = 3;
            this.lightRequirementTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // waterRequirementTextBox
            // 
            this.waterRequirementTextBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterRequirementTextBox.Location = new System.Drawing.Point(399, 287);
            this.waterRequirementTextBox.Name = "waterRequirementTextBox";
            this.waterRequirementTextBox.Size = new System.Drawing.Size(441, 35);
            this.waterRequirementTextBox.TabIndex = 4;
            this.waterRequirementTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // fertilizerRequirementTextBox
            // 
            this.fertilizerRequirementTextBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizerRequirementTextBox.Location = new System.Drawing.Point(399, 343);
            this.fertilizerRequirementTextBox.Name = "fertilizerRequirementTextBox";
            this.fertilizerRequirementTextBox.Size = new System.Drawing.Size(441, 35);
            this.fertilizerRequirementTextBox.TabIndex = 5;
            this.fertilizerRequirementTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // plantPictureBox
            // 
            this.plantPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plantPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plantPictureBox.Location = new System.Drawing.Point(874, 92);
            this.plantPictureBox.Name = "plantPictureBox";
            this.plantPictureBox.Size = new System.Drawing.Size(544, 312);
            this.plantPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantPictureBox.TabIndex = 12;
            this.plantPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(31, 415);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(180, 27);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description:";
            // 
            // moreInfoTextBox
            // 
            this.moreInfoTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfoTextBox.Location = new System.Drawing.Point(36, 450);
            this.moreInfoTextBox.Multiline = true;
            this.moreInfoTextBox.Name = "moreInfoTextBox";
            this.moreInfoTextBox.Size = new System.Drawing.Size(1382, 265);
            this.moreInfoTextBox.TabIndex = 6;
            this.moreInfoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // browseImageButton
            // 
            this.browseImageButton.BackColor = System.Drawing.Color.White;
            this.browseImageButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImageButton.ForeColor = System.Drawing.Color.Black;
            this.browseImageButton.Location = new System.Drawing.Point(1265, 410);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(153, 29);
            this.browseImageButton.TabIndex = 7;
            this.browseImageButton.Text = "Browse Image";
            this.browseImageButton.UseVisualStyleBackColor = false;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            this.browseImageButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // addPlantButton
            // 
            this.addPlantButton.BackColor = System.Drawing.Color.White;
            this.addPlantButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlantButton.ForeColor = System.Drawing.Color.Black;
            this.addPlantButton.Location = new System.Drawing.Point(1265, 721);
            this.addPlantButton.Name = "addPlantButton";
            this.addPlantButton.Size = new System.Drawing.Size(153, 29);
            this.addPlantButton.TabIndex = 9;
            this.addPlantButton.Text = "Add Plant";
            this.addPlantButton.UseVisualStyleBackColor = false;
            this.addPlantButton.Click += new System.EventHandler(this.addPlantButton_Click);
            this.addPlantButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Black;
            this.homeButton.Location = new System.Drawing.Point(36, 721);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(153, 29);
            this.homeButton.TabIndex = 10;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(1105, 721);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 29);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // PlantInformationEditForm
            // 
            this.AcceptButton = this.addPlantButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1455, 764);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.addPlantButton);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.moreInfoTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.plantPictureBox);
            this.Controls.Add(this.fertilizerRequirementTextBox);
            this.Controls.Add(this.waterRequirementTextBox);
            this.Controls.Add(this.lightRequirementTextBox);
            this.Controls.Add(this.botanicalNameTextBox);
            this.Controls.Add(this.commonNameTextBox);
            this.Controls.Add(this.fertilizerRequirementLabel);
            this.Controls.Add(this.waterRequirementLabel);
            this.Controls.Add(this.lightRequirementLabel);
            this.Controls.Add(this.botanicalNameLabel);
            this.Controls.Add(this.commonNameLabel);
            this.Controls.Add(this.mainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlantInformationEditForm";
            this.Text = "Project Plant";
            ((System.ComponentModel.ISupportInitialize)(this.plantPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label commonNameLabel;
        private System.Windows.Forms.Label botanicalNameLabel;
        private System.Windows.Forms.Label lightRequirementLabel;
        private System.Windows.Forms.Label waterRequirementLabel;
        private System.Windows.Forms.Label fertilizerRequirementLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Button homeButton;
        public System.Windows.Forms.TextBox commonNameTextBox;
        public System.Windows.Forms.TextBox botanicalNameTextBox;
        public System.Windows.Forms.TextBox lightRequirementTextBox;
        public System.Windows.Forms.TextBox waterRequirementTextBox;
        public System.Windows.Forms.TextBox fertilizerRequirementTextBox;
        public System.Windows.Forms.TextBox moreInfoTextBox;
        public System.Windows.Forms.Button addPlantButton;
        public System.Windows.Forms.PictureBox plantPictureBox;
        public System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}