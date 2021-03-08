using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='IBlankTouchDetector']"
	[Register ("com/qmuiteam/qmui/widget/IBlankTouchDetector", "", "Com.Qmuiteam.Qmui.Widget.IBlankTouchDetectorInvoker")]
	public partial interface IBlankTouchDetector : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='IBlankTouchDetector']/method[@name='isTouchInBlank' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("isTouchInBlank", "(Landroid/view/MotionEvent;)Z", "GetIsTouchInBlank_Landroid_view_MotionEvent_Handler:Com.Qmuiteam.Qmui.Widget.IBlankTouchDetectorInvoker, QMUI.Droid")]
		bool IsTouchInBlank (global::Android.Views.MotionEvent p0);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/IBlankTouchDetector", DoNotGenerateAcw=true)]
	internal partial class IBlankTouchDetectorInvoker : global::Java.Lang.Object, IBlankTouchDetector {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/IBlankTouchDetector", typeof (IBlankTouchDetectorInvoker));

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

		public static IBlankTouchDetector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBlankTouchDetector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.IBlankTouchDetector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBlankTouchDetectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isTouchInBlank_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetIsTouchInBlank_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_isTouchInBlank_Landroid_view_MotionEvent_ == null)
				cb_isTouchInBlank_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsTouchInBlank_Landroid_view_MotionEvent_);
			return cb_isTouchInBlank_Landroid_view_MotionEvent_;
		}

		static bool n_IsTouchInBlank_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.IBlankTouchDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsTouchInBlank (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isTouchInBlank_Landroid_view_MotionEvent_;
		public unsafe bool IsTouchInBlank (global::Android.Views.MotionEvent p0)
		{
			if (id_isTouchInBlank_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_isTouchInBlank_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "isTouchInBlank", "(Landroid/view/MotionEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTouchInBlank_Landroid_view_MotionEvent_, __args);
			return __ret;
		}

	}

}
