using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIRadiusImageView", DoNotGenerateAcw=true)]
	public partial class QMUIRadiusImageView : global::AndroidX.AppCompat.Widget.AppCompatImageView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIRadiusImageView", typeof (QMUIRadiusImageView));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected QMUIRadiusImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/constructor[@name='QMUIRadiusImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIRadiusImageView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/constructor[@name='QMUIRadiusImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIRadiusImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/constructor[@name='QMUIRadiusImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIRadiusImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static int n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int borderColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderColor = borderColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()I", "GetGetBorderColorHandler")]
			get {
				const string __id = "getBorderColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
			set {
				const string __id = "setBorderColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBorderWidth;
#pragma warning disable 0169
		static Delegate GetGetBorderWidthHandler ()
		{
			if (cb_getBorderWidth == null)
				cb_getBorderWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBorderWidth);
			return cb_getBorderWidth;
		}

		static int n_GetBorderWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderWidth_I;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_IHandler ()
		{
			if (cb_setBorderWidth_I == null)
				cb_setBorderWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderWidth_I);
			return cb_setBorderWidth_I;
		}

		static void n_SetBorderWidth_I (IntPtr jnienv, IntPtr native__this, int borderWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderWidth = borderWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='getBorderWidth' and count(parameter)=0]"
			[Register ("getBorderWidth", "()I", "GetGetBorderWidthHandler")]
			get {
				const string __id = "getBorderWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderWidth", "(I)V", "GetSetBorderWidth_IHandler")]
			set {
				const string __id = "setBorderWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCircle;
#pragma warning disable 0169
		static Delegate GetIsCircleHandler ()
		{
			if (cb_isCircle == null)
				cb_isCircle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCircle);
			return cb_isCircle;
		}

		static bool n_IsCircle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Circle;
		}
#pragma warning restore 0169

		static Delegate cb_setCircle_Z;
#pragma warning disable 0169
		static Delegate GetSetCircle_ZHandler ()
		{
			if (cb_setCircle_Z == null)
				cb_setCircle_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCircle_Z);
			return cb_setCircle_Z;
		}

		static void n_SetCircle_Z (IntPtr jnienv, IntPtr native__this, bool isCircle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Circle = isCircle;
		}
#pragma warning restore 0169

		public virtual unsafe bool Circle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='isCircle' and count(parameter)=0]"
			[Register ("isCircle", "()Z", "GetIsCircleHandler")]
			get {
				const string __id = "isCircle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setCircle' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCircle", "(Z)V", "GetSetCircle_ZHandler")]
			set {
				const string __id = "setCircle.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCornerRadius;
#pragma warning disable 0169
		static Delegate GetGetCornerRadiusHandler ()
		{
			if (cb_getCornerRadius == null)
				cb_getCornerRadius = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCornerRadius);
			return cb_getCornerRadius;
		}

		static int n_GetCornerRadius (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CornerRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setCornerRadius_I;
#pragma warning disable 0169
		static Delegate GetSetCornerRadius_IHandler ()
		{
			if (cb_setCornerRadius_I == null)
				cb_setCornerRadius_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCornerRadius_I);
			return cb_setCornerRadius_I;
		}

		static void n_SetCornerRadius_I (IntPtr jnienv, IntPtr native__this, int cornerRadius)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CornerRadius = cornerRadius;
		}
#pragma warning restore 0169

		public virtual unsafe int CornerRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='getCornerRadius' and count(parameter)=0]"
			[Register ("getCornerRadius", "()I", "GetGetCornerRadiusHandler")]
			get {
				const string __id = "getCornerRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCornerRadius", "(I)V", "GetSetCornerRadius_IHandler")]
			set {
				const string __id = "setCornerRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOval;
#pragma warning disable 0169
		static Delegate GetIsOvalHandler ()
		{
			if (cb_isOval == null)
				cb_isOval = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOval);
			return cb_isOval;
		}

		static bool n_IsOval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Oval;
		}
#pragma warning restore 0169

		static Delegate cb_setOval_Z;
#pragma warning disable 0169
		static Delegate GetSetOval_ZHandler ()
		{
			if (cb_setOval_Z == null)
				cb_setOval_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOval_Z);
			return cb_setOval_Z;
		}

		static void n_SetOval_Z (IntPtr jnienv, IntPtr native__this, bool isOval)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Oval = isOval;
		}
