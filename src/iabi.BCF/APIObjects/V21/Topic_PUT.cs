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
    using System.ComponentModel.DataAnnotations;
    
    
    // Schema for topic PUT, BCF REST API.
    public class Topic_PUT
    {
        
        private object _topic_type;
        
        private object _topic_status;
        
        private object _reference_links;
        
        private string _title;
        
        private object _priority;
        
        private object _index;
        
        private object _labels;
        
        private object _assigned_to;
        
        private object _stage;
        
        private object _description;
        
        private Bim_snippet _bim_snippet;
        
        private object _due_date;
        
        public virtual object Topic_type
        {
            get
            {
                return _topic_type;
            }
            set
            {
                _topic_type = value;
            }
        }
        
        public virtual object Topic_status
        {
            get
            {
                return _topic_status;
            }
            set
            {
                _topic_status = value;
            }
        }
        
        public virtual object Reference_links
        {
            get
            {
                return _reference_links;
            }
            set
            {
                _reference_links = value;
            }
        }
        
        [Required()]
        public virtual string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        
        public virtual object Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }
        
        public virtual object Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }
        
        public virtual object Labels
        {
            get
            {
                return _labels;
            }
            set
            {
                _labels = value;
            }
        }
        
        public virtual object Assigned_to
        {
            get
            {
                return _assigned_to;
            }
            set
            {
                _assigned_to = value;
            }
        }
        
        public virtual object Stage
        {
            get
            {
                return _stage;
            }
            set
            {
                _stage = value;
            }
        }
        
        public virtual object Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        public virtual Bim_snippet Bim_snippet
        {
            get
            {
                return _bim_snippet;
            }
            set
            {
                _bim_snippet = value;
            }
        }
        
        public virtual object Due_date
        {
            get
            {
                return _due_date;
            }
            set
            {
                _due_date = value;
            }
        }
    }
}
