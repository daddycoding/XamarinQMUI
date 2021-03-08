using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='IWindowInsetKeyboardConsumer']"
	[Register ("com/qmuiteam/qmui/widget/IWindowInsetKeyboardConsumer", "", "Com.Qmuiteam.Qmui.Widget.IWindowInsetKeyboardConsumerInvoker")]
	public partial interface IWindowInsetKeyboardConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='IWindowInsetKeyboardConsumer']/method[@name='onHandleKeyboard' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onHandleKeyboard", "(I)V", "GetOnHandleKeyboard_IHandler:Com.Qmuiteam.Qmui.Widget.IWindowInsetKeyboardConsumerInvoker, QMUI.Droid")]
		void OnHandleKeyboard (int keyboardInset);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/IWindowInsetKeyboardConsumer", DoNotGenerateAcw=true)]
	internal partial class IWindowInsetKeyboardConsumerInvoker : global::Java.Lang.Object, IWindowInsetKeyboardConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/IWindowInsetKeyboardConsumer", typeof (IWindowInsetKeyboardConsumerInvoker));

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

		public static IWindowInsetKeyboardConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWindowInsetKeyboardConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.IWindowInsetKeyboardConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWindowInsetKeyboardConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onHandleKeyboard_I;
#pragma warning disable 0169
		static Delegate GetOnHandleKeyboard_IHandler ()
		{
			if (cb_onHandleKeyboard_I == null)
				cb_onHandleKeyboard_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnHandleKeyboard_I);
			return cb_onHandleKeyboard_I;
		}

		static void n_OnHandleKeyboard_I (IntPtr jnienv, IntPtr native__this, int keyboardInset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.IWindowInsetKeyboardConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleKeyboard (keyboardInset);
		}
#pragma warning restore 0169

		IntPtr id_onHandleKeyboard_I;
		public unsafe void OnHandleKeyboard (int keyboardInset)
		{
			if (id_onHandleKeyboard_I == IntPtr.Zero)
				id_onHandleKeyboard_I = JNIEnv.GetMethodID (class_ref, "onHandleKeyboard", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (keyboardInset);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandleKeyboard_I, __args);
		}

	}

}
