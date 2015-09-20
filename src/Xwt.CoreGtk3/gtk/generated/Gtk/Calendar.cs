// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Calendar : Gtk.Widget {

		public Calendar (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_calendar_new();

		public Calendar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Calendar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_calendar_new();
		}

		[GLib.Property ("year")]
		public int Year {
			get {
				GLib.Value val = GetProperty ("year");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("year", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("month")]
		public int Month {
			get {
				GLib.Value val = GetProperty ("month");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("month", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("day")]
		public int Day {
			get {
				GLib.Value val = GetProperty ("day");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("day", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("show-heading")]
		public bool ShowHeading {
			get {
				GLib.Value val = GetProperty ("show-heading");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("show-heading", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("show-day-names")]
		public bool ShowDayNames {
			get {
				GLib.Value val = GetProperty ("show-day-names");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("show-day-names", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("no-month-change")]
		public bool NoMonthChange {
			get {
				GLib.Value val = GetProperty ("no-month-change");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("no-month-change", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("show-week-numbers")]
		public bool ShowWeekNumbers {
			get {
				GLib.Value val = GetProperty ("show-week-numbers");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("show-week-numbers", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_calendar_get_detail_width_chars(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_set_detail_width_chars(IntPtr raw, int chars);

		[GLib.Property ("detail-width-chars")]
		public int DetailWidthChars {
			get  {
				int raw_ret = gtk_calendar_get_detail_width_chars(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_calendar_set_detail_width_chars(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_calendar_get_detail_height_rows(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_set_detail_height_rows(IntPtr raw, int rows);

		[GLib.Property ("detail-height-rows")]
		public int DetailHeightRows {
			get  {
				int raw_ret = gtk_calendar_get_detail_height_rows(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_calendar_set_detail_height_rows(Handle, value);
			}
		}

		[GLib.Property ("show-details")]
		public bool ShowDetails {
			get {
				GLib.Value val = GetProperty ("show-details");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("show-details", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("day-selected")]
		public event System.EventHandler DaySelected {
			add {
				this.AddSignalHandler ("day-selected", value);
			}
			remove {
				this.RemoveSignalHandler ("day-selected", value);
			}
		}

		[GLib.Signal("prev-month")]
		public event System.EventHandler PrevMonth {
			add {
				this.AddSignalHandler ("prev-month", value);
			}
			remove {
				this.RemoveSignalHandler ("prev-month", value);
			}
		}

		[GLib.Signal("day-selected-double-click")]
		public event System.EventHandler DaySelectedDoubleClick {
			add {
				this.AddSignalHandler ("day-selected-double-click", value);
			}
			remove {
				this.RemoveSignalHandler ("day-selected-double-click", value);
			}
		}

		[GLib.Signal("month-changed")]
		public event System.EventHandler MonthChanged {
			add {
				this.AddSignalHandler ("month-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("month-changed", value);
			}
		}

		[GLib.Signal("next-year")]
		public event System.EventHandler NextYear {
			add {
				this.AddSignalHandler ("next-year", value);
			}
			remove {
				this.RemoveSignalHandler ("next-year", value);
			}
		}

		[GLib.Signal("next-month")]
		public event System.EventHandler NextMonth {
			add {
				this.AddSignalHandler ("next-month", value);
			}
			remove {
				this.RemoveSignalHandler ("next-month", value);
			}
		}

		[GLib.Signal("prev-year")]
		public event System.EventHandler PrevYear {
			add {
				this.AddSignalHandler ("prev-year", value);
			}
			remove {
				this.RemoveSignalHandler ("prev-year", value);
			}
		}

		static MonthChangedNativeDelegate MonthChanged_cb_delegate;
		static MonthChangedNativeDelegate MonthChangedVMCallback {
			get {
				if (MonthChanged_cb_delegate == null)
					MonthChanged_cb_delegate = new MonthChangedNativeDelegate (MonthChanged_cb);
				return MonthChanged_cb_delegate;
			}
		}

		static void OverrideMonthChanged (GLib.GType gtype)
		{
			OverrideMonthChanged (gtype, MonthChangedVMCallback);
		}

		static void OverrideMonthChanged (GLib.GType gtype, MonthChangedNativeDelegate callback)
		{
			GtkCalendarClass class_iface = GetClassStruct (gtype, false);
			class_iface.MonthChanged = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MonthChangedNativeDelegate (IntPtr inst);

		static void MonthChanged_cb (IntPtr inst)
		{
			try {
				Calendar __obj = GLib.Object.GetObject (inst, false) as Calendar;
				__obj.OnMonthChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Calendar), ConnectionMethod="OverrideMonthChanged")]
		protected virtual void OnMonthChanged ()
		{
			InternalMonthChanged ();
		}

		private void InternalMonthChanged ()
		{
			MonthChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).MonthChanged;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static DaySelectedNativeDelegate DaySelected_cb_delegate;
		static DaySelectedNativeDelegate DaySelectedVMCallback {
			get {
				if (DaySelected_cb_delegate == null)
					DaySelected_cb_delegate = new DaySelectedNativeDelegate (DaySelected_cb);
				return DaySelected_cb_delegate;
			}
		}

		static void OverrideDaySelected (GLib.GType gtype)
		{
			OverrideDaySelected (gtype, DaySelectedVMCallback);
		}

		static void OverrideDaySelected (GLib.GType gtype, DaySelectedNativeDelegate callback)
		{
			GtkCalendarClass class_iface = GetClassStruct (gtype, false);
			class_iface.DaySelected = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DaySelectedNativeDelegate (IntPtr inst);

		static void DaySelected_cb (IntPtr inst)
		{
			try {
				Calendar __obj = GLib.Object.GetObject (inst, false) as Calendar;
				__obj.OnDaySelected ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Calendar), ConnectionMethod="OverrideDaySelected")]
		protected virtual void OnDaySelected ()
		{
			InternalDaySelected ();
		}

		private void InternalDaySelected ()
		{
			DaySelectedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DaySelected;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static DaySelectedDoubleClickNativeDelegate DaySelectedDoubleClick_cb_delegate;
		static DaySelectedDoubleClickNativeDelegate DaySelectedDoubleClickVMCallback {
			get {
				if (DaySelectedDoubleClick_cb_delegate == null)
					DaySelectedDoubleClick_cb_delegate = new DaySelectedDoubleClickNativeDelegate (DaySelectedDoubleClick_cb);
				return DaySelectedDoubleClick_cb_delegate;
			}
		}

		static void OverrideDaySelectedDoubleClick (GLib.GType gtype)
		{
			OverrideDaySelectedDoubleClick (gtype, DaySelectedDoubleClickVMCallback);
		}

		static void OverrideDaySelectedDoubleClick (GLib.GType gtype, DaySelectedDoubleClickNativeDelegate callback)
		{
			GtkCalendarClass class_iface = GetClassStruct (gtype, false);
			class_iface.DaySelectedDoubleClick = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DaySelectedDoubleClickNativeDelegate (IntPtr inst);

		static void DaySelectedDoubleClick_cb (IntPtr inst)
		{
			try {
				Calendar __obj = GLib.Object.GetObject (inst, false) as Calendar;
				__obj.OnDaySelectedDoubleClick ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Calendar), ConnectionMethod="OverrideDaySelectedDoubleClick")]
		protected virtual void OnDaySelectedDoubleClick ()
		{
			InternalDaySelectedDoubleClick ();
		}

		private void InternalDaySelectedDoubleClick ()
		{
			DaySelectedDoubleClickNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DaySelectedDoubleClick;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static PrevMonthNativeDelegate PrevMonth_cb_delegate;
		static PrevMonthNativeDelegate PrevMonthVMCallback {
			get {
				if (PrevMonth_cb_delegate == null)
					PrevMonth_cb_delegate = new PrevMonthNativeDelegate (PrevMonth_cb);
				return PrevMonth_cb_delegate;
			}
		}

		static void OverridePrevMonth (GLib.GType gtype)
		{
			OverridePrevMonth (gtype, PrevMonthVMCallback);
		}

		static void OverridePrevMonth (GLib.GType gtype, PrevMonthNativeDelegate callback)
		{
			GtkCalendarClass class_iface = GetClassStruct (gtype, false);
			class_iface.PrevMonth = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrevMonthNativeDelegate (IntPtr inst);

		static void PrevMonth_cb (IntPtr inst)
		{
			try {
				Calendar __obj = GLib.Object.GetObject (inst, false) as Calendar;
				__obj.OnPrevMonth ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Calendar), ConnectionMethod="OverridePrevMonth")]
		protected virtual void OnPrevMonth ()
		{
			InternalPrevMonth ();
		}

		private void InternalPrevMonth ()
		{
			PrevMonthNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).PrevMonth;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static NextMonthNativeDelegate NextMonth_cb_delegate;
		static NextMonthNativeDelegate NextMonthVMCallback {
			get {
				if (NextMonth_cb_delegate == null)
					NextMonth_cb_delegate = new NextMonthNativeDelegate (NextMonth_cb);
				return NextMonth_cb_delegate;
			}
		}

		static void OverrideNextMonth (GLib.GType gtype)
		{
			OverrideNextMonth (gtype, NextMonthVMCallback);
		}

		static void OverrideNextMonth (GLib.GType gtype, NextMonthNativeDelegate callback)
		{
			GtkCalendarClass class_iface = GetClassStruct (gtype, false);
			class_iface.NextMonth = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NextMonthNativeDelegate (IntPtr inst);

		static void NextMonth_cb (IntPtr inst)
		{
			try {
				Calendar __obj = GLib.Object.GetObject (inst, false) as Calendar;
				__obj.OnNextMonth ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Calendar), ConnectionMethod="OverrideNextMonth")]
		protected virtual void OnNextMonth ()
		{
			InternalNextMonth ();
		}

		private void InternalNextMonth ()
		{
			NextMonthNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).NextMonth;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static PrevYearNativeDelegate PrevYear_cb_delegate;
		static PrevYearNativeDelegate PrevYearVMCallback {
			get {
				if (PrevYear_cb_delegate == null)
					PrevYear_cb_delegate = new PrevYearNativeDelegate (PrevYear_cb);
				return PrevYear_cb_delegate;
			}
		}

		static void OverridePrevYear (GLib.GType gtype)
		{
			OverridePrevYear (gtype, PrevYearVMCallback);
		}

		static void OverridePrevYear (GLib.GType gtype, PrevYearNativeDelegate callback)
		{
			GtkCalendarClass class_iface = GetClassStruct (gtype, false);
			class_iface.PrevYear = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrevYearNativeDelegate (IntPtr inst);

		static void PrevYear_cb (IntPtr inst)
		{
			try {
				Calendar __obj = GLib.Object.GetObject (inst, false) as Calendar;
				__obj.OnPrevYear ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Calendar), ConnectionMethod="OverridePrevYear")]
		protected virtual void OnPrevYear ()
		{
			InternalPrevYear ();
		}

		private void InternalPrevYear ()
		{
			PrevYearNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).PrevYear;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static NextYearNativeDelegate NextYear_cb_delegate;
		static NextYearNativeDelegate NextYearVMCallback {
			get {
				if (NextYear_cb_delegate == null)
					NextYear_cb_delegate = new NextYearNativeDelegate (NextYear_cb);
				return NextYear_cb_delegate;
			}
		}

		static void OverrideNextYear (GLib.GType gtype)
		{
			OverrideNextYear (gtype, NextYearVMCallback);
		}

		static void OverrideNextYear (GLib.GType gtype, NextYearNativeDelegate callback)
		{
			GtkCalendarClass class_iface = GetClassStruct (gtype, false);
			class_iface.NextYear = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NextYearNativeDelegate (IntPtr inst);

		static void NextYear_cb (IntPtr inst)
		{
			try {
				Calendar __obj = GLib.Object.GetObject (inst, false) as Calendar;
				__obj.OnNextYear ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Calendar), ConnectionMethod="OverrideNextYear")]
		protected virtual void OnNextYear ()
		{
			InternalNextYear ();
		}

		private void InternalNextYear ()
		{
			NextYearNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).NextYear;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkCalendarClass {
			public MonthChangedNativeDelegate MonthChanged;
			public DaySelectedNativeDelegate DaySelected;
			public DaySelectedDoubleClickNativeDelegate DaySelectedDoubleClick;
			public PrevMonthNativeDelegate PrevMonth;
			public NextMonthNativeDelegate NextMonth;
			public PrevYearNativeDelegate PrevYear;
			public NextYearNativeDelegate NextYear;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Widget)).GetClassSize ();
		static Dictionary<GLib.GType, GtkCalendarClass> class_structs;

		static GtkCalendarClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkCalendarClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkCalendarClass class_struct = (GtkCalendarClass) Marshal.PtrToStructure (class_ptr, typeof (GtkCalendarClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkCalendarClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_clear_marks(IntPtr raw);

		public void ClearMarks() {
			gtk_calendar_clear_marks(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_get_date(IntPtr raw, out uint year, out uint month, out uint day);

		public void GetDate(out uint year, out uint month, out uint day) {
			gtk_calendar_get_date(Handle, out year, out month, out day);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_calendar_get_day_is_marked(IntPtr raw, uint day);

		public bool GetDayIsMarked(uint day) {
			bool raw_ret = gtk_calendar_get_day_is_marked(Handle, day);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_calendar_get_display_options(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_set_display_options(IntPtr raw, int flags);

		public Gtk.CalendarDisplayOptions DisplayOptions { 
			get {
				int raw_ret = gtk_calendar_get_display_options(Handle);
				Gtk.CalendarDisplayOptions ret = (Gtk.CalendarDisplayOptions) raw_ret;
				return ret;
			}
			set {
				gtk_calendar_set_display_options(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_calendar_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_calendar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_mark_day(IntPtr raw, uint day);

		public void MarkDay(uint day) {
			gtk_calendar_mark_day(Handle, day);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_select_day(IntPtr raw, uint day);

		public void SelectDay(uint day) {
			gtk_calendar_select_day(Handle, day);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_select_month(IntPtr raw, uint month, uint year);

		public void SelectMonth(uint month, uint year) {
			gtk_calendar_select_month(Handle, month, year);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_set_detail_func(IntPtr raw, GtkSharp.CalendarDetailFuncNative func, IntPtr data, GLib.DestroyNotify destroy);

		public Gtk.CalendarDetailFunc DetailFunc { 
			set {
				GtkSharp.CalendarDetailFuncWrapper value_wrapper = new GtkSharp.CalendarDetailFuncWrapper (value);
				IntPtr data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					data = IntPtr.Zero;
					destroy = null;
				} else {
					data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_calendar_set_detail_func(Handle, value_wrapper.NativeDelegate, data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_calendar_unmark_day(IntPtr raw, uint day);

		public void UnmarkDay(uint day) {
			gtk_calendar_unmark_day(Handle, day);
		}

#endregion
	}
}
