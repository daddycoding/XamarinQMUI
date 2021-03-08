using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebViewContainer", DoNotGenerateAcw=true)]
	public partial class QMUIWebViewContainer : global::Com.Qmuiteam.Qmui.Widget.QMUIWindowInsetLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebViewContainer", typeof (QMUIWebViewContainer));
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

		protected QMUIWebViewContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']/constructor[@name='QMUIWebViewContainer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIWebViewContainer (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']/constructor[@name='QMUIWebViewContainer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIWebViewContainer (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		static Delegate cb_getWebViewLayoutParams;
#pragma warning disable 0169
		static Delegate GetGetWebViewLayoutParamsHandler ()
		{
			if (cb_getWebViewLayoutParams == null)
				cb_getWebViewLayoutParams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWebViewLayoutParams);
			return cb_getWebViewLayoutParams;
		}

		static IntPtr n_GetWebViewLayoutParams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebViewLayoutParams);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Widget.FrameLayout.LayoutParams WebViewLayoutParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']/method[@name='getWebViewLayoutParams' and count(parameter)=0]"
			[Register ("getWebViewLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;", "GetGetWebViewLayoutParamsHandler")]
			get {
				const string __id = "getWebViewLayoutParams.()Landroid/widget/FrameLayout$LayoutParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Z;
#pragma warning disable 0169
		static Delegate GetAddWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_ZHandler ()
		{
			if (cb_addWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Z == null)
				cb_addWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_AddWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Z);
			return cb_addWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Z;
		}

		static void n_AddWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_webView, bool needDispatchSafeAreaInset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var webView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView> (native_webView, JniHandleOwnership.DoNotTransfer);
			__this.AddWebView (webView, needDispatchSafeAreaInset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']/method[@name='addWebView' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.webview.QMUIWebView'] and parameter[2][@type='boolean']]"
		[Register ("addWebView", "(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView;Z)V", "GetAddWebView_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_ZHandler")]
		public virtual unsafe void AddWebView (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView webView, bool needDispatchSafeAreaInset)
		{
			const string __id = "addWebView.(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((webView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webView).Handle);
				__args [1] = new JniArgumentValue (needDispatchSafeAreaInset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (webView);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_Handler ()
		{
			if (cb_setCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ == null)
				cb_setCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_);
			return cb_setCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_;
		}

		static void n_SetCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onScrollChangeListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onScrollChangeListener = (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener> (native_onScrollChangeListener, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomOnScrollChangeListener (onScrollChangeListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']/method[@name='setCustomOnScrollChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.webview.QMUIWebView.OnScrollChangeListener']]"
		[Register ("setCustomOnScrollChangeListener", "(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener;)V", "GetSetCustomOnScrollChangeListener_Lcom_qmuiteam_qmui_widget_webview_QMUIWebView_OnScrollChangeListener_Handler")]
		public virtual unsafe void SetCustomOnScrollChangeListener (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener onScrollChangeListener)
		{
			const string __id = "setCustomOnScrollChangeListener.(Lcom/qmuiteam/qmui/widget/webview/QMUIWebView$OnScrollChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onScrollChangeListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onScrollChangeListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onScrollChangeListener);
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNeedDispatchSafeAreaInset (needDispatchSafeAreaInset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewContainer']/method[@name='setNeedDispatchSafeAreaInset' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedDispatchSafeAreaInset", "(Z)V", "GetSetNeedDispatchSafeAreaInset_ZHandler")]
		public virtual unsafe void SetNeedDispatchSafeAreaInset (bool needDispatchSafeAreaInset)
		{
			const string __id = "setNeedDispatchSafeAreaInset.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (needDispatchSafeAreaInset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.ScrollChangeEventArgs> CustomOnScrollChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor>(
						ref weak_implementor_SetCustomOnScrollChangeListener,
						__CreateIOnScrollChangeListenerImplementor,
						SetCustomOnScrollChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListener, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor>(
						ref weak_implementor_SetCustomOnScrollChangeListener,
						global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor.__IsEmpty,
						__v => SetCustomOnScrollChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetCustomOnScrollChangeListener;

		global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor __CreateIOnScrollChangeListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebView.IOnScrollChangeListenerImplementor (this);
		}
#endregion
	}
}
