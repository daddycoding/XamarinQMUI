using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewClient']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebViewClient", DoNotGenerateAcw=true)]
	public partial class QMUIWebViewClient : global::Android.Webkit.WebViewClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewClient']/field[@name='JS_FAKE_KEY_CODE_EVENT']"
		[Register ("JS_FAKE_KEY_CODE_EVENT")]
		public const int JsFakeKeyCodeEvent = (int) 112;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebViewClient", typeof (QMUIWebViewClient));
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

		protected QMUIWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewClient']/constructor[@name='QMUIWebViewClient' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(ZZ)V", "")]
		public unsafe QMUIWebViewClient (bool needDispatchSafeAreaInset, bool disableVideoFullscreenBtnAlways)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (needDispatchSafeAreaInset);
				__args [1] = new JniArgumentValue (disableVideoFullscreenBtnAlways);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_;
#pragma warning disable 0169
		static Delegate GetSetNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Handler ()
		{
			if (cb_setNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_ == null)
				cb_setNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_);
			return cb_setNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_;
		}

		static void n_SetNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var webView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (native_webView, JniHandleOwnership.DoNotTransfer);
			__this.SetNeedDispatchSafeAreaInset (webView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewClient']/method[@name='setNeedDispatchSafeAreaInset' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.webview.QMUIWebView']]"
		[Register ("setNeedDispatchSafeAreaInset", "(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView;)V", "GetSetNeedDispatchSafeAreaInset_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Handler")]
		public virtual unsafe void SetNeedDispatchSafeAreaInset (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView webView)
		{
			const string __id = "setNeedDispatchSafeAreaInset.(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((webView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (webView);
			}
		}

	}
}
