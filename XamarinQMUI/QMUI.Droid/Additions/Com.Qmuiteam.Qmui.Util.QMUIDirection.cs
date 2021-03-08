using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDirection']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIDirection", DoNotGenerateAcw=true)]
	public sealed partial class QMUIDirection : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDirection']/field[@name='BOTTOM_TO_TOP']"
		[Register ("BOTTOM_TO_TOP")]
		public static global::Com.Qmuiteam.Qmui.Util.QMUIDirection BottomToTop {
			get {
				const string __id = "BOTTOM_TO_TOP.Lcom/qmuiteam/qmui/util/QMUIDirection;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDirection']/field[@name='LEFT_TO_RIGHT']"
		[Register ("LEFT_TO_RIGHT")]
		public static global::Com.Qmuiteam.Qmui.Util.QMUIDirection LeftToRight {
			get {
				const string __id = "LEFT_TO_RIGHT.Lcom/qmuiteam/qmui/util/QMUIDirection;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDirection']/field[@name='RIGHT_TO_LEFT']"
		[Register ("RIGHT_TO_LEFT")]
		public static global::Com.Qmuiteam.Qmui.Util.QMUIDirection RightToLeft {
			get {
				const string __id = "RIGHT_TO_LEFT.Lcom/qmuiteam/qmui/util/QMUIDirection;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDirection']/field[@name='TOP_TO_BOTTOM']"
		[Register ("TOP_TO_BOTTOM")]
		public static global::Com.Qmuiteam.Qmui.Util.QMUIDirection TopToBottom {
			get {
				const string __id = "TOP_TO_BOTTOM.Lcom/qmuiteam/qmui/util/QMUIDirection;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIDirection", typeof (QMUIDirection));
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

		internal QMUIDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/util/QMUIDirection;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Util.QMUIDirection ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/qmuiteam/qmui/util/QMUIDirection;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDirection']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/qmuiteam/qmui/util/QMUIDirection;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Util.QMUIDirection[] Values ()
		{
			const string __id = "values.()[Lcom/qmuiteam/qmui/util/QMUIDirection;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Qmuiteam.Qmui.Util.QMUIDirection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qmuiteam.Qmui.Util.QMUIDirection));
			} finally {
			}
		}

	}
}
