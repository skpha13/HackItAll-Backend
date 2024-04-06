using backend.Data;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Helpers.Seeders
{
    public class StationSeeder
    {
        private readonly DatabaseContext _dbContext;

        public StationSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void seedInitialStations()
        {
            if (!_dbContext.Stations.Any())
            {
                var stations = new List<Station>
                {
                    new Station()
                    {
                      coordinateX = 123.123f,
                      coordinateY = 123.123f,
                      address = "address 1",
                      chargingStations = 3,
                    },
                    new Station()
                    {
                      coordinateX = 2344f,
                      coordinateY = 42342f,
                      address = "address 2",
                      chargingStations = 4,
                    },
                    new Station()
                    {
                      coordinateX = 8732f,
                      coordinateY = 785f,
                      address = "address 3",
                      chargingStations = 10,
                    },
                    new Station()
                    {
                      coordinateX = 28796f,
                      coordinateY = 27896f,
                      address = "address 4",
                      chargingStations = 5,
                    },
                };

                _dbContext.Stations.AddRange(stations);
                _dbContext.SaveChanges();
            }
        }
    }
}
