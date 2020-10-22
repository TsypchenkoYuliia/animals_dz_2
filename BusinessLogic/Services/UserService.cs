using BusinessLogic.Infrastructure;
using BusinessLogic.ModelDTO;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace BusinessLogic.Services
{
    public class UserService
    {
        UserRepository _repository;
        MapperConfig _mapper;
        public UserService(UserRepository repository, MapperConfig mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IReadOnlyCollection<UserDTO>> GetAsync()
        {
            return _mapper.mapper.Map<IReadOnlyCollection<UserDTO>>(await _repository.GetAsync());
        }
        public async Task<UserDTO> GetUserAsync(string email, string password)
        {
            return _mapper.mapper.Map<UserDTO>(await _repository.GetAsync(x=>x.Email== email && x.Password==Crypto.SHA256(password)));
        }

        public async Task UpdateAsync(int id, string role)
        {
            var res = await _repository.GetAsync(x => x.Id == id);
            res.Role = role;
            await _repository.UpdateAsync(res);
        }
    }
}
