using Cargo.DataAccess.Abstract;
using Cargo.DataAccess.Repositories;
using DataAccess.Concrete;
using Entity.Concrete;
namespace Cargo.DataAccess.EntityFramework
{
    public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
    {
        public EfCargoDetailDal(CargoContext cargoContext) : base(cargoContext)
        {
        }
    }
}
