using HomeWork22.DataStore;

namespace HomeWork22.Models
{
    public class CityGetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfInterest { get; set; }

        public CityGetModel() { }

        public CityGetModel(City city)
        {
            Id = city.Id;
            Name = city.Name;
            Description = city.Description;
            NumberOfPointsOfInterest = city.NumberOfPointsOfInterest;
        }

    }

}
