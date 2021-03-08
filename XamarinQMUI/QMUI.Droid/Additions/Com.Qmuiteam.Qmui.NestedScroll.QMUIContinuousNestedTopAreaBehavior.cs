using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopAreaBehavior']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior", DoNotGenerateAcw=true)]
	public partial class QMUIContinuousNestedTopAreaBehavior : global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedTopAreaBehavior.Callback']"
		[Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior$Callback", "", "Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedTopAreaBehavior.Callback']/method[@name='onTopAreaOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTopAreaOffset", "(I)V", "GetOnTopAreaOffset_IHandler:Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior/ICallbackInvoker, QMUI.Droid")]
			void OnTopAreaOffset (int offset);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedTopAreaBehavior.Callback']/method[@name='onTopBehaviorFlingOrScrollEnd' and count(parameter)=0]"
			[Register ("onTopBehaviorFlingOrScrollEnd", "()V", "GetOnTopBehaviorFlingOrScrollEndHandler:Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior/ICallbackInvoker, QMUI.Droid")]
			void OnTopBehaviorFlingOrScrollEnd ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedTopAreaBehavior.Callback']/method[@name='onTopBehaviorFlingOrScrollStart' and count(parameter)=0]"
			[Register ("onTopBehaviorFlingOrScrollStart", "()V", "GetOnTopBehaviorFlingOrScrollStartHandler:Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior/ICallbackInvoker, QMUI.Droid")]
			void OnTopBehaviorFlingOrScrollStart ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedTopAreaBehavior.Callback']/method[@name='onTopBehaviorTouchBegin' and count(parameter)=0]"
			[Register ("onTopBehaviorTouchBegin", "()V", "GetOnTopBehaviorTouchBeginHandler:Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior/ICallbackInvoker, QMUI.Droid")]
			void OnTopBehaviorTouchBegin ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='QMUIContinuousNestedTopAreaBehavior.Callback']/method[@name='onTopBehaviorTouchEnd' and count(parameter)=0]"
			[Register ("onTopBehaviorTouchEnd", "()V", "GetOnTopBehaviorTouchEndHandler:Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior/ICallbackInvoker, QMUI.Droid")]
			void OnTopBehaviorTouchEnd ();

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior$Callback", typeof (ICallbackInvoker));

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

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedTopAreaBehavior.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTopAreaOffset (offset);
			}
#pragma warning restore 0169

			IntPtr id_onTopAreaOffset_I;
			public unsafe void OnTopAreaOffset (int offset)
			{
				if (id_onTopAreaOffset_I == IntPtr.Zero)
					id_onTopAreaOffset_I = JNIEnv.GetMethodID (class_ref, "onTopAreaOffset", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (offset);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTopAreaOffset_I, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTopBehaviorFlingOrScrollEnd ();
			}
#pragma warning restore 0169

			IntPtr id_onTopBehaviorFlingOrScrollEnd;
			public unsafe void OnTopBehaviorFlingOrScrollEnd ()
			{
				if (id_onTopBehaviorFlingOrScrollEnd == IntPtr.Zero)
					id_onTopBehaviorFlingOrScrollEnd = JNIEnv.GetMethodID (class_ref, "onTopBehaviorFlingOrScrollEnd", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTopBehaviorFlingOrScrollEnd);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTopBehaviorFlingOrScrollStart ();
			}
#pragma warning restore 0169

			IntPtr id_onTopBehaviorFlingOrScrollStart;
			public unsafe void OnTopBehaviorFlingOrScrollStart ()
			{
				if (id_onTopBehaviorFlingOrScrollStart == IntPtr.Zero)
					id_onTopBehaviorFlingOrScrollStart = JNIEnv.GetMethodID (class_ref, "onTopBehaviorFlingOrScrollStart", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTopBehaviorFlingOrScrollStart);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTopBehaviorTouchBegin ();
			}
#pragma warning restore 0169

			IntPtr id_onTopBehaviorTouchBegin;
			public unsafe void OnTopBehaviorTouchBegin ()
			{
				if (id_onTopBehaviorTouchBegin == IntPtr.Zero)
					id_onTopBehaviorTouchBegin = JNIEnv.GetMethodID (class_ref, "onTopBehaviorTouchBegin", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTopBehaviorTouchBegin);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTopBehaviorTouchEnd ();
			}
#pragma warning restore 0169

			IntPtr id_onTopBehaviorTouchEnd;
			public unsafe void OnTopBehaviorTouchEnd ()
			{
				if (id_onTopBehaviorTouchEnd == IntPtr.Zero)
					id_onTopBehaviorTouchEnd = JNIEnv.GetMethodID (class_ref, "onTopBehaviorTouchEnd", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTopBehaviorTouchEnd);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior", typeof (QMUIContinuousNestedTopAreaBehavior));
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

		protected QMUIContinuousNestedTopAreaBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopAreaBehavior']/constructor[@name='QMUIContinuousNestedTopAreaBehavior' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIContinuousNestedTopAreaBehavior (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopAreaBehavior']/constructor[@name='QMUIContinuousNestedTopAreaBehavior' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIContinuousNestedTopAreaBehavior (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		static Delegate cb_setCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_Handler ()
		{
			if (cb_setCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_ == null)
				cb_setCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_);
			return cb_setCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_;
		}

		static void n_SetCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopAreaBehavior']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.QMUIContinuousNestedTopAreaBehavior.Callback']]"
		[Register ("setCallback", "(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior$Callback;)V", "GetSetCallback_Lcom_qmuiteam_qmui_nestedScroll_QMUIContinuousNestedTopAreaBehavior_Callback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopAreaBehavior.ICallback @callback)
		{
			const string __id = "setCallback.(Lcom/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopAreaBehavior$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
