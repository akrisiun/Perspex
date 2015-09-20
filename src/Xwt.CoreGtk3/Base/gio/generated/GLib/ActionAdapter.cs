// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ActionAdapter : GLib.GInterfaceAdapter, GLib.IAction {

		[StructLayout (LayoutKind.Sequential)]
		struct GActionInterface {
			public GetNameNativeDelegate GetName;
			public GetParameterTypeNativeDelegate GetParameterType;
			public GetStateTypeNativeDelegate GetStateType;
			public GetStateHintNativeDelegate GetStateHint;
			public GetEnabledNativeDelegate GetEnabled;
			public GetStateNativeDelegate GetState;
			public SetStateNativeDelegate SetState;
			public ActivateNativeDelegate Activate;
		}

		static GActionInterface iface;

		static ActionAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ActionAdapter));
			iface.GetName = new GetNameNativeDelegate (GetName_cb);
			iface.GetParameterType = new GetParameterTypeNativeDelegate (GetParameterType_cb);
			iface.GetStateType = new GetStateTypeNativeDelegate (GetStateType_cb);
			iface.GetStateHint = new GetStateHintNativeDelegate (GetStateHint_cb);
			iface.GetEnabled = new GetEnabledNativeDelegate (GetEnabled_cb);
			iface.GetState = new GetStateNativeDelegate (GetState_cb);
			iface.SetState = new SetStateNativeDelegate (SetState_cb);
			iface.Activate = new ActivateNativeDelegate (Activate_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetNameNativeDelegate (IntPtr inst);

		static IntPtr GetName_cb (IntPtr inst)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				string __result;
				__result = __obj.Name;
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetParameterTypeNativeDelegate (IntPtr inst);

		static IntPtr GetParameterType_cb (IntPtr inst)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				GLib.VariantType __result;
				__result = __obj.ParameterType;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetStateTypeNativeDelegate (IntPtr inst);

		static IntPtr GetStateType_cb (IntPtr inst)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				GLib.VariantType __result;
				__result = __obj.StateType;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetStateHintNativeDelegate (IntPtr inst);

		static IntPtr GetStateHint_cb (IntPtr inst)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				GLib.Variant __result;
				__result = __obj.StateHint;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetEnabledNativeDelegate (IntPtr inst);

		static bool GetEnabled_cb (IntPtr inst)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				bool __result;
				__result = __obj.Enabled;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetStateNativeDelegate (IntPtr inst);

		static IntPtr GetState_cb (IntPtr inst)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				GLib.Variant __result;
				__result = __obj.State;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetStateNativeDelegate (IntPtr inst, IntPtr value);

		static void SetState_cb (IntPtr inst, IntPtr value)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				__obj.State = new GLib.Variant(value);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivateNativeDelegate (IntPtr inst, IntPtr parameter);

		static void Activate_cb (IntPtr inst, IntPtr parameter)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				__obj.Activate (new GLib.Variant(parameter));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GActionInterface native_iface = (GActionInterface) Marshal.PtrToStructure (ifaceptr, typeof (GActionInterface));
			native_iface.GetName = iface.GetName;
			native_iface.GetParameterType = iface.GetParameterType;
			native_iface.GetStateType = iface.GetStateType;
			native_iface.GetStateHint = iface.GetStateHint;
			native_iface.GetEnabled = iface.GetEnabled;
			native_iface.GetState = iface.GetState;
			native_iface.SetState = iface.SetState;
			native_iface.Activate = iface.Activate;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ActionAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ActionAdapter (IActionImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ActionAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_get_type();

		private static GLib.GType _gtype = new GLib.GType (g_action_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IAction GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IAction GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IActionImplementor)
				return new ActionAdapter (obj as IActionImplementor);
			else if (obj as IAction == null)
				return new ActionAdapter (obj.Handle);
			else
				return obj as IAction;
		}

		public IActionImplementor Implementor {
			get {
				return implementor as IActionImplementor;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_action_activate(IntPtr raw, IntPtr parameter);

		public void Activate(GLib.Variant parameter) {
			g_action_activate(Handle, parameter == null ? IntPtr.Zero : parameter.Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_action_get_enabled(IntPtr raw);

		public bool Enabled { 
			get {
				bool raw_ret = g_action_get_enabled(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = g_action_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_get_parameter_type(IntPtr raw);

		public GLib.VariantType ParameterType { 
			get {
				IntPtr raw_ret = g_action_get_parameter_type(Handle);
				GLib.VariantType ret = new GLib.VariantType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_get_state(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_action_set_state(IntPtr raw, IntPtr value);

		public GLib.Variant State { 
			get {
				IntPtr raw_ret = g_action_get_state(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
			set {
				g_action_set_state(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_get_state_hint(IntPtr raw);

		public GLib.Variant StateHint { 
			get {
				IntPtr raw_ret = g_action_get_state_hint(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_get_state_type(IntPtr raw);

		public GLib.VariantType StateType { 
			get {
				IntPtr raw_ret = g_action_get_state_type(Handle);
				GLib.VariantType ret = new GLib.VariantType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
