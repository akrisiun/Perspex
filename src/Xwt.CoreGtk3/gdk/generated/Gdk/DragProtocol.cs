// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.DragProtocolGType))]
	public enum DragProtocol {

		None,
		Motif,
		Xdnd,
		Rootwin,
		Win32Dropfiles,
		Ole2,
		Local,
	}

	internal class DragProtocolGType {
		[DllImport ("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_drag_protocol_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_drag_protocol_get_type ());
			}
		}
	}
#endregion
}
