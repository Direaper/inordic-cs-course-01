using Microsoft.AspNetCore.Mvc;
using HomeWork22.DataStore;
using System;
using System.Linq;
using HomeWork22.Models;


namespace HomeWork22.Controllers
{
    public class CitiesController : Controller
    {
        [HttpGet("/api/cities")]
        public IActionResult GetCities()
        {
            var citiesDataStore = CitiesDataStore.GetInstance();
            var citiyGetModelList =
                citiesDataStore.Cities
                .Values
                .Select(x => new CityGetModel(x))
                .ToList();

            return Ok(citiyGetModelList);
        }

        [HttpGet("/api/cities/{id}")]
        public IActionResult GetCity(int id)
        {
            var citiesDataStore = CitiesDataStore.GetInstance();

            if (citiesDataStore.Cities.ContainsKey(id))
            {
                City city = citiesDataStore.Cities[id];
                return Ok(new CityGetModel(city));
            }
            return NotFound();
        }

        [HttpPost("/api/cities/")]
        public IActionResult AddCity([FromBody] CityCreateOrUpdateModel cityCreateModel)
        {
            if(cityCreateModel == null)
                return BadRequest();

            var citiesDataStore = CitiesDataStore.GetInstance();

            var id = citiesDataStore.Cities.Keys.Max() + 1;
            City city = cityCreateModel.ConverToCity(id);
            citiesDataStore.Cities.Add(city.Id, city);

            return Created($"/api/cities/{id}" + city.Id, new CityGetModel(city));
        }
       
        [HttpDelete("/api/cities/{id}")]
        public IActionResult DeleteCity(int id)
        {
            var citiesDataStore = CitiesDataStore.GetInstance();

            if (citiesDataStore.Cities.ContainsKey(id))
            {
                citiesDataStore.Cities.Remove(id);
                return NoContent();
            }

            return NotFound();
        }

        [HttpPut("/api/cities/{id}")]
        public IActionResult ReplaceCity(int id, [FromBody] CityCreateOrUpdateModel cityCreateOrUpdateModel)
        {
            var citiesDataStore = CitiesDataStore.GetInstance();

            if (citiesDataStore.Cities.ContainsKey(id))
            {
                citiesDataStore.Cities[id].Name = cityCreateOrUpdateModel.Name;
                citiesDataStore.Cities[id].Description = cityCreateOrUpdateModel.Description;
                citiesDataStore.Cities[id].NumberOfPointsOfInterest = cityCreateOrUpdateModel.NumberOfPointsOfInterest;
                return Ok(new CityGetModel(citiesDataStore.Cities[id]));
            }

            return NotFound();
        }
    }
}
