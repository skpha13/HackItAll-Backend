using backend.Data;
using backend.Models;
using HackItAll_Backend.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace HackItAll_Backend.Helpers.Seeders
{
    public class BatterySeeder
    {
        private readonly DatabaseContext _dbContext;

        public BatterySeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void seedInitialBatteries()
        {
            if (!_dbContext.Batteries.Any())
            {
                var batteries = new List<Battery>();

                var models = _dbContext.Models.ToList();
                var stations = _dbContext.Stations.ToList();    

                foreach ( var model in models)
                {
                    foreach (var station in stations)
                    {
                        batteries.Add(new Battery
                        {
                            modelId = model.Id,
                            stationId = station.Id,
                            maxCapacity = 1000,
                            capacity = 700,
                            state = State.CHARGING,
                        });

                        batteries.Add(new Battery
                        {
                            modelId = model.Id,
                            stationId = station.Id,
                            maxCapacity = 500,
                            capacity = 500,
                            state = State.RESERVED,
                        });

                        batteries.Add(new Battery
                        {
                            modelId = model.Id,
                            stationId = station.Id,
                            maxCapacity = 1000,
                            capacity = 700,
                            state = State.STORED,
                        });
                    }
                }
            

                _dbContext.Batteries.AddRange(batteries);
                _dbContext.SaveChanges();
            }
        }
    }
}
