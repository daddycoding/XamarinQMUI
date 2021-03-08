using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Qqface {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']"
	[Register ("com/qmuiteam/qmui/qqface/IQMUIQQFaceManager", "", "Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker")]
	public partial interface IQMUIQQFaceManager : IJavaObject, IJavaPeerable {

		int SpecialDrawableMaxHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='getSpecialDrawableMaxHeight' and count(parameter)=0]"
			[Register ("getSpecialDrawableMaxHeight", "()I", "GetGetSpecialDrawableMaxHeightHandler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='getDoubleUnicodeEmoji' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDoubleUnicodeEmoji", "(II)I", "GetGetDoubleUnicodeEmoji_IIHandler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")]
		int GetDoubleUnicodeEmoji (int currentCodePoint, int nextCodePoint);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='getEmojiResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEmojiResource", "(I)I", "GetGetEmojiResource_IHandler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")]
		int GetEmojiResource (int codePoint);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='getQQfaceResource' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("getQQfaceResource", "(Ljava/lang/CharSequence;)I", "GetGetQQfaceResource_Ljava_lang_CharSequence_Handler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")]
		int GetQQfaceResource (global::Java.Lang.ICharSequence text);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='getSoftbankEmojiResource' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("getSoftbankEmojiResource", "(C)I", "GetGetSoftbankEmojiResource_CHandler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")]
		int GetSoftbankEmojiResource (char c);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='getSpecialBoundsDrawable' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("getSpecialBoundsDrawable", "(Ljava/lang/CharSequence;)Landroid/graphics/drawable/Drawable;", "GetGetSpecialBoundsDrawable_Ljava_lang_CharSequence_Handler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")]
		global::Android.Graphics.Drawables.Drawable GetSpecialBoundsDrawable (global::Java.Lang.ICharSequence text);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='maybeEmoji' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maybeEmoji", "(I)Z", "GetMaybeEmoji_IHandler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")]
		bool MaybeEmoji (int codePoint);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/interface[@name='IQMUIQQFaceManager']/method[@name='maybeSoftBankEmoji' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("maybeSoftBankEmoji", "(C)Z", "GetMaybeSoftBankEmoji_CHandler:Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManagerInvoker, QMUI.Droid")]
		bool MaybeSoftBankEmoji (char c);

	}

	public static partial class IQMUIQQFaceManagerExtensions {

		public static int GetQQfaceResource (this Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager self, string text)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			int __result = self.GetQQfaceResource (jls_text);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
		}

		public static global::Android.Graphics.Drawables.Drawable GetSpecialBoundsDrawable (this Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager self, string text)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Android.Graphics.Drawables.Drawable __result = self.GetSpecialBoundsDrawable (jls_text);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
		}
	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/IQMUIQQFaceManager", DoNotGenerateAcw=true)]
	internal partial class IQMUIQQFaceManagerInvoker : global::Java.Lang.Object, IQMUIQQFaceManager {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/IQMUIQQFaceManager", typeof (IQMUIQQFaceManagerInvoker));

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

		public static IQMUIQQFaceManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUIQQFaceManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.qqface.IQMUIQQFaceManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUIQQFaceManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSpecialDrawableMaxHeight;
#pragma warning disable 0169
		static Delegate GetGetSpecialDrawableMaxHeightHandler ()
		{
			if (cb_getSpecialDrawableMaxHeight == null)
				cb_getSpecialDrawableMaxHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSpecialDrawableMaxHeight);
			return cb_getSpecialDrawableMaxHeight;
		}

		static int n_GetSpecialDrawableMaxHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpecialDrawableMaxHeight;
		}
#pragma warning restore 0169

		IntPtr id_getSpecialDrawableMaxHeight;
		public unsafe int SpecialDrawableMaxHeight {
			get {
				if (id_getSpecialDrawableMaxHeight == IntPtr.Zero)
					id_getSpecialDrawableMaxHeight = JNIEnv.GetMethodID (class_ref, "getSpecialDrawableMaxHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSpecialDrawableMaxHeight);
			}
		}

		static Delegate cb_getDoubleUnicodeEmoji_II;
#pragma warning disable 0169
		static Delegate GetGetDoubleUnicodeEmoji_IIHandler ()
		{
			if (cb_getDoubleUnicodeEmoji_II == null)
				cb_getDoubleUnicodeEmoji_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_GetDoubleUnicodeEmoji_II);
			return cb_getDoubleUnicodeEmoji_II;
		}

		static int n_GetDoubleUnicodeEmoji_II (IntPtr jnienv, IntPtr native__this, int currentCodePoint, int nextCodePoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDoubleUnicodeEmoji (currentCodePoint, nextCodePoint);
		}
#pragma warning restore 0169

		IntPtr id_getDoubleUnicodeEmoji_II;
		public unsafe int GetDoubleUnicodeEmoji (int currentCodePoint, int nextCodePoint)
		{
			if (id_getDoubleUnicodeEmoji_II == IntPtr.Zero)
				id_getDoubleUnicodeEmoji_II = JNIEnv.GetMethodID (class_ref, "getDoubleUnicodeEmoji", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (currentCodePoint);
			__args [1] = new JValue (nextCodePoint);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDoubleUnicodeEmoji_II, __args);
		}

		static Delegate cb_getEmojiResource_I;
