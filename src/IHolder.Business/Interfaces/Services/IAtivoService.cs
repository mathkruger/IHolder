using IHolder.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IHolder.Business.Interfaces.Services
{
    public interface IAtivoService
    {
        Task<int> Insert(Ativo ativo);
        Task<int> Update(Ativo ativo);
        Task Delete(int id);
        Task GetAll();
    }
}
