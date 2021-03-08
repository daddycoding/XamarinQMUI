using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/QMUISkinValueBuilder", DoNotGenerateAcw=true)]
	public partial class QMUISkinValueBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/QMUISkinValueBuilder", typeof (QMUISkinValueBuilder));
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

		protected QMUISkinValueBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Acquire ()
		{
			const string __id = "acquire.()Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_alpha_I;
#pragma warning disable 0169
		static Delegate GetAlpha_IHandler ()
		{
			if (cb_alpha_I == null)
				cb_alpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Alpha_I);
			return cb_alpha_I;
		}

		static IntPtr n_Alpha_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Alpha (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alpha", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetAlpha_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Alpha (int attr)
		{
			const string __id = "alpha.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_alpha_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAlpha_Ljava_lang_String_Handler ()
		{
			if (cb_alpha_Ljava_lang_String_ == null)
				cb_alpha_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Alpha_Ljava_lang_String_);
			return cb_alpha_Ljava_lang_String_;
		}

		static IntPtr n_Alpha_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Alpha (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("alpha", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetAlpha_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Alpha (string attrName)
		{
			const string __id = "alpha.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_background_I;
#pragma warning disable 0169
		static Delegate GetBackground_IHandler ()
		{
			if (cb_background_I == null)
				cb_background_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Background_I);
			return cb_background_I;
		}

		static IntPtr n_Background_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Background (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='background' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("background", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBackground_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Background (int attr)
		{
			const string __id = "background.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_background_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBackground_Ljava_lang_String_Handler ()
		{
			if (cb_background_Ljava_lang_String_ == null)
				cb_background_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Background_Ljava_lang_String_);
			return cb_background_Ljava_lang_String_;
		}

		static IntPtr n_Background_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Background (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='background' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("background", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBackground_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Background (string attrName)
		{
			const string __id = "background.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_bgTintColor_I;
#pragma warning disable 0169
		static Delegate GetBgTintColor_IHandler ()
		{
			if (cb_bgTintColor_I == null)
				cb_bgTintColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_BgTintColor_I);
			return cb_bgTintColor_I;
		}

		static IntPtr n_BgTintColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BgTintColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='bgTintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bgTintColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBgTintColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder BgTintColor (int attr)
		{
			const string __id = "bgTintColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_bgTintColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBgTintColor_Ljava_lang_String_Handler ()
		{
			if (cb_bgTintColor_Ljava_lang_String_ == null)
				cb_bgTintColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BgTintColor_Ljava_lang_String_);
			return cb_bgTintColor_Ljava_lang_String_;
		}

		static IntPtr n_BgTintColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BgTintColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='bgTintColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bgTintColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBgTintColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder BgTintColor (string attrName)
		{
			const string __id = "bgTintColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_border_I;
#pragma warning disable 0169
		static Delegate GetBorder_IHandler ()
		{
			if (cb_border_I == null)
				cb_border_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Border_I);
			return cb_border_I;
		}

		static IntPtr n_Border_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Border (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='border' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("border", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBorder_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Border (int attr)
		{
			const string __id = "border.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_border_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBorder_Ljava_lang_String_Handler ()
		{
			if (cb_border_Ljava_lang_String_ == null)
				cb_border_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Border_Ljava_lang_String_);
			return cb_border_Ljava_lang_String_;
		}

		static IntPtr n_Border_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Border (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='border' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("border", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBorder_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Border (string attrName)
		{
			const string __id = "border.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_bottomSeparator_I;
#pragma warning disable 0169
		static Delegate GetBottomSeparator_IHandler ()
		{
			if (cb_bottomSeparator_I == null)
				cb_bottomSeparator_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_BottomSeparator_I);
			return cb_bottomSeparator_I;
		}

		static IntPtr n_BottomSeparator_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BottomSeparator (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='bottomSeparator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bottomSeparator", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBottomSeparator_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder BottomSeparator (int attr)
		{
			const string __id = "bottomSeparator.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_bottomSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBottomSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_bottomSeparator_Ljava_lang_String_ == null)
				cb_bottomSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BottomSeparator_Ljava_lang_String_);
			return cb_bottomSeparator_Ljava_lang_String_;
		}

		static IntPtr n_BottomSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BottomSeparator (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='bottomSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bottomSeparator", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetBottomSeparator_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder BottomSeparator (string attrName)
		{
			const string __id = "bottomSeparator.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/String;", "GetBuildHandler")]
		public virtual unsafe string Build ()
		{
			const string __id = "build.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clear);
			return cb_clear;
		}

		static IntPtr n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetClearHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Clear ()
		{
			const string __id = "clear.()Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_convertFrom_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConvertFrom_Ljava_lang_String_Handler ()
		{
			if (cb_convertFrom_Ljava_lang_String_ == null)
				cb_convertFrom_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertFrom_Ljava_lang_String_);
			return cb_convertFrom_Ljava_lang_String_;
		}

		static IntPtr n_ConvertFrom_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertFrom (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='convertFrom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertFrom", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetConvertFrom_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder ConvertFrom (string value)
		{
			const string __id = "convertFrom.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_custom_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCustom_Ljava_lang_String_IHandler ()
		{
			if (cb_custom_Ljava_lang_String_I == null)
				cb_custom_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_Custom_Ljava_lang_String_I);
			return cb_custom_Ljava_lang_String_I;
		}

		static IntPtr n_Custom_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Custom (name, attr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='custom' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("custom", "(Ljava/lang/String;I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetCustom_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Custom (string name, int attr)
		{
			const string __id = "custom.(Ljava/lang/String;I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_custom_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCustom_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_custom_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_custom_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Custom_Ljava_lang_String_Ljava_lang_String_);
			return cb_custom_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Custom_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Custom (name, attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='custom' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("custom", "(Ljava/lang/String;Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetCustom_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Custom (string name, string attrName)
		{
			const string __id = "custom.(Ljava/lang/String;Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_hintColor_I;
#pragma warning disable 0169
		static Delegate GetHintColor_IHandler ()
		{
			if (cb_hintColor_I == null)
				cb_hintColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_HintColor_I);
			return cb_hintColor_I;
		}

		static IntPtr n_HintColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HintColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='hintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hintColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetHintColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder HintColor (int attr)
		{
			const string __id = "hintColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hintColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHintColor_Ljava_lang_String_Handler ()
		{
			if (cb_hintColor_Ljava_lang_String_ == null)
				cb_hintColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_HintColor_Ljava_lang_String_);
			return cb_hintColor_Ljava_lang_String_;
		}

		static IntPtr n_HintColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HintColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='hintColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hintColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetHintColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder HintColor (string attrName)
		{
			const string __id = "hintColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_leftSeparator_I;
#pragma warning disable 0169
		static Delegate GetLeftSeparator_IHandler ()
		{
			if (cb_leftSeparator_I == null)
				cb_leftSeparator_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_LeftSeparator_I);
			return cb_leftSeparator_I;
		}

		static IntPtr n_LeftSeparator_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LeftSeparator (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='leftSeparator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("leftSeparator", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetLeftSeparator_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder LeftSeparator (int attr)
		{
			const string __id = "leftSeparator.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_leftSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeftSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_leftSeparator_Ljava_lang_String_ == null)
				cb_leftSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LeftSeparator_Ljava_lang_String_);
			return cb_leftSeparator_Ljava_lang_String_;
		}

		static IntPtr n_LeftSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LeftSeparator (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='leftSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leftSeparator", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetLeftSeparator_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder LeftSeparator (string attrName)
		{
			const string __id = "leftSeparator.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_moreBgColor_I;
#pragma warning disable 0169
		static Delegate GetMoreBgColor_IHandler ()
		{
			if (cb_moreBgColor_I == null)
				cb_moreBgColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_MoreBgColor_I);
			return cb_moreBgColor_I;
		}

		static IntPtr n_MoreBgColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoreBgColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='moreBgColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("moreBgColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetMoreBgColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder MoreBgColor (int attr)
		{
			const string __id = "moreBgColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_moreBgColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMoreBgColor_Ljava_lang_String_Handler ()
		{
			if (cb_moreBgColor_Ljava_lang_String_ == null)
				cb_moreBgColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MoreBgColor_Ljava_lang_String_);
			return cb_moreBgColor_Ljava_lang_String_;
		}

		static IntPtr n_MoreBgColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MoreBgColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='moreBgColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("moreBgColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetMoreBgColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder MoreBgColor (string attrName)
		{
			const string __id = "moreBgColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_moreTextColor_I;
#pragma warning disable 0169
		static Delegate GetMoreTextColor_IHandler ()
		{
			if (cb_moreTextColor_I == null)
				cb_moreTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_MoreTextColor_I);
			return cb_moreTextColor_I;
		}

		static IntPtr n_MoreTextColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoreTextColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='moreTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("moreTextColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetMoreTextColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder MoreTextColor (int attr)
		{
			const string __id = "moreTextColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_moreTextColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMoreTextColor_Ljava_lang_String_Handler ()
		{
			if (cb_moreTextColor_Ljava_lang_String_ == null)
				cb_moreTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MoreTextColor_Ljava_lang_String_);
			return cb_moreTextColor_Ljava_lang_String_;
		}

		static IntPtr n_MoreTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MoreTextColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='moreTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("moreTextColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetMoreTextColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder MoreTextColor (string attrName)
		{
			const string __id = "moreTextColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_progressColor_I;
#pragma warning disable 0169
		static Delegate GetProgressColor_IHandler ()
		{
			if (cb_progressColor_I == null)
				cb_progressColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ProgressColor_I);
			return cb_progressColor_I;
		}

		static IntPtr n_ProgressColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='progressColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("progressColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetProgressColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder ProgressColor (int attr)
		{
			const string __id = "progressColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_progressColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProgressColor_Ljava_lang_String_Handler ()
		{
			if (cb_progressColor_Ljava_lang_String_ == null)
				cb_progressColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ProgressColor_Ljava_lang_String_);
			return cb_progressColor_Ljava_lang_String_;
		}

		static IntPtr n_ProgressColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProgressColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='progressColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("progressColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetProgressColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder ProgressColor (string attrName)
		{
			const string __id = "progressColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("release", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "")]
		public static unsafe void Release (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder valueBuilder)
		{
			const string __id = "release.(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((valueBuilder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueBuilder).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (valueBuilder);
			}
		}

		static Delegate cb_rightSeparator_I;
#pragma warning disable 0169
		static Delegate GetRightSeparator_IHandler ()
		{
			if (cb_rightSeparator_I == null)
				cb_rightSeparator_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_RightSeparator_I);
			return cb_rightSeparator_I;
		}

		static IntPtr n_RightSeparator_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RightSeparator (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='rightSeparator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rightSeparator", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetRightSeparator_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder RightSeparator (int attr)
		{
			const string __id = "rightSeparator.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rightSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRightSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_rightSeparator_Ljava_lang_String_ == null)
				cb_rightSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RightSeparator_Ljava_lang_String_);
			return cb_rightSeparator_Ljava_lang_String_;
		}

		static IntPtr n_RightSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RightSeparator (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='rightSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rightSeparator", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetRightSeparator_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder RightSeparator (string attrName)
		{
			const string __id = "rightSeparator.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_secondTextColor_I;
#pragma warning disable 0169
		static Delegate GetSecondTextColor_IHandler ()
		{
			if (cb_secondTextColor_I == null)
				cb_secondTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SecondTextColor_I);
			return cb_secondTextColor_I;
		}

		static IntPtr n_SecondTextColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SecondTextColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='secondTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("secondTextColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetSecondTextColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder SecondTextColor (int attr)
		{
			const string __id = "secondTextColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_secondTextColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSecondTextColor_Ljava_lang_String_Handler ()
		{
			if (cb_secondTextColor_Ljava_lang_String_ == null)
				cb_secondTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SecondTextColor_Ljava_lang_String_);
			return cb_secondTextColor_Ljava_lang_String_;
		}

		static IntPtr n_SecondTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SecondTextColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='secondTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("secondTextColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetSecondTextColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder SecondTextColor (string attrName)
		{
			const string __id = "secondTextColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_src_I;
#pragma warning disable 0169
		static Delegate GetSrc_IHandler ()
		{
			if (cb_src_I == null)
				cb_src_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Src_I);
			return cb_src_I;
		}

		static IntPtr n_Src_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Src (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='src' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("src", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetSrc_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Src (int attr)
		{
			const string __id = "src.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_src_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSrc_Ljava_lang_String_Handler ()
		{
			if (cb_src_Ljava_lang_String_ == null)
				cb_src_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Src_Ljava_lang_String_);
			return cb_src_Ljava_lang_String_;
		}

		static IntPtr n_Src_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Src (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='src' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("src", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetSrc_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Src (string attrName)
		{
			const string __id = "src.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_textColor_I;
#pragma warning disable 0169
		static Delegate GetTextColor_IHandler ()
		{
			if (cb_textColor_I == null)
				cb_textColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextColor_I);
			return cb_textColor_I;
		}

		static IntPtr n_TextColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextColor (int attr)
		{
			const string __id = "textColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTextColor_Ljava_lang_String_Handler ()
		{
			if (cb_textColor_Ljava_lang_String_ == null)
				cb_textColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TextColor_Ljava_lang_String_);
			return cb_textColor_Ljava_lang_String_;
		}

		static IntPtr n_TextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextColor (string attrName)
		{
			const string __id = "textColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_textCompoundBottomSrc_I;
#pragma warning disable 0169
		static Delegate GetTextCompoundBottomSrc_IHandler ()
		{
			if (cb_textCompoundBottomSrc_I == null)
				cb_textCompoundBottomSrc_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextCompoundBottomSrc_I);
			return cb_textCompoundBottomSrc_I;
		}

		static IntPtr n_TextCompoundBottomSrc_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextCompoundBottomSrc (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundBottomSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textCompoundBottomSrc", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundBottomSrc_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundBottomSrc (int attr)
		{
			const string __id = "textCompoundBottomSrc.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textCompoundBottomSrc_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTextCompoundBottomSrc_Ljava_lang_String_Handler ()
		{
			if (cb_textCompoundBottomSrc_Ljava_lang_String_ == null)
				cb_textCompoundBottomSrc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TextCompoundBottomSrc_Ljava_lang_String_);
			return cb_textCompoundBottomSrc_Ljava_lang_String_;
		}

		static IntPtr n_TextCompoundBottomSrc_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextCompoundBottomSrc (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundBottomSrc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textCompoundBottomSrc", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundBottomSrc_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundBottomSrc (string attrName)
		{
			const string __id = "textCompoundBottomSrc.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_textCompoundLeftSrc_I;
#pragma warning disable 0169
		static Delegate GetTextCompoundLeftSrc_IHandler ()
		{
			if (cb_textCompoundLeftSrc_I == null)
				cb_textCompoundLeftSrc_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextCompoundLeftSrc_I);
			return cb_textCompoundLeftSrc_I;
		}

		static IntPtr n_TextCompoundLeftSrc_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextCompoundLeftSrc (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundLeftSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textCompoundLeftSrc", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundLeftSrc_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundLeftSrc (int attr)
		{
			const string __id = "textCompoundLeftSrc.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textCompoundLeftSrc_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTextCompoundLeftSrc_Ljava_lang_String_Handler ()
		{
			if (cb_textCompoundLeftSrc_Ljava_lang_String_ == null)
				cb_textCompoundLeftSrc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TextCompoundLeftSrc_Ljava_lang_String_);
			return cb_textCompoundLeftSrc_Ljava_lang_String_;
		}

		static IntPtr n_TextCompoundLeftSrc_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextCompoundLeftSrc (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundLeftSrc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textCompoundLeftSrc", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundLeftSrc_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundLeftSrc (string attrName)
		{
			const string __id = "textCompoundLeftSrc.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_textCompoundRightSrc_I;
#pragma warning disable 0169
		static Delegate GetTextCompoundRightSrc_IHandler ()
		{
			if (cb_textCompoundRightSrc_I == null)
				cb_textCompoundRightSrc_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextCompoundRightSrc_I);
			return cb_textCompoundRightSrc_I;
		}

		static IntPtr n_TextCompoundRightSrc_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextCompoundRightSrc (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundRightSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textCompoundRightSrc", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundRightSrc_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundRightSrc (int attr)
		{
			const string __id = "textCompoundRightSrc.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textCompoundRightSrc_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTextCompoundRightSrc_Ljava_lang_String_Handler ()
		{
			if (cb_textCompoundRightSrc_Ljava_lang_String_ == null)
				cb_textCompoundRightSrc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TextCompoundRightSrc_Ljava_lang_String_);
			return cb_textCompoundRightSrc_Ljava_lang_String_;
		}

		static IntPtr n_TextCompoundRightSrc_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextCompoundRightSrc (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundRightSrc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textCompoundRightSrc", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundRightSrc_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundRightSrc (string attrName)
		{
			const string __id = "textCompoundRightSrc.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_textCompoundTintColor_I;
#pragma warning disable 0169
		static Delegate GetTextCompoundTintColor_IHandler ()
		{
			if (cb_textCompoundTintColor_I == null)
				cb_textCompoundTintColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextCompoundTintColor_I);
			return cb_textCompoundTintColor_I;
		}

		static IntPtr n_TextCompoundTintColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextCompoundTintColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundTintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textCompoundTintColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundTintColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundTintColor (int attr)
		{
			const string __id = "textCompoundTintColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textCompoundTintColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTextCompoundTintColor_Ljava_lang_String_Handler ()
		{
			if (cb_textCompoundTintColor_Ljava_lang_String_ == null)
				cb_textCompoundTintColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TextCompoundTintColor_Ljava_lang_String_);
			return cb_textCompoundTintColor_Ljava_lang_String_;
		}

		static IntPtr n_TextCompoundTintColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextCompoundTintColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundTintColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textCompoundTintColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundTintColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundTintColor (string attrName)
		{
			const string __id = "textCompoundTintColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_textCompoundTopSrc_I;
#pragma warning disable 0169
		static Delegate GetTextCompoundTopSrc_IHandler ()
		{
			if (cb_textCompoundTopSrc_I == null)
				cb_textCompoundTopSrc_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextCompoundTopSrc_I);
			return cb_textCompoundTopSrc_I;
		}

		static IntPtr n_TextCompoundTopSrc_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextCompoundTopSrc (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundTopSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textCompoundTopSrc", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundTopSrc_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundTopSrc (int attr)
		{
			const string __id = "textCompoundTopSrc.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textCompoundTopSrc_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTextCompoundTopSrc_Ljava_lang_String_Handler ()
		{
			if (cb_textCompoundTopSrc_Ljava_lang_String_ == null)
				cb_textCompoundTopSrc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TextCompoundTopSrc_Ljava_lang_String_);
			return cb_textCompoundTopSrc_Ljava_lang_String_;
		}

		static IntPtr n_TextCompoundTopSrc_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextCompoundTopSrc (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='textCompoundTopSrc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("textCompoundTopSrc", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTextCompoundTopSrc_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TextCompoundTopSrc (string attrName)
		{
			const string __id = "textCompoundTopSrc.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_tintColor_I;
#pragma warning disable 0169
		static Delegate GetTintColor_IHandler ()
		{
			if (cb_tintColor_I == null)
				cb_tintColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TintColor_I);
			return cb_tintColor_I;
		}

		static IntPtr n_TintColor_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TintColor (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='tintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("tintColor", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTintColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TintColor (int attr)
		{
			const string __id = "tintColor.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_tintColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTintColor_Ljava_lang_String_Handler ()
		{
			if (cb_tintColor_Ljava_lang_String_ == null)
				cb_tintColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TintColor_Ljava_lang_String_);
			return cb_tintColor_Ljava_lang_String_;
		}

		static IntPtr n_TintColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TintColor (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='tintColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tintColor", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTintColor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TintColor (string attrName)
		{
			const string __id = "tintColor.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_topSeparator_I;
#pragma warning disable 0169
		static Delegate GetTopSeparator_IHandler ()
		{
			if (cb_topSeparator_I == null)
				cb_topSeparator_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TopSeparator_I);
			return cb_topSeparator_I;
		}

		static IntPtr n_TopSeparator_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopSeparator (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='topSeparator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("topSeparator", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTopSeparator_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TopSeparator (int attr)
		{
			const string __id = "topSeparator.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_topSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTopSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_topSeparator_Ljava_lang_String_ == null)
				cb_topSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TopSeparator_Ljava_lang_String_);
			return cb_topSeparator_Ljava_lang_String_;
		}

		static IntPtr n_TopSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TopSeparator (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='topSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("topSeparator", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetTopSeparator_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder TopSeparator (string attrName)
		{
			const string __id = "topSeparator.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		static Delegate cb_underline_I;
#pragma warning disable 0169
		static Delegate GetUnderline_IHandler ()
		{
			if (cb_underline_I == null)
				cb_underline_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Underline_I);
			return cb_underline_I;
		}

		static IntPtr n_Underline_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Underline (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='underline' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("underline", "(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetUnderline_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Underline (int attr)
		{
			const string __id = "underline.(I)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_underline_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnderline_Ljava_lang_String_Handler ()
		{
			if (cb_underline_Ljava_lang_String_ == null)
				cb_underline_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Underline_Ljava_lang_String_);
			return cb_underline_Ljava_lang_String_;
		}

		static IntPtr n_Underline_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attrName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attrName = JNIEnv.GetString (native_attrName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Underline (attrName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinValueBuilder']/method[@name='underline' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("underline", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;", "GetUnderline_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder Underline (string attrName)
		{
			const string __id = "underline.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

	}
}
