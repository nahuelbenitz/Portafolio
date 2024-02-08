using Portafolio.Models;

namespace Portafolio.interfaces
{
	public interface IServicioEmail
	{
		Task Enviar(ContactoViewModel contacto);
	}
}
