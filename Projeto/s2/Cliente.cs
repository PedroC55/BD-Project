using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
	[Serializable()]
	public class Cliente
	{
		private String nome;
		private String endereço;
		private String n_cc;
		private String genero;
		private String email;
		private String nome_empresa;
		

		public String Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public String Endereço
		{
			get { return endereço; }
			set { endereço = value; }
		}

		public String Nº_CC
		{
			get { return n_cc; }
			set { n_cc = value; }
		}

		public String Género
		{
			get { return genero; }
			set { genero = value; }
		}

		public String Email
		{
			get { return email; }
			set { email = value; }
		}

		public String Nome_Empresa
		{
			get { return nome_empresa; }
			set { nome_empresa = value; }
		}

		public override String ToString()
		{
			return nome;
		}

	}
}
