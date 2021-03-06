using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.PullLayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUICenterOffsetCalculator']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUICenterOffsetCalculator", DoNotGenerateAcw=true)]
	public partial class QMUICenterOffsetCalculator : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionViewOffsetCalculator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUICenterOffsetCalculator", typeof (QMUICenterOffsetCalculator));
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

		protected QMUICenterOffsetCalculator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUICenterOffsetCalculator']/constructor[@name='QMUICenterOffsetCalculator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUICenterOffsetCalculator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
#pragma warning disable 0169
		static Delegate GetCalculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler ()
		{
			if (cb_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I == null)
				cb_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_CalculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I);
			return cb_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
		}

		static int n_CalculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I (IntPtr jnienv, IntPtr native__this, IntPtr native_pullAction, int targetOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUICenterOffsetCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CalculateOffset (pullAction, targetOffset);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUICenterOffsetCalculator']/method[@name='calculateOffset' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction'] and parameter[2][@type='int']]"
		[Register ("calculateOffset", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)I", "GetCalculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler")]
		public virtual unsafe int CalculateOffset (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, int targetOffset)
		{
			const string __id = "calculateOffset.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				__args [1] = new JniArgumentValue (targetOffset);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (pullAction);
			}
		}

	}
}
