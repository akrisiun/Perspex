// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Color : IEquatable<Color> {

		public uint Pixel;
		public ushort Red;
		public ushort Green;
		public ushort Blue;

		public static Gdk.Color Zero = new Gdk.Color ();

		public static Gdk.Color New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gdk.Color.Zero;
			return (Gdk.Color) Marshal.PtrToStructure (raw, typeof (Gdk.Color));
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_color_equal(IntPtr raw, IntPtr colorb);

		public bool Equal(Gdk.Color colorb) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_colorb = GLib.Marshaller.StructureToPtrAlloc (colorb);
			bool raw_ret = gdk_color_equal(this_as_native, native_colorb);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			colorb = Gdk.Color.New (native_colorb);
			Marshal.FreeHGlobal (native_colorb);
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_color_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_color_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_color_parse(IntPtr spec, IntPtr color);

		public static bool Parse(string spec, ref Gdk.Color color) {
			IntPtr native_spec = GLib.Marshaller.StringToPtrGStrdup (spec);
			IntPtr native_color = GLib.Marshaller.StructureToPtrAlloc (color);
			bool raw_ret = gdk_color_parse(native_spec, native_color);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_spec);
			color = Gdk.Color.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gdk.Color target)
		{
			target = New (native);
		}

		public bool Equals (Color other)
		{
			return true && Pixel.Equals (other.Pixel) && Red.Equals (other.Red) && Green.Equals (other.Green) && Blue.Equals (other.Blue);
		}

		public override bool Equals (object other)
		{
			return other is Color && Equals ((Color) other);
		}

		public static explicit operator GLib.Value (Gdk.Color boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gdk.Color.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gdk.Color (GLib.Value val)
		{
			return (Gdk.Color) val.Val;
		}
#endregion
	}
}
