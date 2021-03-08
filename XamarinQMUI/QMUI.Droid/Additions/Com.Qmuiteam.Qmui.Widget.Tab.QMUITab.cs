using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITab", DoNotGenerateAcw=true)]
	public partial class QMUITab : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/field[@name='ICON_POSITION_BOTTOM']"
		[Register ("ICON_POSITION_BOTTOM")]
		public const int IconPositionBottom = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/field[@name='ICON_POSITION_LEFT']"
		[Register ("ICON_POSITION_LEFT")]
		public const int IconPositionLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/field[@name='ICON_POSITION_RIGHT']"
		[Register ("ICON_POSITION_RIGHT")]
		public const int IconPositionRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/field[@name='ICON_POSITION_TOP']"
		[Register ("ICON_POSITION_TOP")]
		public const int IconPositionTop = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/field[@name='NO_SIGN_COUNT_AND_RED_POINT']"
		[Register ("NO_SIGN_COUNT_AND_RED_POINT")]
		public const int NoSignCountAndRedPoint = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/field[@name='RED_POINT_SIGN_COUNT']"
		[Register ("RED_POINT_SIGN_COUNT")]
		public const int RedPointSignCount = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/field[@name='SIGN_COUNT_VIEW_LAYOUT_VERTICAL_CENTER']"
		[Register ("SIGN_COUNT_VIEW_LAYOUT_VERTICAL_CENTER")]
		public const int SignCountViewLayoutVerticalCenter = (int) -2147483648;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUITab.IconPosition']"
		[Register ("com/qmuiteam/qmui/widget/tab/QMUITab$IconPosition", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUITab/IIconPositionInvoker")]
		public partial interface IIconPosition : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITab$IconPosition", DoNotGenerateAcw=true)]
		internal partial class IIconPositionInvoker : global::Java.Lang.Object, IIconPosition {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITab$IconPosition", typeof (IIconPositionInvoker));

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

			public static IIconPosition GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IIconPosition> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUITab.IconPosition"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IIconPositionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab.IIconPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab.IIconPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab.IIconPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab.IIconPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITab", typeof (QMUITab));
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

		protected QMUITab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Gravity = gravity;
		}
#pragma warning restore 0169

		public virtual unsafe int Gravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getGravity' and count(parameter)=0]"
			[Register ("getGravity", "()I", "GetGetGravityHandler")]
			get {
				const string __id = "getGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='setGravity' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getIconPosition;
#pragma warning disable 0169
		static Delegate GetGetIconPositionHandler ()
		{
			if (cb_getIconPosition == null)
				cb_getIconPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIconPosition);
			return cb_getIconPosition;
		}

		static int n_GetIconPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setIconPosition_I;
#pragma warning disable 0169
		static Delegate GetSetIconPosition_IHandler ()
		{
			if (cb_setIconPosition_I == null)
				cb_setIconPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetIconPosition_I);
			return cb_setIconPosition_I;
		}

		static void n_SetIconPosition_I (IntPtr jnienv, IntPtr native__this, int iconPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IconPosition = iconPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int IconPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getIconPosition' and count(parameter)=0]"
			[Register ("getIconPosition", "()I", "GetGetIconPositionHandler")]
			get {
				const string __id = "getIconPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='setIconPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIconPosition", "(I)V", "GetSetIconPosition_IHandler")]
			set {
				const string __id = "setIconPosition.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconTextGap;
#pragma warning disable 0169
		static Delegate GetGetIconTextGapHandler ()
		{
			if (cb_getIconTextGap == null)
				cb_getIconTextGap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIconTextGap);
			return cb_getIconTextGap;
		}

		static int n_GetIconTextGap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconTextGap;
		}
