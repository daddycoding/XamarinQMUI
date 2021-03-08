using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.PullRefreshLayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout", DoNotGenerateAcw=true)]
	public partial class QMUIPullRefreshLayout : global::Android.Views.ViewGroup, global::AndroidX.Core.View.INestedScrollingParent {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.IRefreshView']"
		[Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$IRefreshView", "", "Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IRefreshViewInvoker")]
		public partial interface IRefreshView : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.IRefreshView']/method[@name='doRefresh' and count(parameter)=0]"
			[Register ("doRefresh", "()V", "GetDoRefreshHandler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IRefreshViewInvoker, QMUI.Droid")]
			void DoRefresh ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.IRefreshView']/method[@name='onPull' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onPull", "(III)V", "GetOnPull_IIIHandler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IRefreshViewInvoker, QMUI.Droid")]
			void OnPull (int offset, int total, int overPull);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.IRefreshView']/method[@name='stop' and count(parameter)=0]"
			[Register ("stop", "()V", "GetStopHandler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IRefreshViewInvoker, QMUI.Droid")]
			void Stop ();

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$IRefreshView", DoNotGenerateAcw=true)]
		internal partial class IRefreshViewInvoker : global::Java.Lang.Object, IRefreshView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$IRefreshView", typeof (IRefreshViewInvoker));

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

			public static IRefreshView GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRefreshView> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.IRefreshView"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRefreshViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_doRefresh;
#pragma warning disable 0169
			static Delegate GetDoRefreshHandler ()
			{
				if (cb_doRefresh == null)
					cb_doRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRefresh);
				return cb_doRefresh;
			}

			static void n_DoRefresh (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DoRefresh ();
			}
#pragma warning restore 0169

			IntPtr id_doRefresh;
			public unsafe void DoRefresh ()
			{
				if (id_doRefresh == IntPtr.Zero)
					id_doRefresh = JNIEnv.GetMethodID (class_ref, "doRefresh", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doRefresh);
			}

			static Delegate cb_onPull_III;
#pragma warning disable 0169
			static Delegate GetOnPull_IIIHandler ()
			{
				if (cb_onPull_III == null)
					cb_onPull_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnPull_III);
				return cb_onPull_III;
			}

			static void n_OnPull_III (IntPtr jnienv, IntPtr native__this, int offset, int total, int overPull)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPull (offset, total, overPull);
			}
#pragma warning restore 0169

			IntPtr id_onPull_III;
			public unsafe void OnPull (int offset, int total, int overPull)
			{
				if (id_onPull_III == IntPtr.Zero)
					id_onPull_III = JNIEnv.GetMethodID (class_ref, "onPull", "(III)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (offset);
				__args [1] = new JValue (total);
				__args [2] = new JValue (overPull);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPull_III, __args);
			}

			static Delegate cb_stop;
#pragma warning disable 0169
			static Delegate GetStopHandler ()
			{
				if (cb_stop == null)
					cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
				return cb_stop;
			}

			static void n_Stop (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Stop ();
			}
#pragma warning restore 0169

			IntPtr id_stop;
			public unsafe void Stop ()
			{
				if (id_stop == IntPtr.Zero)
					id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.OnChildScrollUpCallback']"
		[Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnChildScrollUpCallback", "", "Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IOnChildScrollUpCallbackInvoker")]
		public partial interface IOnChildScrollUpCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.OnChildScrollUpCallback']/method[@name='canChildScrollUp' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout'] and parameter[2][@type='android.view.View']]"
			[Register ("canChildScrollUp", "(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout;Landroid/view/View;)Z", "GetCanChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_Handler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IOnChildScrollUpCallbackInvoker, QMUI.Droid")]
			bool CanChildScrollUp (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout p0, global::Android.Views.View p1);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnChildScrollUpCallback", DoNotGenerateAcw=true)]
		internal partial class IOnChildScrollUpCallbackInvoker : global::Java.Lang.Object, IOnChildScrollUpCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnChildScrollUpCallback", typeof (IOnChildScrollUpCallbackInvoker));

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

			public static IOnChildScrollUpCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnChildScrollUpCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.OnChildScrollUpCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnChildScrollUpCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetCanChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_Handler ()
			{
				if (cb_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_ == null)
					cb_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_CanChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_);
				return cb_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_;
			}

			static bool n_CanChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnChildScrollUpCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.CanChildScrollUp (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_;
			public unsafe bool CanChildScrollUp (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout p0, global::Android.Views.View p1)
			{
				if (id_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_ == IntPtr.Zero)
					id_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "canChildScrollUp", "(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout;Landroid/view/View;)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canChildScrollUp_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_Landroid_view_View_, __args);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.OnPullListener']"
		[Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnPullListener", "", "Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IOnPullListenerInvoker")]
		public partial interface IOnPullListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.OnPullListener']/method[@name='onMoveRefreshView' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onMoveRefreshView", "(I)V", "GetOnMoveRefreshView_IHandler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IOnPullListenerInvoker, QMUI.Droid")]
			void OnMoveRefreshView (int offset);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.OnPullListener']/method[@name='onMoveTarget' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onMoveTarget", "(I)V", "GetOnMoveTarget_IHandler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IOnPullListenerInvoker, QMUI.Droid")]
			void OnMoveTarget (int offset);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.OnPullListener']/method[@name='onRefresh' and count(parameter)=0]"
			[Register ("onRefresh", "()V", "GetOnRefreshHandler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IOnPullListenerInvoker, QMUI.Droid")]
			void OnRefresh ();

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnPullListener", DoNotGenerateAcw=true)]
		internal partial class IOnPullListenerInvoker : global::Java.Lang.Object, IOnPullListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnPullListener", typeof (IOnPullListenerInvoker));

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

			public static IOnPullListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPullListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.OnPullListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPullListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMoveRefreshView_I;
#pragma warning disable 0169
			static Delegate GetOnMoveRefreshView_IHandler ()
			{
				if (cb_onMoveRefreshView_I == null)
					cb_onMoveRefreshView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnMoveRefreshView_I);
				return cb_onMoveRefreshView_I;
			}

			static void n_OnMoveRefreshView_I (IntPtr jnienv, IntPtr native__this, int offset)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMoveRefreshView (offset);
			}
#pragma warning restore 0169

			IntPtr id_onMoveRefreshView_I;
			public unsafe void OnMoveRefreshView (int offset)
			{
				if (id_onMoveRefreshView_I == IntPtr.Zero)
					id_onMoveRefreshView_I = JNIEnv.GetMethodID (class_ref, "onMoveRefreshView", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (offset);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMoveRefreshView_I, __args);
			}

			static Delegate cb_onMoveTarget_I;
#pragma warning disable 0169
			static Delegate GetOnMoveTarget_IHandler ()
			{
				if (cb_onMoveTarget_I == null)
					cb_onMoveTarget_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnMoveTarget_I);
				return cb_onMoveTarget_I;
			}

			static void n_OnMoveTarget_I (IntPtr jnienv, IntPtr native__this, int offset)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMoveTarget (offset);
			}
