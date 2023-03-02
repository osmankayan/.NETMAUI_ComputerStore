using ComputerStore.Model;

namespace ComputerStore;

public  partial class Store : ContentPage
{
	public Store()
	{
		InitializeComponent();
       
    }

    private void i3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Model1.priceproc = 1500;
    }

    private void i5_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Model1.priceproc = 1700;
    }

    private void i7_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Model1.priceproc = 2000;
    }

    private void i9_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Model1.priceproc = 2500;
    }
}