using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout", DoNotGenerateAcw=true)]
	public partial class QMUIContinuousNestedScrollLayout : global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout, global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/field[@name='KEY_SCROLL_INFO_OFFSET']"
		[Register ("KEY_SCROLL_INFO_OFFSET")]
		public const string KeyScrollInfoOffset = (string) "@qmui_nested_scroll_layout_offset";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedScrollLayout.OnScrollListener']"
		[Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout$OnScrollListener", "", "Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout/IOnScrollListenerInvoker")]
		public partial interface IOnScrollListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedScrollLayout.OnScrollListener']/method[@name='onScroll' and count(parameter)=7 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedScrollLayout'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
			[Register ("onScroll", "(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout;IIIIII)V", "GetOnScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIIIHandler:Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout/IOnScrollListenerInvoker, QMUI.Droid")]
			void OnScroll (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int topCurrent, int topRange, int offsetCurrent, int offsetRange, int bottomCurrent, int bottomRange);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedScrollLayout.OnScrollListener']/method[@name='onScrollStateChange' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedScrollLayout'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("onScrollStateChange", "(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout;IZ)V", "GetOnScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZHandler:Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout/IOnScrollListenerInvoker, QMUI.Droid")]
			void OnScrollStateChange (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int newScrollState, bool fromTopBehavior);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout$OnScrollListener", DoNotGenerateAcw=true)]
		internal partial class IOnScrollListenerInvoker : global::Java.Lang.Object, IOnScrollListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout$OnScrollListener", typeof (IOnScrollListenerInvoker));

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

			public static IOnScrollListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScrollListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedScrollLayout.OnScrollListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScrollListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII;
#pragma warning disable 0169
			static Delegate GetOnScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIIIHandler ()
			{
				if (cb_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII == null)
					cb_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIIII_V) n_OnScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII);
				return cb_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII;
			}

			static void n_OnScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_scrollLayout, int topCurrent, int topRange, int offsetCurrent, int offsetRange, int bottomCurrent, int bottomRange)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scrollLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (native_scrollLayout, JniHandleOwnership.DoNotTransfer);
				__this.OnScroll (scrollLayout, topCurrent, topRange, offsetCurrent, offsetRange, bottomCurrent, bottomRange);
			}
#pragma warning restore 0169

			IntPtr id_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII;
			public unsafe void OnScroll (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int topCurrent, int topRange, int offsetCurrent, int offsetRange, int bottomCurrent, int bottomRange)
			{
				if (id_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII == IntPtr.Zero)
					id_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII = JNIEnv.GetMethodID (class_ref, "onScroll", "(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout;IIIIII)V");
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue ((scrollLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scrollLayout).Handle);
				__args [1] = new JValue (topCurrent);
				__args [2] = new JValue (topRange);
				__args [3] = new JValue (offsetCurrent);
				__args [4] = new JValue (offsetRange);
				__args [5] = new JValue (bottomCurrent);
				__args [6] = new JValue (bottomRange);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScroll_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IIIIII, __args);
			}

			static Delegate cb_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ;
#pragma warning disable 0169
			static Delegate GetOnScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZHandler ()
			{
				if (cb_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ == null)
					cb_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZ_V) n_OnScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ);
				return cb_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ;
			}

			static void n_OnScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_scrollLayout, int newScrollState, bool fromTopBehavior)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scrollLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (native_scrollLayout, JniHandleOwnership.DoNotTransfer);
				__this.OnScrollStateChange (scrollLayout, newScrollState, fromTopBehavior);
			}
