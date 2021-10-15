using System.Security.AccessControl;
using Home2Med.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home2Med.Client.Services
{
    public interface IServiceNurse
   {
      List<Nurse> GetNurses();
      Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
    }
}