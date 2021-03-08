using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.PullRefreshLayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUICenterGravityRefreshOffsetCalculator']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUICenterGravityRefreshOffsetCalculator", DoNotGenerateAcw=true)]
	public partial class QMUICenterGravityRefreshOffsetCalculator : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshOffsetCalculator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUICenterGravityRefreshOffsetCalculator", typeof (QMUICenterGravityRefreshOffsetCalculator));
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

		protected QMUICenterGravityRefreshOffsetCalculator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUICenterGravityRefreshOffsetCalculator']/constructor[@name='QMUICenterGravityRefreshOffsetCalculator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUICenterGravityRefreshOffsetCalculator ()
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

		static Delegate cb_calculateRefreshOffset_IIIIII;
#pragma warning disable 0169
		static Delegate GetCalculateRefreshOffset_IIIIIIHandler ()
		{
			if (cb_calculateRefreshOffset_IIIIII == null)
				cb_calculateRefreshOffset_IIIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIIII_I) n_CalculateRefreshOffset_IIIIII);
			return cb_calculateRefreshOffset_IIIIII;
		}

		static int n_CalculateRefreshOffset_IIIIII (IntPtr jnienv, IntPtr native__this, int refreshInitOffset, int refreshEndOffset, int refreshViewHeight, int targetCurrentOffset, int targetInitOffset, int targetRefreshOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUICenterGravityRefreshOffsetCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateRefreshOffset (refreshInitOffset, refreshEndOffset, refreshViewHeight, targetCurrentOffset, targetInitOffset, targetRefreshOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUICenterGravityRefreshOffsetCalculator']/method[@name='calculateRefreshOffset' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("calculateRefreshOffset", "(IIIIII)I", "GetCalculateRefreshOffset_IIIIIIHandler")]
		public virtual unsafe int CalculateRefreshOffset (int refreshInitOffset, int refreshEndOffset, int refreshViewHeight, int targetCurrentOffset, int targetInitOffset, int targetRefreshOffset)
		{
			const string __id = "calculateRefreshOffset.(IIIIII)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (refreshInitOffset);
				__args [1] = new JniArgumentValue (refreshEndOffset);
				__args [2] = new JniArgumentValue (refreshViewHeight);
				__args [3] = new JniArgumentValue (targetCurrentOffset);
				__args [4] = new JniArgumentValue (targetInitOffset);
				__args [5] = new JniArgumentValue (targetRefreshOffset);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
