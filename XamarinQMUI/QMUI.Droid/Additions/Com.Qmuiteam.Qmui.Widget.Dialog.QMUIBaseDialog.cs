using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBaseDialog']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBaseDialog", DoNotGenerateAcw=true)]
	public partial class QMUIBaseDialog : global::AndroidX.AppCompat.App.AppCompatDialog {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBaseDialog", typeof (QMUIBaseDialog));
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

		protected QMUIBaseDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBaseDialog']/constructor[@name='QMUIBaseDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe QMUIBaseDialog (global::Android.Content.Context context, int themeResId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (themeResId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onSetCancelable_Z;
#pragma warning disable 0169
		static Delegate GetOnSetCancelable_ZHandler ()
		{
			if (cb_onSetCancelable_Z == null)
				cb_onSetCancelable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnSetCancelable_Z);
			return cb_onSetCancelable_Z;
		}

		static void n_OnSetCancelable_Z (IntPtr jnienv, IntPtr native__this, bool cancelable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSetCancelable (cancelable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBaseDialog']/method[@name='onSetCancelable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onSetCancelable", "(Z)V", "GetOnSetCancelable_ZHandler")]
		protected virtual unsafe void OnSetCancelable (bool cancelable)
		{
			const string __id = "onSetCancelable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cancelable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
#pragma warning disable 0169
		static Delegate GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler ()
		{
			if (cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ == null)
				cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_);
			return cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
		}

		static void n_SetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skinManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
			__this.SetSkinManager (skinManager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBaseDialog']/method[@name='setSkinManager' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager']]"
		[Register ("setSkinManager", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)V", "GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler")]
		public virtual unsafe void SetSkinManager (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager)
		{
			const string __id = "setSkinManager.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (skinManager);
			}
		}

		static Delegate cb_shouldWindowCloseOnTouchOutside;
#pragma warning disable 0169
		static Delegate GetShouldWindowCloseOnTouchOutsideHandler ()
		{
			if (cb_shouldWindowCloseOnTouchOutside == null)
				cb_shouldWindowCloseOnTouchOutside = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldWindowCloseOnTouchOutside);
			return cb_shouldWindowCloseOnTouchOutside;
		}

		static bool n_ShouldWindowCloseOnTouchOutside (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBaseDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldWindowCloseOnTouchOutside ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBaseDialog']/method[@name='shouldWindowCloseOnTouchOutside' and count(parameter)=0]"
		[Register ("shouldWindowCloseOnTouchOutside", "()Z", "GetShouldWindowCloseOnTouchOutsideHandler")]
		protected virtual unsafe bool ShouldWindowCloseOnTouchOutside ()
		{
			const string __id = "shouldWindowCloseOnTouchOutside.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
