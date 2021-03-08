using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler", DoNotGenerateAcw=true)]
	public abstract partial class QMUIWebViewBridgeHandler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler.MessageFinishCallback']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler$MessageFinishCallback", DoNotGenerateAcw=true)]
		public abstract partial class MessageFinishCallback : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler$MessageFinishCallback", typeof (MessageFinishCallback));
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

			protected MessageFinishCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler.MessageFinishCallback']/constructor[@name='QMUIWebViewBridgeHandler.MessageFinishCallback' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.webview.QMUIWebViewBridgeHandler'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler;Ljava/lang/String;)V", "")]
			public unsafe MessageFinishCallback (global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler __self, string callbackId)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_callbackId = JNIEnv.NewString (callbackId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue (native_callbackId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_callbackId);
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate cb_getCallbackId;
#pragma warning disable 0169
			static Delegate GetGetCallbackIdHandler ()
			{
				if (cb_getCallbackId == null)
					cb_getCallbackId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCallbackId);
				return cb_getCallbackId;
			}

			static IntPtr n_GetCallbackId (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler.MessageFinishCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CallbackId);
			}
#pragma warning restore 0169

			public virtual unsafe string CallbackId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler.MessageFinishCallback']/method[@name='getCallbackId' and count(parameter)=0]"
				[Register ("getCallbackId", "()Ljava/lang/String;", "GetGetCallbackIdHandler")]
				get {
					const string __id = "getCallbackId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_finish_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetFinish_Ljava_lang_Object_Handler ()
			{
				if (cb_finish_Ljava_lang_Object_ == null)
					cb_finish_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Finish_Ljava_lang_Object_);
				return cb_finish_Ljava_lang_Object_;
			}

			static void n_Finish_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler.MessageFinishCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var data = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_data, JniHandleOwnership.DoNotTransfer);
				__this.Finish (data);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler.MessageFinishCallback']/method[@name='finish' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("finish", "(Ljava/lang/Object;)V", "GetFinish_Ljava_lang_Object_Handler")]
			public abstract void Finish (global::Java.Lang.Object data);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler$MessageFinishCallback", DoNotGenerateAcw=true)]
		internal partial class MessageFinishCallbackInvoker : MessageFinishCallback {

			public MessageFinishCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler$MessageFinishCallback", typeof (MessageFinishCallbackInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler.MessageFinishCallback']/method[@name='finish' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("finish", "(Ljava/lang/Object;)V", "GetFinish_Ljava_lang_Object_Handler")]
			public override unsafe void Finish (global::Java.Lang.Object data)
			{
				const string __id = "finish.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (data);
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler", typeof (QMUIWebViewBridgeHandler));
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

		protected QMUIWebViewBridgeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/constructor[@name='QMUIWebViewBridgeHandler' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register (".ctor", "(Landroid/webkit/WebView;)V", "")]
		public unsafe QMUIWebViewBridgeHandler (global::Android.Webkit.WebView webView)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/webkit/WebView;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((webView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webView).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (webView);
			}
		}

		static Delegate cb_getSupportedCmdList;
#pragma warning disable 0169
		static Delegate GetGetSupportedCmdListHandler ()
		{
			if (cb_getSupportedCmdList == null)
				cb_getSupportedCmdList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedCmdList);
			return cb_getSupportedCmdList;
		}

		static IntPtr n_GetSupportedCmdList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.SupportedCmdList);
		}
#pragma warning restore 0169

		protected abstract global::System.Collections.Generic.IList<string> SupportedCmdList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/method[@name='getSupportedCmdList' and count(parameter)=0]"
			[Register ("getSupportedCmdList", "()Ljava/util/List;", "GetGetSupportedCmdListHandler")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escape", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Escape (string value)
		{
			const string __id = "escape.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/method[@name='evaluateBridgeScript' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.webkit.ValueCallback&lt;java.lang.String&gt;']]"
		[Register ("evaluateBridgeScript", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", "")]
		public unsafe void EvaluateBridgeScript (string script, global::Android.Webkit.IValueCallback resultCallback)
		{
			const string __id = "evaluateBridgeScript.(Ljava/lang/String;Landroid/webkit/ValueCallback;)V";
			IntPtr native_script = JNIEnv.NewString (script);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_script);
				__args [1] = new JniArgumentValue ((resultCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultCallback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_script);
				global::System.GC.KeepAlive (resultCallback);
			}
		}

		static Delegate cb_handleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_Handler ()
		{
			if (cb_handleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_ == null)
				cb_handleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_HandleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_);
			return cb_handleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_;
		}

		static void n_HandleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler.MessageFinishCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (message, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.qmuiteam.qmui.widget.webview.QMUIWebViewBridgeHandler.MessageFinishCallback']]"
		[Register ("handleMessage", "(Ljava/lang/String;Lcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler$MessageFinishCallback;)V", "GetHandleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_Handler")]
		protected abstract void HandleMessage (string message, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler.MessageFinishCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/method[@name='unescape' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unescape", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Unescape (string value)
		{
			const string __id = "unescape.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler", DoNotGenerateAcw=true)]
	internal partial class QMUIWebViewBridgeHandlerInvoker : QMUIWebViewBridgeHandler {

		public QMUIWebViewBridgeHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler", typeof (QMUIWebViewBridgeHandlerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe global::System.Collections.Generic.IList<string> SupportedCmdList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/method[@name='getSupportedCmdList' and count(parameter)=0]"
			[Register ("getSupportedCmdList", "()Ljava/util/List;", "GetGetSupportedCmdListHandler")]
			get {
				const string __id = "getSupportedCmdList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.webview']/class[@name='QMUIWebViewBridgeHandler']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.qmuiteam.qmui.widget.webview.QMUIWebViewBridgeHandler.MessageFinishCallback']]"
		[Register ("handleMessage", "(Ljava/lang/String;Lcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler$MessageFinishCallback;)V", "GetHandleMessage_Ljava_lang_String_Lcom_qmuiteam_qmui_widget_webview_QMUIWebViewBridgeHandler_MessageFinishCallback_Handler")]
		protected override unsafe void HandleMessage (string message, global::Com.Qmuiteam.Qmui.Widget.Webview.QMUIWebViewBridgeHandler.MessageFinishCallback @callback)
		{
			const string __id = "handleMessage.(Ljava/lang/String;Lcom/qmuiteam/qmui/widget/webview/QMUIWebViewBridgeHandler$MessageFinishCallback;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}

}
