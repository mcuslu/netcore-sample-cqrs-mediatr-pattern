namespace netcore_sample_cqrs_mediatr_pattern.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string? StockCode { get; set; }
    }
}
