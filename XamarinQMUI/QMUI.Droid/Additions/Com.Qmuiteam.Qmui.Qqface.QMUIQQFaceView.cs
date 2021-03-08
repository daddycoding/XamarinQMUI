using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Qqface {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceView", DoNotGenerateAcw=true)]
	public partial class QMUIQQFaceView : global::Android.Views.View {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView.PressCancelAction']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceView$PressCancelAction", DoNotGenerateAcw=true)]
		public partial class PressCancelAction : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUIQQFaceView$PressCancelAction", typeof (PressCancelAction));
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

			protected PressCancelAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView.PressCancelAction']/constructor[@name='QMUIQQFaceView.PressCancelAction' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe PressCancelAction (global::Java.Lang.Object spanInfo)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((spanInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spanInfo).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (spanInfo);
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.PressCancelAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView.PressCancelAction']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='QMUIQQFaceView.QQFaceViewListener']"
		[Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceView$QQFaceViewListener", "", "Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView/IQQFaceViewListenerInvoker")]
		public partial interface IQQFaceViewListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='QMUIQQFaceView.QQFaceViewListener']/method[@name='onCalculateLinesChange' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onCalculateLinesChange", "(I)V", "GetOnCalculateLinesChange_IHandler:Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView/IQQFaceViewListenerInvoker, QMUI.Droid")]
			void OnCalculateLinesChange (int lines);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='QMUIQQFaceView.QQFaceViewListener']/method[@name='onMoreTextClick' and count(parameter)=0]"
			[Register ("onMoreTextClick", "()V", "GetOnMoreTextClickHandler:Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView/IQQFaceViewListenerInvoker, QMUI.Droid")]
			void OnMoreTextClick ();

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUIQQFaceView$QQFaceViewListener", DoNotGenerateAcw=true)]
		internal partial class IQQFaceViewListenerInvoker : global::Java.Lang.Object, IQQFaceViewListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUIQQFaceView$QQFaceViewListener", typeof (IQQFaceViewListenerInvoker));

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

			public static IQQFaceViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQQFaceViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.qqface.QMUIQQFaceView.QQFaceViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQQFaceViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCalculateLinesChange_I;
#pragma warning disable 0169
			static Delegate GetOnCalculateLinesChange_IHandler ()
			{
				if (cb_onCalculateLinesChange_I == null)
					cb_onCalculateLinesChange_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnCalculateLinesChange_I);
				return cb_onCalculateLinesChange_I;
			}

			static void n_OnCalculateLinesChange_I (IntPtr jnienv, IntPtr native__this, int lines)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCalculateLinesChange (lines);
			}
#pragma warning restore 0169

			IntPtr id_onCalculateLinesChange_I;
			public unsafe void OnCalculateLinesChange (int lines)
			{
				if (id_onCalculateLinesChange_I == IntPtr.Zero)
					id_onCalculateLinesChange_I = JNIEnv.GetMethodID (class_ref, "onCalculateLinesChange", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lines);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCalculateLinesChange_I, __args);
			}

			static Delegate cb_onMoreTextClick;
#pragma warning disable 0169
			static Delegate GetOnMoreTextClickHandler ()
			{
				if (cb_onMoreTextClick == null)
					cb_onMoreTextClick = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnMoreTextClick);
				return cb_onMoreTextClick;
			}

			static void n_OnMoreTextClick (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMoreTextClick ();
			}
