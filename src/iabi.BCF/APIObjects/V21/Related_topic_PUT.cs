//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace generated
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    
    // Schema for related topic PUT, BCF REST API.
    public class Related_topic_PUT
    {
        
        private string _related_topic_guid;
        
        [Required()]
        public virtual string Related_topic_guid
        {
            get
            {
                return _related_topic_guid;
            }
            set
            {
                _related_topic_guid = value;
            }
        }
    }
}
