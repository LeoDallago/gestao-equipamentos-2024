namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista novaLista = new();
            Console.WriteLine("Cadastro de Equipamentos!");
            int escolha = OpcaoMenu();

            while (escolha != 5)
            {
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        novaLista.registraProduto();

                        escolha = OpcaoMenu();
                        break;

                    case 2:
                        Console.Clear();
                        novaLista.ExibeProdutos();

                        escolha = OpcaoMenu();
                        break;

                    case 3:
                        Console.Clear();
                        novaLista.ExibeProdutos();
                        Console.WriteLine("Informe o ID do produto a ser removido");
                        int id = Convert.ToInt32(Console.ReadLine());
                        novaLista.DeletaProduto(id);

                        escolha = OpcaoMenu();
                        break;

                    case 4:
                        Console.Clear();
                        novaLista.ExibeProdutos();
                        Console.WriteLine("Informe o ID do produto a ser editado");
                        id = Convert.ToInt32(Console.ReadLine());
                        novaLista.EditaProduto(id);

                        escolha = OpcaoMenu();
                        break;
                }
            }

        }

        private static int OpcaoMenu()
        {
            Console.WriteLine("Por favor escolha a opcao desejada \n 1- Cadastrar produto \n 2- Listagem de produtos \n 3- Remocao de produtos \n 4- Edicao de produtos \n 5- Sair");
            int escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
    }
}
