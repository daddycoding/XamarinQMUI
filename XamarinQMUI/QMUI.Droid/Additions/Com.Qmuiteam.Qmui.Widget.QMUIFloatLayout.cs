using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIFloatLayout", DoNotGenerateAcw=true)]
	public partial class QMUIFloatLayout : global::Android.Views.ViewGroup {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIFloatLayout.OnLineCountChangeListener']"
		[Register ("com/qmuiteam/qmui/widget/QMUIFloatLayout$OnLineCountChangeListener", "", "Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout/IOnLineCountChangeListenerInvoker")]
		public partial interface IOnLineCountChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIFloatLayout.OnLineCountChangeListener']/method[@name='onChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onChange", "(II)V", "GetOnChange_IIHandler:Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout/IOnLineCountChangeListenerInvoker, QMUI.Droid")]
			void OnChange (int oldLineCount, int newLineCount);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIFloatLayout$OnLineCountChangeListener", DoNotGenerateAcw=true)]
		internal partial class IOnLineCountChangeListenerInvoker : global::Java.Lang.Object, IOnLineCountChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIFloatLayout$OnLineCountChangeListener", typeof (IOnLineCountChangeListenerInvoker));

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

			public static IOnLineCountChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnLineCountChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUIFloatLayout.OnLineCountChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnLineCountChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onChange_II;
#pragma warning disable 0169
			static Delegate GetOnChange_IIHandler ()
			{
				if (cb_onChange_II == null)
					cb_onChange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnChange_II);
				return cb_onChange_II;
			}

			static void n_OnChange_II (IntPtr jnienv, IntPtr native__this, int oldLineCount, int newLineCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnChange (oldLineCount, newLineCount);
			}
