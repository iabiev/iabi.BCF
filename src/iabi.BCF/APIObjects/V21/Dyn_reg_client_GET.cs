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
    
    
    // Dynamic Client Meta Data
    public class Dyn_reg_client_GET
    {
        
        private string _client_id;
        
        private string _client_secret;
        
        [Required()]
        public virtual string Client_id
        {
            get
            {
                return _client_id;
            }
            set
            {
                _client_id = value;
            }
        }
        
        [Required()]
        public virtual string Client_secret
        {
            get
            {
                return _client_secret;
            }
            set
            {
                _client_secret = value;
            }
        }
    }
}