#pragma warning restore 0169

		public virtual unsafe int IconTextGap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getIconTextGap' and count(parameter)=0]"
			[Register ("getIconTextGap", "()I", "GetGetIconTextGapHandler")]
			get {
				const string __id = "getIconTextGap.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAllowIconDrawOutside;
#pragma warning disable 0169
		static Delegate GetIsAllowIconDrawOutsideHandler ()
		{
			if (cb_isAllowIconDrawOutside == null)
				cb_isAllowIconDrawOutside = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAllowIconDrawOutside);
			return cb_isAllowIconDrawOutside;
		}

		static bool n_IsAllowIconDrawOutside (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAllowIconDrawOutside;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAllowIconDrawOutside {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='isAllowIconDrawOutside' and count(parameter)=0]"
			[Register ("isAllowIconDrawOutside", "()Z", "GetIsAllowIconDrawOutsideHandler")]
			get {
				const string __id = "isAllowIconDrawOutside.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRedPointShowing;
#pragma warning disable 0169
		static Delegate GetIsRedPointShowingHandler ()
		{
			if (cb_isRedPointShowing == null)
				cb_isRedPointShowing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRedPointShowing);
			return cb_isRedPointShowing;
		}

		static bool n_IsRedPointShowing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRedPointShowing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRedPointShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='isRedPointShowing' and count(parameter)=0]"
			[Register ("isRedPointShowing", "()Z", "GetIsRedPointShowingHandler")]
			get {
				const string __id = "isRedPointShowing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalColorAttr;
#pragma warning disable 0169
		static Delegate GetGetNormalColorAttrHandler ()
		{
			if (cb_getNormalColorAttr == null)
				cb_getNormalColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNormalColorAttr);
			return cb_getNormalColorAttr;
		}

		static int n_GetNormalColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getNormalColorAttr' and count(parameter)=0]"
			[Register ("getNormalColorAttr", "()I", "GetGetNormalColorAttrHandler")]
			get {
				const string __id = "getNormalColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalIconAttr;
#pragma warning disable 0169
		static Delegate GetGetNormalIconAttrHandler ()
		{
			if (cb_getNormalIconAttr == null)
				cb_getNormalIconAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNormalIconAttr);
			return cb_getNormalIconAttr;
		}

		static int n_GetNormalIconAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalIconAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalIconAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getNormalIconAttr' and count(parameter)=0]"
			[Register ("getNormalIconAttr", "()I", "GetGetNormalIconAttrHandler")]
			get {
				const string __id = "getNormalIconAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalTabIconHeight;
#pragma warning disable 0169
		static Delegate GetGetNormalTabIconHeightHandler ()
		{
			if (cb_getNormalTabIconHeight == null)
				cb_getNormalTabIconHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNormalTabIconHeight);
			return cb_getNormalTabIconHeight;
		}

		static int n_GetNormalTabIconHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalTabIconHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalTabIconHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getNormalTabIconHeight' and count(parameter)=0]"
			[Register ("getNormalTabIconHeight", "()I", "GetGetNormalTabIconHeightHandler")]
			get {
				const string __id = "getNormalTabIconHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalTabIconWidth;
#pragma warning disable 0169
		static Delegate GetGetNormalTabIconWidthHandler ()
		{
			if (cb_getNormalTabIconWidth == null)
				cb_getNormalTabIconWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNormalTabIconWidth);
			return cb_getNormalTabIconWidth;
		}

		static int n_GetNormalTabIconWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalTabIconWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalTabIconWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getNormalTabIconWidth' and count(parameter)=0]"
			[Register ("getNormalTabIconWidth", "()I", "GetGetNormalTabIconWidthHandler")]
			get {
				const string __id = "getNormalTabIconWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalTextSize;
#pragma warning disable 0169
		static Delegate GetGetNormalTextSizeHandler ()
		{
			if (cb_getNormalTextSize == null)
				cb_getNormalTextSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNormalTextSize);
			return cb_getNormalTextSize;
		}

		static int n_GetNormalTextSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalTextSize;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getNormalTextSize' and count(parameter)=0]"
			[Register ("getNormalTextSize", "()I", "GetGetNormalTextSizeHandler")]
			get {
				const string __id = "getNormalTextSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalTypeface;
#pragma warning disable 0169
		static Delegate GetGetNormalTypefaceHandler ()
		{
			if (cb_getNormalTypeface == null)
				cb_getNormalTypeface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNormalTypeface);
			return cb_getNormalTypeface;
		}

		static IntPtr n_GetNormalTypeface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormalTypeface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface NormalTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getNormalTypeface' and count(parameter)=0]"
			[Register ("getNormalTypeface", "()Landroid/graphics/Typeface;", "GetGetNormalTypefaceHandler")]
			get {
				const string __id = "getNormalTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedColorAttr;
#pragma warning disable 0169
		static Delegate GetGetSelectedColorAttrHandler ()
		{
			if (cb_getSelectedColorAttr == null)
				cb_getSelectedColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedColorAttr);
			return cb_getSelectedColorAttr;
		}

		static int n_GetSelectedColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getSelectedColorAttr' and count(parameter)=0]"
			[Register ("getSelectedColorAttr", "()I", "GetGetSelectedColorAttrHandler")]
			get {
				const string __id = "getSelectedColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedIconAttr;
#pragma warning disable 0169
		static Delegate GetGetSelectedIconAttrHandler ()
		{
			if (cb_getSelectedIconAttr == null)
				cb_getSelectedIconAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedIconAttr);
			return cb_getSelectedIconAttr;
		}

		static int n_GetSelectedIconAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedIconAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedIconAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getSelectedIconAttr' and count(parameter)=0]"
			[Register ("getSelectedIconAttr", "()I", "GetGetSelectedIconAttrHandler")]
			get {
				const string __id = "getSelectedIconAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedTabIconScale;
#pragma warning disable 0169
		static Delegate GetGetSelectedTabIconScaleHandler ()
		{
			if (cb_getSelectedTabIconScale == null)
				cb_getSelectedTabIconScale = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetSelectedTabIconScale);
			return cb_getSelectedTabIconScale;
		}

		static float n_GetSelectedTabIconScale (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedTabIconScale;
		}
