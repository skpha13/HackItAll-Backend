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
                       name = "model 1"
                    },
                    new Model()
                    {
                       name = "model 2"
                    },
                    new Model()
                    {
                        name = "model 3"
                    },
                        new Model()
                    {
                        name = "model 4"
                    },
                    new Model()
                    {
                        name = "model 5"
                    }
                };

                _dbContext.Models.AddRange(models);
                _dbContext.SaveChanges();
            }
        }
    }
}
