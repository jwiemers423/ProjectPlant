namespace FormUI
{
    public class Plant
    {
        public int PlantID { get; set; }
        public string CommonName { get; set; }
        public string BotanicalName { get; set; }
        public string LightRequirement { get; set; }
        public string WaterRequirement { get; set; }
        public string FertilizerRequirement { get; set; }
        public string MoreInfo { get; set; }    
        public byte[] Image { get; set; }
    }
}