#pragma warning restore 0169

			IntPtr id_onMoreTextClick;
			public unsafe void OnMoreTextClick ()
			{
				if (id_onMoreTextClick == IntPtr.Zero)
					id_onMoreTextClick = JNIEnv.GetMethodID (class_ref, "onMoreTextClick", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMoreTextClick);
			}

		}

		// event args for com.qmuiteam.qmui.qqface.QMUIQQFaceView.QQFaceViewListener.onCalculateLinesChange
		public partial class CalculateLinesChangeEventArgs : global::System.EventArgs {

			public CalculateLinesChangeEventArgs (int lines)
			{
				this.lines = lines;
			}

			int lines;
			public int Lines {
				get { return lines; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/qqface/QMUIQQFaceView_QQFaceViewListenerImplementor")]
		internal sealed partial class IQQFaceViewListenerImplementor : global::Java.Lang.Object, IQQFaceViewListener {

			object sender;

			public IQQFaceViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/qqface/QMUIQQFaceView_QQFaceViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CalculateLinesChangeEventArgs> OnCalculateLinesChangeHandler;
#pragma warning restore 0649

			public void OnCalculateLinesChange (int lines)
			{
				var __h = OnCalculateLinesChangeHandler;
				if (__h != null)
					__h (sender, new CalculateLinesChangeEventArgs (lines));
			}
#pragma warning disable 0649
			public EventHandler OnMoreTextClickHandler;
#pragma warning restore 0649

			public void OnMoreTextClick ()
			{
				var __h = OnMoreTextClickHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IQQFaceViewListenerImplementor value)
			{
				return value.OnCalculateLinesChangeHandler == null && value.OnMoreTextClickHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUIQQFaceView", typeof (QMUIQQFaceView));
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

		protected QMUIQQFaceView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/constructor[@name='QMUIQQFaceView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIQQFaceView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/constructor[@name='QMUIQQFaceView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIQQFaceView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/constructor[@name='QMUIQQFaceView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIQQFaceView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getFontHeight;
#pragma warning disable 0169
		static Delegate GetGetFontHeightHandler ()
		{
			if (cb_getFontHeight == null)
				cb_getFontHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFontHeight);
			return cb_getFontHeight;
		}

		static int n_GetFontHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FontHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int FontHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getFontHeight' and count(parameter)=0]"
			[Register ("getFontHeight", "()I", "GetGetFontHeightHandler")]
			get {
				const string __id = "getFontHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getGravity;
#pragma warning disable 0169
		static Delegate GetGetGravityHandler ()
		{
			if (cb_getGravity == null)
				cb_getGravity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetGravity);
			return cb_getGravity;
		}

		static int n_GetGravity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Gravity;
		}
#pragma warning restore 0169

		static Delegate cb_setGravity_I;
#pragma warning disable 0169
		static Delegate GetSetGravity_IHandler ()
		{
			if (cb_setGravity_I == null)
				cb_setGravity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetGravity_I);
			return cb_setGravity_I;
		}

		static void n_SetGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Gravity = gravity;
		}
#pragma warning restore 0169

		public virtual unsafe int Gravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getGravity' and count(parameter)=0]"
			[Register ("getGravity", "()I", "GetGetGravityHandler")]
			get {
				const string __id = "getGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGravity", "(I)V", "GetSetGravity_IHandler")]
			set {
				const string __id = "setGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNeedEllipsize;
#pragma warning disable 0169
		static Delegate GetIsNeedEllipsizeHandler ()
		{
			if (cb_isNeedEllipsize == null)
				cb_isNeedEllipsize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNeedEllipsize);
			return cb_isNeedEllipsize;
		}

		static bool n_IsNeedEllipsize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedEllipsize;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedEllipsize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='isNeedEllipsize' and count(parameter)=0]"
			[Register ("isNeedEllipsize", "()Z", "GetIsNeedEllipsizeHandler")]
			get {
				const string __id = "isNeedEllipsize.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLineCount;
#pragma warning disable 0169
		static Delegate GetGetLineCountHandler ()
		{
			if (cb_getLineCount == null)
				cb_getLineCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLineCount);
			return cb_getLineCount;
		}

		static int n_GetLineCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineCount;
		}
#pragma warning restore 0169

		public virtual unsafe int LineCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getLineCount' and count(parameter)=0]"
			[Register ("getLineCount", "()I", "GetGetLineCountHandler")]
			get {
				const string __id = "getLineCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLineSpace;
#pragma warning disable 0169
		static Delegate GetGetLineSpaceHandler ()
		{
			if (cb_getLineSpace == null)
				cb_getLineSpace = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLineSpace);
			return cb_getLineSpace;
		}

		static int n_GetLineSpace (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setLineSpace_I;
#pragma warning disable 0169
		static Delegate GetSetLineSpace_IHandler ()
		{
			if (cb_setLineSpace_I == null)
				cb_setLineSpace_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLineSpace_I);
			return cb_setLineSpace_I;
		}

		static void n_SetLineSpace_I (IntPtr jnienv, IntPtr native__this, int lineSpace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineSpace = lineSpace;
		}
