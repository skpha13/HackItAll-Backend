using backend.Data;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Helpers.Seeders
{
    public class CarSeeder
    {
        private readonly DatabaseContext _dbContext;

        public CarSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void seedInitialCars()
        {
            if (!_dbContext.Cars.Any())
            {
                var stations = _dbContext.Models.ToList();

                var cars = new List<Car>();
                foreach (var model in stations)
                {
                    cars.Add(new Car()
                    {
                        brand = "Audi",
                        model = "Rs3",
                        batteryModelId = model.Id,
                    });
                    cars.Add(new Car()
                    {
                        brand = "BMW",
                        model = "i3",
                        batteryModelId = model.Id,
                    });
                    cars.Add(new Car()
                    {
                        brand = "Toyota",
                        model = "Auris",
                        batteryModelId = model.Id,
                    });
                    cars.Add(new Car()
                    {
                        brand = "Renault",
                        model = "Zoe",
                        batteryModelId = model.Id,
                    });
                }
               
              
                _dbContext.Cars.AddRange(cars);
                _dbContext.SaveChanges();
                
                
            }
        }
    }
}
