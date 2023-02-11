using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
	[Serializable()]
	public class Fornecedor
	{
		private String nome;
		private String endereço;
		private String Nº_fax;
		private String Nº_id_fiscal;
		private String mat_prima;


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

		public String Nºfax
		{
			get { return Nº_fax; }
			set { Nº_fax = value; }
		}

		public String Nºid_fiscal
		{
			get { return Nº_id_fiscal; }
			set { Nº_id_fiscal = value; }
		}

		public String Mat_Prima {
			get { return mat_prima; }
			set { mat_prima = value; }
		}

		public override String ToString()
		{
			return nome;
		}

	}
}
