// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void GrabBrokenEventHandler(object o, GrabBrokenEventArgs args);

	public class GrabBrokenEventArgs : GLib.SignalArgs {
		public Gdk.EventGrabBroken Event{
			get {
				return (Gdk.EventGrabBroken) Args [0];
			}
		}

	}
}
