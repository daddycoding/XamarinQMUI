using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIWindowHelper", DoNotGenerateAcw=true)]
	public partial class QMUIWindowHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowHelper']/field[@name='KEYBOARD_HEIGHT_BOUNDARY_DP']"
		[Register ("KEYBOARD_HEIGHT_BOUNDARY_DP")]
		public const int KeyboardHeightBoundaryDp = (int) 100;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIWindowHelper", typeof (QMUIWindowHelper));
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

		protected QMUIWindowHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowHelper']/constructor[@name='QMUIWindowHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIWindowHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowHelper']/method[@name='getAttachInfoFromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getAttachInfoFromView", "(Landroid/view/View;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetAttachInfoFromView (global::Android.Views.View view)
		{
			const string __id = "getAttachInfoFromView.(Landroid/view/View;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowHelper']/method[@name='setWindowType' and count(parameter)=1 and parameter[1][@type='android.view.WindowManager.LayoutParams']]"
		[Register ("setWindowType", "(Landroid/view/WindowManager$LayoutParams;)V", "")]
		public static unsafe void SetWindowType (global::Android.Views.WindowManagerLayoutParams layoutParams)
		{
			const string __id = "setWindowType.(Landroid/view/WindowManager$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (layoutParams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowHelper']/method[@name='unSafeGetContentInsets' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("unSafeGetContentInsets", "(Landroid/view/View;)Landroid/graphics/Rect;", "")]
		public static unsafe global::Android.Graphics.Rect UnSafeGetContentInsets (global::Android.Views.View view)
		{
			const string __id = "unSafeGetContentInsets.(Landroid/view/View;)Landroid/graphics/Rect;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowHelper']/method[@name='unSafeGetWindowVisibleInsets' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("unSafeGetWindowVisibleInsets", "(Landroid/view/View;)Landroid/graphics/Rect;", "")]
		public static unsafe global::Android.Graphics.Rect UnSafeGetWindowVisibleInsets (global::Android.Views.View view)
		{
			const string __id = "unSafeGetWindowVisibleInsets.(Landroid/view/View;)Landroid/graphics/Rect;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
