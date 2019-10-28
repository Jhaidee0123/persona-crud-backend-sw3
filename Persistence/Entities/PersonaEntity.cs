namespace Persistence.Entities
{
    public class PersonaEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public int TipoDocumentoIdentidadId { get; set; }
        public TipoDocumentoIdentidadEntity TipoDocumentoIdentidad { get; set; }
    }
}
