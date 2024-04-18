namespace GestaoEquipamentos.ConsoleApp
{
    public class Lista
    {
        Equipamento[] listaProdutos = new Equipamento[20];
        Contador produtoContador = new();


        public void registraProduto()
        {
            Equipamento novoEquipamento = new();

            Console.WriteLine("Insira o NOME do produto");
            novoEquipamento.nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o VALOR do produto");
            novoEquipamento.preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o NUMERO DE SERIE do produto");
            novoEquipamento.numeroSerie = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira a DATA DE FABRICACAO do produto");
            novoEquipamento.dataFabricacao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o FABRICANTE do produto ");
            novoEquipamento.fabricante = Convert.ToString(Console.ReadLine());

            novoEquipamento.id = produtoContador.contadorValor;

            listaProdutos[produtoContador.contadorValor] = novoEquipamento;
            produtoContador.Incrementa();


        }

        public void ExibeProdutos()
        {
            Console.WriteLine("ID |  NOME  |  PRECO   |   FABRICACAO |  FABRICANTE");

            for (int i = 0; i < listaProdutos.Length; i++)
            {
                if (listaProdutos[i] != null)
                    Console.WriteLine(listaProdutos[i].id +
                    "   " + listaProdutos[i].nome +
                    "     " + listaProdutos[i].preco +
                    "         " + listaProdutos[i].dataFabricacao +
                    "        " + listaProdutos[i].fabricante);
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
            Equipamento novoEquipamento = new();
            Console.WriteLine("Insira o NOME do produto");
            novoEquipamento.nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o VALOR do produto");
            novoEquipamento.preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o NUMERO DE SERIE do produto");
            novoEquipamento.numeroSerie = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira a DATA DE FABRICACAO do produto");
            novoEquipamento.dataFabricacao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o FABRICANTE do produto ");
            novoEquipamento.fabricante = Convert.ToString(Console.ReadLine());

            listaProdutos.SetValue(novoEquipamento, id);
        }
    }
}
