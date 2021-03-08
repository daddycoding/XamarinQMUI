using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Textview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView", DoNotGenerateAcw=true)]
	public partial class QMUILinkTextView : global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaTextView, global::Com.Qmuiteam.Qmui.Span.IQMUIOnSpanClickListener {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/field[@name='AUTO_LINK_MASK_REQUIRED']"
		[Register ("AUTO_LINK_MASK_REQUIRED")]
		public static int AutoLinkMaskRequired {
			get {
				const string __id = "AUTO_LINK_MASK_REQUIRED.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "AUTO_LINK_MASK_REQUIRED.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='QMUILinkTextView.OnLinkClickListener']"
		[Register ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkClickListener", "", "Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView/IOnLinkClickListenerInvoker")]
		public partial interface IOnLinkClickListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='QMUILinkTextView.OnLinkClickListener']/method[@name='onMailLinkClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onMailLinkClick", "(Ljava/lang/String;)V", "GetOnMailLinkClick_Ljava_lang_String_Handler:Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView/IOnLinkClickListenerInvoker, QMUI.Droid")]
			void OnMailLinkClick (string mailAddress);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='QMUILinkTextView.OnLinkClickListener']/method[@name='onTelLinkClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onTelLinkClick", "(Ljava/lang/String;)V", "GetOnTelLinkClick_Ljava_lang_String_Handler:Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView/IOnLinkClickListenerInvoker, QMUI.Droid")]
			void OnTelLinkClick (string phoneNumber);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='QMUILinkTextView.OnLinkClickListener']/method[@name='onWebUrlLinkClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebUrlLinkClick", "(Ljava/lang/String;)V", "GetOnWebUrlLinkClick_Ljava_lang_String_Handler:Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView/IOnLinkClickListenerInvoker, QMUI.Droid")]
			void OnWebUrlLinkClick (string url);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkClickListener", DoNotGenerateAcw=true)]
		internal partial class IOnLinkClickListenerInvoker : global::Java.Lang.Object, IOnLinkClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkClickListener", typeof (IOnLinkClickListenerInvoker));

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

			public static IOnLinkClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnLinkClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnLinkClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMailLinkClick_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnMailLinkClick_Ljava_lang_String_Handler ()
			{
				if (cb_onMailLinkClick_Ljava_lang_String_ == null)
					cb_onMailLinkClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMailLinkClick_Ljava_lang_String_);
				return cb_onMailLinkClick_Ljava_lang_String_;
			}

			static void n_OnMailLinkClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mailAddress)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var mailAddress = JNIEnv.GetString (native_mailAddress, JniHandleOwnership.DoNotTransfer);
				__this.OnMailLinkClick (mailAddress);
			}
#pragma warning restore 0169

			IntPtr id_onMailLinkClick_Ljava_lang_String_;
			public unsafe void OnMailLinkClick (string mailAddress)
			{
				if (id_onMailLinkClick_Ljava_lang_String_ == IntPtr.Zero)
					id_onMailLinkClick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMailLinkClick", "(Ljava/lang/String;)V");
				IntPtr native_mailAddress = JNIEnv.NewString (mailAddress);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mailAddress);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMailLinkClick_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_mailAddress);
			}

			static Delegate cb_onTelLinkClick_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnTelLinkClick_Ljava_lang_String_Handler ()
			{
				if (cb_onTelLinkClick_Ljava_lang_String_ == null)
					cb_onTelLinkClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTelLinkClick_Ljava_lang_String_);
				return cb_onTelLinkClick_Ljava_lang_String_;
			}

			static void n_OnTelLinkClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_phoneNumber)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var phoneNumber = JNIEnv.GetString (native_phoneNumber, JniHandleOwnership.DoNotTransfer);
				__this.OnTelLinkClick (phoneNumber);
			}
