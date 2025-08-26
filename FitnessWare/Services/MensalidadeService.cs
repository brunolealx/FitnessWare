using System.Collections.Generic;
using SeuProjeto.Models;

namespace SeuProjeto.Services
{
    public class MensalidadeService
    {
        // Lista interna que armazena todas as mensalidades
        private List<Mensalidade> mensalidades = new List<Mensalidade>();

        // Registra uma nova mensalidade
        public void RegistrarMensalidade(Mensalidade mensalidade)
        {
            mensalidades.Add(mensalidade); // Adiciona a mensalidade à lista
        }

        // Lista todas as mensalidades
        public List<Mensalidade> ListarMensalidades()
        {
            return mensalidades; // Retorna todas as mensalidades
        }

        // Lista apenas mensalidades pendentes (não pagas)
        public List<Mensalidade> ListarPendentes()
        {
            return mensalidades.FindAll(m => m.Pago == false);
        }

        // Marca uma mensalidade como paga
        public void MarcarComoPago(Mensalidade mensalidade)
        {
            mensalidade.Pago = true; // Atualiza a propriedade Pago para true
        }
    }
}
