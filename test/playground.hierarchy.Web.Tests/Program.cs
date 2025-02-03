using Microsoft.AspNetCore.Builder;
using playground.hierarchy;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("playground.hierarchy.Web.csproj"); 
await builder.RunAbpModuleAsync<hierarchyWebTestModule>(applicationName: "playground.hierarchy.Web");

public partial class Program
{
}
