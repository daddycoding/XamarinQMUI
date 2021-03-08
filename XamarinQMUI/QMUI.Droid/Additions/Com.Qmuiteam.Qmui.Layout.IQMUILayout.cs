using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Layout {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout.HideRadiusSide']"
	[Register ("com/qmuiteam/qmui/layout/IQMUILayout$HideRadiusSide", "", "Com.Qmuiteam.Qmui.Layout.IQMUILayoutHideRadiusSideInvoker")]
	public partial interface IQMUILayoutHideRadiusSide : global::Java.Lang.Annotation.IAnnotation {

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/layout/IQMUILayout$HideRadiusSide", DoNotGenerateAcw=true)]
	internal partial class IQMUILayoutHideRadiusSideInvoker : global::Java.Lang.Object, IQMUILayoutHideRadiusSide {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/layout/IQMUILayout$HideRadiusSide", typeof (IQMUILayoutHideRadiusSideInvoker));

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

		public static IQMUILayoutHideRadiusSide GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUILayoutHideRadiusSide> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.layout.IQMUILayout.HideRadiusSide"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUILayoutHideRadiusSideInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayoutHideRadiusSide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayoutHideRadiusSide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayoutHideRadiusSide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayoutHideRadiusSide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


	[Register ("com/qmuiteam/qmui/layout/IQMUILayout", DoNotGenerateAcw=true)]
	public abstract class QMUILayout : Java.Lang.Object {

		internal QMUILayout ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_BOTTOM']"
		[Register ("HIDE_RADIUS_SIDE_BOTTOM")]
		public const int HideRadiusSideBottom = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_LEFT']"
		[Register ("HIDE_RADIUS_SIDE_LEFT")]
		public const int HideRadiusSideLeft = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_NONE']"
		[Register ("HIDE_RADIUS_SIDE_NONE")]
		public const int HideRadiusSideNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_RIGHT']"
		[Register ("HIDE_RADIUS_SIDE_RIGHT")]
		public const int HideRadiusSideRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_TOP']"
		[Register ("HIDE_RADIUS_SIDE_TOP")]
		public const int HideRadiusSideTop = (int) 1;
	}

	[Register ("com/qmuiteam/qmui/layout/IQMUILayout", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'QMUILayout' type. This type will be removed in a future release.", error: true)]
	public abstract class QMUILayoutConsts : QMUILayout {

		private QMUILayoutConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']"
	[Register ("com/qmuiteam/qmui/layout/IQMUILayout", "", "Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker")]
	public partial interface IQMUILayout : IJavaObject, IJavaPeerable {

		bool HasBorder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='hasBorder' and count(parameter)=0]"
			[Register ("hasBorder", "()Z", "GetHasBorderHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
		}

		bool HasBottomSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='hasBottomSeparator' and count(parameter)=0]"
			[Register ("hasBottomSeparator", "()Z", "GetHasBottomSeparatorHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
		}

		bool HasLeftSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='hasLeftSeparator' and count(parameter)=0]"
			[Register ("hasLeftSeparator", "()Z", "GetHasLeftSeparatorHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
		}

		bool HasRightSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='hasRightSeparator' and count(parameter)=0]"
			[Register ("hasRightSeparator", "()Z", "GetHasRightSeparatorHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
		}

		bool HasTopSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='hasTopSeparator' and count(parameter)=0]"
			[Register ("hasTopSeparator", "()Z", "GetHasTopSeparatorHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
		}

		int HideRadiusSide {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='getHideRadiusSide' and count(parameter)=0]"
			[Register ("getHideRadiusSide", "()I", "GetGetHideRadiusSideHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setHideRadiusSide' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHideRadiusSide", "(I)V", "GetSetHideRadiusSide_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] set;
		}

		int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] set;
		}

		float ShadowAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='getShadowAlpha' and count(parameter)=0]"
			[Register ("getShadowAlpha", "()F", "GetGetShadowAlphaHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setShadowAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setShadowAlpha", "(F)V", "GetSetShadowAlpha_FHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] set;
		}

		int ShadowColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='getShadowColor' and count(parameter)=0]"
			[Register ("getShadowColor", "()I", "GetGetShadowColorHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowColor", "(I)V", "GetSetShadowColor_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] set;
		}

		int ShadowElevation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='getShadowElevation' and count(parameter)=0]"
			[Register ("getShadowElevation", "()I", "GetGetShadowElevationHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setShadowElevation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowElevation", "(I)V", "GetSetShadowElevation_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='onlyShowBottomDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowBottomDivider", "(IIII)V", "GetOnlyShowBottomDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void OnlyShowBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='onlyShowLeftDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowLeftDivider", "(IIII)V", "GetOnlyShowLeftDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void OnlyShowLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='onlyShowRightDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowRightDivider", "(IIII)V", "GetOnlyShowRightDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void OnlyShowRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='onlyShowTopDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowTopDivider", "(IIII)V", "GetOnlyShowTopDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void OnlyShowTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetBorderColor (int borderColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderWidth", "(I)V", "GetSetBorderWidth_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetBorderWidth (int borderWidth);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setBottomDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBottomDividerAlpha", "(I)V", "GetSetBottomDividerAlpha_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetBottomDividerAlpha (int dividerAlpha);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setHeightLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeightLimit", "(I)Z", "GetSetHeightLimit_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		bool SetHeightLimit (int heightLimit);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setLeftDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLeftDividerAlpha", "(I)V", "GetSetLeftDividerAlpha_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetLeftDividerAlpha (int dividerAlpha);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setOuterNormalColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOuterNormalColor", "(I)V", "GetSetOuterNormalColor_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetOuterNormalColor (int color);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setOutlineExcludePadding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOutlineExcludePadding", "(Z)V", "GetSetOutlineExcludePadding_ZHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetOutlineExcludePadding (bool outlineExcludePadding);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setOutlineInset' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setOutlineInset", "(IIII)V", "GetSetOutlineInset_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetOutlineInset (int left, int top, int right, int bottom);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setRadius' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setRadius", "(II)V", "GetSetRadius_IIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetRadius (int radius, int hideRadiusSide);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setRadiusAndShadow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIF)V", "GetSetRadiusAndShadow_IIFHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetRadiusAndShadow (int radius, int shadowElevation, float shadowAlpha);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setRadiusAndShadow' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIIF)V", "GetSetRadiusAndShadow_IIIFHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, float shadowAlpha);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setRadiusAndShadow' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIIIF)V", "GetSetRadiusAndShadow_IIIIFHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, int shadowColor, float shadowAlpha);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setRightDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRightDividerAlpha", "(I)V", "GetSetRightDividerAlpha_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetRightDividerAlpha (int dividerAlpha);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setShowBorderOnlyBeforeL' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowBorderOnlyBeforeL", "(Z)V", "GetSetShowBorderOnlyBeforeL_ZHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetShowBorderOnlyBeforeL (bool showBorderOnlyBeforeL);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setTopDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTopDividerAlpha", "(I)V", "GetSetTopDividerAlpha_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetTopDividerAlpha (int dividerAlpha);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setUseThemeGeneralShadowElevation' and count(parameter)=0]"
		[Register ("setUseThemeGeneralShadowElevation", "()V", "GetSetUseThemeGeneralShadowElevationHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void SetUseThemeGeneralShadowElevation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='setWidthLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWidthLimit", "(I)Z", "GetSetWidthLimit_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		bool SetWidthLimit (int widthLimit);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateBottomDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateBottomDivider", "(IIII)V", "GetUpdateBottomDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateBottomSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateBottomSeparatorColor", "(I)V", "GetUpdateBottomSeparatorColor_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateBottomSeparatorColor (int color);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateLeftDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateLeftDivider", "(IIII)V", "GetUpdateLeftDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateLeftSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateLeftSeparatorColor", "(I)V", "GetUpdateLeftSeparatorColor_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateLeftSeparatorColor (int color);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateRightDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateRightDivider", "(IIII)V", "GetUpdateRightDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateRightSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateRightSeparatorColor", "(I)V", "GetUpdateRightSeparatorColor_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateRightSeparatorColor (int color);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateTopDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateTopDivider", "(IIII)V", "GetUpdateTopDivider_IIIIHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/method[@name='updateTopSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateTopSeparatorColor", "(I)V", "GetUpdateTopSeparatorColor_IHandler:Com.Qmuiteam.Qmui.Layout.IQMUILayoutInvoker, QMUI.Droid")]
		void UpdateTopSeparatorColor (int color);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/layout/IQMUILayout", DoNotGenerateAcw=true)]
	internal partial class IQMUILayoutInvoker : global::Java.Lang.Object, IQMUILayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/layout/IQMUILayout", typeof (IQMUILayoutInvoker));

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

		public static IQMUILayout GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUILayout> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.layout.IQMUILayout"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUILayoutInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasBorder;
#pragma warning disable 0169
		static Delegate GetHasBorderHandler ()
		{
			if (cb_hasBorder == null)
				cb_hasBorder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasBorder);
			return cb_hasBorder;
		}

		static bool n_HasBorder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBorder;
		}
#pragma warning restore 0169

		IntPtr id_hasBorder;
		public unsafe bool HasBorder {
			get {
				if (id_hasBorder == IntPtr.Zero)
					id_hasBorder = JNIEnv.GetMethodID (class_ref, "hasBorder", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasBorder);
			}
		}

		static Delegate cb_hasBottomSeparator;
#pragma warning disable 0169
		static Delegate GetHasBottomSeparatorHandler ()
		{
			if (cb_hasBottomSeparator == null)
				cb_hasBottomSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasBottomSeparator);
			return cb_hasBottomSeparator;
		}

		static bool n_HasBottomSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBottomSeparator;
		}
#pragma warning restore 0169

		IntPtr id_hasBottomSeparator;
		public unsafe bool HasBottomSeparator {
			get {
				if (id_hasBottomSeparator == IntPtr.Zero)
					id_hasBottomSeparator = JNIEnv.GetMethodID (class_ref, "hasBottomSeparator", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasBottomSeparator);
			}
		}

		static Delegate cb_hasLeftSeparator;
#pragma warning disable 0169
		static Delegate GetHasLeftSeparatorHandler ()
		{
			if (cb_hasLeftSeparator == null)
				cb_hasLeftSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasLeftSeparator);
			return cb_hasLeftSeparator;
		}

		static bool n_HasLeftSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLeftSeparator;
		}
#pragma warning restore 0169

		IntPtr id_hasLeftSeparator;
		public unsafe bool HasLeftSeparator {
			get {
				if (id_hasLeftSeparator == IntPtr.Zero)
					id_hasLeftSeparator = JNIEnv.GetMethodID (class_ref, "hasLeftSeparator", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasLeftSeparator);
			}
		}

		static Delegate cb_hasRightSeparator;
#pragma warning disable 0169
		static Delegate GetHasRightSeparatorHandler ()
		{
			if (cb_hasRightSeparator == null)
				cb_hasRightSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasRightSeparator);
			return cb_hasRightSeparator;
		}

		static bool n_HasRightSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRightSeparator;
		}
