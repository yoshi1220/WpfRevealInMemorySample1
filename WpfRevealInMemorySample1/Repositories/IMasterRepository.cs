using System.Collections.Generic;

namespace InputControlSample.Repositories
{
    /// <summary>
    /// マスターメンテ用Repositoryインターフェイス
    /// </summary>
    /// <typeparam name="TEntity">モデルを指定する</typeparam>
    public interface IMasterRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        TEntity Get(string id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);

        void Update(TEntity entity, int id);
        void Remove(int id);
    }
}
