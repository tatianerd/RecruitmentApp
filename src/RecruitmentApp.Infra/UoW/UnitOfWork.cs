using RecruitmentApp.Infra.Context;

namespace RecruitmentApp.Infra.UoW
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _session;

        public UnitOfWork(DbContext session)
        {
            _session = session;
        }

        public void BeginTransaction()
        {
            _session.Transaction = _session.Connection.BeginTransaction();
        }
        public void Commit()
        {
            _session.Transaction.Commit();
            Dispose();
        }
        public void Rollback()
        {
            _session.Transaction.Rollback();
            Dispose();
        }
        public void Dispose() => _session.Transaction?.Dispose();
    }
}
