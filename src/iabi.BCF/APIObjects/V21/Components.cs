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
    using generated;
    
    
    public class Components
    {
        
        private ComponentList _selection;
        
        private object _coloring;
        
        private Visibility _visibility;
        
        public virtual ComponentList Selection
        {
            get
            {
                return _selection;
            }
            set
            {
                _selection = value;
            }
        }
        
        public virtual object Coloring
        {
            get
            {
                return _coloring;
            }
            set
            {
                _coloring = value;
            }
        }
        
        public virtual Visibility Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                _visibility = value;
            }
        }
    }
}
