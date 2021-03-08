using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabIcon", DoNotGenerateAcw=true)]
	public partial class QMUITabIcon : global::Android.Graphics.Drawables.Drawable, global::Android.Graphics.Drawables.Drawable.ICallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/field[@name='TAB_ICON_INTRINSIC']"
		[Register ("TAB_ICON_INTRINSIC")]
		public const int TabIconIntrinsic = (int) -1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabIcon", typeof (QMUITabIcon));
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

		protected QMUITabIcon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/constructor[@name='QMUITabIcon' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe QMUITabIcon (global::Android.Graphics.Drawables.Drawable normalIconDrawable, global::Android.Graphics.Drawables.Drawable selectedIconDrawable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((normalIconDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalIconDrawable).Handle);
				__args [1] = new JniArgumentValue ((selectedIconDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedIconDrawable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (normalIconDrawable);
				global::System.GC.KeepAlive (selectedIconDrawable);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/constructor[@name='QMUITabIcon' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Z)V", "")]
		public unsafe QMUITabIcon (global::Android.Graphics.Drawables.Drawable normalIconDrawable, global::Android.Graphics.Drawables.Drawable selectedIconDrawable, bool dynamicChangeIconColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((normalIconDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalIconDrawable).Handle);
				__args [1] = new JniArgumentValue ((selectedIconDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedIconDrawable).Handle);
				__args [2] = new JniArgumentValue (dynamicChangeIconColor);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (normalIconDrawable);
				global::System.GC.KeepAlive (selectedIconDrawable);
			}
		}

		static Delegate cb_hasSelectedIcon;
#pragma warning disable 0169
		static Delegate GetHasSelectedIconHandler ()
		{
			if (cb_hasSelectedIcon == null)
				cb_hasSelectedIcon = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasSelectedIcon);
			return cb_hasSelectedIcon;
		}

		static bool n_HasSelectedIcon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSelectedIcon;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasSelectedIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='hasSelectedIcon' and count(parameter)=0]"
			[Register ("hasSelectedIcon", "()Z", "GetHasSelectedIconHandler")]
			get {
				const string __id = "hasSelectedIcon.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				const string __id = "getOpacity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
			}
		}

		static Delegate cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_who)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateDrawable (who);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='invalidateDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void InvalidateDrawable (global::Android.Graphics.Drawables.Drawable who)
		{
			const string __id = "invalidateDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((who == null) ? IntPtr.Zero : ((global::Java.Lang.Object) who).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (who);
			}
		}

		static Delegate cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == null)
				cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_V) n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J);
			return cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
		}

		static void n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what, long when)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			var what = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_what, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleDrawable (who, what, when);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='scheduleDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='long']]"
		[Register ("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", "GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler")]
		public virtual unsafe void ScheduleDrawable (global::Android.Graphics.Drawables.Drawable who, global::Java.Lang.IRunnable what, long when)
		{
			const string __id = "scheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((who == null) ? IntPtr.Zero : ((global::Java.Lang.Object) who).Handle);
				__args [1] = new JniArgumentValue ((what == null) ? IntPtr.Zero : ((global::Java.Lang.Object) what).Handle);
				__args [2] = new JniArgumentValue (when);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (who);
				global::System.GC.KeepAlive (what);
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int alpha)
		{
			const string __id = "setAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (colorFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter colorFilter)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorFilter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (colorFilter);
			}
		}

		static Delegate cb_setSelectFraction_FI;
