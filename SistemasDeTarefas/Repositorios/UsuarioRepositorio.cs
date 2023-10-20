using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Data;
using SistemasDeTarefas.Models;
using SistemasDeTarefas.Repositorios.Interfaces;

namespace SistemasDeTarefas.Repositorios
{
    public class UsuarioRepositorio : IUserRepositorio
    {
        private readonly SistemaTarefasDBContex _dBContex;
        public UsuarioRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dBContex = sistemaTarefasDBContex;
        }
           public async Task<UserModel?> BuscarPorId(int id)
        {
           return await _dBContex.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UserModel>> BuscarTodosUsuario()
        {
               return await _dBContex.Usuarios.ToListAsync();
        }
        public Task<UserModel> Adicionar(UserModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Atualizar(UserModel usuario, int id)
        {
            throw new NotImplementedException();
        }

     
    }
}