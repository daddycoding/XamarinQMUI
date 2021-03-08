using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleFloatHandler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleFloatHandler", DoNotGenerateAcw=true)]
	public abstract partial class QMUISkinRuleFloatHandler : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Skin.Handler.IQMUISkinRuleHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleFloatHandler", typeof (QMUISkinRuleFloatHandler));
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

		protected QMUISkinRuleFloatHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleFloatHandler']/constructor[@name='QMUISkinRuleFloatHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinRuleFloatHandler ()
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

		static Delegate cb_handle_Landroid_view_View_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetHandle_Landroid_view_View_Ljava_lang_String_FHandler ()
		{
			if (cb_handle_Landroid_view_View_Ljava_lang_String_F == null)
				cb_handle_Landroid_view_View_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLF_V) n_Handle_Landroid_view_View_Ljava_lang_String_F);
			return cb_handle_Landroid_view_View_Ljava_lang_String_F;
		}

		static void n_Handle_Landroid_view_View_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleFloatHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleFloatHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("handle", "(Landroid/view/View;Ljava/lang/String;F)V", "GetHandle_Landroid_view_View_Ljava_lang_String_FHandler")]
		new protected abstract void Handle (global::Android.Views.View p0, string p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleFloatHandler']/method[@name='handle' and count(parameter)=5 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
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

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleFloatHandler", DoNotGenerateAcw=true)]
	internal partial class QMUISkinRuleFloatHandlerInvoker : QMUISkinRuleFloatHandler {

		public QMUISkinRuleFloatHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleFloatHandler", typeof (QMUISkinRuleFloatHandlerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleFloatHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("handle", "(Landroid/view/View;Ljava/lang/String;F)V", "GetHandle_Landroid_view_View_Ljava_lang_String_FHandler")]
		protected override unsafe void Handle (global::Android.Views.View p0, string p1, float p2)
		{
			const string __id = "handle.(Landroid/view/View;Ljava/lang/String;F)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