#pragma warning restore 0169

		IntPtr id_hasRightSeparator;
		public unsafe bool HasRightSeparator {
			get {
				if (id_hasRightSeparator == IntPtr.Zero)
					id_hasRightSeparator = JNIEnv.GetMethodID (class_ref, "hasRightSeparator", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasRightSeparator);
			}
		}

		static Delegate cb_hasTopSeparator;
#pragma warning disable 0169
		static Delegate GetHasTopSeparatorHandler ()
		{
			if (cb_hasTopSeparator == null)
				cb_hasTopSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasTopSeparator);
			return cb_hasTopSeparator;
		}

		static bool n_HasTopSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTopSeparator;
		}
#pragma warning restore 0169

		IntPtr id_hasTopSeparator;
		public unsafe bool HasTopSeparator {
			get {
				if (id_hasTopSeparator == IntPtr.Zero)
					id_hasTopSeparator = JNIEnv.GetMethodID (class_ref, "hasTopSeparator", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasTopSeparator);
			}
		}

		static Delegate cb_getHideRadiusSide;
#pragma warning disable 0169
		static Delegate GetGetHideRadiusSideHandler ()
		{
			if (cb_getHideRadiusSide == null)
				cb_getHideRadiusSide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHideRadiusSide);
			return cb_getHideRadiusSide;
		}

		static int n_GetHideRadiusSide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideRadiusSide;
		}
