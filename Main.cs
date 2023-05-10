using IonicCypher.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IonicCypher
{
	public partial class Main : Form
	{
		private static string[,] cripto = new string[5, 5] {
															{"a","b","c","d","e"},
															{"f","g","h","i/j","k"},
															{"l","m","n","o","p"},
															{"q","r","s","t","u" },
															{"v","w","x","y","z"},
															 };

		public Main()
		{
			InitializeComponent();
		}

		private void btCriptografar_Click(object sender, EventArgs e)
		{
			string criptografar = txtCripto.Text;

			Cypher cypher = new Cypher();
			txtDecripto.Text = cypher.Criptografar(criptografar, cripto);
		}

		private void btDecriptografar_Click(object sender, EventArgs e)
		{
			string decriptografar = txtDecripto.Text;
			Cypher cypher = new Cypher();
			txtCripto.Text = cypher.Decriptografar(decriptografar, cripto);
		}
	}
}
