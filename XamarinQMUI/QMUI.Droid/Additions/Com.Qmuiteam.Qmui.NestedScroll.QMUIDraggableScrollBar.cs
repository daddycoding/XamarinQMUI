using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIDraggableScrollBar", DoNotGenerateAcw=true)]
	public partial class QMUIDraggableScrollBar : global::Android.Views.View {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIDraggableScrollBar", typeof (QMUIDraggableScrollBar));
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

		protected QMUIDraggableScrollBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/constructor[@name='QMUIDraggableScrollBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIDraggableScrollBar (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/constructor[@name='QMUIDraggableScrollBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe QMUIDraggableScrollBar (global::Android.Content.Context context, global::Android.Graphics.Drawables.Drawable dragDrawable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((dragDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dragDrawable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (dragDrawable);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/constructor[@name='QMUIDraggableScrollBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIDraggableScrollBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		static Delegate cb_isEnableFadeInAndOut;
#pragma warning disable 0169
		static Delegate GetIsEnableFadeInAndOutHandler ()
		{
			if (cb_isEnableFadeInAndOut == null)
				cb_isEnableFadeInAndOut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnableFadeInAndOut);
			return cb_isEnableFadeInAndOut;
		}

		static bool n_IsEnableFadeInAndOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableFadeInAndOut;
		}
#pragma warning restore 0169

		static Delegate cb_setEnableFadeInAndOut_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableFadeInAndOut_ZHandler ()
		{
			if (cb_setEnableFadeInAndOut_Z == null)
				cb_setEnableFadeInAndOut_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnableFadeInAndOut_Z);
			return cb_setEnableFadeInAndOut_Z;
		}

		static void n_SetEnableFadeInAndOut_Z (IntPtr jnienv, IntPtr native__this, bool enableFadeInAndOut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableFadeInAndOut = enableFadeInAndOut;
		}
#pragma warning restore 0169

		public virtual unsafe bool EnableFadeInAndOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='isEnableFadeInAndOut' and count(parameter)=0]"
			[Register ("isEnableFadeInAndOut", "()Z", "GetIsEnableFadeInAndOutHandler")]
			get {
				const string __id = "isEnableFadeInAndOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='setEnableFadeInAndOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableFadeInAndOut", "(Z)V", "GetSetEnableFadeInAndOut_ZHandler")]
			set {
				const string __id = "setEnableFadeInAndOut.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScrollBarBottomMargin;
#pragma warning disable 0169
		static Delegate GetGetScrollBarBottomMarginHandler ()
		{
			if (cb_getScrollBarBottomMargin == null)
				cb_getScrollBarBottomMargin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScrollBarBottomMargin);
			return cb_getScrollBarBottomMargin;
		}

		static int n_GetScrollBarBottomMargin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollBarBottomMargin;
		}
#pragma warning restore 0169

		protected virtual unsafe int ScrollBarBottomMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='getScrollBarBottomMargin' and count(parameter)=0]"
			[Register ("getScrollBarBottomMargin", "()I", "GetGetScrollBarBottomMarginHandler")]
			get {
				const string __id = "getScrollBarBottomMargin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScrollBarTopMargin;
#pragma warning disable 0169
		static Delegate GetGetScrollBarTopMarginHandler ()
		{
			if (cb_getScrollBarTopMargin == null)
				cb_getScrollBarTopMargin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScrollBarTopMargin);
			return cb_getScrollBarTopMargin;
		}

		static int n_GetScrollBarTopMargin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollBarTopMargin;
		}
#pragma warning restore 0169

		protected virtual unsafe int ScrollBarTopMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='getScrollBarTopMargin' and count(parameter)=0]"
			[Register ("getScrollBarTopMargin", "()I", "GetGetScrollBarTopMarginHandler")]
			get {
				const string __id = "getScrollBarTopMargin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_awakenScrollBar;
#pragma warning disable 0169
		static Delegate GetAwakenScrollBarHandler ()
		{
			if (cb_awakenScrollBar == null)
				cb_awakenScrollBar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AwakenScrollBar);
			return cb_awakenScrollBar;
		}

		static void n_AwakenScrollBar (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AwakenScrollBar ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='awakenScrollBar' and count(parameter)=0]"
		[Register ("awakenScrollBar", "()V", "GetAwakenScrollBarHandler")]
		public virtual unsafe void AwakenScrollBar ()
		{
			const string __id = "awakenScrollBar.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setDragDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDragDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDragDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDragDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDragDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setDragDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetDragDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dragDrawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dragDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_dragDrawable, JniHandleOwnership.DoNotTransfer);
			__this.SetDragDrawable (dragDrawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='setDragDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDragDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDragDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetDragDrawable (global::Android.Graphics.Drawables.Drawable dragDrawable)
		{
			const string __id = "setDragDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dragDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dragDrawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dragDrawable);
			}
		}

		static Delegate cb_setKeepShownTime_I;
#pragma warning disable 0169
		static Delegate GetSetKeepShownTime_IHandler ()
		{
			if (cb_setKeepShownTime_I == null)
				cb_setKeepShownTime_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetKeepShownTime_I);
			return cb_setKeepShownTime_I;
		}

		static void n_SetKeepShownTime_I (IntPtr jnienv, IntPtr native__this, int keepShownTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepShownTime (keepShownTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='setKeepShownTime' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setKeepShownTime", "(I)V", "GetSetKeepShownTime_IHandler")]
		public virtual unsafe void SetKeepShownTime (int keepShownTime)
		{
			const string __id = "setKeepShownTime.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (keepShownTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPercent_F;
#pragma warning disable 0169
		static Delegate GetSetPercent_FHandler ()
		{
			if (cb_setPercent_F == null)
				cb_setPercent_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetPercent_F);
			return cb_setPercent_F;
		}

		static void n_SetPercent_F (IntPtr jnienv, IntPtr native__this, float percent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPercent (percent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='setPercent' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPercent", "(F)V", "GetSetPercent_FHandler")]
		public virtual unsafe void SetPercent (float percent)
		{
			const string __id = "setPercent.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (percent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTransitionDuration_I;
#pragma warning disable 0169
		static Delegate GetSetTransitionDuration_IHandler ()
		{
			if (cb_setTransitionDuration_I == null)
				cb_setTransitionDuration_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTransitionDuration_I);
			return cb_setTransitionDuration_I;
		}

		static void n_SetTransitionDuration_I (IntPtr jnienv, IntPtr native__this, int transitionDuration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransitionDuration (transitionDuration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIDraggableScrollBar']/method[@name='setTransitionDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTransitionDuration", "(I)V", "GetSetTransitionDuration_IHandler")]
		public virtual unsafe void SetTransitionDuration (int transitionDuration)
		{
			const string __id = "setTransitionDuration.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (transitionDuration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
