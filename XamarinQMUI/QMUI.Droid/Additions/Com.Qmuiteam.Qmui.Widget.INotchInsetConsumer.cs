using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='INotchInsetConsumer']"
	[Register ("com/qmuiteam/qmui/widget/INotchInsetConsumer", "", "Com.Qmuiteam.Qmui.Widget.INotchInsetConsumerInvoker")]
	public partial interface INotchInsetConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='INotchInsetConsumer']/method[@name='notifyInsetMaybeChanged' and count(parameter)=0]"
		[Register ("notifyInsetMaybeChanged", "()Z", "GetNotifyInsetMaybeChangedHandler:Com.Qmuiteam.Qmui.Widget.INotchInsetConsumerInvoker, QMUI.Droid")]
		bool NotifyInsetMaybeChanged ();

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/INotchInsetConsumer", DoNotGenerateAcw=true)]
	internal partial class INotchInsetConsumerInvoker : global::Java.Lang.Object, INotchInsetConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/INotchInsetConsumer", typeof (INotchInsetConsumerInvoker));

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

		public static INotchInsetConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INotchInsetConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.INotchInsetConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INotchInsetConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_notifyInsetMaybeChanged;
#pragma warning disable 0169
		static Delegate GetNotifyInsetMaybeChangedHandler ()
		{
			if (cb_notifyInsetMaybeChanged == null)
				cb_notifyInsetMaybeChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NotifyInsetMaybeChanged);
			return cb_notifyInsetMaybeChanged;
		}

		static bool n_NotifyInsetMaybeChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.INotchInsetConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyInsetMaybeChanged ();
		}
#pragma warning restore 0169

		IntPtr id_notifyInsetMaybeChanged;
		public unsafe bool NotifyInsetMaybeChanged ()
		{
			if (id_notifyInsetMaybeChanged == IntPtr.Zero)
				id_notifyInsetMaybeChanged = JNIEnv.GetMethodID (class_ref, "notifyInsetMaybeChanged", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_notifyInsetMaybeChanged);
		}

	}

}
