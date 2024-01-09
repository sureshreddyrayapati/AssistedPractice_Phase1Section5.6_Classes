﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._6_Classes
{
    public class Subject
    {
        public List<Subject> Subjects { get; internal set; }    
        private string name;
        private string shortName;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }
    }
}