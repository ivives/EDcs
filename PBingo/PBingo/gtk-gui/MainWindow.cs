
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Button buttonNext;
	private global::Gtk.Table table;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonNext = new global::Gtk.Button ();
		this.buttonNext.CanFocus = true;
		this.buttonNext.Name = "buttonNext";
		this.buttonNext.UseUnderline = true;
		this.buttonNext.Label = global::Mono.Unix.Catalog.GetString ("Añadir");
		this.hbox3.Add (this.buttonNext);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonNext]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.table = new global::Gtk.Table (((uint)(3)), ((uint)(4)), false);
		this.table.Name = "table";
		this.table.RowSpacing = ((uint)(6));
		this.table.ColumnSpacing = ((uint)(6));
		this.vbox2.Add (this.table);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table]));
		w3.Position = 1;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 485;
		this.DefaultHeight = 412;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonNext.Clicked += new global::System.EventHandler (this.OnButtonNextClicked);
	}
}
