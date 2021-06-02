using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using RuRay.DAL.MySql.Contract;
using RuRay.DAL.MySql.Models;

namespace RuRay.DAL.MySql
{
    /// <summary>
    /// Defines the <see cref="CarsRepository" />.
    /// </summary>
    public class CarsRepository : ICarsRepository, IHealthCheck
    {
        /// <summary>
        /// Defines the _options.
        /// </summary>
        private readonly IOptionsMonitor<CarsMySqlRepositoryOption> _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarsRepository"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="IOptionsMonitor{CarsMySqlRepositoryOption}"/>.</param>
        public CarsRepository(IOptionsMonitor<CarsMySqlRepositoryOption> options)
        {
            _options = options;
        }

        /// <summary>
        /// The CreateCarAsync.
        /// </summary>
        /// <param name="newCar">The newCar<see cref="CarEntity"/>.</param>
        /// <returns>The <see cref="Task{CarEntity}"/>.</returns>
        public async Task<CarEntity> CreateCarAsync(CarEntity newCar)
        {
            if (newCar.Id == Guid.Empty.ToString())
            {
                newCar.Id = Guid.NewGuid().ToString();
            }
            var dnow = DateTime.UtcNow;
            newCar.CreatedOn = dnow;
            newCar.ModifiedOn = dnow;

            const string sqlQuery = @"INSERT INTO cars (
                    id,
                    modelname,                   
                    cartype,
                    createdon,
                    modifiedon                   
                )
                VALUES (
                    @id,
                    @modelname,                   
                    @cartype,
                    @createdon,
                    @modifiedon);";

            using (var db = new MySqlConnection(_options.CurrentValue.CarsDbConnectionString))
            {
                await db.ExecuteAsync(sqlQuery, newCar, commandType: CommandType.Text);
                return newCar;
            }
        }

        /// <summary>
        /// The GetCarAsync.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{CarEntity}"/>.</returns>
        public async Task<CarEntity> GetCarAsync(Guid id)
        {
            using (var db = new MySqlConnection(_options.CurrentValue.CarsDbConnectionString))
            {
                const string sqlQuery = @"SELECT 
                    id,
                    modelname,                    
                    cartype,
                    createdon,
                    modifiedon
                FROM cars
                WHERE id=@id;";
                return await db.QueryFirstOrDefaultAsync<CarEntity>(sqlQuery, new { id = id.ToString() }, commandType: CommandType.Text);
            }
        }

        /// <summary>
        /// The UpdateCarAsync.
        /// </summary>
        /// <param name="car">The car<see cref="CarEntity"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> UpdateCarAsync(CarEntity car)
        {
            car.ModifiedOn = DateTime.UtcNow;

            const string sqlQuery = @"UPDATE cars SET                
                modelname = @modelname,                
                cartype = @cartype,
                createdon = @createdon,
                modifiedon = @modifiedon
            WHERE id = @id;";

            using (var db = new MySqlConnection(_options.CurrentValue.CarsDbConnectionString))
            {
                await db.ExecuteAsync(sqlQuery, car, commandType: CommandType.Text);
                return true;
            }
        }

        /// <summary>
        /// The DeleteCarAsync.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> DeleteCarAsync(Guid id)
        {
            const string sqlQuery = @"DELETE FROM cars WHERE id = @id;";
            using (var db = new MySqlConnection(_options.CurrentValue.CarsDbConnectionString))
            {
                await db.ExecuteAsync(sqlQuery, new { id = id.ToString() }, commandType: CommandType.Text);
                return true;
            }
        }

        /// <summary>
        /// The GetCarsListAsync.
        /// </summary>
        /// <param name="pageNumber">The pageNumber<see cref="int"/>.</param>
        /// <param name="pageSize">The pageSize<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IEnumerable{CarEntity}}"/>.</returns>
        public async Task<IEnumerable<CarEntity>> GetCarsListAsync(int pageNumber, int pageSize)
        {
            using (var db = new MySqlConnection(_options.CurrentValue.CarsDbConnectionString))
            {
                var offset = pageNumber <= 1 ? 0 : (pageNumber - 1) * pageSize;
                const string sqlQuery = @"SELECT 
                    id,
                    modelname,                    
                    cartype,
                    createdon,
                    modifiedon
                FROM cars
                LIMIT @pageSize OFFSET @offset;";
                return await db.QueryAsync<CarEntity>(sqlQuery, new { pageSize, offset }, commandType: CommandType.Text);
            }
        }

        /// <summary>
        /// The CheckHealthAsync.
        /// </summary>
        /// <param name="context">The context<see cref="HealthCheckContext"/>.</param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{HealthCheckResult}"/>.</returns>
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            using (var db = new MySqlConnection(_options.CurrentValue.CarsDbConnectionString))
            {
                try
                {
                    db.Open();
                    db.Close();
                    return Task.FromResult(HealthCheckResult.Healthy());
                }
                catch
                {
                    return Task.FromResult(HealthCheckResult.Unhealthy());
                }
            }
        }
    }
}
