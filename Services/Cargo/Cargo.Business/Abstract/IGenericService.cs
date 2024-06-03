

namespace Cargo.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(long id);
        T TGetById(long id);
        List<T> TGetAll();

    }
}