#pragma warning restore 0169

			IntPtr id_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ;
			public unsafe void OnScrollStateChange (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int newScrollState, bool fromTopBehavior)
			{
				if (id_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ == IntPtr.Zero)
					id_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ = JNIEnv.GetMethodID (class_ref, "onScrollStateChange", "(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout;IZ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((scrollLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scrollLayout).Handle);
				__args [1] = new JValue (newScrollState);
				__args [2] = new JValue (fromTopBehavior);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollStateChange_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_IZ, __args);
			}

		}

		// event args for com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedScrollLayout.OnScrollListener.onScroll
		public partial class ScrollEventArgs : global::System.EventArgs {

			public ScrollEventArgs (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int topCurrent, int topRange, int offsetCurrent, int offsetRange, int bottomCurrent, int bottomRange)
			{
				this.scrollLayout = scrollLayout;
				this.topCurrent = topCurrent;
				this.topRange = topRange;
				this.offsetCurrent = offsetCurrent;
				this.offsetRange = offsetRange;
				this.bottomCurrent = bottomCurrent;
				this.bottomRange = bottomRange;
			}

			global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout;
			public global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout ScrollLayout {
				get { return scrollLayout; }
			}

			int topCurrent;
			public int TopCurrent {
				get { return topCurrent; }
			}

			int topRange;
			public int TopRange {
				get { return topRange; }
			}

			int offsetCurrent;
			public int OffsetCurrent {
				get { return offsetCurrent; }
			}

			int offsetRange;
			public int OffsetRange {
				get { return offsetRange; }
			}

			int bottomCurrent;
			public int BottomCurrent {
				get { return bottomCurrent; }
			}

			int bottomRange;
			public int BottomRange {
				get { return bottomRange; }
			}
		}

		// event args for com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedScrollLayout.OnScrollListener.onScrollStateChange
		public partial class ScrollStateChangeEventArgs : global::System.EventArgs {

			public ScrollStateChangeEventArgs (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int newScrollState, bool fromTopBehavior)
			{
				this.scrollLayout = scrollLayout;
				this.newScrollState = newScrollState;
				this.fromTopBehavior = fromTopBehavior;
			}

			global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout;
			public global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout ScrollLayout {
				get { return scrollLayout; }
			}

			int newScrollState;
			public int NewScrollState {
				get { return newScrollState; }
			}

			bool fromTopBehavior;
			public bool FromTopBehavior {
				get { return fromTopBehavior; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout_OnScrollListenerImplementor")]
		internal sealed partial class IOnScrollListenerImplementor : global::Java.Lang.Object, IOnScrollListener {

			object sender;

			public IOnScrollListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout_OnScrollListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ScrollEventArgs> OnScrollHandler;
#pragma warning restore 0649

			public void OnScroll (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int topCurrent, int topRange, int offsetCurrent, int offsetRange, int bottomCurrent, int bottomRange)
			{
				var __h = OnScrollHandler;
				if (__h != null)
					__h (sender, new ScrollEventArgs (scrollLayout, topCurrent, topRange, offsetCurrent, offsetRange, bottomCurrent, bottomRange));
			}
#pragma warning disable 0649
			public EventHandler<ScrollStateChangeEventArgs> OnScrollStateChangeHandler;
#pragma warning restore 0649

			public void OnScrollStateChange (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout scrollLayout, int newScrollState, bool fromTopBehavior)
			{
				var __h = OnScrollStateChangeHandler;
				if (__h != null)
					__h (sender, new ScrollStateChangeEventArgs (scrollLayout, newScrollState, fromTopBehavior));
			}

			internal static bool __IsEmpty (IOnScrollListenerImplementor value)
			{
				return value.OnScrollHandler == null && value.OnScrollStateChangeHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout", typeof (QMUIContinuousNestedScrollLayout));
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

		protected QMUIContinuousNestedScrollLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/constructor[@name='QMUIContinuousNestedScrollLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIContinuousNestedScrollLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/constructor[@name='QMUIContinuousNestedScrollLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIContinuousNestedScrollLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/constructor[@name='QMUIContinuousNestedScrollLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIContinuousNestedScrollLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getBottomAreaBehavior;
#pragma warning disable 0169
		static Delegate GetGetBottomAreaBehaviorHandler ()
		{
			if (cb_getBottomAreaBehavior == null)
				cb_getBottomAreaBehavior = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBottomAreaBehavior);
			return cb_getBottomAreaBehavior;
		}

		static IntPtr n_GetBottomAreaBehavior (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BottomAreaBehavior);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomAreaBehavior BottomAreaBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getBottomAreaBehavior' and count(parameter)=0]"
			[Register ("getBottomAreaBehavior", "()Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedBottomAreaBehavior;", "GetGetBottomAreaBehaviorHandler")]
			get {
				const string __id = "getBottomAreaBehavior.()Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedBottomAreaBehavior;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomAreaBehavior> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBottomView;
#pragma warning disable 0169
		static Delegate GetGetBottomViewHandler ()
		{
			if (cb_getBottomView == null)
				cb_getBottomView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBottomView);
			return cb_getBottomView;
		}

		static IntPtr n_GetBottomView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BottomView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView BottomView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getBottomView' and count(parameter)=0]"
			[Register ("getBottomView", "()Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedBottomView;", "GetGetBottomViewHandler")]
			get {
				const string __id = "getBottomView.()Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedBottomView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentScroll;
#pragma warning disable 0169
		static Delegate GetGetCurrentScrollHandler ()
		{
			if (cb_getCurrentScroll == null)
				cb_getCurrentScroll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentScroll);
			return cb_getCurrentScroll;
		}

		static int n_GetCurrentScroll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScroll;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentScroll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getCurrentScroll' and count(parameter)=0]"
			[Register ("getCurrentScroll", "()I", "GetGetCurrentScrollHandler")]
			get {
				const string __id = "getCurrentScroll.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentScrollPercent;
#pragma warning disable 0169
		static Delegate GetGetCurrentScrollPercentHandler ()
		{
			if (cb_getCurrentScrollPercent == null)
				cb_getCurrentScrollPercent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetCurrentScrollPercent);
			return cb_getCurrentScrollPercent;
		}

		static float n_GetCurrentScrollPercent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScrollPercent;
		}
#pragma warning restore 0169

		public virtual unsafe float CurrentScrollPercent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getCurrentScrollPercent' and count(parameter)=0]"
			[Register ("getCurrentScrollPercent", "()F", "GetGetCurrentScrollPercentHandler")]
			get {
				const string __id = "getCurrentScrollPercent.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isKeepBottomAreaStableWhenCheckLayout;
#pragma warning disable 0169
		static Delegate GetIsKeepBottomAreaStableWhenCheckLayoutHandler ()
		{
			if (cb_isKeepBottomAreaStableWhenCheckLayout == null)
				cb_isKeepBottomAreaStableWhenCheckLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsKeepBottomAreaStableWhenCheckLayout);
			return cb_isKeepBottomAreaStableWhenCheckLayout;
		}

		static bool n_IsKeepBottomAreaStableWhenCheckLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepBottomAreaStableWhenCheckLayout;
		}
#pragma warning restore 0169

		static Delegate cb_setKeepBottomAreaStableWhenCheckLayout_Z;
#pragma warning disable 0169
		static Delegate GetSetKeepBottomAreaStableWhenCheckLayout_ZHandler ()
		{
			if (cb_setKeepBottomAreaStableWhenCheckLayout_Z == null)
				cb_setKeepBottomAreaStableWhenCheckLayout_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetKeepBottomAreaStableWhenCheckLayout_Z);
			return cb_setKeepBottomAreaStableWhenCheckLayout_Z;
		}

		static void n_SetKeepBottomAreaStableWhenCheckLayout_Z (IntPtr jnienv, IntPtr native__this, bool keepBottomAreaStableWhenCheckLayout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KeepBottomAreaStableWhenCheckLayout = keepBottomAreaStableWhenCheckLayout;
		}
#pragma warning restore 0169

		public virtual unsafe bool KeepBottomAreaStableWhenCheckLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='isKeepBottomAreaStableWhenCheckLayout' and count(parameter)=0]"
			[Register ("isKeepBottomAreaStableWhenCheckLayout", "()Z", "GetIsKeepBottomAreaStableWhenCheckLayoutHandler")]
			get {
				const string __id = "isKeepBottomAreaStableWhenCheckLayout.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='setKeepBottomAreaStableWhenCheckLayout' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setKeepBottomAreaStableWhenCheckLayout", "(Z)V", "GetSetKeepBottomAreaStableWhenCheckLayout_ZHandler")]
			set {
				const string __id = "setKeepBottomAreaStableWhenCheckLayout.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOffsetCurrent;
#pragma warning disable 0169
		static Delegate GetGetOffsetCurrentHandler ()
		{
			if (cb_getOffsetCurrent == null)
				cb_getOffsetCurrent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOffsetCurrent);
			return cb_getOffsetCurrent;
		}

		static int n_GetOffsetCurrent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetCurrent;
		}
