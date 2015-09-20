// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool RecentFilterFuncNative(IntPtr filter_info, IntPtr user_data);

	internal class RecentFilterFuncInvoker {

		RecentFilterFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~RecentFilterFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal RecentFilterFuncInvoker (RecentFilterFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal RecentFilterFuncInvoker (RecentFilterFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal RecentFilterFuncInvoker (RecentFilterFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.RecentFilterFunc Handler {
			get {
				return new Gtk.RecentFilterFunc(InvokeNative);
			}
		}

		bool InvokeNative (Gtk.RecentFilterInfo filter_info)
		{
			IntPtr native_filter_info = GLib.Marshaller.StructureToPtrAlloc (filter_info);
			bool __result = native_cb (native_filter_info, __data);
			filter_info = Gtk.RecentFilterInfo.New (native_filter_info);
			Marshal.FreeHGlobal (native_filter_info);
			return __result;
		}
	}

	internal class RecentFilterFuncWrapper {

		public bool NativeCallback (IntPtr filter_info, IntPtr user_data)
		{
			try {
				bool __ret = managed (Gtk.RecentFilterInfo.New (filter_info));
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

		internal RecentFilterFuncNative NativeDelegate;
		Gtk.RecentFilterFunc managed;

		public RecentFilterFuncWrapper (Gtk.RecentFilterFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new RecentFilterFuncNative (NativeCallback);
		}

		public static Gtk.RecentFilterFunc GetManagedDelegate (RecentFilterFuncNative native)
		{
			if (native == null)
				return null;
			RecentFilterFuncWrapper wrapper = (RecentFilterFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
