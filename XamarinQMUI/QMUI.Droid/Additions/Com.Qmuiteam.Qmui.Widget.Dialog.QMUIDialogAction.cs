using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction", DoNotGenerateAcw=true)]
	public partial class QMUIDialogAction : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/field[@name='ACTION_PROP_NEGATIVE']"
		[Register ("ACTION_PROP_NEGATIVE")]
		public const int ActionPropNegative = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/field[@name='ACTION_PROP_NEUTRAL']"
		[Register ("ACTION_PROP_NEUTRAL")]
		public const int ActionPropNeutral = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/field[@name='ACTION_PROP_POSITIVE']"
		[Register ("ACTION_PROP_POSITIVE")]
		public const int ActionPropPositive = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogAction.ActionListener']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction/IActionListenerInvoker")]
		public partial interface IActionListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogAction.ActionListener']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='int']]"
			[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;I)V", "GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_IHandler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction/IActionListenerInvoker, QMUI.Droid")]
			void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, int index);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener", DoNotGenerateAcw=true)]
		internal partial class IActionListenerInvoker : global::Java.Lang.Object, IActionListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener", typeof (IActionListenerInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener"));
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

			static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I;
#pragma warning disable 0169
			static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_IHandler ()
			{
				if (cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I == null)
					cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I);
				return cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I;
			}

			static void n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (dialog, index);
			}
#pragma warning restore 0169

			IntPtr id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I;
			public unsafe void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, int index)
			{
				if (id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I == IntPtr.Zero)
					id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I = JNIEnv.GetMethodID (class_ref, "onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JValue (index);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener.onClick
		public partial class ActionEventArgs : global::System.EventArgs {

			public ActionEventArgs (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, int index)
			{
				this.dialog = dialog;
				this.index = index;
			}

			global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog;
			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog Dialog {
				get { return dialog; }
			}

			int index;
			public int Index {
				get { return index; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/dialog/QMUIDialogAction_ActionListenerImplementor")]
		internal sealed partial class IActionListenerImplementor : global::Java.Lang.Object, IActionListener {

			object sender;

			public IActionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/dialog/QMUIDialogAction_ActionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActionEventArgs> Handler;
#pragma warning restore 0649

			public void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, int index)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ActionEventArgs (dialog, index));
			}

			internal static bool __IsEmpty (IActionListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogAction.Prop']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction$Prop", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction/IPropInvoker")]
		public partial interface IProp : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction$Prop", DoNotGenerateAcw=true)]
		internal partial class IPropInvoker : global::Java.Lang.Object, IProp {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction$Prop", typeof (IPropInvoker));

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

			public static IProp GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProp> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.Prop"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPropInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogAction", typeof (QMUIDialogAction));
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

		protected QMUIDialogAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/constructor[@name='QMUIDialogAction' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe QMUIDialogAction (global::Android.Content.Context context, int strRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (strRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/constructor[@name='QMUIDialogAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register (".ctor", "(Landroid/content/Context;ILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)V", "")]
		public unsafe QMUIDialogAction (global::Android.Content.Context context, int strRes, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener onClickListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;ILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (strRes);
				__args [2] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (onClickListener);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/constructor[@name='QMUIDialogAction' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register (".ctor", "(Ljava/lang/CharSequence;)V", "")]
		public unsafe QMUIDialogAction (global::Java.Lang.ICharSequence str)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				global::System.GC.KeepAlive (str);
			}
		}

		[Register (".ctor", "(Ljava/lang/CharSequence;)V", "")]
		public unsafe QMUIDialogAction (string str)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				global::System.GC.KeepAlive (str);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/constructor[@name='QMUIDialogAction' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register (".ctor", "(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)V", "")]
		public unsafe QMUIDialogAction (global::Java.Lang.ICharSequence str, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener onClickListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_str);
				__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				global::System.GC.KeepAlive (str);
				global::System.GC.KeepAlive (onClickListener);
			}
		}

		[Register (".ctor", "(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)V", "")]
		public unsafe QMUIDialogAction (string str, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener onClickListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_str);
				__args [1] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				global::System.GC.KeepAlive (str);
				global::System.GC.KeepAlive (onClickListener);
			}
		}

		static Delegate cb_getActionProp;
#pragma warning disable 0169
		static Delegate GetGetActionPropHandler ()
		{
			if (cb_getActionProp == null)
				cb_getActionProp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetActionProp);
			return cb_getActionProp;
		}

		static int n_GetActionProp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActionProp;
		}
#pragma warning restore 0169

		public virtual unsafe int ActionProp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='getActionProp' and count(parameter)=0]"
			[Register ("getActionProp", "()I", "GetGetActionPropHandler")]
			get {
				const string __id = "getActionProp.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_buildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I;
#pragma warning disable 0169
		static Delegate GetBuildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_IHandler ()
		{
			if (cb_buildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I == null)
				cb_buildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_BuildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I);
			return cb_buildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I;
		}

		static IntPtr n_BuildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildActionView (dialog, index));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='buildActionView' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='int']]"
		[Register ("buildActionView", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;I)Lcom/qmuiteam/qmui/layout/QMUIButton;", "GetBuildActionView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Layout.QMUIButton BuildActionView (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, int index)
		{
			const string __id = "buildActionView.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;I)Lcom/qmuiteam/qmui/layout/QMUIButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dialog);
			}
		}

		static Delegate cb_iconRes_I;
