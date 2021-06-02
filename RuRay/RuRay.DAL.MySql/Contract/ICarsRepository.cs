using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RuRay.DAL.MySql.Models;

namespace RuRay.DAL.MySql.Contract
{
    /// <summary>
    /// Defines the <see cref="ICarsRepository" />.
    /// </summary>
    public interface ICarsRepository
    {
        /// <summary>
        /// The CreateCarAsync.
        /// </summary>
        /// <param name="car">The car<see cref="CarEntity"/>.</param>
        /// <returns>The <see cref="Task{CarEntity}"/>.</returns>
        Task<CarEntity> CreateCarAsync(CarEntity car);

        /// <summary>
        /// The GetCarAsync.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{CarEntity}"/>.</returns>
        Task<CarEntity> GetCarAsync(Guid id);

        /// <summary>
        /// The UpdateCarAsync.
        /// </summary>
        /// <param name="car">The car<see cref="CarEntity"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> UpdateCarAsync(CarEntity car);

        /// <summary>
        /// The DeleteCarAsync.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        Task<bool> DeleteCarAsync(Guid id);

        /// <summary>
        /// The GetCarsListAsync.
        /// </summary>
        /// <param name="pageNumber">The pageNumber<see cref="int"/>.</param>
        /// <param name="pageSize">The pageSize<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IEnumerable{CarEntity}}"/>.</returns>
        Task<IEnumerable<CarEntity>> GetCarsListAsync(int pageNumber, int pageSize);
    }
}
