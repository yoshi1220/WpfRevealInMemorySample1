using System.Collections.Generic;

namespace InputControlSample.Services
{
    /// <summary>
    /// マスター制御用サービスインターフェース
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IMasterService<TEntity>
    {
        TEntity Get(int id);
        TEntity Get(string id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);

        void Update(TEntity entity, int id);
        void Remove(int id);
    }
}
