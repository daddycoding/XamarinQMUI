using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIWindowInsetHelper", DoNotGenerateAcw=true)]
	public partial class QMUIWindowInsetHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIWindowInsetHelper", typeof (QMUIWindowInsetHelper));
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

		protected QMUIWindowInsetHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/constructor[@name='QMUIWindowInsetHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIWindowInsetHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='addHandleContainer' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.view.ViewGroup&gt;']]"
		[Register ("addHandleContainer", "(Ljava/lang/Class;)V", "")]
		public static unsafe void AddHandleContainer (global::Java.Lang.Class clazz)
		{
			const string __id = "addHandleContainer.(Ljava/lang/Class;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("apply", "(Landroid/view/ViewGroup;)V", "")]
		public static unsafe void Apply (global::Android.Views.ViewGroup viewGroup)
		{
			const string __id = "apply.(Landroid/view/ViewGroup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((viewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewGroup).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (viewGroup);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='computeInsets' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.Rect']]"
		[Register ("computeInsets", "(Landroid/view/View;Landroid/graphics/Rect;)V", "")]
		public static unsafe void ComputeInsets (global::Android.Views.View view, global::Android.Graphics.Rect insets)
		{
			const string __id = "computeInsets.(Landroid/view/View;Landroid/graphics/Rect;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (insets);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='computeInsetsWithConstraint' and count(parameter)=2 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("computeInsetsWithConstraint", "(Landroid/graphics/Rect;Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void ComputeInsetsWithConstraint (global::Android.Graphics.Rect insets, global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams lp)
		{
			const string __id = "computeInsetsWithConstraint.(Landroid/graphics/Rect;Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				__args [1] = new JniArgumentValue ((lp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lp).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (insets);
				global::System.GC.KeepAlive (lp);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='computeInsetsWithGravity' and count(parameter)=2 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("computeInsetsWithGravity", "(Landroid/graphics/Rect;Landroid/view/ViewGroup$LayoutParams;)V", "")]
		public static unsafe void ComputeInsetsWithGravity (global::Android.Graphics.Rect insets, global::Android.Views.ViewGroup.LayoutParams lp)
		{
			const string __id = "computeInsetsWithGravity.(Landroid/graphics/Rect;Landroid/view/ViewGroup$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				__args [1] = new JniArgumentValue ((lp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lp).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (insets);
				global::System.GC.KeepAlive (lp);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='defaultApplySystemWindowInsets19' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.graphics.Rect']]"
		[Register ("defaultApplySystemWindowInsets19", "(Landroid/view/ViewGroup;Landroid/graphics/Rect;)Z", "")]
		public static unsafe bool DefaultApplySystemWindowInsets19 (global::Android.Views.ViewGroup viewGroup, global::Android.Graphics.Rect insets)
		{
			const string __id = "defaultApplySystemWindowInsets19.(Landroid/view/ViewGroup;Landroid/graphics/Rect;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((viewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewGroup).Handle);
				__args [1] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (viewGroup);
				global::System.GC.KeepAlive (insets);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='defaultApplySystemWindowInsets21' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='androidx.core.view.WindowInsetsCompat']]"
		[Register ("defaultApplySystemWindowInsets21", "(Landroid/view/ViewGroup;Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", "")]
		public static unsafe global::AndroidX.Core.View.WindowInsetsCompat DefaultApplySystemWindowInsets21 (global::Android.Views.ViewGroup viewGroup, global::AndroidX.Core.View.WindowInsetsCompat insets)
		{
			const string __id = "defaultApplySystemWindowInsets21.(Landroid/view/ViewGroup;Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((viewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewGroup).Handle);
				__args [1] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (viewGroup);
				global::System.GC.KeepAlive (insets);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='isHandleContainer' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("isHandleContainer", "(Landroid/view/View;)Z", "")]
		public static unsafe bool IsHandleContainer (global::Android.Views.View child)
		{
			const string __id = "isHandleContainer.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (child);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIWindowInsetHelper']/method[@name='jumpDispatch' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("jumpDispatch", "(Landroid/view/View;)Z", "")]
		public static unsafe bool JumpDispatch (global::Android.Views.View child)
		{
			const string __id = "jumpDispatch.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (child);
			}
		}

	}
}
