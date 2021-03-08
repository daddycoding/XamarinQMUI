using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabBuilder", DoNotGenerateAcw=true)]
	public partial class QMUITabBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabBuilder", typeof (QMUITabBuilder));
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

		protected QMUITabBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_build_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetBuild_Landroid_content_Context_Handler ()
		{
			if (cb_build_Landroid_content_Context_ == null)
				cb_build_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Build_Landroid_content_Context_);
			return cb_build_Landroid_content_Context_;
		}

		static IntPtr n_Build_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("build", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/tab/QMUITab;", "GetBuild_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab Build (global::Android.Content.Context context)
		{
			const string __id = "build.(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/tab/QMUITab;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_setAllowIconDrawOutside_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowIconDrawOutside_ZHandler ()
		{
			if (cb_setAllowIconDrawOutside_Z == null)
				cb_setAllowIconDrawOutside_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetAllowIconDrawOutside_Z);
			return cb_setAllowIconDrawOutside_Z;
		}

		static IntPtr n_SetAllowIconDrawOutside_Z (IntPtr jnienv, IntPtr native__this, bool allowIconDrawOutside)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAllowIconDrawOutside (allowIconDrawOutside));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setAllowIconDrawOutside' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowIconDrawOutside", "(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetAllowIconDrawOutside_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetAllowIconDrawOutside (bool allowIconDrawOutside)
		{
			const string __id = "setAllowIconDrawOutside.(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allowIconDrawOutside);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setColor_II;
#pragma warning disable 0169
		static Delegate GetSetColor_IIHandler ()
		{
			if (cb_setColor_II == null)
				cb_setColor_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SetColor_II);
			return cb_setColor_II;
		}

		static IntPtr n_SetColor_II (IntPtr jnienv, IntPtr native__this, int normalColor, int selectColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetColor (normalColor, selectColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setColor", "(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetColor_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetColor (int normalColor, int selectColor)
		{
			const string __id = "setColor.(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (normalColor);
				__args [1] = new JniArgumentValue (selectColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setColorAttr_II;
#pragma warning disable 0169
		static Delegate GetSetColorAttr_IIHandler ()
		{
			if (cb_setColorAttr_II == null)
				cb_setColorAttr_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SetColorAttr_II);
			return cb_setColorAttr_II;
		}

		static IntPtr n_SetColorAttr_II (IntPtr jnienv, IntPtr native__this, int normalColorAttr, int selectedColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetColorAttr (normalColorAttr, selectedColorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setColorAttr' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setColorAttr", "(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetColorAttr_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetColorAttr (int normalColorAttr, int selectedColorAttr)
		{
			const string __id = "setColorAttr.(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (normalColorAttr);
				__args [1] = new JniArgumentValue (selectedColorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDynamicChangeIconColor_Z;
#pragma warning disable 0169
		static Delegate GetSetDynamicChangeIconColor_ZHandler ()
		{
			if (cb_setDynamicChangeIconColor_Z == null)
				cb_setDynamicChangeIconColor_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetDynamicChangeIconColor_Z);
			return cb_setDynamicChangeIconColor_Z;
		}

		static IntPtr n_SetDynamicChangeIconColor_Z (IntPtr jnienv, IntPtr native__this, bool dynamicChangeIconColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDynamicChangeIconColor (dynamicChangeIconColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setDynamicChangeIconColor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDynamicChangeIconColor", "(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetDynamicChangeIconColor_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetDynamicChangeIconColor (bool dynamicChangeIconColor)
		{
			const string __id = "setDynamicChangeIconColor.(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dynamicChangeIconColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setGravity_I;
#pragma warning disable 0169
		static Delegate GetSetGravity_IHandler ()
		{
			if (cb_setGravity_I == null)
				cb_setGravity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetGravity_I);
			return cb_setGravity_I;
		}

		static IntPtr n_SetGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetGravity (gravity));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGravity", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetGravity_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetGravity (int gravity)
		{
			const string __id = "setGravity.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (gravity);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIconPosition_I;
#pragma warning disable 0169
		static Delegate GetSetIconPosition_IHandler ()
		{
			if (cb_setIconPosition_I == null)
				cb_setIconPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetIconPosition_I);
			return cb_setIconPosition_I;
		}

		static IntPtr n_SetIconPosition_I (IntPtr jnienv, IntPtr native__this, int iconPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIconPosition (iconPosition));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setIconPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIconPosition", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetIconPosition_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetIconPosition (int iconPosition)
		{
			const string __id = "setIconPosition.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (iconPosition);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIconTextGap_I;
#pragma warning disable 0169
		static Delegate GetSetIconTextGap_IHandler ()
		{
			if (cb_setIconTextGap_I == null)
				cb_setIconTextGap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetIconTextGap_I);
			return cb_setIconTextGap_I;
		}

		static IntPtr n_SetIconTextGap_I (IntPtr jnienv, IntPtr native__this, int iconTextGap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIconTextGap (iconTextGap));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setIconTextGap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIconTextGap", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetIconTextGap_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetIconTextGap (int iconTextGap)
		{
			const string __id = "setIconTextGap.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (iconTextGap);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNormalColor_I;
#pragma warning disable 0169
		static Delegate GetSetNormalColor_IHandler ()
		{
			if (cb_setNormalColor_I == null)
				cb_setNormalColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetNormalColor_I);
			return cb_setNormalColor_I;
		}

		static IntPtr n_SetNormalColor_I (IntPtr jnienv, IntPtr native__this, int normalColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNormalColor (normalColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setNormalColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNormalColor", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetNormalColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetNormalColor (int normalColor)
		{
			const string __id = "setNormalColor.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNormalColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSetNormalColorAttr_IHandler ()
		{
			if (cb_setNormalColorAttr_I == null)
				cb_setNormalColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetNormalColorAttr_I);
			return cb_setNormalColorAttr_I;
		}

		static IntPtr n_SetNormalColorAttr_I (IntPtr jnienv, IntPtr native__this, int normalColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNormalColorAttr (normalColorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setNormalColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNormalColorAttr", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetNormalColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetNormalColorAttr (int normalColorAttr)
		{
			const string __id = "setNormalColorAttr.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalColorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNormalDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetNormalDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setNormalDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setNormalDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetNormalDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setNormalDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetNormalDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normalDrawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var normalDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_normalDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNormalDrawable (normalDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setNormalDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setNormalDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetNormalDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetNormalDrawable (global::Android.Graphics.Drawables.Drawable normalDrawable)
		{
			const string __id = "setNormalDrawable.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((normalDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (normalDrawable);
			}
		}

		static Delegate cb_setNormalDrawableAttr_I;
#pragma warning disable 0169
		static Delegate GetSetNormalDrawableAttr_IHandler ()
		{
			if (cb_setNormalDrawableAttr_I == null)
				cb_setNormalDrawableAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetNormalDrawableAttr_I);
			return cb_setNormalDrawableAttr_I;
		}

		static IntPtr n_SetNormalDrawableAttr_I (IntPtr jnienv, IntPtr native__this, int normalDrawableAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNormalDrawableAttr (normalDrawableAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setNormalDrawableAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNormalDrawableAttr", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetNormalDrawableAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetNormalDrawableAttr (int normalDrawableAttr)
		{
			const string __id = "setNormalDrawableAttr.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalDrawableAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNormalIconSizeInfo_II;
#pragma warning disable 0169
		static Delegate GetSetNormalIconSizeInfo_IIHandler ()
		{
			if (cb_setNormalIconSizeInfo_II == null)
				cb_setNormalIconSizeInfo_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SetNormalIconSizeInfo_II);
			return cb_setNormalIconSizeInfo_II;
		}

		static IntPtr n_SetNormalIconSizeInfo_II (IntPtr jnienv, IntPtr native__this, int normalWidth, int normalHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNormalIconSizeInfo (normalWidth, normalHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setNormalIconSizeInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setNormalIconSizeInfo", "(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetNormalIconSizeInfo_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetNormalIconSizeInfo (int normalWidth, int normalHeight)
		{
			const string __id = "setNormalIconSizeInfo.(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (normalWidth);
				__args [1] = new JniArgumentValue (normalHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSelectColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectColor_IHandler ()
		{
			if (cb_setSelectColor_I == null)
				cb_setSelectColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSelectColor_I);
			return cb_setSelectColor_I;
		}

		static IntPtr n_SetSelectColor_I (IntPtr jnienv, IntPtr native__this, int selectColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSelectColor (selectColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setSelectColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectColor", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetSelectColor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetSelectColor (int selectColor)
		{
			const string __id = "setSelectColor.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (selectColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSelectedColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedColorAttr_IHandler ()
		{
			if (cb_setSelectedColorAttr_I == null)
				cb_setSelectedColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSelectedColorAttr_I);
			return cb_setSelectedColorAttr_I;
		}

		static IntPtr n_SetSelectedColorAttr_I (IntPtr jnienv, IntPtr native__this, int selectedColorAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSelectedColorAttr (selectedColorAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setSelectedColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectedColorAttr", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetSelectedColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetSelectedColorAttr (int selectedColorAttr)
		{
			const string __id = "setSelectedColorAttr.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (selectedColorAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSelectedDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetSelectedDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setSelectedDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setSelectedDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSelectedDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setSelectedDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetSelectedDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDrawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var selectedDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_selectedDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSelectedDrawable (selectedDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setSelectedDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setSelectedDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetSelectedDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetSelectedDrawable (global::Android.Graphics.Drawables.Drawable selectedDrawable)
		{
			const string __id = "setSelectedDrawable.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((selectedDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (selectedDrawable);
			}
		}

		static Delegate cb_setSelectedDrawableAttr_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedDrawableAttr_IHandler ()
		{
			if (cb_setSelectedDrawableAttr_I == null)
				cb_setSelectedDrawableAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSelectedDrawableAttr_I);
			return cb_setSelectedDrawableAttr_I;
		}

		static IntPtr n_SetSelectedDrawableAttr_I (IntPtr jnienv, IntPtr native__this, int selectedDrawableAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSelectedDrawableAttr (selectedDrawableAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setSelectedDrawableAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectedDrawableAttr", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetSelectedDrawableAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetSelectedDrawableAttr (int selectedDrawableAttr)
		{
			const string __id = "setSelectedDrawableAttr.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (selectedDrawableAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSelectedIconScale_F;
#pragma warning disable 0169
		static Delegate GetSetSelectedIconScale_FHandler ()
		{
			if (cb_setSelectedIconScale_F == null)
				cb_setSelectedIconScale_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_SetSelectedIconScale_F);
			return cb_setSelectedIconScale_F;
		}

		static IntPtr n_SetSelectedIconScale_F (IntPtr jnienv, IntPtr native__this, float selectedScale)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSelectedIconScale (selectedScale));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setSelectedIconScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSelectedIconScale", "(F)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetSelectedIconScale_FHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetSelectedIconScale (float selectedScale)
		{
			const string __id = "setSelectedIconScale.(F)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (selectedScale);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSignCount_I;
#pragma warning disable 0169
		static Delegate GetSetSignCount_IHandler ()
		{
			if (cb_setSignCount_I == null)
				cb_setSignCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSignCount_I);
			return cb_setSignCount_I;
		}

		static IntPtr n_SetSignCount_I (IntPtr jnienv, IntPtr native__this, int signCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSignCount (signCount));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setSignCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSignCount", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetSignCount_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetSignCount (int signCount)
		{
			const string __id = "setSignCount.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (signCount);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSignCountMarginInfo_III;
#pragma warning disable 0169
		static Delegate GetSetSignCountMarginInfo_IIIHandler ()
		{
			if (cb_setSignCountMarginInfo_III == null)
				cb_setSignCountMarginInfo_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_L) n_SetSignCountMarginInfo_III);
			return cb_setSignCountMarginInfo_III;
		}

		static IntPtr n_SetSignCountMarginInfo_III (IntPtr jnienv, IntPtr native__this, int digit, int leftMarginWithIconOrText, int bottomMarginWithIconOrText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSignCountMarginInfo (digit, leftMarginWithIconOrText, bottomMarginWithIconOrText));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setSignCountMarginInfo' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setSignCountMarginInfo", "(III)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetSignCountMarginInfo_IIIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetSignCountMarginInfo (int digit, int leftMarginWithIconOrText, int bottomMarginWithIconOrText)
		{
			const string __id = "setSignCountMarginInfo.(III)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (digit);
				__args [1] = new JniArgumentValue (leftMarginWithIconOrText);
				__args [2] = new JniArgumentValue (bottomMarginWithIconOrText);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setText_Ljava_lang_CharSequence_ == null)
				cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetText_Ljava_lang_CharSequence_);
			return cb_setText_Ljava_lang_CharSequence_;
		}

		static IntPtr n_SetText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetText (text));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setText", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetText_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetText (global::Java.Lang.ICharSequence text)
		{
			const string __id = "setText.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
			}
		}

		public global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetText (string text)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder __result = SetText (jls_text);
			var __rsval = __result;
			jls_text?.Dispose ();
			return __rsval;
		}

		static Delegate cb_setTextSize_II;
#pragma warning disable 0169
		static Delegate GetSetTextSize_IIHandler ()
		{
			if (cb_setTextSize_II == null)
				cb_setTextSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SetTextSize_II);
			return cb_setTextSize_II;
		}

		static IntPtr n_SetTextSize_II (IntPtr jnienv, IntPtr native__this, int normalTextSize, int selectedTextSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTextSize (normalTextSize, selectedTextSize));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setTextSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setTextSize", "(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetTextSize_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetTextSize (int normalTextSize, int selectedTextSize)
		{
			const string __id = "setTextSize.(II)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (normalTextSize);
				__args [1] = new JniArgumentValue (selectedTextSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_ == null)
				cb_setTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_);
			return cb_setTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_SetTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normalTypeface, IntPtr native_selectedTypeface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var normalTypeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_normalTypeface, JniHandleOwnership.DoNotTransfer);
			var selectedTypeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_selectedTypeface, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTypeface (normalTypeface, selectedTypeface));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setTypeface' and count(parameter)=2 and parameter[1][@type='android.graphics.Typeface'] and parameter[2][@type='android.graphics.Typeface']]"
		[Register ("setTypeface", "(Landroid/graphics/Typeface;Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetTypeface_Landroid_graphics_Typeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetTypeface (global::Android.Graphics.Typeface normalTypeface, global::Android.Graphics.Typeface selectedTypeface)
		{
			const string __id = "setTypeface.(Landroid/graphics/Typeface;Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((normalTypeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalTypeface).Handle);
				__args [1] = new JniArgumentValue ((selectedTypeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedTypeface).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (normalTypeface);
				global::System.GC.KeepAlive (selectedTypeface);
			}
		}

		static Delegate cb_setTypefaceUpdateAreaPercent_F;
#pragma warning disable 0169
		static Delegate GetSetTypefaceUpdateAreaPercent_FHandler ()
		{
			if (cb_setTypefaceUpdateAreaPercent_F == null)
				cb_setTypefaceUpdateAreaPercent_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_SetTypefaceUpdateAreaPercent_F);
			return cb_setTypefaceUpdateAreaPercent_F;
		}

		static IntPtr n_SetTypefaceUpdateAreaPercent_F (IntPtr jnienv, IntPtr native__this, float typefaceUpdateAreaPercent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTypefaceUpdateAreaPercent (typefaceUpdateAreaPercent));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='setTypefaceUpdateAreaPercent' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTypefaceUpdateAreaPercent", "(F)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSetTypefaceUpdateAreaPercent_FHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SetTypefaceUpdateAreaPercent (float typefaceUpdateAreaPercent)
		{
			const string __id = "setTypefaceUpdateAreaPercent.(F)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (typefaceUpdateAreaPercent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinChangeNormalWithTintColor_Z;
#pragma warning disable 0169
		static Delegate GetSkinChangeNormalWithTintColor_ZHandler ()
		{
			if (cb_skinChangeNormalWithTintColor_Z == null)
				cb_skinChangeNormalWithTintColor_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SkinChangeNormalWithTintColor_Z);
			return cb_skinChangeNormalWithTintColor_Z;
		}

		static IntPtr n_SkinChangeNormalWithTintColor_Z (IntPtr jnienv, IntPtr native__this, bool skinChangeNormalWithTintColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinChangeNormalWithTintColor (skinChangeNormalWithTintColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='skinChangeNormalWithTintColor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("skinChangeNormalWithTintColor", "(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSkinChangeNormalWithTintColor_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SkinChangeNormalWithTintColor (bool skinChangeNormalWithTintColor)
		{
			const string __id = "skinChangeNormalWithTintColor.(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skinChangeNormalWithTintColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinChangeSelectedWithTintColor_Z;
#pragma warning disable 0169
		static Delegate GetSkinChangeSelectedWithTintColor_ZHandler ()
		{
			if (cb_skinChangeSelectedWithTintColor_Z == null)
				cb_skinChangeSelectedWithTintColor_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SkinChangeSelectedWithTintColor_Z);
			return cb_skinChangeSelectedWithTintColor_Z;
		}

		static IntPtr n_SkinChangeSelectedWithTintColor_Z (IntPtr jnienv, IntPtr native__this, bool skinChangeSelectedWithTintColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinChangeSelectedWithTintColor (skinChangeSelectedWithTintColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='skinChangeSelectedWithTintColor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("skinChangeSelectedWithTintColor", "(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSkinChangeSelectedWithTintColor_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SkinChangeSelectedWithTintColor (bool skinChangeSelectedWithTintColor)
		{
			const string __id = "skinChangeSelectedWithTintColor.(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skinChangeSelectedWithTintColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinChangeWithTintColor_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSkinChangeWithTintColor_ZHandler ()
		{
			if (cb_skinChangeWithTintColor_Z == null)
				cb_skinChangeWithTintColor_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SkinChangeWithTintColor_Z);
			return cb_skinChangeWithTintColor_Z;
		}

		[Obsolete]
		static IntPtr n_SkinChangeWithTintColor_Z (IntPtr jnienv, IntPtr native__this, bool skinChangeWithTintColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinChangeWithTintColor (skinChangeWithTintColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabBuilder']/method[@name='skinChangeWithTintColor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("skinChangeWithTintColor", "(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetSkinChangeWithTintColor_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder SkinChangeWithTintColor (bool skinChangeWithTintColor)
		{
			const string __id = "skinChangeWithTintColor.(Z)Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skinChangeWithTintColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
