using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using RuRay.BLL.Contracts;
using RuRay.BLL.Models;
using RuRay.DAL.MySql.Contract;
using RuRay.DAL.MySql.Models;

namespace RuRay.BLL
{
    /// <summary>
    /// Defines the <see cref="CarsService" />.
    /// </summary>
    public class CarsService : ICarsService
    {
        /// <summary>
        /// Defines the _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Gets the _carsRepo.
        /// </summary>
        public ICarsRepository _carsRepo { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarsService"/> class.
        /// </summary>
        /// <param name="mapper">The mapper<see cref="IMapper"/>.</param>
        /// <param name="carsRepo">The carsRepo<see cref="ICarsRepository"/>.</param>
        public CarsService(IMapper mapper, ICarsRepository carsRepo)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _carsRepo = carsRepo ?? throw new ArgumentNullException(nameof(carsRepo));
        }

        /// <summary>
        /// The CreateCarAsync.
        /// </summary>
        /// <param name="car">The car<see cref="Car"/>.</param>
        /// <returns>The <see cref="Task{Car}"/>.</returns>
        public async Task<Car> CreateCarAsync(Car car)
        {
            var newCar = await _carsRepo.CreateCarAsync(_mapper.Map<CarEntity>(car));
            return _mapper.Map<Car>(newCar);
        }

        /// <summary>
        /// The DeleteCarAsync.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> DeleteCarAsync(Guid id)
        {
            var result = await _carsRepo.DeleteCarAsync(id);
            return result;
        }

        /// <summary>
        /// The GetCarAsync.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{Car}"/>.</returns>
        public async Task<Car> GetCarAsync(Guid id)
        {
            var car = await _carsRepo.GetCarAsync(id);
            return _mapper.Map<Car>(car);
        }

        /// <summary>
        /// The GetCarsListAsync.
        /// </summary>
        /// <param name="pageNumber">The pageNumber<see cref="int"/>.</param>
        /// <param name="pageSize">The pageSize<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{IEnumerable{Car}}"/>.</returns>
        public async Task<IEnumerable<Car>> GetCarsListAsync(int pageNumber, int pageSize)
        {
            var cars = await _carsRepo.GetCarsListAsync(pageNumber, pageSize);
            return _mapper.Map<IEnumerable<Car>>(cars);
        }

        /// <summary>
        /// The UpdateCarAsync.
        /// </summary>
        /// <param name="car">The car<see cref="Car"/>.</param>
        /// <returns>The <see cref="Task{bool}"/>.</returns>
        public async Task<bool> UpdateCarAsync(Car car)
        {
            var result = await _carsRepo.UpdateCarAsync(_mapper.Map<CarEntity>(car));
            return result;
        }
    }
}
