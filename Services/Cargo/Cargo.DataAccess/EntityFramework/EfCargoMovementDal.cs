
using Cargo.DataAccess.Abstract;
using Cargo.DataAccess.Repositories;
using DataAccess.Concrete;
using Entity.Concrete;

namespace Cargo.DataAccess.EntityFramework
{
    public class EfCargoMovementDal : GenericRepository<CargoMovement>, ICargoMovementDal
    {
        public EfCargoMovementDal(CargoContext cargoContext) : base(cargoContext)
        {
        }
    }
}
