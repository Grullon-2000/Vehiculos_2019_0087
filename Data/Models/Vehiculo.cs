using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vehiculos_2019_0087.Data.Models;


namespace Vehiculos_2019_0087.Data.Models
{
    public class Vehiculos
    {
    
    public int VehiculosId { get; set; }
    public string Marca { get; set; } = null!;
    public string Modelo { get; set; } = null!;
    public string Anio { get; set; } = null!;
    public string Color { get; set; } = null!;
    }


}
