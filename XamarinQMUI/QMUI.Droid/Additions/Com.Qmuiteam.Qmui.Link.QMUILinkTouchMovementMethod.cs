using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Link {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkTouchMovementMethod']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/link/QMUILinkTouchMovementMethod", DoNotGenerateAcw=true)]
	public partial class QMUILinkTouchMovementMethod : global::Android.Text.Method.LinkMovementMethod {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/link/QMUILinkTouchMovementMethod", typeof (QMUILinkTouchMovementMethod));
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

		protected QMUILinkTouchMovementMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkTouchMovementMethod']/constructor[@name='QMUILinkTouchMovementMethod' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUILinkTouchMovementMethod ()
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

		public static unsafe global::Android.Text.Method.IMovementMethod Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkTouchMovementMethod']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Landroid/text/method/MovementMethod;", "")]
			get {
				const string __id = "getInstance.()Landroid/text/method/MovementMethod;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Text.Method.IMovementMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
