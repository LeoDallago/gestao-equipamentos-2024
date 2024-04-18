namespace GestaoEquipamentos.ConsoleApp
{
    public static class MensagemSucesso
    {
        public static void Mensagem(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}