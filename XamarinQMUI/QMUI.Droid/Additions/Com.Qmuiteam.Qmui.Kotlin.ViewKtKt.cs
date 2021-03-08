using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Kotlin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='ViewKtKt']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/kotlin/ViewKtKt", DoNotGenerateAcw=true)]
	public sealed partial class ViewKtKt : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/kotlin/ViewKtKt", typeof (ViewKtKt));
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

		internal ViewKtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='ViewKtKt']/method[@name='clearSkin' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clearSkin", "(Landroid/view/View;)V", "")]
		public static unsafe void ClearSkin (global::Android.Views.View obj)
		{
			const string __id = "clearSkin.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
