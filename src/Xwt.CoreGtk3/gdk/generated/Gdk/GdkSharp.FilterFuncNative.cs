// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GdkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate int FilterFuncNative(IntPtr xevent, IntPtr evnt, IntPtr data);

	internal class FilterFuncInvoker {

		FilterFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FilterFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FilterFuncInvoker (FilterFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FilterFuncInvoker (FilterFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FilterFuncInvoker (FilterFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gdk.FilterFunc Handler {
			get {
				return new Gdk.FilterFunc(InvokeNative);
			}
		}

		Gdk.FilterReturn InvokeNative (System.IntPtr xevent, Gdk.Event evnt)
		{
			Gdk.FilterReturn __result = (Gdk.FilterReturn) native_cb (xevent, evnt == null ? IntPtr.Zero : evnt.Handle, __data);
			return __result;
		}
	}

	internal class FilterFuncWrapper {

		public int NativeCallback (IntPtr xevent, IntPtr evnt, IntPtr data)
		{
			try {
				Gdk.FilterReturn __ret = managed (xevent, Gdk.Event.GetEvent (evnt));
				if (release_on_call)
					gch.Free ();
				return (int) __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FilterFuncNative NativeDelegate;
		Gdk.FilterFunc managed;

		public FilterFuncWrapper (Gdk.FilterFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FilterFuncNative (NativeCallback);
		}

		public static Gdk.FilterFunc GetManagedDelegate (FilterFuncNative native)
		{
			if (native == null)
				return null;
			FilterFuncWrapper wrapper = (FilterFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
