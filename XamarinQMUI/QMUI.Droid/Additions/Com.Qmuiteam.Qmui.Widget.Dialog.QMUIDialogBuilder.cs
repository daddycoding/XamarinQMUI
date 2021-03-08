using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.qmuiteam.qmui.widget.dialog.QMUIDialogBuilder"})]
	public abstract partial class QMUIDialogBuilder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/field[@name='HORIZONTAL']"
		[Register ("HORIZONTAL")]
		public const int Horizontal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/field[@name='VERTICAL']"
		[Register ("VERTICAL")]
		public const int Vertical = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/field[@name='mActions']"
		[Register ("mActions")]
		protected global::System.Collections.IList MActions {
			get {
				const string __id = "mActions.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mActions.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/field[@name='mDialog']"
		[Register ("mDialog")]
		protected global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog MDialog {
			get {
				const string __id = "mDialog.Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDialog.Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/field[@name='mDialogView']"
		[Register ("mDialogView")]
		protected global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView MDialogView {
			get {
				const string __id = "mDialogView.Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDialogView.Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/field[@name='mRootView']"
		[Register ("mRootView")]
		protected global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout MRootView {
			get {
				const string __id = "mRootView.Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRootView.Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/field[@name='mTitle']"
		[Register ("mTitle")]
		protected string MTitle {
			get {
				const string __id = "mTitle.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTitle.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogBuilder.OnProvideDefaultTheme']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$OnProvideDefaultTheme", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder/IOnProvideDefaultThemeInvoker")]
		public partial interface IOnProvideDefaultTheme : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogBuilder.OnProvideDefaultTheme']/method[@name='getThemeForBuilder' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogBuilder']]"
			[Register ("getThemeForBuilder", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;)I", "GetGetThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder/IOnProvideDefaultThemeInvoker, QMUI.Droid")]
			int GetThemeForBuilder (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder builder);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$OnProvideDefaultTheme", DoNotGenerateAcw=true)]
		internal partial class IOnProvideDefaultThemeInvoker : global::Java.Lang.Object, IOnProvideDefaultTheme {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$OnProvideDefaultTheme", typeof (IOnProvideDefaultThemeInvoker));

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

			public static IOnProvideDefaultTheme GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnProvideDefaultTheme> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIDialogBuilder.OnProvideDefaultTheme"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnProvideDefaultThemeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_;
#pragma warning disable 0169
			static Delegate GetGetThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_Handler ()
			{
				if (cb_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_ == null)
					cb_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_);
				return cb_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_;
			}

			static int n_GetThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder.IOnProvideDefaultTheme> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetThemeForBuilder (builder);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_;
			public unsafe int GetThemeForBuilder (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder builder)
			{
				if (id_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_ == IntPtr.Zero)
					id_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_ = JNIEnv.GetMethodID (class_ref, "getThemeForBuilder", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getThemeForBuilder_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogBuilder_, __args);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogBuilder.Orientation']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$Orientation", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder/IOrientationInvoker")]
		public partial interface IOrientation : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$Orientation", DoNotGenerateAcw=true)]
		internal partial class IOrientationInvoker : global::Java.Lang.Object, IOrientation {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$Orientation", typeof (IOrientationInvoker));

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

			public static IOrientation GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOrientation> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIDialogBuilder.Orientation"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOrientationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder.IOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder.IOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder.IOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder.IOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder", typeof (QMUIDialogBuilder));
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

		protected QMUIDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/constructor[@name='QMUIDialogBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIDialogBuilder (global::Android.Content.Context context)
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

		static Delegate cb_getBaseContext;
#pragma warning disable 0169
		static Delegate GetGetBaseContextHandler ()
		{
			if (cb_getBaseContext == null)
				cb_getBaseContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBaseContext);
			return cb_getBaseContext;
		}

		static IntPtr n_GetBaseContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context BaseContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='getBaseContext' and count(parameter)=0]"
			[Register ("getBaseContext", "()Landroid/content/Context;", "GetGetBaseContextHandler")]
			get {
				const string __id = "getBaseContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasTitle;
#pragma warning disable 0169
		static Delegate GetHasTitleHandler ()
		{
			if (cb_hasTitle == null)
				cb_hasTitle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasTitle);
			return cb_hasTitle;
		}

		static bool n_HasTitle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTitle;
		}
#pragma warning restore 0169

		protected virtual unsafe bool HasTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='hasTitle' and count(parameter)=0]"
			[Register ("hasTitle", "()Z", "GetHasTitleHandler")]
			get {
				const string __id = "hasTitle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPositiveAction;
#pragma warning disable 0169
		static Delegate GetGetPositiveActionHandler ()
		{
			if (cb_getPositiveAction == null)
				cb_getPositiveAction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPositiveAction);
			return cb_getPositiveAction;
		}

		static IntPtr n_GetPositiveAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction>.ToLocalJniHandle (__this.PositiveAction);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> PositiveAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='getPositiveAction' and count(parameter)=0]"
			[Register ("getPositiveAction", "()Ljava/util/List;", "GetGetPositiveActionHandler")]
			get {
				const string __id = "getPositiveAction.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_;
#pragma warning disable 0169
		static Delegate GetAddAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_Handler ()
		{
			if (cb_addAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ == null)
				cb_addAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_);
			return cb_addAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_;
		}

		static IntPtr n_AddAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction> (native_action, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (action));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='addAction' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction']]"
		[Register ("addAction", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddAction_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAction (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction action)
		{
			const string __id = "addAction.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (action);
			}
		}

		static Delegate cb_addAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
#pragma warning disable 0169
		static Delegate GetAddAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler ()
		{
			if (cb_addAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ == null)
				cb_addAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_AddAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_);
			return cb_addAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
		}

		static IntPtr n_AddAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ (IntPtr jnienv, IntPtr native__this, int strResId, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (strResId, listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='addAction' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register ("addAction", "(ILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddAction_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAction (int strResId, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			const string __id = "addAction.(ILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (strResId);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_addAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
#pragma warning disable 0169
		static Delegate GetAddAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler ()
		{
			if (cb_addAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ == null)
				cb_addAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_L) n_AddAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_);
			return cb_addAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
		}

		static IntPtr n_AddAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ (IntPtr jnienv, IntPtr native__this, int iconResId, int strResId, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (iconResId, strResId, listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='addAction' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register ("addAction", "(IILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddAction_IILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAction (int iconResId, int strResId, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			const string __id = "addAction.(IILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (iconResId);
				__args [1] = new JniArgumentValue (strResId);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_addAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
#pragma warning disable 0169
		static Delegate GetAddAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler ()
		{
			if (cb_addAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ == null)
				cb_addAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_L) n_AddAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_);
			return cb_addAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
		}

		static IntPtr n_AddAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ (IntPtr jnienv, IntPtr native__this, int iconRes, int strRes, int prop, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (iconRes, strRes, prop, listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='addAction' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register ("addAction", "(IIILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddAction_IIILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAction (int iconRes, int strRes, int prop, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			const string __id = "addAction.(IIILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (iconRes);
				__args [1] = new JniArgumentValue (strRes);
				__args [2] = new JniArgumentValue (prop);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_addAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
#pragma warning disable 0169
		static Delegate GetAddAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler ()
		{
			if (cb_addAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ == null)
				cb_addAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_L) n_AddAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_);
			return cb_addAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
		}

		static IntPtr n_AddAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ (IntPtr jnienv, IntPtr native__this, int iconResId, IntPtr native_str, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_str, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (iconResId, str, listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='addAction' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register ("addAction", "(ILjava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddAction_ILjava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAction (int iconResId, global::Java.Lang.ICharSequence str, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			const string __id = "addAction.(ILjava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (iconResId);
				__args [1] = new JniArgumentValue (native_str);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				global::System.GC.KeepAlive (str);
				global::System.GC.KeepAlive (listener);
			}
		}

		public global::Java.Lang.Object AddAction (int iconResId, string str, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			global::Java.Lang.Object __result = AddAction (iconResId, jls_str, listener);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static Delegate cb_addAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
#pragma warning disable 0169
		static Delegate GetAddAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler ()
		{
			if (cb_addAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ == null)
				cb_addAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILIL_L) n_AddAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_);
			return cb_addAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
		}

		static IntPtr n_AddAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ (IntPtr jnienv, IntPtr native__this, int iconRes, IntPtr native_str, int prop, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_str, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (iconRes, str, prop, listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='addAction' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int'] and parameter[4][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register ("addAction", "(ILjava/lang/CharSequence;ILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddAction_ILjava_lang_CharSequence_ILcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAction (int iconRes, global::Java.Lang.ICharSequence str, int prop, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			const string __id = "addAction.(ILjava/lang/CharSequence;ILcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (iconRes);
				__args [1] = new JniArgumentValue (native_str);
				__args [2] = new JniArgumentValue (prop);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				global::System.GC.KeepAlive (str);
				global::System.GC.KeepAlive (listener);
			}
		}

		public global::Java.Lang.Object AddAction (int iconRes, string str, int prop, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			global::Java.Lang.Object __result = AddAction (iconRes, jls_str, prop, listener);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static Delegate cb_addAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
#pragma warning disable 0169
		static Delegate GetAddAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler ()
		{
			if (cb_addAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ == null)
				cb_addAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_);
			return cb_addAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_;
		}

		static IntPtr n_AddAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_str, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (str, listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='addAction' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogAction.ActionListener']]"
		[Register ("addAction", "(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetAddAction_Ljava_lang_CharSequence_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogAction_ActionListener_Handler")]
		public virtual unsafe global::Java.Lang.Object AddAction (global::Java.Lang.ICharSequence str, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			const string __id = "addAction.(Ljava/lang/CharSequence;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogAction$ActionListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_str);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				global::System.GC.KeepAlive (str);
				global::System.GC.KeepAlive (listener);
			}
		}

		public global::Java.Lang.Object AddAction (string str, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogAction.IActionListener listener)
		{
			var jls_str = str == null ? null : new global::Java.Lang.String (str);
			global::Java.Lang.Object __result = AddAction (jls_str, listener);
			var __rsval = __result;
			jls_str?.Dispose ();
			return __rsval;
		}

		static Delegate cb_configRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_;
#pragma warning disable 0169
		static Delegate GetConfigRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Handler ()
		{
			if (cb_configRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_ == null)
				cb_configRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ConfigRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_);
			return cb_configRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_;
		}

		static void n_ConfigRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rootLayout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
			__this.ConfigRootLayout (rootLayout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='configRootLayout' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogRootLayout']]"
		[Register ("configRootLayout", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout;)V", "GetConfigRootLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Handler")]
		protected virtual unsafe void ConfigRootLayout (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout rootLayout)
		{
			const string __id = "configRootLayout.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rootLayout);
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Create);
			return cb_create;
		}

		static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;", "GetCreateHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog Create ()
		{
			const string __id = "create.()Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_create_I;
#pragma warning disable 0169
		static Delegate GetCreate_IHandler ()
		{
			if (cb_create_I == null)
				cb_create_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Create_I);
			return cb_create_I;
		}

		static IntPtr n_Create_I (IntPtr jnienv, IntPtr native__this, int style)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create (style));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;", "GetCreate_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog Create (int style)
		{
			const string __id = "create.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (style);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_Handler ()
		{
			if (cb_onAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_ == null)
				cb_onAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_);
			return cb_onAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_;
		}

		static void n_OnAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, IntPtr native_rootLayout, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
			var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.OnAfterCreate (dialog, rootLayout, context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onAfterCreate' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogRootLayout'] and parameter[3][@type='android.content.Context']]"
		[Register ("onAfterCreate", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout;Landroid/content/Context;)V", "GetOnAfterCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogRootLayout_Landroid_content_Context_Handler")]
		protected virtual unsafe void OnAfterCreate (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogRootLayout rootLayout, global::Android.Content.Context context)
		{
			const string __id = "onAfterCreate.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogRootLayout;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dialog);
				global::System.GC.KeepAlive (rootLayout);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ == null)
				cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_);
			return cb_onCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContent (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateContent", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler")]
		protected abstract global::Android.Views.View OnCreateContent (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1, global::Android.Content.Context p2);

		static Delegate cb_onCreateContentLayoutParams_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateContentLayoutParams_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateContentLayoutParams_Landroid_content_Context_ == null)
				cb_onCreateContentLayoutParams_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateContentLayoutParams_Landroid_content_Context_);
			return cb_onCreateContentLayoutParams_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateContentLayoutParams_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContentLayoutParams (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateContentLayoutParams' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreateContentLayoutParams", "(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;", "GetOnCreateContentLayoutParams_Landroid_content_Context_Handler")]
		protected virtual unsafe global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams OnCreateContentLayoutParams (global::Android.Content.Context context)
		{
			const string __id = "onCreateContentLayoutParams.(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateDialogLayoutParams;
#pragma warning disable 0169
		static Delegate GetOnCreateDialogLayoutParamsHandler ()
		{
			if (cb_onCreateDialogLayoutParams == null)
				cb_onCreateDialogLayoutParams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OnCreateDialogLayoutParams);
			return cb_onCreateDialogLayoutParams;
		}

		static IntPtr n_OnCreateDialogLayoutParams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCreateDialogLayoutParams ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateDialogLayoutParams' and count(parameter)=0]"
		[Register ("onCreateDialogLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;", "GetOnCreateDialogLayoutParamsHandler")]
		protected virtual unsafe global::Android.Widget.FrameLayout.LayoutParams OnCreateDialogLayoutParams ()
		{
			const string __id = "onCreateDialogLayoutParams.()Landroid/widget/FrameLayout$LayoutParams;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onCreateDialogView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateDialogView_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateDialogView_Landroid_content_Context_ == null)
				cb_onCreateDialogView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateDialogView_Landroid_content_Context_);
			return cb_onCreateDialogView_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateDialogView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateDialogView (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateDialogView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreateDialogView", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;", "GetOnCreateDialogView_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView OnCreateDialogView (global::Android.Content.Context context)
		{
			const string __id = "onCreateDialogView.(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ == null)
				cb_onCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_);
			return cb_onCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, IntPtr native_parent, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateOperatorLayout (dialog, parent, context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateOperatorLayout' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateOperatorLayout", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateOperatorLayout_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Android.Views.View OnCreateOperatorLayout (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView parent, global::Android.Content.Context context)
		{
			const string __id = "onCreateOperatorLayout.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dialog);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateOperatorLayoutLayoutParams_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateOperatorLayoutLayoutParams_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateOperatorLayoutLayoutParams_Landroid_content_Context_ == null)
				cb_onCreateOperatorLayoutLayoutParams_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateOperatorLayoutLayoutParams_Landroid_content_Context_);
			return cb_onCreateOperatorLayoutLayoutParams_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateOperatorLayoutLayoutParams_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateOperatorLayoutLayoutParams (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateOperatorLayoutLayoutParams' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreateOperatorLayoutLayoutParams", "(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;", "GetOnCreateOperatorLayoutLayoutParams_Landroid_content_Context_Handler")]
		protected virtual unsafe global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams OnCreateOperatorLayoutLayoutParams (global::Android.Content.Context context)
		{
			const string __id = "onCreateOperatorLayoutLayoutParams.(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ == null)
				cb_onCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_);
			return cb_onCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, IntPtr native_parent, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dialog = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (native_dialog, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_parent, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateTitle (dialog, parent, context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateTitle' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateTitle", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateTitle_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Android.Views.View OnCreateTitle (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog dialog, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView parent, global::Android.Content.Context context)
		{
			const string __id = "onCreateTitle.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dialog);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onCreateTitleLayoutParams_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreateTitleLayoutParams_Landroid_content_Context_Handler ()
		{
			if (cb_onCreateTitleLayoutParams_Landroid_content_Context_ == null)
				cb_onCreateTitleLayoutParams_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateTitleLayoutParams_Landroid_content_Context_);
			return cb_onCreateTitleLayoutParams_Landroid_content_Context_;
		}

		static IntPtr n_OnCreateTitleLayoutParams_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateTitleLayoutParams (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateTitleLayoutParams' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreateTitleLayoutParams", "(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;", "GetOnCreateTitleLayoutParams_Landroid_content_Context_Handler")]
		protected virtual unsafe global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams OnCreateTitleLayoutParams (global::Android.Content.Context context)
		{
			const string __id = "onCreateTitleLayoutParams.(Landroid/content/Context;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_onOverlayOccurredInMeasure;
#pragma warning disable 0169
		static Delegate GetOnOverlayOccurredInMeasureHandler ()
		{
			if (cb_onOverlayOccurredInMeasure == null)
				cb_onOverlayOccurredInMeasure = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnOverlayOccurredInMeasure);
			return cb_onOverlayOccurredInMeasure;
		}

		static void n_OnOverlayOccurredInMeasure (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOverlayOccurredInMeasure ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onOverlayOccurredInMeasure' and count(parameter)=0]"
		[Register ("onOverlayOccurredInMeasure", "()V", "GetOnOverlayOccurredInMeasureHandler")]
		protected virtual unsafe void OnOverlayOccurredInMeasure ()
		{
			const string __id = "onOverlayOccurredInMeasure.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setActionContainerOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetActionContainerOrientation_IHandler ()
		{
			if (cb_setActionContainerOrientation_I == null)
				cb_setActionContainerOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetActionContainerOrientation_I);
			return cb_setActionContainerOrientation_I;
		}

		static IntPtr n_SetActionContainerOrientation_I (IntPtr jnienv, IntPtr native__this, int actionContainerOrientation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetActionContainerOrientation (actionContainerOrientation));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setActionContainerOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActionContainerOrientation", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetActionContainerOrientation_IHandler")]
		public virtual unsafe global::Java.Lang.Object SetActionContainerOrientation (int actionContainerOrientation)
		{
			const string __id = "setActionContainerOrientation.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (actionContainerOrientation);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActionDivider_IIII;
#pragma warning disable 0169
		static Delegate GetSetActionDivider_IIIIHandler ()
		{
			if (cb_setActionDivider_IIII == null)
				cb_setActionDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_L) n_SetActionDivider_IIII);
			return cb_setActionDivider_IIII;
		}

		static IntPtr n_SetActionDivider_IIII (IntPtr jnienv, IntPtr native__this, int thickness, int colorAttr, int startInset, int endInset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetActionDivider (thickness, colorAttr, startInset, endInset));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setActionDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setActionDivider", "(IIII)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetActionDivider_IIIIHandler")]
		public virtual unsafe global::Java.Lang.Object SetActionDivider (int thickness, int colorAttr, int startInset, int endInset)
		{
			const string __id = "setActionDivider.(IIII)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (thickness);
				__args [1] = new JniArgumentValue (colorAttr);
				__args [2] = new JniArgumentValue (startInset);
				__args [3] = new JniArgumentValue (endInset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActionDividerColor_I;
#pragma warning disable 0169
		static Delegate GetSetActionDividerColor_IHandler ()
		{
			if (cb_setActionDividerColor_I == null)
				cb_setActionDividerColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetActionDividerColor_I);
			return cb_setActionDividerColor_I;
		}

		static IntPtr n_SetActionDividerColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetActionDividerColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setActionDividerColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActionDividerColor", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetActionDividerColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object SetActionDividerColor (int color)
		{
			const string __id = "setActionDividerColor.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActionDividerColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSetActionDividerColorAttr_IHandler ()
		{
			if (cb_setActionDividerColorAttr_I == null)
				cb_setActionDividerColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetActionDividerColorAttr_I);
			return cb_setActionDividerColorAttr_I;
		}

		static IntPtr n_SetActionDividerColorAttr_I (IntPtr jnienv, IntPtr native__this, int colorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetActionDividerColorAttr (colorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setActionDividerColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActionDividerColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetActionDividerColorAttr_IHandler")]
		public virtual unsafe global::Java.Lang.Object SetActionDividerColorAttr (int colorAttr)
		{
			const string __id = "setActionDividerColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (colorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActionDividerInsetAndThickness_III;
#pragma warning disable 0169
		static Delegate GetSetActionDividerInsetAndThickness_IIIHandler ()
		{
			if (cb_setActionDividerInsetAndThickness_III == null)
				cb_setActionDividerInsetAndThickness_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_L) n_SetActionDividerInsetAndThickness_III);
			return cb_setActionDividerInsetAndThickness_III;
		}

		static IntPtr n_SetActionDividerInsetAndThickness_III (IntPtr jnienv, IntPtr native__this, int thickness, int startInset, int endInset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetActionDividerInsetAndThickness (thickness, startInset, endInset));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setActionDividerInsetAndThickness' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setActionDividerInsetAndThickness", "(III)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetActionDividerInsetAndThickness_IIIHandler")]
		public virtual unsafe global::Java.Lang.Object SetActionDividerInsetAndThickness (int thickness, int startInset, int endInset)
		{
			const string __id = "setActionDividerInsetAndThickness.(III)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (thickness);
				__args [1] = new JniArgumentValue (startInset);
				__args [2] = new JniArgumentValue (endInset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCancelable_Z;
#pragma warning disable 0169
		static Delegate GetSetCancelable_ZHandler ()
		{
			if (cb_setCancelable_Z == null)
				cb_setCancelable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCancelable_Z);
			return cb_setCancelable_Z;
		}

		static IntPtr n_SetCancelable_Z (IntPtr jnienv, IntPtr native__this, bool cancelable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCancelable (cancelable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setCancelable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCancelable", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetCancelable_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetCancelable (bool cancelable)
		{
			const string __id = "setCancelable.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cancelable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCanceledOnTouchOutside_Z;
#pragma warning disable 0169
		static Delegate GetSetCanceledOnTouchOutside_ZHandler ()
		{
			if (cb_setCanceledOnTouchOutside_Z == null)
				cb_setCanceledOnTouchOutside_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCanceledOnTouchOutside_Z);
			return cb_setCanceledOnTouchOutside_Z;
		}

		static IntPtr n_SetCanceledOnTouchOutside_Z (IntPtr jnienv, IntPtr native__this, bool canceledOnTouchOutside)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCanceledOnTouchOutside (canceledOnTouchOutside));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setCanceledOnTouchOutside' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCanceledOnTouchOutside", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetCanceledOnTouchOutside_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetCanceledOnTouchOutside (bool canceledOnTouchOutside)
		{
			const string __id = "setCanceledOnTouchOutside.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (canceledOnTouchOutside);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setChangeAlphaForPressOrDisable_Z;
#pragma warning disable 0169
		static Delegate GetSetChangeAlphaForPressOrDisable_ZHandler ()
		{
			if (cb_setChangeAlphaForPressOrDisable_Z == null)
				cb_setChangeAlphaForPressOrDisable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetChangeAlphaForPressOrDisable_Z);
			return cb_setChangeAlphaForPressOrDisable_Z;
		}

		static IntPtr n_SetChangeAlphaForPressOrDisable_Z (IntPtr jnienv, IntPtr native__this, bool changeAlphaForPressOrDisable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetChangeAlphaForPressOrDisable (changeAlphaForPressOrDisable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setChangeAlphaForPressOrDisable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChangeAlphaForPressOrDisable", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetChangeAlphaForPressOrDisable_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetChangeAlphaForPressOrDisable (bool changeAlphaForPressOrDisable)
		{
			const string __id = "setChangeAlphaForPressOrDisable.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (changeAlphaForPressOrDisable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCheckKeyboardOverlay_Z;
#pragma warning disable 0169
		static Delegate GetSetCheckKeyboardOverlay_ZHandler ()
		{
			if (cb_setCheckKeyboardOverlay_Z == null)
				cb_setCheckKeyboardOverlay_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetCheckKeyboardOverlay_Z);
			return cb_setCheckKeyboardOverlay_Z;
		}

		static IntPtr n_SetCheckKeyboardOverlay_Z (IntPtr jnienv, IntPtr native__this, bool checkKeyboardOverlay)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCheckKeyboardOverlay (checkKeyboardOverlay));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setCheckKeyboardOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCheckKeyboardOverlay", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetCheckKeyboardOverlay_ZHandler")]
		public virtual unsafe global::Java.Lang.Object SetCheckKeyboardOverlay (bool checkKeyboardOverlay)
		{
			const string __id = "setCheckKeyboardOverlay.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (checkKeyboardOverlay);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMaxPercent_F;
#pragma warning disable 0169
		static Delegate GetSetMaxPercent_FHandler ()
		{
			if (cb_setMaxPercent_F == null)
				cb_setMaxPercent_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_SetMaxPercent_F);
			return cb_setMaxPercent_F;
		}

		static IntPtr n_SetMaxPercent_F (IntPtr jnienv, IntPtr native__this, float maxPercent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxPercent (maxPercent));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setMaxPercent' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMaxPercent", "(F)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetMaxPercent_FHandler")]
		public virtual unsafe global::Java.Lang.Object SetMaxPercent (float maxPercent)
		{
			const string __id = "setMaxPercent.(F)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxPercent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_Handler ()
		{
			if (cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_ == null)
				cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_);
			return cb_setOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_;
		}

		static IntPtr n_SetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onDecorationListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onDecorationListener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener> (native_onDecorationListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnDecorationListener (onDecorationListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setOnDecorationListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView.OnDecorationListener']]"
		[Register ("setOnDecorationListener", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView$OnDecorationListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetOnDecorationListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_OnDecorationListener_Handler")]
		public virtual unsafe global::Java.Lang.Object SetOnDecorationListener (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView.IOnDecorationListener onDecorationListener)
		{
			const string __id = "setOnDecorationListener.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView$OnDecorationListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onDecorationListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onDecorationListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (onDecorationListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setOnProvideDefaultTheme' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogBuilder.OnProvideDefaultTheme']]"
		[Register ("setOnProvideDefaultTheme", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$OnProvideDefaultTheme;)V", "")]
		public static unsafe void SetOnProvideDefaultTheme (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder.IOnProvideDefaultTheme onProvideDefaultTheme)
		{
			const string __id = "setOnProvideDefaultTheme.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder$OnProvideDefaultTheme;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onProvideDefaultTheme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onProvideDefaultTheme).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (onProvideDefaultTheme);
			}
		}

		static Delegate cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
#pragma warning disable 0169
		static Delegate GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler ()
		{
			if (cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ == null)
				cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_);
			return cb_setSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
		}

		static IntPtr n_SetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skinManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSkinManager (skinManager));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setSkinManager' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager']]"
		[Register ("setSkinManager", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler")]
		public virtual unsafe global::Java.Lang.Object SetSkinManager (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager)
		{
			const string __id = "setSkinManager.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (skinManager);
			}
		}

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static IntPtr n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitle (resId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitle", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetTitle_IHandler")]
		public virtual unsafe global::Java.Lang.Object SetTitle (int resId)
		{
			const string __id = "setTitle.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static IntPtr n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object SetTitle (string title)
		{
			const string __id = "setTitle.(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Show);
			return cb_show;
		}

		static IntPtr n_Show (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Show ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;", "GetShowHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog Show ()
		{
			const string __id = "show.()Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinConfigActionContainer_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetSkinConfigActionContainer_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_skinConfigActionContainer_Landroid_view_ViewGroup_ == null)
				cb_skinConfigActionContainer_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SkinConfigActionContainer_Landroid_view_ViewGroup_);
			return cb_skinConfigActionContainer_Landroid_view_ViewGroup_;
		}

		static void n_SkinConfigActionContainer_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actionContainer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var actionContainer = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_actionContainer, JniHandleOwnership.DoNotTransfer);
			__this.SkinConfigActionContainer (actionContainer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='skinConfigActionContainer' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("skinConfigActionContainer", "(Landroid/view/ViewGroup;)V", "GetSkinConfigActionContainer_Landroid_view_ViewGroup_Handler")]
		protected virtual unsafe void SkinConfigActionContainer (global::Android.Views.ViewGroup actionContainer)
		{
			const string __id = "skinConfigActionContainer.(Landroid/view/ViewGroup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((actionContainer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actionContainer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (actionContainer);
			}
		}

		static Delegate cb_skinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
#pragma warning disable 0169
		static Delegate GetSkinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Handler ()
		{
			if (cb_skinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ == null)
				cb_skinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SkinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_);
			return cb_skinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_;
		}

		static void n_SkinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dialogView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dialogView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView> (native_dialogView, JniHandleOwnership.DoNotTransfer);
			__this.SkinConfigDialogView (dialogView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='skinConfigDialogView' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView']]"
		[Register ("skinConfigDialogView", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;)V", "GetSkinConfigDialogView_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Handler")]
		protected virtual unsafe void SkinConfigDialogView (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView dialogView)
		{
			const string __id = "skinConfigDialogView.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dialogView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialogView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dialogView);
			}
		}

		static Delegate cb_skinConfigTitleView_Landroid_widget_TextView_;
#pragma warning disable 0169
		static Delegate GetSkinConfigTitleView_Landroid_widget_TextView_Handler ()
		{
			if (cb_skinConfigTitleView_Landroid_widget_TextView_ == null)
				cb_skinConfigTitleView_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SkinConfigTitleView_Landroid_widget_TextView_);
			return cb_skinConfigTitleView_Landroid_widget_TextView_;
		}

		static void n_SkinConfigTitleView_Landroid_widget_TextView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_titleView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var titleView = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_titleView, JniHandleOwnership.DoNotTransfer);
			__this.SkinConfigTitleView (titleView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='skinConfigTitleView' and count(parameter)=1 and parameter[1][@type='android.widget.TextView']]"
		[Register ("skinConfigTitleView", "(Landroid/widget/TextView;)V", "GetSkinConfigTitleView_Landroid_widget_TextView_Handler")]
		protected virtual unsafe void SkinConfigTitleView (global::Android.Widget.TextView titleView)
		{
			const string __id = "skinConfigTitleView.(Landroid/widget/TextView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((titleView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) titleView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (titleView);
			}
		}

		static Delegate cb_wrapWithScroll_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetWrapWithScroll_Landroid_view_View_Handler ()
		{
			if (cb_wrapWithScroll_Landroid_view_View_ == null)
				cb_wrapWithScroll_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WrapWithScroll_Landroid_view_View_);
			return cb_wrapWithScroll_Landroid_view_View_;
		}

		static IntPtr n_WrapWithScroll_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WrapWithScroll (view));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='wrapWithScroll' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("wrapWithScroll", "(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/QMUIWrapContentScrollView;", "GetWrapWithScroll_Landroid_view_View_Handler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.QMUIWrapContentScrollView WrapWithScroll (global::Android.Views.View view)
		{
			const string __id = "wrapWithScroll.(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/QMUIWrapContentScrollView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIWrapContentScrollView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder", DoNotGenerateAcw=true)]
	internal partial class QMUIDialogBuilderInvoker : QMUIDialogBuilder {

		public QMUIDialogBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogBuilder", typeof (QMUIDialogBuilderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogBuilder']/method[@name='onCreateContent' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialog'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogView'] and parameter[3][@type='android.content.Context']]"
		[Register ("onCreateContent", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateContent_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialog_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogView_Landroid_content_Context_Handler")]
		protected override unsafe global::Android.Views.View OnCreateContent (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialog p0, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogView p1, global::Android.Content.Context p2)
		{
			const string __id = "onCreateContent.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialog;Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogView;Landroid/content/Context;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}

}
