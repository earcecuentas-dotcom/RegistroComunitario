using System.ComponentModel.DataAnnotations;

namespace RegistroComunitario.Models
{
	public class Vecino
	{
		[Required(ErrorMessage = "La identificación es obligatoria")]
		public string Identificacion { get; set; }

		[Required(ErrorMessage = "El nombre es obligatorio")]
		[MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "Los apellidos son obligatorios")]
		public string Apellidos { get; set; }

		[Phone(ErrorMessage = "El teléfono no tiene formato válido")]
		public string Telefono { get; set; }

		[Required(ErrorMessage = "El correo es obligatorio")]
		[EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
		public string Correo { get; set; }

		[Required(ErrorMessage = "El género es obligatorio")]
		public string Genero { get; set; }

		[Range(1, 120, ErrorMessage = "La edad debe estar entre 1 y 120 años")]
		public int Edad { get; set; }
	}
}