namespace IHolder.Business.Entities.Base
{
    public abstract class Valores_base : Entidade_base
    {
        protected Valores_base(decimal percentual_objetivo)
        {
            Percentual_objetivo = percentual_objetivo;
        }

        public decimal Percentual_objetivo { get; private set; }
        public decimal Percentual_atual { get; private set; }
        public decimal Percentual_diferenca { get; private set; }
        public decimal Valor_atual { get; private set; }
        public decimal Valor_diferenca { get; private set; }

        public void AtualizarPercentualAtual (decimal valor_investido_total, decimal valor_atual)
        {
            Percentual_atual = (valor_atual / valor_investido_total) * 100;
        }

        public void AtualizarPercentualDiferenca()
        {
            Percentual_diferenca = Percentual_objetivo - Percentual_atual;
        }

        public void AtualizarValorAtual(decimal valor_atual)
        {
            Valor_atual = valor_atual;
        }

        public void AtualizarValorDiferenca(decimal valor_atual)
        {
            AtualizarPercentualDiferenca();
            Valor_diferenca = (valor_atual / Percentual_atual) * Percentual_diferenca;
        }

    }
}
