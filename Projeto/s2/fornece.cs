using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
	[Serializable()]
	public class fornece
	{
		private String nome_forn;
		private String nome_empr;


		public String Nome_Forn
		{
			get { return nome_forn; }
			set { nome_forn = value; }
		}

		public String Nome_Emp
		{
			get { return nome_empr; }
			set { nome_empr = value; }
		}

	
		public override String ToString()
		{
			return nome_forn;
		}

	}
}
