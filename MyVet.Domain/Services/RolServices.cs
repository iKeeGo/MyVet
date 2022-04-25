using Infraestructure.Core.UnitOfWork.Interface;
using Infraestructure.Entity.Model;
using MyVet.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyVet.Domain.Services
{
    public class RolServices : IRolServices
    {
        #region Attribute
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IRestService _restService;
        //private readonly IConfiguration _config;
        #endregion

        public RolServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public List<RolEntity> GetAll()=> _unitOfWork.RolRepository.GetAll().ToList();
        
    }
}