#pragma warning restore 0169

		static Delegate cb_setHideRadiusSide_I;
#pragma warning disable 0169
		static Delegate GetSetHideRadiusSide_IHandler ()
		{
			if (cb_setHideRadiusSide_I == null)
				cb_setHideRadiusSide_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHideRadiusSide_I);
			return cb_setHideRadiusSide_I;
		}

		static void n_SetHideRadiusSide_I (IntPtr jnienv, IntPtr native__this, int hideRadiusSide)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideRadiusSide = hideRadiusSide;
		}
#pragma warning restore 0169

		IntPtr id_getHideRadiusSide;
		IntPtr id_setHideRadiusSide_I;
		public unsafe int HideRadiusSide {
			get {
				if (id_getHideRadiusSide == IntPtr.Zero)
					id_getHideRadiusSide = JNIEnv.GetMethodID (class_ref, "getHideRadiusSide", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHideRadiusSide);
			}
			set {
				if (id_setHideRadiusSide_I == IntPtr.Zero)
					id_setHideRadiusSide_I = JNIEnv.GetMethodID (class_ref, "setHideRadiusSide", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHideRadiusSide_I, __args);
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radius;
		}
#pragma warning restore 0169

		IntPtr id_getRadius;
		IntPtr id_setRadius_I;
		public unsafe int Radius {
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRadius);
			}
			set {
				if (id_setRadius_I == IntPtr.Zero)
					id_setRadius_I = JNIEnv.GetMethodID (class_ref, "setRadius", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_I, __args);
			}
		}

		static Delegate cb_getShadowAlpha;
#pragma warning disable 0169
		static Delegate GetGetShadowAlphaHandler ()
		{
			if (cb_getShadowAlpha == null)
				cb_getShadowAlpha = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetShadowAlpha);
			return cb_getShadowAlpha;
		}

		static float n_GetShadowAlpha (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowAlpha;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetShadowAlpha_FHandler ()
		{
			if (cb_setShadowAlpha_F == null)
				cb_setShadowAlpha_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetShadowAlpha_F);
			return cb_setShadowAlpha_F;
		}

		static void n_SetShadowAlpha_F (IntPtr jnienv, IntPtr native__this, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowAlpha = shadowAlpha;
		}
#pragma warning restore 0169

		IntPtr id_getShadowAlpha;
		IntPtr id_setShadowAlpha_F;
		public unsafe float ShadowAlpha {
			get {
				if (id_getShadowAlpha == IntPtr.Zero)
					id_getShadowAlpha = JNIEnv.GetMethodID (class_ref, "getShadowAlpha", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getShadowAlpha);
			}
			set {
				if (id_setShadowAlpha_F == IntPtr.Zero)
					id_setShadowAlpha_F = JNIEnv.GetMethodID (class_ref, "setShadowAlpha", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShadowAlpha_F, __args);
			}
		}

		static Delegate cb_getShadowColor;
#pragma warning disable 0169
		static Delegate GetGetShadowColorHandler ()
		{
			if (cb_getShadowColor == null)
				cb_getShadowColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetShadowColor);
			return cb_getShadowColor;
		}

		static int n_GetShadowColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowColor;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowColor_I;
#pragma warning disable 0169
		static Delegate GetSetShadowColor_IHandler ()
		{
			if (cb_setShadowColor_I == null)
				cb_setShadowColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShadowColor_I);
			return cb_setShadowColor_I;
		}

		static void n_SetShadowColor_I (IntPtr jnienv, IntPtr native__this, int shadowColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowColor = shadowColor;
		}
