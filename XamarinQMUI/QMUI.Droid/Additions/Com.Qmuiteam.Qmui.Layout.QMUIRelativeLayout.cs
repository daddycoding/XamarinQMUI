using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Layout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/layout/QMUIRelativeLayout", DoNotGenerateAcw=true)]
	public partial class QMUIRelativeLayout : global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaRelativeLayout, global::Com.Qmuiteam.Qmui.Layout.IQMUILayout {


		public static class InterfaceConsts {

			// The following are fields from: com.qmuiteam.qmui.layout.IQMUILayout

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_BOTTOM']"
			[Register ("HIDE_RADIUS_SIDE_BOTTOM")]
			public const int HideRadiusSideBottom = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_LEFT']"
			[Register ("HIDE_RADIUS_SIDE_LEFT")]
			public const int HideRadiusSideLeft = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_NONE']"
			[Register ("HIDE_RADIUS_SIDE_NONE")]
			public const int HideRadiusSideNone = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_RIGHT']"
			[Register ("HIDE_RADIUS_SIDE_RIGHT")]
			public const int HideRadiusSideRight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_TOP']"
			[Register ("HIDE_RADIUS_SIDE_TOP")]
			public const int HideRadiusSideTop = (int) 1;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/layout/QMUIRelativeLayout", typeof (QMUIRelativeLayout));
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

		protected QMUIRelativeLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/constructor[@name='QMUIRelativeLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIRelativeLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/constructor[@name='QMUIRelativeLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIRelativeLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/constructor[@name='QMUIRelativeLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIRelativeLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_hasBorder;
#pragma warning disable 0169
		static Delegate GetHasBorderHandler ()
		{
			if (cb_hasBorder == null)
				cb_hasBorder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasBorder);
			return cb_hasBorder;
		}

		static bool n_HasBorder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBorder;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBorder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='hasBorder' and count(parameter)=0]"
			[Register ("hasBorder", "()Z", "GetHasBorderHandler")]
			get {
				const string __id = "hasBorder.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasBottomSeparator;
#pragma warning disable 0169
		static Delegate GetHasBottomSeparatorHandler ()
		{
			if (cb_hasBottomSeparator == null)
				cb_hasBottomSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasBottomSeparator);
			return cb_hasBottomSeparator;
		}

		static bool n_HasBottomSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBottomSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBottomSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='hasBottomSeparator' and count(parameter)=0]"
			[Register ("hasBottomSeparator", "()Z", "GetHasBottomSeparatorHandler")]
			get {
				const string __id = "hasBottomSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasLeftSeparator;
#pragma warning disable 0169
		static Delegate GetHasLeftSeparatorHandler ()
		{
			if (cb_hasLeftSeparator == null)
				cb_hasLeftSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasLeftSeparator);
			return cb_hasLeftSeparator;
		}

		static bool n_HasLeftSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLeftSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasLeftSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='hasLeftSeparator' and count(parameter)=0]"
			[Register ("hasLeftSeparator", "()Z", "GetHasLeftSeparatorHandler")]
			get {
				const string __id = "hasLeftSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasRightSeparator;
#pragma warning disable 0169
		static Delegate GetHasRightSeparatorHandler ()
		{
			if (cb_hasRightSeparator == null)
				cb_hasRightSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasRightSeparator);
			return cb_hasRightSeparator;
		}

		static bool n_HasRightSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRightSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasRightSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='hasRightSeparator' and count(parameter)=0]"
			[Register ("hasRightSeparator", "()Z", "GetHasRightSeparatorHandler")]
			get {
				const string __id = "hasRightSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasTopSeparator;
#pragma warning disable 0169
		static Delegate GetHasTopSeparatorHandler ()
		{
			if (cb_hasTopSeparator == null)
				cb_hasTopSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasTopSeparator);
			return cb_hasTopSeparator;
		}

		static bool n_HasTopSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTopSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasTopSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='hasTopSeparator' and count(parameter)=0]"
			[Register ("hasTopSeparator", "()Z", "GetHasTopSeparatorHandler")]
			get {
				const string __id = "hasTopSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHideRadiusSide;
#pragma warning disable 0169
		static Delegate GetGetHideRadiusSideHandler ()
		{
			if (cb_getHideRadiusSide == null)
				cb_getHideRadiusSide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHideRadiusSide);
			return cb_getHideRadiusSide;
		}

		static int n_GetHideRadiusSide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideRadiusSide;
		}
