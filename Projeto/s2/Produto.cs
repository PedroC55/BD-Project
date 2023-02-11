using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
	[Serializable()]
	public class Produto
    {
		private String codigo;
		private String nome;
		private String preco;
		private String taxa_iva;
		private String n_stock;
		private String nome_empresa;
		private String tipo_categoria;

		public String Código
		{
			get { return codigo; }
			set { codigo = value; }
		}

		public String Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public String Preço
		{
			get { return preco; }
			set { preco = value; }
		}

		public String Taxa_de_IVA { 
			get { return taxa_iva; }
			set { taxa_iva = value; }
		}

		public String Nº_em_Stock
		{
			get { return n_stock; }
			set { n_stock = value; }
		}

		public String Nome_Empresa
		{
			get { return nome_empresa; }
			set { nome_empresa = value; }
		}

		public String Tipo_Categoria
		{
			get { return tipo_categoria; }
			set { tipo_categoria = value; }
		}

		public override String ToString()
		{
			return codigo + "    " + nome;
		}
	}
}