#pragma warning restore 0169

			IntPtr id_onMoveTarget_I;
			public unsafe void OnMoveTarget (int offset)
			{
				if (id_onMoveTarget_I == IntPtr.Zero)
					id_onMoveTarget_I = JNIEnv.GetMethodID (class_ref, "onMoveTarget", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (offset);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMoveTarget_I, __args);
			}

			static Delegate cb_onRefresh;
#pragma warning disable 0169
			static Delegate GetOnRefreshHandler ()
			{
				if (cb_onRefresh == null)
					cb_onRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRefresh);
				return cb_onRefresh;
			}

			static void n_OnRefresh (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRefresh ();
			}
#pragma warning restore 0169

			IntPtr id_onRefresh;
			public unsafe void OnRefresh ()
			{
				if (id_onRefresh == IntPtr.Zero)
					id_onRefresh = JNIEnv.GetMethodID (class_ref, "onRefresh", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRefresh);
			}

		}

		// event args for com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.OnPullListener.onMoveRefreshView
		public partial class MoveRefreshViewEventArgs : global::System.EventArgs {

			public MoveRefreshViewEventArgs (int offset)
			{
				this.offset = offset;
			}

			int offset;
			public int Offset {
				get { return offset; }
			}
		}

		// event args for com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.OnPullListener.onMoveTarget
		public partial class MoveTargetEventArgs : global::System.EventArgs {

			public MoveTargetEventArgs (int offset)
			{
				this.offset = offset;
			}

			int offset;
			public int Offset {
				get { return offset; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout_OnPullListenerImplementor")]
		internal sealed partial class IOnPullListenerImplementor : global::Java.Lang.Object, IOnPullListener {

			object sender;

			public IOnPullListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout_OnPullListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MoveRefreshViewEventArgs> OnMoveRefreshViewHandler;
#pragma warning restore 0649

			public void OnMoveRefreshView (int offset)
			{
				var __h = OnMoveRefreshViewHandler;
				if (__h != null)
					__h (sender, new MoveRefreshViewEventArgs (offset));
			}
#pragma warning disable 0649
			public EventHandler<MoveTargetEventArgs> OnMoveTargetHandler;
#pragma warning restore 0649

			public void OnMoveTarget (int offset)
			{
				var __h = OnMoveTargetHandler;
				if (__h != null)
					__h (sender, new MoveTargetEventArgs (offset));
			}
#pragma warning disable 0649
			public EventHandler OnRefreshHandler;
#pragma warning restore 0649

			public void OnRefresh ()
			{
				var __h = OnRefreshHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnPullListenerImplementor value)
			{
				return value.OnMoveRefreshViewHandler == null && value.OnMoveTargetHandler == null && value.OnRefreshHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.RefreshOffsetCalculator']"
		[Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$RefreshOffsetCalculator", "", "Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IRefreshOffsetCalculatorInvoker")]
		public partial interface IRefreshOffsetCalculator : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/interface[@name='QMUIPullRefreshLayout.RefreshOffsetCalculator']/method[@name='calculateRefreshOffset' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register ("calculateRefreshOffset", "(IIIIII)I", "GetCalculateRefreshOffset_IIIIIIHandler:Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout/IRefreshOffsetCalculatorInvoker, QMUI.Droid")]
			int CalculateRefreshOffset (int refreshInitOffset, int refreshEndOffset, int refreshViewHeight, int targetCurrentOffset, int targetInitOffset, int targetRefreshOffset);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$RefreshOffsetCalculator", DoNotGenerateAcw=true)]
		internal partial class IRefreshOffsetCalculatorInvoker : global::Java.Lang.Object, IRefreshOffsetCalculator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$RefreshOffsetCalculator", typeof (IRefreshOffsetCalculatorInvoker));

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

			public static IRefreshOffsetCalculator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRefreshOffsetCalculator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.RefreshOffsetCalculator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRefreshOffsetCalculatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshOffsetCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CalculateRefreshOffset (refreshInitOffset, refreshEndOffset, refreshViewHeight, targetCurrentOffset, targetInitOffset, targetRefreshOffset);
			}
#pragma warning restore 0169

			IntPtr id_calculateRefreshOffset_IIIIII;
			public unsafe int CalculateRefreshOffset (int refreshInitOffset, int refreshEndOffset, int refreshViewHeight, int targetCurrentOffset, int targetInitOffset, int targetRefreshOffset)
			{
				if (id_calculateRefreshOffset_IIIIII == IntPtr.Zero)
					id_calculateRefreshOffset_IIIIII = JNIEnv.GetMethodID (class_ref, "calculateRefreshOffset", "(IIIIII)I");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (refreshInitOffset);
				__args [1] = new JValue (refreshEndOffset);
				__args [2] = new JValue (refreshViewHeight);
				__args [3] = new JValue (targetCurrentOffset);
				__args [4] = new JValue (targetInitOffset);
				__args [5] = new JValue (targetRefreshOffset);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calculateRefreshOffset_IIIIII, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$RefreshView", DoNotGenerateAcw=true)]
		public partial class RefreshView : global::AndroidX.AppCompat.Widget.AppCompatImageView, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$RefreshView", typeof (RefreshView));
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

			protected RefreshView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/constructor[@name='QMUIPullRefreshLayout.RefreshView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe RefreshView (global::Android.Content.Context context)
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

			static Delegate cb_getDefaultSkinAttrs;
#pragma warning disable 0169
			static Delegate GetGetDefaultSkinAttrsHandler ()
			{
				if (cb_getDefaultSkinAttrs == null)
					cb_getDefaultSkinAttrs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultSkinAttrs);
				return cb_getDefaultSkinAttrs;
			}

			static IntPtr n_GetDefaultSkinAttrs (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.RefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
			}
#pragma warning restore 0169

			public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
				[Register ("getDefaultSkinAttrs", "()Landroidx/collection/SimpleArrayMap;", "GetGetDefaultSkinAttrsHandler")]
				get {
					const string __id = "getDefaultSkinAttrs.()Landroidx/collection/SimpleArrayMap;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_doRefresh;
#pragma warning disable 0169
			static Delegate GetDoRefreshHandler ()
			{
				if (cb_doRefresh == null)
					cb_doRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRefresh);
				return cb_doRefresh;
			}

			static void n_DoRefresh (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.RefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DoRefresh ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/method[@name='doRefresh' and count(parameter)=0]"
			[Register ("doRefresh", "()V", "GetDoRefreshHandler")]
			public virtual unsafe void DoRefresh ()
			{
				const string __id = "doRefresh.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_onPull_III;
#pragma warning disable 0169
			static Delegate GetOnPull_IIIHandler ()
			{
				if (cb_onPull_III == null)
					cb_onPull_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnPull_III);
				return cb_onPull_III;
			}

			static void n_OnPull_III (IntPtr jnienv, IntPtr native__this, int offset, int total, int overPull)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.RefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPull (offset, total, overPull);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/method[@name='onPull' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onPull", "(III)V", "GetOnPull_IIIHandler")]
			public virtual unsafe void OnPull (int offset, int total, int overPull)
			{
				const string __id = "onPull.(III)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (offset);
					__args [1] = new JniArgumentValue (total);
					__args [2] = new JniArgumentValue (overPull);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_setColorSchemeColors_arrayI;
#pragma warning disable 0169
			static Delegate GetSetColorSchemeColors_arrayIHandler ()
			{
				if (cb_setColorSchemeColors_arrayI == null)
					cb_setColorSchemeColors_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetColorSchemeColors_arrayI);
				return cb_setColorSchemeColors_arrayI;
			}

			static void n_SetColorSchemeColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.RefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
				__this.SetColorSchemeColors (colors);
				if (colors != null)
					JNIEnv.CopyArray (colors, native_colors);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/method[@name='setColorSchemeColors' and count(parameter)=1 and parameter[1][@type='int...']]"
			[Register ("setColorSchemeColors", "([I)V", "GetSetColorSchemeColors_arrayIHandler")]
			public virtual unsafe void SetColorSchemeColors (params int[] colors)
			{
				const string __id = "setColorSchemeColors.([I)V";
				IntPtr native_colors = JNIEnv.NewArray (colors);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_colors);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (colors != null) {
						JNIEnv.CopyArray (native_colors, colors);
						JNIEnv.DeleteLocalRef (native_colors);
					}
					global::System.GC.KeepAlive (colors);
				}
			}

			static Delegate cb_setColorSchemeResources_arrayI;
#pragma warning disable 0169
			static Delegate GetSetColorSchemeResources_arrayIHandler ()
			{
				if (cb_setColorSchemeResources_arrayI == null)
					cb_setColorSchemeResources_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetColorSchemeResources_arrayI);
				return cb_setColorSchemeResources_arrayI;
			}

			static void n_SetColorSchemeResources_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colorResIds)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.RefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var colorResIds = (int[]) JNIEnv.GetArray (native_colorResIds, JniHandleOwnership.DoNotTransfer, typeof (int));
				__this.SetColorSchemeResources (colorResIds);
				if (colorResIds != null)
					JNIEnv.CopyArray (colorResIds, native_colorResIds);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/method[@name='setColorSchemeResources' and count(parameter)=1 and parameter[1][@type='int...']]"
			[Register ("setColorSchemeResources", "([I)V", "GetSetColorSchemeResources_arrayIHandler")]
			public virtual unsafe void SetColorSchemeResources (params int[] colorResIds)
			{
				const string __id = "setColorSchemeResources.([I)V";
				IntPtr native_colorResIds = JNIEnv.NewArray (colorResIds);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_colorResIds);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (colorResIds != null) {
						JNIEnv.CopyArray (native_colorResIds, colorResIds);
						JNIEnv.DeleteLocalRef (native_colorResIds);
					}
					global::System.GC.KeepAlive (colorResIds);
				}
			}

			static Delegate cb_setSize_I;
#pragma warning disable 0169
			static Delegate GetSetSize_IHandler ()
			{
				if (cb_setSize_I == null)
					cb_setSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSize_I);
				return cb_setSize_I;
			}

			static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int size)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.RefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSize (size);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
			public virtual unsafe void SetSize (int size)
			{
				const string __id = "setSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (size);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_stop;
#pragma warning disable 0169
			static Delegate GetStopHandler ()
			{
				if (cb_stop == null)
					cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
				return cb_stop;
			}

			static void n_Stop (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.RefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Stop ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout.RefreshView']/method[@name='stop' and count(parameter)=0]"
			[Register ("stop", "()V", "GetStopHandler")]
			public virtual unsafe void Stop ()
			{
				const string __id = "stop.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout", typeof (QMUIPullRefreshLayout));
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

		protected QMUIPullRefreshLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/constructor[@name='QMUIPullRefreshLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIPullRefreshLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/constructor[@name='QMUIPullRefreshLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIPullRefreshLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/constructor[@name='QMUIPullRefreshLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIPullRefreshLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_isDragging;
#pragma warning disable 0169
		static Delegate GetIsDraggingHandler ()
		{
			if (cb_isDragging == null)
				cb_isDragging = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDragging);
			return cb_isDragging;
		}

		static bool n_IsDragging (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDragging;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDragging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='isDragging' and count(parameter)=0]"
			[Register ("isDragging", "()Z", "GetIsDraggingHandler")]
			get {
				const string __id = "isDragging.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshEndOffset;
#pragma warning disable 0169
		static Delegate GetGetRefreshEndOffsetHandler ()
		{
			if (cb_getRefreshEndOffset == null)
				cb_getRefreshEndOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRefreshEndOffset);
			return cb_getRefreshEndOffset;
		}

		static int n_GetRefreshEndOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RefreshEndOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int RefreshEndOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='getRefreshEndOffset' and count(parameter)=0]"
			[Register ("getRefreshEndOffset", "()I", "GetGetRefreshEndOffsetHandler")]
			get {
				const string __id = "getRefreshEndOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshInitOffset;
#pragma warning disable 0169
		static Delegate GetGetRefreshInitOffsetHandler ()
		{
			if (cb_getRefreshInitOffset == null)
				cb_getRefreshInitOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRefreshInitOffset);
			return cb_getRefreshInitOffset;
		}

		static int n_GetRefreshInitOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RefreshInitOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int RefreshInitOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='getRefreshInitOffset' and count(parameter)=0]"
			[Register ("getRefreshInitOffset", "()I", "GetGetRefreshInitOffsetHandler")]
			get {
				const string __id = "getRefreshInitOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScrollerFriction;
#pragma warning disable 0169
		static Delegate GetGetScrollerFrictionHandler ()
		{
			if (cb_getScrollerFriction == null)
				cb_getScrollerFriction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetScrollerFriction);
			return cb_getScrollerFriction;
		}

		static float n_GetScrollerFriction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollerFriction;
		}
