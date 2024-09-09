using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;

namespace AvaloniaApplication1.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    IList<EmployeeInfo> employees;

    public MainWindowViewModel()
    {
        Employees = new List<EmployeeInfo>();
    }

}

public class EmployeeInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HiredAt { get; set; }
    public int Experience { get; set; }
    public string Position { get; set; }
    public bool Married { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
}