#pragma warning restore 0169

		public virtual unsafe int OffsetCurrent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getOffsetCurrent' and count(parameter)=0]"
			[Register ("getOffsetCurrent", "()I", "GetGetOffsetCurrentHandler")]
			get {
				const string __id = "getOffsetCurrent.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOffsetRange;
#pragma warning disable 0169
		static Delegate GetGetOffsetRangeHandler ()
		{
			if (cb_getOffsetRange == null)
				cb_getOffsetRange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOffsetRange);
			return cb_getOffsetRange;
		}

		static int n_GetOffsetRange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetRange;
		}
#pragma warning restore 0169

		public virtual unsafe int OffsetRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getOffsetRange' and count(parameter)=0]"
			[Register ("getOffsetRange", "()I", "GetGetOffsetRangeHandler")]
			get {
				const string __id = "getOffsetRange.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScrollRange;
#pragma warning disable 0169
		static Delegate GetGetScrollRangeHandler ()
		{
			if (cb_getScrollRange == null)
				cb_getScrollRange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScrollRange);
			return cb_getScrollRange;
		}

		static int n_GetScrollRange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollRange;
		}
#pragma warning restore 0169

		public virtual unsafe int ScrollRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getScrollRange' and count(parameter)=0]"
			[Register ("getScrollRange", "()I", "GetGetScrollRangeHandler")]
			get {
				const string __id = "getScrollRange.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTopAreaBehavior;
#pragma warning disable 0169
		static Delegate GetGetTopAreaBehaviorHandler ()
		{
			if (cb_getTopAreaBehavior == null)
				cb_getTopAreaBehavior = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTopAreaBehavior);
			return cb_getTopAreaBehavior;
		}

		static IntPtr n_GetTopAreaBehavior (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopAreaBehavior);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior TopAreaBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getTopAreaBehavior' and count(parameter)=0]"
			[Register ("getTopAreaBehavior", "()Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior;", "GetGetTopAreaBehaviorHandler")]
			get {
				const string __id = "getTopAreaBehavior.()Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTopView;
#pragma warning disable 0169
		static Delegate GetGetTopViewHandler ()
		{
			if (cb_getTopView == null)
				cb_getTopView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTopView);
			return cb_getTopView;
		}

		static IntPtr n_GetTopView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView TopView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='getTopView' and count(parameter)=0]"
			[Register ("getTopView", "()Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView;", "GetGetTopViewHandler")]
			get {
				const string __id = "getTopView.()Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_;
#pragma warning disable 0169
		static Delegate GetAddOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_Handler ()
		{
			if (cb_addOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_ == null)
				cb_addOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_);
			return cb_addOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_;
		}

		static void n_AddOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onScrollListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onScrollListener = (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener> (native_onScrollListener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnScrollListener (onScrollListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='addOnScrollListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedScrollLayout.OnScrollListener']]"
		[Register ("addOnScrollListener", "(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout$OnScrollListener;)V", "GetAddOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_Handler")]
		public virtual unsafe void AddOnScrollListener (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener onScrollListener)
		{
			const string __id = "addOnScrollListener.(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout$OnScrollListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onScrollListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onScrollListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onScrollListener);
			}
		}

		static Delegate cb_checkLayout;
