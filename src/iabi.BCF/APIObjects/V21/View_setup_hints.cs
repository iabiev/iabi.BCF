//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iabi.BCF.APIObjects.V21
{
    public class View_setup_hints
    {
        
        private bool _spaces_visible;
        
        private bool _space_boundaries_visible;
        
        private bool _openings_visible;
        
        public View_setup_hints()
        {
            _spaces_visible = false;
            _space_boundaries_visible = false;
            _openings_visible = false;
        }
        
        public virtual bool Spaces_visible
        {
            get
            {
                return _spaces_visible;
            }
            set
            {
                _spaces_visible = value;
            }
        }
        
        public virtual bool Space_boundaries_visible
        {
            get
            {
                return _space_boundaries_visible;
            }
            set
            {
                _space_boundaries_visible = value;
            }
        }
        
        public virtual bool Openings_visible
        {
            get
            {
                return _openings_visible;
            }
            set
            {
                _openings_visible = value;
            }
        }
    }
}
