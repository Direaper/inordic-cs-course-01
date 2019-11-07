using HomeWork22.Models;
using System.Collections.Generic;

namespace HomeWork22.DataStore
{
    public class CitiesDataStore
    {
        private static CitiesDataStore _citiesDataStore;

        public Dictionary<int, City> Cities { get; }

        private CitiesDataStore()
        {
            Cities = new Dictionary<int, City>
            {
                {
                    1,
                      new City
                         {
                              Id = 1,
                              Name = "Moscow",
                             Description = "This is my favorite city!",
                              NumberOfPointsOfInterest = 100
                         }
                 },
                 {
                      2,
                    new City
                    {
                        Id = 2,
                        Name = "New York",
                        Description = "I love NY",
                        NumberOfPointsOfInterest = 99
                    }
                 }
            };

        }
        public static CitiesDataStore GetInstance()
        {
            if (_citiesDataStore == null)
                _citiesDataStore = new CitiesDataStore();

            return _citiesDataStore;
        }
    }
}
