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
    using System.Collections.Generic;
    
    
    public class Topic_event_GET
    {
        
        private string _topic_guid;
        
        private string _date;
        
        private string _author;
        
        private List<Event_action> _actions;
        
        [Required()]
        public virtual string Topic_guid
        {
            get
            {
                return _topic_guid;
            }
            set
            {
                _topic_guid = value;
            }
        }
        
        [Required()]
        public virtual string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        
        [Required()]
        public virtual string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        
        [MinLength(1)]
        public virtual List<Event_action> Actions
        {
            get
            {
                return _actions;
            }
            set
            {
                _actions = value;
            }
        }
    }
}
