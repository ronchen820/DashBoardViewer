using DashBoardViewer.Api.Core.Repositories;
using DashBoardViewer.Api.Domain.Module;
using ZhonTai.Admin.Core.Db.Transaction;

namespace DashBoardViewer.Api.Repositories;

/// <summary>
/// ģ��ִ�
/// </summary>
public class ModuleRepository : AppRepositoryBase<ModuleEntity>, IModuleRepository
{
    public ModuleRepository(UnitOfWorkManagerCloud uowm) : base(uowm)
    {
    }
}