using Cargo.Business.Abstract;
using Cargo.DataAccess.Abstract;
using Entity.Concrete;

namespace Cargo.Business.Concrete
{
    public class CargoMovementManager : ICargoMovementService
    {
        private readonly ICargoMovementDal _cargoMovementDal;

        public CargoMovementManager(ICargoMovementDal cargoDetailDal)
        {
            _cargoMovementDal = cargoDetailDal;
        }

        public void TDelete(long id)
        {
            _cargoMovementDal.Delete(id);
        }

        public List<CargoMovement> TGetAll()
        {
            return _cargoMovementDal.GetAll();
        }

        public CargoMovement TGetById(long id)
        {
            return _cargoMovementDal.GetById(id);
        }

        public void TInsert(CargoMovement entity)
        {
            _cargoMovementDal.Insert(entity);
        }

        public void TUpdate(CargoMovement entity)
        {
            _cargoMovementDal.Update(entity);

        }
    }
}
