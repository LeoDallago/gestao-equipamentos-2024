namespace GestaoEquipamentos.ConsoleApp
{
    public class Lista
    {
        Produto[] listaProdutos = new Produto[20];


        public void registraProduto()
        {
            Produto novoProduto = new();
            Console.WriteLine("Insira o NOME do produto");
            novoProduto.nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o VALOR do produto");
            novoProduto.preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o NUMERO DE SERIE do produto");
            novoProduto.numeroSerie = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira a DATA DE FABRICACAO do produto");
            novoProduto.dataFabricacao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o FABRICANTE do produto ");
            novoProduto.fabricante = Convert.ToString(Console.ReadLine());

            novoProduto.id = Contador.contadorValor;

            listaProdutos[Contador.contadorValor] = novoProduto;
            Contador.Incrementa();
        }

        public void ExibeProdutos()
        {
            Console.WriteLine("ID |  NOME  |  PRECO   |   FABRICACAO |  FABRICANTE");

            for (int i = 0; i < listaProdutos.Length; i++)
            {
                if (listaProdutos[i] != null)
                    Console.WriteLine(listaProdutos[i].id + "   " + listaProdutos[i].nome + "     " + listaProdutos[i].preco + "         " + listaProdutos[i].dataFabricacao + "        " + listaProdutos[i].fabricante);
            }
        }

        public void DeletaProduto(int id)
        {
            var lista = listaProdutos.ToList();

            lista.RemoveAt(id);

            listaProdutos = lista.ToArray();
        }

        public void EditaProduto(int id)
        {
            Produto novoProduto = new();
            Console.WriteLine("Insira o NOME do produto");
            novoProduto.nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o VALOR do produto");
            novoProduto.preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o NUMERO DE SERIE do produto");
            novoProduto.numeroSerie = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira a DATA DE FABRICACAO do produto");
            novoProduto.dataFabricacao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o FABRICANTE do produto ");
            novoProduto.fabricante = Convert.ToString(Console.ReadLine());

            listaProdutos.SetValue(novoProduto, id);
        }
    }
}
