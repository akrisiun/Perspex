// Copyright (c) 2011 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

	public partial class TextAttributes {

		public TextAppearance Appearance {
			get { return (TextAppearance) Marshal.PtrToStructure (new IntPtr (Handle.ToInt64 () + 4), typeof (TextAppearance)); }
			set { Marshal.StructureToPtr (value, new IntPtr (Handle.ToInt64 () + 4), false); }
		}
	}
}
