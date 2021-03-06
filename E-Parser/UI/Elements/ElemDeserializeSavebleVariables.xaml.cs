﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using E_Parser.Logic.ElementLogic;

namespace E_Parser.UI.Elements
{
    /// <summary>
    /// Interaction logic for ElemDeserializeSavebleVariables.xaml
    /// </summary>
    public partial class ElemDeserializeSavebleVariables : ElemBase
    {
        public ElemDeserializeSavebleVariables()
        {}
        public ElemDeserializeSavebleVariables(TaskSession ts)
        {
            InitializeComponent();
            Task = new TSDeserializeSavebleVariables(ts);
        }
        public ElemDeserializeSavebleVariables(TSBase ts)
        {
            InitializeComponent();
            Task = ts;
        }

        private void tbxUrl_TextChanged(object sender, TextChangedEventArgs e)
        {       
            (Task as TSDeserializeSavebleVariables).DeserializeNow();
        }

    }
}
