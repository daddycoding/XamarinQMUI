using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemView", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheetGridItemView : global::Com.Qmuiteam.Qmui.Layout.QMUIConstraintLayout {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/field[@name='mIconIv']"
		[Register ("mIconIv")]
		protected global::AndroidX.AppCompat.Widget.AppCompatImageView MIconIv {
			get {
				const string __id = "mIconIv.Landroidx/appcompat/widget/AppCompatImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.AppCompat.Widget.AppCompatImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mIconIv.Landroidx/appcompat/widget/AppCompatImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/field[@name='mModelTag']"
		[Register ("mModelTag")]
		protected global::Java.Lang.Object MModelTag {
			get {
				const string __id = "mModelTag.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mModelTag.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/field[@name='mSubscriptIv']"
		[Register ("mSubscriptIv")]
		protected global::AndroidX.AppCompat.Widget.AppCompatImageView MSubscriptIv {
			get {
				const string __id = "mSubscriptIv.Landroidx/appcompat/widget/AppCompatImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.AppCompat.Widget.AppCompatImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSubscriptIv.Landroidx/appcompat/widget/AppCompatImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/field[@name='mTitleTv']"
		[Register ("mTitleTv")]
		protected global::Android.Widget.TextView MTitleTv {
			get {
				const string __id = "mTitleTv.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTitleTv.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemView", typeof (QMUIBottomSheetGridItemView));
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

		protected QMUIBottomSheetGridItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/constructor[@name='QMUIBottomSheetGridItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIBottomSheetGridItemView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/constructor[@name='QMUIBottomSheetGridItemView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIBottomSheetGridItemView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/constructor[@name='QMUIBottomSheetGridItemView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIBottomSheetGridItemView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getModelTag;
#pragma warning disable 0169
		static Delegate GetGetModelTagHandler ()
		{
			if (cb_getModelTag == null)
				cb_getModelTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetModelTag);
			return cb_getModelTag;
		}

		static IntPtr n_GetModelTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModelTag);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object ModelTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/method[@name='getModelTag' and count(parameter)=0]"
			[Register ("getModelTag", "()Ljava/lang/Object;", "GetGetModelTagHandler")]
			get {
				const string __id = "getModelTag.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onCreateIconView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateIconView_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateIconView_Landroid_content_Context_ == null)
				cb_onCreateIconView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateIconView_Landroid_content_Context_);
			return cb_onCreateIconView_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateIconView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateIconView (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/method[@name='onCreateIconView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreateIconView", "(Landroid/content/Context;)Landroidx/appcompat/widget/AppCompatImageView;", "GetOnCreateIconView_Landroid_content_Context_Handler")]
		protected virtual unsafe global::AndroidX.AppCompat.Widget.AppCompatImageView OnCreateIconView (global::Android.Content.Context context)
		{
			const string __id = "onCreateIconView.(Landroid/content/Context;)Landroidx/appcompat/widget/AppCompatImageView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.AppCompat.Widget.AppCompatImageView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateTitleView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateTitleView_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateTitleView_Landroid_content_Context_ == null)
				cb_onCreateTitleView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateTitleView_Landroid_content_Context_);
			return cb_onCreateTitleView_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateTitleView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateTitleView (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/method[@name='onCreateTitleView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreateTitleView", "(Landroid/content/Context;)Landroid/widget/TextView;", "GetOnCreateTitleView_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Android.Widget.TextView OnCreateTitleView (global::Android.Content.Context context)
		{
			const string __id = "onCreateTitleView.(Landroid/content/Context;)Landroid/widget/TextView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_;
#pragma warning disable 0169
		static Delegate GetRender_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Handler ()
		{
			if (cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ == null)
				cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_);
			return cb_render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_;
		}

		static void n_Render_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
			__this.Render (model);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/method[@name='render' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridItemModel']]"
		[Register ("render", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;)V", "GetRender_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Handler")]
		public virtual unsafe void Render (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model)
		{
			const string __id = "render.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (model);
			}
		}

		static Delegate cb_renderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetRenderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_renderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_renderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RenderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_renderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_RenderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_model, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.RenderIcon (model, builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/method[@name='renderIcon' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridItemModel'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("renderIcon", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetRenderIcon_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		protected virtual unsafe void RenderIcon (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model, global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "renderIcon.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
				__args [1] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (model);
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_renderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetRenderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_renderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_renderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RenderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_renderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_RenderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_model, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.RenderSubScript (model, builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/method[@name='renderSubScript' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridItemModel'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("renderSubScript", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetRenderSubScript_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		protected virtual unsafe void RenderSubScript (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model, global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "renderSubScript.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
				__args [1] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (model);
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_renderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetRenderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_renderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_renderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RenderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_renderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_RenderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_model, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.RenderTitle (model, builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemView']/method[@name='renderTitle' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridItemModel'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("renderTitle", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetRenderTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		protected virtual unsafe void RenderTitle (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model, global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "renderTitle.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
				__args [1] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (model);
				global::System.GC.KeepAlive (builder);
			}
		}

	}
}
