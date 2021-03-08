using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Textview {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='ISpanTouchFix']"
	[Register ("com/qmuiteam/qmui/widget/textview/ISpanTouchFix", "", "Com.Qmuiteam.Qmui.Widget.Textview.ISpanTouchFixInvoker")]
	public partial interface ISpanTouchFix : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='ISpanTouchFix']/method[@name='setTouchSpanHit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTouchSpanHit", "(Z)V", "GetSetTouchSpanHit_ZHandler:Com.Qmuiteam.Qmui.Widget.Textview.ISpanTouchFixInvoker, QMUI.Droid")]
		void SetTouchSpanHit (bool hit);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/textview/ISpanTouchFix", DoNotGenerateAcw=true)]
	internal partial class ISpanTouchFixInvoker : global::Java.Lang.Object, ISpanTouchFix {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/textview/ISpanTouchFix", typeof (ISpanTouchFixInvoker));

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

		public static ISpanTouchFix GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpanTouchFix> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.textview.ISpanTouchFix"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpanTouchFixInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setTouchSpanHit_Z;
#pragma warning disable 0169
		static Delegate GetSetTouchSpanHit_ZHandler ()
		{
			if (cb_setTouchSpanHit_Z == null)
				cb_setTouchSpanHit_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTouchSpanHit_Z);
			return cb_setTouchSpanHit_Z;
		}

		static void n_SetTouchSpanHit_Z (IntPtr jnienv, IntPtr native__this, bool hit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.ISpanTouchFix> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTouchSpanHit (hit);
		}
#pragma warning restore 0169

		IntPtr id_setTouchSpanHit_Z;
		public unsafe void SetTouchSpanHit (bool hit)
		{
			if (id_setTouchSpanHit_Z == IntPtr.Zero)
				id_setTouchSpanHit_Z = JNIEnv.GetMethodID (class_ref, "setTouchSpanHit", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (hit);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTouchSpanHit_Z, __args);
		}

	}

}
