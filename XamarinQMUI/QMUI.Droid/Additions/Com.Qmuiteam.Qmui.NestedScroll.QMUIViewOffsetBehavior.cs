using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIViewOffsetBehavior", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V extends android.view.View"})]
	public partial class QMUIViewOffsetBehavior : global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout.Behavior {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIViewOffsetBehavior", typeof (QMUIViewOffsetBehavior));
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

		protected QMUIViewOffsetBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/constructor[@name='QMUIViewOffsetBehavior' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIViewOffsetBehavior ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/constructor[@name='QMUIViewOffsetBehavior' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIViewOffsetBehavior (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		static Delegate cb_isHorizontalOffsetEnabled;
#pragma warning disable 0169
		static Delegate GetIsHorizontalOffsetEnabledHandler ()
		{
			if (cb_isHorizontalOffsetEnabled == null)
				cb_isHorizontalOffsetEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHorizontalOffsetEnabled);
			return cb_isHorizontalOffsetEnabled;
		}

		static bool n_IsHorizontalOffsetEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HorizontalOffsetEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHorizontalOffsetEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHorizontalOffsetEnabled_ZHandler ()
		{
			if (cb_setHorizontalOffsetEnabled_Z == null)
				cb_setHorizontalOffsetEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHorizontalOffsetEnabled_Z);
			return cb_setHorizontalOffsetEnabled_Z;
		}

		static void n_SetHorizontalOffsetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool horizontalOffsetEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HorizontalOffsetEnabled = horizontalOffsetEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool HorizontalOffsetEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='isHorizontalOffsetEnabled' and count(parameter)=0]"
			[Register ("isHorizontalOffsetEnabled", "()Z", "GetIsHorizontalOffsetEnabledHandler")]
			get {
				const string __id = "isHorizontalOffsetEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='setHorizontalOffsetEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHorizontalOffsetEnabled", "(Z)V", "GetSetHorizontalOffsetEnabled_ZHandler")]
			set {
				const string __id = "setHorizontalOffsetEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLayoutLeft;
#pragma warning disable 0169
		static Delegate GetGetLayoutLeftHandler ()
		{
			if (cb_getLayoutLeft == null)
				cb_getLayoutLeft = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLayoutLeft);
			return cb_getLayoutLeft;
		}

		static int n_GetLayoutLeft (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutLeft;
		}
#pragma warning restore 0169

		public virtual unsafe int LayoutLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='getLayoutLeft' and count(parameter)=0]"
			[Register ("getLayoutLeft", "()I", "GetGetLayoutLeftHandler")]
			get {
				const string __id = "getLayoutLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLayoutTop;
#pragma warning disable 0169
		static Delegate GetGetLayoutTopHandler ()
		{
			if (cb_getLayoutTop == null)
				cb_getLayoutTop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLayoutTop);
			return cb_getLayoutTop;
		}

		static int n_GetLayoutTop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutTop;
		}
