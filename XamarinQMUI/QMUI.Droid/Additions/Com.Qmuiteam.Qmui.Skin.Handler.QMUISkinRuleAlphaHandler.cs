using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleAlphaHandler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleAlphaHandler", DoNotGenerateAcw=true)]
	public partial class QMUISkinRuleAlphaHandler : global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleFloatHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleAlphaHandler", typeof (QMUISkinRuleAlphaHandler));
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

		protected QMUISkinRuleAlphaHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleAlphaHandler']/constructor[@name='QMUISkinRuleAlphaHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinRuleAlphaHandler ()
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

		static void n_Handle_Landroid_view_View_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_name, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleAlphaHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Handle (view, name, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleAlphaHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float']]"
		[Register ("handle", "(Landroid/view/View;Ljava/lang/String;F)V", "GetHandle_Landroid_view_View_Ljava_lang_String_FHandler")]
		protected override unsafe void Handle (global::Android.Views.View view, string name, float value)
		{
			const string __id = "handle.(Landroid/view/View;Ljava/lang/String;F)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
