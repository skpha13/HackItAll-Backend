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
                      Id = new Guid(),
                      coordinateX = 44.46f,
                      coordinateY = 26.0f,
                      address = "Str. Gheorghe Sincai",
                      chargingStations = 3,
                    },
                    new Station()
                    {
                      Id = new Guid(),
                      coordinateX = 44.43f,
                      coordinateY = 26.11f,
                      address = "Str. Marasesti",
                      chargingStations = 4,
                    },
                    new Station()
                    {
                      Id = new Guid(),
                      coordinateX = 44.42f,
                      coordinateY = 26.12f,
                      address = "Str. Brancoveanu",
                      chargingStations = 10,
                    },
                    new Station()
                    {
                      Id = new Guid(),
                      coordinateX = 44.46f,
                      coordinateY = 26.18f,
                      address = "Str. Mihai Eminescu",
                      chargingStations = 5,
                    },
                };

                _dbContext.Stations.AddRange(stations);
                _dbContext.SaveChanges();
            }
        }
    }
}
