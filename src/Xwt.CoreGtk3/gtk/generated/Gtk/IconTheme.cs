// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class IconTheme : GLib.Object {

		public IconTheme (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_new();

		public IconTheme () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (IconTheme)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_icon_theme_new();
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			GtkIconThemeClass class_iface = GetClassStruct (gtype, false);
			class_iface.Changed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				IconTheme __obj = GLib.Object.GetObject (inst, false) as IconTheme;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.IconTheme), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Changed;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkIconThemeClass {
			public ChangedNativeDelegate Changed;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkIconThemeClass> class_structs;

		static GtkIconThemeClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkIconThemeClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkIconThemeClass class_struct = (GtkIconThemeClass) Marshal.PtrToStructure (class_ptr, typeof (GtkIconThemeClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkIconThemeClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_theme_add_builtin_icon(IntPtr icon_name, int size, IntPtr pixbuf);

		public static void AddBuiltinIcon(string icon_name, int size, Gdk.Pixbuf pixbuf) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			gtk_icon_theme_add_builtin_icon(native_icon_name, size, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
			GLib.Marshaller.Free (native_icon_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_theme_append_search_path(IntPtr raw, IntPtr path);

		[DllImport("libgtk-3-0.dll")]
		static extern void gtk_icon_theme_append_search_path_utf8(IntPtr raw, IntPtr path);

		public void AppendSearchPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				gtk_icon_theme_append_search_path_utf8(Handle, native_path);
			else
				gtk_icon_theme_append_search_path(Handle, native_path);
			GLib.Marshaller.Free (native_path);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_choose_icon(IntPtr raw, IntPtr[] icon_names, int size, int flags);

		public Gtk.IconInfo ChooseIcon(string[] icon_names, int size, Gtk.IconLookupFlags flags) {
			int cnt_icon_names = icon_names == null ? 0 : icon_names.Length;
			IntPtr[] native_icon_names = new IntPtr [cnt_icon_names + 1];
			for (int i = 0; i < cnt_icon_names; i++)
				native_icon_names [i] = GLib.Marshaller.StringToPtrGStrdup (icon_names[i]);
			native_icon_names [cnt_icon_names] = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_theme_choose_icon(Handle, native_icon_names, size, (int) flags);
			Gtk.IconInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconInfo), false);
			for (int i = 0; i < native_icon_names.Length - 1; i++) {
				icon_names [i] = GLib.Marshaller.Utf8PtrToString (native_icon_names[i]);
				GLib.Marshaller.Free (native_icon_names[i]);
			}
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_icon_theme_error_quark();

		public static int ErrorQuark() {
			int raw_ret = gtk_icon_theme_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_get_default();

		public static Gtk.IconTheme Default { 
			get {
				IntPtr raw_ret = gtk_icon_theme_get_default();
				Gtk.IconTheme ret = GLib.Object.GetObject(raw_ret) as Gtk.IconTheme;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_get_example_icon_name(IntPtr raw);

		public string ExampleIconName { 
			get {
				IntPtr raw_ret = gtk_icon_theme_get_example_icon_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_get_for_screen(IntPtr screen);

		public static Gtk.IconTheme GetForScreen(Gdk.Screen screen) {
			IntPtr raw_ret = gtk_icon_theme_get_for_screen(screen == null ? IntPtr.Zero : screen.Handle);
			Gtk.IconTheme ret = GLib.Object.GetObject(raw_ret) as Gtk.IconTheme;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_icon_theme_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_icon_theme_has_icon(IntPtr raw, IntPtr icon_name);

		public bool HasIcon(string icon_name) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			bool raw_ret = gtk_icon_theme_has_icon(Handle, native_icon_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_icon_name);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_list_contexts(IntPtr raw);

		public string[] ListContexts() {
			IntPtr raw_ret = gtk_icon_theme_list_contexts(Handle);
			string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(string));
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gtk_icon_theme_load_icon(IntPtr raw, IntPtr icon_name, int size, int flags, out IntPtr error);

		public unsafe Gdk.Pixbuf LoadIcon(string icon_name, int size, Gtk.IconLookupFlags flags) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_theme_load_icon(Handle, native_icon_name, size, (int) flags, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret, true) as Gdk.Pixbuf;
			GLib.Marshaller.Free (native_icon_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_lookup_by_gicon(IntPtr raw, IntPtr icon, int size, int flags);

		public Gtk.IconInfo LookupIcon(GLib.IIcon icon, int size, Gtk.IconLookupFlags flags) {
			IntPtr raw_ret = gtk_icon_theme_lookup_by_gicon(Handle, icon == null ? IntPtr.Zero : ((icon is GLib.Object) ? (icon as GLib.Object).Handle : (icon as GLib.IconAdapter).Handle), size, (int) flags);
			Gtk.IconInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconInfo), true);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_theme_lookup_icon(IntPtr raw, IntPtr icon_name, int size, int flags);

		public Gtk.IconInfo LookupIcon(string icon_name, int size, Gtk.IconLookupFlags flags) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			IntPtr raw_ret = gtk_icon_theme_lookup_icon(Handle, native_icon_name, size, (int) flags);
			Gtk.IconInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconInfo), true);
			GLib.Marshaller.Free (native_icon_name);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_theme_prepend_search_path(IntPtr raw, IntPtr path);

		[DllImport("libgtk-3-0.dll")]
		static extern void gtk_icon_theme_prepend_search_path_utf8(IntPtr raw, IntPtr path);

		public void PrependSearchPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				gtk_icon_theme_prepend_search_path_utf8(Handle, native_path);
			else
				gtk_icon_theme_prepend_search_path(Handle, native_path);
			GLib.Marshaller.Free (native_path);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_icon_theme_rescan_if_needed(IntPtr raw);

		public bool RescanIfNeeded() {
			bool raw_ret = gtk_icon_theme_rescan_if_needed(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_theme_set_custom_theme(IntPtr raw, IntPtr theme_name);

		public string CustomTheme { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_icon_theme_set_custom_theme(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_theme_set_screen(IntPtr raw, IntPtr screen);

		public Gdk.Screen Screen { 
			set {
				gtk_icon_theme_set_screen(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

#endregion
	}
}