#pragma warning restore 0169

		public virtual unsafe float SelectedTabIconScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getSelectedTabIconScale' and count(parameter)=0]"
			[Register ("getSelectedTabIconScale", "()F", "GetGetSelectedTabIconScaleHandler")]
			get {
				const string __id = "getSelectedTabIconScale.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedTextSize;
#pragma warning disable 0169
		static Delegate GetGetSelectedTextSizeHandler ()
		{
			if (cb_getSelectedTextSize == null)
				cb_getSelectedTextSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedTextSize);
			return cb_getSelectedTextSize;
		}

		static int n_GetSelectedTextSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedTextSize;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getSelectedTextSize' and count(parameter)=0]"
			[Register ("getSelectedTextSize", "()I", "GetGetSelectedTextSizeHandler")]
			get {
				const string __id = "getSelectedTextSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedTypeface;
#pragma warning disable 0169
		static Delegate GetGetSelectedTypefaceHandler ()
		{
			if (cb_getSelectedTypeface == null)
				cb_getSelectedTypeface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSelectedTypeface);
			return cb_getSelectedTypeface;
		}

		static IntPtr n_GetSelectedTypeface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedTypeface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface SelectedTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getSelectedTypeface' and count(parameter)=0]"
			[Register ("getSelectedTypeface", "()Landroid/graphics/Typeface;", "GetGetSelectedTypefaceHandler")]
			get {
				const string __id = "getSelectedTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSignCount;
#pragma warning disable 0169
		static Delegate GetGetSignCountHandler ()
		{
			if (cb_getSignCount == null)
				cb_getSignCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSignCount);
			return cb_getSignCount;
		}

		static int n_GetSignCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SignCount;
		}
#pragma warning restore 0169

		static Delegate cb_setSignCount_I;
#pragma warning disable 0169
		static Delegate GetSetSignCount_IHandler ()
		{
			if (cb_setSignCount_I == null)
				cb_setSignCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSignCount_I);
			return cb_setSignCount_I;
		}

		static void n_SetSignCount_I (IntPtr jnienv, IntPtr native__this, int signCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SignCount = signCount;
		}
#pragma warning restore 0169

		public virtual unsafe int SignCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getSignCount' and count(parameter)=0]"
			[Register ("getSignCount", "()I", "GetGetSignCountHandler")]
			get {
				const string __id = "getSignCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='setSignCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSignCount", "(I)V", "GetSetSignCount_IHandler")]
			set {
				const string __id = "setSignCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTabIcon;
#pragma warning disable 0169
		static Delegate GetGetTabIconHandler ()
		{
			if (cb_getTabIcon == null)
				cb_getTabIcon = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTabIcon);
			return cb_getTabIcon;
		}

		static IntPtr n_GetTabIcon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TabIcon);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon TabIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getTabIcon' and count(parameter)=0]"
			[Register ("getTabIcon", "()Lcom/qmuiteam/qmui/widget/tab/QMUITabIcon;", "GetGetTabIconHandler")]
			get {
				const string __id = "getTabIcon.()Lcom/qmuiteam/qmui/widget/tab/QMUITabIcon;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.TextFormatted = text;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence TextFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
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

		static Delegate cb_getTypefaceUpdateAreaPercent;
#pragma warning disable 0169
		static Delegate GetGetTypefaceUpdateAreaPercentHandler ()
		{
			if (cb_getTypefaceUpdateAreaPercent == null)
				cb_getTypefaceUpdateAreaPercent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetTypefaceUpdateAreaPercent);
			return cb_getTypefaceUpdateAreaPercent;
		}

		static float n_GetTypefaceUpdateAreaPercent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TypefaceUpdateAreaPercent;
		}
#pragma warning restore 0169

		static Delegate cb_setTypefaceUpdateAreaPercent_F;
