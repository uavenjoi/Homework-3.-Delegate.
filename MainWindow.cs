using System;
using System.Collections.Generic;
using Gtk;
using DelegateGTK;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnStartButtonClicked(object sender, EventArgs e)
	{

		TextLabel.Text = string.Empty;

		if (ToUpperCheckButton.Active)
		{
			if (TextLabel.Text.Length == 0)
				//непонятно, если текста нет, зачем что то делать
				TextLabel.Text = MainClass.StringOperations(TextField.Text, MainClass.ToUpperString);
			else
				TextLabel.Text = MainClass.StringOperations(TextLabel.Text, MainClass.ToUpperString);
		}

		if (TurnStringCheckButton.Active)
		{
			
			if (TextLabel.Text.Length == 0)

				TextLabel.Text = MainClass.StringOperations(TextField.Text, MainClass.TurnString);
			else
				TextLabel.Text = MainClass.StringOperations(TextLabel.Text, MainClass.TurnString);
		}

		if (AddSpacesCheckButton.Active)
		{
			if (TextLabel.Text.Length == 0)

				TextLabel.Text = MainClass.StringOperations(TextField.Text, MainClass.AddSpacesToString);
			else
				TextLabel.Text = MainClass.StringOperations(TextLabel.Text, MainClass.AddSpacesToString);
		}
	}
}
