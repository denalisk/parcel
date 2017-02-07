using Nancy;
using ParcelTracker.Objects;

namespace ParcelTracker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["form.cshtml"];
      };

      Get["/price"] = _ =>
      {
        ParcelVariables myParcelVariables = new ParcelVariables();
        myParcelVariables.SetHeight(Request.Query["height"]);
        myParcelVariables.SetWeight(Request.Query["weight"]);
        myParcelVariables.SetLength(Request.Query["length"]);
        myParcelVariables.SetWidth(Request.Query["width"]);
        return View["index.cshtml", myParcelVariables];
      };
    }

  }
}
