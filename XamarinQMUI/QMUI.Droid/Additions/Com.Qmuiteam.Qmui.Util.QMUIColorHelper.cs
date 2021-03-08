using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIColorHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIColorHelper", DoNotGenerateAcw=true)]
	public partial class QMUIColorHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIColorHelper", typeof (QMUIColorHelper));
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

		protected QMUIColorHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIColorHelper']/constructor[@name='QMUIColorHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIColorHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIColorHelper']/method[@name='colorToString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("colorToString", "(I)Ljava/lang/String;", "")]
		public static unsafe string ColorToString (int color)
		{
			const string __id = "colorToString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIColorHelper']/method[@name='computeColor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("computeColor", "(IIF)I", "")]
		public static unsafe int ComputeColor (int fromColor, int toColor, float fraction)
		{
			const string __id = "computeColor.(IIF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (fromColor);
				__args [1] = new JniArgumentValue (toColor);
				__args [2] = new JniArgumentValue (fraction);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIColorHelper']/method[@name='setColorAlpha' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("setColorAlpha", "(IF)I", "")]
		public static unsafe int SetColorAlpha (int color, float alpha)
		{
			const string __id = "setColorAlpha.(IF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (alpha);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIColorHelper']/method[@name='setColorAlpha' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("setColorAlpha", "(IFZ)I", "")]
		public static unsafe int SetColorAlpha (int color, float alpha, bool @override)
		{
			const string __id = "setColorAlpha.(IFZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (alpha);
				__args [2] = new JniArgumentValue (@override);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
