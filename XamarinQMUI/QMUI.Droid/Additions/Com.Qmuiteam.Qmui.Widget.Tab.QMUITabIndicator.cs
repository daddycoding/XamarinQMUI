using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabIndicator", DoNotGenerateAcw=true)]
	public partial class QMUITabIndicator : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabIndicator", typeof (QMUITabIndicator));
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

		protected QMUITabIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/constructor[@name='QMUITabIndicator' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;ZZ)V", "")]
		public unsafe QMUITabIndicator (global::Android.Graphics.Drawables.Drawable drawable, bool indicatorTop, bool isIndicatorWidthFollowContent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue (indicatorTop);
				__args [2] = new JniArgumentValue (isIndicatorWidthFollowContent);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (drawable);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/constructor[@name='QMUITabIndicator' and count(parameter)=4 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;ZZI)V", "")]
		public unsafe QMUITabIndicator (global::Android.Graphics.Drawables.Drawable drawable, bool indicatorTop, bool isIndicatorWidthFollowContent, int fixedColorAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;ZZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue (indicatorTop);
				__args [2] = new JniArgumentValue (isIndicatorWidthFollowContent);
				__args [3] = new JniArgumentValue (fixedColorAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (drawable);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/constructor[@name='QMUITabIndicator' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(IZZ)V", "")]
		public unsafe QMUITabIndicator (int indicatorHeight, bool indicatorTop, bool isIndicatorWidthFollowContent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (indicatorHeight);
				__args [1] = new JniArgumentValue (indicatorTop);
				__args [2] = new JniArgumentValue (isIndicatorWidthFollowContent);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/constructor[@name='QMUITabIndicator' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IZZI)V", "")]
		public unsafe QMUITabIndicator (int indicatorHeight, bool indicatorTop, bool isIndicatorWidthFollowContent, int fixedColorAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IZZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (indicatorHeight);
				__args [1] = new JniArgumentValue (indicatorTop);
				__args [2] = new JniArgumentValue (isIndicatorWidthFollowContent);
				__args [3] = new JniArgumentValue (fixedColorAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isIndicatorTop;
#pragma warning disable 0169
		static Delegate GetIsIndicatorTopHandler ()
		{
			if (cb_isIndicatorTop == null)
				cb_isIndicatorTop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIndicatorTop);
			return cb_isIndicatorTop;
		}

		static bool n_IsIndicatorTop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIndicatorTop;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIndicatorTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/method[@name='isIndicatorTop' and count(parameter)=0]"
			[Register ("isIndicatorTop", "()Z", "GetIsIndicatorTopHandler")]
			get {
				const string __id = "isIndicatorTop.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isIndicatorWidthFollowContent;
#pragma warning disable 0169
		static Delegate GetIsIndicatorWidthFollowContentHandler ()
		{
			if (cb_isIndicatorWidthFollowContent == null)
				cb_isIndicatorWidthFollowContent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIndicatorWidthFollowContent);
			return cb_isIndicatorWidthFollowContent;
		}

		static bool n_IsIndicatorWidthFollowContent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIndicatorWidthFollowContent;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIndicatorWidthFollowContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/method[@name='isIndicatorWidthFollowContent' and count(parameter)=0]"
			[Register ("isIndicatorWidthFollowContent", "()Z", "GetIsIndicatorWidthFollowContentHandler")]
			get {
				const string __id = "isIndicatorWidthFollowContent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_view_View_Landroid_graphics_Canvas_II;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_view_View_Landroid_graphics_Canvas_IIHandler ()
		{
			if (cb_draw_Landroid_view_View_Landroid_graphics_Canvas_II == null)
				cb_draw_Landroid_view_View_Landroid_graphics_Canvas_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_Draw_Landroid_view_View_Landroid_graphics_Canvas_II);
			return cb_draw_Landroid_view_View_Landroid_graphics_Canvas_II;
		}

		static void n_Draw_Landroid_view_View_Landroid_graphics_Canvas_II (IntPtr jnienv, IntPtr native__this, IntPtr native_hostView, IntPtr native_canvas, int viewTop, int viewBottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hostView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_hostView, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (hostView, canvas, viewTop, viewBottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/method[@name='draw' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("draw", "(Landroid/view/View;Landroid/graphics/Canvas;II)V", "GetDraw_Landroid_view_View_Landroid_graphics_Canvas_IIHandler")]
		protected virtual unsafe void Draw (global::Android.Views.View hostView, global::Android.Graphics.Canvas canvas, int viewTop, int viewBottom)
		{
			const string __id = "draw.(Landroid/view/View;Landroid/graphics/Canvas;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((hostView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hostView).Handle);
				__args [1] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [2] = new JniArgumentValue (viewTop);
				__args [3] = new JniArgumentValue (viewBottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (hostView);
				global::System.GC.KeepAlive (canvas);
			}
		}

		static Delegate cb_handleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_;
#pragma warning disable 0169
		static Delegate GetHandleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Handler ()
		{
			if (cb_handleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ == null)
				cb_handleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_V) n_HandleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_);
			return cb_handleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_;
		}

		static void n_HandleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_manager, int skinIndex, IntPtr native_theme, IntPtr native_selectedTab)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			var selectedTab = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (native_selectedTab, JniHandleOwnership.DoNotTransfer);
			__this.HandleSkinChange (manager, skinIndex, theme, selectedTab);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/method[@name='handleSkinChange' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='com.qmuiteam.qmui.widget.tab.QMUITab']]"
		[Register ("handleSkinChange", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Lcom/qmuiteam/qmui/widget/tab/QMUITab;)V", "GetHandleSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Handler")]
		protected virtual unsafe void HandleSkinChange (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager manager, int skinIndex, global::Android.Content.Res.Resources.Theme theme, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab selectedTab)
		{
			const string __id = "handleSkinChange.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Lcom/qmuiteam/qmui/widget/tab/QMUITab;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				__args [1] = new JniArgumentValue (skinIndex);
				__args [2] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [3] = new JniArgumentValue ((selectedTab == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedTab).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manager);
				global::System.GC.KeepAlive (theme);
				global::System.GC.KeepAlive (selectedTab);
			}
		}

		static Delegate cb_updateColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateColor_IHandler ()
		{
			if (cb_updateColor_I == null)
				cb_updateColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateColor_I);
			return cb_updateColor_I;
		}

		static void n_UpdateColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/method[@name='updateColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateColor", "(I)V", "GetUpdateColor_IHandler")]
		protected virtual unsafe void UpdateColor (int color)
		{
			const string __id = "updateColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateInfo_III;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetUpdateInfo_IIIHandler ()
		{
			if (cb_updateInfo_III == null)
				cb_updateInfo_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_UpdateInfo_III);
			return cb_updateInfo_III;
		}

		[Obsolete]
		static void n_UpdateInfo_III (IntPtr jnienv, IntPtr native__this, int left, int width, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateInfo (left, width, color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/method[@name='updateInfo' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("updateInfo", "(III)V", "GetUpdateInfo_IIIHandler")]
		protected virtual unsafe void UpdateInfo (int left, int width, int color)
		{
			const string __id = "updateInfo.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateInfo_IIIF;
#pragma warning disable 0169
		static Delegate GetUpdateInfo_IIIFHandler ()
		{
			if (cb_updateInfo_IIIF == null)
				cb_updateInfo_IIIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIF_V) n_UpdateInfo_IIIF);
			return cb_updateInfo_IIIF;
		}

		static void n_UpdateInfo_IIIF (IntPtr jnienv, IntPtr native__this, int left, int width, int color, float offsetPercent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateInfo (left, width, color, offsetPercent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabIndicator']/method[@name='updateInfo' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("updateInfo", "(IIIF)V", "GetUpdateInfo_IIIFHandler")]
		protected virtual unsafe void UpdateInfo (int left, int width, int color, float offsetPercent)
		{
			const string __id = "updateInfo.(IIIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (color);
				__args [3] = new JniArgumentValue (offsetPercent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