#pragma warning restore 0169

		protected virtual unsafe float ScrollerFriction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='getScrollerFriction' and count(parameter)=0]"
			[Register ("getScrollerFriction", "()F", "GetGetScrollerFrictionHandler")]
			get {
				const string __id = "getScrollerFriction.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTargetInitOffset;
#pragma warning disable 0169
		static Delegate GetGetTargetInitOffsetHandler ()
		{
			if (cb_getTargetInitOffset == null)
				cb_getTargetInitOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTargetInitOffset);
			return cb_getTargetInitOffset;
		}

		static int n_GetTargetInitOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetInitOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int TargetInitOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='getTargetInitOffset' and count(parameter)=0]"
			[Register ("getTargetInitOffset", "()I", "GetGetTargetInitOffsetHandler")]
			get {
				const string __id = "getTargetInitOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTargetRefreshOffset;
#pragma warning disable 0169
		static Delegate GetGetTargetRefreshOffsetHandler ()
		{
			if (cb_getTargetRefreshOffset == null)
				cb_getTargetRefreshOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTargetRefreshOffset);
			return cb_getTargetRefreshOffset;
		}

		static int n_GetTargetRefreshOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetRefreshOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setTargetRefreshOffset_I;
#pragma warning disable 0169
		static Delegate GetSetTargetRefreshOffset_IHandler ()
		{
			if (cb_setTargetRefreshOffset_I == null)
				cb_setTargetRefreshOffset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTargetRefreshOffset_I);
			return cb_setTargetRefreshOffset_I;
		}

		static void n_SetTargetRefreshOffset_I (IntPtr jnienv, IntPtr native__this, int targetRefreshOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TargetRefreshOffset = targetRefreshOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int TargetRefreshOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='getTargetRefreshOffset' and count(parameter)=0]"
			[Register ("getTargetRefreshOffset", "()I", "GetGetTargetRefreshOffsetHandler")]
			get {
				const string __id = "getTargetRefreshOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setTargetRefreshOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTargetRefreshOffset", "(I)V", "GetSetTargetRefreshOffset_IHandler")]
			set {
				const string __id = "setTargetRefreshOffset.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetView;
#pragma warning disable 0169
		static Delegate GetGetTargetViewHandler ()
		{
			if (cb_getTargetView == null)
				cb_getTargetView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetView);
			return cb_getTargetView;
		}

		static IntPtr n_GetTargetView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View TargetView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='getTargetView' and count(parameter)=0]"
			[Register ("getTargetView", "()Landroid/view/View;", "GetGetTargetViewHandler")]
			get {
				const string __id = "getTargetView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calculateTargetOffset_IIIZ;
#pragma warning disable 0169
		static Delegate GetCalculateTargetOffset_IIIZHandler ()
		{
			if (cb_calculateTargetOffset_IIIZ == null)
				cb_calculateTargetOffset_IIIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIZ_I) n_CalculateTargetOffset_IIIZ);
			return cb_calculateTargetOffset_IIIZ;
		}

		static int n_CalculateTargetOffset_IIIZ (IntPtr jnienv, IntPtr native__this, int target, int targetInitOffset, int targetRefreshOffset, bool enableOverPull)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateTargetOffset (target, targetInitOffset, targetRefreshOffset, enableOverPull);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='calculateTargetOffset' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("calculateTargetOffset", "(IIIZ)I", "GetCalculateTargetOffset_IIIZHandler")]
		protected virtual unsafe int CalculateTargetOffset (int target, int targetInitOffset, int targetRefreshOffset, bool enableOverPull)
		{
			const string __id = "calculateTargetOffset.(IIIZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (target);
				__args [1] = new JniArgumentValue (targetInitOffset);
				__args [2] = new JniArgumentValue (targetRefreshOffset);
				__args [3] = new JniArgumentValue (enableOverPull);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canChildScrollUp;
#pragma warning disable 0169
		static Delegate GetCanChildScrollUpHandler ()
		{
			if (cb_canChildScrollUp == null)
				cb_canChildScrollUp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CanChildScrollUp);
			return cb_canChildScrollUp;
		}

		static bool n_CanChildScrollUp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanChildScrollUp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='canChildScrollUp' and count(parameter)=0]"
		[Register ("canChildScrollUp", "()Z", "GetCanChildScrollUpHandler")]
		public virtual unsafe bool CanChildScrollUp ()
		{
			const string __id = "canChildScrollUp.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createRefreshView;
#pragma warning disable 0169
		static Delegate GetCreateRefreshViewHandler ()
		{
			if (cb_createRefreshView == null)
				cb_createRefreshView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateRefreshView);
			return cb_createRefreshView;
		}

		static IntPtr n_CreateRefreshView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateRefreshView ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='createRefreshView' and count(parameter)=0]"
		[Register ("createRefreshView", "()Landroid/view/View;", "GetCreateRefreshViewHandler")]
		protected virtual unsafe global::Android.Views.View CreateRefreshView ()
		{
			const string __id = "createRefreshView.()Landroid/view/View;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='defaultCanScrollUp' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("defaultCanScrollUp", "(Landroid/view/View;)Z", "")]
		public static unsafe bool DefaultCanScrollUp (global::Android.Views.View view)
		{
			const string __id = "defaultCanScrollUp.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_finishRefresh;
#pragma warning disable 0169
		static Delegate GetFinishRefreshHandler ()
		{
			if (cb_finishRefresh == null)
				cb_finishRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FinishRefresh);
			return cb_finishRefresh;
		}

		static void n_FinishRefresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishRefresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='finishRefresh' and count(parameter)=0]"
		[Register ("finishRefresh", "()V", "GetFinishRefreshHandler")]
		public virtual unsafe void FinishRefresh ()
		{
			const string __id = "finishRefresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isYDrag_FF;
#pragma warning disable 0169
		static Delegate GetIsYDrag_FFHandler ()
		{
			if (cb_isYDrag_FF == null)
				cb_isYDrag_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_Z) n_IsYDrag_FF);
			return cb_isYDrag_FF;
		}

		static bool n_IsYDrag_FF (IntPtr jnienv, IntPtr native__this, float dx, float dy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsYDrag (dx, dy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='isYDrag' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("isYDrag", "(FF)Z", "GetIsYDrag_FFHandler")]
		protected virtual unsafe bool IsYDrag (float dx, float dy)
		{
			const string __id = "isYDrag.(FF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dx);
				__args [1] = new JniArgumentValue (dy);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onFinishPull_IIIIIII;
#pragma warning disable 0169
		static Delegate GetOnFinishPull_IIIIIIIHandler ()
		{
			if (cb_onFinishPull_IIIIIII == null)
				cb_onFinishPull_IIIIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIIIII_V) n_OnFinishPull_IIIIIII);
			return cb_onFinishPull_IIIIIII;
		}

		static void n_OnFinishPull_IIIIIII (IntPtr jnienv, IntPtr native__this, int vy, int refreshInitOffset, int refreshEndOffset, int refreshViewHeight, int targetCurrentOffset, int targetInitOffset, int targetRefreshOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinishPull (vy, refreshInitOffset, refreshEndOffset, refreshViewHeight, targetCurrentOffset, targetInitOffset, targetRefreshOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='onFinishPull' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("onFinishPull", "(IIIIIII)V", "GetOnFinishPull_IIIIIIIHandler")]
		protected virtual unsafe void OnFinishPull (int vy, int refreshInitOffset, int refreshEndOffset, int refreshViewHeight, int targetCurrentOffset, int targetInitOffset, int targetRefreshOffset)
		{
			const string __id = "onFinishPull.(IIIIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (vy);
				__args [1] = new JniArgumentValue (refreshInitOffset);
				__args [2] = new JniArgumentValue (refreshEndOffset);
				__args [3] = new JniArgumentValue (refreshViewHeight);
				__args [4] = new JniArgumentValue (targetCurrentOffset);
				__args [5] = new JniArgumentValue (targetInitOffset);
				__args [6] = new JniArgumentValue (targetRefreshOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZIIII_V) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, l, t, r, b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool changed, int l, int t, int r, int b)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (l);
				__args [2] = new JniArgumentValue (t);
				__args [3] = new JniArgumentValue (r);
				__args [4] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onMoveRefreshView_I;
#pragma warning disable 0169
		static Delegate GetOnMoveRefreshView_IHandler ()
		{
			if (cb_onMoveRefreshView_I == null)
				cb_onMoveRefreshView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnMoveRefreshView_I);
			return cb_onMoveRefreshView_I;
		}

		static void n_OnMoveRefreshView_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMoveRefreshView (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='onMoveRefreshView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMoveRefreshView", "(I)V", "GetOnMoveRefreshView_IHandler")]
		protected virtual unsafe void OnMoveRefreshView (int offset)
		{
			const string __id = "onMoveRefreshView.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onMoveTargetView_I;
#pragma warning disable 0169
		static Delegate GetOnMoveTargetView_IHandler ()
		{
			if (cb_onMoveTargetView_I == null)
				cb_onMoveTargetView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnMoveTargetView_I);
			return cb_onMoveTargetView_I;
		}

		static void n_OnMoveTargetView_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMoveTargetView (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='onMoveTargetView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMoveTargetView", "(I)V", "GetOnMoveTargetView_IHandler")]
		protected virtual unsafe void OnMoveTargetView (int offset)
		{
			const string __id = "onMoveTargetView.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRefresh;
#pragma warning disable 0169
		static Delegate GetOnRefreshHandler ()
		{
			if (cb_onRefresh == null)
				cb_onRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnRefresh);
			return cb_onRefresh;
		}

		static void n_OnRefresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRefresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='onRefresh' and count(parameter)=0]"
		[Register ("onRefresh", "()V", "GetOnRefreshHandler")]
		protected virtual unsafe void OnRefresh ()
		{
			const string __id = "onRefresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSureTargetView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnSureTargetView_Landroid_view_View_Handler ()
		{
			if (cb_onSureTargetView_Landroid_view_View_ == null)
				cb_onSureTargetView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSureTargetView_Landroid_view_View_);
			return cb_onSureTargetView_Landroid_view_View_;
		}

		static void n_OnSureTargetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_targetView, JniHandleOwnership.DoNotTransfer);
			__this.OnSureTargetView (targetView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='onSureTargetView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onSureTargetView", "(Landroid/view/View;)V", "GetOnSureTargetView_Landroid_view_View_Handler")]
		protected virtual unsafe void OnSureTargetView (global::Android.Views.View targetView)
		{
			const string __id = "onSureTargetView.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (targetView);
			}
		}

		static Delegate cb_openSafeDisallowInterceptTouchEvent;