#pragma warning restore 0169

		public virtual unsafe int LineSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getLineSpace' and count(parameter)=0]"
			[Register ("getLineSpace", "()I", "GetGetLineSpaceHandler")]
			get {
				const string __id = "getLineSpace.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setLineSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLineSpace", "(I)V", "GetSetLineSpace_IHandler")]
			set {
				const string __id = "setLineSpace.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxLine;
#pragma warning disable 0169
		static Delegate GetGetMaxLineHandler ()
		{
			if (cb_getMaxLine == null)
				cb_getMaxLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxLine);
			return cb_getMaxLine;
		}

		static int n_GetMaxLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLine;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxLine_I;
#pragma warning disable 0169
		static Delegate GetSetMaxLine_IHandler ()
		{
			if (cb_setMaxLine_I == null)
				cb_setMaxLine_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxLine_I);
			return cb_setMaxLine_I;
		}

		static void n_SetMaxLine_I (IntPtr jnienv, IntPtr native__this, int maxLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxLine = maxLine;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getMaxLine' and count(parameter)=0]"
			[Register ("getMaxLine", "()I", "GetGetMaxLineHandler")]
			get {
				const string __id = "getMaxLine.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setMaxLine' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxLine", "(I)V", "GetSetMaxLine_IHandler")]
			set {
				const string __id = "setMaxLine.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxWidth;
#pragma warning disable 0169
		static Delegate GetGetMaxWidthHandler ()
		{
			if (cb_getMaxWidth == null)
				cb_getMaxWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxWidth);
			return cb_getMaxWidth;
		}

		static int n_GetMaxWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxWidth_I;
#pragma warning disable 0169
		static Delegate GetSetMaxWidth_IHandler ()
		{
			if (cb_setMaxWidth_I == null)
				cb_setMaxWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxWidth_I);
			return cb_setMaxWidth_I;
		}

		static void n_SetMaxWidth_I (IntPtr jnienv, IntPtr native__this, int maxWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxWidth = maxWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getMaxWidth' and count(parameter)=0]"
			[Register ("getMaxWidth", "()I", "GetGetMaxWidthHandler")]
			get {
				const string __id = "getMaxWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setMaxWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxWidth", "(I)V", "GetSetMaxWidth_IHandler")]
			set {
				const string __id = "setMaxWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMoreHitRect;
#pragma warning disable 0169
		static Delegate GetGetMoreHitRectHandler ()
		{
			if (cb_getMoreHitRect == null)
				cb_getMoreHitRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMoreHitRect);
			return cb_getMoreHitRect;
		}

		static IntPtr n_GetMoreHitRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoreHitRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Rect MoreHitRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getMoreHitRect' and count(parameter)=0]"
			[Register ("getMoreHitRect", "()Landroid/graphics/Rect;", "GetGetMoreHitRectHandler")]
			get {
				const string __id = "getMoreHitRect.()Landroid/graphics/Rect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaint;
#pragma warning disable 0169
		static Delegate GetGetPaintHandler ()
		{
			if (cb_getPaint == null)
				cb_getPaint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaint);
			return cb_getPaint;
		}

		static IntPtr n_GetPaint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Paint);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Text.TextPaint Paint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getPaint' and count(parameter)=0]"
			[Register ("getPaint", "()Landroid/text/TextPaint;", "GetGetPaintHandler")]
			get {
				const string __id = "getPaint.()Landroid/text/TextPaint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Text.TextPaint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TextFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setText_Ljava_lang_CharSequence_ == null)
				cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetText_Ljava_lang_CharSequence_);
			return cb_setText_Ljava_lang_CharSequence_;
		}

		static void n_SetText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_charSequence)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var charSequence = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_charSequence, JniHandleOwnership.DoNotTransfer);
			__this.TextFormatted = charSequence;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence TextFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setText", "(Ljava/lang/CharSequence;)V", "GetSetText_Ljava_lang_CharSequence_Handler")]
			set {
				const string __id = "setText.(Ljava/lang/CharSequence;)V";
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public string Text {
			get { return TextFormatted == null ? null : TextFormatted.ToString (); }
			set {
				var jls = value == null ? null : new global::Java.Lang.String (value);
				TextFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTextSize);
			return cb_getTextSize;
		}

		static int n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setTextSize_I;
#pragma warning disable 0169
		static Delegate GetSetTextSize_IHandler ()
		{
			if (cb_setTextSize_I == null)
				cb_setTextSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTextSize_I);
			return cb_setTextSize_I;
		}

		static void n_SetTextSize_I (IntPtr jnienv, IntPtr native__this, int textSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSize = textSize;
		}
