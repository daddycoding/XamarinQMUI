using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetBaseBuilder"})]
	public abstract partial class QMUIBottomSheetBaseBuilder : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/field[@name='mDialog']"
		[Register ("mDialog")]
		protected global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet MDialog {
			get {
				const string __id = "mDialog.Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDialog.Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder", typeof (QMUIBottomSheetBaseBuilder));
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

		protected QMUIBottomSheetBaseBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/constructor[@name='QMUIBottomSheetBaseBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIBottomSheetBaseBuilder (global::Android.Content.Context context)
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

		static Delegate cb_hasTitle;
#pragma warning disable 0169
		static Delegate GetHasTitleHandler ()
		{
			if (cb_hasTitle == null)
				cb_hasTitle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasTitle);
			return cb_hasTitle;
		}

		static bool n_HasTitle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTitle;
		}
#pragma warning restore 0169

		protected virtual unsafe bool HasTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='hasTitle' and count(parameter)=0]"
			[Register ("hasTitle", "()Z", "GetHasTitleHandler")]
			get {
				const string __id = "hasTitle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;", "GetBuildHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet Build ()
		{
			const string __id = "build.()Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_build_I;
#pragma warning disable 0169
		static Delegate GetBuild_IHandler ()
		{
			if (cb_build_I == null)
				cb_build_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Build_I);
			return cb_build_I;
		}

		static IntPtr n_Build_I (IntPtr jnienv, IntPtr native__this, int style)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build (style));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("build", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;", "GetBuild_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet Build (int style)
		{
			const string __id = "build.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (style);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler ()
		{
			if (cb_onAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ == null)
				cb_onAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_);
			return cb_onAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
		}

		static void n_OnAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_rootLayout, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
			var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.OnAddCustomViewAfterContent (bottomSheet, rootLayout, context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='onAddCustomViewAfterContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
		[Register ("onAddCustomViewAfterContent", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)V", "GetOnAddCustomViewAfterContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
		protected virtual unsafe void OnAddCustomViewAfterContent (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout rootLayout, global::Android.Content.Context context)
		{
			const string __id = "onAddCustomViewAfterContent.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
				__args [1] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bottomSheet);
				global::System.GC.KeepAlive (rootLayout);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler ()
		{
			if (cb_onAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ == null)
				cb_onAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_);
			return cb_onAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
		}

		static void n_OnAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_rootLayout, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
			var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.OnAddCustomViewBetweenTitleAndContent (bottomSheet, rootLayout, context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='onAddCustomViewBetweenTitleAndContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
		[Register ("onAddCustomViewBetweenTitleAndContent", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)V", "GetOnAddCustomViewBetweenTitleAndContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
		protected virtual unsafe void OnAddCustomViewBetweenTitleAndContent (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout rootLayout, global::Android.Content.Context context)
		{
			const string __id = "onAddCustomViewBetweenTitleAndContent.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
				__args [1] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bottomSheet);
				global::System.GC.KeepAlive (rootLayout);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ == null)
				cb_onCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_);
			return cb_onCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_rootLayout, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
			var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateCancelBtn (bottomSheet, rootLayout, context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='onCreateCancelBtn' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateCancelBtn", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateCancelBtn_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Android.Views.View OnCreateCancelBtn (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout rootLayout, global::Android.Content.Context context)
		{
			const string __id = "onCreateCancelBtn.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
				__args [1] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bottomSheet);
				global::System.GC.KeepAlive (rootLayout);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ == null)
				cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_);
			return cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContentView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='onCreateContentView' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateContentView", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
		protected abstract global::Android.Views.View OnCreateContentView (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout p1, global::Android.Content.Context p2);

		static Delegate cb_onCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ == null)
				cb_onCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_);
			return cb_onCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_rootLayout, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
			var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateTitleView (bottomSheet, rootLayout, context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='onCreateTitleView' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateTitleView", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateTitleView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Android.Views.View OnCreateTitleView (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout rootLayout, global::Android.Content.Context context)
		{
			const string __id = "onCreateTitleView.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
				__args [1] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (bottomSheet);
				global::System.GC.KeepAlive (rootLayout);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_setAddCancelBtn_Z;
#pragma warning disable 0169
		static Delegate GetSetAddCancelBtn_ZHandler ()
		{
			if (cb_setAddCancelBtn_Z == null)
				cb_setAddCancelBtn_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAddCancelBtn_Z);
			return cb_setAddCancelBtn_Z;
		}

		static IntPtr n_SetAddCancelBtn_Z (IntPtr jnienv, IntPtr native__this, bool addCancelBtn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAddCancelBtn (addCancelBtn));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setAddCancelBtn' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAddCancelBtn", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetAddCancelBtn_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetAddCancelBtn (bool addCancelBtn)
		{
			const string __id = "setAddCancelBtn.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (addCancelBtn);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAllowDrag_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowDrag_ZHandler ()
		{
			if (cb_setAllowDrag_Z == null)
				cb_setAllowDrag_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAllowDrag_Z);
			return cb_setAllowDrag_Z;
		}

		static IntPtr n_SetAllowDrag_Z (IntPtr jnienv, IntPtr native__this, bool allowDrag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAllowDrag (allowDrag));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setAllowDrag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowDrag", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetAllowDrag_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetAllowDrag (bool allowDrag)
		{
			const string __id = "setAllowDrag.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allowDrag);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCancelText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCancelText_Ljava_lang_String_Handler ()
		{
			if (cb_setCancelText_Ljava_lang_String_ == null)
				cb_setCancelText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCancelText_Ljava_lang_String_);
			return cb_setCancelText_Ljava_lang_String_;
		}

		static IntPtr n_SetCancelText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cancelText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cancelText = JNIEnv.GetString (native_cancelText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCancelText (cancelText));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setCancelText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCancelText", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetCancelText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object SetCancelText (string cancelText)
		{
			const string __id = "setCancelText.(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			IntPtr native_cancelText = JNIEnv.NewString (cancelText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cancelText);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cancelText);
			}
		}

		static Delegate cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_;
