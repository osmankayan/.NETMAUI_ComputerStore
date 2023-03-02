using ComputerStore.Model;

namespace ComputerStore;

public partial class Shop : ContentPage 
{
	
	public Shop()
	{
		InitializeComponent();
		Model1.HDD1_Price = 300;
		Model1.HDD2_Price = 600;
		Model1.SSD1_Price= 500;
		Model1.SSD2_Price= 1000;

		//Model1.i3 = 1500;
		//Model1.i5 = 1700;
		//Model1.i7 = 2000;
		//Model1.i9 = 2500;

		Model1.gb4 = 150;
		Model1.gb8 = 300;
		Model1.gb12 = 450;
		Model1.gb16 = 600;

		Model1.inc17 = 450;
		Model1.inc20 = 900;
		Model1.inc23 = 1350;
        
       


    }

    private void memory_stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        
        if (memory_stepper.Value == 4) Model1.price1 = Model1.gb4;
        if (memory_stepper.Value == 8) Model1.price1 = Model1.gb8;
        if (memory_stepper.Value == 12) Model1.price1 = Model1.gb12;
        if (memory_stepper.Value == 16) Model1.price1 = Model1.gb16;
        memorylabel.Text=memory_stepper.Value.ToString();

        
        int total = Model1.price1+ Model1.price2+Model1.priceproc;
        Model1.lastpagetotal = total;
        totallabel.Text = $"Total: {total}";

    }

   

    private void monitorsize_stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        
        if (monitorsize_stepper.Value == 17) Model1.price2 = Model1.inc17;
        if (monitorsize_stepper.Value == 20) Model1.price2 = Model1.inc20;
        if (monitorsize_stepper.Value == 23) Model1.price2 = Model1.inc23;
        
        monitorsizelabel.Text = monitorsize_stepper.Value.ToString();



        int total = Model1.price1 + Model1.price2 + Model1.priceproc;
        Model1.lastpagetotal= total;
        totallabel.Text = $"Total: {total}";
    }

    private void storage_stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {


        //if (storage_stepper.Value == 500) Model1.price3 = Model1.HDD1_Price;
        //else if (storage_stepper.Value == 1000) Model1.price3 = Model1.HDD2_Price;
        //else Model1.price3 = 0;
        //storagelabel.Text = storage_stepper.Value.ToString();

        //int total = Model1.price1 + Model1.price2;
        //totallabel.Text = $"Total: {total}";


    }
}