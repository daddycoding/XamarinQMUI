using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomAreaBehavior']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedBottomAreaBehavior", DoNotGenerateAcw=true)]
	public partial class QMUIContinuousNestedBottomAreaBehavior : global::Com.Qmuiteam.Qmui.NestedScroll.QMUIViewOffsetBehavior {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedBottomAreaBehavior", typeof (QMUIContinuousNestedBottomAreaBehavior));
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

		protected QMUIContinuousNestedBottomAreaBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomAreaBehavior']/constructor[@name='QMUIContinuousNestedBottomAreaBehavior' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIContinuousNestedBottomAreaBehavior ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomAreaBehavior']/constructor[@name='QMUIContinuousNestedBottomAreaBehavior' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIContinuousNestedBottomAreaBehavior (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomAreaBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_child, JniHandleOwnership.DoNotTransfer);
			__this.LayoutChild (parent, child, layoutDirection);
		}
#pragma warning restore 0169
      
        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomAreaBehavior']/method[@name='layoutChild' and count(parameter)=3 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
        [Register ("layoutChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)V", "GetLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler")]
		protected override unsafe void LayoutChild (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, Java.Lang.Object child, int layoutDirection)
		{
			const string __id = "layoutChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [2] = new JniArgumentValue (layoutDirection);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomAreaBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_child, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLayoutChild (parent, child, layoutDirection);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomAreaBehavior']/method[@name='onLayoutChild' and count(parameter)=3 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onLayoutChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", "GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler")]
		public override unsafe bool OnLayoutChild (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, global::Java.Lang.Object child, int layoutDirection)
		{
			const string __id = "onLayoutChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [2] = new JniArgumentValue (layoutDirection);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (child);
			}
		}

		static Delegate cb_setTopInset_I;
#pragma warning disable 0169
		static Delegate GetSetTopInset_IHandler ()
		{
			if (cb_setTopInset_I == null)
				cb_setTopInset_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTopInset_I);
			return cb_setTopInset_I;
		}

		static void n_SetTopInset_I (IntPtr jnienv, IntPtr native__this, int topInset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomAreaBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTopInset (topInset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomAreaBehavior']/method[@name='setTopInset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTopInset", "(I)V", "GetSetTopInset_IHandler")]
		public virtual unsafe void SetTopInset (int topInset)
		{
			const string __id = "setTopInset.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (topInset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
