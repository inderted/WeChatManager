using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace WxManager.Pages
{
    public class Index_Tests : WxManagerWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
