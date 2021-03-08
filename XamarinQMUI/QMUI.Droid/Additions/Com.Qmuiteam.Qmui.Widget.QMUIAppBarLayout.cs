using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAppBarLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIAppBarLayout", DoNotGenerateAcw=true)]
	public partial class QMUIAppBarLayout : global::Google.Android.Material.AppBar.AppBarLayout, global::Com.Qmuiteam.Qmui.Widget.IWindowInsetLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIAppBarLayout", typeof (QMUIAppBarLayout));
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

		protected QMUIAppBarLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAppBarLayout']/constructor[@name='QMUIAppBarLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIAppBarLayout (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAppBarLayout']/constructor[@name='QMUIAppBarLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIAppBarLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler ()
		{
			if (cb_applySystemWindowInsets19_Landroid_graphics_Rect_ == null)
				cb_applySystemWindowInsets19_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ApplySystemWindowInsets19_Landroid_graphics_Rect_);
			return cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
		}

		static bool n_ApplySystemWindowInsets19_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAppBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_insets, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ApplySystemWindowInsets19 (insets);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAppBarLayout']/method[@name='applySystemWindowInsets19' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("applySystemWindowInsets19", "(Landroid/graphics/Rect;)Z", "GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler")]
		public virtual unsafe bool ApplySystemWindowInsets19 (global::Android.Graphics.Rect insets)
		{
			const string __id = "applySystemWindowInsets19.(Landroid/graphics/Rect;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

		static Delegate cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler ()
		{
			if (cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ == null)
				cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_);
			return cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
		}

		static IntPtr n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAppBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (native_insets, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplySystemWindowInsets21 (insets));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAppBarLayout']/method[@name='applySystemWindowInsets21' and count(parameter)=1 and parameter[1][@type='androidx.core.view.WindowInsetsCompat']]"
		[Register ("applySystemWindowInsets21", "(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", "GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler")]
		public virtual unsafe global::AndroidX.Core.View.WindowInsetsCompat ApplySystemWindowInsets21 (global::AndroidX.Core.View.WindowInsetsCompat insets)
		{
			const string __id = "applySystemWindowInsets21.(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

	}
}
