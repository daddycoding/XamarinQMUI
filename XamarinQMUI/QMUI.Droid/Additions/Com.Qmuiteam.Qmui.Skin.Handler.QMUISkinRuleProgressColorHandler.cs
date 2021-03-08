using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleProgressColorHandler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleProgressColorHandler", DoNotGenerateAcw=true)]
	public partial class QMUISkinRuleProgressColorHandler : global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleColorHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleProgressColorHandler", typeof (QMUISkinRuleProgressColorHandler));
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

		protected QMUISkinRuleProgressColorHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleProgressColorHandler']/constructor[@name='QMUISkinRuleProgressColorHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinRuleProgressColorHandler ()
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

		static Delegate cb_handle_Landroid_view_View_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetHandle_Landroid_view_View_Ljava_lang_String_IHandler ()
		{
			if (cb_handle_Landroid_view_View_Ljava_lang_String_I == null)
				cb_handle_Landroid_view_View_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Handle_Landroid_view_View_Ljava_lang_String_I);
			return cb_handle_Landroid_view_View_Ljava_lang_String_I;
		}

		static void n_Handle_Landroid_view_View_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_name, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleProgressColorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Handle (view, name, color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleProgressColorHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("handle", "(Landroid/view/View;Ljava/lang/String;I)V", "GetHandle_Landroid_view_View_Ljava_lang_String_IHandler")]
		protected override unsafe void Handle (global::Android.Views.View view, string name, int color)
		{
			const string __id = "handle.(Landroid/view/View;Ljava/lang/String;I)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
