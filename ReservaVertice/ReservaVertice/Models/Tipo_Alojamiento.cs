//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservaVertice.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Alojamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Alojamiento()
        {
            this.alojamiento_has_tipo_alojamiento = new HashSet<alojamiento_has_tipo_alojamiento>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Resumen_ReservaId { get; set; }
        public string ll { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alojamiento_has_tipo_alojamiento> alojamiento_has_tipo_alojamiento { get; set; }
    }
}