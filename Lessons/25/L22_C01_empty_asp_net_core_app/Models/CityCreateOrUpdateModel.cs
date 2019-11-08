using HomeWork22.DataStore;


namespace HomeWork22.Models
{
    public class CityCreateOrUpdateModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfInterest { get; set; }

        public City ConverToCity(int id)
        {
            return new City
            {
                Id = id,
                Name = Name,
                Description = Description,
                NumberOfPointsOfInterest = NumberOfPointsOfInterest
            };
        }
    }
}

