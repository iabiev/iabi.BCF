//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iabi.BCF.APIObjects.V21
{
    // Schema for Versions
    public class Versions_GET
    {
        
        private List<Version> _versions;
        
        [Required()]
        public virtual List<Version> Versions
        {
            get
            {
                return _versions;
            }
            set
            {
                _versions = value;
            }
        }
    }
}