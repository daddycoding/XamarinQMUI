using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIEmptyView", DoNotGenerateAcw=true)]
	public partial class QMUIEmptyView : global::AndroidX.ConstraintLayout.Widget.ConstraintLayout {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/field[@name='mButton']"
		[Register ("mButton")]
		protected global::Android.Widget.Button MButton {
			get {
				const string __id = "mButton.Landroid/widget/Button;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mButton.Landroid/widget/Button;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIEmptyView", typeof (QMUIEmptyView));
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

		protected QMUIEmptyView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/constructor[@name='QMUIEmptyView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIEmptyView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/constructor[@name='QMUIEmptyView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIEmptyView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/constructor[@name='QMUIEmptyView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIEmptyView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_isLoading;
#pragma warning disable 0169
		static Delegate GetIsLoadingHandler ()
		{
			if (cb_isLoading == null)
				cb_isLoading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoading);
			return cb_isLoading;
		}

		static bool n_IsLoading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler")]
			get {
				const string __id = "isLoading.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				const string __id = "isShowing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler")]
		public virtual unsafe void Hide ()
		{
			const string __id = "hide.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetSetBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_setBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_setBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_setBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_SetBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.SetBtnSkinValue (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setBtnSkinValue' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("setBtnSkinValue", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetSetBtnSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		public virtual unsafe void SetBtnSkinValue (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "setBtnSkinValue.(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_setButton_Ljava_lang_String_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButton_Ljava_lang_String_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setButton_Ljava_lang_String_Landroid_view_View_OnClickListener_ == null)
				cb_setButton_Ljava_lang_String_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetButton_Ljava_lang_String_Landroid_view_View_OnClickListener_);
			return cb_setButton_Ljava_lang_String_Landroid_view_View_OnClickListener_;
		}

		static void n_SetButton_Ljava_lang_String_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_onClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var onClickListener = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetButton (text, onClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setButton' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View.OnClickListener']]"
		[Register ("setButton", "(Ljava/lang/String;Landroid/view/View$OnClickListener;)V", "GetSetButton_Ljava_lang_String_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetButton (string text, global::Android.Views.View.IOnClickListener onClickListener)
		{
			const string __id = "setButton.(Ljava/lang/String;Landroid/view/View$OnClickListener;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (onClickListener);
			}
		}

		static Delegate cb_setDetailColor_I;
#pragma warning disable 0169
		static Delegate GetSetDetailColor_IHandler ()
		{
			if (cb_setDetailColor_I == null)
				cb_setDetailColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDetailColor_I);
			return cb_setDetailColor_I;
		}

		static void n_SetDetailColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDetailColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setDetailColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDetailColor", "(I)V", "GetSetDetailColor_IHandler")]
		public virtual unsafe void SetDetailColor (int color)
		{
			const string __id = "setDetailColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetSetDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_setDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_setDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_setDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_SetDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.SetDetailSkinValue (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setDetailSkinValue' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("setDetailSkinValue", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetSetDetailSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		public virtual unsafe void SetDetailSkinValue (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "setDetailSkinValue.(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_setDetailText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDetailText_Ljava_lang_String_Handler ()
		{
			if (cb_setDetailText_Ljava_lang_String_ == null)
				cb_setDetailText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDetailText_Ljava_lang_String_);
			return cb_setDetailText_Ljava_lang_String_;
		}

		static void n_SetDetailText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.SetDetailText (text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setDetailText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDetailText", "(Ljava/lang/String;)V", "GetSetDetailText_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDetailText (string text)
		{
			const string __id = "setDetailText.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setLoadingShowing_Z;
#pragma warning disable 0169
		static Delegate GetSetLoadingShowing_ZHandler ()
		{
			if (cb_setLoadingShowing_Z == null)
				cb_setLoadingShowing_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetLoadingShowing_Z);
			return cb_setLoadingShowing_Z;
		}

		static void n_SetLoadingShowing_Z (IntPtr jnienv, IntPtr native__this, bool show)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLoadingShowing (show);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setLoadingShowing' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoadingShowing", "(Z)V", "GetSetLoadingShowing_ZHandler")]
		public virtual unsafe void SetLoadingShowing (bool show)
		{
			const string __id = "setLoadingShowing.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (show);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetSetLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_setLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_setLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_setLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_SetLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.SetLoadingSkinValue (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setLoadingSkinValue' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("setLoadingSkinValue", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetSetLoadingSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		public virtual unsafe void SetLoadingSkinValue (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "setLoadingSkinValue.(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_setTitleColor_I;
#pragma warning disable 0169
		static Delegate GetSetTitleColor_IHandler ()
		{
			if (cb_setTitleColor_I == null)
				cb_setTitleColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTitleColor_I);
			return cb_setTitleColor_I;
		}

		static void n_SetTitleColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setTitleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitleColor", "(I)V", "GetSetTitleColor_IHandler")]
		public virtual unsafe void SetTitleColor (int color)
		{
			const string __id = "setTitleColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetSetTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_setTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_setTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_setTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_SetTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleSkinValue (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setTitleSkinValue' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("setTitleSkinValue", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetSetTitleSkinValue_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		public virtual unsafe void SetTitleSkinValue (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "setTitleSkinValue.(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_setTitleText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleText_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleText_Ljava_lang_String_ == null)
				cb_setTitleText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTitleText_Ljava_lang_String_);
			return cb_setTitleText_Ljava_lang_String_;
		}

		static void n_SetTitleText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleText (text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='setTitleText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleText", "(Ljava/lang/String;)V", "GetSetTitleText_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTitleText (string text)
		{
			const string __id = "setTitleText.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual unsafe void Show ()
		{
			const string __id = "show.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_show_Z;
#pragma warning disable 0169
		static Delegate GetShow_ZHandler ()
		{
			if (cb_show_Z == null)
				cb_show_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Show_Z);
			return cb_show_Z;
		}

		static void n_Show_Z (IntPtr jnienv, IntPtr native__this, bool loading)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show (loading);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='show' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("show", "(Z)V", "GetShow_ZHandler")]
		public virtual unsafe void Show (bool loading)
		{
			const string __id = "show.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (loading);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_show_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetShow_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_show_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_ == null)
				cb_show_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLLLL_V) n_Show_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_);
			return cb_show_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_;
		}

		static void n_Show_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, bool loading, IntPtr native_titleText, IntPtr native_detailText, IntPtr native_buttonText, IntPtr native_onButtonClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var titleText = JNIEnv.GetString (native_titleText, JniHandleOwnership.DoNotTransfer);
			var detailText = JNIEnv.GetString (native_detailText, JniHandleOwnership.DoNotTransfer);
			var buttonText = JNIEnv.GetString (native_buttonText, JniHandleOwnership.DoNotTransfer);
			var onButtonClickListener = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_onButtonClickListener, JniHandleOwnership.DoNotTransfer);
			__this.Show (loading, titleText, detailText, buttonText, onButtonClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='show' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.view.View.OnClickListener']]"
		[Register ("show", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/view/View$OnClickListener;)V", "GetShow_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void Show (bool loading, string titleText, string detailText, string buttonText, global::Android.Views.View.IOnClickListener onButtonClickListener)
		{
			const string __id = "show.(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/view/View$OnClickListener;)V";
			IntPtr native_titleText = JNIEnv.NewString (titleText);
			IntPtr native_detailText = JNIEnv.NewString (detailText);
			IntPtr native_buttonText = JNIEnv.NewString (buttonText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (loading);
				__args [1] = new JniArgumentValue (native_titleText);
				__args [2] = new JniArgumentValue (native_detailText);
				__args [3] = new JniArgumentValue (native_buttonText);
				__args [4] = new JniArgumentValue ((onButtonClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onButtonClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				JNIEnv.DeleteLocalRef (native_detailText);
				JNIEnv.DeleteLocalRef (native_buttonText);
				global::System.GC.KeepAlive (onButtonClickListener);
			}
		}

		static Delegate cb_show_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShow_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_show_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_show_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Show_Ljava_lang_String_Ljava_lang_String_);
			return cb_show_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Show_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_titleText, IntPtr native_detailText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIEmptyView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var titleText = JNIEnv.GetString (native_titleText, JniHandleOwnership.DoNotTransfer);
			var detailText = JNIEnv.GetString (native_detailText, JniHandleOwnership.DoNotTransfer);
			__this.Show (titleText, detailText);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIEmptyView']/method[@name='show' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("show", "(Ljava/lang/String;Ljava/lang/String;)V", "GetShow_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Show (string titleText, string detailText)
		{
			const string __id = "show.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_titleText = JNIEnv.NewString (titleText);
			IntPtr native_detailText = JNIEnv.NewString (detailText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_titleText);
				__args [1] = new JniArgumentValue (native_detailText);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				JNIEnv.DeleteLocalRef (native_detailText);
			}
		}

	}
}
