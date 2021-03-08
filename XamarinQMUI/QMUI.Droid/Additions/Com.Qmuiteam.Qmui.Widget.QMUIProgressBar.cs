using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIProgressBar", DoNotGenerateAcw=true)]
	public partial class QMUIProgressBar : global::Android.Views.View {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='DEFAULT_BACKGROUND_COLOR']"
		[Register ("DEFAULT_BACKGROUND_COLOR")]
		public const int DefaultBackgroundColor = (int) -7829368;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='DEFAULT_PROGRESS_COLOR']"
		[Register ("DEFAULT_PROGRESS_COLOR")]
		public const int DefaultProgressColor = (int) -16776961;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='DEFAULT_STROKE_WIDTH']"
		[Register ("DEFAULT_STROKE_WIDTH")]
		public static int DefaultStrokeWidth {
			get {
				const string __id = "DEFAULT_STROKE_WIDTH.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "DEFAULT_STROKE_WIDTH.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='DEFAULT_TEXT_COLOR']"
		[Register ("DEFAULT_TEXT_COLOR")]
		public const int DefaultTextColor = (int) -16777216;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='DEFAULT_TEXT_SIZE']"
		[Register ("DEFAULT_TEXT_SIZE")]
		public const int DefaultTextSize = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='TOTAL_DURATION']"
		[Register ("TOTAL_DURATION")]
		public const int TotalDuration = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='TYPE_CIRCLE']"
		[Register ("TYPE_CIRCLE")]
		public const int TypeCircle = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='TYPE_FILL_CIRCLE']"
		[Register ("TYPE_FILL_CIRCLE")]
		public const int TypeFillCircle = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='TYPE_RECT']"
		[Register ("TYPE_RECT")]
		public const int TypeRect = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/field[@name='TYPE_ROUND_RECT']"
		[Register ("TYPE_ROUND_RECT")]
		public const int TypeRoundRect = (int) 1;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIProgressBar.OnProgressChangeListener']"
		[Register ("com/qmuiteam/qmui/widget/QMUIProgressBar$OnProgressChangeListener", "", "Com.Qmuiteam.Qmui.Widget.QMUIProgressBar/IOnProgressChangeListenerInvoker")]
		public partial interface IOnProgressChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIProgressBar.OnProgressChangeListener']/method[@name='onProgressChange' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIProgressBar'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onProgressChange", "(Lcom/qmuiteam/qmui/widget/QMUIProgressBar;II)V", "GetOnProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_IIHandler:Com.Qmuiteam.Qmui.Widget.QMUIProgressBar/IOnProgressChangeListenerInvoker, QMUI.Droid")]
			void OnProgressChange (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar progressBar, int currentValue, int maxValue);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIProgressBar$OnProgressChangeListener", DoNotGenerateAcw=true)]
		internal partial class IOnProgressChangeListenerInvoker : global::Java.Lang.Object, IOnProgressChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIProgressBar$OnProgressChangeListener", typeof (IOnProgressChangeListenerInvoker));

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

			public static IOnProgressChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnProgressChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUIProgressBar.OnProgressChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnProgressChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II;
