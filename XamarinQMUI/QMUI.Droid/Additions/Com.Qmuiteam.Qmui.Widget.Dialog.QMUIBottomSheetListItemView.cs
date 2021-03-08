using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemView", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheetListItemView : global::Com.Qmuiteam.Qmui.Layout.QMUIConstraintLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemView", typeof (QMUIBottomSheetListItemView));
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

		protected QMUIBottomSheetListItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemView']/constructor[@name='QMUIBottomSheetListItemView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;ZZ)V", "")]
		public unsafe QMUIBottomSheetListItemView (global::Android.Content.Context context, bool markStyle, bool gravityCenter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (markStyle);
				__args [2] = new JniArgumentValue (gravityCenter);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Z;
#pragma warning disable 0169
		static Delegate GetRender_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ZHandler ()
		{
			if (cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Z == null)
				cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_Render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Z);
			return cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Z;
		}

		static void n_Render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_itemModel, bool isChecked)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var itemModel = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (native_itemModel, JniHandleOwnership.DoNotTransfer);
			__this.Render (itemModel, isChecked);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemView']/method[@name='render' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListItemModel'] and parameter[2][@type='boolean']]"
		[Register ("render", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;Z)V", "GetRender_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ZHandler")]
		public virtual unsafe void Render (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel itemModel, bool isChecked)
		{
			const string __id = "render.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((itemModel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemModel).Handle);
				__args [1] = new JniArgumentValue (isChecked);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (itemModel);
			}
		}

	}
}