#pragma warning disable 0169
		static Delegate GetSetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_Handler ()
		{
			if (cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_ == null)
				cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_);
			return cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_;
		}

		static IntPtr n_SetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_downDragDecisionMaker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var downDragDecisionMaker = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior.IDownDragDecisionMaker)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior.IDownDragDecisionMaker> (native_downDragDecisionMaker, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDownDragDecisionMaker (downDragDecisionMaker));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setDownDragDecisionMaker' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetBehavior.DownDragDecisionMaker']]"
		[Register ("setDownDragDecisionMaker", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior$DownDragDecisionMaker;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_Handler")]
		public virtual unsafe global::Java.Lang.Object SetDownDragDecisionMaker (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior.IDownDragDecisionMaker downDragDecisionMaker)
		{
			const string __id = "setDownDragDecisionMaker.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior$DownDragDecisionMaker;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((downDragDecisionMaker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downDragDecisionMaker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (downDragDecisionMaker);
			}
		}

		static Delegate cb_setOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_Handler ()
		{
			if (cb_setOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_ == null)
				cb_setOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_);
			return cb_setOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_;
		}

		static IntPtr n_SetOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Android.Content.IDialogInterfaceOnDismissListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnDismissListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnBottomDialogDismissListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setOnBottomDialogDismissListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnDismissListener']]"
		[Register ("setOnBottomDialogDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetOnBottomDialogDismissListener_Landroid_content_DialogInterface_OnDismissListener_Handler")]
		public virtual unsafe global::Java.Lang.Object SetOnBottomDialogDismissListener (global::Android.Content.IDialogInterfaceOnDismissListener listener)
		{
			const string __id = "setOnBottomDialogDismissListener.(Landroid/content/DialogInterface$OnDismissListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static IntPtr n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRadius (radius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRadius", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetRadius_IHandler")]
		public virtual unsafe global::Java.Lang.Object SetRadius (int radius)
		{
			const string __id = "setRadius.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
#pragma warning disable 0169
		static Delegate GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler ()
		{
			if (cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ == null)
				cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_);
			return cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
		}

		static IntPtr n_SetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skinManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSkinManager (skinManager));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setSkinManager' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager']]"
		[Register ("setSkinManager", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler")]
		public virtual unsafe global::Java.Lang.Object SetSkinManager (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager)
		{
			const string __id = "setSkinManager.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (skinManager);
			}
		}

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static IntPtr n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setTitle", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Java.Lang.Object SetTitle (global::Java.Lang.ICharSequence title)
		{
			const string __id = "setTitle.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder;";
			IntPtr native_title = CharSequence.ToLocalJniHandle (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
				global::System.GC.KeepAlive (title);
			}
		}

		public global::Java.Lang.Object SetTitle (string title)
		{
			var jls_title = title == null ? null : new global::Java.Lang.String (title);
			global::Java.Lang.Object __result = SetTitle (jls_title);
			var __rsval = __result;
			jls_title?.Dispose ();
			return __rsval;
		}

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder", DoNotGenerateAcw=true)]
	internal partial class QMUIBottomSheetBaseBuilderInvoker : QMUIBottomSheetBaseBuilder {

		public QMUIBottomSheetBaseBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBaseBuilder", typeof (QMUIBottomSheetBaseBuilderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBaseBuilder']/method[@name='onCreateContentView' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateContentView", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
		protected override unsafe global::Android.Views.View OnCreateContentView (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout p1, global::Android.Content.Context p2)
		{
			const string __id = "onCreateContentView.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}

}
