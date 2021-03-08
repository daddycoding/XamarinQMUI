using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Alpha {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaFrameLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/alpha/QMUIAlphaFrameLayout", DoNotGenerateAcw=true)]
	public partial class QMUIAlphaFrameLayout : global::Android.Widget.FrameLayout, global::Com.Qmuiteam.Qmui.Alpha.IQMUIAlphaViewInf {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/alpha/QMUIAlphaFrameLayout", typeof (QMUIAlphaFrameLayout));
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

		protected QMUIAlphaFrameLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaFrameLayout']/constructor[@name='QMUIAlphaFrameLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIAlphaFrameLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaFrameLayout']/constructor[@name='QMUIAlphaFrameLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIAlphaFrameLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaFrameLayout']/constructor[@name='QMUIAlphaFrameLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIAlphaFrameLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeAlphaWhenDisable (changeAlphaWhenDisable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaFrameLayout']/method[@name='setChangeAlphaWhenDisable' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeAlphaWhenPress (changeAlphaWhenPress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/class[@name='QMUIAlphaFrameLayout']/method[@name='setChangeAlphaWhenPress' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
