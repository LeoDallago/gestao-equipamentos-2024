namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    internal class TelaChamado
    {

        public static void Chamados()
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
            Program.MenuPricipal();
        }
    }
}