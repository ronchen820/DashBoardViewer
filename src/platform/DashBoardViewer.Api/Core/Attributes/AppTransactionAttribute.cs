using System;
using DashBoardViewer.Api.Core.Consts;
using ZhonTai.Admin.Core.Attributes;

namespace DashBoardViewer.Api.Core.Attributes;

/// <summary>
/// 启用事物
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = true)]
public class AppTransactionAttribute : TransactionAttribute
{
    public AppTransactionAttribute(): base(DbKeys.AppDb)
    {
    }
}