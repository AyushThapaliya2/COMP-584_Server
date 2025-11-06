namespace COMP_584_Lab_Server.DTOs
{
    public class CountryPopulation
    {
        public required int Id { get; set; }

        public required string Name { get; set; }

        public required string Iso2 { get; set; }

        public required string Iso3 { get; set; }

        public double Population { get; set; }
    }
}
