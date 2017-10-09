using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLib
{
    public class Event
    {
        public List<Event> Children { get; set; }
        public int durationHours;
        public string description;
        private bool iseducation;

        public bool IsEducation
        {
            get
            {
                return this.iseducation;
            }
        }

        public Event(string name, string description, bool iseducation)
        {
            this.iseducation = iseducation;
            if (!this.iseducation)
            { 
                durationHours = 6;
            }
            Children = new List<Event>();
        }
        public int Duration
        {
            get
            {
                // If top level
                if(IsEducation)
                return Children.Sum(child => child.durationHours);
                
                return 0;
            }
        }
    }
}
