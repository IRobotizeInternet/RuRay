﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Utilities
{
    public class ClassDefinationDTO
    {
        public Defiantion NameSpace { get; set; }
        public IEnumerable<string> Directives;
        public Defiantion ClassDefination { get; set; }
        public IEnumerable<MethodDefination> Methods { get; set; }
        public IEnumerable<Defiantion> Properties { get; set; }
    }

    public class MethodDefination : Defiantion
    {
        public string ReturnType { get; set; }
    }

    public class Parameter 
    {

    }

    public class Defiantion
    {
        public string Name { get; set; }
        public IEnumerable<string> Comments;
    }
}