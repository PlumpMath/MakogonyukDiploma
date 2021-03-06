﻿using System;
using System.Windows;
using System.Windows.Controls;
using E_Parser.Logic.ElementLogic;

namespace E_Parser.UI.Elements
{

    public partial class ElemParameterTap : ElemBase
    {
        public NodeTap tNodeTap {
            get
            {
                return (Task as TSParameterTap).tNodeTap;
            }
            set
            {
                (Task as TSParameterTap).tNodeTap = value;
            } 
        }
        public StringTap tStringTap
        {
            get { return (Task as TSParameterTap).tStringTap; }
            set { (Task as TSParameterTap).tStringTap = value; }
        }


        public ElemParameterTap(TaskSession CurrentSession)
        {
            InitializeComponent();
            Task = new TSParameterTap(CurrentSession);
        }

        public override void AfterElementAddition()
        {
            SwitchOutputType();
        }

        public void SwitchOutputType()
        {
            switch (Task.PreviousTask.OutputType)
            {
                case ParameterTypes.None:
                    break;
                case ParameterTypes.Any:
                    break;
                case ParameterTypes.String:
                    UIChanger(cmbbxStringTap);
                    break;
                case ParameterTypes.Double:
                    break;
                case ParameterTypes.NodeList:
                    break;
                case ParameterTypes.Node:
                    UIChanger(cmbbxNodeTap);
                    break;
                case ParameterTypes.Boolean:
                    break;
                case ParameterTypes.PassThrough:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            
        }

        public void UIChanger(ComboBox nodeTap)
        {
            foreach (ComboBox cmb in cmbbxGrid.Children)
            {
                if (cmb != nodeTap)
                {
                    cmb.Visibility = Visibility.Hidden;
                }
                else
                {
                    cmb.Visibility = Visibility.Visible;
                }
            }

        }
        public ElemParameterTap()
        {
            InitializeComponent();
        }
        
        public ElemParameterTap(TSBase ts)
        {
            InitializeComponent();
            Task = ts;
        }

        private void CmbbxNodeTap_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task.OutputType = (Task as TSParameterTap).DetermineType(Task.PreviousTask.OutputType);
        }
    }
}
