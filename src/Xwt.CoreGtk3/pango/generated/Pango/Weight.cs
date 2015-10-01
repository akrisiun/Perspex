// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.WeightGType))]
	public enum Weight {

		Thin = 100,
		Ultralight = 200,
		Light = 300,
		Book = 380,
		Normal = 400,
		Medium = 500,
		Semibold = 600,
		Bold = 700,
		Ultrabold = 800,
		Heavy = 900,
		Ultraheavy = 1000,
	}

	internal class WeightGType {
		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_weight_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_weight_get_type ());
			}
		}
	}
#endregion
}
