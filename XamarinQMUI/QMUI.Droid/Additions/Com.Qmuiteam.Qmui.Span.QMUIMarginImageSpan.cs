using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Span {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIMarginImageSpan']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/span/QMUIMarginImageSpan", DoNotGenerateAcw=true)]
	public partial class QMUIMarginImageSpan : global::Com.Qmuiteam.Qmui.Span.QMUIAlignMiddleImageSpan {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/span/QMUIMarginImageSpan", typeof (QMUIMarginImageSpan));
		internal static new IntPtr class_ref {
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

		protected QMUIMarginImageSpan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIMarginImageSpan']/constructor[@name='QMUIMarginImageSpan' and count(parameter)=4 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;III)V", "")]
		public unsafe QMUIMarginImageSpan (global::Android.Graphics.Drawables.Drawable d, int verticalAlignment, int marginLeft, int marginRight)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				__args [1] = new JniArgumentValue (verticalAlignment);
				__args [2] = new JniArgumentValue (marginLeft);
				__args [3] = new JniArgumentValue (marginRight);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIMarginImageSpan']/constructor[@name='QMUIMarginImageSpan' and count(parameter)=5 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;IIII)V", "")]
		public unsafe QMUIMarginImageSpan (global::Android.Graphics.Drawables.Drawable d, int verticalAlignment, int marginLeft, int marginRight, int offsetY)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				__args [1] = new JniArgumentValue (verticalAlignment);
				__args [2] = new JniArgumentValue (marginLeft);
				__args [3] = new JniArgumentValue (marginRight);
				__args [4] = new JniArgumentValue (offsetY);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

	}
}
