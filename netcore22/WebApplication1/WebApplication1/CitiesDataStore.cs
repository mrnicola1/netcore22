using WebApplication1.Models;

namespace WebApplication1
{
    public class CitiesDataStore
    {

        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id =1,
                Name = "New York City",
                Description = "The one with that big park",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto() {
                        Id =1,
                        Name = "Central Park",
                        Description="Most visitet park in the United States" },
                    new PointOfInterestDto() {

                        Id = 2,
                        Name="Empire State Building",
                        Description="A102 -story skyscraper locateed in midtown Manhatten" },
                    
                }
            },
            new CityDto()
            {
                Id =2,
                Name = "Antwerp",
                Description ="Te ne with the cathedral that was never really finised",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                new PointOfInterestDto()
                    {
                        Id =3,
                        Name = "Cathedral of Our Lady",
                        Description="A Gothic style cathedral"
                    },

                    new PointOfInterestDto()
                    {
                        Id = 4,
                        Name="Antwerp Central Station",
                        Description="The finest examble of railway architecture in belgium"
                    },
                }
            },
            new CityDto()
            {

                Id =3,
                Name ="Paris",
                Description="Big tower",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                new PointOfInterestDto()
                    {
                        Id =5,
                        Name = "Eiffel tower",
                        Description="a Chonky tower"
                    },

                    new PointOfInterestDto()
                    {
                        Id = 6,
                        Name="The Louvre",
                        Description="Worlds largest mus"
                    },
                }
            }
        };
        }
    }
}
