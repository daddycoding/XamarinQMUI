using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinHandlerDecoration']"
	[Register ("com/qmuiteam/qmui/skin/IQMUISkinHandlerDecoration", "", "Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerDecorationInvoker")]
	public partial interface IQMUISkinHandlerDecoration : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinHandlerDecoration']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[3][@type='int'] and parameter[4][@type='android.content.res.Resources.Theme']]"
		[Register ("handle", "(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V", "GetHandle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler:Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerDecorationInvoker, QMUI.Droid")]
		void Handle (global::AndroidX.RecyclerView.Widget.RecyclerView p0, global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager p1, int p2, global::Android.Content.Res.Resources.Theme p3);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/IQMUISkinHandlerDecoration", DoNotGenerateAcw=true)]
	internal partial class IQMUISkinHandlerDecorationInvoker : global::Java.Lang.Object, IQMUISkinHandlerDecoration {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/IQMUISkinHandlerDecoration", typeof (IQMUISkinHandlerDecorationInvoker));

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

		public static IQMUISkinHandlerDecoration GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUISkinHandlerDecoration> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.IQMUISkinHandlerDecoration"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUISkinHandlerDecorationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetHandle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ == null)
				cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_V) n_Handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_);
			return cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
		}

		static void n_Handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
		public unsafe void Handle (global::AndroidX.RecyclerView.Widget.RecyclerView p0, global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager p1, int p2, global::Android.Content.Res.Resources.Theme p3)
		{
			if (id_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ == IntPtr.Zero)
				id_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ = JNIEnv.GetMethodID (class_ref, "handle", "(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_, __args);
		}

	}

}