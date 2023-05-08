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

namespace Season3_Day2_2.UI.Units
{
    public class StudyListBoxItem : ListBoxItem
    {
        static StudyListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StudyListBoxItem), new FrameworkPropertyMetadata(typeof(StudyListBoxItem)));
        }
    }
}
