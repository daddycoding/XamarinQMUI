using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIActivityLifecycleCallbacks", DoNotGenerateAcw=true)]
	public abstract partial class QMUIActivityLifecycleCallbacks : global::Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIActivityLifecycleCallbacks", typeof (QMUIActivityLifecycleCallbacks));
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

		protected QMUIActivityLifecycleCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/constructor[@name='QMUIActivityLifecycleCallbacks' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe QMUIActivityLifecycleCallbacks (global::Android.App.Activity targetActivity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetActivity).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (targetActivity);
			}
		}

		static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (activity, savedInstanceState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivityCreated (global::Android.App.Activity activity, global::Android.OS.Bundle savedInstanceState)
		{
			const string __id = "onActivityCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((savedInstanceState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) savedInstanceState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (savedInstanceState);
			}
		}

		static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActivityDestroyed_Landroid_app_Activity_);
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityDestroyed (global::Android.App.Activity activity)
		{
			const string __id = "onActivityDestroyed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActivityPaused_Landroid_app_Activity_);
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityPaused (global::Android.App.Activity activity)
		{
			const string __id = "onActivityPaused.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActivityResumed_Landroid_app_Activity_);
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityResumed (global::Android.App.Activity activity)
		{
			const string __id = "onActivityResumed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_outState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var outState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_outState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (activity, outState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivitySaveInstanceState (global::Android.App.Activity activity, global::Android.OS.Bundle outState)
		{
			const string __id = "onActivitySaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((outState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (outState);
			}
		}

		static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActivityStarted_Landroid_app_Activity_);
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStarted (global::Android.App.Activity activity)
		{
			const string __id = "onActivityStarted.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActivityStopped_Landroid_app_Activity_);
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStopped (global::Android.App.Activity activity)
		{
			const string __id = "onActivityStopped.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_onTargetActivityDestroyed;
#pragma warning disable 0169
		static Delegate GetOnTargetActivityDestroyedHandler ()
		{
			if (cb_onTargetActivityDestroyed == null)
				cb_onTargetActivityDestroyed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTargetActivityDestroyed);
			return cb_onTargetActivityDestroyed;
		}

		static void n_OnTargetActivityDestroyed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIActivityLifecycleCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTargetActivityDestroyed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onTargetActivityDestroyed' and count(parameter)=0]"
		[Register ("onTargetActivityDestroyed", "()V", "GetOnTargetActivityDestroyedHandler")]
		protected abstract void OnTargetActivityDestroyed ();

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIActivityLifecycleCallbacks", DoNotGenerateAcw=true)]
	internal partial class QMUIActivityLifecycleCallbacksInvoker : QMUIActivityLifecycleCallbacks {

		public QMUIActivityLifecycleCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIActivityLifecycleCallbacks", typeof (QMUIActivityLifecycleCallbacksInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIActivityLifecycleCallbacks']/method[@name='onTargetActivityDestroyed' and count(parameter)=0]"
		[Register ("onTargetActivityDestroyed", "()V", "GetOnTargetActivityDestroyedHandler")]
		protected override unsafe void OnTargetActivityDestroyed ()
		{
			const string __id = "onTargetActivityDestroyed.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
