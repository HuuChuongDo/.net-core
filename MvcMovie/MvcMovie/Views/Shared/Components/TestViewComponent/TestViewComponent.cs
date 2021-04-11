using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Views.Shared.Components.TestViewComponent
{
    public class TestViewComponent: ViewComponent
    {
        public string Invoke()
        {
            return "this is testing from view component";
        }
    }
}
