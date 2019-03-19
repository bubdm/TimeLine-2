﻿using System;
using System.Collections;
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

namespace TimeLineControl
{
	/// <summary>
	/// Interaction logic for TimeLine.xaml
	/// </summary>
	public partial class TimeLine : UserControl
	{
		public TimeLine()
		{
			InitializeComponent();
		}

		public IEnumerable ItemsSource { get => lbTimeEntries.ItemsSource; set => lbTimeEntries.ItemsSource = value; }
	}
}