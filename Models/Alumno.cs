
using System;
namespace AspNet_CoreWeb.Models;

  public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }

