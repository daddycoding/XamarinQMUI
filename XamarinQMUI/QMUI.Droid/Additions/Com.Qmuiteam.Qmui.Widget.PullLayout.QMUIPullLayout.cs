using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.PullLayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout", DoNotGenerateAcw=true)]
	public partial class QMUIPullLayout : global::Android.Widget.FrameLayout, global::AndroidX.Core.View.INestedScrollingParent3 {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='DEFAULT_FLING_FRACTION']"
		[Register ("DEFAULT_FLING_FRACTION")]
		public const float DefaultFlingFraction = (float) 0.002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='DEFAULT_MIN_SCROLL_DURATION']"
		[Register ("DEFAULT_MIN_SCROLL_DURATION")]
		public const int DefaultMinScrollDuration = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='DEFAULT_PULL_RATE']"
		[Register ("DEFAULT_PULL_RATE")]
		public const float DefaultPullRate = (float) 0.45;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='DEFAULT_SCROLL_SPEED_PER_PIXEL']"
		[Register ("DEFAULT_SCROLL_SPEED_PER_PIXEL")]
		public const float DefaultScrollSpeedPerPixel = (float) 1.5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='PULL_EDGE_BOTTOM']"
		[Register ("PULL_EDGE_BOTTOM")]
		public const int PullEdgeBottom = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='PULL_EDGE_LEFT']"
		[Register ("PULL_EDGE_LEFT")]
		public const int PullEdgeLeft = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='PULL_EDGE_RIGHT']"
		[Register ("PULL_EDGE_RIGHT")]
		public const int PullEdgeRight = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='PULL_EDGE_TOP']"
		[Register ("PULL_EDGE_TOP")]
		public const int PullEdgeTop = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/field[@name='PUL_EDGE_ALL']"
		[Register ("PUL_EDGE_ALL")]
		public const int PulEdgeAll = (int) 15;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionListener']"
		[Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionListener", "", "Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionListenerInvoker")]
		public partial interface IActionListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionListener']/method[@name='onActionTriggered' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction']]"
			[Register ("onActionTriggered", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;)V", "GetOnActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Handler:Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionListenerInvoker, QMUI.Droid")]
			void OnActionTriggered (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionListener", DoNotGenerateAcw=true)]
		internal partial class IActionListenerInvoker : global::Java.Lang.Object, IActionListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionListener", typeof (IActionListenerInvoker));

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

			public static IActionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IActionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.ActionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_;
#pragma warning disable 0169
			static Delegate GetOnActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Handler ()
			{
				if (cb_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ == null)
					cb_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_);
				return cb_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_;
			}

			static void n_OnActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pullAction)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
				__this.OnActionTriggered (pullAction);
			}
