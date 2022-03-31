using ULTIMOTESTE3_3.Models;
using static System.Console;
namespace UTLIMOTESTE3_3
{
      class program
      {
            public static void Main(string[]args)
            {     
                  Morador morador = new Morador();
                  int [] Casas = new int []{1,2,3,4,5,6};
                  int CasasImpares = 0;
                  for (int i = 1; i <= 6 ;i++)
                  {
                        WriteLine($"\nA {i}º casa tem cachorro? [S]Sim/[N]Nao"); 
                        string CachorroExists = ReadLine();
                        if (CachorroExists.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                        {     
                              morador.getTelefone();
                              morador.getNumeroResidencia();
                              morador.Calculo();

                              if (Casas[i] % 2 == 1)
                              {
                              CasasImpares = CasasImpares + 1;
                              }
                        }
                        else
                        {
                              WriteLine($"Correspondência não entregue na {i}º Casa...");
                        }
                        
                        
                  }     
                  morador.Mensagem();
            }
      }
}