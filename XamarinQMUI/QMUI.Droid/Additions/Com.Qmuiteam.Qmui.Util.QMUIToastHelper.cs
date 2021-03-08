using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIToastHelper", DoNotGenerateAcw=true)]
	public partial class QMUIToastHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper.FixCallback']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIToastHelper$FixCallback", DoNotGenerateAcw=true)]
		public partial class FixCallback : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIToastHelper$FixCallback", typeof (FixCallback));
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

			protected FixCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper.FixCallback']/constructor[@name='QMUIToastHelper.FixCallback' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
			[Register (".ctor", "(Landroid/os/Handler;)V", "")]
			public unsafe FixCallback (global::Android.OS.Handler handler)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/os/Handler;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (handler);
				}
			}

			static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
			static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
			{
				if (cb_handleMessage_Landroid_os_Message_ == null)
					cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
				return cb_handleMessage_Landroid_os_Message_;
			}

			static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIToastHelper.FixCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HandleMessage (msg);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper.FixCallback']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
			[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
			public virtual unsafe bool HandleMessage (global::Android.OS.Message msg)
			{
				const string __id = "handleMessage.(Landroid/os/Message;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (msg);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper.FixRunnable']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIToastHelper$FixRunnable", DoNotGenerateAcw=true)]
		public partial class FixRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIToastHelper$FixRunnable", typeof (FixRunnable));
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

			protected FixRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper.FixRunnable']/constructor[@name='QMUIToastHelper.FixRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register (".ctor", "(Ljava/lang/Runnable;)V", "")]
			public unsafe FixRunnable (global::Java.Lang.IRunnable runnable)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Runnable;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (runnable);
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIToastHelper.FixRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper.FixRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIToastHelper", typeof (QMUIToastHelper));
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

		protected QMUIToastHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper']/constructor[@name='QMUIToastHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIToastHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIToastHelper']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.widget.Toast']]"
		[Register ("show", "(Landroid/widget/Toast;)V", "")]
		public static unsafe void Show (global::Android.Widget.Toast toast)
		{
			const string __id = "show.(Landroid/widget/Toast;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((toast == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toast).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (toast);
			}
		}

	}
}
