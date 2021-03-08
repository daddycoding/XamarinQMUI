using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Grouplist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUIGroupListView", DoNotGenerateAcw=true)]
	public partial class QMUIGroupListView : global::Android.Widget.LinearLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section", DoNotGenerateAcw=true)]
		public partial class Section : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section", typeof (Section));
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

			protected Section (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/constructor[@name='QMUIGroupListView.Section' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Section (global::Android.Content.Context context)
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

			static Delegate cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetAddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Handler ()
			{
				if (cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_ == null)
					cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_);
				return cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_;
			}

			static IntPtr n_AddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_itemView, IntPtr native_onClickListener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var itemView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (native_itemView, JniHandleOwnership.DoNotTransfer);
				var onClickListener = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItemView (itemView, onClickListener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='addItemView' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView'] and parameter[2][@type='android.view.View.OnClickListener']]"
			[Register ("addItemView", "(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;Landroid/view/View$OnClickListener;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetAddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section AddItemView (global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView itemView, global::Android.Views.View.IOnClickListener onClickListener)
			{
				const string __id = "addItemView.(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;Landroid/view/View$OnClickListener;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((itemView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemView).Handle);
					__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (itemView);
					global::System.GC.KeepAlive (onClickListener);
				}
			}

			static Delegate cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_;
#pragma warning disable 0169
			static Delegate GetAddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_Handler ()
			{
				if (cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_ == null)
					cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_AddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_);
				return cb_addItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_;
			}

			static IntPtr n_AddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_itemView, IntPtr native_onClickListener, IntPtr native_onLongClickListener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var itemView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (native_itemView, JniHandleOwnership.DoNotTransfer);
				var onClickListener = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
				var onLongClickListener = (global::Android.Views.View.IOnLongClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnLongClickListener> (native_onLongClickListener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItemView (itemView, onClickListener, onLongClickListener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='addItemView' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView'] and parameter[2][@type='android.view.View.OnClickListener'] and parameter[3][@type='android.view.View.OnLongClickListener']]"
			[Register ("addItemView", "(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;Landroid/view/View$OnClickListener;Landroid/view/View$OnLongClickListener;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetAddItemView_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_Landroid_view_View_OnClickListener_Landroid_view_View_OnLongClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section AddItemView (global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView itemView, global::Android.Views.View.IOnClickListener onClickListener, global::Android.Views.View.IOnLongClickListener onLongClickListener)
			{
				const string __id = "addItemView.(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;Landroid/view/View$OnClickListener;Landroid/view/View$OnLongClickListener;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((itemView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemView).Handle);
					__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
					__args [2] = new JniArgumentValue ((onLongClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onLongClickListener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (itemView);
					global::System.GC.KeepAlive (onClickListener);
					global::System.GC.KeepAlive (onLongClickListener);
				}
			}

			static Delegate cb_addTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_;
#pragma warning disable 0169
			static Delegate GetAddTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_Handler ()
			{
				if (cb_addTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_ == null)
					cb_addTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_);
				return cb_addTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_;
			}

			static void n_AddTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groupListView)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var groupListView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (native_groupListView, JniHandleOwnership.DoNotTransfer);
				__this.AddTo (groupListView);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='addTo' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.grouplist.QMUIGroupListView']]"
			[Register ("addTo", "(Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView;)V", "GetAddTo_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_Handler")]
			public virtual unsafe void AddTo (global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView groupListView)
			{
				const string __id = "addTo.(Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((groupListView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groupListView).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (groupListView);
				}
			}

			static Delegate cb_createSectionFooter_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetCreateSectionFooter_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_createSectionFooter_Ljava_lang_CharSequence_ == null)
					cb_createSectionFooter_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateSectionFooter_Ljava_lang_CharSequence_);
				return cb_createSectionFooter_Ljava_lang_CharSequence_;
			}

			static IntPtr n_CreateSectionFooter_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSectionFooter (text));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='createSectionFooter' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("createSectionFooter", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListSectionHeaderFooterView;", "GetCreateSectionFooter_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView CreateSectionFooter (global::Java.Lang.ICharSequence text)
			{
				const string __id = "createSectionFooter.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListSectionHeaderFooterView;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView CreateSectionFooter (string text)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView __result = CreateSectionFooter (jls_text);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

			static Delegate cb_createSectionHeader_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetCreateSectionHeader_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_createSectionHeader_Ljava_lang_CharSequence_ == null)
					cb_createSectionHeader_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateSectionHeader_Ljava_lang_CharSequence_);
				return cb_createSectionHeader_Ljava_lang_CharSequence_;
			}

			static IntPtr n_CreateSectionHeader_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_titleText)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var titleText = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_titleText, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSectionHeader (titleText));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='createSectionHeader' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("createSectionHeader", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListSectionHeaderFooterView;", "GetCreateSectionHeader_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView CreateSectionHeader (global::Java.Lang.ICharSequence titleText)
			{
				const string __id = "createSectionHeader.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListSectionHeaderFooterView;";
				IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_titleText);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_titleText);
					global::System.GC.KeepAlive (titleText);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView CreateSectionHeader (string titleText)
			{
				var jls_titleText = titleText == null ? null : new global::Java.Lang.String (titleText);
				global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView __result = CreateSectionHeader (jls_titleText);
				var __rsval = __result;
				jls_titleText?.Dispose ();
				return __rsval;
			}

			static Delegate cb_removeFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_;
