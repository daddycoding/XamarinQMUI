using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleBackgroundHandler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleBackgroundHandler", DoNotGenerateAcw=true)]
	public partial class QMUISkinRuleBackgroundHandler : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Skin.Handler.IQMUISkinRuleHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleBackgroundHandler", typeof (QMUISkinRuleBackgroundHandler));
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

		protected QMUISkinRuleBackgroundHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleBackgroundHandler']/constructor[@name='QMUISkinRuleBackgroundHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinRuleBackgroundHandler ()
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

		static Delegate cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_IHandler ()
		{
			if (cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I == null)
				cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLI_V) n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I);
			return cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I;
		}

		static void n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_skinManager, IntPtr native_view, IntPtr native_theme, IntPtr native_name, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleBackgroundHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Handle (skinManager, view, theme, name, attr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleBackgroundHandler']/method[@name='handle' and count(parameter)=5 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;Landroid/view/View;Landroid/content/res/Resources$Theme;Ljava/lang/String;I)V", "GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Landroid_view_View_Landroid_content_res_Resources_Theme_Ljava_lang_String_IHandler")]
		public new virtual unsafe void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager, global::Android.Views.View view, global::Android.Content.Res.Resources.Theme theme, string name, int attr)
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
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (skinManager);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (theme);
			}
		}

	}
}
