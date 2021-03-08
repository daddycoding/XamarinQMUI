using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Link {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='ITouchableSpan']"
	[Register ("com/qmuiteam/qmui/link/ITouchableSpan", "", "Com.Qmuiteam.Qmui.Link.ITouchableSpanInvoker")]
	public partial interface ITouchableSpan : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='ITouchableSpan']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler:Com.Qmuiteam.Qmui.Link.ITouchableSpanInvoker, QMUI.Droid")]
		void OnClick (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/interface[@name='ITouchableSpan']/method[@name='setPressed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPressed", "(Z)V", "GetSetPressed_ZHandler:Com.Qmuiteam.Qmui.Link.ITouchableSpanInvoker, QMUI.Droid")]
		void SetPressed (bool pressed);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/link/ITouchableSpan", DoNotGenerateAcw=true)]
	internal partial class ITouchableSpanInvoker : global::Java.Lang.Object, ITouchableSpan {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/link/ITouchableSpan", typeof (ITouchableSpanInvoker));

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

		public static ITouchableSpan GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITouchableSpan> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.link.ITouchableSpan"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITouchableSpanInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.ITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onClick_Landroid_view_View_;
		public unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
		}

		static Delegate cb_setPressed_Z;
#pragma warning disable 0169
		static Delegate GetSetPressed_ZHandler ()
		{
			if (cb_setPressed_Z == null)
				cb_setPressed_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPressed_Z);
			return cb_setPressed_Z;
		}

		static void n_SetPressed_Z (IntPtr jnienv, IntPtr native__this, bool pressed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.ITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPressed (pressed);
		}
#pragma warning restore 0169

		IntPtr id_setPressed_Z;
		public unsafe void SetPressed (bool pressed)
		{
			if (id_setPressed_Z == IntPtr.Zero)
				id_setPressed_Z = JNIEnv.GetMethodID (class_ref, "setPressed", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (pressed);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPressed_Z, __args);
		}

	}

}
