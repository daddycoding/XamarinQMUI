using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Span {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.span']/interface[@name='QMUIOnSpanClickListener']"
	[Register ("com/qmuiteam/qmui/span/QMUIOnSpanClickListener", "", "Com.Qmuiteam.Qmui.Span.IQMUIOnSpanClickListenerInvoker")]
	public partial interface IQMUIOnSpanClickListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/interface[@name='QMUIOnSpanClickListener']/method[@name='onSpanClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSpanClick", "(Ljava/lang/String;)Z", "GetOnSpanClick_Ljava_lang_String_Handler:Com.Qmuiteam.Qmui.Span.IQMUIOnSpanClickListenerInvoker, QMUI.Droid")]
		bool OnSpanClick (string text);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/span/QMUIOnSpanClickListener", DoNotGenerateAcw=true)]
	internal partial class IQMUIOnSpanClickListenerInvoker : global::Java.Lang.Object, IQMUIOnSpanClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/span/QMUIOnSpanClickListener", typeof (IQMUIOnSpanClickListenerInvoker));

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

		public static IQMUIOnSpanClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUIOnSpanClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.span.QMUIOnSpanClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUIOnSpanClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSpanClick_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSpanClick_Ljava_lang_String_Handler ()
		{
			if (cb_onSpanClick_Ljava_lang_String_ == null)
				cb_onSpanClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_OnSpanClick_Ljava_lang_String_);
			return cb_onSpanClick_Ljava_lang_String_;
		}

		static bool n_OnSpanClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.IQMUIOnSpanClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSpanClick (text);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onSpanClick_Ljava_lang_String_;
		public unsafe bool OnSpanClick (string text)
		{
			if (id_onSpanClick_Ljava_lang_String_ == IntPtr.Zero)
				id_onSpanClick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSpanClick", "(Ljava/lang/String;)Z");
			IntPtr native_text = JNIEnv.NewString (text);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_text);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSpanClick_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_text);
			return __ret;
		}

	}

	// event args for com.qmuiteam.qmui.span.QMUIOnSpanClickListener.onSpanClick
	public partial class QMUIOnSpanClickEventArgs : global::System.EventArgs {

		public QMUIOnSpanClickEventArgs (bool handled, string text)
		{
			this.handled = handled;
			this.text = text;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		string text;
		public string Text {
			get { return text; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/span/QMUIOnSpanClickListenerImplementor")]
	internal sealed partial class IQMUIOnSpanClickListenerImplementor : global::Java.Lang.Object, IQMUIOnSpanClickListener {

		object sender;

		public IQMUIOnSpanClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/span/QMUIOnSpanClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<QMUIOnSpanClickEventArgs> Handler;
#pragma warning restore 0649

		public bool OnSpanClick (string text)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new QMUIOnSpanClickEventArgs (true, text);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IQMUIOnSpanClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
