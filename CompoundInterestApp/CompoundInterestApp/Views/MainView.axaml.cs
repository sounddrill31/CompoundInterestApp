using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CompoundInterestApp.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        //throw new System.NotImplementedException();
        int p, r, d,si,ci;
        Debug.Assert(PrincipalAmt.Text != null, "PrincipalAmt.Text != null");
        p = Int32.Parse(PrincipalAmt.Text);
        
        r = Int32.Parse(Rate.Text);
        
        d = int.Parse(Duration.Text);

        si = (p * r * d) / 100;
        
        SimpleRes.Text = si.ToString();

        // todo: fix Compound Interest Logic
        ci = p * (1 + (r / 100)) ^ (d - 1); // A = P * (1 + (r/n))^(n * t)
        Res.Text = ci.ToString();
    }

    private void Button_OnClick_Clear(object? sender, RoutedEventArgs e)
    {
        //throw new System.NotImplementedException();
        PrincipalAmt.Text = String.Empty;
        Rate.Text = String.Empty;
        Duration.Text = String.Empty;
        Res.Text = String.Empty;
        SimpleRes.Text = String.Empty;
    }

    private void Button_OnClick_Exit(object? sender, RoutedEventArgs e)
    {
        //throw new System.NotImplementedException();
        System.Environment.Exit(0);
    }
}