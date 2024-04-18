namespace GestaoEquipamentos.ConsoleApp
{
    public class ListaChamado
    {
        Chamado[] salvaChamados = new Chamado[30];
        Contador chamadoContador = new Contador();


        public void RegistraChamado()
        {
            Chamado novoChamado = new();

            Console.WriteLine("Informe o TITULO do chamado");
            novoChamado.tituloChamdo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("DESCREVA a situacao com seu equipamento");
            novoChamado.descricaoChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Infome o ID de registro do produto");
            novoChamado.idEquipamento = Convert.ToInt32(Console.ReadLine());

            novoChamado.dataAbertura = DateTime.Now.ToString();
            novoChamado.idChamado = chamadoContador.contadorValor;

            salvaChamados[chamadoContador.contadorValor] = novoChamado;

            chamadoContador.Incrementa();
        }


        public void ExibeChamados()
        {
            Console.WriteLine("ID CHAMADO |TITULO |  DESCRICAO  |  ABERTO DESDE   |   ID DO PRODUTO  | ");

            for (int i = 0; i < salvaChamados.Length; i++)
            {
                if (salvaChamados[i] != null)
                    Console.WriteLine(salvaChamados[i].idChamado +
                    "     " + salvaChamados[i].tituloChamdo +
                    "   " + salvaChamados[i].descricaoChamado +
                    "     " + salvaChamados[i].dataAbertura +
                     "      " + salvaChamados[i].idEquipamento +
                     "      ");
            }
        }

        public void ExcluiChamado(int idChamado)
        {
            var lista = salvaChamados.ToList();

            lista.RemoveAt(idChamado);

            salvaChamados = lista.ToArray();
        }

        public void EditaChamado(int idChamado)
        {
            Chamado novoChamado = new();
            Console.WriteLine("Informe o TITULO do chamado");
            novoChamado.tituloChamdo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("DESCREVA a situacao com seu equipamento");
            novoChamado.descricaoChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Infome o ID de registro do produto");
            novoChamado.idEquipamento = Convert.ToInt32(Console.ReadLine());

            novoChamado.dataAbertura = salvaChamados[idChamado].dataAbertura;

            salvaChamados.SetValue(novoChamado, idChamado);

        }

    }

}
