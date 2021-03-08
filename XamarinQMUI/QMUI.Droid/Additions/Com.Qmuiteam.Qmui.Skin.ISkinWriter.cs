using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='SkinWriter']"
	[Register ("com/qmuiteam/qmui/skin/SkinWriter", "", "Com.Qmuiteam.Qmui.Skin.ISkinWriterInvoker")]
	public partial interface ISkinWriter : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='SkinWriter']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("write", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetWrite_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler:Com.Qmuiteam.Qmui.Skin.ISkinWriterInvoker, QMUI.Droid")]
		void Write (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/SkinWriter", DoNotGenerateAcw=true)]
	internal partial class ISkinWriterInvoker : global::Java.Lang.Object, ISkinWriter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/SkinWriter", typeof (ISkinWriterInvoker));

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

		public static ISkinWriter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISkinWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.SkinWriter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISkinWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_Write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.ISkinWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.Write (builder);
		}
#pragma warning restore 0169

		IntPtr id_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		public unsafe void Write (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			if (id_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == IntPtr.Zero)
				id_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_, __args);
		}

	}

}
