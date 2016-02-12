using Nancy;
using System.Collections.Generic;
using System;
using Cds.Objects;

namespace Cds
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View ["index.cshtml"];
      };
      Get["/new_Cd"]=_=> {
        return View["new_cd.cshtml"];
      };
      Post["/"]=_=>{
        Cd newCd = new Cd (Request.Form["Cd-Name"],Request.Form["Cd-Artist"]);
        List<Cd> Cdlist = Cd.GetAll();
        return View["index.cshtml", Cdlist];
      };
      Get["/search"]=_=> {
        return View["search.cshtml"];
      };
      Post["/search"]=_=>{
        string returnString = Request.Form["searchString"];
        System.Console.WriteLine(returnString);
        List<Cd> Cdlist = Cd.SearchAll(returnString);
        return View["search.cshtml", Cdlist];
      };
    }
  }
}
