//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3
{
    using System;
    using System.Collections.Generic;
    
    public partial class utilisation
    {
        public int id { get; set; }
        public Nullable<int> l_utilisation_id { get; set; }
        public Nullable<int> chauffeur_id { get; set; }
        public Nullable<int> la_date_id { get; set; }
        public Nullable<int> le_bus_id { get; set; }
    
        public virtual bus bus { get; set; }
        public virtual chauffeur chauffeur { get; set; }
        public virtual date date { get; set; }
        public virtual ligne ligne { get; set; }
    }
}
