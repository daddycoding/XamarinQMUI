using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIObservableScrollView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIObservableScrollView", DoNotGenerateAcw=true)]
	public partial class QMUIObservableScrollView : global::Android.Widget.ScrollView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIObservableScrollView.OnScrollChangedListener']"
		[Register ("com/qmuiteam/qmui/widget/QMUIObservableScrollView$OnScrollChangedListener", "", "Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView/IOnScrollChangedListenerInvoker")]
		public partial interface IOnScrollChangedListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIObservableScrollView.OnScrollChangedListener']/method[@name='onScrollChanged' and count(parameter)=5 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIObservableScrollView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("onScrollChanged", "(Lcom/qmuiteam/qmui/widget/QMUIObservableScrollView;IIII)V", "GetOnScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIIIHandler:Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView/IOnScrollChangedListenerInvoker, QMUI.Droid")]
			void OnScrollChanged (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView scrollView, int l, int t, int oldl, int oldt);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIObservableScrollView$OnScrollChangedListener", DoNotGenerateAcw=true)]
		internal partial class IOnScrollChangedListenerInvoker : global::Java.Lang.Object, IOnScrollChangedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIObservableScrollView$OnScrollChangedListener", typeof (IOnScrollChangedListenerInvoker));

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

			public static IOnScrollChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScrollChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUIObservableScrollView.OnScrollChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScrollChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII;
#pragma warning disable 0169
			static Delegate GetOnScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIIIHandler ()
			{
				if (cb_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII == null)
					cb_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIII_V) n_OnScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII);
				return cb_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII;
			}

			static void n_OnScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_scrollView, int l, int t, int oldl, int oldt)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var scrollView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView> (native_scrollView, JniHandleOwnership.DoNotTransfer);
				__this.OnScrollChanged (scrollView, l, t, oldl, oldt);
			}
#pragma warning restore 0169

			IntPtr id_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII;
			public unsafe void OnScrollChanged (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView scrollView, int l, int t, int oldl, int oldt)
			{
				if (id_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII == IntPtr.Zero)
					id_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII = JNIEnv.GetMethodID (class_ref, "onScrollChanged", "(Lcom/qmuiteam/qmui/widget/QMUIObservableScrollView;IIII)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue ((scrollView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scrollView).Handle);
				__args [1] = new JValue (l);
				__args [2] = new JValue (t);
				__args [3] = new JValue (oldl);
				__args [4] = new JValue (oldt);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollChanged_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_IIII, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.QMUIObservableScrollView.OnScrollChangedListener.onScrollChanged
		public partial class ScrollChangedEventArgs : global::System.EventArgs {

			public ScrollChangedEventArgs (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView scrollView, int l, int t, int oldl, int oldt)
			{
				this.scrollView = scrollView;
				this.l = l;
				this.t = t;
				this.oldl = oldl;
				this.oldt = oldt;
			}

			global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView scrollView;
			public global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView ScrollView {
				get { return scrollView; }
			}

			int l;
			public int L {
				get { return l; }
			}

			int t;
			public int T {
				get { return t; }
			}

			int oldl;
			public int Oldl {
				get { return oldl; }
			}

			int oldt;
			public int Oldt {
				get { return oldt; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/QMUIObservableScrollView_OnScrollChangedListenerImplementor")]
		internal sealed partial class IOnScrollChangedListenerImplementor : global::Java.Lang.Object, IOnScrollChangedListener {

			object sender;

			public IOnScrollChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/QMUIObservableScrollView_OnScrollChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ScrollChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnScrollChanged (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView scrollView, int l, int t, int oldl, int oldt)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ScrollChangedEventArgs (scrollView, l, t, oldl, oldt));
			}

			internal static bool __IsEmpty (IOnScrollChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIObservableScrollView", typeof (QMUIObservableScrollView));
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

		protected QMUIObservableScrollView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIObservableScrollView']/constructor[@name='QMUIObservableScrollView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIObservableScrollView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIObservableScrollView']/constructor[@name='QMUIObservableScrollView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIObservableScrollView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIObservableScrollView']/constructor[@name='QMUIObservableScrollView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIObservableScrollView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getScrollOffset;
#pragma warning disable 0169
		static Delegate GetGetScrollOffsetHandler ()
		{
			if (cb_getScrollOffset == null)
				cb_getScrollOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScrollOffset);
			return cb_getScrollOffset;
		}

		static int n_GetScrollOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int ScrollOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIObservableScrollView']/method[@name='getScrollOffset' and count(parameter)=0]"
			[Register ("getScrollOffset", "()I", "GetGetScrollOffsetHandler")]
			get {
				const string __id = "getScrollOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_Handler ()
		{
			if (cb_addOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_ == null)
				cb_addOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_);
			return cb_addOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_;
		}

		static void n_AddOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onScrollChangedListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onScrollChangedListener = (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener> (native_onScrollChangedListener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnScrollChangedListener (onScrollChangedListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIObservableScrollView']/method[@name='addOnScrollChangedListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIObservableScrollView.OnScrollChangedListener']]"
		[Register ("addOnScrollChangedListener", "(Lcom/qmuiteam/qmui/widget/QMUIObservableScrollView$OnScrollChangedListener;)V", "GetAddOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_Handler")]
		public virtual unsafe void AddOnScrollChangedListener (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener onScrollChangedListener)
		{
			const string __id = "addOnScrollChangedListener.(Lcom/qmuiteam/qmui/widget/QMUIObservableScrollView$OnScrollChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onScrollChangedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onScrollChangedListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onScrollChangedListener);
			}
		}

		static Delegate cb_removeOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_Handler ()
		{
			if (cb_removeOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_ == null)
				cb_removeOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_);
			return cb_removeOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_;
		}

		static void n_RemoveOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onScrollChangedListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onScrollChangedListener = (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener> (native_onScrollChangedListener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnScrollChangedListener (onScrollChangedListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIObservableScrollView']/method[@name='removeOnScrollChangedListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIObservableScrollView.OnScrollChangedListener']]"
		[Register ("removeOnScrollChangedListener", "(Lcom/qmuiteam/qmui/widget/QMUIObservableScrollView$OnScrollChangedListener;)V", "GetRemoveOnScrollChangedListener_Lcom_qmuiteam_qmui_widget_QMUIObservableScrollView_OnScrollChangedListener_Handler")]
		public virtual unsafe void RemoveOnScrollChangedListener (global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener onScrollChangedListener)
		{
			const string __id = "removeOnScrollChangedListener.(Lcom/qmuiteam/qmui/widget/QMUIObservableScrollView$OnScrollChangedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onScrollChangedListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onScrollChangedListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onScrollChangedListener);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.ScrollChangedEventArgs> ScrollChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener, global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListenerImplementor>(
						ref weak_implementor_AddOnScrollChangedListener,
						__CreateIOnScrollChangedListenerImplementor,
						AddOnScrollChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListener, global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListenerImplementor>(
						ref weak_implementor_AddOnScrollChangedListener,
						global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListenerImplementor.__IsEmpty,
						__v => RemoveOnScrollChangedListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnScrollChangedListener;

		global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListenerImplementor __CreateIOnScrollChangedListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.QMUIObservableScrollView.IOnScrollChangedListenerImplementor (this);
		}
#endregion
	}
}
