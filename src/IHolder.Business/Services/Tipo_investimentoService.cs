using IHolder.Business.Entities;
using IHolder.Business.Interfaces.Notifications;
using IHolder.Business.Interfaces.Repositories;
using IHolder.Business.Interfaces.Services;
using IHolder.Business.Repositories.Base;
using IHolder.Business.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IHolder.Business.Services
{
    public class Tipo_investimentoService : ServiceBase, ITipo_investimentoService
    {
        private readonly ITipo_investimentoRepository _tipo_investimentoRepository;
        public Tipo_investimentoService(INotifier notifier, ITipo_investimentoRepository tipo_investimentoRepository) : base(notifier)
        {
            _tipo_investimentoRepository = tipo_investimentoRepository;
        }

        public async Task Delete(int id)
        {
            #warning VALIDACAO DE REGISTRO USADO
            await _tipo_investimentoRepository.Delete(id);
        }

        public async Task<IEnumerable<Tipo_investimento>> GetAll()
        {
            return await _tipo_investimentoRepository.GetAll();
        }

        public async Task<int> Insert(Tipo_investimento entity)
        {
            #warning VALIDACAO DE DUPLICIDADE
            return await _tipo_investimentoRepository.Insert(entity);

        }

        public async Task<int> Update(Tipo_investimento entity)
        {
            return await _tipo_investimentoRepository.Update(entity);
        }
    }
}
