using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Kotlin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DebounceAction']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/kotlin/DebounceAction", DoNotGenerateAcw=true)]
	public sealed partial class DebounceAction : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/kotlin/DebounceAction", typeof (DebounceAction));
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

		internal DebounceAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DebounceAction']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DebounceAction']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "")]
		public unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