#pragma warning restore 0169

		IntPtr id_getShadowColor;
		IntPtr id_setShadowColor_I;
		public unsafe int ShadowColor {
			get {
				if (id_getShadowColor == IntPtr.Zero)
					id_getShadowColor = JNIEnv.GetMethodID (class_ref, "getShadowColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getShadowColor);
			}
			set {
				if (id_setShadowColor_I == IntPtr.Zero)
					id_setShadowColor_I = JNIEnv.GetMethodID (class_ref, "setShadowColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShadowColor_I, __args);
			}
		}

		static Delegate cb_getShadowElevation;
#pragma warning disable 0169
		static Delegate GetGetShadowElevationHandler ()
		{
			if (cb_getShadowElevation == null)
				cb_getShadowElevation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetShadowElevation);
			return cb_getShadowElevation;
		}

		static int n_GetShadowElevation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowElevation;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowElevation_I;
#pragma warning disable 0169
		static Delegate GetSetShadowElevation_IHandler ()
		{
			if (cb_setShadowElevation_I == null)
				cb_setShadowElevation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShadowElevation_I);
			return cb_setShadowElevation_I;
		}

		static void n_SetShadowElevation_I (IntPtr jnienv, IntPtr native__this, int elevation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowElevation = elevation;
		}
#pragma warning restore 0169

		IntPtr id_getShadowElevation;
		IntPtr id_setShadowElevation_I;
		public unsafe int ShadowElevation {
			get {
				if (id_getShadowElevation == IntPtr.Zero)
					id_getShadowElevation = JNIEnv.GetMethodID (class_ref, "getShadowElevation", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getShadowElevation);
			}
			set {
				if (id_setShadowElevation_I == IntPtr.Zero)
					id_setShadowElevation_I = JNIEnv.GetMethodID (class_ref, "setShadowElevation", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShadowElevation_I, __args);
			}
		}

		static Delegate cb_onlyShowBottomDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowBottomDivider_IIIIHandler ()
		{
			if (cb_onlyShowBottomDivider_IIII == null)
				cb_onlyShowBottomDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowBottomDivider_IIII);
			return cb_onlyShowBottomDivider_IIII;
		}

		static void n_OnlyShowBottomDivider_IIII (IntPtr jnienv, IntPtr native__this, int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowBottomDivider (bottomInsetLeft, bottomInsetRight, bottomDividerHeight, bottomDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_onlyShowBottomDivider_IIII;
		public unsafe void OnlyShowBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			if (id_onlyShowBottomDivider_IIII == IntPtr.Zero)
				id_onlyShowBottomDivider_IIII = JNIEnv.GetMethodID (class_ref, "onlyShowBottomDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (bottomInsetLeft);
			__args [1] = new JValue (bottomInsetRight);
			__args [2] = new JValue (bottomDividerHeight);
			__args [3] = new JValue (bottomDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onlyShowBottomDivider_IIII, __args);
		}

		static Delegate cb_onlyShowLeftDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowLeftDivider_IIIIHandler ()
		{
			if (cb_onlyShowLeftDivider_IIII == null)
				cb_onlyShowLeftDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowLeftDivider_IIII);
			return cb_onlyShowLeftDivider_IIII;
		}

		static void n_OnlyShowLeftDivider_IIII (IntPtr jnienv, IntPtr native__this, int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowLeftDivider (leftInsetTop, leftInsetBottom, leftDividerWidth, leftDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_onlyShowLeftDivider_IIII;
		public unsafe void OnlyShowLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			if (id_onlyShowLeftDivider_IIII == IntPtr.Zero)
				id_onlyShowLeftDivider_IIII = JNIEnv.GetMethodID (class_ref, "onlyShowLeftDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (leftInsetTop);
			__args [1] = new JValue (leftInsetBottom);
			__args [2] = new JValue (leftDividerWidth);
			__args [3] = new JValue (leftDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onlyShowLeftDivider_IIII, __args);
		}

		static Delegate cb_onlyShowRightDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowRightDivider_IIIIHandler ()
		{
			if (cb_onlyShowRightDivider_IIII == null)
				cb_onlyShowRightDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowRightDivider_IIII);
			return cb_onlyShowRightDivider_IIII;
		}

		static void n_OnlyShowRightDivider_IIII (IntPtr jnienv, IntPtr native__this, int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowRightDivider (rightInsetTop, rightInsetBottom, rightDividerWidth, rightDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_onlyShowRightDivider_IIII;
		public unsafe void OnlyShowRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			if (id_onlyShowRightDivider_IIII == IntPtr.Zero)
				id_onlyShowRightDivider_IIII = JNIEnv.GetMethodID (class_ref, "onlyShowRightDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (rightInsetTop);
			__args [1] = new JValue (rightInsetBottom);
			__args [2] = new JValue (rightDividerWidth);
			__args [3] = new JValue (rightDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onlyShowRightDivider_IIII, __args);
		}

		static Delegate cb_onlyShowTopDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowTopDivider_IIIIHandler ()
		{
			if (cb_onlyShowTopDivider_IIII == null)
				cb_onlyShowTopDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowTopDivider_IIII);
			return cb_onlyShowTopDivider_IIII;
		}

		static void n_OnlyShowTopDivider_IIII (IntPtr jnienv, IntPtr native__this, int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowTopDivider (topInsetLeft, topInsetRight, topDividerHeight, topDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_onlyShowTopDivider_IIII;
		public unsafe void OnlyShowTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			if (id_onlyShowTopDivider_IIII == IntPtr.Zero)
				id_onlyShowTopDivider_IIII = JNIEnv.GetMethodID (class_ref, "onlyShowTopDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (topInsetLeft);
			__args [1] = new JValue (topInsetRight);
			__args [2] = new JValue (topDividerHeight);
			__args [3] = new JValue (topDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onlyShowTopDivider_IIII, __args);
		}

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int borderColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderColor (borderColor);
		}
#pragma warning restore 0169

		IntPtr id_setBorderColor_I;
		public unsafe void SetBorderColor (int borderColor)
		{
			if (id_setBorderColor_I == IntPtr.Zero)
				id_setBorderColor_I = JNIEnv.GetMethodID (class_ref, "setBorderColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (borderColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBorderColor_I, __args);
		}

		static Delegate cb_setBorderWidth_I;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_IHandler ()
		{
			if (cb_setBorderWidth_I == null)
				cb_setBorderWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderWidth_I);
			return cb_setBorderWidth_I;
		}

		static void n_SetBorderWidth_I (IntPtr jnienv, IntPtr native__this, int borderWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderWidth (borderWidth);
		}
#pragma warning restore 0169

		IntPtr id_setBorderWidth_I;
		public unsafe void SetBorderWidth (int borderWidth)
		{
			if (id_setBorderWidth_I == IntPtr.Zero)
				id_setBorderWidth_I = JNIEnv.GetMethodID (class_ref, "setBorderWidth", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (borderWidth);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBorderWidth_I, __args);
		}

		static Delegate cb_setBottomDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetBottomDividerAlpha_IHandler ()
		{
			if (cb_setBottomDividerAlpha_I == null)
				cb_setBottomDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBottomDividerAlpha_I);
			return cb_setBottomDividerAlpha_I;
		}

		static void n_SetBottomDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBottomDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		IntPtr id_setBottomDividerAlpha_I;
		public unsafe void SetBottomDividerAlpha (int dividerAlpha)
		{
			if (id_setBottomDividerAlpha_I == IntPtr.Zero)
				id_setBottomDividerAlpha_I = JNIEnv.GetMethodID (class_ref, "setBottomDividerAlpha", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (dividerAlpha);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBottomDividerAlpha_I, __args);
		}

		static Delegate cb_setHeightLimit_I;
#pragma warning disable 0169
		static Delegate GetSetHeightLimit_IHandler ()
		{
			if (cb_setHeightLimit_I == null)
				cb_setHeightLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetHeightLimit_I);
			return cb_setHeightLimit_I;
		}

		static bool n_SetHeightLimit_I (IntPtr jnienv, IntPtr native__this, int heightLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetHeightLimit (heightLimit);
		}
#pragma warning restore 0169

		IntPtr id_setHeightLimit_I;
		public unsafe bool SetHeightLimit (int heightLimit)
		{
			if (id_setHeightLimit_I == IntPtr.Zero)
				id_setHeightLimit_I = JNIEnv.GetMethodID (class_ref, "setHeightLimit", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (heightLimit);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setHeightLimit_I, __args);
		}

		static Delegate cb_setLeftDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetLeftDividerAlpha_IHandler ()
		{
			if (cb_setLeftDividerAlpha_I == null)
				cb_setLeftDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLeftDividerAlpha_I);
			return cb_setLeftDividerAlpha_I;
		}

		static void n_SetLeftDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLeftDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		IntPtr id_setLeftDividerAlpha_I;
		public unsafe void SetLeftDividerAlpha (int dividerAlpha)
		{
			if (id_setLeftDividerAlpha_I == IntPtr.Zero)
				id_setLeftDividerAlpha_I = JNIEnv.GetMethodID (class_ref, "setLeftDividerAlpha", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (dividerAlpha);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLeftDividerAlpha_I, __args);
		}

		static Delegate cb_setOuterNormalColor_I;
#pragma warning disable 0169
		static Delegate GetSetOuterNormalColor_IHandler ()
		{
			if (cb_setOuterNormalColor_I == null)
				cb_setOuterNormalColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetOuterNormalColor_I);
			return cb_setOuterNormalColor_I;
		}

		static void n_SetOuterNormalColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOuterNormalColor (color);
		}
