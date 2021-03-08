using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.PullLayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLoadMoreView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLoadMoreView", DoNotGenerateAcw=true)]
	public partial class QMUIPullLoadMoreView : global::AndroidX.ConstraintLayout.Widget.ConstraintLayout, global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionPullWatcherView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLoadMoreView", typeof (QMUIPullLoadMoreView));
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

		protected QMUIPullLoadMoreView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLoadMoreView']/constructor[@name='QMUIPullLoadMoreView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIPullLoadMoreView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLoadMoreView']/constructor[@name='QMUIPullLoadMoreView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIPullLoadMoreView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLoadMoreView']/constructor[@name='QMUIPullLoadMoreView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIPullLoadMoreView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_onActionFinished;
#pragma warning disable 0169
		static Delegate GetOnActionFinishedHandler ()
		{
			if (cb_onActionFinished == null)
				cb_onActionFinished = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnActionFinished);
			return cb_onActionFinished;
		}

		static void n_OnActionFinished (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLoadMoreView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionFinished ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLoadMoreView']/method[@name='onActionFinished' and count(parameter)=0]"
		[Register ("onActionFinished", "()V", "GetOnActionFinishedHandler")]
		public virtual unsafe void OnActionFinished ()
		{
			const string __id = "onActionFinished.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onActionTriggered;
#pragma warning disable 0169
		static Delegate GetOnActionTriggeredHandler ()
		{
			if (cb_onActionTriggered == null)
				cb_onActionTriggered = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnActionTriggered);
			return cb_onActionTriggered;
		}

		static void n_OnActionTriggered (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLoadMoreView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionTriggered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLoadMoreView']/method[@name='onActionTriggered' and count(parameter)=0]"
		[Register ("onActionTriggered", "()V", "GetOnActionTriggeredHandler")]
		public virtual unsafe void OnActionTriggered ()
		{
			const string __id = "onActionTriggered.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
#pragma warning disable 0169
		static Delegate GetOnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler ()
		{
			if (cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I == null)
				cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I);
			return cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
		}

		static void n_OnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I (IntPtr jnienv, IntPtr native__this, IntPtr native_pullAction, int currentTargetOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLoadMoreView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
			__this.OnPull (pullAction, currentTargetOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLoadMoreView']/method[@name='onPull' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction'] and parameter[2][@type='int']]"
		[Register ("onPull", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)V", "GetOnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler")]
		public virtual unsafe void OnPull (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, int currentTargetOffset)
		{
			const string __id = "onPull.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				__args [1] = new JniArgumentValue (currentTargetOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pullAction);
			}
		}

	}
}
