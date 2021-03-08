using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIConfig']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/QMUIConfig", DoNotGenerateAcw=true)]
	public partial class QMUIConfig : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				const string __id = "DEBUG.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "DEBUG.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/QMUIConfig", typeof (QMUIConfig));
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

		protected QMUIConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIConfig']/constructor[@name='QMUIConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIConfig ()
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

	}
}
