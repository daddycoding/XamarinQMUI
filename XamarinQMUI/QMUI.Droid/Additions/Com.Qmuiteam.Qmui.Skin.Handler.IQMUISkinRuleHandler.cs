using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.Handler {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/interface[@name='IQMUISkinRuleHandler']"
	[Register ("com/qmuiteam/qmui/skin/handler/IQMUISkinRuleHandler", "", "Com.Qmuiteam.Qmui.Skin.Handler.IQMUISkinRuleHandlerInvoker")]
	public partial interface IQMUISkinRuleHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/interface[@name='IQMUISkinRuleHandler']/method[@name='handle' and count(parameter)=5 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;Landroid/view/View;Landroid/content/res/Resources$Theme;Ljava/lang/String;I)V", "GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_IHandler:Com.Qmuiteam.Qmui.Skin.Handler.IQMUISkinRuleHandlerInvoker, QMUI.Droid")]
		void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager p0, global::Android.Views.View p1, global::Android.Content.Res.Resources.Theme p2, string p3, int p4);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/IQMUISkinRuleHandler", DoNotGenerateAcw=true)]
	internal partial class IQMUISkinRuleHandlerInvoker : global::Java.Lang.Object, IQMUISkinRuleHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/IQMUISkinRuleHandler", typeof (IQMUISkinRuleHandlerInvoker));

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

		public static IQMUISkinRuleHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUISkinRuleHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.handler.IQMUISkinRuleHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUISkinRuleHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_IHandler ()
		{
			if (cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I == null)
				cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLI_V) n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I);
			return cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I;
		}

		static void n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.Handler.IQMUISkinRuleHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I;
		public unsafe void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager p0, global::Android.Views.View p1, global::Android.Content.Res.Resources.Theme p2, string p3, int p4)
		{
			if (id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I == IntPtr.Zero)
				id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;Landroid/view/View;Landroid/content/res/Resources$Theme;Ljava/lang/String;I)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

}
