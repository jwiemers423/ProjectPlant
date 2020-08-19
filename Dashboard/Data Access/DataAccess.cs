using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;


namespace FormUI
{
    public class DataAccess
    {
        
        //Method populates Plant list from SQL table with whatever text is in the searchTextBox. If searchTextBox is blank, all fields will show.
        public List<Plant> GetPlants(string searchName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectPlantDB")))
            {
                var output = 
                    connection.Query<Plant>("dbo.PlantViewAllOrSearch @SearchText", new { SearchText = searchName}).ToList();
                return output;
            }
        }

        //Saves new plant entry to SQL table
        public void SavePlant(string commonName, string botanicalName, string lightRequirement, string waterRequirement, string fertilizerRequirement, string moreInfo, byte[] image)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectPlantDB")))
            {                
                List<Plant> plants = new List<Plant>();

                plants.Add(new Plant
                {
                    CommonName = commonName,
                    BotanicalName = botanicalName,
                    LightRequirement = lightRequirement,
                    WaterRequirement = waterRequirement,
                    FertilizerRequirement = fertilizerRequirement,
                    MoreInfo = moreInfo,
                    Image = image
                });                
                connection.Execute ("dbo.PlantAdd @CommonName, @BotanicalName, @LightRequirement, @WaterRequirement, @FertilizerRequirement, @MoreInfo, @Image", plants);
            }
        }
        
        //Updates a selected plant in a SQL table with new data
        public void UpdatePlant(int plantID, string commonName, string botanicalName, string lightRequirement, string waterRequirement, string fertilizerRequirement, string moreInfo, byte[] image)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectPlantDB")))
            {
                List<Plant> plants = new List<Plant>();

                plants.Add(new Plant
                {
                    PlantID = plantID,
                    CommonName = commonName,
                    BotanicalName = botanicalName,
                    LightRequirement = lightRequirement,
                    WaterRequirement = waterRequirement,
                    FertilizerRequirement = fertilizerRequirement,
                    MoreInfo = moreInfo,
                    Image = image
                });
                connection.Execute("dbo.PlantUpdateByID @PlantID, @CommonName, @BotanicalName, @LightRequirement, @WaterRequirement, @FertilizerRequirement, @MoreInfo, @Image", plants);
            }
        }
        
        //Deletes plant by select plantID
        public void DeletePlant(int plantID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectPlantDB")))
            {
                connection.Query<Plant>("dbo.PlantDeleteByID @PlantID", new { PlantID = plantID }).ToList();
            }
        }
        
        //Pulls up File Explorer so user can select an image
        public string BrowsePhoto()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ProjectPlantDB")))
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|ALL FILES (*.*)|*.*";
                dlg.Title = "Select Plant Picture";
                
                List<Plant> plants = new List<Plant>();
                if (dlg.ShowDialog() == DialogResult.OK)
                {                    
                    var output = dlg.FileName.ToString();
                    return output;
                }
                else
                { return null; }
            }
        }
    }
}


