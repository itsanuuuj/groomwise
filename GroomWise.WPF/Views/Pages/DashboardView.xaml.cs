// GroomWise
// Copyright (C) 2023  John Russell C. Camo (@russkyc)
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY

using GroomWise.Infrastructure.Navigation.Interfaces;
using GroomWise.Views.Controls;
using System.Windows;

namespace GroomWise.Views.Pages;

public partial class DashboardView : IPage
{
    public DashboardView()
    {
        InitializeComponent();
    }

    private void CalendarControl_OnSelectedDateChanged(object sender, RoutedEventArgs e)
    {
        // Handle the selected date change event
        var calendarControl = sender as CalendarControl;
        if (calendarControl != null)
        {
            var selectedDate = calendarControl.SelectedDate;
            // Do something with the selected date
        }
    }
}
