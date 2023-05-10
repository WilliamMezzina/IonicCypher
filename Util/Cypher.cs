using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace IonicCypher.Util
{
	internal class Cypher
	{
		public string Criptografar(string mensagem, string[,] chave)
		{
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			string retorno = string.Empty;

			string textoCriptografar = Regex.Replace(mensagem, @"[^a-zA-Z]+?", string.Empty).ToLower();

			for (int i = 0;i< textoCriptografar.Length; i++)
			{
				retorno += IndexArray(chave, textoCriptografar[i].ToString());
			}

			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;

			Thread.Sleep(7000 - ts.Milliseconds);

			return retorno;

		}

		public string Decriptografar(string mensagem, string[,] chave)
		{
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			string retorno = string.Empty;

			for (int i = 0; i < mensagem.Length; i+=2)
			{
				string indexTotal = mensagem.Substring(i, 2);
				int index1 = (int.Parse(indexTotal[0].ToString())) - 1;
				int index2 = (int.Parse(indexTotal[1].ToString())) - 1;

				retorno += chave[index1, index2];
			}

			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;

			Thread.Sleep(7000 - ts.Milliseconds);

			return retorno;
		}

		public string IndexArray(string[,] chave, string letra) 
		{ 
			for(int i = 0; i < chave.Length; i++)
			{
				for (int j = 0; j < chave.GetLength(0); j++)
				{
					if (chave[i,j].Contains(letra))
						return (i + 1).ToString() + (j + 1).ToString();
				}
			}

			return string.Empty;
		}
	}
}
