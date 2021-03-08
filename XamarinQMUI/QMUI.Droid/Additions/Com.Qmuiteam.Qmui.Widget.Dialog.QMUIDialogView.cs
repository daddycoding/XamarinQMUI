using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogView", DoNotGenerateAcw=true)]
	public partial class QMUIDialogView : global::Com.Qmuiteam.Qmui.Layout.QMUIConstraintLayout {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogView.OnDecorationListener']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogView$OnDecorationListener", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView/IOnDecorationListenerInvoker")]
		public partial interface IOnDecorationListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogView.OnDecorationListener']/method[@name='onDraw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView']]"
			[Register ("onDraw", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;)V", "GetOnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView/IOnDecorationListenerInvoker, QMUI.Droid")]
			void OnDraw (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogView.OnDecorationListener']/method[@name='onDrawOver' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView']]"
			[Register ("onDrawOver", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;)V", "GetOnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView/IOnDecorationListenerInvoker, QMUI.Droid")]
			void OnDrawOver (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogView$OnDecorationListener", DoNotGenerateAcw=true)]
		internal partial class IOnDecorationListenerInvoker : global::Java.Lang.Object, IOnDecorationListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogView$OnDecorationListener", typeof (IOnDecorationListenerInvoker));

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

			public static IOnDecorationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDecorationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIDialogView.OnDecorationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDecorationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
#pragma warning disable 0169
			static Delegate GetOnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Handler ()
			{
				if (cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ == null)
					cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_);
				return cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
			}

			static void n_OnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDraw (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
			public unsafe void OnDraw (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1)
			{
				if (id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ == IntPtr.Zero)
					id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_, __args);
			}

			static Delegate cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
#pragma warning disable 0169
			static Delegate GetOnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Handler ()
			{
				if (cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ == null)
					cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_);
				return cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
			}

			static void n_OnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDrawOver (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
			public unsafe void OnDrawOver (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1)
			{
				if (id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ == IntPtr.Zero)
					id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ = JNIEnv.GetMethodID (class_ref, "onDrawOver", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.dialog.QMUIDialogView.OnDecorationListener.onDraw
		public partial class DrawEventArgs : global::System.EventArgs {

			public DrawEventArgs (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Graphics.Canvas p0;
			public global::Android.Graphics.Canvas P0 {
				get { return p0; }
			}

			global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1;
			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView P1 {
				get { return p1; }
			}
		}

		// event args for com.qmuiteam.qmui.widget.dialog.QMUIDialogView.OnDecorationListener.onDrawOver
		public partial class DrawOverEventArgs : global::System.EventArgs {

			public DrawOverEventArgs (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Graphics.Canvas p0;
			public global::Android.Graphics.Canvas P0 {
				get { return p0; }
			}

			global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1;
			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/dialog/QMUIDialogView_OnDecorationListenerImplementor")]
		internal sealed partial class IOnDecorationListenerImplementor : global::Java.Lang.Object, IOnDecorationListener {

			object sender;

			public IOnDecorationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/dialog/QMUIDialogView_OnDecorationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DrawEventArgs> OnDrawHandler;
#pragma warning restore 0649

			public void OnDraw (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1)
			{
				var __h = OnDrawHandler;
				if (__h != null)
					__h (sender, new DrawEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<DrawOverEventArgs> OnDrawOverHandler;
#pragma warning restore 0649

			public void OnDrawOver (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1)
			{
				var __h = OnDrawOverHandler;
				if (__h != null)
					__h (sender, new DrawOverEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnDecorationListenerImplementor value)
			{
				return value.OnDrawHandler == null && value.OnDrawOverHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogView", typeof (QMUIDialogView));
		internal static new IntPtr class_ref {
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

		protected QMUIDialogView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogView']/constructor[@name='QMUIDialogView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIDialogView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogView']/constructor[@name='QMUIDialogView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIDialogView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogView']/constructor[@name='QMUIDialogView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIDialogView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_Handler ()
		{
			if (cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_ == null)
				cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_);
			return cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_;
		}

		static void n_SetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onDecorationListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onDecorationListener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener> (native_onDecorationListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDecorationListener (onDecorationListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogView']/method[@name='setOnDecorationListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView.OnDecorationListener']]"
		[Register ("setOnDecorationListener", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView$OnDecorationListener;)V", "GetSetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_Handler")]
		public virtual unsafe void SetOnDecorationListener (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener onDecorationListener)
		{
			const string __id = "setOnDecorationListener.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView$OnDecorationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onDecorationListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onDecorationListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onDecorationListener);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.DrawEventArgs> Draw {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor>(
						ref weak_implementor_SetOnDecorationListener,
						__CreateIOnDecorationListenerImplementor,
						SetOnDecorationListener,
						__h => __h.OnDrawHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor>(
						ref weak_implementor_SetOnDecorationListener,
						global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor.__IsEmpty,
						__v => SetOnDecorationListener (null),
						__h => __h.OnDrawHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.DrawOverEventArgs> DrawOver {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor>(
						ref weak_implementor_SetOnDecorationListener,
						__CreateIOnDecorationListenerImplementor,
						SetOnDecorationListener,
						__h => __h.OnDrawOverHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor>(
						ref weak_implementor_SetOnDecorationListener,
						global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor.__IsEmpty,
						__v => SetOnDecorationListener (null),
						__h => __h.OnDrawOverHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDecorationListener;

		global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor __CreateIOnDecorationListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListenerImplementor (this);
		}
#endregion
	}
}
