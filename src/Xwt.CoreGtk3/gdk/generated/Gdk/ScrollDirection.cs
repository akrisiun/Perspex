// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.ScrollDirectionGType))]
	public enum ScrollDirection {

		Up,
		Down,
		Left,
		Right,
	}

	internal class ScrollDirectionGType {
		[DllImport ("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_scroll_direction_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_scroll_direction_get_type ());
			}
		}
	}
#endregion
}
