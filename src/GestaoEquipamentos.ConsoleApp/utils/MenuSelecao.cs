namespace GestaoEquipamentos.ConsoleApp
{
    public static class Menu
    {
        public static int MenuEquipamento()
        {
            Console.WriteLine("Por favor escolha a opcao desejada \n" +
             "1- Cadastrar Equipamento \n" +
             "2- Listagem de Equipamentos \n" +
             "3- Remocao de Equipamentos \n" +
             "4- Edicao de Equipamentos \n" +
             "5- Sair");
            int escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }

        public static int MenuChamado()
        {
            Console.WriteLine("Por favor escolha a opcao desejada \n" +
             "1- Cadastrar Chamado \n" +
             "2- Listagem de Chamados \n" +
             "3- Remocao de Chamados \n" +
             "4- Edicao de Chamados \n" +
             "5- Sair");
            int escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
    }

}