using Carvajal.CORE.Entities;
using Carvajal.CORE.Interfaces;
using Carvajal.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carvajal.INFRASTRUCTURE.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UsuariosContext _context;

        public UserRepository(UsuariosContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene todos los usuarios de la base de datos.
        /// </summary>
        /// <returns>Usuarios</returns>
        public IEnumerable<User> GetAll()
        {
            //Buscamos todos los usarios de la base de datos.
            return _context.User.AsEnumerable();
        }

        /// <summary>
        /// Obtenemos el usuario por id
        /// </summary>
        /// <param name="id">Llave primaria del usuario</param>
        /// <returns>Usuario</returns>
        public async Task<User> GetUserByID(int id)
        {
            //Obtenemos el usuario por el ID
            return await _context.User.FirstAsync(x => x.primary == id);
        }

        /// <summary>
        /// Insertamos un usuario en la kbase de datos.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Usuario</returns>
        public async Task AddUser(User user)
        {
            try
            {
                _context.Add(user);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception($"No se pudo insertar el usuario: {ex.Message}\n");
            }
        }

        /// <summary>
        /// Actualizamos el usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns>No retorna valores</returns>
        public async Task Update(User user)
        {
            try
            {
                _context.Update(user);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo actualizar el usuario: {ex.Message}\n");
            }
        }

        public async Task Delete(User user)
        {
            try
            {
                _context.Remove(user);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo eliminar el usuario: {ex.Message}\n");
            }
        }
    }

}
