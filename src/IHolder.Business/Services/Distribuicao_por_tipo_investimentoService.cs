using IHolder.Business.Entities;
using IHolder.Business.Entities.Validations;
using IHolder.Business.Interfaces.Notifications;
using IHolder.Business.Interfaces.Repositories;
using IHolder.Business.Interfaces.Services;
using IHolder.Business.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IHolder.Business.Services
{
    public class Distribuicao_por_tipo_investimentoService : ServiceBase, IDistribuicao_por_tipo_investimentoService
    {
        private readonly IDistribuicao_por_tipo_investimentoRepository _distribuicao_Por_Tipo_InvestimentoRepository;
        private readonly Distribuicao_por_tipo_investimentoValidation _validation;
        public Distribuicao_por_tipo_investimentoService(INotifier notifier,
                                                         IDistribuicao_por_tipo_investimentoRepository distribuicao_Por_Tipo_InvestimentoRepository) : base(notifier)
        {
            this._distribuicao_Por_Tipo_InvestimentoRepository = distribuicao_Por_Tipo_InvestimentoRepository;
            _validation = new Distribuicao_por_tipo_investimentoValidation(_distribuicao_Por_Tipo_InvestimentoRepository);
        }

        public async Task Delete(Guid id)
        {
            #warning IMPLEMENTAR VALIDAÇÃO 
            await _distribuicao_Por_Tipo_InvestimentoRepository.Delete(id);

        }

        public async Task<IEnumerable<Distribuicao_por_tipo_investimento>> GetManyBy(Expression<Func<Distribuicao_por_tipo_investimento, bool>> predicate)
        {
           return await _distribuicao_Por_Tipo_InvestimentoRepository.GetManyBy(predicate);
        }

        public async Task<bool> Insert(Distribuicao_por_tipo_investimento entity)
        {

            if (!RunValidation(_validation, entity))
                return false;
            return await _distribuicao_Por_Tipo_InvestimentoRepository.Insert(entity);
        }

        public async Task<bool> Update(Distribuicao_por_tipo_investimento entity)
        {
            if (!RunValidation(_validation, entity))
                return false;
            return await _distribuicao_Por_Tipo_InvestimentoRepository.Update(entity);
        }



    }
}
