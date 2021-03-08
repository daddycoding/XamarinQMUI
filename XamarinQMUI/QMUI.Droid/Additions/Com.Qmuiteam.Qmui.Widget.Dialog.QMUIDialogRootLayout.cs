using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout", DoNotGenerateAcw=true)]
	public partial class QMUIDialogRootLayout : global::Android.Views.ViewGroup {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout", typeof (QMUIDialogRootLayout));
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

		protected QMUIDialogRootLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/constructor[@name='QMUIDialogRootLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.widget.FrameLayout.LayoutParams']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/widget/FrameLayout$LayoutParams;)V", "")]
		public unsafe QMUIDialogRootLayout (global::Android.Content.Context context, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView dialogView, global::Android.Widget.FrameLayout.LayoutParams dialogViewLp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/widget/FrameLayout$LayoutParams;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((dialogView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialogView).Handle);
				__args [2] = new JniArgumentValue ((dialogViewLp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialogViewLp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (dialogView);
				global::System.GC.KeepAlive (dialogViewLp);
			}
		}

		static Delegate cb_getDialogView;
#pragma warning disable 0169
		static Delegate GetGetDialogViewHandler ()
		{
			if (cb_getDialogView == null)
				cb_getDialogView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDialogView);
			return cb_getDialogView;
		}

		static IntPtr n_GetDialogView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DialogView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView DialogView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='getDialogView' and count(parameter)=0]"
			[Register ("getDialogView", "()Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;", "GetGetDialogViewHandler")]
			get {
				const string __id = "getDialogView.()Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZIIII_V) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, l, t, r, b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool changed, int l, int t, int r, int b)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (l);
				__args [2] = new JniArgumentValue (t);
				__args [3] = new JniArgumentValue (r);
				__args [4] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCheckKeyboardOverlay_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckKeyboardOverlay_ZHandler ()
		{
			if (cb_setCheckKeyboardOverlay_Z == null)
				cb_setCheckKeyboardOverlay_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCheckKeyboardOverlay_Z);
			return cb_setCheckKeyboardOverlay_Z;
		}

		static void n_SetCheckKeyboardOverlay_Z (IntPtr jnienv, IntPtr native__this, bool checkKeyboardOverlay)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCheckKeyboardOverlay (checkKeyboardOverlay);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='setCheckKeyboardOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCheckKeyboardOverlay", "(Z)V", "GetSetCheckKeyboardOverlay_ZHandler")]
		public virtual unsafe void SetCheckKeyboardOverlay (bool checkKeyboardOverlay)
		{
			const string __id = "setCheckKeyboardOverlay.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (checkKeyboardOverlay);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInsetHor_I;
#pragma warning disable 0169
		static Delegate GetSetInsetHor_IHandler ()
		{
			if (cb_setInsetHor_I == null)
				cb_setInsetHor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetInsetHor_I);
			return cb_setInsetHor_I;
		}

		static void n_SetInsetHor_I (IntPtr jnienv, IntPtr native__this, int insetHor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInsetHor (insetHor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='setInsetHor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInsetHor", "(I)V", "GetSetInsetHor_IHandler")]
		public virtual unsafe void SetInsetHor (int insetHor)
		{
			const string __id = "setInsetHor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (insetHor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInsetVer_I;
#pragma warning disable 0169
		static Delegate GetSetInsetVer_IHandler ()
		{
			if (cb_setInsetVer_I == null)
				cb_setInsetVer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetInsetVer_I);
			return cb_setInsetVer_I;
		}

		static void n_SetInsetVer_I (IntPtr jnienv, IntPtr native__this, int insetVer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInsetVer (insetVer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='setInsetVer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInsetVer", "(I)V", "GetSetInsetVer_IHandler")]
		public virtual unsafe void SetInsetVer (int insetVer)
		{
			const string __id = "setInsetVer.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (insetVer);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaxPercent_F;
#pragma warning disable 0169
		static Delegate GetSetMaxPercent_FHandler ()
		{
			if (cb_setMaxPercent_F == null)
				cb_setMaxPercent_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetMaxPercent_F);
			return cb_setMaxPercent_F;
		}

		static void n_SetMaxPercent_F (IntPtr jnienv, IntPtr native__this, float maxPercent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxPercent (maxPercent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='setMaxPercent' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMaxPercent", "(F)V", "GetSetMaxPercent_FHandler")]
		public virtual unsafe void SetMaxPercent (float maxPercent)
		{
			const string __id = "setMaxPercent.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxPercent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaxWidth_I;
#pragma warning disable 0169
		static Delegate GetSetMaxWidth_IHandler ()
		{
			if (cb_setMaxWidth_I == null)
				cb_setMaxWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxWidth_I);
			return cb_setMaxWidth_I;
		}

		static void n_SetMaxWidth_I (IntPtr jnienv, IntPtr native__this, int maxWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxWidth (maxWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='setMaxWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxWidth", "(I)V", "GetSetMaxWidth_IHandler")]
		public virtual unsafe void SetMaxWidth (int maxWidth)
		{
			const string __id = "setMaxWidth.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinWidth_I;
#pragma warning disable 0169
		static Delegate GetSetMinWidth_IHandler ()
		{
			if (cb_setMinWidth_I == null)
				cb_setMinWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMinWidth_I);
			return cb_setMinWidth_I;
		}

		static void n_SetMinWidth_I (IntPtr jnienv, IntPtr native__this, int minWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinWidth (minWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogRootLayout']/method[@name='setMinWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMinWidth", "(I)V", "GetSetMinWidth_IHandler")]
		public virtual unsafe void SetMinWidth (int minWidth)
		{
			const string __id = "setMinWidth.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
