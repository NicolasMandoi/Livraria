
namespace Livraria
{
	public class Livro
	{
		public string titulo = "";
		public string ISBN = "";
		public int quantidadeEmEstoque = 0;
		
		public Livro (string titulo, string ISBN)
		{
			this.titulo = titulo;
			this.ISBN = ISBN;
		}
	}	
}
