// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SeparatorToolItem : Gtk.ToolItem {

		public SeparatorToolItem (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_separator_tool_item_new();

		public SeparatorToolItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SeparatorToolItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_separator_tool_item_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_separator_tool_item_get_draw(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_separator_tool_item_set_draw(IntPtr raw, bool draw);

		[GLib.Property ("draw")]
		public new bool Draw {
			get  {
				bool raw_ret = gtk_separator_tool_item_get_draw(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_separator_tool_item_set_draw(Handle, value);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkSeparatorToolItemClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.ToolItem)).GetClassSize ();
		static Dictionary<GLib.GType, GtkSeparatorToolItemClass> class_structs;

		static GtkSeparatorToolItemClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkSeparatorToolItemClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkSeparatorToolItemClass class_struct = (GtkSeparatorToolItemClass) Marshal.PtrToStructure (class_ptr, typeof (GtkSeparatorToolItemClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkSeparatorToolItemClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_separator_tool_item_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_separator_tool_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
