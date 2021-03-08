using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog", DoNotGenerateAcw=true)]
	public partial class QMUIDialog : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBaseDialog {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.AutoResizeDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$AutoResizeDialogBuilder", DoNotGenerateAcw=true)]
		public abstract partial class AutoResizeDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.AutoResizeDialogBuilder']/field[@name='mScrollView']"
			[Register ("mScrollView")]
			protected global::Android.Widget.ScrollView MScrollView {
				get {
					const string __id = "mScrollView.Landroid/widget/ScrollView;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.ScrollView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mScrollView.Landroid/widget/ScrollView;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$AutoResizeDialogBuilder", typeof (AutoResizeDialogBuilder));
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

			protected AutoResizeDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.AutoResizeDialogBuilder']/constructor[@name='QMUIDialog.AutoResizeDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe AutoResizeDialogBuilder (global::Android.Content.Context context)
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

			static Delegate cb_onBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetOnBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_Handler ()
			{
				if (cb_onBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_ == null)
					cb_onBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_OnBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_);
				return cb_onBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_;
			}

			static IntPtr n_OnBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.AutoResizeDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBuildContent (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.AutoResizeDialogBuilder']/method[@name='onBuildContent' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='android.content.Context']]"
			[Register ("onBuildContent", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Landroid/content/Context;)Landroid/view/View;", "GetOnBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_Handler")]
			public abstract global::Android.Views.View OnBuildContent (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog p0, global::Android.Content.Context p1);

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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.AutoResizeDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
				var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (dialog, parent, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.AutoResizeDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
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

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$AutoResizeDialogBuilder", DoNotGenerateAcw=true)]
		internal partial class AutoResizeDialogBuilderInvoker : AutoResizeDialogBuilder {

			public AutoResizeDialogBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$AutoResizeDialogBuilder", typeof (AutoResizeDialogBuilderInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.AutoResizeDialogBuilder']/method[@name='onBuildContent' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='android.content.Context']]"
			[Register ("onBuildContent", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Landroid/content/Context;)Landroid/view/View;", "GetOnBuildContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Landroid_content_Context_Handler")]
			public override unsafe global::Android.Views.View OnBuildContent (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog p0, global::Android.Content.Context p1)
			{
				const string __id = "onBuildContent.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Landroid/content/Context;)Landroid/view/View;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckableDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckableDialogBuilder", DoNotGenerateAcw=true)]
		public partial class CheckableDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckableDialogBuilder", typeof (CheckableDialogBuilder));
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

			protected CheckableDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckableDialogBuilder']/constructor[@name='QMUIDialog.CheckableDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe CheckableDialogBuilder (global::Android.Content.Context context)
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

			static Delegate cb_getCheckedIndex;
#pragma warning disable 0169
			static Delegate GetGetCheckedIndexHandler ()
			{
				if (cb_getCheckedIndex == null)
					cb_getCheckedIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCheckedIndex);
				return cb_getCheckedIndex;
			}

			static int n_GetCheckedIndex (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckedIndex;
			}
#pragma warning restore 0169

			public virtual unsafe int CheckedIndex {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckableDialogBuilder']/method[@name='getCheckedIndex' and count(parameter)=0]"
				[Register ("getCheckedIndex", "()I", "GetGetCheckedIndexHandler")]
				get {
					const string __id = "getCheckedIndex.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetAddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_AddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_items, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var items = (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.ICharSequence));
				var listener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItems (items, listener));
				if (items != null)
					JNIEnv.CopyArray (items, native_items);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckableDialogBuilder']/method[@name='addItems' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence[]'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("addItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckableDialogBuilder;", "GetAddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder AddItems (global::Java.Lang.ICharSequence[] items, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				const string __id = "addItems.([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckableDialogBuilder;";
				IntPtr native_items = JNIEnv.NewArray (items);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_items);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (items != null) {
						JNIEnv.CopyArray (native_items, items);
						JNIEnv.DeleteLocalRef (native_items);
					}
					global::System.GC.KeepAlive (items);
					global::System.GC.KeepAlive (listener);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder AddItems (string[] items, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				var jlca_items = CharSequence.ArrayFromStringArray(items);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder __result = AddItems (jlca_items, listener);
				var __rsval = __result;
				if (jlca_items != null) foreach (var s in jlca_items) s?.Dispose ();
				return __rsval;
			}

			static Delegate cb_setCheckedIndex_I;
#pragma warning disable 0169
			static Delegate GetSetCheckedIndex_IHandler ()
			{
				if (cb_setCheckedIndex_I == null)
					cb_setCheckedIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetCheckedIndex_I);
				return cb_setCheckedIndex_I;
			}

			static IntPtr n_SetCheckedIndex_I (IntPtr jnienv, IntPtr native__this, int checkedIndex)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCheckedIndex (checkedIndex));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckableDialogBuilder']/method[@name='setCheckedIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCheckedIndex", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckableDialogBuilder;", "GetSetCheckedIndex_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder SetCheckedIndex (int checkedIndex)
			{
				const string __id = "setCheckedIndex.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckableDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (checkedIndex);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckableDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder", DoNotGenerateAcw=true)]
		public partial class CheckBoxMessageDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/field[@name='mMessage']"
			[Register ("mMessage")]
			protected string MMessage {
				get {
					const string __id = "mMessage.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mMessage.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder", typeof (CheckBoxMessageDialogBuilder));
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

			protected CheckBoxMessageDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/constructor[@name='QMUIDialog.CheckBoxMessageDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe CheckBoxMessageDialogBuilder (global::Android.Content.Context context)
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

			static Delegate cb_isChecked;
#pragma warning disable 0169
			static Delegate GetIsCheckedHandler ()
			{
				if (cb_isChecked == null)
					cb_isChecked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsChecked);
				return cb_isChecked;
			}

			static bool n_IsChecked (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsChecked;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsChecked {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/method[@name='isChecked' and count(parameter)=0]"
				[Register ("isChecked", "()Z", "GetIsCheckedHandler")]
				get {
					const string __id = "isChecked.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getTextView;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetGetTextViewHandler ()
			{
				if (cb_getTextView == null)
					cb_getTextView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTextView);
				return cb_getTextView;
			}

			[Obsolete]
			static IntPtr n_GetTextView (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextView);
			}
#pragma warning restore 0169

			[Obsolete (@"deprecated")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Textview.QMUISpanTouchFixTextView TextView {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/method[@name='getTextView' and count(parameter)=0]"
				[Register ("getTextView", "()Lcom/qmuiteam/qmui/widget/textview/QMUISpanTouchFixTextView;", "GetGetTextViewHandler")]
				get {
					const string __id = "getTextView.()Lcom/qmuiteam/qmui/widget/textview/QMUISpanTouchFixTextView;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Textview.QMUISpanTouchFixTextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
				var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (dialog, parent, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
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

			static Delegate cb_setChecked_Z;
#pragma warning disable 0169
			static Delegate GetSetChecked_ZHandler ()
			{
				if (cb_setChecked_Z == null)
					cb_setChecked_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetChecked_Z);
				return cb_setChecked_Z;
			}

			static IntPtr n_SetChecked_Z (IntPtr jnienv, IntPtr native__this, bool @checked)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetChecked (@checked));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/method[@name='setChecked' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setChecked", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder;", "GetSetChecked_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder SetChecked (bool @checked)
			{
				const string __id = "setChecked.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (@checked);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMessage_I;
#pragma warning disable 0169
			static Delegate GetSetMessage_IHandler ()
			{
				if (cb_setMessage_I == null)
					cb_setMessage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetMessage_I);
				return cb_setMessage_I;
			}

			static IntPtr n_SetMessage_I (IntPtr jnienv, IntPtr native__this, int resid)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMessage (resid));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessage", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder;", "GetSetMessage_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder SetMessage (int resid)
			{
				const string __id = "setMessage.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resid);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetMessage_Ljava_lang_String_Handler ()
			{
				if (cb_setMessage_Ljava_lang_String_ == null)
					cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetMessage_Ljava_lang_String_);
				return cb_setMessage_Ljava_lang_String_;
			}

			static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (message));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CheckBoxMessageDialogBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder;", "GetSetMessage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder SetMessage (string message)
			{
				const string __id = "setMessage.(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CheckBoxMessageDialogBuilder;";
				IntPtr native_message = JNIEnv.NewString (message);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_message);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CheckBoxMessageDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CustomDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$CustomDialogBuilder", DoNotGenerateAcw=true)]
		public partial class CustomDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$CustomDialogBuilder", typeof (CustomDialogBuilder));
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

			protected CustomDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CustomDialogBuilder']/constructor[@name='QMUIDialog.CustomDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe CustomDialogBuilder (global::Android.Content.Context context)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CustomDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
				var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (dialog, parent, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CustomDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
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

			static Delegate cb_setLayout_I;
#pragma warning disable 0169
			static Delegate GetSetLayout_IHandler ()
			{
				if (cb_setLayout_I == null)
					cb_setLayout_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetLayout_I);
				return cb_setLayout_I;
			}

			static IntPtr n_SetLayout_I (IntPtr jnienv, IntPtr native__this, int layoutResId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CustomDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetLayout (layoutResId));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.CustomDialogBuilder']/method[@name='setLayout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLayout", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CustomDialogBuilder;", "GetSetLayout_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CustomDialogBuilder SetLayout (int layoutResId)
			{
				const string __id = "setLayout.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$CustomDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (layoutResId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.CustomDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder", DoNotGenerateAcw=true)]
		public partial class EditTextDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/field[@name='mEditText']"
			[Register ("mEditText")]
			protected global::Android.Widget.EditText MEditText {
				get {
					const string __id = "mEditText.Landroid/widget/EditText;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mEditText.Landroid/widget/EditText;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/field[@name='mPlaceholder']"
			[Register ("mPlaceholder")]
			protected string MPlaceholder {
				get {
					const string __id = "mPlaceholder.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mPlaceholder.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/field[@name='mRightImageView']"
			[Register ("mRightImageView")]
			protected global::AndroidX.AppCompat.Widget.AppCompatImageView MRightImageView {
				get {
					const string __id = "mRightImageView.Landroidx/appcompat/widget/AppCompatImageView;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::AndroidX.AppCompat.Widget.AppCompatImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mRightImageView.Landroidx/appcompat/widget/AppCompatImageView;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/field[@name='mTransformationMethod']"
			[Register ("mTransformationMethod")]
			protected global::Android.Text.Method.ITransformationMethod MTransformationMethod {
				get {
					const string __id = "mTransformationMethod.Landroid/text/method/TransformationMethod;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Text.Method.ITransformationMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mTransformationMethod.Landroid/text/method/TransformationMethod;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder", typeof (EditTextDialogBuilder));
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

			protected EditTextDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/constructor[@name='QMUIDialog.EditTextDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe EditTextDialogBuilder (global::Android.Content.Context context)
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

			static Delegate cb_getEditText;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetGetEditTextHandler ()
			{
				if (cb_getEditText == null)
					cb_getEditText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEditText);
				return cb_getEditText;
			}

			[Obsolete]
			static IntPtr n_GetEditText (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.EditText);
			}
#pragma warning restore 0169

			[Obsolete (@"deprecated")]
			public virtual unsafe global::Android.Widget.EditText EditText {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='getEditText' and count(parameter)=0]"
				[Register ("getEditText", "()Landroid/widget/EditText;", "GetGetEditTextHandler")]
				get {
					const string __id = "getEditText.()Landroid/widget/EditText;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getRightImageView;
#pragma warning disable 0169
			static Delegate GetGetRightImageViewHandler ()
			{
				if (cb_getRightImageView == null)
					cb_getRightImageView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRightImageView);
				return cb_getRightImageView;
			}

			static IntPtr n_GetRightImageView (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RightImageView);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Widget.ImageView RightImageView {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='getRightImageView' and count(parameter)=0]"
				[Register ("getRightImageView", "()Landroid/widget/ImageView;", "GetGetRightImageViewHandler")]
				get {
					const string __id = "getRightImageView.()Landroid/widget/ImageView;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_configRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_;
#pragma warning disable 0169
			static Delegate GetConfigRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_Handler ()
			{
				if (cb_configRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_ == null)
					cb_configRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ConfigRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_);
				return cb_configRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_;
			}

			static void n_ConfigRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageView, IntPtr native_editText)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var imageView = global::Java.Lang.Object.GetObject<global::AndroidX.AppCompat.Widget.AppCompatImageView> (native_imageView, JniHandleOwnership.DoNotTransfer);
				var editText = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (native_editText, JniHandleOwnership.DoNotTransfer);
				__this.ConfigRightImageView (imageView, editText);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='configRightImageView' and count(parameter)=2 and parameter[1][@type='androidx.appcompat.widget.AppCompatImageView'] and parameter[2][@type='android.widget.EditText']]"
			[Register ("configRightImageView", "(Landroidx/appcompat/widget/AppCompatImageView;Landroid/widget/EditText;)V", "GetConfigRightImageView_Landroidx_appcompat_widget_AppCompatImageView_Landroid_widget_EditText_Handler")]
			protected virtual unsafe void ConfigRightImageView (global::AndroidX.AppCompat.Widget.AppCompatImageView imageView, global::Android.Widget.EditText editText)
			{
				const string __id = "configRightImageView.(Landroidx/appcompat/widget/AppCompatImageView;Landroid/widget/EditText;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((imageView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageView).Handle);
					__args [1] = new JniArgumentValue ((editText == null) ? IntPtr.Zero : ((global::Java.Lang.Object) editText).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (imageView);
					global::System.GC.KeepAlive (editText);
				}
			}

			static Delegate cb_createEditTextLayoutParams_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetCreateEditTextLayoutParams_Landroid_content_Context_Handler ()
			{
				if (cb_createEditTextLayoutParams_Landroid_content_Context_ == null)
					cb_createEditTextLayoutParams_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateEditTextLayoutParams_Landroid_content_Context_);
				return cb_createEditTextLayoutParams_Landroid_content_Context_;
			}

			static IntPtr n_CreateEditTextLayoutParams_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateEditTextLayoutParams (context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='createEditTextLayoutParams' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("createEditTextLayoutParams", "(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;", "GetCreateEditTextLayoutParams_Landroid_content_Context_Handler")]
			protected virtual unsafe global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams CreateEditTextLayoutParams (global::Android.Content.Context context)
			{
				const string __id = "createEditTextLayoutParams.(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_createRightIconLayoutParams_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetCreateRightIconLayoutParams_Landroid_content_Context_Handler ()
			{
				if (cb_createRightIconLayoutParams_Landroid_content_Context_ == null)
					cb_createRightIconLayoutParams_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateRightIconLayoutParams_Landroid_content_Context_);
				return cb_createRightIconLayoutParams_Landroid_content_Context_;
			}

			static IntPtr n_CreateRightIconLayoutParams_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRightIconLayoutParams (context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='createRightIconLayoutParams' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("createRightIconLayoutParams", "(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;", "GetCreateRightIconLayoutParams_Landroid_content_Context_Handler")]
			protected virtual unsafe global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams CreateRightIconLayoutParams (global::Android.Content.Context context)
			{
				const string __id = "createRightIconLayoutParams.(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
				var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (dialog, parent, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
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

			static Delegate cb_setDefaultText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetDefaultText_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setDefaultText_Ljava_lang_CharSequence_ == null)
					cb_setDefaultText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDefaultText_Ljava_lang_CharSequence_);
				return cb_setDefaultText_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetDefaultText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultText)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var defaultText = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_defaultText, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDefaultText (defaultText));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='setDefaultText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setDefaultText", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;", "GetSetDefaultText_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder SetDefaultText (global::Java.Lang.ICharSequence defaultText)
			{
				const string __id = "setDefaultText.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;";
				IntPtr native_defaultText = CharSequence.ToLocalJniHandle (defaultText);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_defaultText);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_defaultText);
					global::System.GC.KeepAlive (defaultText);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder SetDefaultText (string defaultText)
			{
				var jls_defaultText = defaultText == null ? null : new global::Java.Lang.String (defaultText);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder __result = SetDefaultText (jls_defaultText);
				var __rsval = __result;
				jls_defaultText?.Dispose ();
				return __rsval;
			}

			static Delegate cb_setInputType_I;
#pragma warning disable 0169
			static Delegate GetSetInputType_IHandler ()
			{
				if (cb_setInputType_I == null)
					cb_setInputType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetInputType_I);
				return cb_setInputType_I;
			}

			static IntPtr n_SetInputType_I (IntPtr jnienv, IntPtr native__this, int inputType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetInputType (inputType));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='setInputType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInputType", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;", "GetSetInputType_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder SetInputType (int inputType)
			{
				const string __id = "setInputType.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (inputType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPlaceholder_I;
#pragma warning disable 0169
			static Delegate GetSetPlaceholder_IHandler ()
			{
				if (cb_setPlaceholder_I == null)
					cb_setPlaceholder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetPlaceholder_I);
				return cb_setPlaceholder_I;
			}

			static IntPtr n_SetPlaceholder_I (IntPtr jnienv, IntPtr native__this, int resId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPlaceholder (resId));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='setPlaceholder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPlaceholder", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;", "GetSetPlaceholder_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder SetPlaceholder (int resId)
			{
				const string __id = "setPlaceholder.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPlaceholder_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPlaceholder_Ljava_lang_String_Handler ()
			{
				if (cb_setPlaceholder_Ljava_lang_String_ == null)
					cb_setPlaceholder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetPlaceholder_Ljava_lang_String_);
				return cb_setPlaceholder_Ljava_lang_String_;
			}

			static IntPtr n_SetPlaceholder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_placeholder)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var placeholder = JNIEnv.GetString (native_placeholder, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlaceholder (placeholder));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='setPlaceholder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPlaceholder", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;", "GetSetPlaceholder_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder SetPlaceholder (string placeholder)
			{
				const string __id = "setPlaceholder.(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;";
				IntPtr native_placeholder = JNIEnv.NewString (placeholder);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_placeholder);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_placeholder);
				}
			}

			static Delegate cb_setTextWatcher_Landroid_text_TextWatcher_;
#pragma warning disable 0169
			static Delegate GetSetTextWatcher_Landroid_text_TextWatcher_Handler ()
			{
				if (cb_setTextWatcher_Landroid_text_TextWatcher_ == null)
					cb_setTextWatcher_Landroid_text_TextWatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTextWatcher_Landroid_text_TextWatcher_);
				return cb_setTextWatcher_Landroid_text_TextWatcher_;
			}

			static IntPtr n_SetTextWatcher_Landroid_text_TextWatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textWatcher)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var textWatcher = (global::Android.Text.ITextWatcher)global::Java.Lang.Object.GetObject<global::Android.Text.ITextWatcher> (native_textWatcher, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTextWatcher (textWatcher));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='setTextWatcher' and count(parameter)=1 and parameter[1][@type='android.text.TextWatcher']]"
			[Register ("setTextWatcher", "(Landroid/text/TextWatcher;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;", "GetSetTextWatcher_Landroid_text_TextWatcher_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder SetTextWatcher (global::Android.Text.ITextWatcher textWatcher)
			{
				const string __id = "setTextWatcher.(Landroid/text/TextWatcher;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((textWatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textWatcher).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (textWatcher);
				}
			}

			static Delegate cb_setTransformationMethod_Landroid_text_method_TransformationMethod_;
#pragma warning disable 0169
			static Delegate GetSetTransformationMethod_Landroid_text_method_TransformationMethod_Handler ()
			{
				if (cb_setTransformationMethod_Landroid_text_method_TransformationMethod_ == null)
					cb_setTransformationMethod_Landroid_text_method_TransformationMethod_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTransformationMethod_Landroid_text_method_TransformationMethod_);
				return cb_setTransformationMethod_Landroid_text_method_TransformationMethod_;
			}

			static IntPtr n_SetTransformationMethod_Landroid_text_method_TransformationMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformationMethod)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var transformationMethod = (global::Android.Text.Method.ITransformationMethod)global::Java.Lang.Object.GetObject<global::Android.Text.Method.ITransformationMethod> (native_transformationMethod, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTransformationMethod (transformationMethod));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.EditTextDialogBuilder']/method[@name='setTransformationMethod' and count(parameter)=1 and parameter[1][@type='android.text.method.TransformationMethod']]"
			[Register ("setTransformationMethod", "(Landroid/text/method/TransformationMethod;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;", "GetSetTransformationMethod_Landroid_text_method_TransformationMethod_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder SetTransformationMethod (global::Android.Text.Method.ITransformationMethod transformationMethod)
			{
				const string __id = "setTransformationMethod.(Landroid/text/method/TransformationMethod;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$EditTextDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((transformationMethod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformationMethod).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.EditTextDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (transformationMethod);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuBaseDialogBuilder", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.qmuiteam.qmui.widget.dialog.QMUIDialogBuilder"})]
		public partial class MenuBaseDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/field[@name='mMenuItemViews']"
			[Register ("mMenuItemViews")]
			protected global::System.Collections.IList MMenuItemViews {
				get {
					const string __id = "mMenuItemViews.Ljava/util/ArrayList;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mMenuItemViews.Ljava/util/ArrayList;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/field[@name='mMenuItemViewsFactoryList']"
			[Register ("mMenuItemViewsFactoryList")]
			protected global::System.Collections.IList MMenuItemViewsFactoryList {
				get {
					const string __id = "mMenuItemViewsFactoryList.Ljava/util/ArrayList;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mMenuItemViewsFactoryList.Ljava/util/ArrayList;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialog.MenuBaseDialogBuilder.ItemViewFactory']"
			[Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuBaseDialogBuilder$ItemViewFactory", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog/MenuBaseDialogBuilder/IItemViewFactoryInvoker")]
			public partial interface IItemViewFactory : IJavaObject, IJavaPeerable {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialog.MenuBaseDialogBuilder.ItemViewFactory']/method[@name='createItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
				[Register ("createItemView", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView;", "GetCreateItemView_Landroid_content_Context_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog/MenuBaseDialogBuilder/IItemViewFactoryInvoker, QMUI.Droid")]
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView CreateItemView (global::Android.Content.Context p0);

			}

			[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuBaseDialogBuilder$ItemViewFactory", DoNotGenerateAcw=true)]
			internal partial class IItemViewFactoryInvoker : global::Java.Lang.Object, IItemViewFactory {

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuBaseDialogBuilder$ItemViewFactory", typeof (IItemViewFactoryInvoker));

				static IntPtr java_class_ref {
					get { return _members.JniPeerType.PeerReference.Handle; }
				}

				public override global::Java.Interop.JniPeerMembers JniPeerMembers {
					get { return _members; }
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return _members.ManagedPeerType; }
				}

				IntPtr class_ref;

				public static IItemViewFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IItemViewFactory> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIDialog.MenuBaseDialogBuilder.ItemViewFactory"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IItemViewFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				static Delegate cb_createItemView_Landroid_content_Context_;
#pragma warning disable 0169
				static Delegate GetCreateItemView_Landroid_content_Context_Handler ()
				{
					if (cb_createItemView_Landroid_content_Context_ == null)
						cb_createItemView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateItemView_Landroid_content_Context_);
					return cb_createItemView_Landroid_content_Context_;
				}

				static IntPtr n_CreateItemView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder.IItemViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateItemView (p0));
					return __ret;
				}
#pragma warning restore 0169

				IntPtr id_createItemView_Landroid_content_Context_;
				public unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView CreateItemView (global::Android.Content.Context p0)
				{
					if (id_createItemView_Landroid_content_Context_ == IntPtr.Zero)
						id_createItemView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "createItemView", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView;");
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __ret = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createItemView_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

			}


			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuBaseDialogBuilder", typeof (MenuBaseDialogBuilder));
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

			protected MenuBaseDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/constructor[@name='QMUIDialog.MenuBaseDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe MenuBaseDialogBuilder (global::Android.Content.Context context)
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

			static Delegate cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_);
				return cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_itemViewFactory, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var itemViewFactory = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder.IItemViewFactory)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder.IItemViewFactory> (native_itemViewFactory, JniHandleOwnership.DoNotTransfer);
				var listener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (itemViewFactory, listener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog.MenuBaseDialogBuilder.ItemViewFactory'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("addItem", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuBaseDialogBuilder$ItemViewFactory;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_MenuBaseDialogBuilder_ItemViewFactory_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Java.Lang.Object AddItem (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder.IItemViewFactory itemViewFactory, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				const string __id = "addItem.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuBaseDialogBuilder$ItemViewFactory;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((itemViewFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemViewFactory).Handle);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (itemViewFactory);
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_);
				return cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_;
			}

			[Obsolete]
			static IntPtr n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_itemView, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var itemView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (native_itemView, JniHandleOwnership.DoNotTransfer);
				var listener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (itemView, listener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogMenuItemView'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Obsolete (@"deprecated")]
			[Register ("addItem", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Java.Lang.Object AddItem (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView itemView, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				const string __id = "addItem.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((itemView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemView).Handle);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (itemView);
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate cb_clear;
#pragma warning disable 0169
			static Delegate GetClearHandler ()
			{
				if (cb_clear == null)
					cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
				return cb_clear;
			}

			static void n_Clear (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public virtual unsafe void Clear ()
			{
				const string __id = "clear.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
				var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (dialog, parent, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
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

			static Delegate cb_onItemClick_I;
#pragma warning disable 0169
			static Delegate GetOnItemClick_IHandler ()
			{
				if (cb_onItemClick_I == null)
					cb_onItemClick_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnItemClick_I);
				return cb_onItemClick_I;
			}

			static void n_OnItemClick_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnItemClick (index);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuBaseDialogBuilder']/method[@name='onItemClick' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onItemClick", "(I)V", "GetOnItemClick_IHandler")]
			protected virtual unsafe void OnItemClick (int index)
			{
				const string __id = "onItemClick.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuDialogBuilder", DoNotGenerateAcw=true)]
		public partial class MenuDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuDialogBuilder", typeof (MenuDialogBuilder));
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

			protected MenuDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuDialogBuilder']/constructor[@name='QMUIDialog.MenuDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe MenuDialogBuilder (global::Android.Content.Context context)
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

			static Delegate cb_addItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetAddItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_addItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_addItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_addItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_AddItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var item = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_item, JniHandleOwnership.DoNotTransfer);
				var listener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (item, listener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuDialogBuilder']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("addItem", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuDialogBuilder;", "GetAddItem_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder AddItem (global::Java.Lang.ICharSequence item, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				const string __id = "addItem.(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuDialogBuilder;";
				IntPtr native_item = CharSequence.ToLocalJniHandle (item);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_item);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_item);
					global::System.GC.KeepAlive (item);
					global::System.GC.KeepAlive (listener);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder AddItem (string item, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				var jls_item = item == null ? null : new global::Java.Lang.String (item);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder __result = AddItem (jls_item, listener);
				var __rsval = __result;
				jls_item?.Dispose ();
				return __rsval;
			}

			static Delegate cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetAddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_AddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_items, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var items = (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.ICharSequence));
				var listener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItems (items, listener));
				if (items != null)
					JNIEnv.CopyArray (items, native_items);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MenuDialogBuilder']/method[@name='addItems' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence[]'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("addItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuDialogBuilder;", "GetAddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder AddItems (global::Java.Lang.ICharSequence[] items, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				const string __id = "addItems.([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MenuDialogBuilder;";
				IntPtr native_items = JNIEnv.NewArray (items);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_items);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (items != null) {
						JNIEnv.CopyArray (native_items, items);
						JNIEnv.DeleteLocalRef (native_items);
					}
					global::System.GC.KeepAlive (items);
					global::System.GC.KeepAlive (listener);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder AddItems (string[] items, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				var jlca_items = CharSequence.ArrayFromStringArray(items);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuDialogBuilder __result = AddItems (jlca_items, listener);
				var __rsval = __result;
				if (jlca_items != null) foreach (var s in jlca_items) s?.Dispose ();
				return __rsval;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MessageDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MessageDialogBuilder", DoNotGenerateAcw=true)]
		public partial class MessageDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MessageDialogBuilder']/field[@name='mMessage']"
			[Register ("mMessage")]
			protected global::Java.Lang.ICharSequence MMessage {
				get {
					const string __id = "mMessage.Ljava/lang/CharSequence;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mMessage.Ljava/lang/CharSequence;";

					IntPtr native_value = CharSequence.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MessageDialogBuilder", typeof (MessageDialogBuilder));
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

			protected MessageDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MessageDialogBuilder']/constructor[@name='QMUIDialog.MessageDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe MessageDialogBuilder (global::Android.Content.Context context)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MessageDialogBuilder']/method[@name='assignMessageTvWithAttr' and count(parameter)=3 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
			[Register ("assignMessageTvWithAttr", "(Landroid/widget/TextView;ZI)V", "")]
			public static unsafe void AssignMessageTvWithAttr (global::Android.Widget.TextView messageTv, bool hasTitle, int defAttr)
			{
				const string __id = "assignMessageTvWithAttr.(Landroid/widget/TextView;ZI)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((messageTv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) messageTv).Handle);
					__args [1] = new JniArgumentValue (hasTitle);
					__args [2] = new JniArgumentValue (defAttr);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (messageTv);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
				var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (dialog, parent, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MessageDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
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

			static Delegate cb_setMessage_I;
#pragma warning disable 0169
			static Delegate GetSetMessage_IHandler ()
			{
				if (cb_setMessage_I == null)
					cb_setMessage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetMessage_I);
				return cb_setMessage_I;
			}

			static IntPtr n_SetMessage_I (IntPtr jnienv, IntPtr native__this, int resId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMessage (resId));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MessageDialogBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessage", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MessageDialogBuilder;", "GetSetMessage_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder SetMessage (int resId)
			{
				const string __id = "setMessage.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MessageDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (resId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMessage_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetMessage_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setMessage_Ljava_lang_CharSequence_ == null)
					cb_setMessage_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetMessage_Ljava_lang_CharSequence_);
				return cb_setMessage_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetMessage_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var message = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_message, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (message));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MessageDialogBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setMessage", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MessageDialogBuilder;", "GetSetMessage_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder SetMessage (global::Java.Lang.ICharSequence message)
			{
				const string __id = "setMessage.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MessageDialogBuilder;";
				IntPtr native_message = CharSequence.ToLocalJniHandle (message);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_message);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_message);
					global::System.GC.KeepAlive (message);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder SetMessage (string message)
			{
				var jls_message = message == null ? null : new global::Java.Lang.String (message);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MessageDialogBuilder __result = SetMessage (jls_message);
				var __rsval = __result;
				jls_message?.Dispose ();
				return __rsval;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder", DoNotGenerateAcw=true)]
		public partial class MultiCheckableDialogBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MenuBaseDialogBuilder {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder", typeof (MultiCheckableDialogBuilder));
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

			protected MultiCheckableDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']/constructor[@name='QMUIDialog.MultiCheckableDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe MultiCheckableDialogBuilder (global::Android.Content.Context context)
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

			static Delegate cb_getCheckedItemRecord;
#pragma warning disable 0169
			static Delegate GetGetCheckedItemRecordHandler ()
			{
				if (cb_getCheckedItemRecord == null)
					cb_getCheckedItemRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCheckedItemRecord);
				return cb_getCheckedItemRecord;
			}

			static IntPtr n_GetCheckedItemRecord (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CheckedItemRecord);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Util.BitSet CheckedItemRecord {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']/method[@name='getCheckedItemRecord' and count(parameter)=0]"
				[Register ("getCheckedItemRecord", "()Ljava/util/BitSet;", "GetGetCheckedItemRecordHandler")]
				get {
					const string __id = "getCheckedItemRecord.()Ljava/util/BitSet;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Util.BitSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetAddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_addItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_AddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_items, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var items = (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (native_items, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.ICharSequence));
				var listener = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItems (items, listener));
				if (items != null)
					JNIEnv.CopyArray (items, native_items);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']/method[@name='addItems' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence[]'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("addItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder;", "GetAddItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder AddItems (global::Java.Lang.ICharSequence[] items, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				const string __id = "addItems.([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder;";
				IntPtr native_items = JNIEnv.NewArray (items);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_items);
					__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (items != null) {
						JNIEnv.CopyArray (native_items, items);
						JNIEnv.DeleteLocalRef (native_items);
					}
					global::System.GC.KeepAlive (items);
					global::System.GC.KeepAlive (listener);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder AddItems (string[] items, global::Android.Content.IDialogInterfaceOnClickListener listener)
			{
				var jlca_items = CharSequence.ArrayFromStringArray(items);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder __result = AddItems (jlca_items, listener);
				var __rsval = __result;
				if (jlca_items != null) foreach (var s in jlca_items) s?.Dispose ();
				return __rsval;
			}

			static Delegate cb_existCheckedItem;
#pragma warning disable 0169
			static Delegate GetExistCheckedItemHandler ()
			{
				if (cb_existCheckedItem == null)
					cb_existCheckedItem = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ExistCheckedItem);
				return cb_existCheckedItem;
			}

			static bool n_ExistCheckedItem (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ExistCheckedItem ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']/method[@name='existCheckedItem' and count(parameter)=0]"
			[Register ("existCheckedItem", "()Z", "GetExistCheckedItemHandler")]
			protected virtual unsafe bool ExistCheckedItem ()
			{
				const string __id = "existCheckedItem.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_getCheckedItemIndexes;
#pragma warning disable 0169
			static Delegate GetGetCheckedItemIndexesHandler ()
			{
				if (cb_getCheckedItemIndexes == null)
					cb_getCheckedItemIndexes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCheckedItemIndexes);
				return cb_getCheckedItemIndexes;
			}

			static IntPtr n_GetCheckedItemIndexes (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetCheckedItemIndexes ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']/method[@name='getCheckedItemIndexes' and count(parameter)=0]"
			[Register ("getCheckedItemIndexes", "()[I", "GetGetCheckedItemIndexesHandler")]
			public virtual unsafe int[] GetCheckedItemIndexes ()
			{
				const string __id = "getCheckedItemIndexes.()[I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
				} finally {
				}
			}

			static Delegate cb_setCheckedItems_arrayI;
#pragma warning disable 0169
			static Delegate GetSetCheckedItems_arrayIHandler ()
			{
				if (cb_setCheckedItems_arrayI == null)
					cb_setCheckedItems_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCheckedItems_arrayI);
				return cb_setCheckedItems_arrayI;
			}

			static IntPtr n_SetCheckedItems_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_checkedIndexes)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var checkedIndexes = (int[]) JNIEnv.GetArray (native_checkedIndexes, JniHandleOwnership.DoNotTransfer, typeof (int));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCheckedItems (checkedIndexes));
				if (checkedIndexes != null)
					JNIEnv.CopyArray (checkedIndexes, native_checkedIndexes);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']/method[@name='setCheckedItems' and count(parameter)=1 and parameter[1][@type='int[]']]"
			[Register ("setCheckedItems", "([I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder;", "GetSetCheckedItems_arrayIHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder SetCheckedItems (int[] checkedIndexes)
			{
				const string __id = "setCheckedItems.([I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder;";
				IntPtr native_checkedIndexes = JNIEnv.NewArray (checkedIndexes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_checkedIndexes);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (checkedIndexes != null) {
						JNIEnv.CopyArray (native_checkedIndexes, checkedIndexes);
						JNIEnv.DeleteLocalRef (native_checkedIndexes);
					}
					global::System.GC.KeepAlive (checkedIndexes);
				}
			}

			static Delegate cb_setCheckedItems_Ljava_util_BitSet_;
#pragma warning disable 0169
			static Delegate GetSetCheckedItems_Ljava_util_BitSet_Handler ()
			{
				if (cb_setCheckedItems_Ljava_util_BitSet_ == null)
					cb_setCheckedItems_Ljava_util_BitSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCheckedItems_Ljava_util_BitSet_);
				return cb_setCheckedItems_Ljava_util_BitSet_;
			}

			static IntPtr n_SetCheckedItems_Ljava_util_BitSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_checkedItems)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var checkedItems = global::Java.Lang.Object.GetObject<global::Java.Util.BitSet> (native_checkedItems, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCheckedItems (checkedItems));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog.MultiCheckableDialogBuilder']/method[@name='setCheckedItems' and count(parameter)=1 and parameter[1][@type='java.util.BitSet']]"
			[Register ("setCheckedItems", "(Ljava/util/BitSet;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder;", "GetSetCheckedItems_Ljava_util_BitSet_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder SetCheckedItems (global::Java.Util.BitSet checkedItems)
			{
				const string __id = "setCheckedItems.(Ljava/util/BitSet;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog$MultiCheckableDialogBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((checkedItems == null) ? IntPtr.Zero : ((global::Java.Lang.Object) checkedItems).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog.MultiCheckableDialogBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (checkedItems);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialog", typeof (QMUIDialog));
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

		protected QMUIDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog']/constructor[@name='QMUIDialog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIDialog (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog']/constructor[@name='QMUIDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe QMUIDialog (global::Android.Content.Context context, int styleRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (styleRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_showWithImmersiveCheck;
#pragma warning disable 0169
		static Delegate GetShowWithImmersiveCheckHandler ()
		{
			if (cb_showWithImmersiveCheck == null)
				cb_showWithImmersiveCheck = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ShowWithImmersiveCheck);
			return cb_showWithImmersiveCheck;
		}

		static void n_ShowWithImmersiveCheck (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowWithImmersiveCheck ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog']/method[@name='showWithImmersiveCheck' and count(parameter)=0]"
		[Register ("showWithImmersiveCheck", "()V", "GetShowWithImmersiveCheckHandler")]
		public virtual unsafe void ShowWithImmersiveCheck ()
		{
			const string __id = "showWithImmersiveCheck.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_showWithImmersiveCheck_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetShowWithImmersiveCheck_Landroid_app_Activity_Handler ()
		{
			if (cb_showWithImmersiveCheck_Landroid_app_Activity_ == null)
				cb_showWithImmersiveCheck_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ShowWithImmersiveCheck_Landroid_app_Activity_);
			return cb_showWithImmersiveCheck_Landroid_app_Activity_;
		}

		static void n_ShowWithImmersiveCheck_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.ShowWithImmersiveCheck (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialog']/method[@name='showWithImmersiveCheck' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("showWithImmersiveCheck", "(Landroid/app/Activity;)V", "GetShowWithImmersiveCheck_Landroid_app_Activity_Handler")]
		public virtual unsafe void ShowWithImmersiveCheck (global::Android.App.Activity activity)
		{
			const string __id = "showWithImmersiveCheck.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

	}
}
