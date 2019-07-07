using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class AtuallizarEventoCommand : BaseEventoCommand
    {
        public AtuallizarEventoCommand(Guid id, string nome, string descricaoCurta, 
            string descricaoLonga, DateTime dataInicio, DateTime dataFim, bool gratuito, 
            decimal valor, bool online, string nomeEmpresa)
        {
            Id = id;
            Nome = nome;
            DescricaoCurta = descricaoCurta;
            DescricaoLonga = descricaoLonga;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeDaEmpresa = nomeEmpresa;
        }
    }
}
