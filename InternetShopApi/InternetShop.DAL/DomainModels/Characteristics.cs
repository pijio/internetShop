namespace InternetShop.DAL
{
    public class Characteristics
    {
        public int CharactId { get; set; }
        public string Processor { get; set; }
        public int? Ram { get; set; }
        public string? MatrixType { get; set; }
        public string? RelationSide { get; set; }
        public string? Dpi { get; set; }
        public string? Format { get; set; }
        public string? PrinterRam { get; set; }
        public string? PrinterType { get; set; }
        public double? ScreenSize { get; set; }
        public string Os { get; set; }
        public string? DiscVolAndType { get; set; }
    }
}