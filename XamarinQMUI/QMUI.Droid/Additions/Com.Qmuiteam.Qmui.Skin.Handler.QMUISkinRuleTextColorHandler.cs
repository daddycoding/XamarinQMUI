using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleTextColorHandler']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleTextColorHandler", DoNotGenerateAcw=true)]
	public partial class QMUISkinRuleTextColorHandler : global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleColorStateListHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/handler/QMUISkinRuleTextColorHandler", typeof (QMUISkinRuleTextColorHandler));
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

		protected QMUISkinRuleTextColorHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleTextColorHandler']/constructor[@name='QMUISkinRuleTextColorHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinRuleTextColorHandler ()
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

		static void n_Handle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_name, IntPtr native_colorStateList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.Handler.QMUISkinRuleTextColorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var colorStateList = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_colorStateList, JniHandleOwnership.DoNotTransfer);
			__this.Handle (view, name, colorStateList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.handler']/class[@name='QMUISkinRuleTextColorHandler']/method[@name='handle' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.res.ColorStateList']]"
		[Register ("handle", "(Landroid/view/View;Ljava/lang/String;Landroid/content/res/ColorStateList;)V", "GetHandle_Landroid_view_View_Ljava_lang_String_Landroid_content_res_ColorStateList_Handler")]
		protected override unsafe void Handle (global::Android.Views.View view, string name, global::Android.Content.Res.ColorStateList colorStateList)
		{
			const string __id = "handle.(Landroid/view/View;Ljava/lang/String;Landroid/content/res/ColorStateList;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((colorStateList == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorStateList).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (colorStateList);
			}
		}

	}
}
