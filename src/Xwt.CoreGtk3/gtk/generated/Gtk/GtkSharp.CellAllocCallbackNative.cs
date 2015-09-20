// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool CellAllocCallbackNative(IntPtr renderer, IntPtr cell_area, IntPtr cell_background, IntPtr data);

	internal class CellAllocCallbackInvoker {

		CellAllocCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~CellAllocCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal CellAllocCallbackInvoker (CellAllocCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal CellAllocCallbackInvoker (CellAllocCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal CellAllocCallbackInvoker (CellAllocCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.CellAllocCallback Handler {
			get {
				return new Gtk.CellAllocCallback(InvokeNative);
			}
		}

		bool InvokeNative (Gtk.CellRenderer renderer, Gdk.Rectangle cell_area, Gdk.Rectangle cell_background)
		{
			IntPtr native_cell_area = GLib.Marshaller.StructureToPtrAlloc (cell_area);
			IntPtr native_cell_background = GLib.Marshaller.StructureToPtrAlloc (cell_background);
			bool __result = native_cb (renderer == null ? IntPtr.Zero : renderer.Handle, native_cell_area, native_cell_background, __data);
			cell_area = (Gdk.Rectangle) Marshal.PtrToStructure (native_cell_area, typeof (Gdk.Rectangle));
			Marshal.FreeHGlobal (native_cell_area);
			cell_background = (Gdk.Rectangle) Marshal.PtrToStructure (native_cell_background, typeof (Gdk.Rectangle));
			Marshal.FreeHGlobal (native_cell_background);
			return __result;
		}
	}

	internal class CellAllocCallbackWrapper {

		public bool NativeCallback (IntPtr renderer, IntPtr cell_area, IntPtr cell_background, IntPtr data)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(renderer) as Gtk.CellRenderer, (Gdk.Rectangle) Marshal.PtrToStructure (cell_area, typeof (Gdk.Rectangle)), (Gdk.Rectangle) Marshal.PtrToStructure (cell_background, typeof (Gdk.Rectangle)));
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

		internal CellAllocCallbackNative NativeDelegate;
		Gtk.CellAllocCallback managed;

		public CellAllocCallbackWrapper (Gtk.CellAllocCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new CellAllocCallbackNative (NativeCallback);
		}

		public static Gtk.CellAllocCallback GetManagedDelegate (CellAllocCallbackNative native)
		{
			if (native == null)
				return null;
			CellAllocCallbackWrapper wrapper = (CellAllocCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
