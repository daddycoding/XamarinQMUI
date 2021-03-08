using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Alpha {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/interface[@name='QMUIAlphaViewInf']"
	[Register ("com/qmuiteam/qmui/alpha/QMUIAlphaViewInf", "", "Com.Qmuiteam.Qmui.Alpha.IQMUIAlphaViewInfInvoker")]
	public partial interface IQMUIAlphaViewInf : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/interface[@name='QMUIAlphaViewInf']/method[@name='setChangeAlphaWhenDisable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChangeAlphaWhenDisable", "(Z)V", "GetSetChangeAlphaWhenDisable_ZHandler:Com.Qmuiteam.Qmui.Alpha.IQMUIAlphaViewInfInvoker, QMUI.Droid")]
		void SetChangeAlphaWhenDisable (bool changeAlphaWhenDisable);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.alpha']/interface[@name='QMUIAlphaViewInf']/method[@name='setChangeAlphaWhenPress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChangeAlphaWhenPress", "(Z)V", "GetSetChangeAlphaWhenPress_ZHandler:Com.Qmuiteam.Qmui.Alpha.IQMUIAlphaViewInfInvoker, QMUI.Droid")]
		void SetChangeAlphaWhenPress (bool changeAlphaWhenPress);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/alpha/QMUIAlphaViewInf", DoNotGenerateAcw=true)]
	internal partial class IQMUIAlphaViewInfInvoker : global::Java.Lang.Object, IQMUIAlphaViewInf {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/alpha/QMUIAlphaViewInf", typeof (IQMUIAlphaViewInfInvoker));

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

		public static IQMUIAlphaViewInf GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUIAlphaViewInf> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.alpha.QMUIAlphaViewInf"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUIAlphaViewInfInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setChangeAlphaWhenDisable_Z;
#pragma warning disable 0169
		static Delegate GetSetChangeAlphaWhenDisable_ZHandler ()
		{
			if (cb_setChangeAlphaWhenDisable_Z == null)
				cb_setChangeAlphaWhenDisable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetChangeAlphaWhenDisable_Z);
			return cb_setChangeAlphaWhenDisable_Z;
		}

		static void n_SetChangeAlphaWhenDisable_Z (IntPtr jnienv, IntPtr native__this, bool changeAlphaWhenDisable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.IQMUIAlphaViewInf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeAlphaWhenDisable (changeAlphaWhenDisable);
		}
#pragma warning restore 0169

		IntPtr id_setChangeAlphaWhenDisable_Z;
		public unsafe void SetChangeAlphaWhenDisable (bool changeAlphaWhenDisable)
		{
			if (id_setChangeAlphaWhenDisable_Z == IntPtr.Zero)
				id_setChangeAlphaWhenDisable_Z = JNIEnv.GetMethodID (class_ref, "setChangeAlphaWhenDisable", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (changeAlphaWhenDisable);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChangeAlphaWhenDisable_Z, __args);
		}

		static Delegate cb_setChangeAlphaWhenPress_Z;
#pragma warning disable 0169
		static Delegate GetSetChangeAlphaWhenPress_ZHandler ()
		{
			if (cb_setChangeAlphaWhenPress_Z == null)
				cb_setChangeAlphaWhenPress_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetChangeAlphaWhenPress_Z);
			return cb_setChangeAlphaWhenPress_Z;
		}

		static void n_SetChangeAlphaWhenPress_Z (IntPtr jnienv, IntPtr native__this, bool changeAlphaWhenPress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.IQMUIAlphaViewInf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeAlphaWhenPress (changeAlphaWhenPress);
		}
#pragma warning restore 0169

		IntPtr id_setChangeAlphaWhenPress_Z;
		public unsafe void SetChangeAlphaWhenPress (bool changeAlphaWhenPress)
		{
			if (id_setChangeAlphaWhenPress_Z == IntPtr.Zero)
				id_setChangeAlphaWhenPress_Z = JNIEnv.GetMethodID (class_ref, "setChangeAlphaWhenPress", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (changeAlphaWhenPress);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChangeAlphaWhenPress_Z, __args);
		}

	}

}
