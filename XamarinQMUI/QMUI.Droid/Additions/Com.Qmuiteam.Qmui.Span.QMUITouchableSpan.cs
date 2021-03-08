using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Span {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/span/QMUITouchableSpan", DoNotGenerateAcw=true)]
	public abstract partial class QMUITouchableSpan : global::Android.Text.Style.ClickableSpan, global::Com.Qmuiteam.Qmui.Link.ITouchableSpan, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerSpan {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/span/QMUITouchableSpan", typeof (QMUITouchableSpan));
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

		protected QMUITouchableSpan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/constructor[@name='QMUITouchableSpan' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/view/View;IIII)V", "")]
		public unsafe QMUITouchableSpan (global::Android.Views.View initFollowSkinView, int normalTextColorAttr, int pressedTextColorAttr, int normalBgAttr, int pressedBgAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((initFollowSkinView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initFollowSkinView).Handle);
				__args [1] = new JniArgumentValue (normalTextColorAttr);
				__args [2] = new JniArgumentValue (pressedTextColorAttr);
				__args [3] = new JniArgumentValue (normalBgAttr);
				__args [4] = new JniArgumentValue (pressedBgAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (initFollowSkinView);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/constructor[@name='QMUITouchableSpan' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe QMUITouchableSpan (int normalTextColor, int pressedTextColor, int normalBackgroundColor, int pressedBackgroundColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (normalTextColor);
				__args [1] = new JniArgumentValue (pressedTextColor);
				__args [2] = new JniArgumentValue (normalBackgroundColor);
				__args [3] = new JniArgumentValue (pressedBackgroundColor);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isNeedUnderline;
#pragma warning disable 0169
		static Delegate GetIsNeedUnderlineHandler ()
		{
			if (cb_isNeedUnderline == null)
				cb_isNeedUnderline = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNeedUnderline);
			return cb_isNeedUnderline;
		}

		static bool n_IsNeedUnderline (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedUnderline;
		}
#pragma warning restore 0169

		static Delegate cb_setIsNeedUnderline_Z;
#pragma warning disable 0169
		static Delegate GetSetIsNeedUnderline_ZHandler ()
		{
			if (cb_setIsNeedUnderline_Z == null)
				cb_setIsNeedUnderline_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetIsNeedUnderline_Z);
			return cb_setIsNeedUnderline_Z;
		}

		static void n_SetIsNeedUnderline_Z (IntPtr jnienv, IntPtr native__this, bool isNeedUnderline)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsNeedUnderline = isNeedUnderline;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedUnderline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='isNeedUnderline' and count(parameter)=0]"
			[Register ("isNeedUnderline", "()Z", "GetIsNeedUnderlineHandler")]
			get {
				const string __id = "isNeedUnderline.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='setIsNeedUnderline' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsNeedUnderline", "(Z)V", "GetSetIsNeedUnderline_ZHandler")]
			set {
				const string __id = "setIsNeedUnderline.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNormalBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetNormalBackgroundColorHandler ()
		{
			if (cb_getNormalBackgroundColor == null)
				cb_getNormalBackgroundColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNormalBackgroundColor);
			return cb_getNormalBackgroundColor;
		}

		static int n_GetNormalBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalBackgroundColor;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='getNormalBackgroundColor' and count(parameter)=0]"
			[Register ("getNormalBackgroundColor", "()I", "GetGetNormalBackgroundColorHandler")]
			get {
				const string __id = "getNormalBackgroundColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalTextColor;
#pragma warning disable 0169
		static Delegate GetGetNormalTextColorHandler ()
		{
			if (cb_getNormalTextColor == null)
				cb_getNormalTextColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNormalTextColor);
			return cb_getNormalTextColor;
		}

		static int n_GetNormalTextColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setNormalTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetNormalTextColor_IHandler ()
		{
			if (cb_setNormalTextColor_I == null)
				cb_setNormalTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetNormalTextColor_I);
			return cb_setNormalTextColor_I;
		}

		static void n_SetNormalTextColor_I (IntPtr jnienv, IntPtr native__this, int normalTextColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NormalTextColor = normalTextColor;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='getNormalTextColor' and count(parameter)=0]"
			[Register ("getNormalTextColor", "()I", "GetGetNormalTextColorHandler")]
			get {
				const string __id = "getNormalTextColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='setNormalTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNormalTextColor", "(I)V", "GetSetNormalTextColor_IHandler")]
			set {
				const string __id = "setNormalTextColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPressedBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetPressedBackgroundColorHandler ()
		{
			if (cb_getPressedBackgroundColor == null)
				cb_getPressedBackgroundColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPressedBackgroundColor);
			return cb_getPressedBackgroundColor;
		}

		static int n_GetPressedBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PressedBackgroundColor;
		}
