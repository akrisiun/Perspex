// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void GSignalHandler(object o, GSignalArgs args);

	public class GSignalArgs : GLib.SignalArgs {
		public string SenderName{
			get {
				return (string) Args [0];
			}
		}

		public string SignalName{
			get {
				return (string) Args [1];
			}
		}

		public GLib.Variant Parameters{
			get {
				return (GLib.Variant) Args [2];
			}
		}

	}
}
