using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Alpha {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaViewHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/alpha/QMUIAlphaViewHelper", DoNotGenerateAcw=true)]
	public partial class QMUIAlphaViewHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/alpha/QMUIAlphaViewHelper", typeof (QMUIAlphaViewHelper));
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

		protected QMUIAlphaViewHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaViewHelper']/constructor[@name='QMUIAlphaViewHelper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe QMUIAlphaViewHelper (global::Android.Views.View target)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaViewHelper']/constructor[@name='QMUIAlphaViewHelper' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register (".ctor", "(Landroid/view/View;FF)V", "")]
		public unsafe QMUIAlphaViewHelper (global::Android.Views.View target, float pressedAlpha, float disabledAlpha)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;FF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (pressedAlpha);
				__args [2] = new JniArgumentValue (disabledAlpha);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onEnabledChanged_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetOnEnabledChanged_Landroid_view_View_ZHandler ()
		{
			if (cb_onEnabledChanged_Landroid_view_View_Z == null)
				cb_onEnabledChanged_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnEnabledChanged_Landroid_view_View_Z);
			return cb_onEnabledChanged_Landroid_view_View_Z;
		}

		static void n_OnEnabledChanged_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_current, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var current = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_current, JniHandleOwnership.DoNotTransfer);
			__this.OnEnabledChanged (current, enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaViewHelper']/method[@name='onEnabledChanged' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("onEnabledChanged", "(Landroid/view/View;Z)V", "GetOnEnabledChanged_Landroid_view_View_ZHandler")]
		public virtual unsafe void OnEnabledChanged (global::Android.Views.View current, bool enabled)
		{
			const string __id = "onEnabledChanged.(Landroid/view/View;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((current == null) ? IntPtr.Zero : ((global::Java.Lang.Object) current).Handle);
				__args [1] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (current);
			}
		}

		static Delegate cb_onPressedChanged_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetOnPressedChanged_Landroid_view_View_ZHandler ()
		{
			if (cb_onPressedChanged_Landroid_view_View_Z == null)
				cb_onPressedChanged_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnPressedChanged_Landroid_view_View_Z);
			return cb_onPressedChanged_Landroid_view_View_Z;
		}

		static void n_OnPressedChanged_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_current, bool pressed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var current = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_current, JniHandleOwnership.DoNotTransfer);
			__this.OnPressedChanged (current, pressed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaViewHelper']/method[@name='onPressedChanged' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("onPressedChanged", "(Landroid/view/View;Z)V", "GetOnPressedChanged_Landroid_view_View_ZHandler")]
		public virtual unsafe void OnPressedChanged (global::Android.Views.View current, bool pressed)
		{
			const string __id = "onPressedChanged.(Landroid/view/View;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((current == null) ? IntPtr.Zero : ((global::Java.Lang.Object) current).Handle);
				__args [1] = new JniArgumentValue (pressed);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (current);
			}
		}

		static Delegate cb_setChangeAlphaWhenDisable_Z;
#pragma warning disable 0169
		static Delegate GetSetChangeAlphaWhenDisable_ZHandler ()
		{
			if (cb_setChangeAlphaWhenDisable_Z == null)
				cb_setChangeAlphaWhenDisable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetChangeAlphaWhenDisable_Z);
			return cb_setChangeAlphaWhenDisable_Z;
		}

		static void n_SetChangeAlphaWhenDisable_Z (IntPtr jnienv, IntPtr native__this, bool changeAlphaWhenDisable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeAlphaWhenDisable (changeAlphaWhenDisable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaViewHelper']/method[@name='setChangeAlphaWhenDisable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChangeAlphaWhenDisable", "(Z)V", "GetSetChangeAlphaWhenDisable_ZHandler")]
		public virtual unsafe void SetChangeAlphaWhenDisable (bool changeAlphaWhenDisable)
		{
			const string __id = "setChangeAlphaWhenDisable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (changeAlphaWhenDisable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setChangeAlphaWhenPress_Z;
#pragma warning disable 0169
		static Delegate GetSetChangeAlphaWhenPress_ZHandler ()
		{
			if (cb_setChangeAlphaWhenPress_Z == null)
				cb_setChangeAlphaWhenPress_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetChangeAlphaWhenPress_Z);
			return cb_setChangeAlphaWhenPress_Z;
		}

		static void n_SetChangeAlphaWhenPress_Z (IntPtr jnienv, IntPtr native__this, bool changeAlphaWhenPress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeAlphaWhenPress (changeAlphaWhenPress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaViewHelper']/method[@name='setChangeAlphaWhenPress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChangeAlphaWhenPress", "(Z)V", "GetSetChangeAlphaWhenPress_ZHandler")]
		public virtual unsafe void SetChangeAlphaWhenPress (bool changeAlphaWhenPress)
		{
			const string __id = "setChangeAlphaWhenPress.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (changeAlphaWhenPress);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
