using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace MobilePratica2
{
public partial class MainPage : ContentPage
{
public MainPage()
{
InitializeComponent();
btnCalcular.Clicked += Calcular;
}
private void Calcular(object sender, EventArgs e)
{
double a, b, c, x1, x2, delta;
a = Convert.ToDouble(txtA.Text);
b = Convert.ToDouble(txtB.Text);
c = Convert.ToDouble(txtC.Text);
delta = (b * b) - (4 * a * c);
if (delta > 0)
{
x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);
DisplayAlert("Mensagem", "X1: " + x1.ToString() + "\nX2: " + x2.ToString(), "OK");
}
else if (delta == 0)
{
x1 = (-b + Math.Sqrt(delta)) / (2 * a);
DisplayAlert("Mensagem", "X1: " + x1.ToString() + "\nX2: Inexistente", "OK");
}
else
{
DisplayAlert("Mensagem", "Resultado: Sem Raízes Reais", "OK");
}
}
}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
x:Class="MobilePratica2.MainPage">
<StackLayout BackgroundColor="White">
<Frame BackgroundColor="DarkSlateGray"/>
<StackLayout HorizontalOptions="Center">
<Label TextColor="Black" Text="Valor A:"/>
<Entry x:Name="txtA"/>
<Label TextColor="Black" Text="Valor B:"/>
<Entry x:Name="txtB"/>
<Label TextColor="Black" Text="Valor C:"/>
<Entry x:Name="txtC"/>
<Button x:Name="btnCalcular" BackgroundColor="DarkSlateGray" TextColor="Black"
Text="Calcular" Clicked="Calcular"/>
</StackLayout>
</StackLayout>
</ContentPage>
