// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

#region Autogenerated code
	public partial interface IHypertext : GLib.IWrapper {

		event Atk.LinkSelectedHandler LinkSelected;
		Atk.Hyperlink GetLink(int link_index);
		int GetLinkIndex(int char_index);
		int NLinks { 
			get;
		}
	}

	[GLib.GInterface (typeof (HypertextAdapter))]
	public partial interface IHypertextImplementor : GLib.IWrapper {

		Atk.Hyperlink GetLink (int link_index);
		int NLinks { get; }
		int GetLinkIndex (int char_index);
	}
#endregion
}
