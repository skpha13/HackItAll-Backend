using backend.Data;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Helpers.Seeders
{
    public class ModelSeeder
    {
        private readonly DatabaseContext _dbContext;

        public ModelSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void seedInitialModels()
        {
            if (!_dbContext.Models.Any())
            {
                var models = new List<Model>
                {
                    new Model()
                    {
                        Id = new Guid(),
                        name = "model 1"
                    },
                    new Model()
                    {
                        Id = new Guid(),
                        name = "model 2"
                    },
                    new Model()
                    {
                        Id = new Guid(),
                        name = "model 3"
                    },
                        new Model()
                    {
                        Id = new Guid(),
                        name = "model 4"
                    },
                    new Model()
                    {
                        Id = new Guid(),
                        name = "model 5"
                    }
                };

                _dbContext.Models.AddRange(models);
                _dbContext.SaveChanges();
            }
        }
    }
}
