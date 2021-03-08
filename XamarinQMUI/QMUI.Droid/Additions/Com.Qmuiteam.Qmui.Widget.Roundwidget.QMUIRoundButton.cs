using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Roundwidget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/roundwidget/QMUIRoundButton", DoNotGenerateAcw=true)]
	public partial class QMUIRoundButton : global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaButton, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/roundwidget/QMUIRoundButton", typeof (QMUIRoundButton));
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

		protected QMUIRoundButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/constructor[@name='QMUIRoundButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIRoundButton (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/constructor[@name='QMUIRoundButton' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIRoundButton (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/constructor[@name='QMUIRoundButton' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIRoundButton (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Roundwidget.QMUIRoundButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
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

		static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetStrokeWidthHandler ()
		{
			if (cb_getStrokeWidth == null)
				cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStrokeWidth);
			return cb_getStrokeWidth;
		}

		static int n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Roundwidget.QMUIRoundButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()I", "GetGetStrokeWidthHandler")]
			get {
				const string __id = "getStrokeWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_setBgData_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetBgData_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setBgData_Landroid_content_res_ColorStateList_ == null)
				cb_setBgData_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBgData_Landroid_content_res_ColorStateList_);
			return cb_setBgData_Landroid_content_res_ColorStateList_;
		}

		static void n_SetBgData_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Roundwidget.QMUIRoundButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.SetBgData (colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/method[@name='setBgData' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setBgData", "(Landroid/content/res/ColorStateList;)V", "GetSetBgData_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetBgData (global::Android.Content.Res.ColorStateList colors)
		{
			const string __id = "setBgData.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colors == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colors).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (colors);
			}
		}

		static Delegate cb_setStrokeColors_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetStrokeColors_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setStrokeColors_Landroid_content_res_ColorStateList_ == null)
				cb_setStrokeColors_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStrokeColors_Landroid_content_res_ColorStateList_);
			return cb_setStrokeColors_Landroid_content_res_ColorStateList_;
		}

		static void n_SetStrokeColors_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Roundwidget.QMUIRoundButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeColors (colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/method[@name='setStrokeColors' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setStrokeColors", "(Landroid/content/res/ColorStateList;)V", "GetSetStrokeColors_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetStrokeColors (global::Android.Content.Res.ColorStateList colors)
		{
			const string __id = "setStrokeColors.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colors == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colors).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (colors);
			}
		}

		static Delegate cb_setStrokeData_ILandroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetStrokeData_ILandroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setStrokeData_ILandroid_content_res_ColorStateList_ == null)
				cb_setStrokeData_ILandroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetStrokeData_ILandroid_content_res_ColorStateList_);
			return cb_setStrokeData_ILandroid_content_res_ColorStateList_;
		}

		static void n_SetStrokeData_ILandroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, int width, IntPtr native_colors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Roundwidget.QMUIRoundButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeData (width, colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.roundwidget']/class[@name='QMUIRoundButton']/method[@name='setStrokeData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.res.ColorStateList']]"
		[Register ("setStrokeData", "(ILandroid/content/res/ColorStateList;)V", "GetSetStrokeData_ILandroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetStrokeData (int width, global::Android.Content.Res.ColorStateList colors)
		{
			const string __id = "setStrokeData.(ILandroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue ((colors == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colors).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (colors);
			}
		}

	}
}
