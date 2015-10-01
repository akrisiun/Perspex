// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VolumeButton : Gtk.ScaleButton {

		public VolumeButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_volume_button_new();

		public VolumeButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (VolumeButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_volume_button_new();
		}

		[GLib.Property ("use-symbolic")]
		public bool UseSymbolic {
			get {
				GLib.Value val = GetProperty ("use-symbolic");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("use-symbolic", val);
				val.Dispose ();
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkVolumeButtonClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.ScaleButton)).GetClassSize ();
		static Dictionary<GLib.GType, GtkVolumeButtonClass> class_structs;

		static GtkVolumeButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkVolumeButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkVolumeButtonClass class_struct = (GtkVolumeButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkVolumeButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkVolumeButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_volume_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_volume_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
