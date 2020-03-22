using AutoMapper;
using IHolder.Api.ViewModels;
using IHolder.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.Configurations.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration ()
        {
            CreateMap<Situacao, SituacaoViewModel>().ReverseMap();
            CreateMap<Risco, RiscoViewModel>().ReverseMap();
            CreateMap<Orientacao, OrientacaoViewModel>().ReverseMap();
            CreateMap<Tipo_investimento, Tipo_investimentoViewModel>().ReverseMap();
            CreateMap<Distribuicao_por_tipo_investimento, Distribuicao_por_tipo_investimentoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Distribuicao_por_produto, Distribuicao_por_produtoViewModel>().ReverseMap();
            CreateMap<Ativo, AtivoViewModel>().ReverseMap();
            CreateMap<Distribuicao_por_ativo, Distribuicao_por_ativoViewModel>().ReverseMap();
            CreateMap<Aporte, AporteViewModel>().ReverseMap();
        }
    }
}
