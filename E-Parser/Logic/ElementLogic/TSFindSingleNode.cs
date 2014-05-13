﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Awesomium.Core;
using E_Parser.UI.Elements;
using HtmlAgilityPack;

namespace E_Parser.Logic.ElementLogic
{
    [Serializable]
    public class TSFindSingleNode : TSBase
    {
        public TSFindSingleNode(TaskSession ts): base(ts)
        {
            
        }


        public override string GetName
        {
            get { return "Find Single Node"; }
        }

        protected override object _mainTaskMethod(object[] args)
        {
            if (args[0] is HtmlNode)
                return (args[0] as HtmlNode).SelectSingleNode(DirectStringInput);
            return Session.Client.HAP.GetSingleElement(DirectStringInput);

        }

        protected override void StaticTypes(TaskSession ts)
        {
            InputTypes = new List<ParameterTypes>() { ParameterTypes.Any };
            OutputType = ParameterTypes.Node;
            ElemType = typeof(ElemFindSingleNode);
        }
    }
}
