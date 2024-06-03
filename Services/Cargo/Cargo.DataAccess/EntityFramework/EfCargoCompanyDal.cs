

using Cargo.DataAccess.Abstract;
using Cargo.DataAccess.Repositories;
using DataAccess.Concrete;
using Entity.Concrete;

namespace Cargo.DataAccess.EntityFramework
{
    public class EfCargoCompanyDal : GenericRepository<CargoCompany>, ICargoCompanyDal
    {
        public EfCargoCompanyDal(CargoContext cargoContext) : base(cargoContext)
        {
        }
    }
}