#pragma warning restore 0169

			IntPtr id_onChange_II;
			public unsafe void OnChange (int oldLineCount, int newLineCount)
			{
				if (id_onChange_II == IntPtr.Zero)
					id_onChange_II = JNIEnv.GetMethodID (class_ref, "onChange", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (oldLineCount);
				__args [1] = new JValue (newLineCount);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChange_II, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.QMUIFloatLayout.OnLineCountChangeListener.onChange
		public partial class LineCountChangeEventArgs : global::System.EventArgs {

			public LineCountChangeEventArgs (int oldLineCount, int newLineCount)
			{
				this.oldLineCount = oldLineCount;
				this.newLineCount = newLineCount;
			}

			int oldLineCount;
			public int OldLineCount {
				get { return oldLineCount; }
			}

			int newLineCount;
			public int NewLineCount {
				get { return newLineCount; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/QMUIFloatLayout_OnLineCountChangeListenerImplementor")]
		internal sealed partial class IOnLineCountChangeListenerImplementor : global::Java.Lang.Object, IOnLineCountChangeListener {

			object sender;

			public IOnLineCountChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/QMUIFloatLayout_OnLineCountChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LineCountChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnChange (int oldLineCount, int newLineCount)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new LineCountChangeEventArgs (oldLineCount, newLineCount));
			}

			internal static bool __IsEmpty (IOnLineCountChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIFloatLayout", typeof (QMUIFloatLayout));
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

		protected QMUIFloatLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/constructor[@name='QMUIFloatLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIFloatLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/constructor[@name='QMUIFloatLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIFloatLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/constructor[@name='QMUIFloatLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIFloatLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Gravity = gravity;
		}
#pragma warning restore 0169

		public virtual unsafe int Gravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='getGravity' and count(parameter)=0]"
			[Register ("getGravity", "()I", "GetGetGravityHandler")]
			get {
				const string __id = "getGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='setGravity' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineCount;
		}
#pragma warning restore 0169

		public virtual unsafe int LineCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='getLineCount' and count(parameter)=0]"
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

		static Delegate cb_getMaxLines;
#pragma warning disable 0169
		static Delegate GetGetMaxLinesHandler ()
		{
			if (cb_getMaxLines == null)
				cb_getMaxLines = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxLines);
			return cb_getMaxLines;
		}

		static int n_GetMaxLines (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLines;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxLines_I;
#pragma warning disable 0169
		static Delegate GetSetMaxLines_IHandler ()
		{
			if (cb_setMaxLines_I == null)
				cb_setMaxLines_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxLines_I);
			return cb_setMaxLines_I;
		}

		static void n_SetMaxLines_I (IntPtr jnienv, IntPtr native__this, int maxLines)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxLines = maxLines;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='getMaxLines' and count(parameter)=0]"
			[Register ("getMaxLines", "()I", "GetGetMaxLinesHandler")]
			get {
				const string __id = "getMaxLines.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='setMaxLines' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxLines", "(I)V", "GetSetMaxLines_IHandler")]
			set {
				const string __id = "setMaxLines.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxNumber;
#pragma warning disable 0169
		static Delegate GetGetMaxNumberHandler ()
		{
			if (cb_getMaxNumber == null)
				cb_getMaxNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxNumber);
			return cb_getMaxNumber;
		}

		static int n_GetMaxNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxNumber;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxNumber_I;
#pragma warning disable 0169
		static Delegate GetSetMaxNumber_IHandler ()
		{
			if (cb_setMaxNumber_I == null)
				cb_setMaxNumber_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxNumber_I);
			return cb_setMaxNumber_I;
		}

		static void n_SetMaxNumber_I (IntPtr jnienv, IntPtr native__this, int maxNumber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxNumber = maxNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='getMaxNumber' and count(parameter)=0]"
			[Register ("getMaxNumber", "()I", "GetGetMaxNumberHandler")]
			get {
				const string __id = "getMaxNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='setMaxNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxNumber", "(I)V", "GetSetMaxNumber_IHandler")]
			set {
				const string __id = "setMaxNumber.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int left, int top, int right, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool changed, int left, int top, int right, int bottom)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (left);
				__args [2] = new JniArgumentValue (top);
				__args [3] = new JniArgumentValue (right);
				__args [4] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setChildHorizontalSpacing_I;
#pragma warning disable 0169
		static Delegate GetSetChildHorizontalSpacing_IHandler ()
		{
			if (cb_setChildHorizontalSpacing_I == null)
				cb_setChildHorizontalSpacing_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetChildHorizontalSpacing_I);
			return cb_setChildHorizontalSpacing_I;
		}

		static void n_SetChildHorizontalSpacing_I (IntPtr jnienv, IntPtr native__this, int spacing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChildHorizontalSpacing (spacing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='setChildHorizontalSpacing' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChildHorizontalSpacing", "(I)V", "GetSetChildHorizontalSpacing_IHandler")]
		public virtual unsafe void SetChildHorizontalSpacing (int spacing)
		{
			const string __id = "setChildHorizontalSpacing.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (spacing);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setChildVerticalSpacing_I;
#pragma warning disable 0169
		static Delegate GetSetChildVerticalSpacing_IHandler ()
		{
			if (cb_setChildVerticalSpacing_I == null)
				cb_setChildVerticalSpacing_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetChildVerticalSpacing_I);
			return cb_setChildVerticalSpacing_I;
		}

		static void n_SetChildVerticalSpacing_I (IntPtr jnienv, IntPtr native__this, int spacing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChildVerticalSpacing (spacing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='setChildVerticalSpacing' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChildVerticalSpacing", "(I)V", "GetSetChildVerticalSpacing_IHandler")]
		public virtual unsafe void SetChildVerticalSpacing (int spacing)
		{
			const string __id = "setChildVerticalSpacing.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (spacing);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_Handler ()
		{
			if (cb_setOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_ == null)
				cb_setOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_);
			return cb_setOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_;
		}

		static void n_SetOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onLineCountChangeListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onLineCountChangeListener = (global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListener> (native_onLineCountChangeListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnLineCountChangeListener (onLineCountChangeListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIFloatLayout']/method[@name='setOnLineCountChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIFloatLayout.OnLineCountChangeListener']]"
		[Register ("setOnLineCountChangeListener", "(Lcom/qmuiteam/qmui/widget/QMUIFloatLayout$OnLineCountChangeListener;)V", "GetSetOnLineCountChangeListener_Lcom_qmuiteam_qmui_widget_QMUIFloatLayout_OnLineCountChangeListener_Handler")]
		public virtual unsafe void SetOnLineCountChangeListener (global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListener onLineCountChangeListener)
		{
			const string __id = "setOnLineCountChangeListener.(Lcom/qmuiteam/qmui/widget/QMUIFloatLayout$OnLineCountChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onLineCountChangeListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onLineCountChangeListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onLineCountChangeListener);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.LineCountChangeEventArgs> LineCountChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListener, global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListenerImplementor>(
						ref weak_implementor_SetOnLineCountChangeListener,
						__CreateIOnLineCountChangeListenerImplementor,
						SetOnLineCountChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListener, global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListenerImplementor>(
						ref weak_implementor_SetOnLineCountChangeListener,
						global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListenerImplementor.__IsEmpty,
						__v => SetOnLineCountChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnLineCountChangeListener;

		global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListenerImplementor __CreateIOnLineCountChangeListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.QMUIFloatLayout.IOnLineCountChangeListenerImplementor (this);
		}
#endregion
	}
}
