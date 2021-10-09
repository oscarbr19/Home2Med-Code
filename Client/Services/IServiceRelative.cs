using System.Security.AccessControl;
using Home2Med.Shared.Entity;
using System.Collections.Generic;

namespace Home2Med.Client.Services
{
    public interface IServiceRelative
   {
      List<Relative> GetRelatives();
    }
}