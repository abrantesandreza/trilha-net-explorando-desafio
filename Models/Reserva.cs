namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Desculpe, a quantidade de hóspedes é maior que nossa capacidade!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorEstadia = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                decimal percentualDesconto = 0.10M;
                decimal desconto = valorEstadia * percentualDesconto;
                return valorEstadia -= desconto;
            }

            return valorEstadia;
        }
    }
}
