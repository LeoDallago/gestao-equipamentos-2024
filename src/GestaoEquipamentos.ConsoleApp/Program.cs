using GestaoEquipamentos.ConsoleApp.ModuloChamado;
using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPricipal();

        }

        public static void MenuPricipal()
        {
            Console.Write("Gerencia de equipamentos!\n");
            Console.WriteLine("O que voce quer fazer? \n" +
            "1- Gerenciar Equipamentos \n" +
            "2- Gerenciar Chamados\n");
            int escolha = Convert.ToInt32(Console.ReadLine());

            while (escolha != 3)
            {
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                       TelaEquipamento.Equipamentos();

                        break;

                    case 2:
                        Console.Clear();
                        TelaChamado.Chamados();

                        break;
                }
            }
        }
    }

}