#pragma warning disable 0169
		static Delegate GetOpenSafeDisallowInterceptTouchEventHandler ()
		{
			if (cb_openSafeDisallowInterceptTouchEvent == null)
				cb_openSafeDisallowInterceptTouchEvent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OpenSafeDisallowInterceptTouchEvent);
			return cb_openSafeDisallowInterceptTouchEvent;
		}

		static void n_OpenSafeDisallowInterceptTouchEvent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenSafeDisallowInterceptTouchEvent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='openSafeDisallowInterceptTouchEvent' and count(parameter)=0]"
		[Register ("openSafeDisallowInterceptTouchEvent", "()V", "GetOpenSafeDisallowInterceptTouchEventHandler")]
		public virtual unsafe void OpenSafeDisallowInterceptTouchEvent ()
		{
			const string __id = "openSafeDisallowInterceptTouchEvent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAutoScrollToRefreshMinOffset_I;
#pragma warning disable 0169
		static Delegate GetSetAutoScrollToRefreshMinOffset_IHandler ()
		{
			if (cb_setAutoScrollToRefreshMinOffset_I == null)
				cb_setAutoScrollToRefreshMinOffset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAutoScrollToRefreshMinOffset_I);
			return cb_setAutoScrollToRefreshMinOffset_I;
		}

		static void n_SetAutoScrollToRefreshMinOffset_I (IntPtr jnienv, IntPtr native__this, int autoScrollToRefreshMinOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAutoScrollToRefreshMinOffset (autoScrollToRefreshMinOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setAutoScrollToRefreshMinOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAutoScrollToRefreshMinOffset", "(I)V", "GetSetAutoScrollToRefreshMinOffset_IHandler")]
		public virtual unsafe void SetAutoScrollToRefreshMinOffset (int autoScrollToRefreshMinOffset)
		{
			const string __id = "setAutoScrollToRefreshMinOffset.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (autoScrollToRefreshMinOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_;
#pragma warning disable 0169
		static Delegate GetSetChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_Handler ()
		{
			if (cb_setChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_ == null)
				cb_setChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_);
			return cb_setChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_;
		}

		static void n_SetChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_childScrollUpCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var childScrollUpCallback = (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnChildScrollUpCallback)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnChildScrollUpCallback> (native_childScrollUpCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetChildScrollUpCallback (childScrollUpCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setChildScrollUpCallback' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.OnChildScrollUpCallback']]"
		[Register ("setChildScrollUpCallback", "(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnChildScrollUpCallback;)V", "GetSetChildScrollUpCallback_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnChildScrollUpCallback_Handler")]
		public virtual unsafe void SetChildScrollUpCallback (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnChildScrollUpCallback childScrollUpCallback)
		{
			const string __id = "setChildScrollUpCallback.(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnChildScrollUpCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((childScrollUpCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) childScrollUpCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (childScrollUpCallback);
			}
		}

		static Delegate cb_setDisableNestScrollImpl_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableNestScrollImpl_ZHandler ()
		{
			if (cb_setDisableNestScrollImpl_Z == null)
				cb_setDisableNestScrollImpl_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDisableNestScrollImpl_Z);
			return cb_setDisableNestScrollImpl_Z;
		}

		static void n_SetDisableNestScrollImpl_Z (IntPtr jnienv, IntPtr native__this, bool disableNestScrollImpl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisableNestScrollImpl (disableNestScrollImpl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setDisableNestScrollImpl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableNestScrollImpl", "(Z)V", "GetSetDisableNestScrollImpl_ZHandler")]
		public virtual unsafe void SetDisableNestScrollImpl (bool disableNestScrollImpl)
		{
			const string __id = "setDisableNestScrollImpl.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disableNestScrollImpl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDragRate_F;
#pragma warning disable 0169
		static Delegate GetSetDragRate_FHandler ()
		{
			if (cb_setDragRate_F == null)
				cb_setDragRate_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetDragRate_F);
			return cb_setDragRate_F;
		}

		static void n_SetDragRate_F (IntPtr jnienv, IntPtr native__this, float dragRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDragRate (dragRate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDragRate", "(F)V", "GetSetDragRate_FHandler")]
		public virtual unsafe void SetDragRate (float dragRate)
		{
			const string __id = "setDragRate.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dragRate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEnableOverPull_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableOverPull_ZHandler ()
		{
			if (cb_setEnableOverPull_Z == null)
				cb_setEnableOverPull_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnableOverPull_Z);
			return cb_setEnableOverPull_Z;
		}

		static void n_SetEnableOverPull_Z (IntPtr jnienv, IntPtr native__this, bool enableOverPull)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnableOverPull (enableOverPull);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setEnableOverPull' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableOverPull", "(Z)V", "GetSetEnableOverPull_ZHandler")]
		public virtual unsafe void SetEnableOverPull (bool enableOverPull)
		{
			const string __id = "setEnableOverPull.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableOverPull);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_Handler ()
		{
			if (cb_setOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_ == null)
				cb_setOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_);
			return cb_setOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_;
		}

		static void n_SetOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPullListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setOnPullListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.OnPullListener']]"
		[Register ("setOnPullListener", "(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnPullListener;)V", "GetSetOnPullListener_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_OnPullListener_Handler")]
		public virtual unsafe void SetOnPullListener (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener listener)
		{
			const string __id = "setOnPullListener.(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$OnPullListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_;
#pragma warning disable 0169
		static Delegate GetSetRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_Handler ()
		{
			if (cb_setRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_ == null)
				cb_setRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_);
			return cb_setRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_;
		}

		static void n_SetRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshOffsetCalculator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var refreshOffsetCalculator = (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshOffsetCalculator)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshOffsetCalculator> (native_refreshOffsetCalculator, JniHandleOwnership.DoNotTransfer);
			__this.SetRefreshOffsetCalculator (refreshOffsetCalculator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setRefreshOffsetCalculator' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.pullRefreshLayout.QMUIPullRefreshLayout.RefreshOffsetCalculator']]"
		[Register ("setRefreshOffsetCalculator", "(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$RefreshOffsetCalculator;)V", "GetSetRefreshOffsetCalculator_Lcom_qmuiteam_qmui_widget_pullRefreshLayout_QMUIPullRefreshLayout_RefreshOffsetCalculator_Handler")]
		public virtual unsafe void SetRefreshOffsetCalculator (global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IRefreshOffsetCalculator refreshOffsetCalculator)
		{
			const string __id = "setRefreshOffsetCalculator.(Lcom/qmuiteam/qmui/widget/pullRefreshLayout/QMUIPullRefreshLayout$RefreshOffsetCalculator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((refreshOffsetCalculator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refreshOffsetCalculator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (refreshOffsetCalculator);
			}
		}

		static Delegate cb_setTargetViewToTop_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetTargetViewToTop_Landroid_view_View_Handler ()
		{
			if (cb_setTargetViewToTop_Landroid_view_View_ == null)
				cb_setTargetViewToTop_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTargetViewToTop_Landroid_view_View_);
			return cb_setTargetViewToTop_Landroid_view_View_;
		}

		static void n_SetTargetViewToTop_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var targetView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_targetView, JniHandleOwnership.DoNotTransfer);
			__this.SetTargetViewToTop (targetView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setTargetViewToTop' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setTargetViewToTop", "(Landroid/view/View;)V", "GetSetTargetViewToTop_Landroid_view_View_Handler")]
		protected virtual unsafe void SetTargetViewToTop (global::Android.Views.View targetView)
		{
			const string __id = "setTargetViewToTop.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (targetView);
			}
		}

		static Delegate cb_setToRefreshDirectly;
