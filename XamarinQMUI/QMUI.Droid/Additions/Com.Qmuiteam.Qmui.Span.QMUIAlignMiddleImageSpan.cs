using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Span {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIAlignMiddleImageSpan']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/span/QMUIAlignMiddleImageSpan", DoNotGenerateAcw=true)]
	public partial class QMUIAlignMiddleImageSpan : global::Android.Text.Style.ImageSpan, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerSpan {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIAlignMiddleImageSpan']/field[@name='ALIGN_MIDDLE']"
		[Register ("ALIGN_MIDDLE")]
		public const int AlignMiddle = (int) -100;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/span/QMUIAlignMiddleImageSpan", typeof (QMUIAlignMiddleImageSpan));
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

		protected QMUIAlignMiddleImageSpan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIAlignMiddleImageSpan']/constructor[@name='QMUIAlignMiddleImageSpan' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;I)V", "")]
		public unsafe QMUIAlignMiddleImageSpan (global::Android.Graphics.Drawables.Drawable d, int verticalAlignment)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				__args [1] = new JniArgumentValue (verticalAlignment);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIAlignMiddleImageSpan']/constructor[@name='QMUIAlignMiddleImageSpan' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;IF)V", "")]
		public unsafe QMUIAlignMiddleImageSpan (global::Android.Graphics.Drawables.Drawable d, int verticalAlignment, float fontWidthMultiple)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;IF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				__args [1] = new JniArgumentValue (verticalAlignment);
				__args [2] = new JniArgumentValue (fontWidthMultiple);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (d);
			}
		}

		static Delegate cb_handle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetHandle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_handle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ == null)
				cb_handle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_V) n_Handle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_);
			return cb_handle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
		}

		static void n_Handle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_manager, int skinIndex, IntPtr native_theme)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUIAlignMiddleImageSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			__this.Handle (view, manager, skinIndex, theme);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIAlignMiddleImageSpan']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[3][@type='int'] and parameter[4][@type='android.content.res.Resources.Theme']]"
		[Register ("handle", "(Landroid/view/View;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V", "GetHandle_Landroid_view_View_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler")]
		public new virtual unsafe void Handle (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager manager, int skinIndex, global::Android.Content.Res.Resources.Theme theme)
		{
			const string __id = "handle.(Landroid/view/View;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				__args [2] = new JniArgumentValue (skinIndex);
				__args [3] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (manager);
				global::System.GC.KeepAlive (theme);
			}
		}

		static Delegate cb_setAvoidSuperChangeFontMetrics_Z;
#pragma warning disable 0169
		static Delegate GetSetAvoidSuperChangeFontMetrics_ZHandler ()
		{
			if (cb_setAvoidSuperChangeFontMetrics_Z == null)
				cb_setAvoidSuperChangeFontMetrics_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAvoidSuperChangeFontMetrics_Z);
			return cb_setAvoidSuperChangeFontMetrics_Z;
		}

		static void n_SetAvoidSuperChangeFontMetrics_Z (IntPtr jnienv, IntPtr native__this, bool avoidSuperChangeFontMetrics)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUIAlignMiddleImageSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAvoidSuperChangeFontMetrics (avoidSuperChangeFontMetrics);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIAlignMiddleImageSpan']/method[@name='setAvoidSuperChangeFontMetrics' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAvoidSuperChangeFontMetrics", "(Z)V", "GetSetAvoidSuperChangeFontMetrics_ZHandler")]
		public virtual unsafe void SetAvoidSuperChangeFontMetrics (bool avoidSuperChangeFontMetrics)
		{
			const string __id = "setAvoidSuperChangeFontMetrics.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (avoidSuperChangeFontMetrics);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSkinSupportWithTintColor_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetSetSkinSupportWithTintColor_Landroid_view_View_IHandler ()
		{
			if (cb_setSkinSupportWithTintColor_Landroid_view_View_I == null)
				cb_setSkinSupportWithTintColor_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetSkinSupportWithTintColor_Landroid_view_View_I);
			return cb_setSkinSupportWithTintColor_Landroid_view_View_I;
		}

		static void n_SetSkinSupportWithTintColor_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_skinFollowView, int drawableTintColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUIAlignMiddleImageSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinFollowView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_skinFollowView, JniHandleOwnership.DoNotTransfer);
			__this.SetSkinSupportWithTintColor (skinFollowView, drawableTintColorAttr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUIAlignMiddleImageSpan']/method[@name='setSkinSupportWithTintColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setSkinSupportWithTintColor", "(Landroid/view/View;I)V", "GetSetSkinSupportWithTintColor_Landroid_view_View_IHandler")]
		public virtual unsafe void SetSkinSupportWithTintColor (global::Android.Views.View skinFollowView, int drawableTintColorAttr)
		{
			const string __id = "setSkinSupportWithTintColor.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((skinFollowView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinFollowView).Handle);
				__args [1] = new JniArgumentValue (drawableTintColorAttr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (skinFollowView);
			}
		}

	}
}
