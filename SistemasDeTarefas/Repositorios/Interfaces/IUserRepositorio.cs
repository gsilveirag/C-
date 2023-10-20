using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemasDeTarefas.Models;

namespace SistemasDeTarefas.Repositorios.Interfaces
{
    public interface IUserRepositorio
    {
        Task<List<UserModel>> BuscarTodosUsuario();
        Task<UserModel?> BuscarPorId(int id);
        Task<UserModel>Adicionar(UserModel usuario);
        Task<UserModel>Atualizar(UserModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}