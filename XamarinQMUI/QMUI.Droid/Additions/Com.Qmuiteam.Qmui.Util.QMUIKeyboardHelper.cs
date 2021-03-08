using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIKeyboardHelper", DoNotGenerateAcw=true)]
	public partial class QMUIKeyboardHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/field[@name='KEYBOARD_VISIBLE_THRESHOLD_DP']"
		[Register ("KEYBOARD_VISIBLE_THRESHOLD_DP")]
		public const int KeyboardVisibleThresholdDp = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/field[@name='SHOW_KEYBOARD_DELAY_TIME']"
		[Register ("SHOW_KEYBOARD_DELAY_TIME")]
		public const int ShowKeyboardDelayTime = (int) 200;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.util']/interface[@name='QMUIKeyboardHelper.KeyboardVisibilityEventListener']"
		[Register ("com/qmuiteam/qmui/util/QMUIKeyboardHelper$KeyboardVisibilityEventListener", "", "Com.Qmuiteam.Qmui.Util.QMUIKeyboardHelper/IKeyboardVisibilityEventListenerInvoker")]
		public partial interface IKeyboardVisibilityEventListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/interface[@name='QMUIKeyboardHelper.KeyboardVisibilityEventListener']/method[@name='onVisibilityChanged' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
			[Register ("onVisibilityChanged", "(ZI)Z", "GetOnVisibilityChanged_ZIHandler:Com.Qmuiteam.Qmui.Util.QMUIKeyboardHelper/IKeyboardVisibilityEventListenerInvoker, QMUI.Droid")]
			bool OnVisibilityChanged (bool isOpen, int heightDiff);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIKeyboardHelper$KeyboardVisibilityEventListener", DoNotGenerateAcw=true)]
		internal partial class IKeyboardVisibilityEventListenerInvoker : global::Java.Lang.Object, IKeyboardVisibilityEventListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIKeyboardHelper$KeyboardVisibilityEventListener", typeof (IKeyboardVisibilityEventListenerInvoker));

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

			public static IKeyboardVisibilityEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IKeyboardVisibilityEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.util.QMUIKeyboardHelper.KeyboardVisibilityEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IKeyboardVisibilityEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onVisibilityChanged_ZI;
#pragma warning disable 0169
			static Delegate GetOnVisibilityChanged_ZIHandler ()
			{
				if (cb_onVisibilityChanged_ZI == null)
					cb_onVisibilityChanged_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZI_Z) n_OnVisibilityChanged_ZI);
				return cb_onVisibilityChanged_ZI;
			}

			static bool n_OnVisibilityChanged_ZI (IntPtr jnienv, IntPtr native__this, bool isOpen, int heightDiff)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIKeyboardHelper.IKeyboardVisibilityEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnVisibilityChanged (isOpen, heightDiff);
			}
#pragma warning restore 0169

			IntPtr id_onVisibilityChanged_ZI;
			public unsafe bool OnVisibilityChanged (bool isOpen, int heightDiff)
			{
				if (id_onVisibilityChanged_ZI == IntPtr.Zero)
					id_onVisibilityChanged_ZI = JNIEnv.GetMethodID (class_ref, "onVisibilityChanged", "(ZI)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (isOpen);
				__args [1] = new JValue (heightDiff);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onVisibilityChanged_ZI, __args);
			}

		}

		// event args for com.qmuiteam.qmui.util.QMUIKeyboardHelper.KeyboardVisibilityEventListener.onVisibilityChanged
		public partial class KeyboardVisibilityEventEventArgs : global::System.EventArgs {

			public KeyboardVisibilityEventEventArgs (bool handled, bool isOpen, int heightDiff)
			{
				this.handled = handled;
				this.isOpen = isOpen;
				this.heightDiff = heightDiff;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			bool isOpen;
			public bool IsOpen {
				get { return isOpen; }
			}

			int heightDiff;
			public int HeightDiff {
				get { return heightDiff; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/util/QMUIKeyboardHelper_KeyboardVisibilityEventListenerImplementor")]
		internal sealed partial class IKeyboardVisibilityEventListenerImplementor : global::Java.Lang.Object, IKeyboardVisibilityEventListener {

			object sender;

			public IKeyboardVisibilityEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/util/QMUIKeyboardHelper_KeyboardVisibilityEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<KeyboardVisibilityEventEventArgs> Handler;
#pragma warning restore 0649

			public bool OnVisibilityChanged (bool isOpen, int heightDiff)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new KeyboardVisibilityEventEventArgs (true, isOpen, heightDiff);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IKeyboardVisibilityEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIKeyboardHelper", typeof (QMUIKeyboardHelper));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected QMUIKeyboardHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/constructor[@name='QMUIKeyboardHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIKeyboardHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/method[@name='findKeyboardAreaConsumer' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("findKeyboardAreaConsumer", "(Landroid/view/View;)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View FindKeyboardAreaConsumer (global::Android.Views.View view)
		{
			const string __id = "findKeyboardAreaConsumer.(Landroid/view/View;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/method[@name='hideKeyboard' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("hideKeyboard", "(Landroid/view/View;)Z", "")]
		public static unsafe bool HideKeyboard (global::Android.Views.View view)
		{
			const string __id = "hideKeyboard.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/method[@name='isKeyboardVisible' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("isKeyboardVisible", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool IsKeyboardVisible (global::Android.App.Activity activity)
		{
			const string __id = "isKeyboardVisible.(Landroid/app/Activity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/method[@name='setVisibilityEventListener' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.qmuiteam.qmui.util.QMUIKeyboardHelper.KeyboardVisibilityEventListener']]"
		[Register ("setVisibilityEventListener", "(Landroid/app/Activity;Lcom/qmuiteam/qmui/util/QMUIKeyboardHelper$KeyboardVisibilityEventListener;)V", "")]
		public static unsafe void SetVisibilityEventListener (global::Android.App.Activity activity, global::Com.Qmuiteam.Qmui.Util.QMUIKeyboardHelper.IKeyboardVisibilityEventListener listener)
		{
			const string __id = "setVisibilityEventListener.(Landroid/app/Activity;Lcom/qmuiteam/qmui/util/QMUIKeyboardHelper$KeyboardVisibilityEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/method[@name='showKeyboard' and count(parameter)=2 and parameter[1][@type='android.widget.EditText'] and parameter[2][@type='boolean']]"
		[Register ("showKeyboard", "(Landroid/widget/EditText;Z)V", "")]
		public static unsafe void ShowKeyboard (global::Android.Widget.EditText editText, bool delay)
		{
			const string __id = "showKeyboard.(Landroid/widget/EditText;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((editText == null) ? IntPtr.Zero : ((global::Java.Lang.Object) editText).Handle);
				__args [1] = new JniArgumentValue (delay);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (editText);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIKeyboardHelper']/method[@name='showKeyboard' and count(parameter)=2 and parameter[1][@type='android.widget.EditText'] and parameter[2][@type='int']]"
		[Register ("showKeyboard", "(Landroid/widget/EditText;I)V", "")]
		public static unsafe void ShowKeyboard (global::Android.Widget.EditText editText, int delay)
		{
			const string __id = "showKeyboard.(Landroid/widget/EditText;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((editText == null) ? IntPtr.Zero : ((global::Java.Lang.Object) editText).Handle);
				__args [1] = new JniArgumentValue (delay);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (editText);
			}
		}

	}
}