#pragma warning restore 0169

		IntPtr id_setOuterNormalColor_I;
		public unsafe void SetOuterNormalColor (int color)
		{
			if (id_setOuterNormalColor_I == IntPtr.Zero)
				id_setOuterNormalColor_I = JNIEnv.GetMethodID (class_ref, "setOuterNormalColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (color);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOuterNormalColor_I, __args);
		}

		static Delegate cb_setOutlineExcludePadding_Z;
#pragma warning disable 0169
		static Delegate GetSetOutlineExcludePadding_ZHandler ()
		{
			if (cb_setOutlineExcludePadding_Z == null)
				cb_setOutlineExcludePadding_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOutlineExcludePadding_Z);
			return cb_setOutlineExcludePadding_Z;
		}

		static void n_SetOutlineExcludePadding_Z (IntPtr jnienv, IntPtr native__this, bool outlineExcludePadding)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutlineExcludePadding (outlineExcludePadding);
		}
#pragma warning restore 0169

		IntPtr id_setOutlineExcludePadding_Z;
		public unsafe void SetOutlineExcludePadding (bool outlineExcludePadding)
		{
			if (id_setOutlineExcludePadding_Z == IntPtr.Zero)
				id_setOutlineExcludePadding_Z = JNIEnv.GetMethodID (class_ref, "setOutlineExcludePadding", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (outlineExcludePadding);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOutlineExcludePadding_Z, __args);
		}

		static Delegate cb_setOutlineInset_IIII;
