﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Parser.UI.Elements;

namespace E_Parser.Logic.ElementLogic
{
    [Serializable]
    public class TSWhile : TSBase
    {
        public TSWhile(TaskSession ts) : base(ts)
        {
            ElemType = typeof(ElemWhile);
        }

        public override string GetName
        {
            get { return "While Loop"; }
        }

        protected override object _mainTaskMethod(object[] args)
        {
            return null;
        }
    }
}