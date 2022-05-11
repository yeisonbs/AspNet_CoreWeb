
namespace AspNet_CoreWeb.Models;
    public abstract class ObjetoEscuelaBase
    {
        public string? UniqueID { get; set; }
        public string? Nombre { get; set; }

        public ObjetoEscuelaBase()
        {

        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueID}";
        }
    }



