using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebView", DoNotGenerateAcw=true)]
	public partial class QMUIWebView : global::Android.Webkit.WebView, global::Com.Qmuiteam.Qmui.Widget.IWindowInsetLayout {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/interface[@name='QMUIWebView.Callback']"
		[Register ("com/qmuiteam/qmui/widget/webview/QMUIWebView$Callback", "", "Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/interface[@name='QMUIWebView.Callback']/method[@name='onSureNotSupportChangeCssEnv' and count(parameter)=0]"
			[Register ("onSureNotSupportChangeCssEnv", "()V", "GetOnSureNotSupportChangeCssEnvHandler:Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView/ICallbackInvoker, QMUI.Droid")]
			void OnSureNotSupportChangeCssEnv ();

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebView$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebView$Callback", typeof (ICallbackInvoker));

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

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.webview.QMUIWebView.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSureNotSupportChangeCssEnv;
#pragma warning disable 0169
			static Delegate GetOnSureNotSupportChangeCssEnvHandler ()
			{
				if (cb_onSureNotSupportChangeCssEnv == null)
					cb_onSureNotSupportChangeCssEnv = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSureNotSupportChangeCssEnv);
				return cb_onSureNotSupportChangeCssEnv;
			}

			static void n_OnSureNotSupportChangeCssEnv (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSureNotSupportChangeCssEnv ();
			}
#pragma warning restore 0169

			IntPtr id_onSureNotSupportChangeCssEnv;
			public unsafe void OnSureNotSupportChangeCssEnv ()
			{
				if (id_onSureNotSupportChangeCssEnv == IntPtr.Zero)
					id_onSureNotSupportChangeCssEnv = JNIEnv.GetMethodID (class_ref, "onSureNotSupportChangeCssEnv", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSureNotSupportChangeCssEnv);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/interface[@name='QMUIWebView.OnScrollChangeListener']"
		[Register ("com/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener", "", "Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView/IOnScrollChangeListenerInvoker")]
		public partial interface IOnScrollChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/interface[@name='QMUIWebView.OnScrollChangeListener']/method[@name='onScrollChange' and count(parameter)=5 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("onScrollChange", "(Landroid/webkit/WebView;IIII)V", "GetOnScrollChange_Landroid_webkit_WebView_IIIIHandler:Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView/IOnScrollChangeListenerInvoker, QMUI.Droid")]
			void OnScrollChange (global::Android.Webkit.WebView p0, int p1, int p2, int p3, int p4);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener", DoNotGenerateAcw=true)]
		internal partial class IOnScrollChangeListenerInvoker : global::Java.Lang.Object, IOnScrollChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener", typeof (IOnScrollChangeListenerInvoker));

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

			public static IOnScrollChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScrollChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.webview.QMUIWebView.OnScrollChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScrollChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onScrollChange_Landroid_webkit_WebView_IIII;
#pragma warning disable 0169
			static Delegate GetOnScrollChange_Landroid_webkit_WebView_IIIIHandler ()
			{
				if (cb_onScrollChange_Landroid_webkit_WebView_IIII == null)
					cb_onScrollChange_Landroid_webkit_WebView_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIII_V) n_OnScrollChange_Landroid_webkit_WebView_IIII);
				return cb_onScrollChange_Landroid_webkit_WebView_IIII;
			}

			static void n_OnScrollChange_Landroid_webkit_WebView_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnScrollChange (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_onScrollChange_Landroid_webkit_WebView_IIII;
			public unsafe void OnScrollChange (global::Android.Webkit.WebView p0, int p1, int p2, int p3, int p4)
			{
				if (id_onScrollChange_Landroid_webkit_WebView_IIII == IntPtr.Zero)
					id_onScrollChange_Landroid_webkit_WebView_IIII = JNIEnv.GetMethodID (class_ref, "onScrollChange", "(Landroid/webkit/WebView;IIII)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollChange_Landroid_webkit_WebView_IIII, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.webview.QMUIWebView.OnScrollChangeListener.onScrollChange
		public partial class ScrollChangeEventArgs : global::System.EventArgs {

			public ScrollChangeEventArgs (global::Android.Webkit.WebView p0, int p1, int p2, int p3, int p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Android.Webkit.WebView p0;
			public global::Android.Webkit.WebView P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}

			int p4;
			public int P4 {
				get { return p4; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/webview/QMUIWebView_OnScrollChangeListenerImplementor")]
		internal sealed partial class IOnScrollChangeListenerImplementor : global::Java.Lang.Object, IOnScrollChangeListener {

			object sender;

			public IOnScrollChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/webview/QMUIWebView_OnScrollChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ScrollChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnScrollChange (global::Android.Webkit.WebView p0, int p1, int p2, int p3, int p4)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ScrollChangeEventArgs (p0, p1, p2, p3, p4));
			}

			internal static bool __IsEmpty (IOnScrollChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebView", typeof (QMUIWebView));
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

		protected QMUIWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/constructor[@name='QMUIWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIWebView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/constructor[@name='QMUIWebView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIWebView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/constructor[@name='QMUIWebView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIWebView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_isNeedDispatchSafeAreaInset;
#pragma warning disable 0169
		static Delegate GetIsNeedDispatchSafeAreaInsetHandler ()
		{
			if (cb_isNeedDispatchSafeAreaInset == null)
				cb_isNeedDispatchSafeAreaInset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNeedDispatchSafeAreaInset);
			return cb_isNeedDispatchSafeAreaInset;
		}

		static bool n_IsNeedDispatchSafeAreaInset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedDispatchSafeAreaInset;
		}
#pragma warning restore 0169

		static Delegate cb_setNeedDispatchSafeAreaInset_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedDispatchSafeAreaInset_ZHandler ()
		{
			if (cb_setNeedDispatchSafeAreaInset_Z == null)
				cb_setNeedDispatchSafeAreaInset_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNeedDispatchSafeAreaInset_Z);
			return cb_setNeedDispatchSafeAreaInset_Z;
		}

		static void n_SetNeedDispatchSafeAreaInset_Z (IntPtr jnienv, IntPtr native__this, bool needDispatchSafeAreaInset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NeedDispatchSafeAreaInset = needDispatchSafeAreaInset;
		}
#pragma warning restore 0169

		public virtual unsafe bool NeedDispatchSafeAreaInset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='isNeedDispatchSafeAreaInset' and count(parameter)=0]"
			[Register ("isNeedDispatchSafeAreaInset", "()Z", "GetIsNeedDispatchSafeAreaInsetHandler")]
			get {
				const string __id = "isNeedDispatchSafeAreaInset.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='setNeedDispatchSafeAreaInset' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNeedDispatchSafeAreaInset", "(Z)V", "GetSetNeedDispatchSafeAreaInset_ZHandler")]
			set {
				const string __id = "setNeedDispatchSafeAreaInset.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_;
#pragma warning disable 0169
		static Delegate GetAddCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_Handler ()
		{
			if (cb_addCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ == null)
				cb_addCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_);
			return cb_addCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_;
		}

		static void n_AddCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddCustomOnScrollChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='addCustomOnScrollChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.webview.QMUIWebView.OnScrollChangeListener']]"
		[Register ("addCustomOnScrollChangeListener", "(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener;)V", "GetAddCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_Handler")]
		public virtual unsafe void AddCustomOnScrollChangeListener (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener listener)
		{
			const string __id = "addCustomOnScrollChangeListener.(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler ()
		{
			if (cb_applySystemWindowInsets19_Landroid_graphics_Rect_ == null)
				cb_applySystemWindowInsets19_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ApplySystemWindowInsets19_Landroid_graphics_Rect_);
			return cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
		}

		static bool n_ApplySystemWindowInsets19_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_insets, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ApplySystemWindowInsets19 (insets);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='applySystemWindowInsets19' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("applySystemWindowInsets19", "(Landroid/graphics/Rect;)Z", "GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler")]
		public virtual unsafe bool ApplySystemWindowInsets19 (global::Android.Graphics.Rect insets)
		{
			const string __id = "applySystemWindowInsets19.(Landroid/graphics/Rect;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

		static Delegate cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler ()
		{
			if (cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ == null)
				cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_);
			return cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
		}

		static IntPtr n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (native_insets, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplySystemWindowInsets21 (insets));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='applySystemWindowInsets21' and count(parameter)=1 and parameter[1][@type='androidx.core.view.WindowInsetsCompat']]"
		[Register ("applySystemWindowInsets21", "(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", "GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler")]
		public virtual unsafe global::AndroidX.Core.View.WindowInsetsCompat ApplySystemWindowInsets21 (global::AndroidX.Core.View.WindowInsetsCompat insets)
		{
			const string __id = "applySystemWindowInsets21.(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

		static Delegate cb_getExtraInsetBottom_F;
#pragma warning disable 0169
		static Delegate GetGetExtraInsetBottom_FHandler ()
		{
			if (cb_getExtraInsetBottom_F == null)
				cb_getExtraInsetBottom_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_I) n_GetExtraInsetBottom_F);
			return cb_getExtraInsetBottom_F;
		}

		static int n_GetExtraInsetBottom_F (IntPtr jnienv, IntPtr native__this, float density)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetExtraInsetBottom (density);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='getExtraInsetBottom' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getExtraInsetBottom", "(F)I", "GetGetExtraInsetBottom_FHandler")]
		protected virtual unsafe int GetExtraInsetBottom (float density)
		{
			const string __id = "getExtraInsetBottom.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (density);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getExtraInsetLeft_F;
#pragma warning disable 0169
		static Delegate GetGetExtraInsetLeft_FHandler ()
		{
			if (cb_getExtraInsetLeft_F == null)
				cb_getExtraInsetLeft_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_I) n_GetExtraInsetLeft_F);
			return cb_getExtraInsetLeft_F;
		}

		static int n_GetExtraInsetLeft_F (IntPtr jnienv, IntPtr native__this, float density)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetExtraInsetLeft (density);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='getExtraInsetLeft' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getExtraInsetLeft", "(F)I", "GetGetExtraInsetLeft_FHandler")]
		protected virtual unsafe int GetExtraInsetLeft (float density)
		{
			const string __id = "getExtraInsetLeft.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (density);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getExtraInsetRight_F;
#pragma warning disable 0169
		static Delegate GetGetExtraInsetRight_FHandler ()
		{
			if (cb_getExtraInsetRight_F == null)
				cb_getExtraInsetRight_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_I) n_GetExtraInsetRight_F);
			return cb_getExtraInsetRight_F;
		}

		static int n_GetExtraInsetRight_F (IntPtr jnienv, IntPtr native__this, float density)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetExtraInsetRight (density);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='getExtraInsetRight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getExtraInsetRight", "(F)I", "GetGetExtraInsetRight_FHandler")]
		protected virtual unsafe int GetExtraInsetRight (float density)
		{
			const string __id = "getExtraInsetRight.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (density);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getExtraInsetTop_F;
#pragma warning disable 0169
		static Delegate GetGetExtraInsetTop_FHandler ()
		{
			if (cb_getExtraInsetTop_F == null)
				cb_getExtraInsetTop_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_I) n_GetExtraInsetTop_F);
			return cb_getExtraInsetTop_F;
		}

		static int n_GetExtraInsetTop_F (IntPtr jnienv, IntPtr native__this, float density)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetExtraInsetTop (density);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='getExtraInsetTop' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getExtraInsetTop", "(F)I", "GetGetExtraInsetTop_FHandler")]
		protected virtual unsafe int GetExtraInsetTop (float density)
		{
			const string __id = "getExtraInsetTop.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (density);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeAllOnScrollChangeListener;
#pragma warning disable 0169
		static Delegate GetRemoveAllOnScrollChangeListenerHandler ()
		{
			if (cb_removeAllOnScrollChangeListener == null)
				cb_removeAllOnScrollChangeListener = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAllOnScrollChangeListener);
			return cb_removeAllOnScrollChangeListener;
		}

		static void n_RemoveAllOnScrollChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllOnScrollChangeListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='removeAllOnScrollChangeListener' and count(parameter)=0]"
		[Register ("removeAllOnScrollChangeListener", "()V", "GetRemoveAllOnScrollChangeListenerHandler")]
		public virtual unsafe void RemoveAllOnScrollChangeListener ()
		{
			const string __id = "removeAllOnScrollChangeListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_Handler ()
		{
			if (cb_removeOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ == null)
				cb_removeOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_);
			return cb_removeOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_;
		}

		static void n_RemoveOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnScrollChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='removeOnScrollChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.webview.QMUIWebView.OnScrollChangeListener']]"
		[Register ("removeOnScrollChangeListener", "(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener;)V", "GetRemoveOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_Handler")]
		public virtual unsafe void RemoveOnScrollChangeListener (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener listener)
		{
			const string __id = "removeOnScrollChangeListener.(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_Handler ()
		{
			if (cb_setCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_ == null)
				cb_setCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_);
			return cb_setCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_;
		}

		static void n_SetCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.ICallback)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebView']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.webview.QMUIWebView.Callback']]"
		[Register ("setCallback", "(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$Callback;)V", "GetSetCallback_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Callback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.ICallback @callback)
		{
			const string __id = "setCallback.(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.ScrollChangeEventArgs> CustomOnScrollChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor>(
						ref weak_implementor_AddCustomOnScrollChangeListener,
						__CreateIOnScrollChangeListenerImplementor,
						AddCustomOnScrollChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor>(
						ref weak_implementor_AddCustomOnScrollChangeListener,
						global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener.AddCustomOnScrollChangeListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddCustomOnScrollChangeListener;

		global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor __CreateIOnScrollChangeListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor (this);
		}
#endregion
	}
}
