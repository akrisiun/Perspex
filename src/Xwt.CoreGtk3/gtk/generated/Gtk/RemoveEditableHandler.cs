// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void RemoveEditableHandler(object o, RemoveEditableArgs args);

	public class RemoveEditableArgs : GLib.SignalArgs {
		public Gtk.CellRenderer P0{
			get {
				return (Gtk.CellRenderer) Args [0];
			}
		}

		public Gtk.ICellEditable P1{
			get {
				return Gtk.CellEditableAdapter.GetObject (Args [1] as GLib.Object);
			}
		}

	}
}