#pragma warning disable 0169
		static Delegate GetSetOutlineInset_IIIIHandler ()
		{
			if (cb_setOutlineInset_IIII == null)
				cb_setOutlineInset_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_SetOutlineInset_IIII);
			return cb_setOutlineInset_IIII;
		}

		static void n_SetOutlineInset_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutlineInset (left, top, right, bottom);
		}
#pragma warning restore 0169

		IntPtr id_setOutlineInset_IIII;
		public unsafe void SetOutlineInset (int left, int top, int right, int bottom)
		{
			if (id_setOutlineInset_IIII == IntPtr.Zero)
				id_setOutlineInset_IIII = JNIEnv.GetMethodID (class_ref, "setOutlineInset", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (left);
			__args [1] = new JValue (top);
			__args [2] = new JValue (right);
			__args [3] = new JValue (bottom);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOutlineInset_IIII, __args);
		}

		static Delegate cb_setRadius_II;
#pragma warning disable 0169
		static Delegate GetSetRadius_IIHandler ()
		{
			if (cb_setRadius_II == null)
				cb_setRadius_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetRadius_II);
			return cb_setRadius_II;
		}

		static void n_SetRadius_II (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius, hideRadiusSide);
		}
#pragma warning restore 0169

		IntPtr id_setRadius_II;
		public unsafe void SetRadius (int radius, int hideRadiusSide)
		{
			if (id_setRadius_II == IntPtr.Zero)
				id_setRadius_II = JNIEnv.GetMethodID (class_ref, "setRadius", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (radius);
			__args [1] = new JValue (hideRadiusSide);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_II, __args);
		}

		static Delegate cb_setRadiusAndShadow_IIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIF == null)
				cb_setRadiusAndShadow_IIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIF_V) n_SetRadiusAndShadow_IIF);
			return cb_setRadiusAndShadow_IIF;
		}

		static void n_SetRadiusAndShadow_IIF (IntPtr jnienv, IntPtr native__this, int radius, int shadowElevation, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, shadowElevation, shadowAlpha);
		}
#pragma warning restore 0169

		IntPtr id_setRadiusAndShadow_IIF;
		public unsafe void SetRadiusAndShadow (int radius, int shadowElevation, float shadowAlpha)
		{
			if (id_setRadiusAndShadow_IIF == IntPtr.Zero)
				id_setRadiusAndShadow_IIF = JNIEnv.GetMethodID (class_ref, "setRadiusAndShadow", "(IIF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (radius);
			__args [1] = new JValue (shadowElevation);
			__args [2] = new JValue (shadowAlpha);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadiusAndShadow_IIF, __args);
		}

		static Delegate cb_setRadiusAndShadow_IIIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIIF == null)
				cb_setRadiusAndShadow_IIIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIF_V) n_SetRadiusAndShadow_IIIF);
			return cb_setRadiusAndShadow_IIIF;
		}

		static void n_SetRadiusAndShadow_IIIF (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide, int shadowElevation, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, hideRadiusSide, shadowElevation, shadowAlpha);
		}
#pragma warning restore 0169

		IntPtr id_setRadiusAndShadow_IIIF;
		public unsafe void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, float shadowAlpha)
		{
			if (id_setRadiusAndShadow_IIIF == IntPtr.Zero)
				id_setRadiusAndShadow_IIIF = JNIEnv.GetMethodID (class_ref, "setRadiusAndShadow", "(IIIF)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (radius);
			__args [1] = new JValue (hideRadiusSide);
			__args [2] = new JValue (shadowElevation);
			__args [3] = new JValue (shadowAlpha);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadiusAndShadow_IIIF, __args);
		}

		static Delegate cb_setRadiusAndShadow_IIIIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIIIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIIIF == null)
				cb_setRadiusAndShadow_IIIIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIIF_V) n_SetRadiusAndShadow_IIIIF);
			return cb_setRadiusAndShadow_IIIIF;
		}

		static void n_SetRadiusAndShadow_IIIIF (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide, int shadowElevation, int shadowColor, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, hideRadiusSide, shadowElevation, shadowColor, shadowAlpha);
		}
#pragma warning restore 0169

		IntPtr id_setRadiusAndShadow_IIIIF;
		public unsafe void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, int shadowColor, float shadowAlpha)
		{
			if (id_setRadiusAndShadow_IIIIF == IntPtr.Zero)
				id_setRadiusAndShadow_IIIIF = JNIEnv.GetMethodID (class_ref, "setRadiusAndShadow", "(IIIIF)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (radius);
			__args [1] = new JValue (hideRadiusSide);
			__args [2] = new JValue (shadowElevation);
			__args [3] = new JValue (shadowColor);
			__args [4] = new JValue (shadowAlpha);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadiusAndShadow_IIIIF, __args);
		}

		static Delegate cb_setRightDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetRightDividerAlpha_IHandler ()
		{
			if (cb_setRightDividerAlpha_I == null)
				cb_setRightDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRightDividerAlpha_I);
			return cb_setRightDividerAlpha_I;
		}

		static void n_SetRightDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRightDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		IntPtr id_setRightDividerAlpha_I;
		public unsafe void SetRightDividerAlpha (int dividerAlpha)
		{
			if (id_setRightDividerAlpha_I == IntPtr.Zero)
				id_setRightDividerAlpha_I = JNIEnv.GetMethodID (class_ref, "setRightDividerAlpha", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (dividerAlpha);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRightDividerAlpha_I, __args);
		}

		static Delegate cb_setShowBorderOnlyBeforeL_Z;
