using Tarea1;

public class SuperPoder 
{
	public SuperPoder()
	{
		public string Nombre { get; set; }

	public string IdentidadSecreta { get; set; }

   public string Ciudad { get; set; }

	public bool PuedeVolar { get; set; }

	SuperPoder superPoder;

	public superPoder()
	{
		superPoder = new SuperPoder();
	}


	public void Imprimir()
	{
		Console.WriteLine($"Nombre:   {Nombre}")
			Console.WriteLine($"IdentidadSecreta:    {IdentidadSecreta}")
			Console.WriteLine($"Ciudad:    {Ciudad}")
			Console.WriteLine($"PuedeVolar:     {PuedeVolar}")
			Console.WriteLine($"SuperPoder:    {superPoder.Nobre}")
			Console.WriteLine($"Descripcion:   {superPoder.Descripcion}")
			Console.WriteLine($"Nivel:     {superPoder.Nivel}")
			Console.WriteLine(); 
	}
}