#pragma warning restore 0169

		public virtual unsafe bool Oval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='isOval' and count(parameter)=0]"
			[Register ("isOval", "()Z", "GetIsOvalHandler")]
			get {
				const string __id = "isOval.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setOval' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOval", "(Z)V", "GetSetOval_ZHandler")]
			set {
				const string __id = "setOval.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedBorderColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedBorderColorHandler ()
		{
			if (cb_getSelectedBorderColor == null)
				cb_getSelectedBorderColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedBorderColor);
			return cb_getSelectedBorderColor;
		}

		static int n_GetSelectedBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedBorderColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedBorderColor_IHandler ()
		{
			if (cb_setSelectedBorderColor_I == null)
				cb_setSelectedBorderColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSelectedBorderColor_I);
			return cb_setSelectedBorderColor_I;
		}

		static void n_SetSelectedBorderColor_I (IntPtr jnienv, IntPtr native__this, int selectedBorderColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedBorderColor = selectedBorderColor;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='getSelectedBorderColor' and count(parameter)=0]"
			[Register ("getSelectedBorderColor", "()I", "GetGetSelectedBorderColorHandler")]
			get {
				const string __id = "getSelectedBorderColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setSelectedBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedBorderColor", "(I)V", "GetSetSelectedBorderColor_IHandler")]
			set {
				const string __id = "setSelectedBorderColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedBorderWidth;
#pragma warning disable 0169
		static Delegate GetGetSelectedBorderWidthHandler ()
		{
			if (cb_getSelectedBorderWidth == null)
				cb_getSelectedBorderWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedBorderWidth);
			return cb_getSelectedBorderWidth;
		}

		static int n_GetSelectedBorderWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedBorderWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedBorderWidth_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedBorderWidth_IHandler ()
		{
			if (cb_setSelectedBorderWidth_I == null)
				cb_setSelectedBorderWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSelectedBorderWidth_I);
			return cb_setSelectedBorderWidth_I;
		}

		static void n_SetSelectedBorderWidth_I (IntPtr jnienv, IntPtr native__this, int selectedBorderWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedBorderWidth = selectedBorderWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedBorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='getSelectedBorderWidth' and count(parameter)=0]"
			[Register ("getSelectedBorderWidth", "()I", "GetGetSelectedBorderWidthHandler")]
			get {
				const string __id = "getSelectedBorderWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setSelectedBorderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedBorderWidth", "(I)V", "GetSetSelectedBorderWidth_IHandler")]
			set {
				const string __id = "setSelectedBorderWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedMaskColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedMaskColorHandler ()
		{
			if (cb_getSelectedMaskColor == null)
				cb_getSelectedMaskColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedMaskColor);
			return cb_getSelectedMaskColor;
		}

		static int n_GetSelectedMaskColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedMaskColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedMaskColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedMaskColor_IHandler ()
		{
			if (cb_setSelectedMaskColor_I == null)
				cb_setSelectedMaskColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSelectedMaskColor_I);
			return cb_setSelectedMaskColor_I;
		}

		static void n_SetSelectedMaskColor_I (IntPtr jnienv, IntPtr native__this, int selectedMaskColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedMaskColor = selectedMaskColor;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedMaskColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='getSelectedMaskColor' and count(parameter)=0]"
			[Register ("getSelectedMaskColor", "()I", "GetGetSelectedMaskColorHandler")]
			get {
				const string __id = "getSelectedMaskColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setSelectedMaskColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedMaskColor", "(I)V", "GetSetSelectedMaskColor_IHandler")]
			set {
				const string __id = "setSelectedMaskColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTouchSelectModeEnabled;
#pragma warning disable 0169
		static Delegate GetIsTouchSelectModeEnabledHandler ()
		{
			if (cb_isTouchSelectModeEnabled == null)
				cb_isTouchSelectModeEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTouchSelectModeEnabled);
			return cb_isTouchSelectModeEnabled;
		}

		static bool n_IsTouchSelectModeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TouchSelectModeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setTouchSelectModeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTouchSelectModeEnabled_ZHandler ()
		{
			if (cb_setTouchSelectModeEnabled_Z == null)
				cb_setTouchSelectModeEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTouchSelectModeEnabled_Z);
			return cb_setTouchSelectModeEnabled_Z;
		}

		static void n_SetTouchSelectModeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool touchSelectModeEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TouchSelectModeEnabled = touchSelectModeEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool TouchSelectModeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='isTouchSelectModeEnabled' and count(parameter)=0]"
			[Register ("isTouchSelectModeEnabled", "()Z", "GetIsTouchSelectModeEnabledHandler")]
			get {
				const string __id = "isTouchSelectModeEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setTouchSelectModeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTouchSelectModeEnabled", "(Z)V", "GetSetTouchSelectModeEnabled_ZHandler")]
			set {
				const string __id = "setTouchSelectModeEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setSelectedColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetSelectedColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setSelectedColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setSelectedColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSelectedColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setSelectedColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetSelectedColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cf = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_cf, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedColorFilter (cf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setSelectedColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setSelectedColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetSelectedColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public virtual unsafe void SetSelectedColorFilter (global::Android.Graphics.ColorFilter cf)
		{
			const string __id = "setSelectedColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cf);
			}
		}

		static Delegate cb_setupBitmap;
#pragma warning disable 0169
		static Delegate GetSetupBitmapHandler ()
		{
			if (cb_setupBitmap == null)
				cb_setupBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetupBitmap);
			return cb_setupBitmap;
		}

		static void n_SetupBitmap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupBitmap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='setupBitmap' and count(parameter)=0]"
		[Register ("setupBitmap", "()V", "GetSetupBitmapHandler")]
		public virtual unsafe void SetupBitmap ()
		{
			const string __id = "setupBitmap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetUpdateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_Handler ()
		{
			if (cb_updateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_ == null)
				cb_updateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_UpdateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_);
			return cb_updateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_;
		}

		static void n_UpdateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matrix, IntPtr native_bitmap, IntPtr native_drawRect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIRadiusImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_matrix, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var drawRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_drawRect, JniHandleOwnership.DoNotTransfer);
			__this.UpdateScaleTypeMatrix (matrix, bitmap, drawRect);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIRadiusImageView']/method[@name='updateScaleTypeMatrix' and count(parameter)=3 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.RectF']]"
		[Register ("updateScaleTypeMatrix", "(Landroid/graphics/Matrix;Landroid/graphics/Bitmap;Landroid/graphics/RectF;)V", "GetUpdateScaleTypeMatrix_Landroid_graphics_Matrix_Landroid_graphics_Bitmap_Landroid_graphics_RectF_Handler")]
		protected virtual unsafe void UpdateScaleTypeMatrix (global::Android.Graphics.Matrix matrix, global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.RectF drawRect)
		{
			const string __id = "updateScaleTypeMatrix.(Landroid/graphics/Matrix;Landroid/graphics/Bitmap;Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((matrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matrix).Handle);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [2] = new JniArgumentValue ((drawRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawRect).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (matrix);
				global::System.GC.KeepAlive (bitmap);
				global::System.GC.KeepAlive (drawRect);
			}
		}

	}
}
