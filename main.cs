using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




namespace loja
{
	public class Produto
	{
		public int proID;
		public int proQuant;
		public string proName;
		public float proValue;
		public Produto()
		{ }
	}
	public class Principal
	{
		static void verestoque()
		{
			List<Produto>prod = new List<Produto>();
			StreamWriter escritor = new StreamWriter("batata.txt");
			prod.Add(new Produto());
			prod[0].proName = Console.ReadLine();
			escritor.WriteLine(prod[0].proName);
			prod[0].proName = Console.ReadLine();
			escritor.WriteLine(prod[0].proName);
			escritor.Close();
		}

		static void Main()
		{
			int opcao;
			Console.WriteLine
				("------------------Bem Vindo à loja------------------\n" +
				"Digite o valor correspondente a sua opção de escolha:\n" +
				"(1) Ver o que tem no estoque\n" +
				"(2) Alterar Estoque\n" +
				"(3) Fechar o programa\n");
			opcao = int.Parse(Console.ReadLine());
			switch (opcao)
			{
				case 1:
					verestoque();

					break;
				case 2:

					break;
				case 3:
					Environment.Exit(0);

					break;
			}
			Console.ReadLine();
		}

	}
}