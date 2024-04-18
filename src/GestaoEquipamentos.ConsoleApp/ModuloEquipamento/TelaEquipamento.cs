namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    internal class TelaEquipamento
    {

        public static void Equipamentos()
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
            Program.MenuPricipal();
        }
    }
}