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
                      coordinateX = 44.46f,
                      coordinateY = 26.0f,
                      address = "address 1",
                      chargingStations = 3,
                    },
                    new Station()
                    {
                      coordinateX = 44.41f,
                      coordinateY = 26.10f,
                      address = "address 2",
                      chargingStations = 4,
                    },
                    new Station()
                    {
                      coordinateX = 44.463f,
                      coordinateY = 26.086f,
                      address = "address 3",
                      chargingStations = 10,
                    },
                    new Station()
                    {
                      coordinateX = 44.434f,
                      coordinateY = 26.044f,
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
