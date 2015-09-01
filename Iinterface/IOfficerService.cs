using dependency2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency2.Iinterface
{
  public  interface IOfficerService
    {
        void CreateOfficer(officer off);
        int getdatas();
    }
}
