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

    public class Produto
    {
        public int id;
        public string nome;
        public decimal preco;
        public string numeroSerie;
        public string dataFabricacao;
        public string fabricante;
    }

    public class Lista
    {
        Produto[] listaProdutos = new Produto[20];

        public int contaProduto;

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

            novoProduto.id = contaProduto;

            listaProdutos[contaProduto] = novoProduto;
            contaProduto++;
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