#pragma warning disable 0169
		static Delegate GetSetTypefaceUpdateAreaPercent_FHandler ()
		{
			if (cb_setTypefaceUpdateAreaPercent_F == null)
				cb_setTypefaceUpdateAreaPercent_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetTypefaceUpdateAreaPercent_F);
			return cb_setTypefaceUpdateAreaPercent_F;
		}

		static void n_SetTypefaceUpdateAreaPercent_F (IntPtr jnienv, IntPtr native__this, float typefaceUpdateAreaPercent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TypefaceUpdateAreaPercent = typefaceUpdateAreaPercent;
		}
#pragma warning restore 0169

		public virtual unsafe float TypefaceUpdateAreaPercent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getTypefaceUpdateAreaPercent' and count(parameter)=0]"
			[Register ("getTypefaceUpdateAreaPercent", "()F", "GetGetTypefaceUpdateAreaPercentHandler")]
			get {
				const string __id = "getTypefaceUpdateAreaPercent.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='setTypefaceUpdateAreaPercent' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTypefaceUpdateAreaPercent", "(F)V", "GetSetTypefaceUpdateAreaPercent_FHandler")]
			set {
				const string __id = "setTypefaceUpdateAreaPercent.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_clearSignCountOrRedPoint;
#pragma warning disable 0169
		static Delegate GetClearSignCountOrRedPointHandler ()
		{
			if (cb_clearSignCountOrRedPoint == null)
				cb_clearSignCountOrRedPoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearSignCountOrRedPoint);
			return cb_clearSignCountOrRedPoint;
		}

		static void n_ClearSignCountOrRedPoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearSignCountOrRedPoint ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='clearSignCountOrRedPoint' and count(parameter)=0]"
		[Register ("clearSignCountOrRedPoint", "()V", "GetClearSignCountOrRedPointHandler")]
		public virtual unsafe void ClearSignCountOrRedPoint ()
		{
			const string __id = "clearSignCountOrRedPoint.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getNormalColor_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetNormalColor_Landroid_view_View_Handler ()
		{
			if (cb_getNormalColor_Landroid_view_View_ == null)
				cb_getNormalColor_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetNormalColor_Landroid_view_View_);
			return cb_getNormalColor_Landroid_view_View_;
		}

		static int n_GetNormalColor_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skinFollowView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinFollowView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_skinFollowView, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNormalColor (skinFollowView);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getNormalColor' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getNormalColor", "(Landroid/view/View;)I", "GetGetNormalColor_Landroid_view_View_Handler")]
		public virtual unsafe int GetNormalColor (global::Android.Views.View skinFollowView)
		{
			const string __id = "getNormalColor.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((skinFollowView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinFollowView).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (skinFollowView);
			}
		}

		static Delegate cb_getSelectColor_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetSelectColor_Landroid_view_View_Handler ()
		{
			if (cb_getSelectColor_Landroid_view_View_ == null)
				cb_getSelectColor_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetSelectColor_Landroid_view_View_);
			return cb_getSelectColor_Landroid_view_View_;
		}

		static int n_GetSelectColor_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skinFollowView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinFollowView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_skinFollowView, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSelectColor (skinFollowView);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='getSelectColor' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSelectColor", "(Landroid/view/View;)I", "GetGetSelectColor_Landroid_view_View_Handler")]
		public virtual unsafe int GetSelectColor (global::Android.Views.View skinFollowView)
		{
			const string __id = "getSelectColor.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((skinFollowView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinFollowView).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (skinFollowView);
			}
		}

		static Delegate cb_setRedPoint;
#pragma warning disable 0169
		static Delegate GetSetRedPointHandler ()
		{
			if (cb_setRedPoint == null)
				cb_setRedPoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetRedPoint);
			return cb_setRedPoint;
		}

		static void n_SetRedPoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRedPoint ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='setRedPoint' and count(parameter)=0]"
		[Register ("setRedPoint", "()V", "GetSetRedPointHandler")]
		public virtual unsafe void SetRedPoint ()
		{
			const string __id = "setRedPoint.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSpaceWeight_FF;
#pragma warning disable 0169
		static Delegate GetSetSpaceWeight_FFHandler ()
		{
			if (cb_setSpaceWeight_FF == null)
				cb_setSpaceWeight_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_V) n_SetSpaceWeight_FF);
			return cb_setSpaceWeight_FF;
		}

		static void n_SetSpaceWeight_FF (IntPtr jnienv, IntPtr native__this, float leftWeight, float rightWeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSpaceWeight (leftWeight, rightWeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITab']/method[@name='setSpaceWeight' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setSpaceWeight", "(FF)V", "GetSetSpaceWeight_FFHandler")]
		public virtual unsafe void SetSpaceWeight (float leftWeight, float rightWeight)
		{
			const string __id = "setSpaceWeight.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (leftWeight);
				__args [1] = new JniArgumentValue (rightWeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
