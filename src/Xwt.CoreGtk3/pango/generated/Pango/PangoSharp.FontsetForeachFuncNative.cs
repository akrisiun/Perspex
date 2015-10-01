// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace PangoSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool FontsetForeachFuncNative(IntPtr fontset, IntPtr font, IntPtr data);

	internal class FontsetForeachFuncInvoker {

		FontsetForeachFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FontsetForeachFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FontsetForeachFuncInvoker (FontsetForeachFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FontsetForeachFuncInvoker (FontsetForeachFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FontsetForeachFuncInvoker (FontsetForeachFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Pango.FontsetForeachFunc Handler {
			get {
				return new Pango.FontsetForeachFunc(InvokeNative);
			}
		}

		bool InvokeNative (Pango.Fontset fontset, Pango.Font font)
		{
			bool __result = native_cb (fontset == null ? IntPtr.Zero : fontset.Handle, font == null ? IntPtr.Zero : font.Handle, __data);
			return __result;
		}
	}

	internal class FontsetForeachFuncWrapper {

		public bool NativeCallback (IntPtr fontset, IntPtr font, IntPtr data)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(fontset) as Pango.Fontset, GLib.Object.GetObject(font) as Pango.Font);
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FontsetForeachFuncNative NativeDelegate;
		Pango.FontsetForeachFunc managed;

		public FontsetForeachFuncWrapper (Pango.FontsetForeachFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FontsetForeachFuncNative (NativeCallback);
		}

		public static Pango.FontsetForeachFunc GetManagedDelegate (FontsetForeachFuncNative native)
		{
			if (native == null)
				return null;
			FontsetForeachFuncWrapper wrapper = (FontsetForeachFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
