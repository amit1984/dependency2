using dependency2.Iinterface;
using dependency2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dependency2.Services
{
    public class OfficerService : IOfficerService
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<officer> _IRepository;

        public OfficerService(IUnitOfWork unitOfWork, IRepository<officer> Repository)
        {
            _unitOfWork = unitOfWork;
            _IRepository = Repository;
        }

        public void CreateOfficer(officer off)
        {
            _IRepository.Add(off);

        }
        public int getdatas()
        {
          return  _IRepository.getdata();
        }

    }
}