#pragma warning disable 0169
		static Delegate GetSetShowBorderOnlyBeforeL_ZHandler ()
		{
			if (cb_setShowBorderOnlyBeforeL_Z == null)
				cb_setShowBorderOnlyBeforeL_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowBorderOnlyBeforeL_Z);
			return cb_setShowBorderOnlyBeforeL_Z;
		}

		static void n_SetShowBorderOnlyBeforeL_Z (IntPtr jnienv, IntPtr native__this, bool showBorderOnlyBeforeL)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBorderOnlyBeforeL (showBorderOnlyBeforeL);
		}
#pragma warning restore 0169

		IntPtr id_setShowBorderOnlyBeforeL_Z;
		public unsafe void SetShowBorderOnlyBeforeL (bool showBorderOnlyBeforeL)
		{
			if (id_setShowBorderOnlyBeforeL_Z == IntPtr.Zero)
				id_setShowBorderOnlyBeforeL_Z = JNIEnv.GetMethodID (class_ref, "setShowBorderOnlyBeforeL", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (showBorderOnlyBeforeL);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShowBorderOnlyBeforeL_Z, __args);
		}

		static Delegate cb_setTopDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetTopDividerAlpha_IHandler ()
		{
			if (cb_setTopDividerAlpha_I == null)
				cb_setTopDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTopDividerAlpha_I);
			return cb_setTopDividerAlpha_I;
		}

		static void n_SetTopDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTopDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		IntPtr id_setTopDividerAlpha_I;
		public unsafe void SetTopDividerAlpha (int dividerAlpha)
		{
			if (id_setTopDividerAlpha_I == IntPtr.Zero)
				id_setTopDividerAlpha_I = JNIEnv.GetMethodID (class_ref, "setTopDividerAlpha", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (dividerAlpha);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopDividerAlpha_I, __args);
		}

		static Delegate cb_setUseThemeGeneralShadowElevation;
#pragma warning disable 0169
		static Delegate GetSetUseThemeGeneralShadowElevationHandler ()
		{
			if (cb_setUseThemeGeneralShadowElevation == null)
				cb_setUseThemeGeneralShadowElevation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetUseThemeGeneralShadowElevation);
			return cb_setUseThemeGeneralShadowElevation;
		}

		static void n_SetUseThemeGeneralShadowElevation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseThemeGeneralShadowElevation ();
		}
#pragma warning restore 0169

		IntPtr id_setUseThemeGeneralShadowElevation;
		public unsafe void SetUseThemeGeneralShadowElevation ()
		{
			if (id_setUseThemeGeneralShadowElevation == IntPtr.Zero)
				id_setUseThemeGeneralShadowElevation = JNIEnv.GetMethodID (class_ref, "setUseThemeGeneralShadowElevation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseThemeGeneralShadowElevation);
		}

		static Delegate cb_setWidthLimit_I;
#pragma warning disable 0169
		static Delegate GetSetWidthLimit_IHandler ()
		{
			if (cb_setWidthLimit_I == null)
				cb_setWidthLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetWidthLimit_I);
			return cb_setWidthLimit_I;
		}

		static bool n_SetWidthLimit_I (IntPtr jnienv, IntPtr native__this, int widthLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetWidthLimit (widthLimit);
		}
#pragma warning restore 0169

		IntPtr id_setWidthLimit_I;
		public unsafe bool SetWidthLimit (int widthLimit)
		{
			if (id_setWidthLimit_I == IntPtr.Zero)
				id_setWidthLimit_I = JNIEnv.GetMethodID (class_ref, "setWidthLimit", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (widthLimit);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setWidthLimit_I, __args);
		}

		static Delegate cb_updateBottomDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateBottomDivider_IIIIHandler ()
		{
			if (cb_updateBottomDivider_IIII == null)
				cb_updateBottomDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateBottomDivider_IIII);
			return cb_updateBottomDivider_IIII;
		}

		static void n_UpdateBottomDivider_IIII (IntPtr jnienv, IntPtr native__this, int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBottomDivider (bottomInsetLeft, bottomInsetRight, bottomDividerHeight, bottomDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_updateBottomDivider_IIII;
		public unsafe void UpdateBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			if (id_updateBottomDivider_IIII == IntPtr.Zero)
				id_updateBottomDivider_IIII = JNIEnv.GetMethodID (class_ref, "updateBottomDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (bottomInsetLeft);
			__args [1] = new JValue (bottomInsetRight);
			__args [2] = new JValue (bottomDividerHeight);
			__args [3] = new JValue (bottomDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateBottomDivider_IIII, __args);
		}

		static Delegate cb_updateBottomSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateBottomSeparatorColor_IHandler ()
		{
			if (cb_updateBottomSeparatorColor_I == null)
				cb_updateBottomSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateBottomSeparatorColor_I);
			return cb_updateBottomSeparatorColor_I;
		}

		static void n_UpdateBottomSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBottomSeparatorColor (color);
		}
