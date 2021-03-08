using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog", DoNotGenerateAcw=true)]
	public partial class QMUITipDialog : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBaseDialog {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/field[@name='ICON_TYPE_FAIL']"
			[Register ("ICON_TYPE_FAIL")]
			public const int IconTypeFail = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/field[@name='ICON_TYPE_INFO']"
			[Register ("ICON_TYPE_INFO")]
			public const int IconTypeInfo = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/field[@name='ICON_TYPE_LOADING']"
			[Register ("ICON_TYPE_LOADING")]
			public const int IconTypeLoading = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/field[@name='ICON_TYPE_NOTHING']"
			[Register ("ICON_TYPE_NOTHING")]
			public const int IconTypeNothing = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/field[@name='ICON_TYPE_SUCCESS']"
			[Register ("ICON_TYPE_SUCCESS")]
			public const int IconTypeSuccess = (int) 2;
			// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUITipDialog.Builder.IconType']"
			[Register ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder$IconType", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog/Builder/IIconTypeInvoker")]
			public partial interface IIconType : global::Java.Lang.Annotation.IAnnotation {

			}

			[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder$IconType", DoNotGenerateAcw=true)]
			internal partial class IIconTypeInvoker : global::Java.Lang.Object, IIconType {

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder$IconType", typeof (IIconTypeInvoker));

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

				public static IIconType GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IIconType> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUITipDialog.Builder.IconType"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IIconTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder.IIconType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder.IIconType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder.IIconType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder.IIconType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/constructor[@name='QMUITipDialog.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder (global::Android.Content.Context context)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='create' and count(parameter)=0]"
			[Register ("create", "()Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;", "GetCreateHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog Create ()
			{
				const string __id = "create.()Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_create_Z;
#pragma warning disable 0169
			static Delegate GetCreate_ZHandler ()
			{
				if (cb_create_Z == null)
					cb_create_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Create_Z);
				return cb_create_Z;
			}

			static IntPtr n_Create_Z (IntPtr jnienv, IntPtr native__this, bool cancelable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create (cancelable));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='create' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("create", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;", "GetCreate_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog Create (bool cancelable)
			{
				const string __id = "create.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (cancelable);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_create_ZI;
#pragma warning disable 0169
			static Delegate GetCreate_ZIHandler ()
			{
				if (cb_create_ZI == null)
					cb_create_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZI_L) n_Create_ZI);
				return cb_create_ZI;
			}

			static IntPtr n_Create_ZI (IntPtr jnienv, IntPtr native__this, bool cancelable, int style)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create (cancelable, style));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='create' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
			[Register ("create", "(ZI)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;", "GetCreate_ZIHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog Create (bool cancelable, int style)
			{
				const string __id = "create.(ZI)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (cancelable);
					__args [1] = new JniArgumentValue (style);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_onCreateIconOrLoadingLayoutParams_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetOnCreateIconOrLoadingLayoutParams_Landroid_content_Context_Handler ()
			{
				if (cb_onCreateIconOrLoadingLayoutParams_Landroid_content_Context_ == null)
					cb_onCreateIconOrLoadingLayoutParams_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateIconOrLoadingLayoutParams_Landroid_content_Context_);
				return cb_onCreateIconOrLoadingLayoutParams_Landroid_content_Context_;
			}

			static IntPtr n_OnCreateIconOrLoadingLayoutParams_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateIconOrLoadingLayoutParams (context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='onCreateIconOrLoadingLayoutParams' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("onCreateIconOrLoadingLayoutParams", "(Landroid/content/Context;)Landroid/widget/LinearLayout$LayoutParams;", "GetOnCreateIconOrLoadingLayoutParams_Landroid_content_Context_Handler")]
			protected virtual unsafe global::Android.Widget.LinearLayout.LayoutParams OnCreateIconOrLoadingLayoutParams (global::Android.Content.Context context)
			{
				const string __id = "onCreateIconOrLoadingLayoutParams.(Landroid/content/Context;)Landroid/widget/LinearLayout$LayoutParams;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_onCreateTextLayoutParams_Landroid_content_Context_I;
#pragma warning disable 0169
			static Delegate GetOnCreateTextLayoutParams_Landroid_content_Context_IHandler ()
			{
				if (cb_onCreateTextLayoutParams_Landroid_content_Context_I == null)
					cb_onCreateTextLayoutParams_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_OnCreateTextLayoutParams_Landroid_content_Context_I);
				return cb_onCreateTextLayoutParams_Landroid_content_Context_I;
			}

			static IntPtr n_OnCreateTextLayoutParams_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int iconType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateTextLayoutParams (context, iconType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='onCreateTextLayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
			[Register ("onCreateTextLayoutParams", "(Landroid/content/Context;I)Landroid/widget/LinearLayout$LayoutParams;", "GetOnCreateTextLayoutParams_Landroid_content_Context_IHandler")]
			protected virtual unsafe global::Android.Widget.LinearLayout.LayoutParams OnCreateTextLayoutParams (global::Android.Content.Context context, int iconType)
			{
				const string __id = "onCreateTextLayoutParams.(Landroid/content/Context;I)Landroid/widget/LinearLayout$LayoutParams;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (iconType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_setIconType_I;
#pragma warning disable 0169
			static Delegate GetSetIconType_IHandler ()
			{
				if (cb_setIconType_I == null)
					cb_setIconType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetIconType_I);
				return cb_setIconType_I;
			}

			static IntPtr n_SetIconType_I (IntPtr jnienv, IntPtr native__this, int iconType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetIconType (iconType));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='setIconType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIconType", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder;", "GetSetIconType_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder SetIconType (int iconType)
			{
				const string __id = "setIconType.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (iconType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSkinManager (skinManager));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='setSkinManager' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager']]"
			[Register ("setSkinManager", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder;", "GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder SetSkinManager (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager)
			{
				const string __id = "setSkinManager.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (skinManager);
				}
			}

			static Delegate cb_setTipWord_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetTipWord_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setTipWord_Ljava_lang_CharSequence_ == null)
					cb_setTipWord_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTipWord_Ljava_lang_CharSequence_);
				return cb_setTipWord_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetTipWord_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tipWord)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tipWord = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_tipWord, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTipWord (tipWord));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.Builder']/method[@name='setTipWord' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTipWord", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder;", "GetSetTipWord_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder SetTipWord (global::Java.Lang.ICharSequence tipWord)
			{
				const string __id = "setTipWord.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$Builder;";
				IntPtr native_tipWord = CharSequence.ToLocalJniHandle (tipWord);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_tipWord);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_tipWord);
					global::System.GC.KeepAlive (tipWord);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder SetTipWord (string tipWord)
			{
				var jls_tipWord = tipWord == null ? null : new global::Java.Lang.String (tipWord);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.Builder __result = SetTipWord (jls_tipWord);
				var __rsval = __result;
				jls_tipWord?.Dispose ();
				return __rsval;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.CustomBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog$CustomBuilder", DoNotGenerateAcw=true)]
		public partial class CustomBuilder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog$CustomBuilder", typeof (CustomBuilder));
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

			protected CustomBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.CustomBuilder']/constructor[@name='QMUITipDialog.CustomBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe CustomBuilder (global::Android.Content.Context context)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.CustomBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.CustomBuilder']/method[@name='create' and count(parameter)=0]"
			[Register ("create", "()Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;", "GetCreateHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog Create ()
			{
				const string __id = "create.()Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setContent_I;
#pragma warning disable 0169
			static Delegate GetSetContent_IHandler ()
			{
				if (cb_setContent_I == null)
					cb_setContent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetContent_I);
				return cb_setContent_I;
			}

			static IntPtr n_SetContent_I (IntPtr jnienv, IntPtr native__this, int layoutId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.CustomBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetContent (layoutId));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.CustomBuilder']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setContent", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$CustomBuilder;", "GetSetContent_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.CustomBuilder SetContent (int layoutId)
			{
				const string __id = "setContent.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$CustomBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (layoutId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.CustomBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.CustomBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSkinManager (skinManager));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog.CustomBuilder']/method[@name='setSkinManager' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager']]"
			[Register ("setSkinManager", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$CustomBuilder;", "GetSetSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.CustomBuilder SetSkinManager (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager)
			{
				const string __id = "setSkinManager.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/dialog/QMUITipDialog$CustomBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUITipDialog.CustomBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (skinManager);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUITipDialog", typeof (QMUITipDialog));
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

		protected QMUITipDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog']/constructor[@name='QMUITipDialog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUITipDialog (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUITipDialog']/constructor[@name='QMUITipDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe QMUITipDialog (global::Android.Content.Context context, int themeResId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (themeResId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
