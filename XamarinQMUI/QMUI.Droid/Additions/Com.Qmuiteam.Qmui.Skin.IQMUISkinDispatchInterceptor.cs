using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinDispatchInterceptor']"
	[Register ("com/qmuiteam/qmui/skin/IQMUISkinDispatchInterceptor", "", "Com.Qmuiteam.Qmui.Skin.IQMUISkinDispatchInterceptorInvoker")]
	public partial interface IQMUISkinDispatchInterceptor : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinDispatchInterceptor']/method[@name='intercept' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.res.Resources.Theme']]"
		[Register ("intercept", "(ILandroid/content/res/Resources$Theme;)Z", "GetIntercept_ILandroid_content_res_Resources_Theme_Handler:Com.Qmuiteam.Qmui.Skin.IQMUISkinDispatchInterceptorInvoker, QMUI.Droid")]
		bool Intercept (int p0, global::Android.Content.Res.Resources.Theme p1);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/IQMUISkinDispatchInterceptor", DoNotGenerateAcw=true)]
	internal partial class IQMUISkinDispatchInterceptorInvoker : global::Java.Lang.Object, IQMUISkinDispatchInterceptor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/IQMUISkinDispatchInterceptor", typeof (IQMUISkinDispatchInterceptorInvoker));

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

		public static IQMUISkinDispatchInterceptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUISkinDispatchInterceptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.IQMUISkinDispatchInterceptor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUISkinDispatchInterceptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_intercept_ILandroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetIntercept_ILandroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_intercept_ILandroid_content_res_Resources_Theme_ == null)
				cb_intercept_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_Intercept_ILandroid_content_res_Resources_Theme_);
			return cb_intercept_ILandroid_content_res_Resources_Theme_;
		}

		static bool n_Intercept_ILandroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.IQMUISkinDispatchInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Intercept (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_intercept_ILandroid_content_res_Resources_Theme_;
		public unsafe bool Intercept (int p0, global::Android.Content.Res.Resources.Theme p1)
		{
			if (id_intercept_ILandroid_content_res_Resources_Theme_ == IntPtr.Zero)
				id_intercept_ILandroid_content_res_Resources_Theme_ = JNIEnv.GetMethodID (class_ref, "intercept", "(ILandroid/content/res/Resources$Theme;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_intercept_ILandroid_content_res_Resources_Theme_, __args);
			return __ret;
		}

	}

}
