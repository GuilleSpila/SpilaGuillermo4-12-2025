using System;

namespace examenProg;

public class Reserva
{
 public int Id { get; set; }
 public int CanchaId { get; set; }
 public Cancha? Cancha { get; set; }
 public int SocioId { get; set; }
 public Socio? Socio { get; set; }
 public DateTime FechaHoraInicio { get; set; }
 public DateTime FechaHoraFin { get; set; }
}
