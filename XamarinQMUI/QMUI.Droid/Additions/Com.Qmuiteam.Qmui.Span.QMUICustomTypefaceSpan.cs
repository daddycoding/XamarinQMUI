using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Span {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUICustomTypefaceSpan']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/span/QMUICustomTypefaceSpan", DoNotGenerateAcw=true)]
	public partial class QMUICustomTypefaceSpan : global::Android.Text.Style.TypefaceSpan {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUICustomTypefaceSpan']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/span/QMUICustomTypefaceSpan", typeof (QMUICustomTypefaceSpan));
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

		protected QMUICustomTypefaceSpan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUICustomTypefaceSpan']/constructor[@name='QMUICustomTypefaceSpan' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Typeface']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/graphics/Typeface;)V", "")]
		public unsafe QMUICustomTypefaceSpan (string family, global::Android.Graphics.Typeface type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Landroid/graphics/Typeface;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_family = JNIEnv.NewString (family);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_family);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_family);
				global::System.GC.KeepAlive (type);
			}
		}

	}
}