#pragma warning disable 0169
		static Delegate GetGetEmojiResource_IHandler ()
		{
			if (cb_getEmojiResource_I == null)
				cb_getEmojiResource_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetEmojiResource_I);
			return cb_getEmojiResource_I;
		}

		static int n_GetEmojiResource_I (IntPtr jnienv, IntPtr native__this, int codePoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetEmojiResource (codePoint);
		}
#pragma warning restore 0169

		IntPtr id_getEmojiResource_I;
		public unsafe int GetEmojiResource (int codePoint)
		{
			if (id_getEmojiResource_I == IntPtr.Zero)
				id_getEmojiResource_I = JNIEnv.GetMethodID (class_ref, "getEmojiResource", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (codePoint);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEmojiResource_I, __args);
		}

		static Delegate cb_getQQfaceResource_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetGetQQfaceResource_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_getQQfaceResource_Ljava_lang_CharSequence_ == null)
				cb_getQQfaceResource_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetQQfaceResource_Ljava_lang_CharSequence_);
			return cb_getQQfaceResource_Ljava_lang_CharSequence_;
		}

		static int n_GetQQfaceResource_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetQQfaceResource (text);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getQQfaceResource_Ljava_lang_CharSequence_;
		public unsafe int GetQQfaceResource (global::Java.Lang.ICharSequence text)
		{
			if (id_getQQfaceResource_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_getQQfaceResource_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "getQQfaceResource", "(Ljava/lang/CharSequence;)I");
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_text);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQQfaceResource_Ljava_lang_CharSequence_, __args);
			JNIEnv.DeleteLocalRef (native_text);
			return __ret;
		}

		static Delegate cb_getSoftbankEmojiResource_C;
#pragma warning disable 0169
		static Delegate GetGetSoftbankEmojiResource_CHandler ()
		{
			if (cb_getSoftbankEmojiResource_C == null)
				cb_getSoftbankEmojiResource_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_I) n_GetSoftbankEmojiResource_C);
			return cb_getSoftbankEmojiResource_C;
		}

		static int n_GetSoftbankEmojiResource_C (IntPtr jnienv, IntPtr native__this, char c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSoftbankEmojiResource (c);
		}
#pragma warning restore 0169

		IntPtr id_getSoftbankEmojiResource_C;
		public unsafe int GetSoftbankEmojiResource (char c)
		{
			if (id_getSoftbankEmojiResource_C == IntPtr.Zero)
				id_getSoftbankEmojiResource_C = JNIEnv.GetMethodID (class_ref, "getSoftbankEmojiResource", "(C)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (c);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSoftbankEmojiResource_C, __args);
		}

		static Delegate cb_getSpecialBoundsDrawable_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetGetSpecialBoundsDrawable_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_getSpecialBoundsDrawable_Ljava_lang_CharSequence_ == null)
				cb_getSpecialBoundsDrawable_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSpecialBoundsDrawable_Ljava_lang_CharSequence_);
			return cb_getSpecialBoundsDrawable_Ljava_lang_CharSequence_;
		}

		static IntPtr n_GetSpecialBoundsDrawable_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSpecialBoundsDrawable (text));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSpecialBoundsDrawable_Ljava_lang_CharSequence_;
		public unsafe global::Android.Graphics.Drawables.Drawable GetSpecialBoundsDrawable (global::Java.Lang.ICharSequence text)
		{
			if (id_getSpecialBoundsDrawable_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_getSpecialBoundsDrawable_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "getSpecialBoundsDrawable", "(Ljava/lang/CharSequence;)Landroid/graphics/drawable/Drawable;");
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_text);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpecialBoundsDrawable_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_text);
			return __ret;
		}

		static Delegate cb_maybeEmoji_I;
#pragma warning disable 0169
		static Delegate GetMaybeEmoji_IHandler ()
		{
			if (cb_maybeEmoji_I == null)
				cb_maybeEmoji_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_MaybeEmoji_I);
			return cb_maybeEmoji_I;
		}

		static bool n_MaybeEmoji_I (IntPtr jnienv, IntPtr native__this, int codePoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaybeEmoji (codePoint);
		}
#pragma warning restore 0169

		IntPtr id_maybeEmoji_I;
		public unsafe bool MaybeEmoji (int codePoint)
		{
			if (id_maybeEmoji_I == IntPtr.Zero)
				id_maybeEmoji_I = JNIEnv.GetMethodID (class_ref, "maybeEmoji", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (codePoint);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_maybeEmoji_I, __args);
		}

		static Delegate cb_maybeSoftBankEmoji_C;
#pragma warning disable 0169
		static Delegate GetMaybeSoftBankEmoji_CHandler ()
		{
			if (cb_maybeSoftBankEmoji_C == null)
				cb_maybeSoftBankEmoji_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_Z) n_MaybeSoftBankEmoji_C);
			return cb_maybeSoftBankEmoji_C;
		}

		static bool n_MaybeSoftBankEmoji_C (IntPtr jnienv, IntPtr native__this, char c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaybeSoftBankEmoji (c);
		}
#pragma warning restore 0169

		IntPtr id_maybeSoftBankEmoji_C;
		public unsafe bool MaybeSoftBankEmoji (char c)
		{
			if (id_maybeSoftBankEmoji_C == IntPtr.Zero)
				id_maybeSoftBankEmoji_C = JNIEnv.GetMethodID (class_ref, "maybeSoftBankEmoji", "(C)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (c);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_maybeSoftBankEmoji_C, __args);
		}

	}

}
