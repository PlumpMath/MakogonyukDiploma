﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Parser.Logic.ElementLogic
{
    class TSStart : BaseTaskSequence
    {
        public TSStart(TaskSession ts) : base(ts)
        {
            
        }

        protected override object _mainTaskMethod(object[] args)
        {
            Console.WriteLine("Do nothing");
            return null;
        }
    }
}