#pragma warning restore 0169

		public virtual unsafe int TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()I", "GetGetTextSizeHandler")]
			get {
				const string __id = "getTextSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextSize", "(I)V", "GetSetTextSize_IHandler")]
			set {
				const string __id = "setTextSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_calculateFontHeight;
#pragma warning disable 0169
		static Delegate GetCalculateFontHeightHandler ()
		{
			if (cb_calculateFontHeight == null)
				cb_calculateFontHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_CalculateFontHeight);
			return cb_calculateFontHeight;
		}

		static int n_CalculateFontHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateFontHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='calculateFontHeight' and count(parameter)=0]"
		[Register ("calculateFontHeight", "()I", "GetCalculateFontHeightHandler")]
		protected virtual unsafe int CalculateFontHeight ()
		{
			const string __id = "calculateFontHeight.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_calculateLinesAndContentWidth_I;
#pragma warning disable 0169
		static Delegate GetCalculateLinesAndContentWidth_IHandler ()
		{
			if (cb_calculateLinesAndContentWidth_I == null)
				cb_calculateLinesAndContentWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_CalculateLinesAndContentWidth_I);
			return cb_calculateLinesAndContentWidth_I;
		}

		static int n_CalculateLinesAndContentWidth_I (IntPtr jnienv, IntPtr native__this, int limitWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateLinesAndContentWidth (limitWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='calculateLinesAndContentWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("calculateLinesAndContentWidth", "(I)I", "GetCalculateLinesAndContentWidth_IHandler")]
		protected virtual unsafe int CalculateLinesAndContentWidth (int limitWidth)
		{
			const string __id = "calculateLinesAndContentWidth.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limitWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_Z;
#pragma warning disable 0169
		static Delegate GetGetFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_ZHandler ()
		{
			if (cb_getFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_Z == null)
				cb_getFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_I) n_GetFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_Z);
			return cb_getFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_Z;
		}

		static int n_GetFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fontMetricsInt, bool includePad)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fontMetricsInt = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.FontMetricsInt> (native_fontMetricsInt, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetFontHeightCalBottom (fontMetricsInt, includePad);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getFontHeightCalBottom' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint.FontMetricsInt'] and parameter[2][@type='boolean']]"
		[Register ("getFontHeightCalBottom", "(Landroid/graphics/Paint$FontMetricsInt;Z)I", "GetGetFontHeightCalBottom_Landroid_graphics_Paint_FontMetricsInt_ZHandler")]
		protected virtual unsafe int GetFontHeightCalBottom (global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt, bool includePad)
		{
			const string __id = "getFontHeightCalBottom.(Landroid/graphics/Paint$FontMetricsInt;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fontMetricsInt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fontMetricsInt).Handle);
				__args [1] = new JniArgumentValue (includePad);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (fontMetricsInt);
			}
		}

		static Delegate cb_getFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_Z;
#pragma warning disable 0169
		static Delegate GetGetFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_ZHandler ()
		{
			if (cb_getFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_Z == null)
				cb_getFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_I) n_GetFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_Z);
			return cb_getFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_Z;
		}

		static int n_GetFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fontMetricsInt, bool includePad)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fontMetricsInt = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.FontMetricsInt> (native_fontMetricsInt, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetFontHeightCalTop (fontMetricsInt, includePad);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='getFontHeightCalTop' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint.FontMetricsInt'] and parameter[2][@type='boolean']]"
		[Register ("getFontHeightCalTop", "(Landroid/graphics/Paint$FontMetricsInt;Z)I", "GetGetFontHeightCalTop_Landroid_graphics_Paint_FontMetricsInt_ZHandler")]
		protected virtual unsafe int GetFontHeightCalTop (global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt, bool includePad)
		{
			const string __id = "getFontHeightCalTop.(Landroid/graphics/Paint$FontMetricsInt;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fontMetricsInt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fontMetricsInt).Handle);
				__args [1] = new JniArgumentValue (includePad);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (fontMetricsInt);
			}
		}

		static Delegate cb_setCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_;
