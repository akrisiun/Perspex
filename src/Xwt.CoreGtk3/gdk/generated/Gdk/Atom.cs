// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Atom : GLib.Opaque {

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_atom_intern(IntPtr atom_name, bool only_if_exists);

		public static Gdk.Atom Intern(string atom_name, bool only_if_exists) {
			IntPtr native_atom_name = GLib.Marshaller.StringToPtrGStrdup (atom_name);
			IntPtr raw_ret = gdk_atom_intern(native_atom_name, only_if_exists);
			Gdk.Atom ret = raw_ret == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.Atom), false);
			GLib.Marshaller.Free (native_atom_name);
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_atom_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = gdk_atom_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		public Atom(IntPtr raw) : base(raw) {}

#endregion
	}
}
