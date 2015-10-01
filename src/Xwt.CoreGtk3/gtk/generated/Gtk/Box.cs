// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Box : Gtk.Container, Gtk.IOrientable {

		public Box (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_box_new(int orientation, int spacing);

		public Box (Gtk.Orientation orientation, int spacing) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Box)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("orientation");
				vals.Add (new GLib.Value (orientation));
				names.Add ("spacing");
				vals.Add (new GLib.Value (spacing));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_box_new((int) orientation, spacing);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_box_get_spacing(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_spacing(IntPtr raw, int spacing);

		[GLib.Property ("spacing")]
		public int Spacing {
			get  {
				int raw_ret = gtk_box_get_spacing(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_box_set_spacing(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_box_get_homogeneous(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_homogeneous(IntPtr raw, bool homogeneous);

		[GLib.Property ("homogeneous")]
		public bool Homogeneous {
			get  {
				bool raw_ret = gtk_box_get_homogeneous(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_box_set_homogeneous(Handle, value);
			}
		}

		public class BoxChild : Gtk.Container.ContainerChild {
			protected internal BoxChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("expand")]
			public new bool Expand {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "expand");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "expand", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("fill")]
			public bool Fill {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "fill");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "fill", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("padding")]
			public uint Padding {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "padding");
					uint ret = (uint) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "padding", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("pack-type")]
			public Gtk.PackType PackType {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "pack-type");
					Gtk.PackType ret = (Gtk.PackType) (Enum) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value((Enum) value);
					parent.ChildSetProperty(child, "pack-type", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("position")]
			public int Position {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "position");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "position", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new BoxChild (this, child);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkBoxClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Container)).GetClassSize ();
		static Dictionary<GLib.GType, GtkBoxClass> class_structs;

		static GtkBoxClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkBoxClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkBoxClass class_struct = (GtkBoxClass) Marshal.PtrToStructure (class_ptr, typeof (GtkBoxClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkBoxClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_box_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_pack_end(IntPtr raw, IntPtr child, bool expand, bool fill, uint padding);

		public void PackEnd(Gtk.Widget child, bool expand, bool fill, uint padding) {
			gtk_box_pack_end(Handle, child == null ? IntPtr.Zero : child.Handle, expand, fill, padding);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_pack_start(IntPtr raw, IntPtr child, bool expand, bool fill, uint padding);

		public void PackStart(Gtk.Widget child, bool expand, bool fill, uint padding) {
			gtk_box_pack_start(Handle, child == null ? IntPtr.Zero : child.Handle, expand, fill, padding);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_query_child_packing(IntPtr raw, IntPtr child, out bool expand, out bool fill, out uint padding, out int pack_type);

		public void QueryChildPacking(Gtk.Widget child, out bool expand, out bool fill, out uint padding, out Gtk.PackType pack_type) {
			int native_pack_type;
			gtk_box_query_child_packing(Handle, child == null ? IntPtr.Zero : child.Handle, out expand, out fill, out padding, out native_pack_type);
			pack_type = (Gtk.PackType) native_pack_type;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_reorder_child(IntPtr raw, IntPtr child, int position);

		public void ReorderChild(Gtk.Widget child, int position) {
			gtk_box_reorder_child(Handle, child == null ? IntPtr.Zero : child.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_child_packing(IntPtr raw, IntPtr child, bool expand, bool fill, uint padding, int pack_type);

		public void SetChildPacking(Gtk.Widget child, bool expand, bool fill, uint padding, Gtk.PackType pack_type) {
			gtk_box_set_child_packing(Handle, child == null ? IntPtr.Zero : child.Handle, expand, fill, padding, (int) pack_type);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_orientable_get_orientation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_orientable_set_orientation(IntPtr raw, int orientation);

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}

#endregion
	}
}
