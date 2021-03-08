using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBlockBuilder']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBlockBuilder", DoNotGenerateAcw=true)]
	public partial class QMUIDialogBlockBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBlockBuilder", typeof (QMUIDialogBlockBuilder));
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

		protected QMUIDialogBlockBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBlockBuilder']/constructor[@name='QMUIDialogBlockBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIDialogBlockBuilder (global::Android.Content.Context context)
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

		static Delegate cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ == null)
				cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_);
			return cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, IntPtr native_parent, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (dialog, parent, context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBlockBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateContent", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler")]
		protected override unsafe global::Android.Views.View OnCreateContent (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView parent, global::Android.Content.Context context)
		{
			const string __id = "onCreateContent.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dialog);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_setContent_I;
#pragma warning disable 0169
		static Delegate GetSetContent_IHandler ()
		{
			if (cb_setContent_I == null)
				cb_setContent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetContent_I);
			return cb_setContent_I;
		}

		static IntPtr n_SetContent_I (IntPtr jnienv, IntPtr native__this, int contentRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContent (contentRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBlockBuilder']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContent", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBlockBuilder;", "GetSetContent_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder SetContent (int contentRes)
		{
			const string __id = "setContent.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBlockBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (contentRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setContent_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetContent_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setContent_Ljava_lang_CharSequence_ == null)
				cb_setContent_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContent_Ljava_lang_CharSequence_);
			return cb_setContent_Ljava_lang_CharSequence_;
		}

		static IntPtr n_SetContent_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_content)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var content = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_content, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContent (content));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBlockBuilder']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setContent", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBlockBuilder;", "GetSetContent_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder SetContent (global::Java.Lang.ICharSequence content)
		{
			const string __id = "setContent.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBlockBuilder;";
			IntPtr native_content = CharSequence.ToLocalJniHandle (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_content);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
				global::System.GC.KeepAlive (content);
			}
		}

		public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder SetContent (string content)
		{
			var jls_content = content == null ? null : new global::Java.Lang.String (content);
			global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBlockBuilder __result = SetContent (jls_content);
			var __rsval = __result;
			jls_content?.Dispose ();
			return __rsval;
		}

	}
}
