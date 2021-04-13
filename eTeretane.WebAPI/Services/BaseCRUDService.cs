using AutoMapper;
using eTeretane.WebAPI.EF;

namespace eTeretane.WebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TUpdate, TInsert> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TUpdate, TInsert> where TDatabase : class
    {
        public BaseCRUDService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }
    }
}