#pragma warning restore 0169

		static Delegate cb_setHideRadiusSide_I;
#pragma warning disable 0169
		static Delegate GetSetHideRadiusSide_IHandler ()
		{
			if (cb_setHideRadiusSide_I == null)
				cb_setHideRadiusSide_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHideRadiusSide_I);
			return cb_setHideRadiusSide_I;
		}

		static void n_SetHideRadiusSide_I (IntPtr jnienv, IntPtr native__this, int hideRadiusSide)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideRadiusSide = hideRadiusSide;
		}
#pragma warning restore 0169

		public virtual unsafe int HideRadiusSide {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='getHideRadiusSide' and count(parameter)=0]"
			[Register ("getHideRadiusSide", "()I", "GetGetHideRadiusSideHandler")]
			get {
				const string __id = "getHideRadiusSide.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setHideRadiusSide' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHideRadiusSide", "(I)V", "GetSetHideRadiusSide_IHandler")]
			set {
				const string __id = "setHideRadiusSide.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
			set {
				const string __id = "setRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowAlpha;
#pragma warning disable 0169
		static Delegate GetGetShadowAlphaHandler ()
		{
			if (cb_getShadowAlpha == null)
				cb_getShadowAlpha = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetShadowAlpha);
			return cb_getShadowAlpha;
		}

		static float n_GetShadowAlpha (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowAlpha;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetShadowAlpha_FHandler ()
		{
			if (cb_setShadowAlpha_F == null)
				cb_setShadowAlpha_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetShadowAlpha_F);
			return cb_setShadowAlpha_F;
		}

		static void n_SetShadowAlpha_F (IntPtr jnienv, IntPtr native__this, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowAlpha = shadowAlpha;
		}
#pragma warning restore 0169

		public virtual unsafe float ShadowAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='getShadowAlpha' and count(parameter)=0]"
			[Register ("getShadowAlpha", "()F", "GetGetShadowAlphaHandler")]
			get {
				const string __id = "getShadowAlpha.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setShadowAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setShadowAlpha", "(F)V", "GetSetShadowAlpha_FHandler")]
			set {
				const string __id = "setShadowAlpha.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowColor;
#pragma warning disable 0169
		static Delegate GetGetShadowColorHandler ()
		{
			if (cb_getShadowColor == null)
				cb_getShadowColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetShadowColor);
			return cb_getShadowColor;
		}

		static int n_GetShadowColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowColor;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowColor_I;
#pragma warning disable 0169
		static Delegate GetSetShadowColor_IHandler ()
		{
			if (cb_setShadowColor_I == null)
				cb_setShadowColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShadowColor_I);
			return cb_setShadowColor_I;
		}

		static void n_SetShadowColor_I (IntPtr jnienv, IntPtr native__this, int shadowColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowColor = shadowColor;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='getShadowColor' and count(parameter)=0]"
			[Register ("getShadowColor", "()I", "GetGetShadowColorHandler")]
			get {
				const string __id = "getShadowColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowColor", "(I)V", "GetSetShadowColor_IHandler")]
			set {
				const string __id = "setShadowColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowElevation;
#pragma warning disable 0169
		static Delegate GetGetShadowElevationHandler ()
		{
			if (cb_getShadowElevation == null)
				cb_getShadowElevation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetShadowElevation);
			return cb_getShadowElevation;
		}

		static int n_GetShadowElevation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowElevation;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowElevation_I;