#pragma warning restore 0169

			IntPtr id_onTelLinkClick_Ljava_lang_String_;
			public unsafe void OnTelLinkClick (string phoneNumber)
			{
				if (id_onTelLinkClick_Ljava_lang_String_ == IntPtr.Zero)
					id_onTelLinkClick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onTelLinkClick", "(Ljava/lang/String;)V");
				IntPtr native_phoneNumber = JNIEnv.NewString (phoneNumber);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_phoneNumber);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTelLinkClick_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_phoneNumber);
			}

			static Delegate cb_onWebUrlLinkClick_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebUrlLinkClick_Ljava_lang_String_Handler ()
			{
				if (cb_onWebUrlLinkClick_Ljava_lang_String_ == null)
					cb_onWebUrlLinkClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnWebUrlLinkClick_Ljava_lang_String_);
				return cb_onWebUrlLinkClick_Ljava_lang_String_;
			}

			static void n_OnWebUrlLinkClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
				__this.OnWebUrlLinkClick (url);
			}
#pragma warning restore 0169

			IntPtr id_onWebUrlLinkClick_Ljava_lang_String_;
			public unsafe void OnWebUrlLinkClick (string url)
			{
				if (id_onWebUrlLinkClick_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebUrlLinkClick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebUrlLinkClick", "(Ljava/lang/String;)V");
				IntPtr native_url = JNIEnv.NewString (url);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_url);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebUrlLinkClick_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_url);
			}

		}

		// event args for com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkClickListener.onMailLinkClick
		public partial class MailLinkClickEventArgs : global::System.EventArgs {

			public MailLinkClickEventArgs (string mailAddress)
			{
				this.mailAddress = mailAddress;
			}

			string mailAddress;
			public string MailAddress {
				get { return mailAddress; }
			}
		}

		// event args for com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkClickListener.onTelLinkClick
		public partial class TelLinkClickEventArgs : global::System.EventArgs {

			public TelLinkClickEventArgs (string phoneNumber)
			{
				this.phoneNumber = phoneNumber;
			}

			string phoneNumber;
			public string PhoneNumber {
				get { return phoneNumber; }
			}
		}

		// event args for com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkClickListener.onWebUrlLinkClick
		public partial class WebUrlLinkClickEventArgs : global::System.EventArgs {

			public WebUrlLinkClickEventArgs (string url)
			{
				this.url = url;
			}

			string url;
			public string Url {
				get { return url; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/textview/QMUILinkTextView_OnLinkClickListenerImplementor")]
		internal sealed partial class IOnLinkClickListenerImplementor : global::Java.Lang.Object, IOnLinkClickListener {

			object sender;

			public IOnLinkClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/textview/QMUILinkTextView_OnLinkClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MailLinkClickEventArgs> OnMailLinkClickHandler;
#pragma warning restore 0649

			public void OnMailLinkClick (string mailAddress)
			{
				var __h = OnMailLinkClickHandler;
				if (__h != null)
					__h (sender, new MailLinkClickEventArgs (mailAddress));
			}
#pragma warning disable 0649
			public EventHandler<TelLinkClickEventArgs> OnTelLinkClickHandler;
#pragma warning restore 0649

			public void OnTelLinkClick (string phoneNumber)
			{
				var __h = OnTelLinkClickHandler;
				if (__h != null)
					__h (sender, new TelLinkClickEventArgs (phoneNumber));
			}
#pragma warning disable 0649
			public EventHandler<WebUrlLinkClickEventArgs> OnWebUrlLinkClickHandler;
#pragma warning restore 0649

			public void OnWebUrlLinkClick (string url)
			{
				var __h = OnWebUrlLinkClickHandler;
				if (__h != null)
					__h (sender, new WebUrlLinkClickEventArgs (url));
			}

			internal static bool __IsEmpty (IOnLinkClickListenerImplementor value)
			{
				return value.OnMailLinkClickHandler == null && value.OnTelLinkClickHandler == null && value.OnWebUrlLinkClickHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='QMUILinkTextView.OnLinkLongClickListener']"
		[Register ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkLongClickListener", "", "Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView/IOnLinkLongClickListenerInvoker")]
		public partial interface IOnLinkLongClickListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/interface[@name='QMUILinkTextView.OnLinkLongClickListener']/method[@name='onLongClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onLongClick", "(Ljava/lang/String;)V", "GetOnLongClick_Ljava_lang_String_Handler:Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView/IOnLinkLongClickListenerInvoker, QMUI.Droid")]
			void OnLongClick (string text);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkLongClickListener", DoNotGenerateAcw=true)]
		internal partial class IOnLinkLongClickListenerInvoker : global::Java.Lang.Object, IOnLinkLongClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkLongClickListener", typeof (IOnLinkLongClickListenerInvoker));

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

			public static IOnLinkLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnLinkLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnLinkLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onLongClick_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnLongClick_Ljava_lang_String_Handler ()
			{
				if (cb_onLongClick_Ljava_lang_String_ == null)
					cb_onLongClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnLongClick_Ljava_lang_String_);
				return cb_onLongClick_Ljava_lang_String_;
			}

			static void n_OnLongClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				__this.OnLongClick (text);
			}
#pragma warning restore 0169

			IntPtr id_onLongClick_Ljava_lang_String_;
			public unsafe void OnLongClick (string text)
			{
				if (id_onLongClick_Ljava_lang_String_ == IntPtr.Zero)
					id_onLongClick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLongClick", "(Ljava/lang/String;)V");
				IntPtr native_text = JNIEnv.NewString (text);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_text);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLongClick_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_text);
			}

		}

		// event args for com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkLongClickListener.onLongClick
		public partial class LinkLongClickEventArgs : global::System.EventArgs {

			public LinkLongClickEventArgs (string text)
			{
				this.text = text;
			}

			string text;
			public string Text {
				get { return text; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/textview/QMUILinkTextView_OnLinkLongClickListenerImplementor")]
		internal sealed partial class IOnLinkLongClickListenerImplementor : global::Java.Lang.Object, IOnLinkLongClickListener {

			object sender;

			public IOnLinkLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/textview/QMUILinkTextView_OnLinkLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LinkLongClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnLongClick (string text)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new LinkLongClickEventArgs (text));
			}

			internal static bool __IsEmpty (IOnLinkLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/textview/QMUILinkTextView", typeof (QMUILinkTextView));
		internal static new IntPtr class_ref {
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

		protected QMUILinkTextView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/constructor[@name='QMUILinkTextView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUILinkTextView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/constructor[@name='QMUILinkTextView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.res.ColorStateList'] and parameter[3][@type='android.content.res.ColorStateList']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;)V", "")]
		public unsafe QMUILinkTextView (global::Android.Content.Context context, global::Android.Content.Res.ColorStateList linkTextColor, global::Android.Content.Res.ColorStateList linkBgColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((linkTextColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkTextColor).Handle);
				__args [2] = new JniArgumentValue ((linkBgColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkBgColor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (linkTextColor);
				global::System.GC.KeepAlive (linkBgColor);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/constructor[@name='QMUILinkTextView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUILinkTextView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getAutoLinkMaskCompat;
#pragma warning disable 0169
		static Delegate GetGetAutoLinkMaskCompatHandler ()
		{
			if (cb_getAutoLinkMaskCompat == null)
				cb_getAutoLinkMaskCompat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAutoLinkMaskCompat);
			return cb_getAutoLinkMaskCompat;
		}

		static int n_GetAutoLinkMaskCompat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoLinkMaskCompat;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoLinkMaskCompat_I;
#pragma warning disable 0169
		static Delegate GetSetAutoLinkMaskCompat_IHandler ()
		{
			if (cb_setAutoLinkMaskCompat_I == null)
				cb_setAutoLinkMaskCompat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAutoLinkMaskCompat_I);
			return cb_setAutoLinkMaskCompat_I;
		}

		static void n_SetAutoLinkMaskCompat_I (IntPtr jnienv, IntPtr native__this, int mask)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoLinkMaskCompat = mask;
		}
#pragma warning restore 0169

		public virtual unsafe int AutoLinkMaskCompat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='getAutoLinkMaskCompat' and count(parameter)=0]"
			[Register ("getAutoLinkMaskCompat", "()I", "GetGetAutoLinkMaskCompatHandler")]
			get {
				const string __id = "getAutoLinkMaskCompat.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='setAutoLinkMaskCompat' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAutoLinkMaskCompat", "(I)V", "GetSetAutoLinkMaskCompat_IHandler")]
			set {
				const string __id = "setAutoLinkMaskCompat.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addAutoLinkMaskCompat_I;
#pragma warning disable 0169
		static Delegate GetAddAutoLinkMaskCompat_IHandler ()
		{
			if (cb_addAutoLinkMaskCompat_I == null)
				cb_addAutoLinkMaskCompat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_AddAutoLinkMaskCompat_I);
			return cb_addAutoLinkMaskCompat_I;
		}

		static void n_AddAutoLinkMaskCompat_I (IntPtr jnienv, IntPtr native__this, int mask)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddAutoLinkMaskCompat (mask);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='addAutoLinkMaskCompat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addAutoLinkMaskCompat", "(I)V", "GetAddAutoLinkMaskCompat_IHandler")]
		public virtual unsafe void AddAutoLinkMaskCompat (int mask)
		{
			const string __id = "addAutoLinkMaskCompat.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mask);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSpanClick (text);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='onSpanClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSpanClick", "(Ljava/lang/String;)Z", "GetOnSpanClick_Ljava_lang_String_Handler")]
		public virtual unsafe bool OnSpanClick (string text)
		{
			const string __id = "onSpanClick.(Ljava/lang/String;)Z";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_performSpanLongClick_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPerformSpanLongClick_Ljava_lang_String_Handler ()
		{
			if (cb_performSpanLongClick_Ljava_lang_String_ == null)
				cb_performSpanLongClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_PerformSpanLongClick_Ljava_lang_String_);
			return cb_performSpanLongClick_Ljava_lang_String_;
		}

		static bool n_PerformSpanLongClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PerformSpanLongClick (text);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='performSpanLongClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("performSpanLongClick", "(Ljava/lang/String;)Z", "GetPerformSpanLongClick_Ljava_lang_String_Handler")]
		protected virtual unsafe bool PerformSpanLongClick (string text)
		{
			const string __id = "performSpanLongClick.(Ljava/lang/String;)Z";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_removeAutoLinkMaskCompat_I;
#pragma warning disable 0169
		static Delegate GetRemoveAutoLinkMaskCompat_IHandler ()
		{
			if (cb_removeAutoLinkMaskCompat_I == null)
				cb_removeAutoLinkMaskCompat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_RemoveAutoLinkMaskCompat_I);
			return cb_removeAutoLinkMaskCompat_I;
		}

		static void n_RemoveAutoLinkMaskCompat_I (IntPtr jnienv, IntPtr native__this, int mask)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAutoLinkMaskCompat (mask);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='removeAutoLinkMaskCompat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeAutoLinkMaskCompat", "(I)V", "GetRemoveAutoLinkMaskCompat_IHandler")]
		public virtual unsafe void RemoveAutoLinkMaskCompat (int mask)
		{
			const string __id = "removeAutoLinkMaskCompat.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mask);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLinkColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetLinkColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setLinkColor_Landroid_content_res_ColorStateList_ == null)
				cb_setLinkColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLinkColor_Landroid_content_res_ColorStateList_);
			return cb_setLinkColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetLinkColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_linkTextColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var linkTextColor = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_linkTextColor, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkColor (linkTextColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='setLinkColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setLinkColor", "(Landroid/content/res/ColorStateList;)V", "GetSetLinkColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetLinkColor (global::Android.Content.Res.ColorStateList linkTextColor)
		{
			const string __id = "setLinkColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((linkTextColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkTextColor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (linkTextColor);
			}
		}

		static Delegate cb_setOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_Handler ()
		{
			if (cb_setOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_ == null)
				cb_setOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_);
			return cb_setOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_;
		}

		static void n_SetOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onLinkClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onLinkClickListener = (global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener> (native_onLinkClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnLinkClickListener (onLinkClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='setOnLinkClickListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkClickListener']]"
		[Register ("setOnLinkClickListener", "(Lcom/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkClickListener;)V", "GetSetOnLinkClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkClickListener_Handler")]
		public virtual unsafe void SetOnLinkClickListener (global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener onLinkClickListener)
		{
			const string __id = "setOnLinkClickListener.(Lcom/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onLinkClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onLinkClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onLinkClickListener);
			}
		}

		static Delegate cb_setOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_Handler ()
		{
			if (cb_setOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_ == null)
				cb_setOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_);
			return cb_setOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_;
		}

		static void n_SetOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onLinkLongClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onLinkLongClickListener = (global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListener> (native_onLinkLongClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnLinkLongClickListener (onLinkLongClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.textview']/class[@name='QMUILinkTextView']/method[@name='setOnLinkLongClickListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.textview.QMUILinkTextView.OnLinkLongClickListener']]"
		[Register ("setOnLinkLongClickListener", "(Lcom/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkLongClickListener;)V", "GetSetOnLinkLongClickListener_Lcom_qmuiteam_qmui_widget_textview_QMUILinkTextView_OnLinkLongClickListener_Handler")]
		public virtual unsafe void SetOnLinkLongClickListener (global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListener onLinkLongClickListener)
		{
			const string __id = "setOnLinkLongClickListener.(Lcom/qmuiteam/qmui/widget/textview/QMUILinkTextView$OnLinkLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onLinkLongClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onLinkLongClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onLinkLongClickListener);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.MailLinkClickEventArgs> MailLinkClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor>(
						ref weak_implementor_SetOnLinkClickListener,
						__CreateIOnLinkClickListenerImplementor,
						SetOnLinkClickListener,
						__h => __h.OnMailLinkClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor>(
						ref weak_implementor_SetOnLinkClickListener,
						global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor.__IsEmpty,
						__v => SetOnLinkClickListener (null),
						__h => __h.OnMailLinkClickHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.TelLinkClickEventArgs> TelLinkClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor>(
						ref weak_implementor_SetOnLinkClickListener,
						__CreateIOnLinkClickListenerImplementor,
						SetOnLinkClickListener,
						__h => __h.OnTelLinkClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor>(
						ref weak_implementor_SetOnLinkClickListener,
						global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor.__IsEmpty,
						__v => SetOnLinkClickListener (null),
						__h => __h.OnTelLinkClickHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.WebUrlLinkClickEventArgs> WebUrlLinkClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor>(
						ref weak_implementor_SetOnLinkClickListener,
						__CreateIOnLinkClickListenerImplementor,
						SetOnLinkClickListener,
						__h => __h.OnWebUrlLinkClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor>(
						ref weak_implementor_SetOnLinkClickListener,
						global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor.__IsEmpty,
						__v => SetOnLinkClickListener (null),
						__h => __h.OnWebUrlLinkClickHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnLinkClickListener;

		global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor __CreateIOnLinkClickListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.LinkLongClickEventArgs> LinkLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListenerImplementor>(
						ref weak_implementor_SetOnLinkLongClickListener,
						__CreateIOnLinkLongClickListenerImplementor,
						SetOnLinkLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListener, global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListenerImplementor>(
						ref weak_implementor_SetOnLinkLongClickListener,
						global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListenerImplementor.__IsEmpty,
						__v => SetOnLinkLongClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnLinkLongClickListener;

		global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListenerImplementor __CreateIOnLinkLongClickListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Textview.QMUILinkTextView.IOnLinkLongClickListenerImplementor (this);
		}
#endregion
	}
}
