using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabAdapter", DoNotGenerateAcw=true)]
	public partial class QMUITabAdapter : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView.ICallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabAdapter", typeof (QMUITabAdapter));
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

		protected QMUITabAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/constructor[@name='QMUITabAdapter' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment;Landroid/view/ViewGroup;)V", "")]
		public unsafe QMUITabAdapter (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment tabSegment, global::Android.Views.ViewGroup parentView)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment;Landroid/view/ViewGroup;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tabSegment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tabSegment).Handle);
				__args [1] = new JniArgumentValue ((parentView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentView).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tabSegment);
				global::System.GC.KeepAlive (parentView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/method[@name='bind' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITab'] and parameter[2][@type='com.qmuiteam.qmui.widget.tab.QMUITabView'] and parameter[3][@type='int']]"
		[Register ("bind", "(Lcom/qmuiteam/qmui/widget/tab/QMUITab;Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)V", "")]
		protected unsafe void Bind (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab item, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view, int position)
		{
			const string __id = "bind.(Lcom/qmuiteam/qmui/widget/tab/QMUITab;Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [2] = new JniArgumentValue (position);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (item);
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_createView_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetCreateView_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_createView_Landroid_view_ViewGroup_ == null)
				cb_createView_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateView_Landroid_view_ViewGroup_);
			return cb_createView_Landroid_view_ViewGroup_;
		}

		static IntPtr n_CreateView_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parentView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parentView = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parentView, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateView (parentView));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/method[@name='createView' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("createView", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/tab/QMUITabView;", "GetCreateView_Landroid_view_ViewGroup_Handler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView CreateView (global::Android.Views.ViewGroup parentView)
		{
			const string __id = "createView.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/tab/QMUITabView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parentView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentView).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parentView);
			}
		}

		static Delegate cb_onBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I;
#pragma warning disable 0169
		static Delegate GetOnBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_IHandler ()
		{
			if (cb_onBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I == null)
				cb_onBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_OnBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I);
			return cb_onBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I;
		}

		static void n_OnBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_item, IntPtr native_view, int position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var item = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (native_item, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnBindTab (item, view, position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/method[@name='onBindTab' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITab'] and parameter[2][@type='com.qmuiteam.qmui.widget.tab.QMUITabView'] and parameter[3][@type='int']]"
		[Register ("onBindTab", "(Lcom/qmuiteam/qmui/widget/tab/QMUITab;Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)V", "GetOnBindTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_IHandler")]
		protected virtual unsafe void OnBindTab (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab item, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view, int position)
		{
			const string __id = "onBindTab.(Lcom/qmuiteam/qmui/widget/tab/QMUITab;Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [2] = new JniArgumentValue (position);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (item);
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
#pragma warning disable 0169
		static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler ()
		{
			if (cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == null)
				cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_);
			return cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
		}

		static void n_OnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView']]"
		[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V", "GetOnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler")]
		public virtual unsafe void OnClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view)
		{
			const string __id = "onClick.(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
#pragma warning disable 0169
		static Delegate GetOnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler ()
		{
			if (cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == null)
				cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_);
			return cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
		}

		static void n_OnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnDoubleClick (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/method[@name='onDoubleClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView']]"
		[Register ("onDoubleClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V", "GetOnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler")]
		public virtual unsafe void OnDoubleClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view)
		{
			const string __id = "onDoubleClick.(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
#pragma warning disable 0169
		static Delegate GetOnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler ()
		{
			if (cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == null)
				cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_);
			return cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
		}

		static void n_OnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnLongClick (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/method[@name='onLongClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView']]"
		[Register ("onLongClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V", "GetOnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler")]
		public virtual unsafe void OnLongClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view)
		{
			const string __id = "onLongClick.(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
#pragma warning disable 0169
		static Delegate GetOnViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler ()
		{
			if (cb_onViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == null)
				cb_onViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_);
			return cb_onViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
		}

		static void n_OnViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_qmuiTabView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var qmuiTabView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_qmuiTabView, JniHandleOwnership.DoNotTransfer);
			__this.OnViewRecycled (qmuiTabView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabAdapter']/method[@name='onViewRecycled' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView']]"
		[Register ("onViewRecycled", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V", "GetOnViewRecycled_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler")]
		protected virtual unsafe void OnViewRecycled (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView qmuiTabView)
		{
			const string __id = "onViewRecycled.(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((qmuiTabView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) qmuiTabView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (qmuiTabView);
			}
		}

	}
}
