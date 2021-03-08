using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin.DefaultAttr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin.defaultAttr']/interface[@name='IQMUISkinDefaultAttrProvider']"
	[Register ("com/qmuiteam/qmui/skin/defaultAttr/IQMUISkinDefaultAttrProvider", "", "Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProviderInvoker")]
	public partial interface IQMUISkinDefaultAttrProvider : IJavaObject, IJavaPeerable {

		global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin.defaultAttr']/interface[@name='IQMUISkinDefaultAttrProvider']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
			[Register ("getDefaultSkinAttrs", "()Landroidx/collection/SimpleArrayMap;", "GetGetDefaultSkinAttrsHandler:Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProviderInvoker, QMUI.Droid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/defaultAttr/IQMUISkinDefaultAttrProvider", DoNotGenerateAcw=true)]
	internal partial class IQMUISkinDefaultAttrProviderInvoker : global::Java.Lang.Object, IQMUISkinDefaultAttrProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/defaultAttr/IQMUISkinDefaultAttrProvider", typeof (IQMUISkinDefaultAttrProviderInvoker));

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

		public static IQMUISkinDefaultAttrProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUISkinDefaultAttrProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.defaultAttr.IQMUISkinDefaultAttrProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUISkinDefaultAttrProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultSkinAttrs;
		public unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			get {
				if (id_getDefaultSkinAttrs == IntPtr.Zero)
					id_getDefaultSkinAttrs = JNIEnv.GetMethodID (class_ref, "getDefaultSkinAttrs", "()Landroidx/collection/SimpleArrayMap;");
				return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultSkinAttrs), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