#pragma warning restore 0169

		public virtual unsafe int LayoutTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='getLayoutTop' and count(parameter)=0]"
			[Register ("getLayoutTop", "()I", "GetGetLayoutTopHandler")]
			get {
				const string __id = "getLayoutTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLeftAndRightOffset;
#pragma warning disable 0169
		static Delegate GetGetLeftAndRightOffsetHandler ()
		{
			if (cb_getLeftAndRightOffset == null)
				cb_getLeftAndRightOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLeftAndRightOffset);
			return cb_getLeftAndRightOffset;
		}

		static int n_GetLeftAndRightOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftAndRightOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int LeftAndRightOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='getLeftAndRightOffset' and count(parameter)=0]"
			[Register ("getLeftAndRightOffset", "()I", "GetGetLeftAndRightOffsetHandler")]
			get {
				const string __id = "getLeftAndRightOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTopAndBottomOffset;
#pragma warning disable 0169
		static Delegate GetGetTopAndBottomOffsetHandler ()
		{
			if (cb_getTopAndBottomOffset == null)
				cb_getTopAndBottomOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTopAndBottomOffset);
			return cb_getTopAndBottomOffset;
		}

		static int n_GetTopAndBottomOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopAndBottomOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int TopAndBottomOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='getTopAndBottomOffset' and count(parameter)=0]"
			[Register ("getTopAndBottomOffset", "()I", "GetGetTopAndBottomOffsetHandler")]
			get {
				const string __id = "getTopAndBottomOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isVerticalOffsetEnabled;
#pragma warning disable 0169
		static Delegate GetIsVerticalOffsetEnabledHandler ()
		{
			if (cb_isVerticalOffsetEnabled == null)
				cb_isVerticalOffsetEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsVerticalOffsetEnabled);
			return cb_isVerticalOffsetEnabled;
		}

		static bool n_IsVerticalOffsetEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VerticalOffsetEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setVerticalOffsetEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetVerticalOffsetEnabled_ZHandler ()
		{
			if (cb_setVerticalOffsetEnabled_Z == null)
				cb_setVerticalOffsetEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetVerticalOffsetEnabled_Z);
			return cb_setVerticalOffsetEnabled_Z;
		}

		static void n_SetVerticalOffsetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool verticalOffsetEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VerticalOffsetEnabled = verticalOffsetEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool VerticalOffsetEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='isVerticalOffsetEnabled' and count(parameter)=0]"
			[Register ("isVerticalOffsetEnabled", "()Z", "GetIsVerticalOffsetEnabledHandler")]
			get {
				const string __id = "isVerticalOffsetEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='setVerticalOffsetEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVerticalOffsetEnabled", "(Z)V", "GetSetVerticalOffsetEnabled_ZHandler")]
			set {
				const string __id = "setVerticalOffsetEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_layoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler ()
		{
			if (cb_layoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I == null)
				cb_layoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_LayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I);
			return cb_layoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;
		}

		static void n_LayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, int layoutDirection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_child, JniHandleOwnership.DoNotTransfer);
			__this.LayoutChild (parent, child, layoutDirection);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='layoutChild' and count(parameter)=3 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='V'] and parameter[3][@type='int']]"
		[Register ("layoutChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)V", "GetLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler")]
		protected virtual unsafe void LayoutChild (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, global::Java.Lang.Object child, int layoutDirection)
		{
			const string __id = "layoutChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)V";
			IntPtr native_child = JNIEnv.ToLocalJniHandle (child);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_child);
				__args [2] = new JniArgumentValue (layoutDirection);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_child);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (child);
			}
		}

		static Delegate cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler ()
		{
			if (cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I == null)
				cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_Z) n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I);
			return cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;
		}

		static bool n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, int layoutDirection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_child, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLayoutChild (parent, child, layoutDirection);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='onLayoutChild' and count(parameter)=3 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='V'] and parameter[3][@type='int']]"
		[Register ("onLayoutChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", "GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler")]
		public virtual unsafe bool OnLayoutChild (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, global::Java.Lang.Object child, int layoutDirection)
		{
			const string __id = "onLayoutChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z";
			IntPtr native_child = JNIEnv.ToLocalJniHandle (child);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_child);
				__args [2] = new JniArgumentValue (layoutDirection);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_child);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (child);
			}
		}

		static Delegate cb_setLeftAndRightOffset_I;
#pragma warning disable 0169
		static Delegate GetSetLeftAndRightOffset_IHandler ()
		{
			if (cb_setLeftAndRightOffset_I == null)
				cb_setLeftAndRightOffset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetLeftAndRightOffset_I);
			return cb_setLeftAndRightOffset_I;
		}

		static bool n_SetLeftAndRightOffset_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetLeftAndRightOffset (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='setLeftAndRightOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLeftAndRightOffset", "(I)Z", "GetSetLeftAndRightOffset_IHandler")]
		public virtual unsafe bool SetLeftAndRightOffset (int offset)
		{
			const string __id = "setLeftAndRightOffset.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setTopAndBottomOffset_I;
#pragma warning disable 0169
		static Delegate GetSetTopAndBottomOffset_IHandler ()
		{
			if (cb_setTopAndBottomOffset_I == null)
				cb_setTopAndBottomOffset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetTopAndBottomOffset_I);
			return cb_setTopAndBottomOffset_I;
		}

		static bool n_SetTopAndBottomOffset_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetTopAndBottomOffset (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIViewOffsetBehavior']/method[@name='setTopAndBottomOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTopAndBottomOffset", "(I)Z", "GetSetTopAndBottomOffset_IHandler")]
		public virtual unsafe bool SetTopAndBottomOffset (int offset)
		{
			const string __id = "setTopAndBottomOffset.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
