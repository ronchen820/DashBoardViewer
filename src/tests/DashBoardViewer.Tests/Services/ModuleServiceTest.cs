using Xunit;
using DashBoardViewer.Api.Services.Module;
using DashBoardViewer.Api.Domain.Module.Dto;
using ZhonTai.Admin.Core.Dto;

namespace DashBoardViewer.Tests.Services;

/// <summary>
/// 模块服务测试
/// </summary>
public class ModuleServiceTest : BaseTest
{
    private readonly IModuleService _moduleService;

    public ModuleServiceTest()
    {
        _moduleService = GetService<IModuleService>();
    }

    [Fact]
    public async void GetPageAsync()
    {
        var input = new PageInput<ModuleGetPageDto>() { };
        var output = await _moduleService.GetPageAsync(input);
        Assert.True(output?.Total >= 0);
    }
}