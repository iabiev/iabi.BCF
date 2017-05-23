//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace iabi.BCF.APIObjects.V21
{
    // Schema for topic POST, BCF REST API.
    public class Topic_POST
    {
        
        private string _topic_type;
        
        private string _topic_status;
        
        private List<string> _reference_links;
        
        private string _title;
        
        private string _priority;
        
        private int _index;
        
        private List<string> _labels;
        
        private string _assigned_to;
        
        private string _stage;
        
        private string _description;
        
        private Bim_snippet _bim_snippet;
        
        private DateTime _due_date;
        
        public virtual string Topic_type
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
        
        public virtual string Topic_status
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
        
        public virtual List<string> Reference_links
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
        
        public virtual string Priority
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
        
        public virtual int Index
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
        
        public virtual List<string> Labels
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
        
        public virtual string Assigned_to
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
        
        public virtual string Stage
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
        
        public virtual string Description
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
        
        public virtual DateTime Due_date
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
