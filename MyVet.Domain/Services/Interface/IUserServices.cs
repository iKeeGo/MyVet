using Infraestructure.Entity.Model;
using MyVet.Domain.Dto;
//using MyVet.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyVet.Domain.Services.Interface
{
    public interface IUserServices
    {

        #region Crud Methods
        List<UserEntity> GetAll();

        UserEntity GetUser(int idUser);

        Task<bool> UpdateUser(UserEntity user);

        Task<bool> DeleteUser(int idUser);

        Task<ResponseDto> CreateUser(UserEntity data);
        
        #endregion

        #region Auth
        Task<ResponseDto> Login(UserDto user);
        Task<ResponseDto> Register(UserDto data);
        #endregion



    }
}