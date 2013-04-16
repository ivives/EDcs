using System;
using Gtk;

using Serpis.EDcs;

public partial class MainWindow: Gtk.Window
{	
	private Bingo bingo = new Bingo();
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build();
		//bingo.NumeroInicialBolas = 43;
		bingo.Iniciar();
		
//		uint rowCount = (uint) bingo.NumeroInicialBolas / 10; 
		
//		for (uint row = 0; row < rowCount; row++){
//			for (uint col = 0; col <= 9; col++) {
//				Button button = new Button();
//				button.Label = "" + (col + 1 + (row * 10));
//				button.Visible = true;
//				//table.Add (button);
//				table.Attach (button, col, 1 + col, row, row + 1, 
//		              AttachOptions.Fill ,
//		              AttachOptions.Fill,
//		              1,1);
//		}	
		
		for (uint index = 0; index < bingo.NumeroInicialBolas; index ++){
			Button button = new Button();
			button.Label = "" + (index + 1);
			button.Visible = true;
			uint row = index / 10;
			uint col = index % 10; //mod
			table.Attach (button, col, 1 + col, row, row + 1, 
		              AttachOptions.Fill ,
		              AttachOptions.Fill,
		              1,1);
			
	}
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonNextClicked (object sender, System.EventArgs e)
	{
		int bola = bingo.ExtraeBola();
		
		Console.WriteLine("bola={0}", bola);
		
		//string path = "C:\\ProgramFiles\\Serpis\\Format.exe";
		//string path = @"C:\ProgramFiles\Serpis\Format.exe";
		// estas formas no son correctas porque no sirven para todos los S.O.
		// ver clase System.IO.Path
		
		//Process.Start("nautilus", "--browser");
		
		Bingo.Cantar(bola);
	}
}