#pragma warning disable 0169
		static Delegate GetCheckLayoutHandler ()
		{
			if (cb_checkLayout == null)
				cb_checkLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CheckLayout);
			return cb_checkLayout;
		}

		static void n_CheckLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='checkLayout' and count(parameter)=0]"
		[Register ("checkLayout", "()V", "GetCheckLayoutHandler")]
		public virtual unsafe void CheckLayout ()
		{
			const string __id = "checkLayout.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_createScrollBar_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreateScrollBar_Landroid_content_Context_Handler ()
		{
			if (cb_createScrollBar_Landroid_content_Context_ == null)
				cb_createScrollBar_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateScrollBar_Landroid_content_Context_);
			return cb_createScrollBar_Landroid_content_Context_;
		}

		static IntPtr n_CreateScrollBar_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateScrollBar (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='createScrollBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createScrollBar", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/nestedScroll/QMUIDraggableScrollBar;", "GetCreateScrollBar_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar CreateScrollBar (global::Android.Content.Context context)
		{
			const string __id = "createScrollBar.(Landroid/content/Context;)Lcom/qmuiteam/qmui/nestedScroll/QMUIDraggableScrollBar;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onDragEnd;
#pragma warning disable 0169
		static Delegate GetOnDragEndHandler ()
		{
			if (cb_onDragEnd == null)
				cb_onDragEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDragEnd);
			return cb_onDragEnd;
		}

		static void n_OnDragEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDragEnd ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onDragEnd' and count(parameter)=0]"
		[Register ("onDragEnd", "()V", "GetOnDragEndHandler")]
		public virtual unsafe void OnDragEnd ()
		{
			const string __id = "onDragEnd.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDragStarted;
#pragma warning disable 0169
		static Delegate GetOnDragStartedHandler ()
		{
			if (cb_onDragStarted == null)
				cb_onDragStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDragStarted);
			return cb_onDragStarted;
		}

		static void n_OnDragStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDragStarted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onDragStarted' and count(parameter)=0]"
		[Register ("onDragStarted", "()V", "GetOnDragStartedHandler")]
		public virtual unsafe void OnDragStarted ()
		{
			const string __id = "onDragStarted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDragToPercent_F;
#pragma warning disable 0169
		static Delegate GetOnDragToPercent_FHandler ()
		{
			if (cb_onDragToPercent_F == null)
				cb_onDragToPercent_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_OnDragToPercent_F);
			return cb_onDragToPercent_F;
		}

		static void n_OnDragToPercent_F (IntPtr jnienv, IntPtr native__this, float percent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDragToPercent (percent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onDragToPercent' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onDragToPercent", "(F)V", "GetOnDragToPercent_FHandler")]
		public virtual unsafe void OnDragToPercent (float percent)
		{
			const string __id = "onDragToPercent.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (percent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onTopAreaOffset_I;
#pragma warning disable 0169
		static Delegate GetOnTopAreaOffset_IHandler ()
		{
			if (cb_onTopAreaOffset_I == null)
				cb_onTopAreaOffset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTopAreaOffset_I);
			return cb_onTopAreaOffset_I;
		}

		static void n_OnTopAreaOffset_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTopAreaOffset (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onTopAreaOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTopAreaOffset", "(I)V", "GetOnTopAreaOffset_IHandler")]
		public virtual unsafe void OnTopAreaOffset (int offset)
		{
			const string __id = "onTopAreaOffset.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onTopBehaviorFlingOrScrollEnd;
#pragma warning disable 0169
		static Delegate GetOnTopBehaviorFlingOrScrollEndHandler ()
		{
			if (cb_onTopBehaviorFlingOrScrollEnd == null)
				cb_onTopBehaviorFlingOrScrollEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTopBehaviorFlingOrScrollEnd);
			return cb_onTopBehaviorFlingOrScrollEnd;
		}

		static void n_OnTopBehaviorFlingOrScrollEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTopBehaviorFlingOrScrollEnd ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onTopBehaviorFlingOrScrollEnd' and count(parameter)=0]"
		[Register ("onTopBehaviorFlingOrScrollEnd", "()V", "GetOnTopBehaviorFlingOrScrollEndHandler")]
		public virtual unsafe void OnTopBehaviorFlingOrScrollEnd ()
		{
			const string __id = "onTopBehaviorFlingOrScrollEnd.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onTopBehaviorFlingOrScrollStart;
#pragma warning disable 0169
		static Delegate GetOnTopBehaviorFlingOrScrollStartHandler ()
		{
			if (cb_onTopBehaviorFlingOrScrollStart == null)
				cb_onTopBehaviorFlingOrScrollStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTopBehaviorFlingOrScrollStart);
			return cb_onTopBehaviorFlingOrScrollStart;
		}

		static void n_OnTopBehaviorFlingOrScrollStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTopBehaviorFlingOrScrollStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onTopBehaviorFlingOrScrollStart' and count(parameter)=0]"
		[Register ("onTopBehaviorFlingOrScrollStart", "()V", "GetOnTopBehaviorFlingOrScrollStartHandler")]
		public virtual unsafe void OnTopBehaviorFlingOrScrollStart ()
		{
			const string __id = "onTopBehaviorFlingOrScrollStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onTopBehaviorTouchBegin;
#pragma warning disable 0169
		static Delegate GetOnTopBehaviorTouchBeginHandler ()
		{
			if (cb_onTopBehaviorTouchBegin == null)
				cb_onTopBehaviorTouchBegin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTopBehaviorTouchBegin);
			return cb_onTopBehaviorTouchBegin;
		}

		static void n_OnTopBehaviorTouchBegin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTopBehaviorTouchBegin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onTopBehaviorTouchBegin' and count(parameter)=0]"
		[Register ("onTopBehaviorTouchBegin", "()V", "GetOnTopBehaviorTouchBeginHandler")]
		public virtual unsafe void OnTopBehaviorTouchBegin ()
		{
			const string __id = "onTopBehaviorTouchBegin.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onTopBehaviorTouchEnd;
#pragma warning disable 0169
		static Delegate GetOnTopBehaviorTouchEndHandler ()
		{
			if (cb_onTopBehaviorTouchEnd == null)
				cb_onTopBehaviorTouchEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTopBehaviorTouchEnd);
			return cb_onTopBehaviorTouchEnd;
		}

		static void n_OnTopBehaviorTouchEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTopBehaviorTouchEnd ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='onTopBehaviorTouchEnd' and count(parameter)=0]"
		[Register ("onTopBehaviorTouchEnd", "()V", "GetOnTopBehaviorTouchEndHandler")]
		public virtual unsafe void OnTopBehaviorTouchEnd ()
		{
			const string __id = "onTopBehaviorTouchEnd.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_postCheckLayout;
#pragma warning disable 0169
		static Delegate GetPostCheckLayoutHandler ()
		{
			if (cb_postCheckLayout == null)
				cb_postCheckLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PostCheckLayout);
			return cb_postCheckLayout;
		}

		static void n_PostCheckLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostCheckLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='postCheckLayout' and count(parameter)=0]"
		[Register ("postCheckLayout", "()V", "GetPostCheckLayoutHandler")]
		public virtual unsafe void PostCheckLayout ()
		{
			const string __id = "postCheckLayout.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_Handler ()
		{
			if (cb_removeOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_ == null)
				cb_removeOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_);
			return cb_removeOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_;
		}

		static void n_RemoveOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onScrollListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onScrollListener = (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener> (native_onScrollListener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnScrollListener (onScrollListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='removeOnScrollListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedScrollLayout.OnScrollListener']]"
		[Register ("removeOnScrollListener", "(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout$OnScrollListener;)V", "GetRemoveOnScrollListener_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedScrollLayout_OnScrollListener_Handler")]
		public virtual unsafe void RemoveOnScrollListener (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener onScrollListener)
		{
			const string __id = "removeOnScrollListener.(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedScrollLayout$OnScrollListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onScrollListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onScrollListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onScrollListener);
			}
		}

		static Delegate cb_restoreScrollInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRestoreScrollInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_restoreScrollInfo_Landroid_os_Bundle_ == null)
				cb_restoreScrollInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RestoreScrollInfo_Landroid_os_Bundle_);
			return cb_restoreScrollInfo_Landroid_os_Bundle_;
		}

		static void n_RestoreScrollInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.RestoreScrollInfo (bundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='restoreScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("restoreScrollInfo", "(Landroid/os/Bundle;)V", "GetRestoreScrollInfo_Landroid_os_Bundle_Handler")]
		public virtual unsafe void RestoreScrollInfo (global::Android.OS.Bundle bundle)
		{
			const string __id = "restoreScrollInfo.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_saveScrollInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveScrollInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_saveScrollInfo_Landroid_os_Bundle_ == null)
				cb_saveScrollInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveScrollInfo_Landroid_os_Bundle_);
			return cb_saveScrollInfo_Landroid_os_Bundle_;
		}

		static void n_SaveScrollInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.SaveScrollInfo (bundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='saveScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveScrollInfo", "(Landroid/os/Bundle;)V", "GetSaveScrollInfo_Landroid_os_Bundle_Handler")]
		public virtual unsafe void SaveScrollInfo (global::Android.OS.Bundle bundle)
		{
			const string __id = "saveScrollInfo.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_scrollBottomViewToTop;
#pragma warning disable 0169
		static Delegate GetScrollBottomViewToTopHandler ()
		{
			if (cb_scrollBottomViewToTop == null)
				cb_scrollBottomViewToTop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ScrollBottomViewToTop);
			return cb_scrollBottomViewToTop;
		}

		static void n_ScrollBottomViewToTop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBottomViewToTop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='scrollBottomViewToTop' and count(parameter)=0]"
		[Register ("scrollBottomViewToTop", "()V", "GetScrollBottomViewToTopHandler")]
		public virtual unsafe void ScrollBottomViewToTop ()
		{
			const string __id = "scrollBottomViewToTop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_scrollBy_I;
#pragma warning disable 0169
		static Delegate GetScrollBy_IHandler ()
		{
			if (cb_scrollBy_I == null)
				cb_scrollBy_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ScrollBy_I);
			return cb_scrollBy_I;
		}

		static void n_ScrollBy_I (IntPtr jnienv, IntPtr native__this, int dy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (dy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='scrollBy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("scrollBy", "(I)V", "GetScrollBy_IHandler")]
		public virtual unsafe void ScrollBy (int dy)
		{
			const string __id = "scrollBy.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dy);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollToBottom;
#pragma warning disable 0169
		static Delegate GetScrollToBottomHandler ()
		{
			if (cb_scrollToBottom == null)
				cb_scrollToBottom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ScrollToBottom);
			return cb_scrollToBottom;
		}

		static void n_ScrollToBottom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollToBottom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='scrollToBottom' and count(parameter)=0]"
		[Register ("scrollToBottom", "()V", "GetScrollToBottomHandler")]
		public virtual unsafe void ScrollToBottom ()
		{
			const string __id = "scrollToBottom.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_scrollToTop;
#pragma warning disable 0169
		static Delegate GetScrollToTopHandler ()
		{
			if (cb_scrollToTop == null)
				cb_scrollToTop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ScrollToTop);
			return cb_scrollToTop;
		}

		static void n_ScrollToTop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollToTop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='scrollToTop' and count(parameter)=0]"
		[Register ("scrollToTop", "()V", "GetScrollToTopHandler")]
		public virtual unsafe void ScrollToTop ()
		{
			const string __id = "scrollToTop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_Handler ()
		{
			if (cb_setBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ == null)
				cb_setBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_);
			return cb_setBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_;
		}

		static void n_SetBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomView, IntPtr native_layoutParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bottomView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_bottomView, JniHandleOwnership.DoNotTransfer);
			var layoutParams = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.LayoutParams> (native_layoutParams, JniHandleOwnership.DoNotTransfer);
			__this.SetBottomAreaView (bottomView, layoutParams);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='setBottomAreaView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='androidx.coordinatorlayout.widget.CoordinatorLayout.LayoutParams']]"
		[Register ("setBottomAreaView", "(Landroid/view/View;Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V", "GetSetBottomAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_Handler")]
		public virtual unsafe void SetBottomAreaView (global::Android.Views.View bottomView, global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.LayoutParams layoutParams)
		{
			const string __id = "setBottomAreaView.(Landroid/view/View;Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bottomView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomView).Handle);
				__args [1] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bottomView);
				global::System.GC.KeepAlive (layoutParams);
			}
		}

		static Delegate cb_setDraggableScrollBarEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDraggableScrollBarEnabled_ZHandler ()
		{
			if (cb_setDraggableScrollBarEnabled_Z == null)
				cb_setDraggableScrollBarEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDraggableScrollBarEnabled_Z);
			return cb_setDraggableScrollBarEnabled_Z;
		}

		static void n_SetDraggableScrollBarEnabled_Z (IntPtr jnienv, IntPtr native__this, bool draggableScrollBarEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDraggableScrollBarEnabled (draggableScrollBarEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='setDraggableScrollBarEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDraggableScrollBarEnabled", "(Z)V", "GetSetDraggableScrollBarEnabled_ZHandler")]
		public virtual unsafe void SetDraggableScrollBarEnabled (bool draggableScrollBarEnabled)
		{
			const string __id = "setDraggableScrollBarEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (draggableScrollBarEnabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEnableScrollBarFadeInOut_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableScrollBarFadeInOut_ZHandler ()
		{
			if (cb_setEnableScrollBarFadeInOut_Z == null)
				cb_setEnableScrollBarFadeInOut_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnableScrollBarFadeInOut_Z);
			return cb_setEnableScrollBarFadeInOut_Z;
		}

		static void n_SetEnableScrollBarFadeInOut_Z (IntPtr jnienv, IntPtr native__this, bool enableScrollBarFadeInOut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnableScrollBarFadeInOut (enableScrollBarFadeInOut);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='setEnableScrollBarFadeInOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableScrollBarFadeInOut", "(Z)V", "GetSetEnableScrollBarFadeInOut_ZHandler")]
		public virtual unsafe void SetEnableScrollBarFadeInOut (bool enableScrollBarFadeInOut)
		{
			const string __id = "setEnableScrollBarFadeInOut.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableScrollBarFadeInOut);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_Handler ()
		{
			if (cb_setTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ == null)
				cb_setTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_);
			return cb_setTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_;
		}

		static void n_SetTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topView, IntPtr native_layoutParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var topView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_topView, JniHandleOwnership.DoNotTransfer);
			var layoutParams = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.LayoutParams> (native_layoutParams, JniHandleOwnership.DoNotTransfer);
			__this.SetTopAreaView (topView, layoutParams);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='setTopAreaView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='androidx.coordinatorlayout.widget.CoordinatorLayout.LayoutParams']]"
		[Register ("setTopAreaView", "(Landroid/view/View;Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V", "GetSetTopAreaView_Landroid_view_View_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_Handler")]
		public virtual unsafe void SetTopAreaView (global::Android.Views.View topView, global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.LayoutParams layoutParams)
		{
			const string __id = "setTopAreaView.(Landroid/view/View;Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((topView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) topView).Handle);
				__args [1] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (topView);
				global::System.GC.KeepAlive (layoutParams);
			}
		}

		static Delegate cb_smoothScrollBy_II;
#pragma warning disable 0169
		static Delegate GetSmoothScrollBy_IIHandler ()
		{
			if (cb_smoothScrollBy_II == null)
				cb_smoothScrollBy_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SmoothScrollBy_II);
			return cb_smoothScrollBy_II;
		}

		static void n_SmoothScrollBy_II (IntPtr jnienv, IntPtr native__this, int dy, int duration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollBy (dy, duration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='smoothScrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollBy", "(II)V", "GetSmoothScrollBy_IIHandler")]
		public virtual unsafe void SmoothScrollBy (int dy, int duration)
		{
			const string __id = "smoothScrollBy.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dy);
				__args [1] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopScroll;
#pragma warning disable 0169
		static Delegate GetStopScrollHandler ()
		{
			if (cb_stopScroll == null)
				cb_stopScroll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopScroll);
			return cb_stopScroll;
		}

		static void n_StopScroll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScroll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedScrollLayout']/method[@name='stopScroll' and count(parameter)=0]"
		[Register ("stopScroll", "()V", "GetStopScrollHandler")]
		public virtual unsafe void StopScroll ()
		{
			const string __id = "stopScroll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.ScrollEventArgs> Scroll {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener, global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor>(
						ref weak_implementor_AddOnScrollListener,
						__CreateIOnScrollListenerImplementor,
						AddOnScrollListener,
						__h => __h.OnScrollHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener, global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor>(
						ref weak_implementor_AddOnScrollListener,
						global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor.__IsEmpty,
						__v => RemoveOnScrollListener (__v),
						__h => __h.OnScrollHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.ScrollStateChangeEventArgs> ScrollStateChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener, global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor>(
						ref weak_implementor_AddOnScrollListener,
						__CreateIOnScrollListenerImplementor,
						AddOnScrollListener,
						__h => __h.OnScrollStateChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListener, global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor>(
						ref weak_implementor_AddOnScrollListener,
						global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor.__IsEmpty,
						__v => RemoveOnScrollListener (__v),
						__h => __h.OnScrollStateChangeHandler -= value);
			}
		}

		WeakReference weak_implementor_AddOnScrollListener;

		global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor __CreateIOnScrollListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedScrollLayout.IOnScrollListenerImplementor (this);
		}
#endregion
	}
}
