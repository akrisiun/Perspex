// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void AskPasswordHandler(object o, AskPasswordArgs args);

	public class AskPasswordArgs : GLib.SignalArgs {
		public string Message{
			get {
				return (string) Args [0];
			}
		}

		public string DefaultUser{
			get {
				return (string) Args [1];
			}
		}

		public string DefaultDomain{
			get {
				return (string) Args [2];
			}
		}

		public GLib.AskPasswordFlags Flags{
			get {
				return (GLib.AskPasswordFlags) Args [3];
			}
		}

	}
}