#pragma warning restore 0169

		public virtual unsafe int PressedBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='getPressedBackgroundColor' and count(parameter)=0]"
			[Register ("getPressedBackgroundColor", "()I", "GetGetPressedBackgroundColorHandler")]
			get {
				const string __id = "getPressedBackgroundColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPressedTextColor;
#pragma warning disable 0169
		static Delegate GetGetPressedTextColorHandler ()
		{
			if (cb_getPressedTextColor == null)
				cb_getPressedTextColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPressedTextColor);
			return cb_getPressedTextColor;
		}

		static int n_GetPressedTextColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PressedTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setPressedTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetPressedTextColor_IHandler ()
		{
			if (cb_setPressedTextColor_I == null)
				cb_setPressedTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPressedTextColor_I);
			return cb_setPressedTextColor_I;
		}

		static void n_SetPressedTextColor_I (IntPtr jnienv, IntPtr native__this, int pressedTextColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PressedTextColor = pressedTextColor;
		}
#pragma warning restore 0169

		public virtual unsafe int PressedTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='getPressedTextColor' and count(parameter)=0]"
			[Register ("getPressedTextColor", "()I", "GetGetPressedTextColorHandler")]
			get {
				const string __id = "getPressedTextColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='setPressedTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPressedTextColor", "(I)V", "GetSetPressedTextColor_IHandler")]
			set {
				const string __id = "setPressedTextColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			__this.Handle (view, manager, skinIndex, theme);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[3][@type='int'] and parameter[4][@type='android.content.res.Resources.Theme']]"
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

		static Delegate cb_isPressed;
#pragma warning disable 0169
		static Delegate GetIsPressedHandler ()
		{
			if (cb_isPressed == null)
				cb_isPressed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPressed);
			return cb_isPressed;
		}

		static bool n_IsPressed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPressed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='isPressed' and count(parameter)=0]"
		[Register ("isPressed", "()Z", "GetIsPressedHandler")]
		public virtual unsafe bool IsPressed ()
		{
			const string __id = "isPressed.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "")]
		public override sealed unsafe void OnClick (global::Android.Views.View widget)
		{
			const string __id = "onClick.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((widget == null) ? IntPtr.Zero : ((global::Java.Lang.Object) widget).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (widget);
			}
		}

		static Delegate cb_onSpanClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnSpanClick_Landroid_view_View_Handler ()
		{
			if (cb_onSpanClick_Landroid_view_View_ == null)
				cb_onSpanClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSpanClick_Landroid_view_View_);
			return cb_onSpanClick_Landroid_view_View_;
		}

		static void n_OnSpanClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpanClick (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='onSpanClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onSpanClick", "(Landroid/view/View;)V", "GetOnSpanClick_Landroid_view_View_Handler")]
		public abstract void OnSpanClick (global::Android.Views.View p0);

		static Delegate cb_setPressed_Z;
#pragma warning disable 0169
		static Delegate GetSetPressed_ZHandler ()
		{
			if (cb_setPressed_Z == null)
				cb_setPressed_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPressed_Z);
			return cb_setPressed_Z;
		}

		static void n_SetPressed_Z (IntPtr jnienv, IntPtr native__this, bool isSelected)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Span.QMUITouchableSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPressed (isSelected);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='setPressed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPressed", "(Z)V", "GetSetPressed_ZHandler")]
		public virtual unsafe void SetPressed (bool isSelected)
		{
			const string __id = "setPressed.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isSelected);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/span/QMUITouchableSpan", DoNotGenerateAcw=true)]
	internal partial class QMUITouchableSpanInvoker : QMUITouchableSpan {

		public QMUITouchableSpanInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/span/QMUITouchableSpan", typeof (QMUITouchableSpanInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.span']/class[@name='QMUITouchableSpan']/method[@name='onSpanClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onSpanClick", "(Landroid/view/View;)V", "GetOnSpanClick_Landroid_view_View_Handler")]
		public override unsafe void OnSpanClick (global::Android.Views.View p0)
		{
			const string __id = "onSpanClick.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
