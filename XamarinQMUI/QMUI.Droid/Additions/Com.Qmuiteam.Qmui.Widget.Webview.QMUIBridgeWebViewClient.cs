using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIBridgeWebViewClient", DoNotGenerateAcw=true)]
	public partial class QMUIBridgeWebViewClient : global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/field[@name='QMUI_BRIDGE_HAS_MESSAGE']"
		[Register ("QMUI_BRIDGE_HAS_MESSAGE")]
		public const string QmuiBridgeHasMessage = (string) "qmui://__QUEUE_MESSAGE__";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/field[@name='QMUI_BRIDGE_JS']"
		[Register ("QMUI_BRIDGE_JS")]
		public const string QmuiBridgeJs = (string) "QMUIWebviewBridge.js";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIBridgeWebViewClient", typeof (QMUIBridgeWebViewClient));
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

		protected QMUIBridgeWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/constructor[@name='QMUIBridgeWebViewClient' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='com.qmuiteam.qmui.widget.webview.QMUIWebViewBridgeHandler']]"
		[Register (".ctor", "(ZZZLcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler;)V", "")]
		public unsafe QMUIBridgeWebViewClient (bool needDispatchSafeAreaInset, bool disableVideoFullscreenBtnAlways, bool needInjectLocalBridgeJs, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler bridgeHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZZZLcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (needDispatchSafeAreaInset);
				__args [1] = new JniArgumentValue (disableVideoFullscreenBtnAlways);
				__args [2] = new JniArgumentValue (needInjectLocalBridgeJs);
				__args [3] = new JniArgumentValue ((bridgeHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bridgeHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bridgeHandler);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/constructor[@name='QMUIBridgeWebViewClient' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='com.qmuiteam.qmui.widget.webview.QMUIWebViewBridgeHandler']]"
		[Register (".ctor", "(ZZLcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler;)V", "")]
		public unsafe QMUIBridgeWebViewClient (bool needDispatchSafeAreaInset, bool disableVideoFullscreenBtnAlways, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler bridgeHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZZLcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (needDispatchSafeAreaInset);
				__args [1] = new JniArgumentValue (disableVideoFullscreenBtnAlways);
				__args [2] = new JniArgumentValue ((bridgeHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bridgeHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bridgeHandler);
			}
		}

		static Delegate cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_;
#pragma warning disable 0169
		static Delegate GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Handler ()
		{
			if (cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_ == null)
				cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_OnShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_);
			return cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_;
		}

		static bool n_OnShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_request)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIBridgeWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_view, JniHandleOwnership.DoNotTransfer);
			var request = (global::Android.Webkit.IWebResourceRequest)global::Java.Lang.Object.GetObject<global::Android.Webkit.IWebResourceRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnShouldOverrideUrlLoading (view, request);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/method[@name='onShouldOverrideUrlLoading' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='android.webkit.WebResourceRequest']]"
		[Register ("onShouldOverrideUrlLoading", "(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z", "GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Handler")]
		protected virtual unsafe bool OnShouldOverrideUrlLoading (global::Android.Webkit.WebView view, global::Android.Webkit.IWebResourceRequest request)
		{
			const string __id = "onShouldOverrideUrlLoading.(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (request);
			}
		}

		static Delegate cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler ()
		{
			if (cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ == null)
				cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_OnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_);
			return cb_onShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_;
		}

		static bool n_OnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIBridgeWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_view, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnShouldOverrideUrlLoading (view, url);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/method[@name='onShouldOverrideUrlLoading' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("onShouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", "GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler")]
		protected virtual unsafe bool OnShouldOverrideUrlLoading (global::Android.Webkit.WebView view, string url)
		{
			const string __id = "onShouldOverrideUrlLoading.(Landroid/webkit/WebView;Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/method[@name='shouldOverrideUrlLoading' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='android.webkit.WebResourceRequest']]"
		[Register ("shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z", "")]
		public override sealed unsafe bool ShouldOverrideUrlLoading (global::Android.Webkit.WebView view, global::Android.Webkit.IWebResourceRequest request)
		{
			const string __id = "shouldOverrideUrlLoading.(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (request);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIBridgeWebViewClient']/method[@name='shouldOverrideUrlLoading' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", "")]
		public override sealed unsafe bool ShouldOverrideUrlLoading (global::Android.Webkit.WebView view, string url)
		{
			const string __id = "shouldOverrideUrlLoading.(Landroid/webkit/WebView;Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
