namespace WaterSystem_Model
{
    public class RowMaterialModel
    {
        public decimal RowMaterialId { get; set; }
        public string RowMaterialName { get; set; }
        public string RowMaterialFlag { get; set; }
        public decimal MeasurmentId { get; set; }
        public decimal RowHedarId { get; set; }
        public bool IsActive { get; set; }
        public string MeasurmentName { get; set; }
        public string RowHedarName { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}