#pragma warning disable 0169
			static Delegate GetOnProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_IIHandler ()
			{
				if (cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II == null)
					cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II);
				return cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II;
			}

			static void n_OnProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II (IntPtr jnienv, IntPtr native__this, IntPtr native_progressBar, int currentValue, int maxValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var progressBar = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (native_progressBar, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressChange (progressBar, currentValue, maxValue);
			}
#pragma warning restore 0169

			IntPtr id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II;
			public unsafe void OnProgressChange (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar progressBar, int currentValue, int maxValue)
			{
				if (id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II == IntPtr.Zero)
					id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II = JNIEnv.GetMethodID (class_ref, "onProgressChange", "(Lcom/qmuiteam/qmui/widget/QMUIProgressBar;II)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((progressBar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressBar).Handle);
				__args [1] = new JValue (currentValue);
				__args [2] = new JValue (maxValue);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.QMUIProgressBar.OnProgressChangeListener.onProgressChange
		public partial class ProgressChangeEventArgs : global::System.EventArgs {

			public ProgressChangeEventArgs (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar progressBar, int currentValue, int maxValue)
			{
				this.progressBar = progressBar;
				this.currentValue = currentValue;
				this.maxValue = maxValue;
			}

			global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar progressBar;
			public global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar ProgressBar {
				get { return progressBar; }
			}

			int currentValue;
			public int CurrentValue {
				get { return currentValue; }
			}

			int maxValue;
			public int MaxValue {
				get { return maxValue; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/QMUIProgressBar_OnProgressChangeListenerImplementor")]
		internal sealed partial class IOnProgressChangeListenerImplementor : global::Java.Lang.Object, IOnProgressChangeListener {

			object sender;

			public IOnProgressChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/QMUIProgressBar_OnProgressChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ProgressChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnProgressChange (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar progressBar, int currentValue, int maxValue)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ProgressChangeEventArgs (progressBar, currentValue, maxValue));
			}

			internal static bool __IsEmpty (IOnProgressChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIProgressBar.QMUIProgressBarTextGenerator']"
		[Register ("com/qmuiteam/qmui/widget/QMUIProgressBar$QMUIProgressBarTextGenerator", "", "Com.Qmuiteam.Qmui.Widget.QMUIProgressBar/IQMUIProgressBarTextGeneratorInvoker")]
		public partial interface IQMUIProgressBarTextGenerator : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIProgressBar.QMUIProgressBarTextGenerator']/method[@name='generateText' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIProgressBar'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("generateText", "(Lcom/qmuiteam/qmui/widget/QMUIProgressBar;II)Ljava/lang/String;", "GetGenerateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_IIHandler:Com.Qmuiteam.Qmui.Widget.QMUIProgressBar/IQMUIProgressBarTextGeneratorInvoker, QMUI.Droid")]
			string GenerateText (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar progressBar, int value, int maxValue);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIProgressBar$QMUIProgressBarTextGenerator", DoNotGenerateAcw=true)]
		internal partial class IQMUIProgressBarTextGeneratorInvoker : global::Java.Lang.Object, IQMUIProgressBarTextGenerator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIProgressBar$QMUIProgressBarTextGenerator", typeof (IQMUIProgressBarTextGeneratorInvoker));

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

			public static IQMUIProgressBarTextGenerator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQMUIProgressBarTextGenerator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUIProgressBar.QMUIProgressBarTextGenerator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQMUIProgressBarTextGeneratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II;
#pragma warning disable 0169
			static Delegate GetGenerateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_IIHandler ()
			{
				if (cb_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II == null)
					cb_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_GenerateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II);
				return cb_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II;
			}

			static IntPtr n_GenerateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II (IntPtr jnienv, IntPtr native__this, IntPtr native_progressBar, int value, int maxValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IQMUIProgressBarTextGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var progressBar = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (native_progressBar, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GenerateText (progressBar, value, maxValue));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II;
			public unsafe string GenerateText (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar progressBar, int value, int maxValue)
			{
				if (id_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II == IntPtr.Zero)
					id_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II = JNIEnv.GetMethodID (class_ref, "generateText", "(Lcom/qmuiteam/qmui/widget/QMUIProgressBar;II)Ljava/lang/String;");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((progressBar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressBar).Handle);
				__args [1] = new JValue (value);
				__args [2] = new JValue (maxValue);
				var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateText_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIProgressBar", typeof (QMUIProgressBar));
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

		protected QMUIProgressBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/constructor[@name='QMUIProgressBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIProgressBar (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/constructor[@name='QMUIProgressBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIProgressBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/constructor[@name='QMUIProgressBar' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIProgressBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getMaxValue;
#pragma warning disable 0169
		static Delegate GetGetMaxValueHandler ()
		{
			if (cb_getMaxValue == null)
				cb_getMaxValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxValue);
			return cb_getMaxValue;
		}

		static int n_GetMaxValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxValue;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxValue_I;
#pragma warning disable 0169
		static Delegate GetSetMaxValue_IHandler ()
		{
			if (cb_setMaxValue_I == null)
				cb_setMaxValue_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxValue_I);
			return cb_setMaxValue_I;
		}

		static void n_SetMaxValue_I (IntPtr jnienv, IntPtr native__this, int maxValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxValue = maxValue;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='getMaxValue' and count(parameter)=0]"
			[Register ("getMaxValue", "()I", "GetGetMaxValueHandler")]
			get {
				const string __id = "getMaxValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setMaxValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxValue", "(I)V", "GetSetMaxValue_IHandler")]
			set {
				const string __id = "setMaxValue.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProgress);
			return cb_getProgress;
		}

		static int n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int progress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress = progress;
		}
#pragma warning restore 0169

		public virtual unsafe int Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()I", "GetGetProgressHandler")]
			get {
				const string __id = "getProgress.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
			set {
				const string __id = "setProgress.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getQMUIProgressBarTextGenerator;
#pragma warning disable 0169
		static Delegate GetGetQMUIProgressBarTextGeneratorHandler ()
		{
			if (cb_getQMUIProgressBarTextGenerator == null)
				cb_getQMUIProgressBarTextGenerator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetQMUIProgressBarTextGenerator);
			return cb_getQMUIProgressBarTextGenerator;
		}

		static IntPtr n_GetQMUIProgressBarTextGenerator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QMUIProgressBarTextGenerator);
		}
#pragma warning restore 0169

		static Delegate cb_setQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_;
#pragma warning disable 0169
		static Delegate GetSetQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_Handler ()
		{
			if (cb_setQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_ == null)
				cb_setQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_);
			return cb_setQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_;
		}

		static void n_SetQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_QMUIProgressBarTextGenerator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var QMUIProgressBarTextGenerator = (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IQMUIProgressBarTextGenerator)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IQMUIProgressBarTextGenerator> (native_QMUIProgressBarTextGenerator, JniHandleOwnership.DoNotTransfer);
			__this.QMUIProgressBarTextGenerator = QMUIProgressBarTextGenerator;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IQMUIProgressBarTextGenerator QMUIProgressBarTextGenerator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='getQMUIProgressBarTextGenerator' and count(parameter)=0]"
			[Register ("getQMUIProgressBarTextGenerator", "()Lcom/qmuiteam/qmui/widget/QMUIProgressBar$QMUIProgressBarTextGenerator;", "GetGetQMUIProgressBarTextGeneratorHandler")]
			get {
				const string __id = "getQMUIProgressBarTextGenerator.()Lcom/qmuiteam/qmui/widget/QMUIProgressBar$QMUIProgressBarTextGenerator;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IQMUIProgressBarTextGenerator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setQMUIProgressBarTextGenerator' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIProgressBar.QMUIProgressBarTextGenerator']]"
			[Register ("setQMUIProgressBarTextGenerator", "(Lcom/qmuiteam/qmui/widget/QMUIProgressBar$QMUIProgressBarTextGenerator;)V", "GetSetQMUIProgressBarTextGenerator_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_QMUIProgressBarTextGenerator_Handler")]
			set {
				const string __id = "setQMUIProgressBarTextGenerator.(Lcom/qmuiteam/qmui/widget/QMUIProgressBar$QMUIProgressBarTextGenerator;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_setBarColor_II;
#pragma warning disable 0169
		static Delegate GetSetBarColor_IIHandler ()
		{
			if (cb_setBarColor_II == null)
				cb_setBarColor_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetBarColor_II);
			return cb_setBarColor_II;
		}

		static void n_SetBarColor_II (IntPtr jnienv, IntPtr native__this, int backgroundColor, int progressColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBarColor (backgroundColor, progressColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setBarColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setBarColor", "(II)V", "GetSetBarColor_IIHandler")]
		public virtual unsafe void SetBarColor (int backgroundColor, int progressColor)
		{
			const string __id = "setBarColor.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (backgroundColor);
				__args [1] = new JniArgumentValue (progressColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_Handler ()
		{
			if (cb_setOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_ == null)
				cb_setOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_);
			return cb_setOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_;
		}

		static void n_SetOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onProgressChangeListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onProgressChangeListener = (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListener> (native_onProgressChangeListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnProgressChangeListener (onProgressChangeListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setOnProgressChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIProgressBar.OnProgressChangeListener']]"
		[Register ("setOnProgressChangeListener", "(Lcom/qmuiteam/qmui/widget/QMUIProgressBar$OnProgressChangeListener;)V", "GetSetOnProgressChangeListener_Lcom_qmuiteam_qmui_widget_QMUIProgressBar_OnProgressChangeListener_Handler")]
		public virtual unsafe void SetOnProgressChangeListener (global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListener onProgressChangeListener)
		{
			const string __id = "setOnProgressChangeListener.(Lcom/qmuiteam/qmui/widget/QMUIProgressBar$OnProgressChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onProgressChangeListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onProgressChangeListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onProgressChangeListener);
			}
		}

		static Delegate cb_setProgress_IZ;
#pragma warning disable 0169
		static Delegate GetSetProgress_IZHandler ()
		{
			if (cb_setProgress_IZ == null)
				cb_setProgress_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_V) n_SetProgress_IZ);
			return cb_setProgress_IZ;
		}

		static void n_SetProgress_IZ (IntPtr jnienv, IntPtr native__this, int progress, bool animated)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (progress, animated);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setProgress' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setProgress", "(IZ)V", "GetSetProgress_IZHandler")]
		public virtual unsafe void SetProgress (int progress, bool animated)
		{
			const string __id = "setProgress.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (progress);
				__args [1] = new JniArgumentValue (animated);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setProgressColor_I;
#pragma warning disable 0169
		static Delegate GetSetProgressColor_IHandler ()
		{
			if (cb_setProgressColor_I == null)
				cb_setProgressColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetProgressColor_I);
			return cb_setProgressColor_I;
		}

		static void n_SetProgressColor_I (IntPtr jnienv, IntPtr native__this, int progressColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgressColor (progressColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setProgressColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgressColor", "(I)V", "GetSetProgressColor_IHandler")]
		public virtual unsafe void SetProgressColor (int progressColor)
		{
			const string __id = "setProgressColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (progressColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStrokeRoundCap_Z;
#pragma warning disable 0169
		static Delegate GetSetStrokeRoundCap_ZHandler ()
		{
			if (cb_setStrokeRoundCap_Z == null)
				cb_setStrokeRoundCap_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetStrokeRoundCap_Z);
			return cb_setStrokeRoundCap_Z;
		}

		static void n_SetStrokeRoundCap_Z (IntPtr jnienv, IntPtr native__this, bool isRoundCap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeRoundCap (isRoundCap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setStrokeRoundCap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStrokeRoundCap", "(Z)V", "GetSetStrokeRoundCap_ZHandler")]
		public virtual unsafe void SetStrokeRoundCap (bool isRoundCap)
		{
			const string __id = "setStrokeRoundCap.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isRoundCap);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStrokeWidth_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_IHandler ()
		{
			if (cb_setStrokeWidth_I == null)
				cb_setStrokeWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStrokeWidth_I);
			return cb_setStrokeWidth_I;
		}

		static void n_SetStrokeWidth_I (IntPtr jnienv, IntPtr native__this, int strokeWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeWidth (strokeWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStrokeWidth", "(I)V", "GetSetStrokeWidth_IHandler")]
		public virtual unsafe void SetStrokeWidth (int strokeWidth)
		{
			const string __id = "setStrokeWidth.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strokeWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextColor (textColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextSize (textSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextSize", "(I)V", "GetSetTextSize_IHandler")]
		public virtual unsafe void SetTextSize (int textSize)
		{
			const string __id = "setTextSize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setType", "(I)V", "GetSetType_IHandler")]
		public virtual unsafe void SetType (int type)
		{
			const string __id = "setType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setup_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetSetup_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_setup_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_setup_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Setup_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_setup_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static void n_Setup_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_attrs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var attrs = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_attrs, JniHandleOwnership.DoNotTransfer);
			__this.Setup (context, attrs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIProgressBar']/method[@name='setup' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("setup", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "GetSetup_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public virtual unsafe void Setup (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "setup.(Landroid/content/Context;Landroid/util/AttributeSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.ProgressChangeEventArgs> ProgressChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListener, global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						__CreateIOnProgressChangeListenerImplementor,
						SetOnProgressChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListener, global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListenerImplementor.__IsEmpty,
						__v => SetOnProgressChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnProgressChangeListener;

		global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListenerImplementor __CreateIOnProgressChangeListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.QMUIProgressBar.IOnProgressChangeListenerImplementor (this);
		}
#endregion
	}
}
