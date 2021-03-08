using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemDecoration']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemDecoration", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheetListItemDecoration : global::AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerDecoration {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemDecoration", typeof (QMUIBottomSheetListItemDecoration));
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

		protected QMUIBottomSheetListItemDecoration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemDecoration']/constructor[@name='QMUIBottomSheetListItemDecoration' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIBottomSheetListItemDecoration (global::Android.Content.Context context)
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

		static Delegate cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetHandle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ == null)
				cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_V) n_Handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_);
			return cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
		}

		static void n_Handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_manager, int skinIndex, IntPtr native_theme)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			__this.Handle (recyclerView, manager, skinIndex, theme);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemDecoration']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[3][@type='int'] and parameter[4][@type='android.content.res.Resources.Theme']]"
		[Register ("handle", "(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V", "GetHandle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler")]
		public new virtual unsafe void Handle (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager manager, int skinIndex, global::Android.Content.Res.Resources.Theme theme)
		{
			const string __id = "handle.(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
				__args [1] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				__args [2] = new JniArgumentValue (skinIndex);
				__args [3] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (recyclerView);
				global::System.GC.KeepAlive (manager);
				global::System.GC.KeepAlive (theme);
			}
		}

	}
}
