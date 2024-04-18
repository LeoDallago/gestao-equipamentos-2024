namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPricipal();

        }

        private static void MenuPricipal()
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
                        Equipamentos();

                        break;

                    case 2:
                        Console.Clear();
                        Chamados();

                        break;
                }
            }
        }

        private static void Chamados()
        {
            ListaChamado novoChamado = new();
            Console.WriteLine("Cadastro de chamados");
            int escolha = Menu.MenuChamado();

            while (escolha != 5)
            {
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        novoChamado.RegistraChamado();
                        MensagemSucesso.Mensagem("Chamado Registrado com sucesso!", ConsoleColor.Green);

                        escolha = Menu.MenuChamado();
                        break;

                    case 2:
                        Console.Clear();
                        novoChamado.ExibeChamados();

                        escolha = Menu.MenuChamado();
                        break;

                    case 3:
                        Console.Clear();
                        novoChamado.ExibeChamados();
                        Console.WriteLine("Por favor, informe o ID do chamado a ser EXCLUIDO");
                        int idExcluir = Convert.ToInt32(Console.ReadLine());
                        novoChamado.ExcluiChamado(idExcluir);
                        MensagemSucesso.Mensagem("Chamado Excluido com sucesso!", ConsoleColor.Red);

                        escolha = Menu.MenuChamado();
                        break;

                    case 4:
                        Console.Clear();
                        novoChamado.ExibeChamados();
                        Console.WriteLine("Por favor, informe o ID do chamado a ser EDITADO");
                        int idEditar = Convert.ToInt32(Console.ReadLine());
                        novoChamado.EditaChamado(idEditar);
                        MensagemSucesso.Mensagem("Chamado alterado com sucesso!", ConsoleColor.Yellow);

                        escolha = Menu.MenuChamado();
                        break;
                }
            }

            Console.Clear();
            MenuPricipal();
        }

        private static void Equipamentos()
        {
            Lista novaLista = new();
            Console.WriteLine("Cadastro de Equipamentos!");

            int escolha = Menu.MenuEquipamento();

            while (escolha != 5)
            {
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        novaLista.registraProduto();
                        MensagemSucesso.Mensagem("Equipamento Cadastrado com sucesso!", ConsoleColor.Green);

                        escolha = Menu.MenuEquipamento();
                        break;

                    case 2:
                        Console.Clear();
                        novaLista.ExibeProdutos();

                        escolha = Menu.MenuEquipamento();
                        break;

                    case 3:
                        Console.Clear();
                        novaLista.ExibeProdutos();
                        Console.WriteLine("Informe o ID do produto a ser removido");
                        int id = Convert.ToInt32(Console.ReadLine());
                        novaLista.DeletaProduto(id);
                        MensagemSucesso.Mensagem("Equipamento Removido com sucesso!", ConsoleColor.Red);

                        escolha = Menu.MenuEquipamento();
                        break;

                    case 4:
                        Console.Clear();
                        novaLista.ExibeProdutos();
                        Console.WriteLine("Informe o ID do produto a ser editado");
                        id = Convert.ToInt32(Console.ReadLine());
                        novaLista.EditaProduto(id);
                        MensagemSucesso.Mensagem("Alterações Efetuadas com sucesso!", ConsoleColor.Yellow);

                        escolha = Menu.MenuEquipamento();
                        break;


                }
            }
            Console.Clear();
            MenuPricipal();
        }


    }

}