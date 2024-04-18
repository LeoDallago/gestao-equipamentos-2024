namespace GestaoEquipamentos.ConsoleApp
{
    public static class MensagemSucesso
    {
        public static void Mensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}