#pragma warning restore 0169

		IntPtr id_updateBottomSeparatorColor_I;
		public unsafe void UpdateBottomSeparatorColor (int color)
		{
			if (id_updateBottomSeparatorColor_I == IntPtr.Zero)
				id_updateBottomSeparatorColor_I = JNIEnv.GetMethodID (class_ref, "updateBottomSeparatorColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (color);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateBottomSeparatorColor_I, __args);
		}

		static Delegate cb_updateLeftDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateLeftDivider_IIIIHandler ()
		{
			if (cb_updateLeftDivider_IIII == null)
				cb_updateLeftDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateLeftDivider_IIII);
			return cb_updateLeftDivider_IIII;
		}

		static void n_UpdateLeftDivider_IIII (IntPtr jnienv, IntPtr native__this, int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLeftDivider (leftInsetTop, leftInsetBottom, leftDividerWidth, leftDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_updateLeftDivider_IIII;
		public unsafe void UpdateLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			if (id_updateLeftDivider_IIII == IntPtr.Zero)
				id_updateLeftDivider_IIII = JNIEnv.GetMethodID (class_ref, "updateLeftDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (leftInsetTop);
			__args [1] = new JValue (leftInsetBottom);
			__args [2] = new JValue (leftDividerWidth);
			__args [3] = new JValue (leftDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLeftDivider_IIII, __args);
		}

		static Delegate cb_updateLeftSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateLeftSeparatorColor_IHandler ()
		{
			if (cb_updateLeftSeparatorColor_I == null)
				cb_updateLeftSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateLeftSeparatorColor_I);
			return cb_updateLeftSeparatorColor_I;
		}

		static void n_UpdateLeftSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLeftSeparatorColor (color);
		}
#pragma warning restore 0169

		IntPtr id_updateLeftSeparatorColor_I;
		public unsafe void UpdateLeftSeparatorColor (int color)
		{
			if (id_updateLeftSeparatorColor_I == IntPtr.Zero)
				id_updateLeftSeparatorColor_I = JNIEnv.GetMethodID (class_ref, "updateLeftSeparatorColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (color);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLeftSeparatorColor_I, __args);
		}

		static Delegate cb_updateRightDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateRightDivider_IIIIHandler ()
		{
			if (cb_updateRightDivider_IIII == null)
				cb_updateRightDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateRightDivider_IIII);
			return cb_updateRightDivider_IIII;
		}

		static void n_UpdateRightDivider_IIII (IntPtr jnienv, IntPtr native__this, int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRightDivider (rightInsetTop, rightInsetBottom, rightDividerWidth, rightDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_updateRightDivider_IIII;
		public unsafe void UpdateRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			if (id_updateRightDivider_IIII == IntPtr.Zero)
				id_updateRightDivider_IIII = JNIEnv.GetMethodID (class_ref, "updateRightDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (rightInsetTop);
			__args [1] = new JValue (rightInsetBottom);
			__args [2] = new JValue (rightDividerWidth);
			__args [3] = new JValue (rightDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateRightDivider_IIII, __args);
		}

		static Delegate cb_updateRightSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateRightSeparatorColor_IHandler ()
		{
			if (cb_updateRightSeparatorColor_I == null)
				cb_updateRightSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateRightSeparatorColor_I);
			return cb_updateRightSeparatorColor_I;
		}

		static void n_UpdateRightSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRightSeparatorColor (color);
		}
#pragma warning restore 0169

		IntPtr id_updateRightSeparatorColor_I;
		public unsafe void UpdateRightSeparatorColor (int color)
		{
			if (id_updateRightSeparatorColor_I == IntPtr.Zero)
				id_updateRightSeparatorColor_I = JNIEnv.GetMethodID (class_ref, "updateRightSeparatorColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (color);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateRightSeparatorColor_I, __args);
		}

		static Delegate cb_updateTopDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateTopDivider_IIIIHandler ()
		{
			if (cb_updateTopDivider_IIII == null)
				cb_updateTopDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateTopDivider_IIII);
			return cb_updateTopDivider_IIII;
		}

		static void n_UpdateTopDivider_IIII (IntPtr jnienv, IntPtr native__this, int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopDivider (topInsetLeft, topInsetRight, topDividerHeight, topDividerColor);
		}
#pragma warning restore 0169

		IntPtr id_updateTopDivider_IIII;
		public unsafe void UpdateTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			if (id_updateTopDivider_IIII == IntPtr.Zero)
				id_updateTopDivider_IIII = JNIEnv.GetMethodID (class_ref, "updateTopDivider", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (topInsetLeft);
			__args [1] = new JValue (topInsetRight);
			__args [2] = new JValue (topDividerHeight);
			__args [3] = new JValue (topDividerColor);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTopDivider_IIII, __args);
		}

		static Delegate cb_updateTopSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateTopSeparatorColor_IHandler ()
		{
			if (cb_updateTopSeparatorColor_I == null)
				cb_updateTopSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateTopSeparatorColor_I);
			return cb_updateTopSeparatorColor_I;
		}

		static void n_UpdateTopSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.IQMUILayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopSeparatorColor (color);
		}
#pragma warning restore 0169

		IntPtr id_updateTopSeparatorColor_I;
		public unsafe void UpdateTopSeparatorColor (int color)
		{
			if (id_updateTopSeparatorColor_I == IntPtr.Zero)
				id_updateTopSeparatorColor_I = JNIEnv.GetMethodID (class_ref, "updateTopSeparatorColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (color);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTopSeparatorColor_I, __args);
		}

	}

}