#pragma warning disable 0169
			static Delegate GetRemoveFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_Handler ()
			{
				if (cb_removeFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_ == null)
					cb_removeFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_);
				return cb_removeFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_;
			}

			static void n_RemoveFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (native_parent, JniHandleOwnership.DoNotTransfer);
				__this.RemoveFrom (parent);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='removeFrom' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.grouplist.QMUIGroupListView']]"
			[Register ("removeFrom", "(Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView;)V", "GetRemoveFrom_Lcom_qmuiteam_qmui_widget_grouplist_QMUIGroupListView_Handler")]
			public virtual unsafe void RemoveFrom (global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView parent)
			{
				const string __id = "removeFrom.(Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (parent);
				}
			}

			static Delegate cb_setBgAttr_I;
#pragma warning disable 0169
			static Delegate GetSetBgAttr_IHandler ()
			{
				if (cb_setBgAttr_I == null)
					cb_setBgAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetBgAttr_I);
				return cb_setBgAttr_I;
			}

			static IntPtr n_SetBgAttr_I (IntPtr jnienv, IntPtr native__this, int bgAttr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetBgAttr (bgAttr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setBgAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBgAttr", "(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetBgAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetBgAttr (int bgAttr)
			{
				const string __id = "setBgAttr.(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bgAttr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDescription_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetDescription_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setDescription_Ljava_lang_CharSequence_ == null)
					cb_setDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDescription_Ljava_lang_CharSequence_);
				return cb_setDescription_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetDescription_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var description = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_description, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDescription (description));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setDescription", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetDescription_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetDescription (global::Java.Lang.ICharSequence description)
			{
				const string __id = "setDescription.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				IntPtr native_description = CharSequence.ToLocalJniHandle (description);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_description);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_description);
					global::System.GC.KeepAlive (description);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetDescription (string description)
			{
				var jls_description = description == null ? null : new global::Java.Lang.String (description);
				global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section __result = SetDescription (jls_description);
				var __rsval = __result;
				jls_description?.Dispose ();
				return __rsval;
			}

			static Delegate cb_setHandleSeparatorCustom_Z;
#pragma warning disable 0169
			static Delegate GetSetHandleSeparatorCustom_ZHandler ()
			{
				if (cb_setHandleSeparatorCustom_Z == null)
					cb_setHandleSeparatorCustom_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetHandleSeparatorCustom_Z);
				return cb_setHandleSeparatorCustom_Z;
			}

			static IntPtr n_SetHandleSeparatorCustom_Z (IntPtr jnienv, IntPtr native__this, bool handleSeparatorCustom)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetHandleSeparatorCustom (handleSeparatorCustom));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setHandleSeparatorCustom' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHandleSeparatorCustom", "(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetHandleSeparatorCustom_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetHandleSeparatorCustom (bool handleSeparatorCustom)
			{
				const string __id = "setHandleSeparatorCustom.(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (handleSeparatorCustom);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setLeftIconSize_II;
#pragma warning disable 0169
			static Delegate GetSetLeftIconSize_IIHandler ()
			{
				if (cb_setLeftIconSize_II == null)
					cb_setLeftIconSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SetLeftIconSize_II);
				return cb_setLeftIconSize_II;
			}

			static IntPtr n_SetLeftIconSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetLeftIconSize (width, height));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setLeftIconSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setLeftIconSize", "(II)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetLeftIconSize_IIHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetLeftIconSize (int width, int height)
			{
				const string __id = "setLeftIconSize.(II)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMiddleSeparatorInset_II;
#pragma warning disable 0169
			static Delegate GetSetMiddleSeparatorInset_IIHandler ()
			{
				if (cb_setMiddleSeparatorInset_II == null)
					cb_setMiddleSeparatorInset_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SetMiddleSeparatorInset_II);
				return cb_setMiddleSeparatorInset_II;
			}

			static IntPtr n_SetMiddleSeparatorInset_II (IntPtr jnienv, IntPtr native__this, int insetLeft, int insetRight)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMiddleSeparatorInset (insetLeft, insetRight));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setMiddleSeparatorInset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setMiddleSeparatorInset", "(II)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetMiddleSeparatorInset_IIHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetMiddleSeparatorInset (int insetLeft, int insetRight)
			{
				const string __id = "setMiddleSeparatorInset.(II)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (insetLeft);
					__args [1] = new JniArgumentValue (insetRight);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setOnlyShowMiddleSeparator_Z;
#pragma warning disable 0169
			static Delegate GetSetOnlyShowMiddleSeparator_ZHandler ()
			{
				if (cb_setOnlyShowMiddleSeparator_Z == null)
					cb_setOnlyShowMiddleSeparator_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetOnlyShowMiddleSeparator_Z);
				return cb_setOnlyShowMiddleSeparator_Z;
			}

			static IntPtr n_SetOnlyShowMiddleSeparator_Z (IntPtr jnienv, IntPtr native__this, bool onlyShowMiddleSeparator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetOnlyShowMiddleSeparator (onlyShowMiddleSeparator));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setOnlyShowMiddleSeparator' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOnlyShowMiddleSeparator", "(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetOnlyShowMiddleSeparator_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetOnlyShowMiddleSeparator (bool onlyShowMiddleSeparator)
			{
				const string __id = "setOnlyShowMiddleSeparator.(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (onlyShowMiddleSeparator);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setOnlyShowStartEndSeparator_Z;
#pragma warning disable 0169
			static Delegate GetSetOnlyShowStartEndSeparator_ZHandler ()
			{
				if (cb_setOnlyShowStartEndSeparator_Z == null)
					cb_setOnlyShowStartEndSeparator_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetOnlyShowStartEndSeparator_Z);
				return cb_setOnlyShowStartEndSeparator_Z;
			}

			static IntPtr n_SetOnlyShowStartEndSeparator_Z (IntPtr jnienv, IntPtr native__this, bool onlyShowStartEndSeparator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetOnlyShowStartEndSeparator (onlyShowStartEndSeparator));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setOnlyShowStartEndSeparator' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOnlyShowStartEndSeparator", "(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetOnlyShowStartEndSeparator_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetOnlyShowStartEndSeparator (bool onlyShowStartEndSeparator)
			{
				const string __id = "setOnlyShowStartEndSeparator.(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (onlyShowStartEndSeparator);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSeparatorColorAttr_I;
#pragma warning disable 0169
			static Delegate GetSetSeparatorColorAttr_IHandler ()
			{
				if (cb_setSeparatorColorAttr_I == null)
					cb_setSeparatorColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSeparatorColorAttr_I);
				return cb_setSeparatorColorAttr_I;
			}

			static IntPtr n_SetSeparatorColorAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetSeparatorColorAttr (attr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setSeparatorColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSeparatorColorAttr", "(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetSeparatorColorAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetSeparatorColorAttr (int attr)
			{
				const string __id = "setSeparatorColorAttr.(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (attr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setShowSeparator_Z;
#pragma warning disable 0169
			static Delegate GetSetShowSeparator_ZHandler ()
			{
				if (cb_setShowSeparator_Z == null)
					cb_setShowSeparator_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetShowSeparator_Z);
				return cb_setShowSeparator_Z;
			}

			static IntPtr n_SetShowSeparator_Z (IntPtr jnienv, IntPtr native__this, bool showSeparator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetShowSeparator (showSeparator));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setShowSeparator' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowSeparator", "(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetShowSeparator_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetShowSeparator (bool showSeparator)
			{
				const string __id = "setShowSeparator.(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (showSeparator);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var title = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_title, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (title));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTitle", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetTitle (global::Java.Lang.ICharSequence title)
			{
				const string __id = "setTitle.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				IntPtr native_title = CharSequence.ToLocalJniHandle (title);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_title);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_title);
					global::System.GC.KeepAlive (title);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetTitle (string title)
			{
				var jls_title = title == null ? null : new global::Java.Lang.String (title);
				global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section __result = SetTitle (jls_title);
				var __rsval = __result;
				jls_title?.Dispose ();
				return __rsval;
			}

			static Delegate cb_setUseDefaultTitleIfNone_Z;
#pragma warning disable 0169
			static Delegate GetSetUseDefaultTitleIfNone_ZHandler ()
			{
				if (cb_setUseDefaultTitleIfNone_Z == null)
					cb_setUseDefaultTitleIfNone_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetUseDefaultTitleIfNone_Z);
				return cb_setUseDefaultTitleIfNone_Z;
			}

			static IntPtr n_SetUseDefaultTitleIfNone_Z (IntPtr jnienv, IntPtr native__this, bool useDefaultTitleIfNone)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetUseDefaultTitleIfNone (useDefaultTitleIfNone));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setUseDefaultTitleIfNone' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseDefaultTitleIfNone", "(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetUseDefaultTitleIfNone_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetUseDefaultTitleIfNone (bool useDefaultTitleIfNone)
			{
				const string __id = "setUseDefaultTitleIfNone.(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useDefaultTitleIfNone);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setUseTitleViewForSectionSpace_Z;
#pragma warning disable 0169
			static Delegate GetSetUseTitleViewForSectionSpace_ZHandler ()
			{
				if (cb_setUseTitleViewForSectionSpace_Z == null)
					cb_setUseTitleViewForSectionSpace_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetUseTitleViewForSectionSpace_Z);
				return cb_setUseTitleViewForSectionSpace_Z;
			}

			static IntPtr n_SetUseTitleViewForSectionSpace_Z (IntPtr jnienv, IntPtr native__this, bool useTitleViewForSectionSpace)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetUseTitleViewForSectionSpace (useTitleViewForSectionSpace));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView.Section']/method[@name='setUseTitleViewForSectionSpace' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseTitleViewForSectionSpace", "(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetSetUseTitleViewForSectionSpace_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section SetUseTitleViewForSectionSpace (bool useTitleViewForSectionSpace)
			{
				const string __id = "setUseTitleViewForSectionSpace.(Z)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useTitleViewForSectionSpace);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUIGroupListView", typeof (QMUIGroupListView));
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

		protected QMUIGroupListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/constructor[@name='QMUIGroupListView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIGroupListView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/constructor[@name='QMUIGroupListView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIGroupListView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/constructor[@name='QMUIGroupListView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIGroupListView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getSectionCount;
#pragma warning disable 0169
		static Delegate GetGetSectionCountHandler ()
		{
			if (cb_getSectionCount == null)
				cb_getSectionCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSectionCount);
			return cb_getSectionCount;
		}

		static int n_GetSectionCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SectionCount;
		}
#pragma warning restore 0169

		public virtual unsafe int SectionCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/method[@name='getSectionCount' and count(parameter)=0]"
			[Register ("getSectionCount", "()I", "GetGetSectionCountHandler")]
			get {
				const string __id = "getSectionCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetCreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_IIHandler ()
		{
			if (cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_II == null)
				cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLII_L) n_CreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_II);
			return cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_II;
		}

		static IntPtr n_CreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_imageDrawable, IntPtr native_titleText, IntPtr native_detailText, int orientation, int accessoryType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_imageDrawable, JniHandleOwnership.DoNotTransfer);
			var titleText = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_titleText, JniHandleOwnership.DoNotTransfer);
			var detailText = JNIEnv.GetString (native_detailText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateItemView (imageDrawable, titleText, detailText, orientation, accessoryType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/method[@name='createItemView' and count(parameter)=5 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("createItemView", "(Landroid/graphics/drawable/Drawable;Ljava/lang/CharSequence;Ljava/lang/String;II)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;", "GetCreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView CreateItemView (global::Android.Graphics.Drawables.Drawable imageDrawable, global::Java.Lang.ICharSequence titleText, string detailText, int orientation, int accessoryType)
		{
			const string __id = "createItemView.(Landroid/graphics/drawable/Drawable;Ljava/lang/CharSequence;Ljava/lang/String;II)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;";
			IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
			IntPtr native_detailText = JNIEnv.NewString (detailText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((imageDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageDrawable).Handle);
				__args [1] = new JniArgumentValue (native_titleText);
				__args [2] = new JniArgumentValue (native_detailText);
				__args [3] = new JniArgumentValue (orientation);
				__args [4] = new JniArgumentValue (accessoryType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				JNIEnv.DeleteLocalRef (native_detailText);
				global::System.GC.KeepAlive (imageDrawable);
				global::System.GC.KeepAlive (titleText);
			}
		}

		public global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView CreateItemView (global::Android.Graphics.Drawables.Drawable imageDrawable, string titleText, string detailText, int orientation, int accessoryType)
		{
			var jls_titleText = titleText == null ? null : new global::Java.Lang.String (titleText);
			global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView __result = CreateItemView (imageDrawable, jls_titleText, detailText, orientation, accessoryType);
			var __rsval = __result;
			jls_titleText?.Dispose ();
			return __rsval;
		}

		static Delegate cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetCreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_IIIHandler ()
		{
			if (cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_III == null)
				cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLIII_L) n_CreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_III);
			return cb_createItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_III;
		}

		static IntPtr n_CreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_imageDrawable, IntPtr native_titleText, IntPtr native_detailText, int orientation, int accessoryType, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_imageDrawable, JniHandleOwnership.DoNotTransfer);
			var titleText = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_titleText, JniHandleOwnership.DoNotTransfer);
			var detailText = JNIEnv.GetString (native_detailText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateItemView (imageDrawable, titleText, detailText, orientation, accessoryType, height));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/method[@name='createItemView' and count(parameter)=6 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("createItemView", "(Landroid/graphics/drawable/Drawable;Ljava/lang/CharSequence;Ljava/lang/String;III)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;", "GetCreateItemView_Landroid_graphics_drawable_Drawable_Ljava_lang_CharSequence_Ljava_lang_String_IIIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView CreateItemView (global::Android.Graphics.Drawables.Drawable imageDrawable, global::Java.Lang.ICharSequence titleText, string detailText, int orientation, int accessoryType, int height)
		{
			const string __id = "createItemView.(Landroid/graphics/drawable/Drawable;Ljava/lang/CharSequence;Ljava/lang/String;III)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;";
			IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
			IntPtr native_detailText = JNIEnv.NewString (detailText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((imageDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageDrawable).Handle);
				__args [1] = new JniArgumentValue (native_titleText);
				__args [2] = new JniArgumentValue (native_detailText);
				__args [3] = new JniArgumentValue (orientation);
				__args [4] = new JniArgumentValue (accessoryType);
				__args [5] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				JNIEnv.DeleteLocalRef (native_detailText);
				global::System.GC.KeepAlive (imageDrawable);
				global::System.GC.KeepAlive (titleText);
			}
		}

		public global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView CreateItemView (global::Android.Graphics.Drawables.Drawable imageDrawable, string titleText, string detailText, int orientation, int accessoryType, int height)
		{
			var jls_titleText = titleText == null ? null : new global::Java.Lang.String (titleText);
			global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView __result = CreateItemView (imageDrawable, jls_titleText, detailText, orientation, accessoryType, height);
			var __rsval = __result;
			jls_titleText?.Dispose ();
			return __rsval;
		}

		static Delegate cb_createItemView_I;
#pragma warning disable 0169
		static Delegate GetCreateItemView_IHandler ()
		{
			if (cb_createItemView_I == null)
				cb_createItemView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_CreateItemView_I);
			return cb_createItemView_I;
		}

		static IntPtr n_CreateItemView_I (IntPtr jnienv, IntPtr native__this, int orientation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateItemView (orientation));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/method[@name='createItemView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItemView", "(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;", "GetCreateItemView_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView CreateItemView (int orientation)
		{
			const string __id = "createItemView.(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (orientation);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createItemView_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetCreateItemView_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_createItemView_Ljava_lang_CharSequence_ == null)
				cb_createItemView_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateItemView_Ljava_lang_CharSequence_);
			return cb_createItemView_Ljava_lang_CharSequence_;
		}

		static IntPtr n_CreateItemView_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_titleText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var titleText = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_titleText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateItemView (titleText));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/method[@name='createItemView' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("createItemView", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;", "GetCreateItemView_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView CreateItemView (global::Java.Lang.ICharSequence titleText)
		{
			const string __id = "createItemView.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView;";
			IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_titleText);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				global::System.GC.KeepAlive (titleText);
			}
		}

		public global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView CreateItemView (string titleText)
		{
			var jls_titleText = titleText == null ? null : new global::Java.Lang.String (titleText);
			global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView __result = CreateItemView (jls_titleText);
			var __rsval = __result;
			jls_titleText?.Dispose ();
			return __rsval;
		}

		static Delegate cb_getSection_I;
#pragma warning disable 0169
		static Delegate GetGetSection_IHandler ()
		{
			if (cb_getSection_I == null)
				cb_getSection_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetSection_I);
			return cb_getSection_I;
		}

		static IntPtr n_GetSection_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSection (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/method[@name='getSection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSection", "(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "GetGetSection_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section GetSection (int index)
		{
			const string __id = "getSection.(I)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListView']/method[@name='newSection' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newSection", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section NewSection (global::Android.Content.Context context)
		{
			const string __id = "newSection.(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/grouplist/QMUIGroupListView$Section;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListView.Section> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