#pragma warning disable 0169
		static Delegate GetSetCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Handler ()
		{
			if (cb_setCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_ == null)
				cb_setCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_);
			return cb_setCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_;
		}

		static void n_SetCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_compiler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var compiler = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler> (native_compiler, JniHandleOwnership.DoNotTransfer);
			__this.SetCompiler (compiler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setCompiler' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.qqface.QMUIQQFaceCompiler']]"
		[Register ("setCompiler", "(Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;)V", "GetSetCompiler_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceCompiler_Handler")]
		public virtual unsafe void SetCompiler (global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceCompiler compiler)
		{
			const string __id = "setCompiler.(Lcom/qmuiteam/qmui/qqface/QMUIQQFaceCompiler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((compiler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compiler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (compiler);
			}
		}

		static Delegate cb_setEllipsize_Landroid_text_TextUtils_TruncateAt_;
#pragma warning disable 0169
		static Delegate GetSetEllipsize_Landroid_text_TextUtils_TruncateAt_Handler ()
		{
			if (cb_setEllipsize_Landroid_text_TextUtils_TruncateAt_ == null)
				cb_setEllipsize_Landroid_text_TextUtils_TruncateAt_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEllipsize_Landroid_text_TextUtils_TruncateAt_);
			return cb_setEllipsize_Landroid_text_TextUtils_TruncateAt_;
		}

		static void n_SetEllipsize_Landroid_text_TextUtils_TruncateAt_ (IntPtr jnienv, IntPtr native__this, IntPtr native__where)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @where = global::Java.Lang.Object.GetObject<global::Android.Text.TextUtils.TruncateAt> (native__where, JniHandleOwnership.DoNotTransfer);
			__this.SetEllipsize (@where);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setEllipsize' and count(parameter)=1 and parameter[1][@type='android.text.TextUtils.TruncateAt']]"
		[Register ("setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", "GetSetEllipsize_Landroid_text_TextUtils_TruncateAt_Handler")]
		public virtual unsafe void SetEllipsize (global::Android.Text.TextUtils.TruncateAt @where)
		{
			const string __id = "setEllipsize.(Landroid/text/TextUtils$TruncateAt;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@where == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @where).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@where);
			}
		}

		static Delegate cb_setIncludeFontPadding_Z;