#pragma warning disable 0169
		static Delegate GetIconRes_IHandler ()
		{
			if (cb_iconRes_I == null)
				cb_iconRes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_IconRes_I);
			return cb_iconRes_I;
		}

		static IntPtr n_IconRes_I (IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconRes (iconRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='iconRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("iconRes", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;", "GetIconRes_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction IconRes (int iconRes)
		{
			const string __id = "iconRes.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (iconRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
#pragma warning disable 0169
		static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler ()
		{
			if (cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ == null)
				cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_);
			return cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
		}

		static IntPtr n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onClickListener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnClick (onClickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;", "GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener onClickListener)
		{
			const string __id = "onClick.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (onClickListener);
			}
		}

		static Delegate cb_prop_I;
#pragma warning disable 0169
		static Delegate GetProp_IHandler ()
		{
			if (cb_prop_I == null)
				cb_prop_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Prop_I);
			return cb_prop_I;
		}

		static IntPtr n_Prop_I (IntPtr jnienv, IntPtr native__this, int actionProp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Prop (actionProp));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='prop' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("prop", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;", "GetProp_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction Prop (int actionProp)
		{
			const string __id = "prop.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (actionProp);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static IntPtr n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;", "GetSetEnabled_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction SetEnabled (bool enabled)
		{
			const string __id = "setEnabled.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinBackgroundAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinBackgroundAttr_IHandler ()
		{
			if (cb_skinBackgroundAttr_I == null)
				cb_skinBackgroundAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinBackgroundAttr_I);
			return cb_skinBackgroundAttr_I;
		}

		static IntPtr n_SkinBackgroundAttr_I (IntPtr jnienv, IntPtr native__this, int skinBackgroundAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinBackgroundAttr (skinBackgroundAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='skinBackgroundAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinBackgroundAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;", "GetSkinBackgroundAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction SkinBackgroundAttr (int skinBackgroundAttr)
		{
			const string __id = "skinBackgroundAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skinBackgroundAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinIconTintColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinIconTintColorAttr_IHandler ()
		{
			if (cb_skinIconTintColorAttr_I == null)
				cb_skinIconTintColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinIconTintColorAttr_I);
			return cb_skinIconTintColorAttr_I;
		}

		static IntPtr n_SkinIconTintColorAttr_I (IntPtr jnienv, IntPtr native__this, int skinIconTintColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinIconTintColorAttr (skinIconTintColorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='skinIconTintColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinIconTintColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;", "GetSkinIconTintColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction SkinIconTintColorAttr (int skinIconTintColorAttr)
		{
			const string __id = "skinIconTintColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skinIconTintColorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinTextColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinTextColorAttr_IHandler ()
		{
			if (cb_skinTextColorAttr_I == null)
				cb_skinTextColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinTextColorAttr_I);
			return cb_skinTextColorAttr_I;
		}

		static IntPtr n_SkinTextColorAttr_I (IntPtr jnienv, IntPtr native__this, int skinTextColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinTextColorAttr (skinTextColorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogAction']/method[@name='skinTextColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinTextColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;", "GetSkinTextColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction SkinTextColorAttr (int skinTextColorAttr)
		{
			const string __id = "skinTextColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skinTextColorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
