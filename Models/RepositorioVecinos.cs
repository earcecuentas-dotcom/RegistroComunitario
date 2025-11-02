using System.Collections.Generic;

namespace RegistroComunitario.Models
{
	public static class RepositorioVecinos
	{
		private static List<Vecino> listaVecinos = new List<Vecino>();

		public static void Agregar(Vecino vecino)
		{
			listaVecinos.Add(vecino);
		}

		public static List<Vecino> ObtenerTodos()
		{
			return listaVecinos;
		}
	}
}