#pragma warning disable 0169
		static Delegate GetSetIncludeFontPadding_ZHandler ()
		{
			if (cb_setIncludeFontPadding_Z == null)
				cb_setIncludeFontPadding_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetIncludeFontPadding_Z);
			return cb_setIncludeFontPadding_Z;
		}

		static void n_SetIncludeFontPadding_Z (IntPtr jnienv, IntPtr native__this, bool includePad)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIncludeFontPadding (includePad);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setIncludeFontPadding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIncludeFontPadding", "(Z)V", "GetSetIncludeFontPadding_ZHandler")]
		public virtual unsafe void SetIncludeFontPadding (bool includePad)
		{
			const string __id = "setIncludeFontPadding.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (includePad);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLinkUnderLineColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetLinkUnderLineColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setLinkUnderLineColor_Landroid_content_res_ColorStateList_ == null)
				cb_setLinkUnderLineColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLinkUnderLineColor_Landroid_content_res_ColorStateList_);
			return cb_setLinkUnderLineColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetLinkUnderLineColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_linkUnderLineColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var linkUnderLineColor = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_linkUnderLineColor, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkUnderLineColor (linkUnderLineColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setLinkUnderLineColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setLinkUnderLineColor", "(Landroid/content/res/ColorStateList;)V", "GetSetLinkUnderLineColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetLinkUnderLineColor (global::Android.Content.Res.ColorStateList linkUnderLineColor)
		{
			const string __id = "setLinkUnderLineColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((linkUnderLineColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) linkUnderLineColor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (linkUnderLineColor);
			}
		}

		static Delegate cb_setLinkUnderLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetLinkUnderLineColor_IHandler ()
		{
			if (cb_setLinkUnderLineColor_I == null)
				cb_setLinkUnderLineColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLinkUnderLineColor_I);
			return cb_setLinkUnderLineColor_I;
		}

		static void n_SetLinkUnderLineColor_I (IntPtr jnienv, IntPtr native__this, int linkUnderLineColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkUnderLineColor (linkUnderLineColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setLinkUnderLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLinkUnderLineColor", "(I)V", "GetSetLinkUnderLineColor_IHandler")]
		public virtual unsafe void SetLinkUnderLineColor (int linkUnderLineColor)
		{
			const string __id = "setLinkUnderLineColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (linkUnderLineColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLinkUnderLineHeight_I;
#pragma warning disable 0169
		static Delegate GetSetLinkUnderLineHeight_IHandler ()
		{
			if (cb_setLinkUnderLineHeight_I == null)
				cb_setLinkUnderLineHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLinkUnderLineHeight_I);
			return cb_setLinkUnderLineHeight_I;
		}

		static void n_SetLinkUnderLineHeight_I (IntPtr jnienv, IntPtr native__this, int linkUnderLineHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkUnderLineHeight (linkUnderLineHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setLinkUnderLineHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLinkUnderLineHeight", "(I)V", "GetSetLinkUnderLineHeight_IHandler")]
		public virtual unsafe void SetLinkUnderLineHeight (int linkUnderLineHeight)
		{
			const string __id = "setLinkUnderLineHeight.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (linkUnderLineHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_Handler ()
		{
			if (cb_setListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_ == null)
				cb_setListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_);
			return cb_setListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_;
		}

		static void n_SetListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.qqface.QMUIQQFaceView.QQFaceViewListener']]"
		[Register ("setListener", "(Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView$QQFaceViewListener;)V", "GetSetListener_Lcom_qmuiteam_qmui_qqface_QMUIQQFaceView_QQFaceViewListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListener listener)
		{
			const string __id = "setListener.(Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView$QQFaceViewListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setMoreActionBgColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetMoreActionBgColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setMoreActionBgColor_Landroid_content_res_ColorStateList_ == null)
				cb_setMoreActionBgColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMoreActionBgColor_Landroid_content_res_ColorStateList_);
			return cb_setMoreActionBgColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetMoreActionBgColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var color = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_color, JniHandleOwnership.DoNotTransfer);
			__this.SetMoreActionBgColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setMoreActionBgColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setMoreActionBgColor", "(Landroid/content/res/ColorStateList;)V", "GetSetMoreActionBgColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetMoreActionBgColor (global::Android.Content.Res.ColorStateList color)
		{
			const string __id = "setMoreActionBgColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((color == null) ? IntPtr.Zero : ((global::Java.Lang.Object) color).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (color);
			}
		}

		static Delegate cb_setMoreActionBgColor_I;
#pragma warning disable 0169
		static Delegate GetSetMoreActionBgColor_IHandler ()
		{
			if (cb_setMoreActionBgColor_I == null)
				cb_setMoreActionBgColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMoreActionBgColor_I);
			return cb_setMoreActionBgColor_I;
		}

		static void n_SetMoreActionBgColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMoreActionBgColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setMoreActionBgColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMoreActionBgColor", "(I)V", "GetSetMoreActionBgColor_IHandler")]
		public virtual unsafe void SetMoreActionBgColor (int color)
		{
			const string __id = "setMoreActionBgColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMoreActionColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetMoreActionColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setMoreActionColor_Landroid_content_res_ColorStateList_ == null)
				cb_setMoreActionColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMoreActionColor_Landroid_content_res_ColorStateList_);
			return cb_setMoreActionColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetMoreActionColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var color = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_color, JniHandleOwnership.DoNotTransfer);
			__this.SetMoreActionColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setMoreActionColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setMoreActionColor", "(Landroid/content/res/ColorStateList;)V", "GetSetMoreActionColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetMoreActionColor (global::Android.Content.Res.ColorStateList color)
		{
			const string __id = "setMoreActionColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((color == null) ? IntPtr.Zero : ((global::Java.Lang.Object) color).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (color);
			}
		}

		static Delegate cb_setMoreActionColor_I;
#pragma warning disable 0169
		static Delegate GetSetMoreActionColor_IHandler ()
		{
			if (cb_setMoreActionColor_I == null)
				cb_setMoreActionColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMoreActionColor_I);
			return cb_setMoreActionColor_I;
		}

		static void n_SetMoreActionColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMoreActionColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setMoreActionColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMoreActionColor", "(I)V", "GetSetMoreActionColor_IHandler")]
		public virtual unsafe void SetMoreActionColor (int color)
		{
			const string __id = "setMoreActionColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMoreActionText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMoreActionText_Ljava_lang_String_Handler ()
		{
			if (cb_setMoreActionText_Ljava_lang_String_ == null)
				cb_setMoreActionText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMoreActionText_Ljava_lang_String_);
			return cb_setMoreActionText_Ljava_lang_String_;
		}

		static void n_SetMoreActionText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_moreActionText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var moreActionText = JNIEnv.GetString (native_moreActionText, JniHandleOwnership.DoNotTransfer);
			__this.SetMoreActionText (moreActionText);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setMoreActionText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMoreActionText", "(Ljava/lang/String;)V", "GetSetMoreActionText_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMoreActionText (string moreActionText)
		{
			const string __id = "setMoreActionText.(Ljava/lang/String;)V";
			IntPtr native_moreActionText = JNIEnv.NewString (moreActionText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_moreActionText);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_moreActionText);
			}
		}

		static Delegate cb_setNeedUnderlineForMoreText_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedUnderlineForMoreText_ZHandler ()
		{
			if (cb_setNeedUnderlineForMoreText_Z == null)
				cb_setNeedUnderlineForMoreText_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNeedUnderlineForMoreText_Z);
			return cb_setNeedUnderlineForMoreText_Z;
		}

		static void n_SetNeedUnderlineForMoreText_Z (IntPtr jnienv, IntPtr native__this, bool needUnderlineForMoreText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNeedUnderlineForMoreText (needUnderlineForMoreText);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setNeedUnderlineForMoreText' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedUnderlineForMoreText", "(Z)V", "GetSetNeedUnderlineForMoreText_ZHandler")]
		public virtual unsafe void SetNeedUnderlineForMoreText (bool needUnderlineForMoreText)
		{
			const string __id = "setNeedUnderlineForMoreText.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (needUnderlineForMoreText);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOpenQQFace_Z;
#pragma warning disable 0169
		static Delegate GetSetOpenQQFace_ZHandler ()
		{
			if (cb_setOpenQQFace_Z == null)
				cb_setOpenQQFace_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOpenQQFace_Z);
			return cb_setOpenQQFace_Z;
		}

		static void n_SetOpenQQFace_Z (IntPtr jnienv, IntPtr native__this, bool openQQFace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOpenQQFace (openQQFace);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setOpenQQFace' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOpenQQFace", "(Z)V", "GetSetOpenQQFace_ZHandler")]
		public virtual unsafe void SetOpenQQFace (bool openQQFace)
		{
			const string __id = "setOpenQQFace.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (openQQFace);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setParagraphSpace_I;
#pragma warning disable 0169
		static Delegate GetSetParagraphSpace_IHandler ()
		{
			if (cb_setParagraphSpace_I == null)
				cb_setParagraphSpace_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetParagraphSpace_I);
			return cb_setParagraphSpace_I;
		}

		static void n_SetParagraphSpace_I (IntPtr jnienv, IntPtr native__this, int paragraphSpace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParagraphSpace (paragraphSpace);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setParagraphSpace' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setParagraphSpace", "(I)V", "GetSetParagraphSpace_IHandler")]
		public virtual unsafe void SetParagraphSpace (int paragraphSpace)
		{
			const string __id = "setParagraphSpace.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (paragraphSpace);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setQQFaceSizeAddon_I;
#pragma warning disable 0169
		static Delegate GetSetQQFaceSizeAddon_IHandler ()
		{
			if (cb_setQQFaceSizeAddon_I == null)
				cb_setQQFaceSizeAddon_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetQQFaceSizeAddon_I);
			return cb_setQQFaceSizeAddon_I;
		}

		static void n_SetQQFaceSizeAddon_I (IntPtr jnienv, IntPtr native__this, int QQFaceSizeAddon)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQQFaceSizeAddon (QQFaceSizeAddon);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setQQFaceSizeAddon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setQQFaceSizeAddon", "(I)V", "GetSetQQFaceSizeAddon_IHandler")]
		public virtual unsafe void SetQQFaceSizeAddon (int QQFaceSizeAddon)
		{
			const string __id = "setQQFaceSizeAddon.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (QQFaceSizeAddon);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSingleLine_Z;
#pragma warning disable 0169
		static Delegate GetSetSingleLine_ZHandler ()
		{
			if (cb_setSingleLine_Z == null)
				cb_setSingleLine_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSingleLine_Z);
			return cb_setSingleLine_Z;
		}

		static void n_SetSingleLine_Z (IntPtr jnienv, IntPtr native__this, bool singleLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSingleLine (singleLine);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setSingleLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSingleLine", "(Z)V", "GetSetSingleLine_ZHandler")]
		public virtual unsafe void SetSingleLine (bool singleLine)
		{
			const string __id = "setSingleLine.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (singleLine);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSpecialDrawablePadding_I;
#pragma warning disable 0169
		static Delegate GetSetSpecialDrawablePadding_IHandler ()
		{
			if (cb_setSpecialDrawablePadding_I == null)
				cb_setSpecialDrawablePadding_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSpecialDrawablePadding_I);
			return cb_setSpecialDrawablePadding_I;
		}

		static void n_SetSpecialDrawablePadding_I (IntPtr jnienv, IntPtr native__this, int specialDrawablePadding)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSpecialDrawablePadding (specialDrawablePadding);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setSpecialDrawablePadding' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSpecialDrawablePadding", "(I)V", "GetSetSpecialDrawablePadding_IHandler")]
		public virtual unsafe void SetSpecialDrawablePadding (int specialDrawablePadding)
		{
			const string __id = "setSpecialDrawablePadding.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (specialDrawablePadding);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTextColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetTextColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setTextColor_Landroid_content_res_ColorStateList_ == null)
				cb_setTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTextColor_Landroid_content_res_ColorStateList_);
			return cb_setTextColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetTextColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var textColor = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_textColor, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (textColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetTextColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetTextColor (global::Android.Content.Res.ColorStateList textColor)
		{
			const string __id = "setTextColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((textColor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textColor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (textColor);
			}
		}

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int textColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (textColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
		public virtual unsafe void SetTextColor (int textColor)
		{
			const string __id = "setTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_ == null)
				cb_setTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTypeface_Landroid_graphics_Typeface_);
			return cb_setTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
			__this.SetTypeface (typeface);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe void SetTypeface (global::Android.Graphics.Typeface typeface)
		{
			const string __id = "setTypeface.(Landroid/graphics/Typeface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (typeface);
			}
		}

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_I;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_IHandler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_I == null)
				cb_setTypeface_Landroid_graphics_Typeface_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetTypeface_Landroid_graphics_Typeface_I);
			return cb_setTypeface_Landroid_graphics_Typeface_I;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_tf, int style)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tf = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_tf, JniHandleOwnership.DoNotTransfer);
			__this.SetTypeface (tf, style);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUIQQFaceView']/method[@name='setTypeface' and count(parameter)=2 and parameter[1][@type='android.graphics.Typeface'] and parameter[2][@type='int']]"
		[Register ("setTypeface", "(Landroid/graphics/Typeface;I)V", "GetSetTypeface_Landroid_graphics_Typeface_IHandler")]
		public virtual unsafe void SetTypeface (global::Android.Graphics.Typeface tf, int style)
		{
			const string __id = "setTypeface.(Landroid/graphics/Typeface;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tf).Handle);
				__args [1] = new JniArgumentValue (style);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tf);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListener"

		global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListenerImplementor __CreateIQQFaceViewListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView.IQQFaceViewListenerImplementor (this);
		}
#endregion
	}
}
