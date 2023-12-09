namespace SWMGApp.Models
{
    public class Industry
    {
        public string Name { get; set; }
        public int AvgWage { get; set; }
        public string minEducation { get; set; }
        public List<Company> Companies { get; set; }
    }
}