#pragma warning disable 0169
		static Delegate GetSetToRefreshDirectlyHandler ()
		{
			if (cb_setToRefreshDirectly == null)
				cb_setToRefreshDirectly = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetToRefreshDirectly);
			return cb_setToRefreshDirectly;
		}

		static void n_SetToRefreshDirectly (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetToRefreshDirectly ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setToRefreshDirectly' and count(parameter)=0]"
		[Register ("setToRefreshDirectly", "()V", "GetSetToRefreshDirectlyHandler")]
		public virtual unsafe void SetToRefreshDirectly ()
		{
			const string __id = "setToRefreshDirectly.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setToRefreshDirectly_J;
#pragma warning disable 0169
		static Delegate GetSetToRefreshDirectly_JHandler ()
		{
			if (cb_setToRefreshDirectly_J == null)
				cb_setToRefreshDirectly_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetToRefreshDirectly_J);
			return cb_setToRefreshDirectly_J;
		}

		static void n_SetToRefreshDirectly_J (IntPtr jnienv, IntPtr native__this, long delay)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetToRefreshDirectly (delay);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setToRefreshDirectly' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setToRefreshDirectly", "(J)V", "GetSetToRefreshDirectly_JHandler")]
		public virtual unsafe void SetToRefreshDirectly (long delay)
		{
			const string __id = "setToRefreshDirectly.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delay);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setToRefreshDirectly_JZ;
#pragma warning disable 0169
		static Delegate GetSetToRefreshDirectly_JZHandler ()
		{
			if (cb_setToRefreshDirectly_JZ == null)
				cb_setToRefreshDirectly_JZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJZ_V) n_SetToRefreshDirectly_JZ);
			return cb_setToRefreshDirectly_JZ;
		}

		static void n_SetToRefreshDirectly_JZ (IntPtr jnienv, IntPtr native__this, long delay, bool animate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetToRefreshDirectly (delay, animate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='setToRefreshDirectly' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("setToRefreshDirectly", "(JZ)V", "GetSetToRefreshDirectly_JZHandler")]
		public virtual unsafe void SetToRefreshDirectly (long delay, bool animate)
		{
			const string __id = "setToRefreshDirectly.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (delay);
				__args [1] = new JniArgumentValue (animate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startDragging_FF;
#pragma warning disable 0169
		static Delegate GetStartDragging_FFHandler ()
		{
			if (cb_startDragging_FF == null)
				cb_startDragging_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_V) n_StartDragging_FF);
			return cb_startDragging_FF;
		}

		static void n_StartDragging_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDragging (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullRefreshLayout']/class[@name='QMUIPullRefreshLayout']/method[@name='startDragging' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("startDragging", "(FF)V", "GetStartDragging_FFHandler")]
		protected virtual unsafe void StartDragging (float x, float y)
		{
			const string __id = "startDragging.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.MoveRefreshViewEventArgs> MoveRefreshView {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor>(
						ref weak_implementor_SetOnPullListener,
						__CreateIOnPullListenerImplementor,
						SetOnPullListener,
						__h => __h.OnMoveRefreshViewHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor>(
						ref weak_implementor_SetOnPullListener,
						global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor.__IsEmpty,
						__v => SetOnPullListener (null),
						__h => __h.OnMoveRefreshViewHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.MoveTargetEventArgs> MoveTarget {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor>(
						ref weak_implementor_SetOnPullListener,
						__CreateIOnPullListenerImplementor,
						SetOnPullListener,
						__h => __h.OnMoveTargetHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor>(
						ref weak_implementor_SetOnPullListener,
						global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor.__IsEmpty,
						__v => SetOnPullListener (null),
						__h => __h.OnMoveTargetHandler -= value);
			}
		}

		public event EventHandler Refresh {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor>(
						ref weak_implementor_SetOnPullListener,
						__CreateIOnPullListenerImplementor,
						SetOnPullListener,
						__h => __h.OnRefreshHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListener, global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor>(
						ref weak_implementor_SetOnPullListener,
						global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor.__IsEmpty,
						__v => SetOnPullListener (null),
						__h => __h.OnRefreshHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPullListener;

		global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor __CreateIOnPullListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.PullRefreshLayout.QMUIPullRefreshLayout.IOnPullListenerImplementor (this);
		}
#endregion
	}
}
