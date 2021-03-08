using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Popup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUINormalPopup", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.qmuiteam.qmui.widget.popup.QMUIBasePopup"})]
	public partial class QMUINormalPopup : global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='ANIM_AUTO']"
		[Register ("ANIM_AUTO")]
		public const int AnimAuto = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='ANIM_GROW_FROM_CENTER']"
		[Register ("ANIM_GROW_FROM_CENTER")]
		public const int AnimGrowFromCenter = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='ANIM_GROW_FROM_LEFT']"
		[Register ("ANIM_GROW_FROM_LEFT")]
		public const int AnimGrowFromLeft = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='ANIM_GROW_FROM_RIGHT']"
		[Register ("ANIM_GROW_FROM_RIGHT")]
		public const int AnimGrowFromRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='ANIM_SPEC']"
		[Register ("ANIM_SPEC")]
		public const int AnimSpec = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='DIRECTION_BOTTOM']"
		[Register ("DIRECTION_BOTTOM")]
		public const int DirectionBottom = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='DIRECTION_CENTER_IN_SCREEN']"
		[Register ("DIRECTION_CENTER_IN_SCREEN")]
		public const int DirectionCenterInScreen = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='DIRECTION_TOP']"
		[Register ("DIRECTION_TOP")]
		public const int DirectionTop = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='mAnimStyle']"
		[Register ("mAnimStyle")]
		protected int MAnimStyle {
			get {
				const string __id = "mAnimStyle.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mAnimStyle.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='mInitHeight']"
		[Register ("mInitHeight")]
		protected int MInitHeight {
			get {
				const string __id = "mInitHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mInitHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='mInitWidth']"
		[Register ("mInitWidth")]
		protected int MInitWidth {
			get {
				const string __id = "mInitWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mInitWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/field[@name='mSpecAnimStyle']"
		[Register ("mSpecAnimStyle")]
		protected int MSpecAnimStyle {
			get {
				const string __id = "mSpecAnimStyle.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mSpecAnimStyle.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/interface[@name='QMUINormalPopup.Direction']"
		[Register ("com/qmuiteam/qmui/widget/popup/QMUINormalPopup$Direction", "", "Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup/IDirectionInvoker")]
		public partial interface IDirection : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUINormalPopup$Direction", DoNotGenerateAcw=true)]
		internal partial class IDirectionInvoker : global::Java.Lang.Object, IDirection {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUINormalPopup$Direction", typeof (IDirectionInvoker));

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

			public static IDirection GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDirection> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.popup.QMUINormalPopup.Direction"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDirectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup.IDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup.IDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup.IDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup.IDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUINormalPopup", typeof (QMUINormalPopup));
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

		protected QMUINormalPopup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/constructor[@name='QMUINormalPopup' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public unsafe QMUINormalPopup (global::Android.Content.Context context, int width, int height)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getBgColor;
#pragma warning disable 0169
		static Delegate GetGetBgColorHandler ()
		{
			if (cb_getBgColor == null)
				cb_getBgColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBgColor);
			return cb_getBgColor;
		}

		static int n_GetBgColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BgColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BgColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='getBgColor' and count(parameter)=0]"
			[Register ("getBgColor", "()I", "GetGetBgColorHandler")]
			get {
				const string __id = "getBgColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBgColorAttr;
#pragma warning disable 0169
		static Delegate GetGetBgColorAttrHandler ()
		{
			if (cb_getBgColorAttr == null)
				cb_getBgColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBgColorAttr);
			return cb_getBgColorAttr;
		}

		static int n_GetBgColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BgColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int BgColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='getBgColorAttr' and count(parameter)=0]"
			[Register ("getBgColorAttr", "()I", "GetGetBgColorAttrHandler")]
			get {
				const string __id = "getBgColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static int n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()I", "GetGetBorderColorHandler")]
			get {
				const string __id = "getBorderColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBorderColorAttr;
#pragma warning disable 0169
		static Delegate GetGetBorderColorAttrHandler ()
		{
			if (cb_getBorderColorAttr == null)
				cb_getBorderColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBorderColorAttr);
			return cb_getBorderColorAttr;
		}

		static int n_GetBorderColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='getBorderColorAttr' and count(parameter)=0]"
			[Register ("getBorderColorAttr", "()I", "GetGetBorderColorAttrHandler")]
			get {
				const string __id = "getBorderColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_animStyle_I;
#pragma warning disable 0169
		static Delegate GetAnimStyle_IHandler ()
		{
			if (cb_animStyle_I == null)
				cb_animStyle_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_AnimStyle_I);
			return cb_animStyle_I;
		}

		static IntPtr n_AnimStyle_I (IntPtr jnienv, IntPtr native__this, int animStyle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimStyle (animStyle));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='animStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animStyle", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetAnimStyle_IHandler")]
		public virtual unsafe global::Java.Lang.Object AnimStyle (int animStyle)
		{
			const string __id = "animStyle.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (animStyle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_arrow_Z;
#pragma warning disable 0169
		static Delegate GetArrow_ZHandler ()
		{
			if (cb_arrow_Z == null)
				cb_arrow_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Arrow_Z);
			return cb_arrow_Z;
		}

		static IntPtr n_Arrow_Z (IntPtr jnienv, IntPtr native__this, bool showArrow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Arrow (showArrow));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='arrow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("arrow", "(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetArrow_ZHandler")]
		public virtual unsafe global::Java.Lang.Object Arrow (bool showArrow)
		{
			const string __id = "arrow.(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showArrow);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_arrowSize_II;
#pragma warning disable 0169
		static Delegate GetArrowSize_IIHandler ()
		{
			if (cb_arrowSize_II == null)
				cb_arrowSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_ArrowSize_II);
			return cb_arrowSize_II;
		}

		static IntPtr n_ArrowSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ArrowSize (width, height));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='arrowSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("arrowSize", "(II)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetArrowSize_IIHandler")]
		public virtual unsafe global::Java.Lang.Object ArrowSize (int width, int height)
		{
			const string __id = "arrowSize.(II)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_bgColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeBgColor_IHandler ()
		{
			if (cb_bgColor_I == null)
				cb_bgColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_InvokeBgColor_I);
			return cb_bgColor_I;
		}

		static IntPtr n_InvokeBgColor_I (IntPtr jnienv, IntPtr native__this, int bgColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeBgColor (bgColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='bgColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bgColor", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetInvokeBgColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object InvokeBgColor (int bgColor)
		{
			const string __id = "bgColor.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bgColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_bgColorAttr_I;
#pragma warning disable 0169
		static Delegate GetInvokeBgColorAttr_IHandler ()
		{
			if (cb_bgColorAttr_I == null)
				cb_bgColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_InvokeBgColorAttr_I);
			return cb_bgColorAttr_I;
		}

		static IntPtr n_InvokeBgColorAttr_I (IntPtr jnienv, IntPtr native__this, int bgColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeBgColorAttr (bgColorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='bgColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bgColorAttr", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetInvokeBgColorAttr_IHandler")]
		public virtual unsafe global::Java.Lang.Object InvokeBgColorAttr (int bgColorAttr)
		{
			const string __id = "bgColorAttr.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bgColorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_borderColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeBorderColor_IHandler ()
		{
			if (cb_borderColor_I == null)
				cb_borderColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_InvokeBorderColor_I);
			return cb_borderColor_I;
		}

		static IntPtr n_InvokeBorderColor_I (IntPtr jnienv, IntPtr native__this, int borderColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeBorderColor (borderColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='borderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("borderColor", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetInvokeBorderColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object InvokeBorderColor (int borderColor)
		{
			const string __id = "borderColor.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (borderColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_borderColorAttr_I;
#pragma warning disable 0169
		static Delegate GetInvokeBorderColorAttr_IHandler ()
		{
			if (cb_borderColorAttr_I == null)
				cb_borderColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_InvokeBorderColorAttr_I);
			return cb_borderColorAttr_I;
		}

		static IntPtr n_InvokeBorderColorAttr_I (IntPtr jnienv, IntPtr native__this, int borderColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeBorderColorAttr (borderColorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='borderColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("borderColorAttr", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetInvokeBorderColorAttr_IHandler")]
		public virtual unsafe global::Java.Lang.Object InvokeBorderColorAttr (int borderColorAttr)
		{
			const string __id = "borderColorAttr.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (borderColorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_borderWidth_I;
#pragma warning disable 0169
		static Delegate GetBorderWidth_IHandler ()
		{
			if (cb_borderWidth_I == null)
				cb_borderWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_BorderWidth_I);
			return cb_borderWidth_I;
		}

		static IntPtr n_BorderWidth_I (IntPtr jnienv, IntPtr native__this, int borderWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BorderWidth (borderWidth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='borderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("borderWidth", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetBorderWidth_IHandler")]
		public virtual unsafe global::Java.Lang.Object BorderWidth (int borderWidth)
		{
			const string __id = "borderWidth.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (borderWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_customAnimStyle_I;
#pragma warning disable 0169
		static Delegate GetCustomAnimStyle_IHandler ()
		{
			if (cb_customAnimStyle_I == null)
				cb_customAnimStyle_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_CustomAnimStyle_I);
			return cb_customAnimStyle_I;
		}

		static IntPtr n_CustomAnimStyle_I (IntPtr jnienv, IntPtr native__this, int animStyle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomAnimStyle (animStyle));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='customAnimStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("customAnimStyle", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetCustomAnimStyle_IHandler")]
		public virtual unsafe global::Java.Lang.Object CustomAnimStyle (int animStyle)
		{
			const string __id = "customAnimStyle.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (animStyle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_edgeProtection_I;
#pragma warning disable 0169
		static Delegate GetEdgeProtection_IHandler ()
		{
			if (cb_edgeProtection_I == null)
				cb_edgeProtection_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_EdgeProtection_I);
			return cb_edgeProtection_I;
		}

		static IntPtr n_EdgeProtection_I (IntPtr jnienv, IntPtr native__this, int distance)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EdgeProtection (distance));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='edgeProtection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("edgeProtection", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetEdgeProtection_IHandler")]
		public virtual unsafe global::Java.Lang.Object EdgeProtection (int distance)
		{
			const string __id = "edgeProtection.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (distance);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_edgeProtection_IIII;
#pragma warning disable 0169
		static Delegate GetEdgeProtection_IIIIHandler ()
		{
			if (cb_edgeProtection_IIII == null)
				cb_edgeProtection_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_L) n_EdgeProtection_IIII);
			return cb_edgeProtection_IIII;
		}

		static IntPtr n_EdgeProtection_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EdgeProtection (left, top, right, bottom));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='edgeProtection' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("edgeProtection", "(IIII)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetEdgeProtection_IIIIHandler")]
		public virtual unsafe global::Java.Lang.Object EdgeProtection (int left, int top, int right, int bottom)
		{
			const string __id = "edgeProtection.(IIII)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_offsetX_I;
#pragma warning disable 0169
		static Delegate GetOffsetX_IHandler ()
		{
			if (cb_offsetX_I == null)
				cb_offsetX_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_OffsetX_I);
			return cb_offsetX_I;
		}

		static IntPtr n_OffsetX_I (IntPtr jnienv, IntPtr native__this, int offsetX)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OffsetX (offsetX));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='offsetX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offsetX", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetOffsetX_IHandler")]
		public virtual unsafe global::Java.Lang.Object OffsetX (int offsetX)
		{
			const string __id = "offsetX.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offsetX);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_offsetYIfBottom_I;
#pragma warning disable 0169
		static Delegate GetOffsetYIfBottom_IHandler ()
		{
			if (cb_offsetYIfBottom_I == null)
				cb_offsetYIfBottom_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_OffsetYIfBottom_I);
			return cb_offsetYIfBottom_I;
		}

		static IntPtr n_OffsetYIfBottom_I (IntPtr jnienv, IntPtr native__this, int y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OffsetYIfBottom (y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='offsetYIfBottom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offsetYIfBottom", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetOffsetYIfBottom_IHandler")]
		public virtual unsafe global::Java.Lang.Object OffsetYIfBottom (int y)
		{
			const string __id = "offsetYIfBottom.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_offsetYIfTop_I;
#pragma warning disable 0169
		static Delegate GetOffsetYIfTop_IHandler ()
		{
			if (cb_offsetYIfTop_I == null)
				cb_offsetYIfTop_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_OffsetYIfTop_I);
			return cb_offsetYIfTop_I;
		}

		static IntPtr n_OffsetYIfTop_I (IntPtr jnienv, IntPtr native__this, int y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OffsetYIfTop (y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='offsetYIfTop' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offsetYIfTop", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetOffsetYIfTop_IHandler")]
		public virtual unsafe global::Java.Lang.Object OffsetYIfTop (int y)
		{
			const string __id = "offsetYIfTop.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_preferredDirection_I;
#pragma warning disable 0169
		static Delegate GetPreferredDirection_IHandler ()
		{
			if (cb_preferredDirection_I == null)
				cb_preferredDirection_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_PreferredDirection_I);
			return cb_preferredDirection_I;
		}

		static IntPtr n_PreferredDirection_I (IntPtr jnienv, IntPtr native__this, int preferredDirection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreferredDirection (preferredDirection));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='preferredDirection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("preferredDirection", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetPreferredDirection_IHandler")]
		public virtual unsafe global::Java.Lang.Object PreferredDirection (int preferredDirection)
		{
			const string __id = "preferredDirection.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (preferredDirection);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_proxyHeight_I;
#pragma warning disable 0169
		static Delegate GetProxyHeight_IHandler ()
		{
			if (cb_proxyHeight_I == null)
				cb_proxyHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_ProxyHeight_I);
			return cb_proxyHeight_I;
		}

		static int n_ProxyHeight_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProxyHeight (height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='proxyHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("proxyHeight", "(I)I", "GetProxyHeight_IHandler")]
		protected virtual unsafe int ProxyHeight (int height)
		{
			const string __id = "proxyHeight.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_proxyWidth_I;
#pragma warning disable 0169
		static Delegate GetProxyWidth_IHandler ()
		{
			if (cb_proxyWidth_I == null)
				cb_proxyWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_ProxyWidth_I);
			return cb_proxyWidth_I;
		}

		static int n_ProxyWidth_I (IntPtr jnienv, IntPtr native__this, int width)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProxyWidth (width);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='proxyWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("proxyWidth", "(I)I", "GetProxyWidth_IHandler")]
		protected virtual unsafe int ProxyWidth (int width)
		{
			const string __id = "proxyWidth.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (width);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_radius_I;
#pragma warning disable 0169
		static Delegate GetRadius_IHandler ()
		{
			if (cb_radius_I == null)
				cb_radius_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Radius_I);
			return cb_radius_I;
		}

		static IntPtr n_Radius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Radius (radius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("radius", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetRadius_IHandler")]
		public virtual unsafe global::Java.Lang.Object Radius (int radius)
		{
			const string __id = "radius.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeBorderWhenShadow_Z;
#pragma warning disable 0169
		static Delegate GetRemoveBorderWhenShadow_ZHandler ()
		{
			if (cb_removeBorderWhenShadow_Z == null)
				cb_removeBorderWhenShadow_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_RemoveBorderWhenShadow_Z);
			return cb_removeBorderWhenShadow_Z;
		}

		static IntPtr n_RemoveBorderWhenShadow_Z (IntPtr jnienv, IntPtr native__this, bool removeBorderWhenShadow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveBorderWhenShadow (removeBorderWhenShadow));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='removeBorderWhenShadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("removeBorderWhenShadow", "(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetRemoveBorderWhenShadow_ZHandler")]
		public virtual unsafe global::Java.Lang.Object RemoveBorderWhenShadow (bool removeBorderWhenShadow)
		{
			const string __id = "removeBorderWhenShadow.(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (removeBorderWhenShadow);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadow_Z;
#pragma warning disable 0169
		static Delegate GetShadow_ZHandler ()
		{
			if (cb_shadow_Z == null)
				cb_shadow_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Shadow_Z);
			return cb_shadow_Z;
		}

		static IntPtr n_Shadow_Z (IntPtr jnienv, IntPtr native__this, bool addShadow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Shadow (addShadow));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='shadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("shadow", "(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetShadow_ZHandler")]
		public virtual unsafe global::Java.Lang.Object Shadow (bool addShadow)
		{
			const string __id = "shadow.(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (addShadow);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadowElevation_IF;
#pragma warning disable 0169
		static Delegate GetShadowElevation_IFHandler ()
		{
			if (cb_shadowElevation_IF == null)
				cb_shadowElevation_IF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIF_L) n_ShadowElevation_IF);
			return cb_shadowElevation_IF;
		}

		static IntPtr n_ShadowElevation_IF (IntPtr jnienv, IntPtr native__this, int shadowElevation, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowElevation (shadowElevation, shadowAlpha));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='shadowElevation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("shadowElevation", "(IF)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetShadowElevation_IFHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowElevation (int shadowElevation, float shadowAlpha)
		{
			const string __id = "shadowElevation.(IF)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (shadowElevation);
				__args [1] = new JniArgumentValue (shadowAlpha);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadowInset_I;
#pragma warning disable 0169
		static Delegate GetShadowInset_IHandler ()
		{
			if (cb_shadowInset_I == null)
				cb_shadowInset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ShadowInset_I);
			return cb_shadowInset_I;
		}

		static IntPtr n_ShadowInset_I (IntPtr jnienv, IntPtr native__this, int shadowInset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowInset (shadowInset));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='shadowInset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shadowInset", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetShadowInset_IHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowInset (int shadowInset)
		{
			const string __id = "shadowInset.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowInset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_show_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_view_View_Handler ()
		{
			if (cb_show_Landroid_view_View_ == null)
				cb_show_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Show_Landroid_view_View_);
			return cb_show_Landroid_view_View_;
		}

		static IntPtr n_Show_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_anchor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var anchor = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_anchor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Show (anchor));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("show", "(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetShow_Landroid_view_View_Handler")]
		public virtual unsafe global::Java.Lang.Object Show (global::Android.Views.View anchor)
		{
			const string __id = "show.(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((anchor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchor).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (anchor);
			}
		}

		static Delegate cb_view_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetView_Landroid_view_View_Handler ()
		{
			if (cb_view_Landroid_view_View_ == null)
				cb_view_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_View_Landroid_view_View_);
			return cb_view_Landroid_view_View_;
		}

		static IntPtr n_View_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_contentView, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.View (contentView));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='view' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("view", "(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetView_Landroid_view_View_Handler")]
		public virtual unsafe global::Java.Lang.Object View (global::Android.Views.View contentView)
		{
			const string __id = "view.(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((contentView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentView).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (contentView);
			}
		}

		static Delegate cb_view_I;
#pragma warning disable 0169
		static Delegate GetView_IHandler ()
		{
			if (cb_view_I == null)
				cb_view_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_View_I);
			return cb_view_I;
		}

		static IntPtr n_View_I (IntPtr jnienv, IntPtr native__this, int contentViewResId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View (contentViewResId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUINormalPopup']/method[@name='view' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("view", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetView_IHandler")]
		public virtual unsafe global::Java.Lang.Object View (int contentViewResId)
		{
			const string __id = "view.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (contentViewResId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
