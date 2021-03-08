using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Qqface {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/qqface/QMUINoQQFaceManager", DoNotGenerateAcw=true)]
	public partial class QMUINoQQFaceManager : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Qqface.IQMUIQQFaceManager {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/qqface/QMUINoQQFaceManager", typeof (QMUINoQQFaceManager));
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

		protected QMUINoQQFaceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/constructor[@name='QMUINoQQFaceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUINoQQFaceManager ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpecialDrawableMaxHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int SpecialDrawableMaxHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='getSpecialDrawableMaxHeight' and count(parameter)=0]"
			[Register ("getSpecialDrawableMaxHeight", "()I", "GetGetSpecialDrawableMaxHeightHandler")]
			get {
				const string __id = "getSpecialDrawableMaxHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDoubleUnicodeEmoji (currentCodePoint, nextCodePoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='getDoubleUnicodeEmoji' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDoubleUnicodeEmoji", "(II)I", "GetGetDoubleUnicodeEmoji_IIHandler")]
		public virtual unsafe int GetDoubleUnicodeEmoji (int currentCodePoint, int nextCodePoint)
		{
			const string __id = "getDoubleUnicodeEmoji.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (currentCodePoint);
				__args [1] = new JniArgumentValue (nextCodePoint);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetEmojiResource (codePoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='getEmojiResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEmojiResource", "(I)I", "GetGetEmojiResource_IHandler")]
		public virtual unsafe int GetEmojiResource (int codePoint)
		{
			const string __id = "getEmojiResource.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (codePoint);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetQQfaceResource (text);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='getQQfaceResource' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("getQQfaceResource", "(Ljava/lang/CharSequence;)I", "GetGetQQfaceResource_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe int GetQQfaceResource (global::Java.Lang.ICharSequence text)
		{
			const string __id = "getQQfaceResource.(Ljava/lang/CharSequence;)I";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
			}
		}

		public int GetQQfaceResource (string text)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			int __result = GetQQfaceResource (jls_text);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSoftbankEmojiResource (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='getSoftbankEmojiResource' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("getSoftbankEmojiResource", "(C)I", "GetGetSoftbankEmojiResource_CHandler")]
		public virtual unsafe int GetSoftbankEmojiResource (char c)
		{
			const string __id = "getSoftbankEmojiResource.(C)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSpecialBoundsDrawable (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='getSpecialBoundsDrawable' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("getSpecialBoundsDrawable", "(Ljava/lang/CharSequence;)Landroid/graphics/drawable/Drawable;", "GetGetSpecialBoundsDrawable_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable GetSpecialBoundsDrawable (global::Java.Lang.ICharSequence text)
		{
			const string __id = "getSpecialBoundsDrawable.(Ljava/lang/CharSequence;)Landroid/graphics/drawable/Drawable;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
			}
		}

		public global::Android.Graphics.Drawables.Drawable GetSpecialBoundsDrawable (string text)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Android.Graphics.Drawables.Drawable __result = GetSpecialBoundsDrawable (jls_text);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaybeEmoji (codePoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='maybeEmoji' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maybeEmoji", "(I)Z", "GetMaybeEmoji_IHandler")]
		public virtual unsafe bool MaybeEmoji (int codePoint)
		{
			const string __id = "maybeEmoji.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (codePoint);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUINoQQFaceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaybeSoftBankEmoji (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.qqface']/class[@name='QMUINoQQFaceManager']/method[@name='maybeSoftBankEmoji' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("maybeSoftBankEmoji", "(C)Z", "GetMaybeSoftBankEmoji_CHandler")]
		public virtual unsafe bool MaybeSoftBankEmoji (char c)
		{
			const string __id = "maybeSoftBankEmoji.(C)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
