// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void EnterNotifyEventHandler(object o, EnterNotifyEventArgs args);

	public class EnterNotifyEventArgs : GLib.SignalArgs {
		public Gdk.EventCrossing Event{
			get {
				return (Gdk.EventCrossing) Args [0];
			}
		}

	}
}
