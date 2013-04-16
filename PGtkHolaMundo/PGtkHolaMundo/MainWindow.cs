using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
//		button.Clicked += delegate {
//			labelSaludo.LabelProp = "Hola " + entryNombre.Text;
//		}; 
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonClicked (object sender, System.EventArgs e) {
		labelSaludo.LabelProp =string.Format("Hola {0} ({1})",
		                                     entryNombre.Text, DateTime.Now);
	}
}
