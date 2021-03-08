using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='IWindowInsetLayout']"
	[Register ("com/qmuiteam/qmui/widget/IWindowInsetLayout", "", "Com.Qmuiteam.Qmui.Widget.IWindowInsetLayoutInvoker")]
	public partial interface IWindowInsetLayout : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='IWindowInsetLayout']/method[@name='applySystemWindowInsets19' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("applySystemWindowInsets19", "(Landroid/graphics/Rect;)Z", "GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler:Com.Qmuiteam.Qmui.Widget.IWindowInsetLayoutInvoker, QMUI.Droid")]
		bool ApplySystemWindowInsets19 (global::Android.Graphics.Rect p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='IWindowInsetLayout']/method[@name='applySystemWindowInsets21' and count(parameter)=1 and parameter[1][@type='androidx.core.view.WindowInsetsCompat']]"
		[Register ("applySystemWindowInsets21", "(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", "GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler:Com.Qmuiteam.Qmui.Widget.IWindowInsetLayoutInvoker, QMUI.Droid")]
		global::AndroidX.Core.View.WindowInsetsCompat ApplySystemWindowInsets21 (global::AndroidX.Core.View.WindowInsetsCompat p0);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/IWindowInsetLayout", DoNotGenerateAcw=true)]
	internal partial class IWindowInsetLayoutInvoker : global::Java.Lang.Object, IWindowInsetLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/IWindowInsetLayout", typeof (IWindowInsetLayoutInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IWindowInsetLayout GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWindowInsetLayout> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.IWindowInsetLayout"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWindowInsetLayoutInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler ()
		{
			if (cb_applySystemWindowInsets19_Landroid_graphics_Rect_ == null)
				cb_applySystemWindowInsets19_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ApplySystemWindowInsets19_Landroid_graphics_Rect_);
			return cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
		}

		static bool n_ApplySystemWindowInsets19_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.IWindowInsetLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ApplySystemWindowInsets19 (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_applySystemWindowInsets19_Landroid_graphics_Rect_;
		public unsafe bool ApplySystemWindowInsets19 (global::Android.Graphics.Rect p0)
		{
			if (id_applySystemWindowInsets19_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_applySystemWindowInsets19_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "applySystemWindowInsets19", "(Landroid/graphics/Rect;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_applySystemWindowInsets19_Landroid_graphics_Rect_, __args);
			return __ret;
		}

		static Delegate cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler ()
		{
			if (cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ == null)
				cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_);
			return cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
		}

		static IntPtr n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.IWindowInsetLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplySystemWindowInsets21 (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
		public unsafe global::AndroidX.Core.View.WindowInsetsCompat ApplySystemWindowInsets21 (global::AndroidX.Core.View.WindowInsetsCompat p0)
		{
			if (id_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ == IntPtr.Zero)
				id_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ = JNIEnv.GetMethodID (class_ref, "applySystemWindowInsets21", "(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
