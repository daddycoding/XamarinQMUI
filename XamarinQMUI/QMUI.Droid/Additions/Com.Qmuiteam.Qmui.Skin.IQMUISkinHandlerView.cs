using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinHandlerView']"
	[Register ("com/qmuiteam/qmui/skin/IQMUISkinHandlerView", "", "Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerViewInvoker")]
	public partial interface IQMUISkinHandlerView : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinHandlerView']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='androidx.collection.SimpleArrayMap&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V", "GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_Handler:Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerViewInvoker, QMUI.Droid")]
		void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager p0, int p1, global::Android.Content.Res.Resources.Theme p2, global::AndroidX.Collection.SimpleArrayMap p3);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/IQMUISkinHandlerView", DoNotGenerateAcw=true)]
	internal partial class IQMUISkinHandlerViewInvoker : global::Java.Lang.Object, IQMUISkinHandlerView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/IQMUISkinHandlerView", typeof (IQMUISkinHandlerViewInvoker));

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

		public static IQMUISkinHandlerView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUISkinHandlerView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.IQMUISkinHandlerView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUISkinHandlerViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_;
#pragma warning disable 0169
		static Delegate GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_Handler ()
		{
			if (cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ == null)
				cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_V) n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_);
			return cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_;
		}

		static void n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_;
		public unsafe void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager p0, int p1, global::Android.Content.Res.Resources.Theme p2, global::AndroidX.Collection.SimpleArrayMap p3)
		{
			if (id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ == IntPtr.Zero)
				id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ = JNIEnv.GetMethodID (class_ref, "handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_, __args);
		}

	}

}
