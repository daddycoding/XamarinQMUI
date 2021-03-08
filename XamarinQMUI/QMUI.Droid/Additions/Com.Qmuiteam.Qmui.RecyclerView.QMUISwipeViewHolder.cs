using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.RecyclerView {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeViewHolder']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUISwipeViewHolder", DoNotGenerateAcw=true)]
	public partial class QMUISwipeViewHolder : global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUISwipeViewHolder", typeof (QMUISwipeViewHolder));
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

		protected QMUISwipeViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeViewHolder']/constructor[@name='QMUISwipeViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe QMUISwipeViewHolder (global::Android.Views.View itemView)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((itemView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemView).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (itemView);
			}
		}

		static Delegate cb_hasAction;
#pragma warning disable 0169
		static Delegate GetHasActionHandler ()
		{
			if (cb_hasAction == null)
				cb_hasAction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasAction);
			return cb_hasAction;
		}

		static bool n_HasAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAction;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeViewHolder']/method[@name='hasAction' and count(parameter)=0]"
			[Register ("hasAction", "()Z", "GetHasActionHandler")]
			get {
				const string __id = "hasAction.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_;
#pragma warning disable 0169
		static Delegate GetAddSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_Handler ()
		{
			if (cb_addSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_ == null)
				cb_addSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_);
			return cb_addSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_;
		}

		static void n_AddSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (native_action, JniHandleOwnership.DoNotTransfer);
			__this.AddSwipeAction (action);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeViewHolder']/method[@name='addSwipeAction' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.recyclerView.QMUISwipeAction']]"
		[Register ("addSwipeAction", "(Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction;)V", "GetAddSwipeAction_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_Handler")]
		public virtual unsafe void AddSwipeAction (global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction action)
		{
			const string __id = "addSwipeAction.(Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (action);
			}
		}

		static Delegate cb_clearActions;
#pragma warning disable 0169
		static Delegate GetClearActionsHandler ()
		{
			if (cb_clearActions == null)
				cb_clearActions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearActions);
			return cb_clearActions;
		}

		static void n_ClearActions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearActions ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeViewHolder']/method[@name='clearActions' and count(parameter)=0]"
		[Register ("clearActions", "()V", "GetClearActionsHandler")]
		public virtual unsafe void ClearActions ()
		{
			const string __id = "clearActions.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearTouchInfo;
#pragma warning disable 0169
		static Delegate GetClearTouchInfoHandler ()
		{
			if (cb_clearTouchInfo == null)
				cb_clearTouchInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearTouchInfo);
			return cb_clearTouchInfo;
		}

		static void n_ClearTouchInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearTouchInfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeViewHolder']/method[@name='clearTouchInfo' and count(parameter)=0]"
		[Register ("clearTouchInfo", "()V", "GetClearTouchInfoHandler")]
		public virtual unsafe void ClearTouchInfo ()
		{
			const string __id = "clearTouchInfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
