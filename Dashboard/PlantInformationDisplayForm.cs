﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class PlantInformationDisplayForm : Form
    {
        public int plantId = 0;
        public PlantInformationEditForm plantInfoForm = new PlantInformationEditForm();
        public PlantInformationDisplayForm()
        {
            InitializeComponent();
        }
        public void ReturnHome()
        {
            // Closes current form and opens MainForm
            var mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
            MainForm.plantSelected = false;
        }

        private void editPlantButton_Click(object sender, EventArgs e)
        {
            //Transfers textbox data to editer form
            MainForm.plantSelected = true;
            plantInfoForm.deleteButton.Enabled = true;
            plantInfoForm.addPlantButton.Text = "Save Edit";
            plantInfoForm.plantId = plantId;
            plantInfoForm.commonNameTextBox.Text = commonNameTextBox.Text;
            plantInfoForm.botanicalNameTextBox.Text = botanicalNameTextBox.Text;
            plantInfoForm.waterRequirementTextBox.Text = waterRequirementTextBox.Text;
            plantInfoForm.lightRequirementTextBox.Text = lightRequirementTextBox.Text;
            plantInfoForm.fertilizerRequirementTextBox.Text = fertilizerRequirementTextBox.Text;
            plantInfoForm.moreInfoTextBox.Text = moreInfoTextBox.Text;
            plantInfoForm.plantPictureBox.Image = plantPictureBox.Image;

            // Closes current form and opens PlantInformationForm            
            this.Hide();
            plantInfoForm.ShowDialog();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ReturnHome();
        }

        //KeyPress Event for all textboxes
        private void KeyPressDown(object sender, KeyEventArgs e)
        {
            ReturnHome();
        }
    }
}