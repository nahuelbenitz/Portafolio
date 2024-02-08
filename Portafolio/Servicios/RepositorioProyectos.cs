using Portafolio.interfaces;
using Portafolio.Models;

namespace Portafolio.Servicios
{
	public class RepositorioProyectos : IRepositorioProyectos
	{
		public List<ProyectoDTO> obtenerProyectos()
		{
			return new List<ProyectoDTO>()
			{
				new ProyectoDTO
			{
				Titulo = "Amazon",
				Descripcion = "Realice un E-Commerce en ASP.NET Core que auen sigue en produccion",
				Link = "https://amazon.com",
				ImagenURL = "/images/amazon.png"
			},
				new ProyectoDTO
			{
				Titulo = "Facebook",
				Descripcion = "Red social hecha en mi tiempo libre",
				Link = "https://facebook.com",
				ImagenURL = "/images/facebook.png"
			},
				new ProyectoDTO
			{
				Titulo = "Mercado Libre",
				Descripcion = "Copia de amazon pero readaptada a latinoamerica",
				Link = "https://mercadolibre.com",
				ImagenURL = "/images/mercadolibre.png"
			},
				new ProyectoDTO
			{
				Titulo = "Reddit",
				Descripcion = "Blog de temas variados en los cuales los usuarios interactuan",
				Link = "https://reddit.com",
				ImagenURL = "/images/reddit.png"
			}
			};
		}
	}
}