#pragma warning disable 0169
		static Delegate GetSetShadowElevation_IHandler ()
		{
			if (cb_setShadowElevation_I == null)
				cb_setShadowElevation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShadowElevation_I);
			return cb_setShadowElevation_I;
		}

		static void n_SetShadowElevation_I (IntPtr jnienv, IntPtr native__this, int elevation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowElevation = elevation;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowElevation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='getShadowElevation' and count(parameter)=0]"
			[Register ("getShadowElevation", "()I", "GetGetShadowElevationHandler")]
			get {
				const string __id = "getShadowElevation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setShadowElevation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowElevation", "(I)V", "GetSetShadowElevation_IHandler")]
			set {
				const string __id = "setShadowElevation.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_onlyShowBottomDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowBottomDivider_IIIIHandler ()
		{
			if (cb_onlyShowBottomDivider_IIII == null)
				cb_onlyShowBottomDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowBottomDivider_IIII);
			return cb_onlyShowBottomDivider_IIII;
		}

		static void n_OnlyShowBottomDivider_IIII (IntPtr jnienv, IntPtr native__this, int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowBottomDivider (bottomInsetLeft, bottomInsetRight, bottomDividerHeight, bottomDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='onlyShowBottomDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowBottomDivider", "(IIII)V", "GetOnlyShowBottomDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			const string __id = "onlyShowBottomDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (bottomInsetLeft);
				__args [1] = new JniArgumentValue (bottomInsetRight);
				__args [2] = new JniArgumentValue (bottomDividerHeight);
				__args [3] = new JniArgumentValue (bottomDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onlyShowLeftDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowLeftDivider_IIIIHandler ()
		{
			if (cb_onlyShowLeftDivider_IIII == null)
				cb_onlyShowLeftDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowLeftDivider_IIII);
			return cb_onlyShowLeftDivider_IIII;
		}

		static void n_OnlyShowLeftDivider_IIII (IntPtr jnienv, IntPtr native__this, int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowLeftDivider (leftInsetTop, leftInsetBottom, leftDividerWidth, leftDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='onlyShowLeftDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowLeftDivider", "(IIII)V", "GetOnlyShowLeftDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			const string __id = "onlyShowLeftDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (leftInsetTop);
				__args [1] = new JniArgumentValue (leftInsetBottom);
				__args [2] = new JniArgumentValue (leftDividerWidth);
				__args [3] = new JniArgumentValue (leftDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onlyShowRightDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowRightDivider_IIIIHandler ()
		{
			if (cb_onlyShowRightDivider_IIII == null)
				cb_onlyShowRightDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowRightDivider_IIII);
			return cb_onlyShowRightDivider_IIII;
		}

		static void n_OnlyShowRightDivider_IIII (IntPtr jnienv, IntPtr native__this, int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowRightDivider (rightInsetTop, rightInsetBottom, rightDividerWidth, rightDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='onlyShowRightDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowRightDivider", "(IIII)V", "GetOnlyShowRightDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			const string __id = "onlyShowRightDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (rightInsetTop);
				__args [1] = new JniArgumentValue (rightInsetBottom);
				__args [2] = new JniArgumentValue (rightDividerWidth);
				__args [3] = new JniArgumentValue (rightDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onlyShowTopDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowTopDivider_IIIIHandler ()
		{
			if (cb_onlyShowTopDivider_IIII == null)
				cb_onlyShowTopDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowTopDivider_IIII);
			return cb_onlyShowTopDivider_IIII;
		}

		static void n_OnlyShowTopDivider_IIII (IntPtr jnienv, IntPtr native__this, int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowTopDivider (topInsetLeft, topInsetRight, topDividerHeight, topDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='onlyShowTopDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowTopDivider", "(IIII)V", "GetOnlyShowTopDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			const string __id = "onlyShowTopDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (topInsetLeft);
				__args [1] = new JniArgumentValue (topInsetRight);
				__args [2] = new JniArgumentValue (topDividerHeight);
				__args [3] = new JniArgumentValue (topDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int borderColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderColor (borderColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
		public virtual unsafe void SetBorderColor (int borderColor)
		{
			const string __id = "setBorderColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (borderColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBorderWidth_I;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_IHandler ()
		{
			if (cb_setBorderWidth_I == null)
				cb_setBorderWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderWidth_I);
			return cb_setBorderWidth_I;
		}

		static void n_SetBorderWidth_I (IntPtr jnienv, IntPtr native__this, int borderWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderWidth (borderWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderWidth", "(I)V", "GetSetBorderWidth_IHandler")]
		public virtual unsafe void SetBorderWidth (int borderWidth)
		{
			const string __id = "setBorderWidth.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (borderWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBottomDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetBottomDividerAlpha_IHandler ()
		{
			if (cb_setBottomDividerAlpha_I == null)
				cb_setBottomDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBottomDividerAlpha_I);
			return cb_setBottomDividerAlpha_I;
		}

		static void n_SetBottomDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBottomDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setBottomDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBottomDividerAlpha", "(I)V", "GetSetBottomDividerAlpha_IHandler")]
		public virtual unsafe void SetBottomDividerAlpha (int dividerAlpha)
		{
			const string __id = "setBottomDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHeightLimit_I;
#pragma warning disable 0169
		static Delegate GetSetHeightLimit_IHandler ()
		{
			if (cb_setHeightLimit_I == null)
				cb_setHeightLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetHeightLimit_I);
			return cb_setHeightLimit_I;
		}

		static bool n_SetHeightLimit_I (IntPtr jnienv, IntPtr native__this, int heightLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetHeightLimit (heightLimit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setHeightLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeightLimit", "(I)Z", "GetSetHeightLimit_IHandler")]
		public virtual unsafe bool SetHeightLimit (int heightLimit)
		{
			const string __id = "setHeightLimit.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (heightLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setLeftDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetLeftDividerAlpha_IHandler ()
		{
			if (cb_setLeftDividerAlpha_I == null)
				cb_setLeftDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLeftDividerAlpha_I);
			return cb_setLeftDividerAlpha_I;
		}

		static void n_SetLeftDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLeftDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setLeftDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLeftDividerAlpha", "(I)V", "GetSetLeftDividerAlpha_IHandler")]
		public virtual unsafe void SetLeftDividerAlpha (int dividerAlpha)
		{
			const string __id = "setLeftDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOuterNormalColor_I;
#pragma warning disable 0169
		static Delegate GetSetOuterNormalColor_IHandler ()
		{
			if (cb_setOuterNormalColor_I == null)
				cb_setOuterNormalColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetOuterNormalColor_I);
			return cb_setOuterNormalColor_I;
		}

		static void n_SetOuterNormalColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOuterNormalColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setOuterNormalColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOuterNormalColor", "(I)V", "GetSetOuterNormalColor_IHandler")]
		public virtual unsafe void SetOuterNormalColor (int color)
		{
			const string __id = "setOuterNormalColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOutlineExcludePadding_Z;
#pragma warning disable 0169
		static Delegate GetSetOutlineExcludePadding_ZHandler ()
		{
			if (cb_setOutlineExcludePadding_Z == null)
				cb_setOutlineExcludePadding_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOutlineExcludePadding_Z);
			return cb_setOutlineExcludePadding_Z;
		}

		static void n_SetOutlineExcludePadding_Z (IntPtr jnienv, IntPtr native__this, bool outlineExcludePadding)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutlineExcludePadding (outlineExcludePadding);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setOutlineExcludePadding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOutlineExcludePadding", "(Z)V", "GetSetOutlineExcludePadding_ZHandler")]
		public virtual unsafe void SetOutlineExcludePadding (bool outlineExcludePadding)
		{
			const string __id = "setOutlineExcludePadding.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (outlineExcludePadding);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOutlineInset_IIII;
#pragma warning disable 0169
		static Delegate GetSetOutlineInset_IIIIHandler ()
		{
			if (cb_setOutlineInset_IIII == null)
				cb_setOutlineInset_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_SetOutlineInset_IIII);
			return cb_setOutlineInset_IIII;
		}

		static void n_SetOutlineInset_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutlineInset (left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setOutlineInset' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setOutlineInset", "(IIII)V", "GetSetOutlineInset_IIIIHandler")]
		public virtual unsafe void SetOutlineInset (int left, int top, int right, int bottom)
		{
			const string __id = "setOutlineInset.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadius_II;
#pragma warning disable 0169
		static Delegate GetSetRadius_IIHandler ()
		{
			if (cb_setRadius_II == null)
				cb_setRadius_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetRadius_II);
			return cb_setRadius_II;
		}

		static void n_SetRadius_II (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius, hideRadiusSide);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setRadius' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setRadius", "(II)V", "GetSetRadius_IIHandler")]
		public virtual unsafe void SetRadius (int radius, int hideRadiusSide)
		{
			const string __id = "setRadius.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (hideRadiusSide);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadiusAndShadow_IIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIF == null)
				cb_setRadiusAndShadow_IIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIF_V) n_SetRadiusAndShadow_IIF);
			return cb_setRadiusAndShadow_IIF;
		}

		static void n_SetRadiusAndShadow_IIF (IntPtr jnienv, IntPtr native__this, int radius, int shadowElevation, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, shadowElevation, shadowAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setRadiusAndShadow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIF)V", "GetSetRadiusAndShadow_IIFHandler")]
		public virtual unsafe void SetRadiusAndShadow (int radius, int shadowElevation, float shadowAlpha)
		{
			const string __id = "setRadiusAndShadow.(IIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (shadowElevation);
				__args [2] = new JniArgumentValue (shadowAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadiusAndShadow_IIIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIIF == null)
				cb_setRadiusAndShadow_IIIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIF_V) n_SetRadiusAndShadow_IIIF);
			return cb_setRadiusAndShadow_IIIF;
		}

		static void n_SetRadiusAndShadow_IIIF (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide, int shadowElevation, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, hideRadiusSide, shadowElevation, shadowAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setRadiusAndShadow' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIIF)V", "GetSetRadiusAndShadow_IIIFHandler")]
		public virtual unsafe void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, float shadowAlpha)
		{
			const string __id = "setRadiusAndShadow.(IIIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (hideRadiusSide);
				__args [2] = new JniArgumentValue (shadowElevation);
				__args [3] = new JniArgumentValue (shadowAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadiusAndShadow_IIIIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIIIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIIIF == null)
				cb_setRadiusAndShadow_IIIIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIIF_V) n_SetRadiusAndShadow_IIIIF);
			return cb_setRadiusAndShadow_IIIIF;
		}

		static void n_SetRadiusAndShadow_IIIIF (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide, int shadowElevation, int shadowColor, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, hideRadiusSide, shadowElevation, shadowColor, shadowAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setRadiusAndShadow' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIIIF)V", "GetSetRadiusAndShadow_IIIIFHandler")]
		public virtual unsafe void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, int shadowColor, float shadowAlpha)
		{
			const string __id = "setRadiusAndShadow.(IIIIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (hideRadiusSide);
				__args [2] = new JniArgumentValue (shadowElevation);
				__args [3] = new JniArgumentValue (shadowColor);
				__args [4] = new JniArgumentValue (shadowAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRightDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetRightDividerAlpha_IHandler ()
		{
			if (cb_setRightDividerAlpha_I == null)
				cb_setRightDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRightDividerAlpha_I);
			return cb_setRightDividerAlpha_I;
		}

		static void n_SetRightDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRightDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setRightDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRightDividerAlpha", "(I)V", "GetSetRightDividerAlpha_IHandler")]
		public virtual unsafe void SetRightDividerAlpha (int dividerAlpha)
		{
			const string __id = "setRightDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowBorderOnlyBeforeL_Z;
#pragma warning disable 0169
		static Delegate GetSetShowBorderOnlyBeforeL_ZHandler ()
		{
			if (cb_setShowBorderOnlyBeforeL_Z == null)
				cb_setShowBorderOnlyBeforeL_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowBorderOnlyBeforeL_Z);
			return cb_setShowBorderOnlyBeforeL_Z;
		}

		static void n_SetShowBorderOnlyBeforeL_Z (IntPtr jnienv, IntPtr native__this, bool showBorderOnlyBeforeL)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBorderOnlyBeforeL (showBorderOnlyBeforeL);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setShowBorderOnlyBeforeL' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowBorderOnlyBeforeL", "(Z)V", "GetSetShowBorderOnlyBeforeL_ZHandler")]
		public virtual unsafe void SetShowBorderOnlyBeforeL (bool showBorderOnlyBeforeL)
		{
			const string __id = "setShowBorderOnlyBeforeL.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showBorderOnlyBeforeL);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTopDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetTopDividerAlpha_IHandler ()
		{
			if (cb_setTopDividerAlpha_I == null)
				cb_setTopDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTopDividerAlpha_I);
			return cb_setTopDividerAlpha_I;
		}

		static void n_SetTopDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTopDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setTopDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTopDividerAlpha", "(I)V", "GetSetTopDividerAlpha_IHandler")]
		public virtual unsafe void SetTopDividerAlpha (int dividerAlpha)
		{
			const string __id = "setTopDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUseThemeGeneralShadowElevation;
#pragma warning disable 0169
		static Delegate GetSetUseThemeGeneralShadowElevationHandler ()
		{
			if (cb_setUseThemeGeneralShadowElevation == null)
				cb_setUseThemeGeneralShadowElevation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetUseThemeGeneralShadowElevation);
			return cb_setUseThemeGeneralShadowElevation;
		}

		static void n_SetUseThemeGeneralShadowElevation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseThemeGeneralShadowElevation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setUseThemeGeneralShadowElevation' and count(parameter)=0]"
		[Register ("setUseThemeGeneralShadowElevation", "()V", "GetSetUseThemeGeneralShadowElevationHandler")]
		public virtual unsafe void SetUseThemeGeneralShadowElevation ()
		{
			const string __id = "setUseThemeGeneralShadowElevation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setWidthLimit_I;
#pragma warning disable 0169
		static Delegate GetSetWidthLimit_IHandler ()
		{
			if (cb_setWidthLimit_I == null)
				cb_setWidthLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetWidthLimit_I);
			return cb_setWidthLimit_I;
		}

		static bool n_SetWidthLimit_I (IntPtr jnienv, IntPtr native__this, int widthLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetWidthLimit (widthLimit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='setWidthLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWidthLimit", "(I)Z", "GetSetWidthLimit_IHandler")]
		public virtual unsafe bool SetWidthLimit (int widthLimit)
		{
			const string __id = "setWidthLimit.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (widthLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_updateBottomDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateBottomDivider_IIIIHandler ()
		{
			if (cb_updateBottomDivider_IIII == null)
				cb_updateBottomDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateBottomDivider_IIII);
			return cb_updateBottomDivider_IIII;
		}

		static void n_UpdateBottomDivider_IIII (IntPtr jnienv, IntPtr native__this, int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBottomDivider (bottomInsetLeft, bottomInsetRight, bottomDividerHeight, bottomDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateBottomDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateBottomDivider", "(IIII)V", "GetUpdateBottomDivider_IIIIHandler")]
		public virtual unsafe void UpdateBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			const string __id = "updateBottomDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (bottomInsetLeft);
				__args [1] = new JniArgumentValue (bottomInsetRight);
				__args [2] = new JniArgumentValue (bottomDividerHeight);
				__args [3] = new JniArgumentValue (bottomDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateBottomSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateBottomSeparatorColor_IHandler ()
		{
			if (cb_updateBottomSeparatorColor_I == null)
				cb_updateBottomSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateBottomSeparatorColor_I);
			return cb_updateBottomSeparatorColor_I;
		}

		static void n_UpdateBottomSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBottomSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateBottomSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateBottomSeparatorColor", "(I)V", "GetUpdateBottomSeparatorColor_IHandler")]
		public virtual unsafe void UpdateBottomSeparatorColor (int color)
		{
			const string __id = "updateBottomSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateLeftDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateLeftDivider_IIIIHandler ()
		{
			if (cb_updateLeftDivider_IIII == null)
				cb_updateLeftDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateLeftDivider_IIII);
			return cb_updateLeftDivider_IIII;
		}

		static void n_UpdateLeftDivider_IIII (IntPtr jnienv, IntPtr native__this, int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLeftDivider (leftInsetTop, leftInsetBottom, leftDividerWidth, leftDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateLeftDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateLeftDivider", "(IIII)V", "GetUpdateLeftDivider_IIIIHandler")]
		public virtual unsafe void UpdateLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			const string __id = "updateLeftDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (leftInsetTop);
				__args [1] = new JniArgumentValue (leftInsetBottom);
				__args [2] = new JniArgumentValue (leftDividerWidth);
				__args [3] = new JniArgumentValue (leftDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateLeftSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateLeftSeparatorColor_IHandler ()
		{
			if (cb_updateLeftSeparatorColor_I == null)
				cb_updateLeftSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateLeftSeparatorColor_I);
			return cb_updateLeftSeparatorColor_I;
		}

		static void n_UpdateLeftSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLeftSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateLeftSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateLeftSeparatorColor", "(I)V", "GetUpdateLeftSeparatorColor_IHandler")]
		public virtual unsafe void UpdateLeftSeparatorColor (int color)
		{
			const string __id = "updateLeftSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateRightDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateRightDivider_IIIIHandler ()
		{
			if (cb_updateRightDivider_IIII == null)
				cb_updateRightDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateRightDivider_IIII);
			return cb_updateRightDivider_IIII;
		}

		static void n_UpdateRightDivider_IIII (IntPtr jnienv, IntPtr native__this, int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRightDivider (rightInsetTop, rightInsetBottom, rightDividerWidth, rightDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateRightDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateRightDivider", "(IIII)V", "GetUpdateRightDivider_IIIIHandler")]
		public virtual unsafe void UpdateRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			const string __id = "updateRightDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (rightInsetTop);
				__args [1] = new JniArgumentValue (rightInsetBottom);
				__args [2] = new JniArgumentValue (rightDividerWidth);
				__args [3] = new JniArgumentValue (rightDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateRightSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateRightSeparatorColor_IHandler ()
		{
			if (cb_updateRightSeparatorColor_I == null)
				cb_updateRightSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateRightSeparatorColor_I);
			return cb_updateRightSeparatorColor_I;
		}

		static void n_UpdateRightSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRightSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateRightSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateRightSeparatorColor", "(I)V", "GetUpdateRightSeparatorColor_IHandler")]
		public virtual unsafe void UpdateRightSeparatorColor (int color)
		{
			const string __id = "updateRightSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateTopDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateTopDivider_IIIIHandler ()
		{
			if (cb_updateTopDivider_IIII == null)
				cb_updateTopDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateTopDivider_IIII);
			return cb_updateTopDivider_IIII;
		}

		static void n_UpdateTopDivider_IIII (IntPtr jnienv, IntPtr native__this, int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopDivider (topInsetLeft, topInsetRight, topDividerHeight, topDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateTopDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateTopDivider", "(IIII)V", "GetUpdateTopDivider_IIIIHandler")]
		public virtual unsafe void UpdateTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			const string __id = "updateTopDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (topInsetLeft);
				__args [1] = new JniArgumentValue (topInsetRight);
				__args [2] = new JniArgumentValue (topDividerHeight);
				__args [3] = new JniArgumentValue (topDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateTopSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateTopSeparatorColor_IHandler ()
		{
			if (cb_updateTopSeparatorColor_I == null)
				cb_updateTopSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateTopSeparatorColor_I);
			return cb_updateTopSeparatorColor_I;
		}

		static void n_UpdateTopSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIRelativeLayout']/method[@name='updateTopSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateTopSeparatorColor", "(I)V", "GetUpdateTopSeparatorColor_IHandler")]
		public virtual unsafe void UpdateTopSeparatorColor (int color)
		{
			const string __id = "updateTopSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