#pragma warning disable 0169
		static Delegate GetSetSelectFraction_FIHandler ()
		{
			if (cb_setSelectFraction_FI == null)
				cb_setSelectFraction_FI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFI_V) n_SetSelectFraction_FI);
			return cb_setSelectFraction_FI;
		}

		static void n_SetSelectFraction_FI (IntPtr jnienv, IntPtr native__this, float fraction, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectFraction (fraction, color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='setSelectFraction' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("setSelectFraction", "(FI)V", "GetSetSelectFraction_FIHandler")]
		public virtual unsafe void SetSelectFraction (float fraction, int color)
		{
			const string __id = "setSelectFraction.(FI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fraction);
				__args [1] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_src_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSrc_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_src_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_src_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Src_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_);
			return cb_src_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_Src_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normalDrawable, IntPtr native_selectDrawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var normalDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_normalDrawable, JniHandleOwnership.DoNotTransfer);
			var selectDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_selectDrawable, JniHandleOwnership.DoNotTransfer);
			__this.Src (normalDrawable, selectDrawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='src' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("src", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", "GetSrc_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void Src (global::Android.Graphics.Drawables.Drawable normalDrawable, global::Android.Graphics.Drawables.Drawable selectDrawable)
		{
			const string __id = "src.(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((normalDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalDrawable).Handle);
				__args [1] = new JniArgumentValue ((selectDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectDrawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (normalDrawable);
				global::System.GC.KeepAlive (selectDrawable);
			}
		}

		static Delegate cb_src_Landroid_graphics_drawable_Drawable_II;
#pragma warning disable 0169
		static Delegate GetSrc_Landroid_graphics_drawable_Drawable_IIHandler ()
		{
			if (cb_src_Landroid_graphics_drawable_Drawable_II == null)
				cb_src_Landroid_graphics_drawable_Drawable_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_Src_Landroid_graphics_drawable_Drawable_II);
			return cb_src_Landroid_graphics_drawable_Drawable_II;
		}

		static void n_Src_Landroid_graphics_drawable_Drawable_II (IntPtr jnienv, IntPtr native__this, IntPtr native_normalDrawable, int normalColor, int selectColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var normalDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_normalDrawable, JniHandleOwnership.DoNotTransfer);
			__this.Src (normalDrawable, normalColor, selectColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='src' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("src", "(Landroid/graphics/drawable/Drawable;II)V", "GetSrc_Landroid_graphics_drawable_Drawable_IIHandler")]
		public virtual unsafe void Src (global::Android.Graphics.Drawables.Drawable normalDrawable, int normalColor, int selectColor)
		{
			const string __id = "src.(Landroid/graphics/drawable/Drawable;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((normalDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalDrawable).Handle);
				__args [1] = new JniArgumentValue (normalColor);
				__args [2] = new JniArgumentValue (selectColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (normalDrawable);
			}
		}

		static Delegate cb_srcNormal_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSrcNormal_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_srcNormal_Landroid_graphics_drawable_Drawable_ == null)
				cb_srcNormal_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SrcNormal_Landroid_graphics_drawable_Drawable_);
			return cb_srcNormal_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SrcNormal_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normalDrawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var normalDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_normalDrawable, JniHandleOwnership.DoNotTransfer);
			__this.SrcNormal (normalDrawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='srcNormal' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("srcNormal", "(Landroid/graphics/drawable/Drawable;)V", "GetSrcNormal_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SrcNormal (global::Android.Graphics.Drawables.Drawable normalDrawable)
		{
			const string __id = "srcNormal.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((normalDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalDrawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (normalDrawable);
			}
		}

		static Delegate cb_srcSelected_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSrcSelected_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_srcSelected_Landroid_graphics_drawable_Drawable_ == null)
				cb_srcSelected_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SrcSelected_Landroid_graphics_drawable_Drawable_);
			return cb_srcSelected_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SrcSelected_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectDrawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var selectDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_selectDrawable, JniHandleOwnership.DoNotTransfer);
			__this.SrcSelected (selectDrawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='srcSelected' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("srcSelected", "(Landroid/graphics/drawable/Drawable;)V", "GetSrcSelected_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SrcSelected (global::Android.Graphics.Drawables.Drawable selectDrawable)
		{
			const string __id = "srcSelected.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((selectDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectDrawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (selectDrawable);
			}
		}

		static Delegate cb_tint_II;
#pragma warning disable 0169
		static Delegate GetTint_IIHandler ()
		{
			if (cb_tint_II == null)
				cb_tint_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_Tint_II);
			return cb_tint_II;
		}

		static void n_Tint_II (IntPtr jnienv, IntPtr native__this, int normalColor, int selectColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Tint (normalColor, selectColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='tint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("tint", "(II)V", "GetTint_IIHandler")]
		public virtual unsafe void Tint (int normalColor, int selectColor)
		{
			const string __id = "tint.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (normalColor);
				__args [1] = new JniArgumentValue (selectColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_tintNormal_I;
#pragma warning disable 0169
		static Delegate GetTintNormal_IHandler ()
		{
			if (cb_tintNormal_I == null)
				cb_tintNormal_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_TintNormal_I);
			return cb_tintNormal_I;
		}

		static void n_TintNormal_I (IntPtr jnienv, IntPtr native__this, int normalColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TintNormal (normalColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='tintNormal' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("tintNormal", "(I)V", "GetTintNormal_IHandler")]
		public virtual unsafe void TintNormal (int normalColor)
		{
			const string __id = "tintNormal.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_tintSelected_I;
#pragma warning disable 0169
		static Delegate GetTintSelected_IHandler ()
		{
			if (cb_tintSelected_I == null)
				cb_tintSelected_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_TintSelected_I);
			return cb_tintSelected_I;
		}

		static void n_TintSelected_I (IntPtr jnienv, IntPtr native__this, int selectColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TintSelected (selectColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='tintSelected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("tintSelected", "(I)V", "GetTintSelected_IHandler")]
		public virtual unsafe void TintSelected (int selectColor)
		{
			const string __id = "tintSelected.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (selectColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == null)
				cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_);
			return cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
		}

		static void n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIcon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var who = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_who, JniHandleOwnership.DoNotTransfer);
			var what = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_what, JniHandleOwnership.DoNotTransfer);
			__this.UnscheduleDrawable (who, what);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIcon']/method[@name='unscheduleDrawable' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", "GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void UnscheduleDrawable (global::Android.Graphics.Drawables.Drawable who, global::Java.Lang.IRunnable what)
		{
			const string __id = "unscheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((who == null) ? IntPtr.Zero : ((global::Java.Lang.Object) who).Handle);
				__args [1] = new JniArgumentValue ((what == null) ? IntPtr.Zero : ((global::Java.Lang.Object) what).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (who);
				global::System.GC.KeepAlive (what);
			}
		}

	}
}
