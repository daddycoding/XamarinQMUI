using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.DefaultAttr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin.defaultAttr']/class[@name='QMUISkinSimpleDefaultAttrProvider']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/defaultAttr/QMUISkinSimpleDefaultAttrProvider", DoNotGenerateAcw=true)]
	public partial class QMUISkinSimpleDefaultAttrProvider : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/defaultAttr/QMUISkinSimpleDefaultAttrProvider", typeof (QMUISkinSimpleDefaultAttrProvider));
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

		protected QMUISkinSimpleDefaultAttrProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin.defaultAttr']/class[@name='QMUISkinSimpleDefaultAttrProvider']/constructor[@name='QMUISkinSimpleDefaultAttrProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinSimpleDefaultAttrProvider ()
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

		static Delegate cb_getDefaultSkinAttrs;
#pragma warning disable 0169
		static Delegate GetGetDefaultSkinAttrsHandler ()
		{
			if (cb_getDefaultSkinAttrs == null)
				cb_getDefaultSkinAttrs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultSkinAttrs);
			return cb_getDefaultSkinAttrs;
		}

		static IntPtr n_GetDefaultSkinAttrs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.QMUISkinSimpleDefaultAttrProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.defaultAttr']/class[@name='QMUISkinSimpleDefaultAttrProvider']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
			[Register ("getDefaultSkinAttrs", "()Landroidx/collection/SimpleArrayMap;", "GetGetDefaultSkinAttrsHandler")]
			get {
				const string __id = "getDefaultSkinAttrs.()Landroidx/collection/SimpleArrayMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setDefaultSkinAttr_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultSkinAttr_Ljava_lang_String_IHandler ()
		{
			if (cb_setDefaultSkinAttr_Ljava_lang_String_I == null)
				cb_setDefaultSkinAttr_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetDefaultSkinAttr_Ljava_lang_String_I);
			return cb_setDefaultSkinAttr_Ljava_lang_String_I;
		}

		static void n_SetDefaultSkinAttr_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.QMUISkinSimpleDefaultAttrProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultSkinAttr (name, attr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.defaultAttr']/class[@name='QMUISkinSimpleDefaultAttrProvider']/method[@name='setDefaultSkinAttr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setDefaultSkinAttr", "(Ljava/lang/String;I)V", "GetSetDefaultSkinAttr_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetDefaultSkinAttr (string name, int attr)
		{
			const string __id = "setDefaultSkinAttr.(Ljava/lang/String;I)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (attr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
