using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinLayoutInflaterFactory']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/QMUISkinLayoutInflaterFactory", DoNotGenerateAcw=true)]
	public partial class QMUISkinLayoutInflaterFactory : global::Java.Lang.Object, global::Android.Views.LayoutInflater.IFactory2 {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/QMUISkinLayoutInflaterFactory", typeof (QMUISkinLayoutInflaterFactory));
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

		protected QMUISkinLayoutInflaterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinLayoutInflaterFactory']/constructor[@name='QMUISkinLayoutInflaterFactory' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.LayoutInflater']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/view/LayoutInflater;)V", "")]
		public unsafe QMUISkinLayoutInflaterFactory (global::Android.App.Activity activity, global::Android.Views.LayoutInflater originLayoutInflater)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;Landroid/view/LayoutInflater;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((originLayoutInflater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) originLayoutInflater).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (originLayoutInflater);
			}
		}

		static Delegate cb_cloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_;
#pragma warning disable 0169
		static Delegate GetCloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_Handler ()
		{
			if (cb_cloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_ == null)
				cb_cloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_);
			return cb_cloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_;
		}

		static IntPtr n_CloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layoutInflater)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinLayoutInflaterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layoutInflater = global::Java.Lang.Object.GetObject<global::Android.Views.LayoutInflater> (native_layoutInflater, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CloneForLayoutInflaterIfNeeded (layoutInflater));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinLayoutInflaterFactory']/method[@name='cloneForLayoutInflaterIfNeeded' and count(parameter)=1 and parameter[1][@type='android.view.LayoutInflater']]"
		[Register ("cloneForLayoutInflaterIfNeeded", "(Landroid/view/LayoutInflater;)Lcom/qmuiteam/qmui/skin/QMUISkinLayoutInflaterFactory;", "GetCloneForLayoutInflaterIfNeeded_Landroid_view_LayoutInflater_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinLayoutInflaterFactory CloneForLayoutInflaterIfNeeded (global::Android.Views.LayoutInflater layoutInflater)
		{
			const string __id = "cloneForLayoutInflaterIfNeeded.(Landroid/view/LayoutInflater;)Lcom/qmuiteam/qmui/skin/QMUISkinLayoutInflaterFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layoutInflater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutInflater).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinLayoutInflaterFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (layoutInflater);
			}
		}

		static Delegate cb_getSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetGetSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_getSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_getSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_GetSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_getSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_GetSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_attrs, IntPtr native_builder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinLayoutInflaterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var attrs = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_attrs, JniHandleOwnership.DoNotTransfer);
			var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.GetSkinValueFromAttributeSet (context, attrs, builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinLayoutInflaterFactory']/method[@name='getSkinValueFromAttributeSet' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("getSkinValueFromAttributeSet", "(Landroid/content/Context;Landroid/util/AttributeSet;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetGetSkinValueFromAttributeSet_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		public virtual unsafe void GetSkinValueFromAttributeSet (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder builder)
		{
			const string __id = "getSkinValueFromAttributeSet.(Landroid/content/Context;Landroid/util/AttributeSet;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
				global::System.GC.KeepAlive (builder);
			}
		}

		static Delegate cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetOnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_OnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static IntPtr n_OnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_name, IntPtr native_context, IntPtr native_attrs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinLayoutInflaterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_parent, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var attrs = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_attrs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateView (parent, name, context, attrs));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinLayoutInflaterFactory']/method[@name='onCreateView' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context'] and parameter[4][@type='android.util.AttributeSet']]"
		[Register ("onCreateView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "GetOnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public virtual unsafe global::Android.Views.View OnCreateView (global::Android.Views.View parent, string name, global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "onCreateView.(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [3] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetOnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static IntPtr n_OnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_context, IntPtr native_attrs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinLayoutInflaterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var attrs = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_attrs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateView (name, context, attrs));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinLayoutInflaterFactory']/method[@name='onCreateView' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.util.AttributeSet']]"
		[Register ("onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "GetOnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public virtual unsafe global::Android.Views.View OnCreateView (string name, global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "onCreateView.(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [2] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

	}
}
