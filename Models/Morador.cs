using static System.Console;
namespace ULTIMOTESTE3_3.Models
{
    public class Morador
    {   
        int CasasImpares = 0;
        private string Telefone;
        private int NumeroResidencia;
        public void getTelefone()
        {
            WriteLine("Informe o telefone: ");
            Telefone = ReadLine();

        }
        public void  getNumeroResidencia()
        {   
            
            WriteLine("Informe o numero da residência: ");
            NumeroResidencia = int.Parse(ReadLine());
                
        }
        public void Calculo()
        {
            if(NumeroResidencia % 2 == 1)
            {
            CasasImpares = CasasImpares + 1;
            }
        }
        public void Mensagem()
        {
            WriteLine($"\nQuantidade casas de números ímpares entregues: {CasasImpares}.");
        }
    }
}