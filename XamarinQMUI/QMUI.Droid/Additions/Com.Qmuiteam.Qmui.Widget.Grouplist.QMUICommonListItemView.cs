using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Grouplist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView", DoNotGenerateAcw=true)]
	public partial class QMUICommonListItemView : global::Com.Qmuiteam.Qmui.Layout.QMUIConstraintLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='ACCESSORY_TYPE_CHEVRON']"
		[Register ("ACCESSORY_TYPE_CHEVRON")]
		public const int AccessoryTypeChevron = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='ACCESSORY_TYPE_CUSTOM']"
		[Register ("ACCESSORY_TYPE_CUSTOM")]
		public const int AccessoryTypeCustom = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='ACCESSORY_TYPE_NONE']"
		[Register ("ACCESSORY_TYPE_NONE")]
		public const int AccessoryTypeNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='ACCESSORY_TYPE_SWITCH']"
		[Register ("ACCESSORY_TYPE_SWITCH")]
		public const int AccessoryTypeSwitch = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='HORIZONTAL']"
		[Register ("HORIZONTAL")]
		public const int Horizontal = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='TIP_POSITION_LEFT']"
		[Register ("TIP_POSITION_LEFT")]
		public const int TipPositionLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='TIP_POSITION_RIGHT']"
		[Register ("TIP_POSITION_RIGHT")]
		public const int TipPositionRight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='VERTICAL']"
		[Register ("VERTICAL")]
		public const int Vertical = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='mDetailTextView']"
		[Register ("mDetailTextView")]
		protected global::Android.Widget.TextView MDetailTextView {
			get {
				const string __id = "mDetailTextView.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDetailTextView.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='mImageView']"
		[Register ("mImageView")]
		protected global::Android.Widget.ImageView MImageView {
			get {
				const string __id = "mImageView.Landroid/widget/ImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mImageView.Landroid/widget/ImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='mSwitch']"
		[Register ("mSwitch")]
		protected global::Android.Widget.CheckBox MSwitch {
			get {
				const string __id = "mSwitch.Landroid/widget/CheckBox;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.CheckBox> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSwitch.Landroid/widget/CheckBox;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/field[@name='mTextView']"
		[Register ("mTextView")]
		protected global::Android.Widget.TextView MTextView {
			get {
				const string __id = "mTextView.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTextView.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/interface[@name='QMUICommonListItemView.LayoutParamConfig']"
		[Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$LayoutParamConfig", "", "Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView/ILayoutParamConfigInvoker")]
		public partial interface ILayoutParamConfig : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/interface[@name='QMUICommonListItemView.LayoutParamConfig']/method[@name='onConfig' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
			[Register ("onConfig", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;", "GetOnConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Handler:Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView/ILayoutParamConfigInvoker, QMUI.Droid")]
			global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams OnConfig (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams p0);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$LayoutParamConfig", DoNotGenerateAcw=true)]
		internal partial class ILayoutParamConfigInvoker : global::Java.Lang.Object, ILayoutParamConfig {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$LayoutParamConfig", typeof (ILayoutParamConfigInvoker));

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

			public static ILayoutParamConfig GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILayoutParamConfig> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView.LayoutParamConfig"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILayoutParamConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_;
#pragma warning disable 0169
			static Delegate GetOnConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Handler ()
			{
				if (cb_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ == null)
					cb_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_);
				return cb_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_;
			}

			static IntPtr n_OnConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.ILayoutParamConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnConfig (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_;
			public unsafe global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams OnConfig (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams p0)
			{
				if (id_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ == IntPtr.Zero)
					id_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "onConfig", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __ret = global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onConfig_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/interface[@name='QMUICommonListItemView.QMUICommonListItemAccessoryType']"
		[Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemAccessoryType", "", "Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView/IQMUICommonListItemAccessoryTypeInvoker")]
		public partial interface IQMUICommonListItemAccessoryType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemAccessoryType", DoNotGenerateAcw=true)]
		internal partial class IQMUICommonListItemAccessoryTypeInvoker : global::Java.Lang.Object, IQMUICommonListItemAccessoryType {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemAccessoryType", typeof (IQMUICommonListItemAccessoryTypeInvoker));

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

			public static IQMUICommonListItemAccessoryType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQMUICommonListItemAccessoryType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView.QMUICommonListItemAccessoryType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQMUICommonListItemAccessoryTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemAccessoryType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemAccessoryType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemAccessoryType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemAccessoryType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/interface[@name='QMUICommonListItemView.QMUICommonListItemOrientation']"
		[Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemOrientation", "", "Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView/IQMUICommonListItemOrientationInvoker")]
		public partial interface IQMUICommonListItemOrientation : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemOrientation", DoNotGenerateAcw=true)]
		internal partial class IQMUICommonListItemOrientationInvoker : global::Java.Lang.Object, IQMUICommonListItemOrientation {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemOrientation", typeof (IQMUICommonListItemOrientationInvoker));

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

			public static IQMUICommonListItemOrientation GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQMUICommonListItemOrientation> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView.QMUICommonListItemOrientation"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQMUICommonListItemOrientationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemOrientation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/interface[@name='QMUICommonListItemView.QMUICommonListItemTipPosition']"
		[Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemTipPosition", "", "Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView/IQMUICommonListItemTipPositionInvoker")]
		public partial interface IQMUICommonListItemTipPosition : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemTipPosition", DoNotGenerateAcw=true)]
		internal partial class IQMUICommonListItemTipPositionInvoker : global::Java.Lang.Object, IQMUICommonListItemTipPosition {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$QMUICommonListItemTipPosition", typeof (IQMUICommonListItemTipPositionInvoker));

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

			public static IQMUICommonListItemTipPosition GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQMUICommonListItemTipPosition> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView.QMUICommonListItemTipPosition"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQMUICommonListItemTipPositionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemTipPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemTipPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemTipPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.IQMUICommonListItemTipPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$SkinConfig", DoNotGenerateAcw=true)]
		public partial class SkinConfig : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']/field[@name='detailTextColorRes']"
			[Register ("detailTextColorRes")]
			public int DetailTextColorRes {
				get {
					const string __id = "detailTextColorRes.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "detailTextColorRes.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']/field[@name='iconSrcRes']"
			[Register ("iconSrcRes")]
			public int IconSrcRes {
				get {
					const string __id = "iconSrcRes.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "iconSrcRes.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']/field[@name='iconTintColorRes']"
			[Register ("iconTintColorRes")]
			public int IconTintColorRes {
				get {
					const string __id = "iconTintColorRes.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "iconTintColorRes.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']/field[@name='newTipSrcRes']"
			[Register ("newTipSrcRes")]
			public int NewTipSrcRes {
				get {
					const string __id = "newTipSrcRes.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "newTipSrcRes.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']/field[@name='tipDotColorRes']"
			[Register ("tipDotColorRes")]
			public int TipDotColorRes {
				get {
					const string __id = "tipDotColorRes.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "tipDotColorRes.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']/field[@name='titleTextColorRes']"
			[Register ("titleTextColorRes")]
			public int TitleTextColorRes {
				get {
					const string __id = "titleTextColorRes.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "titleTextColorRes.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$SkinConfig", typeof (SkinConfig));
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

			protected SkinConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView.SkinConfig']/constructor[@name='QMUICommonListItemView.SkinConfig' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SkinConfig ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView", typeof (QMUICommonListItemView));
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

		protected QMUICommonListItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/constructor[@name='QMUICommonListItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUICommonListItemView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/constructor[@name='QMUICommonListItemView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUICommonListItemView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/constructor[@name='QMUICommonListItemView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUICommonListItemView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getAccessoryContainerView;
#pragma warning disable 0169
		static Delegate GetGetAccessoryContainerViewHandler ()
		{
			if (cb_getAccessoryContainerView == null)
				cb_getAccessoryContainerView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAccessoryContainerView);
			return cb_getAccessoryContainerView;
		}

		static IntPtr n_GetAccessoryContainerView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccessoryContainerView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.ViewGroup AccessoryContainerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getAccessoryContainerView' and count(parameter)=0]"
			[Register ("getAccessoryContainerView", "()Landroid/view/ViewGroup;", "GetGetAccessoryContainerViewHandler")]
			get {
				const string __id = "getAccessoryContainerView.()Landroid/view/ViewGroup;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAccessoryType;
#pragma warning disable 0169
		static Delegate GetGetAccessoryTypeHandler ()
		{
			if (cb_getAccessoryType == null)
				cb_getAccessoryType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAccessoryType);
			return cb_getAccessoryType;
		}

		static int n_GetAccessoryType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccessoryType;
		}
#pragma warning restore 0169

		static Delegate cb_setAccessoryType_I;
#pragma warning disable 0169
		static Delegate GetSetAccessoryType_IHandler ()
		{
			if (cb_setAccessoryType_I == null)
				cb_setAccessoryType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAccessoryType_I);
			return cb_setAccessoryType_I;
		}

		static void n_SetAccessoryType_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AccessoryType = type;
		}
#pragma warning restore 0169

		public virtual unsafe int AccessoryType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getAccessoryType' and count(parameter)=0]"
			[Register ("getAccessoryType", "()I", "GetGetAccessoryTypeHandler")]
			get {
				const string __id = "getAccessoryType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setAccessoryType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAccessoryType", "(I)V", "GetSetAccessoryType_IHandler")]
			set {
				const string __id = "setAccessoryType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDetailText;
#pragma warning disable 0169
		static Delegate GetGetDetailTextHandler ()
		{
			if (cb_getDetailText == null)
				cb_getDetailText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDetailText);
			return cb_getDetailText;
		}

		static IntPtr n_GetDetailText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.DetailTextFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setDetailText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetDetailText_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setDetailText_Ljava_lang_CharSequence_ == null)
				cb_setDetailText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDetailText_Ljava_lang_CharSequence_);
			return cb_setDetailText_Ljava_lang_CharSequence_;
		}

		static void n_SetDetailText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.DetailTextFormatted = text;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence DetailTextFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getDetailText' and count(parameter)=0]"
			[Register ("getDetailText", "()Ljava/lang/CharSequence;", "GetGetDetailTextHandler")]
			get {
				const string __id = "getDetailText.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setDetailText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setDetailText", "(Ljava/lang/CharSequence;)V", "GetSetDetailText_Ljava_lang_CharSequence_Handler")]
			set {
				const string __id = "setDetailText.(Ljava/lang/CharSequence;)V";
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

		public string DetailText {
			get { return DetailTextFormatted == null ? null : DetailTextFormatted.ToString (); }
			set {
				var jls = value == null ? null : new global::Java.Lang.String (value);
				DetailTextFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_getDetailTextView;
#pragma warning disable 0169
		static Delegate GetGetDetailTextViewHandler ()
		{
			if (cb_getDetailTextView == null)
				cb_getDetailTextView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDetailTextView);
			return cb_getDetailTextView;
		}

		static IntPtr n_GetDetailTextView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DetailTextView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView DetailTextView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getDetailTextView' and count(parameter)=0]"
			[Register ("getDetailTextView", "()Landroid/widget/TextView;", "GetGetDetailTextViewHandler")]
			get {
				const string __id = "getDetailTextView.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_IHandler ()
		{
			if (cb_setOrientation_I == null)
				cb_setOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetOrientation_I);
			return cb_setOrientation_I;
		}

		static void n_SetOrientation_I (IntPtr jnienv, IntPtr native__this, int orientation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = orientation;
		}
#pragma warning restore 0169

		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				const string __id = "getOrientation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
			set {
				const string __id = "setOrientation.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSwitch;
#pragma warning disable 0169
		static Delegate GetGetSwitchHandler ()
		{
			if (cb_getSwitch == null)
				cb_getSwitch = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSwitch);
			return cb_getSwitch;
		}

		static IntPtr n_GetSwitch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Switch);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.CheckBox Switch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getSwitch' and count(parameter)=0]"
			[Register ("getSwitch", "()Landroid/widget/CheckBox;", "GetGetSwitchHandler")]
			get {
				const string __id = "getSwitch.()Landroid/widget/CheckBox;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.CheckBox> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.TextFormatted = text;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence TextFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
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

		static Delegate cb_getTextView;
#pragma warning disable 0169
		static Delegate GetGetTextViewHandler ()
		{
			if (cb_getTextView == null)
				cb_getTextView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTextView);
			return cb_getTextView;
		}

		static IntPtr n_GetTextView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView TextView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='getTextView' and count(parameter)=0]"
			[Register ("getTextView", "()Landroid/widget/TextView;", "GetGetTextViewHandler")]
			get {
				const string __id = "getTextView.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addAccessoryCustomView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetAddAccessoryCustomView_Landroid_view_View_Handler ()
		{
			if (cb_addAccessoryCustomView_Landroid_view_View_ == null)
				cb_addAccessoryCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddAccessoryCustomView_Landroid_view_View_);
			return cb_addAccessoryCustomView_Landroid_view_View_;
		}

		static void n_AddAccessoryCustomView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.AddAccessoryCustomView (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='addAccessoryCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("addAccessoryCustomView", "(Landroid/view/View;)V", "GetAddAccessoryCustomView_Landroid_view_View_Handler")]
		public virtual unsafe void AddAccessoryCustomView (global::Android.Views.View view)
		{
			const string __id = "addAccessoryCustomView.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_init_Landroid_content_Context_Landroid_util_AttributeSet_I;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Landroid_util_AttributeSet_IHandler ()
		{
			if (cb_init_Landroid_content_Context_Landroid_util_AttributeSet_I == null)
				cb_init_Landroid_content_Context_Landroid_util_AttributeSet_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Init_Landroid_content_Context_Landroid_util_AttributeSet_I);
			return cb_init_Landroid_content_Context_Landroid_util_AttributeSet_I;
		}

		static void n_Init_Landroid_content_Context_Landroid_util_AttributeSet_I (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_attrs, int defStyleAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var attrs = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_attrs, JniHandleOwnership.DoNotTransfer);
			__this.Init (context, attrs, defStyleAttr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register ("init", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "GetInit_Landroid_content_Context_Landroid_util_AttributeSet_IHandler")]
		protected virtual unsafe void Init (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
		{
			const string __id = "init.(Landroid/content/Context;Landroid/util/AttributeSet;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_setDisableSwitchSelf_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableSwitchSelf_ZHandler ()
		{
			if (cb_setDisableSwitchSelf_Z == null)
				cb_setDisableSwitchSelf_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDisableSwitchSelf_Z);
			return cb_setDisableSwitchSelf_Z;
		}

		static void n_SetDisableSwitchSelf_Z (IntPtr jnienv, IntPtr native__this, bool disableSwitchSelf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisableSwitchSelf (disableSwitchSelf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setDisableSwitchSelf' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableSwitchSelf", "(Z)V", "GetSetDisableSwitchSelf_ZHandler")]
		public virtual unsafe void SetDisableSwitchSelf (bool disableSwitchSelf)
		{
			const string __id = "setDisableSwitchSelf.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disableSwitchSelf);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImageDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetImageDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setImageDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setImageDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetImageDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setImageDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetImageDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetImageDrawable (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetImageDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetImageDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setImageDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (drawable);
			}
		}

		static Delegate cb_setSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_;
#pragma warning disable 0169
		static Delegate GetSetSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_Handler ()
		{
			if (cb_setSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_ == null)
				cb_setSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_);
			return cb_setSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_;
		}

		static void n_SetSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skinConfig)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinConfig = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.SkinConfig> (native_skinConfig, JniHandleOwnership.DoNotTransfer);
			__this.SetSkinConfig (skinConfig);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setSkinConfig' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView.SkinConfig']]"
		[Register ("setSkinConfig", "(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$SkinConfig;)V", "GetSetSkinConfig_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_SkinConfig_Handler")]
		public virtual unsafe void SetSkinConfig (global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.SkinConfig skinConfig)
		{
			const string __id = "setSkinConfig.(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$SkinConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((skinConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinConfig).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (skinConfig);
			}
		}

		static Delegate cb_setTipPosition_I;
#pragma warning disable 0169
		static Delegate GetSetTipPosition_IHandler ()
		{
			if (cb_setTipPosition_I == null)
				cb_setTipPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTipPosition_I);
			return cb_setTipPosition_I;
		}

		static void n_SetTipPosition_I (IntPtr jnienv, IntPtr native__this, int tipPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipPosition (tipPosition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='setTipPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTipPosition", "(I)V", "GetSetTipPosition_IHandler")]
		public virtual unsafe void SetTipPosition (int tipPosition)
		{
			const string __id = "setTipPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tipPosition);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showNewTip_Z;
#pragma warning disable 0169
		static Delegate GetShowNewTip_ZHandler ()
		{
			if (cb_showNewTip_Z == null)
				cb_showNewTip_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_ShowNewTip_Z);
			return cb_showNewTip_Z;
		}

		static void n_ShowNewTip_Z (IntPtr jnienv, IntPtr native__this, bool isShow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowNewTip (isShow);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='showNewTip' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showNewTip", "(Z)V", "GetShowNewTip_ZHandler")]
		public virtual unsafe void ShowNewTip (bool isShow)
		{
			const string __id = "showNewTip.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isShow);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showRedDot_Z;
#pragma warning disable 0169
		static Delegate GetShowRedDot_ZHandler ()
		{
			if (cb_showRedDot_Z == null)
				cb_showRedDot_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_ShowRedDot_Z);
			return cb_showRedDot_Z;
		}

		static void n_ShowRedDot_Z (IntPtr jnienv, IntPtr native__this, bool isShow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowRedDot (isShow);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='showRedDot' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showRedDot", "(Z)V", "GetShowRedDot_ZHandler")]
		public virtual unsafe void ShowRedDot (bool isShow)
		{
			const string __id = "showRedDot.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isShow);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_;
#pragma warning disable 0169
		static Delegate GetUpdateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_Handler ()
		{
			if (cb_updateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_ == null)
				cb_updateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_);
			return cb_updateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_;
		}

		static void n_UpdateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lpConfig)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lpConfig = (global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.ILayoutParamConfig)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.ILayoutParamConfig> (native_lpConfig, JniHandleOwnership.DoNotTransfer);
			__this.UpdateImageViewLp (lpConfig);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUICommonListItemView']/method[@name='updateImageViewLp' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.grouplist.QMUICommonListItemView.LayoutParamConfig']]"
		[Register ("updateImageViewLp", "(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$LayoutParamConfig;)V", "GetUpdateImageViewLp_Lcom_qmuiteam_qmui_widget_grouplist_QMUICommonListItemView_LayoutParamConfig_Handler")]
		public virtual unsafe void UpdateImageViewLp (global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUICommonListItemView.ILayoutParamConfig lpConfig)
		{
			const string __id = "updateImageViewLp.(Lcom/qmuiteam/qmui/widget/grouplist/QMUICommonListItemView$LayoutParamConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lpConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lpConfig).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (lpConfig);
			}
		}

	}
}
