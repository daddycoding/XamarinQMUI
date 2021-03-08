using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinApplyListener']"
	[Register ("com/qmuiteam/qmui/skin/IQMUISkinApplyListener", "", "Com.Qmuiteam.Qmui.Skin.IQMUISkinApplyListenerInvoker")]
	public partial interface IQMUISkinApplyListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='IQMUISkinApplyListener']/method[@name='onApply' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme']]"
		[Register ("onApply", "(Landroid/view/View;ILandroid/content/res/Resources$Theme;)V", "GetOnApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_Handler:Com.Qmuiteam.Qmui.Skin.IQMUISkinApplyListenerInvoker, QMUI.Droid")]
		void OnApply (global::Android.Views.View p0, int p1, global::Android.Content.Res.Resources.Theme p2);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/IQMUISkinApplyListener", DoNotGenerateAcw=true)]
	internal partial class IQMUISkinApplyListenerInvoker : global::Java.Lang.Object, IQMUISkinApplyListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/IQMUISkinApplyListener", typeof (IQMUISkinApplyListenerInvoker));

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

		public static IQMUISkinApplyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUISkinApplyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.IQMUISkinApplyListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUISkinApplyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetOnApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_ == null)
				cb_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_);
			return cb_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_;
		}

		static void n_OnApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.IQMUISkinApplyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnApply (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_;
		public unsafe void OnApply (global::Android.Views.View p0, int p1, global::Android.Content.Res.Resources.Theme p2)
		{
			if (id_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_ == IntPtr.Zero)
				id_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_ = JNIEnv.GetMethodID (class_ref, "onApply", "(Landroid/view/View;ILandroid/content/res/Resources$Theme;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApply_Landroid_view_View_ILandroid_content_res_Resources_Theme_, __args);
		}

	}

	// event args for com.qmuiteam.qmui.skin.IQMUISkinApplyListener.onApply
	public partial class QMUISkinApplyEventArgs : global::System.EventArgs {

		public QMUISkinApplyEventArgs (global::Android.Views.View p0, int p1, global::Android.Content.Res.Resources.Theme p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Android.Views.View p0;
		public global::Android.Views.View P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::Android.Content.Res.Resources.Theme p2;
		public global::Android.Content.Res.Resources.Theme P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/skin/IQMUISkinApplyListenerImplementor")]
	internal sealed partial class IQMUISkinApplyListenerImplementor : global::Java.Lang.Object, IQMUISkinApplyListener {

		object sender;

		public IQMUISkinApplyListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/skin/IQMUISkinApplyListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<QMUISkinApplyEventArgs> Handler;
#pragma warning restore 0649

		public void OnApply (global::Android.Views.View p0, int p1, global::Android.Content.Res.Resources.Theme p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new QMUISkinApplyEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IQMUISkinApplyListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
