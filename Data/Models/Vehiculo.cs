
using System.ComponentModel.DataAnnotations
namespace Models;

public class Vehiculo
{
[Key]
public int vehiculoID { get; set; }
public string Marca { get; set; } = null!;
public string? Modelo { get; set; }                                          
public int Año { get; set; }                                          
public string? Color { get; set; }                                          

}