#pragma warning restore 0169

			IntPtr id_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_;
			public unsafe void OnActionTriggered (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction)
			{
				if (id_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ == IntPtr.Zero)
					id_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ = JNIEnv.GetMethodID (class_ref, "onActionTriggered", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActionTriggered_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.ActionListener.onActionTriggered
		public partial class ActionEventArgs : global::System.EventArgs {

			public ActionEventArgs (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction)
			{
				this.pullAction = pullAction;
			}

			global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction;
			public global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction PullAction {
				get { return pullAction; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout_ActionListenerImplementor")]
		internal sealed partial class IActionListenerImplementor : global::Java.Lang.Object, IActionListener {

			object sender;

			public IActionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout_ActionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActionEventArgs> Handler;
#pragma warning restore 0649

			public void OnActionTriggered (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ActionEventArgs (pullAction));
			}

			internal static bool __IsEmpty (IActionListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionPullWatcherView']"
		[Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionPullWatcherView", "", "Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionPullWatcherViewInvoker")]
		public partial interface IActionPullWatcherView : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionPullWatcherView']/method[@name='onActionFinished' and count(parameter)=0]"
			[Register ("onActionFinished", "()V", "GetOnActionFinishedHandler:Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionPullWatcherViewInvoker, QMUI.Droid")]
			void OnActionFinished ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionPullWatcherView']/method[@name='onActionTriggered' and count(parameter)=0]"
			[Register ("onActionTriggered", "()V", "GetOnActionTriggeredHandler:Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionPullWatcherViewInvoker, QMUI.Droid")]
			void OnActionTriggered ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionPullWatcherView']/method[@name='onPull' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction'] and parameter[2][@type='int']]"
			[Register ("onPull", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)V", "GetOnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler:Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionPullWatcherViewInvoker, QMUI.Droid")]
			void OnPull (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, int currentTargetOffset);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionPullWatcherView", DoNotGenerateAcw=true)]
		internal partial class IActionPullWatcherViewInvoker : global::Java.Lang.Object, IActionPullWatcherView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionPullWatcherView", typeof (IActionPullWatcherViewInvoker));

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

			public static IActionPullWatcherView GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IActionPullWatcherView> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.ActionPullWatcherView"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActionPullWatcherViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionPullWatcherView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnActionFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onActionFinished;
			public unsafe void OnActionFinished ()
			{
				if (id_onActionFinished == IntPtr.Zero)
					id_onActionFinished = JNIEnv.GetMethodID (class_ref, "onActionFinished", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActionFinished);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionPullWatcherView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnActionTriggered ();
			}
#pragma warning restore 0169

			IntPtr id_onActionTriggered;
			public unsafe void OnActionTriggered ()
			{
				if (id_onActionTriggered == IntPtr.Zero)
					id_onActionTriggered = JNIEnv.GetMethodID (class_ref, "onActionTriggered", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActionTriggered);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionPullWatcherView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
				__this.OnPull (pullAction, currentTargetOffset);
			}
#pragma warning restore 0169

			IntPtr id_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
			public unsafe void OnPull (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, int currentTargetOffset)
			{
				if (id_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I == IntPtr.Zero)
					id_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I = JNIEnv.GetMethodID (class_ref, "onPull", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				__args [1] = new JValue (currentTargetOffset);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionViewOffsetCalculator']"
		[Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionViewOffsetCalculator", "", "Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionViewOffsetCalculatorInvoker")]
		public partial interface IActionViewOffsetCalculator : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.ActionViewOffsetCalculator']/method[@name='calculateOffset' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction'] and parameter[2][@type='int']]"
			[Register ("calculateOffset", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)I", "GetCalculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler:Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IActionViewOffsetCalculatorInvoker, QMUI.Droid")]
			int CalculateOffset (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, int targetOffset);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionViewOffsetCalculator", DoNotGenerateAcw=true)]
		internal partial class IActionViewOffsetCalculatorInvoker : global::Java.Lang.Object, IActionViewOffsetCalculator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionViewOffsetCalculator", typeof (IActionViewOffsetCalculatorInvoker));

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

			public static IActionViewOffsetCalculator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IActionViewOffsetCalculator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.ActionViewOffsetCalculator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActionViewOffsetCalculatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionViewOffsetCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CalculateOffset (pullAction, targetOffset);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
			public unsafe int CalculateOffset (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, int targetOffset)
			{
				if (id_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I == IntPtr.Zero)
					id_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I = JNIEnv.GetMethodID (class_ref, "calculateOffset", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)I");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				__args [1] = new JValue (targetOffset);
				var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calculateOffset_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I, __args);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.DefaultStopTargetViewFlingImpl']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$DefaultStopTargetViewFlingImpl", DoNotGenerateAcw=true)]
		public partial class DefaultStopTargetViewFlingImpl : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IStopTargetViewFlingImpl {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$DefaultStopTargetViewFlingImpl", typeof (DefaultStopTargetViewFlingImpl));
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

			protected DefaultStopTargetViewFlingImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public static unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.DefaultStopTargetViewFlingImpl Instance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.DefaultStopTargetViewFlingImpl']/method[@name='getInstance' and count(parameter)=0]"
				[Register ("getInstance", "()Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$DefaultStopTargetViewFlingImpl;", "")]
				get {
					const string __id = "getInstance.()Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$DefaultStopTargetViewFlingImpl;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.DefaultStopTargetViewFlingImpl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_stopFling_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetStopFling_Landroid_view_View_Handler ()
			{
				if (cb_stopFling_Landroid_view_View_ == null)
					cb_stopFling_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopFling_Landroid_view_View_);
				return cb_stopFling_Landroid_view_View_;
			}

			static void n_StopFling_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.DefaultStopTargetViewFlingImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
				__this.StopFling (view);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.DefaultStopTargetViewFlingImpl']/method[@name='stopFling' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("stopFling", "(Landroid/view/View;)V", "GetStopFling_Landroid_view_View_Handler")]
			public virtual unsafe void StopFling (global::Android.Views.View view)
			{
				const string __id = "stopFling.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (view);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Widget.FrameLayout.LayoutParams {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='actionInitOffset']"
			[Register ("actionInitOffset")]
			public int ActionInitOffset {
				get {
					const string __id = "actionInitOffset.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "actionInitOffset.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='canOverPull']"
			[Register ("canOverPull")]
			public bool CanOverPull {
				get {
					const string __id = "canOverPull.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "canOverPull.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='edge']"
			[Register ("edge")]
			public int Edge {
				get {
					const string __id = "edge.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "edge.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='isTarget']"
			[Register ("isTarget")]
			public bool IsTarget {
				get {
					const string __id = "isTarget.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isTarget.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='needReceiveFlingFromTarget']"
			[Register ("needReceiveFlingFromTarget")]
			public bool NeedReceiveFlingFromTarget {
				get {
					const string __id = "needReceiveFlingFromTarget.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "needReceiveFlingFromTarget.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='pullRate']"
			[Register ("pullRate")]
			public float PullRate {
				get {
					const string __id = "pullRate.F";

					var __v = _members.InstanceFields.GetSingleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "pullRate.F";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='receivedFlingFraction']"
			[Register ("receivedFlingFraction")]
			public float ReceivedFlingFraction {
				get {
					const string __id = "receivedFlingFraction.F";

					var __v = _members.InstanceFields.GetSingleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "receivedFlingFraction.F";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='scrollSpeedPerPixel']"
			[Register ("scrollSpeedPerPixel")]
			public float ScrollSpeedPerPixel {
				get {
					const string __id = "scrollSpeedPerPixel.F";

					var __v = _members.InstanceFields.GetSingleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "scrollSpeedPerPixel.F";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='scrollToTriggerOffsetAfterTouchUp']"
			[Register ("scrollToTriggerOffsetAfterTouchUp")]
			public bool ScrollToTriggerOffsetAfterTouchUp {
				get {
					const string __id = "scrollToTriggerOffsetAfterTouchUp.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "scrollToTriggerOffsetAfterTouchUp.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='targetTriggerOffset']"
			[Register ("targetTriggerOffset")]
			public int TargetTriggerOffset {
				get {
					const string __id = "targetTriggerOffset.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "targetTriggerOffset.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/field[@name='triggerUntilScrollToTriggerOffset']"
			[Register ("triggerUntilScrollToTriggerOffset")]
			public bool TriggerUntilScrollToTriggerOffset {
				get {
					const string __id = "triggerUntilScrollToTriggerOffset.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "triggerUntilScrollToTriggerOffset.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$LayoutParams", typeof (LayoutParams));
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

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/constructor[@name='QMUIPullLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams (global::Android.Content.Context c, global::Android.Util.IAttributeSet attrs)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
					__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (c);
					global::System.GC.KeepAlive (attrs);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/constructor[@name='QMUIPullLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.LayoutParams p)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$LayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/constructor[@name='QMUIPullLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.MarginLayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.MarginLayoutParams source)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$MarginLayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (source);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.LayoutParams']/constructor[@name='QMUIPullLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe LayoutParams (int width, int height)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction", DoNotGenerateAcw=true)]
		public sealed partial class PullAction : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction", typeof (PullAction));
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

			internal PullAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int ActionInitOffset {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='getActionInitOffset' and count(parameter)=0]"
				[Register ("getActionInitOffset", "()I", "")]
				get {
					const string __id = "getActionInitOffset.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int ActionPullSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='getActionPullSize' and count(parameter)=0]"
				[Register ("getActionPullSize", "()I", "")]
				get {
					const string __id = "getActionPullSize.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool IsCanOverPull {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='isCanOverPull' and count(parameter)=0]"
				[Register ("isCanOverPull", "()Z", "")]
				get {
					const string __id = "isCanOverPull.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool IsNeedReceiveFlingFromTargetView {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='isNeedReceiveFlingFromTargetView' and count(parameter)=0]"
				[Register ("isNeedReceiveFlingFromTargetView", "()Z", "")]
				get {
					const string __id = "isNeedReceiveFlingFromTargetView.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool IsScrollToTriggerOffsetAfterTouchUp {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='isScrollToTriggerOffsetAfterTouchUp' and count(parameter)=0]"
				[Register ("isScrollToTriggerOffsetAfterTouchUp", "()Z", "")]
				get {
					const string __id = "isScrollToTriggerOffsetAfterTouchUp.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool IsTriggerUntilScrollToTriggerOffset {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='isTriggerUntilScrollToTriggerOffset' and count(parameter)=0]"
				[Register ("isTriggerUntilScrollToTriggerOffset", "()Z", "")]
				get {
					const string __id = "isTriggerUntilScrollToTriggerOffset.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int PullEdge {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='getPullEdge' and count(parameter)=0]"
				[Register ("getPullEdge", "()I", "")]
				get {
					const string __id = "getPullEdge.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe float PullRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='getPullRate' and count(parameter)=0]"
				[Register ("getPullRate", "()F", "")]
				get {
					const string __id = "getPullRate.()F";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe float ScrollSpeedPerPixel {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='getScrollSpeedPerPixel' and count(parameter)=0]"
				[Register ("getScrollSpeedPerPixel", "()F", "")]
				get {
					const string __id = "getScrollSpeedPerPixel.()F";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int TargetTriggerOffset {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='getTargetTriggerOffset' and count(parameter)=0]"
				[Register ("getTargetTriggerOffset", "()I", "")]
				get {
					const string __id = "getTargetTriggerOffset.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullAction']/method[@name='getFlingRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getFlingRate", "(I)F", "")]
			public unsafe float GetFlingRate (int currentTargetOffset)
			{
				const string __id = "getFlingRate.(I)F";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (currentTargetOffset);
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder", DoNotGenerateAcw=true)]
		public partial class PullActionBuilder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder", typeof (PullActionBuilder));
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

			protected PullActionBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/constructor[@name='QMUIPullLayout.PullActionBuilder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Landroid/view/View;I)V", "")]
			public unsafe PullActionBuilder (global::Android.Views.View actionView, int pullEdge)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/View;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((actionView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actionView).Handle);
					__args [1] = new JniArgumentValue (pullEdge);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (actionView);
				}
			}

			static Delegate cb_actionInitOffset_I;
#pragma warning disable 0169
			static Delegate GetActionInitOffset_IHandler ()
			{
				if (cb_actionInitOffset_I == null)
					cb_actionInitOffset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ActionInitOffset_I);
				return cb_actionInitOffset_I;
			}

			static IntPtr n_ActionInitOffset_I (IntPtr jnienv, IntPtr native__this, int initOffset)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ActionInitOffset (initOffset));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='actionInitOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("actionInitOffset", "(I)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetActionInitOffset_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder ActionInitOffset (int initOffset)
			{
				const string __id = "actionInitOffset.(I)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (initOffset);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_actionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_;
#pragma warning disable 0169
			static Delegate GetActionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_Handler ()
			{
				if (cb_actionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_ == null)
					cb_actionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ActionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_);
				return cb_actionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_;
			}

			static IntPtr n_ActionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calculator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var calculator = (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionViewOffsetCalculator)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionViewOffsetCalculator> (native_calculator, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ActionViewOffsetCalculator (calculator));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='actionViewOffsetCalculator' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.ActionViewOffsetCalculator']]"
			[Register ("actionViewOffsetCalculator", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionViewOffsetCalculator;)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetActionViewOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionViewOffsetCalculator_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder ActionViewOffsetCalculator (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionViewOffsetCalculator calculator)
			{
				const string __id = "actionViewOffsetCalculator.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionViewOffsetCalculator;)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((calculator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calculator).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (calculator);
				}
			}

			static Delegate cb_canOverPull_Z;
#pragma warning disable 0169
			static Delegate GetCanOverPull_ZHandler ()
			{
				if (cb_canOverPull_Z == null)
					cb_canOverPull_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_CanOverPull_Z);
				return cb_canOverPull_Z;
			}

			static IntPtr n_CanOverPull_Z (IntPtr jnienv, IntPtr native__this, bool canOverPull)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CanOverPull (canOverPull));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='canOverPull' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("canOverPull", "(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetCanOverPull_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder CanOverPull (bool canOverPull)
			{
				const string __id = "canOverPull.(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (canOverPull);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_needReceiveFlingFromTargetView_Z;
#pragma warning disable 0169
			static Delegate GetNeedReceiveFlingFromTargetView_ZHandler ()
			{
				if (cb_needReceiveFlingFromTargetView_Z == null)
					cb_needReceiveFlingFromTargetView_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_NeedReceiveFlingFromTargetView_Z);
				return cb_needReceiveFlingFromTargetView_Z;
			}

			static IntPtr n_NeedReceiveFlingFromTargetView_Z (IntPtr jnienv, IntPtr native__this, bool needReceive)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NeedReceiveFlingFromTargetView (needReceive));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='needReceiveFlingFromTargetView' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("needReceiveFlingFromTargetView", "(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetNeedReceiveFlingFromTargetView_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder NeedReceiveFlingFromTargetView (bool needReceive)
			{
				const string __id = "needReceiveFlingFromTargetView.(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (needReceive);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_pullRate_F;
#pragma warning disable 0169
			static Delegate GetPullRate_FHandler ()
			{
				if (cb_pullRate_F == null)
					cb_pullRate_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_PullRate_F);
				return cb_pullRate_F;
			}

			static IntPtr n_PullRate_F (IntPtr jnienv, IntPtr native__this, float rate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PullRate (rate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='pullRate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("pullRate", "(F)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetPullRate_FHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder PullRate (float rate)
			{
				const string __id = "pullRate.(F)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_receivedFlingFraction_F;
#pragma warning disable 0169
			static Delegate GetReceivedFlingFraction_FHandler ()
			{
				if (cb_receivedFlingFraction_F == null)
					cb_receivedFlingFraction_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_ReceivedFlingFraction_F);
				return cb_receivedFlingFraction_F;
			}

			static IntPtr n_ReceivedFlingFraction_F (IntPtr jnienv, IntPtr native__this, float fraction)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ReceivedFlingFraction (fraction));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='receivedFlingFraction' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("receivedFlingFraction", "(F)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetReceivedFlingFraction_FHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder ReceivedFlingFraction (float fraction)
			{
				const string __id = "receivedFlingFraction.(F)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (fraction);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_scrollSpeedPerPixel_F;
#pragma warning disable 0169
			static Delegate GetScrollSpeedPerPixel_FHandler ()
			{
				if (cb_scrollSpeedPerPixel_F == null)
					cb_scrollSpeedPerPixel_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_ScrollSpeedPerPixel_F);
				return cb_scrollSpeedPerPixel_F;
			}

			static IntPtr n_ScrollSpeedPerPixel_F (IntPtr jnienv, IntPtr native__this, float scrollSpeedPerPixel)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ScrollSpeedPerPixel (scrollSpeedPerPixel));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='scrollSpeedPerPixel' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("scrollSpeedPerPixel", "(F)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetScrollSpeedPerPixel_FHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder ScrollSpeedPerPixel (float scrollSpeedPerPixel)
			{
				const string __id = "scrollSpeedPerPixel.(F)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (scrollSpeedPerPixel);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_scrollToTriggerOffsetAfterTouchUp_Z;
#pragma warning disable 0169
			static Delegate GetScrollToTriggerOffsetAfterTouchUp_ZHandler ()
			{
				if (cb_scrollToTriggerOffsetAfterTouchUp_Z == null)
					cb_scrollToTriggerOffsetAfterTouchUp_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ScrollToTriggerOffsetAfterTouchUp_Z);
				return cb_scrollToTriggerOffsetAfterTouchUp_Z;
			}

			static IntPtr n_ScrollToTriggerOffsetAfterTouchUp_Z (IntPtr jnienv, IntPtr native__this, bool scrollToTriggerOffsetAfterTouchUp)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ScrollToTriggerOffsetAfterTouchUp (scrollToTriggerOffsetAfterTouchUp));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='scrollToTriggerOffsetAfterTouchUp' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("scrollToTriggerOffsetAfterTouchUp", "(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetScrollToTriggerOffsetAfterTouchUp_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder ScrollToTriggerOffsetAfterTouchUp (bool scrollToTriggerOffsetAfterTouchUp)
			{
				const string __id = "scrollToTriggerOffsetAfterTouchUp.(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (scrollToTriggerOffsetAfterTouchUp);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_targetTriggerOffset_I;
#pragma warning disable 0169
			static Delegate GetTargetTriggerOffset_IHandler ()
			{
				if (cb_targetTriggerOffset_I == null)
					cb_targetTriggerOffset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TargetTriggerOffset_I);
				return cb_targetTriggerOffset_I;
			}

			static IntPtr n_TargetTriggerOffset_I (IntPtr jnienv, IntPtr native__this, int offset)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TargetTriggerOffset (offset));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='targetTriggerOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("targetTriggerOffset", "(I)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetTargetTriggerOffset_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder TargetTriggerOffset (int offset)
			{
				const string __id = "targetTriggerOffset.(I)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (offset);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_triggerUntilScrollToTriggerOffset_Z;
#pragma warning disable 0169
			static Delegate GetTriggerUntilScrollToTriggerOffset_ZHandler ()
			{
				if (cb_triggerUntilScrollToTriggerOffset_Z == null)
					cb_triggerUntilScrollToTriggerOffset_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_TriggerUntilScrollToTriggerOffset_Z);
				return cb_triggerUntilScrollToTriggerOffset_Z;
			}

			static IntPtr n_TriggerUntilScrollToTriggerOffset_Z (IntPtr jnienv, IntPtr native__this, bool triggerUntilScrollToTriggerOffset)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TriggerUntilScrollToTriggerOffset (triggerUntilScrollToTriggerOffset));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout.PullActionBuilder']/method[@name='triggerUntilScrollToTriggerOffset' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("triggerUntilScrollToTriggerOffset", "(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;", "GetTriggerUntilScrollToTriggerOffset_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder TriggerUntilScrollToTriggerOffset (bool triggerUntilScrollToTriggerOffset)
			{
				const string __id = "triggerUntilScrollToTriggerOffset.(Z)Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (triggerUntilScrollToTriggerOffset);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.PullEdge']"
		[Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullEdge", "", "Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IPullEdgeInvoker")]
		public partial interface IPullEdge : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullEdge", DoNotGenerateAcw=true)]
		internal partial class IPullEdgeInvoker : global::Java.Lang.Object, IPullEdge {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullEdge", typeof (IPullEdgeInvoker));

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

			public static IPullEdge GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPullEdge> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullEdge"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPullEdgeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IPullEdge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IPullEdge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IPullEdge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IPullEdge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.StopTargetViewFlingImpl']"
		[Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$StopTargetViewFlingImpl", "", "Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IStopTargetViewFlingImplInvoker")]
		public partial interface IStopTargetViewFlingImpl : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/interface[@name='QMUIPullLayout.StopTargetViewFlingImpl']/method[@name='stopFling' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("stopFling", "(Landroid/view/View;)V", "GetStopFling_Landroid_view_View_Handler:Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout/IStopTargetViewFlingImplInvoker, QMUI.Droid")]
			void StopFling (global::Android.Views.View p0);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$StopTargetViewFlingImpl", DoNotGenerateAcw=true)]
		internal partial class IStopTargetViewFlingImplInvoker : global::Java.Lang.Object, IStopTargetViewFlingImpl {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$StopTargetViewFlingImpl", typeof (IStopTargetViewFlingImplInvoker));

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

			public static IStopTargetViewFlingImpl GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStopTargetViewFlingImpl> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.StopTargetViewFlingImpl"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStopTargetViewFlingImplInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_stopFling_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetStopFling_Landroid_view_View_Handler ()
			{
				if (cb_stopFling_Landroid_view_View_ == null)
					cb_stopFling_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopFling_Landroid_view_View_);
				return cb_stopFling_Landroid_view_View_;
			}

			static void n_StopFling_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IStopTargetViewFlingImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.StopFling (p0);
			}
#pragma warning restore 0169

			IntPtr id_stopFling_Landroid_view_View_;
			public unsafe void StopFling (global::Android.Views.View p0)
			{
				if (id_stopFling_Landroid_view_View_ == IntPtr.Zero)
					id_stopFling_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "stopFling", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopFling_Landroid_view_View_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout", typeof (QMUIPullLayout));
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

		protected QMUIPullLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/constructor[@name='QMUIPullLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIPullLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/constructor[@name='QMUIPullLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIPullLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/constructor[@name='QMUIPullLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIPullLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_;
#pragma warning disable 0169
		static Delegate GetFinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Handler ()
		{
			if (cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ == null)
				cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_);
			return cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_;
		}

		static void n_FinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pullAction)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
			__this.FinishActionRun (pullAction);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='finishActionRun' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction']]"
		[Register ("finishActionRun", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;)V", "GetFinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Handler")]
		public virtual unsafe void FinishActionRun (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction)
		{
			const string __id = "finishActionRun.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pullAction);
			}
		}

		static Delegate cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Z;
#pragma warning disable 0169
		static Delegate GetFinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ZHandler ()
		{
			if (cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Z == null)
				cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_FinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Z);
			return cb_finishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Z;
		}

		static void n_FinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_pullAction, bool animate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
			__this.FinishActionRun (pullAction, animate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='finishActionRun' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction'] and parameter[2][@type='boolean']]"
		[Register ("finishActionRun", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;Z)V", "GetFinishActionRun_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_ZHandler")]
		public virtual unsafe void FinishActionRun (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, bool animate)
		{
			const string __id = "finishActionRun.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				__args [1] = new JniArgumentValue (animate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pullAction);
			}
		}

		static Delegate cb_isEdgeEnabled_I;
#pragma warning disable 0169
		static Delegate GetIsEdgeEnabled_IHandler ()
		{
			if (cb_isEdgeEnabled_I == null)
				cb_isEdgeEnabled_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsEdgeEnabled_I);
			return cb_isEdgeEnabled_I;
		}

		static bool n_IsEdgeEnabled_I (IntPtr jnienv, IntPtr native__this, int edge)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEdgeEnabled (edge);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='isEdgeEnabled' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isEdgeEnabled", "(I)Z", "GetIsEdgeEnabled_IHandler")]
		public virtual unsafe bool IsEdgeEnabled (int edge)
		{
			const string __id = "isEdgeEnabled.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (edge);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
#pragma warning disable 0169
		static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler ()
		{
			if (cb_onNestedPreScroll_Landroid_view_View_IIarrayII == null)
				cb_onNestedPreScroll_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILI_V) n_OnNestedPreScroll_Landroid_view_View_IIarrayII);
			return cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
		}

		static void n_OnNestedPreScroll_Landroid_view_View_IIarrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			var consumed = (int[]) JNIEnv.GetArray (native_consumed, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnNestedPreScroll (target, dx, dy, consumed, type);
			if (consumed != null)
				JNIEnv.CopyArray (consumed, native_consumed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onNestedPreScroll' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int']]"
		[Register ("onNestedPreScroll", "(Landroid/view/View;II[II)V", "GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler")]
		public virtual unsafe void OnNestedPreScroll (global::Android.Views.View target, int dx, int dy, int[] consumed, int type)
		{
			const string __id = "onNestedPreScroll.(Landroid/view/View;II[II)V";
			IntPtr native_consumed = JNIEnv.NewArray (consumed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (dx);
				__args [2] = new JniArgumentValue (dy);
				__args [3] = new JniArgumentValue (native_consumed);
				__args [4] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (consumed != null) {
					JNIEnv.CopyArray (native_consumed, consumed);
					JNIEnv.DeleteLocalRef (native_consumed);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (consumed);
			}
		}

		static Delegate cb_onNestedScroll_Landroid_view_View_IIIII;
#pragma warning disable 0169
		static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIHandler ()
		{
			if (cb_onNestedScroll_Landroid_view_View_IIIII == null)
				cb_onNestedScroll_Landroid_view_View_IIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIII_V) n_OnNestedScroll_Landroid_view_View_IIIII);
			return cb_onNestedScroll_Landroid_view_View_IIIII;
		}

		static void n_OnNestedScroll_Landroid_view_View_IIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.OnNestedScroll (target, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onNestedScroll' and count(parameter)=6 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("onNestedScroll", "(Landroid/view/View;IIIII)V", "GetOnNestedScroll_Landroid_view_View_IIIIIHandler")]
		public virtual unsafe void OnNestedScroll (global::Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			const string __id = "onNestedScroll.(Landroid/view/View;IIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (dxConsumed);
				__args [2] = new JniArgumentValue (dyConsumed);
				__args [3] = new JniArgumentValue (dxUnconsumed);
				__args [4] = new JniArgumentValue (dyUnconsumed);
				__args [5] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;
#pragma warning disable 0169
		static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler ()
		{
			if (cb_onNestedScroll_Landroid_view_View_IIIIIarrayI == null)
				cb_onNestedScroll_Landroid_view_View_IIIIIarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIIIL_V) n_OnNestedScroll_Landroid_view_View_IIIIIarrayI);
			return cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;
		}

		static void n_OnNestedScroll_Landroid_view_View_IIIIIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, IntPtr native_consumed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			var consumed = (int[]) JNIEnv.GetArray (native_consumed, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnNestedScroll (target, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type, consumed);
			if (consumed != null)
				JNIEnv.CopyArray (consumed, native_consumed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onNestedScroll' and count(parameter)=7 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int[]']]"
		[Register ("onNestedScroll", "(Landroid/view/View;IIIII[I)V", "GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler")]
		public virtual unsafe void OnNestedScroll (global::Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed)
		{
			const string __id = "onNestedScroll.(Landroid/view/View;IIIII[I)V";
			IntPtr native_consumed = JNIEnv.NewArray (consumed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (dxConsumed);
				__args [2] = new JniArgumentValue (dyConsumed);
				__args [3] = new JniArgumentValue (dxUnconsumed);
				__args [4] = new JniArgumentValue (dyUnconsumed);
				__args [5] = new JniArgumentValue (type);
				__args [6] = new JniArgumentValue (native_consumed);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (consumed != null) {
					JNIEnv.CopyArray (native_consumed, consumed);
					JNIEnv.DeleteLocalRef (native_consumed);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (consumed);
			}
		}

		static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler ()
		{
			if (cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II == null)
				cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II);
			return cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
		}

		static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int axes, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_child, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.OnNestedScrollAccepted (child, target, axes, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onNestedScrollAccepted' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;II)V", "GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler")]
		public virtual unsafe void OnNestedScrollAccepted (global::Android.Views.View child, global::Android.Views.View target, int axes, int type)
		{
			const string __id = "onNestedScrollAccepted.(Landroid/view/View;Landroid/view/View;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [2] = new JniArgumentValue (axes);
				__args [3] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (child);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler ()
		{
			if (cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II == null)
				cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_Z) n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II);
			return cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
		}

		static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int axes, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_child, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnStartNestedScroll (child, target, axes, type);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onStartNestedScroll' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler")]
		public virtual unsafe bool OnStartNestedScroll (global::Android.Views.View child, global::Android.Views.View target, int axes, int type)
		{
			const string __id = "onStartNestedScroll.(Landroid/view/View;Landroid/view/View;II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [2] = new JniArgumentValue (axes);
				__args [3] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (child);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onStopNestedScroll_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnStopNestedScroll_Landroid_view_View_IHandler ()
		{
			if (cb_onStopNestedScroll_Landroid_view_View_I == null)
				cb_onStopNestedScroll_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnStopNestedScroll_Landroid_view_View_I);
			return cb_onStopNestedScroll_Landroid_view_View_I;
		}

		static void n_OnStopNestedScroll_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_target, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.OnStopNestedScroll (target, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onStopNestedScroll' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onStopNestedScroll", "(Landroid/view/View;I)V", "GetOnStopNestedScroll_Landroid_view_View_IHandler")]
		public virtual unsafe void OnStopNestedScroll (global::Android.Views.View target, int type)
		{
			const string __id = "onStopNestedScroll.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onTargetViewLeftAndRightOffsetChanged_I;
#pragma warning disable 0169
		static Delegate GetOnTargetViewLeftAndRightOffsetChanged_IHandler ()
		{
			if (cb_onTargetViewLeftAndRightOffsetChanged_I == null)
				cb_onTargetViewLeftAndRightOffsetChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTargetViewLeftAndRightOffsetChanged_I);
			return cb_onTargetViewLeftAndRightOffsetChanged_I;
		}

		static void n_OnTargetViewLeftAndRightOffsetChanged_I (IntPtr jnienv, IntPtr native__this, int hOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTargetViewLeftAndRightOffsetChanged (hOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onTargetViewLeftAndRightOffsetChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTargetViewLeftAndRightOffsetChanged", "(I)V", "GetOnTargetViewLeftAndRightOffsetChanged_IHandler")]
		protected virtual unsafe void OnTargetViewLeftAndRightOffsetChanged (int hOffset)
		{
			const string __id = "onTargetViewLeftAndRightOffsetChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (hOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onTargetViewTopAndBottomOffsetChanged_I;
#pragma warning disable 0169
		static Delegate GetOnTargetViewTopAndBottomOffsetChanged_IHandler ()
		{
			if (cb_onTargetViewTopAndBottomOffsetChanged_I == null)
				cb_onTargetViewTopAndBottomOffsetChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTargetViewTopAndBottomOffsetChanged_I);
			return cb_onTargetViewTopAndBottomOffsetChanged_I;
		}

		static void n_OnTargetViewTopAndBottomOffsetChanged_I (IntPtr jnienv, IntPtr native__this, int vOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTargetViewTopAndBottomOffsetChanged (vOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='onTargetViewTopAndBottomOffsetChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTargetViewTopAndBottomOffsetChanged", "(I)V", "GetOnTargetViewTopAndBottomOffsetChanged_IHandler")]
		protected virtual unsafe void OnTargetViewTopAndBottomOffsetChanged (int vOffset)
		{
			const string __id = "onTargetViewTopAndBottomOffsetChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (vOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_;
#pragma warning disable 0169
		static Delegate GetSetActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_Handler ()
		{
			if (cb_setActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_ == null)
				cb_setActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_);
			return cb_setActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_;
		}

		static void n_SetActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actionListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var actionListener = (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListener> (native_actionListener, JniHandleOwnership.DoNotTransfer);
			__this.SetActionListener (actionListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setActionListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.ActionListener']]"
		[Register ("setActionListener", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionListener;)V", "GetSetActionListener_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_ActionListener_Handler")]
		public virtual unsafe void SetActionListener (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListener actionListener)
		{
			const string __id = "setActionListener.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$ActionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((actionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actionListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (actionListener);
			}
		}

		static Delegate cb_setActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_Handler ()
		{
			if (cb_setActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_ == null)
				cb_setActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_);
			return cb_setActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_;
		}

		static void n_SetActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_lp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var lp = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.LayoutParams> (native_lp, JniHandleOwnership.DoNotTransfer);
			__this.SetActionView (view, lp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setActionView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.LayoutParams']]"
		[Register ("setActionView", "(Landroid/view/View;Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$LayoutParams;)V", "GetSetActionView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_LayoutParams_Handler")]
		public virtual unsafe void SetActionView (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.LayoutParams lp)
		{
			const string __id = "setActionView.(Landroid/view/View;Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((lp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (lp);
			}
		}

		static Delegate cb_setActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_;
#pragma warning disable 0169
		static Delegate GetSetActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_Handler ()
		{
			if (cb_setActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_ == null)
				cb_setActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_);
			return cb_setActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_;
		}

		static void n_SetActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.SetActionView (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setActionView' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullActionBuilder']]"
		[Register ("setActionView", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;)V", "GetSetActionView_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullActionBuilder_Handler")]
		public virtual unsafe void SetActionView (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullActionBuilder builder)
		{
			const string __id = "setActionView.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullActionBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_setEnabledEdges_I;
#pragma warning disable 0169
		static Delegate GetSetEnabledEdges_IHandler ()
		{
			if (cb_setEnabledEdges_I == null)
				cb_setEnabledEdges_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetEnabledEdges_I);
			return cb_setEnabledEdges_I;
		}

		static void n_SetEnabledEdges_I (IntPtr jnienv, IntPtr native__this, int enabledEdges)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnabledEdges (enabledEdges);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setEnabledEdges' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEnabledEdges", "(I)V", "GetSetEnabledEdges_IHandler")]
		public virtual unsafe void SetEnabledEdges (int enabledEdges)
		{
			const string __id = "setEnabledEdges.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabledEdges);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinScrollDuration_I;
#pragma warning disable 0169
		static Delegate GetSetMinScrollDuration_IHandler ()
		{
			if (cb_setMinScrollDuration_I == null)
				cb_setMinScrollDuration_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMinScrollDuration_I);
			return cb_setMinScrollDuration_I;
		}

		static void n_SetMinScrollDuration_I (IntPtr jnienv, IntPtr native__this, int minScrollDuration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinScrollDuration (minScrollDuration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setMinScrollDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMinScrollDuration", "(I)V", "GetSetMinScrollDuration_IHandler")]
		public virtual unsafe void SetMinScrollDuration (int minScrollDuration)
		{
			const string __id = "setMinScrollDuration.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minScrollDuration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNestedPreFlingVelocityScaleDown_F;
#pragma warning disable 0169
		static Delegate GetSetNestedPreFlingVelocityScaleDown_FHandler ()
		{
			if (cb_setNestedPreFlingVelocityScaleDown_F == null)
				cb_setNestedPreFlingVelocityScaleDown_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetNestedPreFlingVelocityScaleDown_F);
			return cb_setNestedPreFlingVelocityScaleDown_F;
		}

		static void n_SetNestedPreFlingVelocityScaleDown_F (IntPtr jnienv, IntPtr native__this, float nestedPreFlingVelocityScaleDown)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNestedPreFlingVelocityScaleDown (nestedPreFlingVelocityScaleDown);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setNestedPreFlingVelocityScaleDown' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setNestedPreFlingVelocityScaleDown", "(F)V", "GetSetNestedPreFlingVelocityScaleDown_FHandler")]
		public virtual unsafe void SetNestedPreFlingVelocityScaleDown (float nestedPreFlingVelocityScaleDown)
		{
			const string __id = "setNestedPreFlingVelocityScaleDown.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nestedPreFlingVelocityScaleDown);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_;
#pragma warning disable 0169
		static Delegate GetSetStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_Handler ()
		{
			if (cb_setStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_ == null)
				cb_setStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_);
			return cb_setStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_;
		}

		static void n_SetStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stopTargetViewFlingImpl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stopTargetViewFlingImpl = (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IStopTargetViewFlingImpl)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IStopTargetViewFlingImpl> (native_stopTargetViewFlingImpl, JniHandleOwnership.DoNotTransfer);
			__this.SetStopTargetViewFlingImpl (stopTargetViewFlingImpl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setStopTargetViewFlingImpl' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.StopTargetViewFlingImpl']]"
		[Register ("setStopTargetViewFlingImpl", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$StopTargetViewFlingImpl;)V", "GetSetStopTargetViewFlingImpl_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_StopTargetViewFlingImpl_Handler")]
		public virtual unsafe void SetStopTargetViewFlingImpl (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IStopTargetViewFlingImpl stopTargetViewFlingImpl)
		{
			const string __id = "setStopTargetViewFlingImpl.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$StopTargetViewFlingImpl;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stopTargetViewFlingImpl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopTargetViewFlingImpl).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (stopTargetViewFlingImpl);
			}
		}

		static Delegate cb_setTargetView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetTargetView_Landroid_view_View_Handler ()
		{
			if (cb_setTargetView_Landroid_view_View_ == null)
				cb_setTargetView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTargetView_Landroid_view_View_);
			return cb_setTargetView_Landroid_view_View_;
		}

		static void n_SetTargetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetTargetView (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullLayout']/method[@name='setTargetView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setTargetView", "(Landroid/view/View;)V", "GetSetTargetView_Landroid_view_View_Handler")]
		public virtual unsafe void SetTargetView (global::Android.Views.View view)
		{
			const string __id = "setTargetView.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.ActionEventArgs> Action {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListener, global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListenerImplementor>(
						ref weak_implementor_SetActionListener,
						__CreateIActionListenerImplementor,
						SetActionListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListener, global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListenerImplementor>(
						ref weak_implementor_SetActionListener,
						global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListenerImplementor.__IsEmpty,
						__v => SetActionListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetActionListener;

		global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListenerImplementor __CreateIActionListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionListenerImplementor (this);
		}
#endregion
	}
}
