using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleColorStateListHandler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleColorStateListHandler", DoNotGenerateAcw=true)]
	public abstract partial class QMUISkinRuleColorStateListHandler : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Skin.Handler.IQMUISkinRuleHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleColorStateListHandler", typeof (QMUISkinRuleColorStateListHandler));
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

		protected QMUISkinRuleColorStateListHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleColorStateListHandler']/constructor[@name='QMUISkinRuleColorStateListHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinRuleColorStateListHandler ()
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

		static Delegate cb_handle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetHandle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_handle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_ == null)
				cb_handle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Handle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_);
			return cb_handle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_;
		}

		static void n_Handle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleColorStateListHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleColorStateListHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.res.ColorStateList']]"
		[Register ("handle", "(Landroid/view/View;Ljava/lang/String;Landroid/content/res/ColorStateList;)V", "GetHandle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_Handler")]
		new protected abstract void Handle (global::Android.Views.View p0, string p1, global::Android.Content.Res.ColorStateList p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleColorStateListHandler']/method[@name='handle' and count(parameter)=5 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;Landroid/view/View;Landroid/content/res/Resources$Theme;Ljava/lang/String;I)V", "")]
		public new unsafe void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager, global::Android.Views.View view, global::Android.Content.Res.Resources.Theme theme, string name, int attr)
		{
			const string __id = "handle.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;Landroid/view/View;Landroid/content/res/Resources$Theme;Ljava/lang/String;I)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [2] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [3] = new JniArgumentValue (native_name);
				__args [4] = new JniArgumentValue (attr);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (skinManager);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (theme);
			}
		}

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleColorStateListHandler", DoNotGenerateAcw=true)]
	internal partial class QMUISkinRuleColorStateListHandlerInvoker : QMUISkinRuleColorStateListHandler {

		public QMUISkinRuleColorStateListHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleColorStateListHandler", typeof (QMUISkinRuleColorStateListHandlerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleColorStateListHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.res.ColorStateList']]"
		[Register ("handle", "(Landroid/view/View;Ljava/lang/String;Landroid/content/res/ColorStateList;)V", "GetHandle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_Handler")]
		protected override unsafe void Handle (global::Android.Views.View p0, string p1, global::Android.Content.Res.ColorStateList p2)
		{
			const string __id = "handle.(Landroid/view/View;Ljava/lang/String;Landroid/content/res/ColorStateList;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

	}

}
