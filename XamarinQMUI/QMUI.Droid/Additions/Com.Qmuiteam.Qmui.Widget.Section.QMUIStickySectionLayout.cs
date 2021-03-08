using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Section {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout", DoNotGenerateAcw=true)]
	public partial class QMUIStickySectionLayout : global::Com.Qmuiteam.Qmui.Layout.QMUIFrameLayout, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IViewCallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionLayout.DrawDecoration']"
		[Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$DrawDecoration", "", "Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout/IDrawDecorationInvoker")]
		public partial interface IDrawDecoration : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionLayout.DrawDecoration']/method[@name='onDraw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout']]"
			[Register ("onDraw", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V", "GetOnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout/IDrawDecorationInvoker, QMUI.Droid")]
			void OnDraw (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionLayout.DrawDecoration']/method[@name='onDrawOver' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout']]"
			[Register ("onDrawOver", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V", "GetOnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout/IDrawDecorationInvoker, QMUI.Droid")]
			void OnDrawOver (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout p1);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$DrawDecoration", DoNotGenerateAcw=true)]
		internal partial class IDrawDecorationInvoker : global::Java.Lang.Object, IDrawDecoration {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$DrawDecoration", typeof (IDrawDecorationInvoker));

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

			public static IDrawDecoration GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDrawDecoration> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout.DrawDecoration"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDrawDecorationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
#pragma warning disable 0169
			static Delegate GetOnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler ()
			{
				if (cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ == null)
					cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_);
				return cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
			}

			static void n_OnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDraw (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
			public unsafe void OnDraw (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout p1)
			{
				if (id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ == IntPtr.Zero)
					id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_, __args);
			}

			static Delegate cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
#pragma warning disable 0169
			static Delegate GetOnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler ()
			{
				if (cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ == null)
					cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_);
				return cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
			}

			static void n_OnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDrawOver (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
			public unsafe void OnDrawOver (global::Android.Graphics.Canvas p0, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout p1)
			{
				if (id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ == IntPtr.Zero)
					id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ = JNIEnv.GetMethodID (class_ref, "onDrawOver", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionLayout.StickySectionWrapViewConfig']"
		[Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$StickySectionWrapViewConfig", "", "Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout/IStickySectionWrapViewConfigInvoker")]
		public partial interface IStickySectionWrapViewConfig : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionLayout.StickySectionWrapViewConfig']/method[@name='config' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.layout.QMUIFrameLayout']]"
			[Register ("config", "(Lcom/qmuiteam/qmui/layout/QMUIFrameLayout;)V", "GetConfig_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout/IStickySectionWrapViewConfigInvoker, QMUI.Droid")]
			void Config (global::Com.Qmuiteam.Qmui.Layout.QMUIFrameLayout stickySectionWrapView);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$StickySectionWrapViewConfig", DoNotGenerateAcw=true)]
		internal partial class IStickySectionWrapViewConfigInvoker : global::Java.Lang.Object, IStickySectionWrapViewConfig {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$StickySectionWrapViewConfig", typeof (IStickySectionWrapViewConfigInvoker));

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

			public static IStickySectionWrapViewConfig GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStickySectionWrapViewConfig> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout.StickySectionWrapViewConfig"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStickySectionWrapViewConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_;
#pragma warning disable 0169
			static Delegate GetConfig_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_Handler ()
			{
				if (cb_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_ == null)
					cb_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_);
				return cb_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_;
			}

			static void n_Config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stickySectionWrapView)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IStickySectionWrapViewConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var stickySectionWrapView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIFrameLayout> (native_stickySectionWrapView, JniHandleOwnership.DoNotTransfer);
				__this.Config (stickySectionWrapView);
			}
#pragma warning restore 0169

			IntPtr id_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_;
			public unsafe void Config (global::Com.Qmuiteam.Qmui.Layout.QMUIFrameLayout stickySectionWrapView)
			{
				if (id_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_ == IntPtr.Zero)
					id_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_ = JNIEnv.GetMethodID (class_ref, "config", "(Lcom/qmuiteam/qmui/layout/QMUIFrameLayout;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((stickySectionWrapView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stickySectionWrapView).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_config_Lcom_qmuiteam_qmui_layout_QMUIFrameLayout_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUIStickySectionLayout", typeof (QMUIStickySectionLayout));
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

		protected QMUIStickySectionLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/constructor[@name='QMUIStickySectionLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIStickySectionLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/constructor[@name='QMUIStickySectionLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIStickySectionLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/constructor[@name='QMUIStickySectionLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIStickySectionLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getRecyclerView;
#pragma warning disable 0169
		static Delegate GetGetRecyclerViewHandler ()
		{
			if (cb_getRecyclerView == null)
				cb_getRecyclerView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRecyclerView);
			return cb_getRecyclerView;
		}

		static IntPtr n_GetRecyclerView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecyclerView);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.RecyclerView.Widget.RecyclerView RecyclerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='getRecyclerView' and count(parameter)=0]"
			[Register ("getRecyclerView", "()Landroidx/recyclerview/widget/RecyclerView;", "GetGetRecyclerViewHandler")]
			get {
				const string __id = "getRecyclerView.()Landroidx/recyclerview/widget/RecyclerView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStickyHeaderPosition;
#pragma warning disable 0169
		static Delegate GetGetStickyHeaderPositionHandler ()
		{
			if (cb_getStickyHeaderPosition == null)
				cb_getStickyHeaderPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStickyHeaderPosition);
			return cb_getStickyHeaderPosition;
		}

		static int n_GetStickyHeaderPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StickyHeaderPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int StickyHeaderPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='getStickyHeaderPosition' and count(parameter)=0]"
			[Register ("getStickyHeaderPosition", "()I", "GetGetStickyHeaderPositionHandler")]
			get {
				const string __id = "getStickyHeaderPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStickySectionView;
#pragma warning disable 0169
		static Delegate GetGetStickySectionViewHandler ()
		{
			if (cb_getStickySectionView == null)
				cb_getStickySectionView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStickySectionView);
			return cb_getStickySectionView;
		}

		static IntPtr n_GetStickySectionView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StickySectionView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View StickySectionView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='getStickySectionView' and count(parameter)=0]"
			[Register ("getStickySectionView", "()Landroid/view/View;", "GetGetStickySectionViewHandler")]
			get {
				const string __id = "getStickySectionView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStickySectionWrapView;
#pragma warning disable 0169
		static Delegate GetGetStickySectionWrapViewHandler ()
		{
			if (cb_getStickySectionWrapView == null)
				cb_getStickySectionWrapView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStickySectionWrapView);
			return cb_getStickySectionWrapView;
		}

		static IntPtr n_GetStickySectionWrapView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StickySectionWrapView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Layout.QMUIFrameLayout StickySectionWrapView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='getStickySectionWrapView' and count(parameter)=0]"
			[Register ("getStickySectionWrapView", "()Lcom/qmuiteam/qmui/layout/QMUIFrameLayout;", "GetGetStickySectionWrapViewHandler")]
			get {
				const string __id = "getStickySectionWrapView.()Lcom/qmuiteam/qmui/layout/QMUIFrameLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIFrameLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_;
#pragma warning disable 0169
		static Delegate GetAddDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_Handler ()
		{
			if (cb_addDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_ == null)
				cb_addDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_);
			return cb_addDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_;
		}

		static void n_AddDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawDecoration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drawDecoration = (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration> (native_drawDecoration, JniHandleOwnership.DoNotTransfer);
			__this.AddDrawDecoration (drawDecoration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='addDrawDecoration' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout.DrawDecoration']]"
		[Register ("addDrawDecoration", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$DrawDecoration;)V", "GetAddDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_Handler")]
		public virtual unsafe void AddDrawDecoration (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration drawDecoration)
		{
			const string __id = "addDrawDecoration.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$DrawDecoration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawDecoration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawDecoration).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (drawDecoration);
			}
		}

		static Delegate cb_configStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_;
#pragma warning disable 0169
		static Delegate GetConfigStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_Handler ()
		{
			if (cb_configStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_ == null)
				cb_configStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ConfigStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_);
			return cb_configStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_;
		}

		static void n_ConfigStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stickySectionWrapViewConfig)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stickySectionWrapViewConfig = (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IStickySectionWrapViewConfig)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IStickySectionWrapViewConfig> (native_stickySectionWrapViewConfig, JniHandleOwnership.DoNotTransfer);
			__this.ConfigStickySectionWrapView (stickySectionWrapViewConfig);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='configStickySectionWrapView' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout.StickySectionWrapViewConfig']]"
		[Register ("configStickySectionWrapView", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$StickySectionWrapViewConfig;)V", "GetConfigStickySectionWrapView_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_StickySectionWrapViewConfig_Handler")]
		public virtual unsafe void ConfigStickySectionWrapView (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IStickySectionWrapViewConfig stickySectionWrapViewConfig)
		{
			const string __id = "configStickySectionWrapView.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$StickySectionWrapViewConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stickySectionWrapViewConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stickySectionWrapViewConfig).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (stickySectionWrapViewConfig);
			}
		}

		static Delegate cb_findViewHolderForAdapterPosition_I;
#pragma warning disable 0169
		static Delegate GetFindViewHolderForAdapterPosition_IHandler ()
		{
			if (cb_findViewHolderForAdapterPosition_I == null)
				cb_findViewHolderForAdapterPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_FindViewHolderForAdapterPosition_I);
			return cb_findViewHolderForAdapterPosition_I;
		}

		static IntPtr n_FindViewHolderForAdapterPosition_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindViewHolderForAdapterPosition (position));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='findViewHolderForAdapterPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findViewHolderForAdapterPosition", "(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetFindViewHolderForAdapterPosition_IHandler")]
		public virtual unsafe global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder FindViewHolderForAdapterPosition (int position)
		{
			const string __id = "findViewHolderForAdapterPosition.(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_;
#pragma warning disable 0169
		static Delegate GetRemoveDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_Handler ()
		{
			if (cb_removeDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_ == null)
				cb_removeDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_);
			return cb_removeDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_;
		}

		static void n_RemoveDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawDecoration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drawDecoration = (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration> (native_drawDecoration, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDrawDecoration (drawDecoration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='removeDrawDecoration' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout.DrawDecoration']]"
		[Register ("removeDrawDecoration", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$DrawDecoration;)V", "GetRemoveDrawDecoration_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_DrawDecoration_Handler")]
		public virtual unsafe void RemoveDrawDecoration (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration drawDecoration)
		{
			const string __id = "removeDrawDecoration.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout$DrawDecoration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawDecoration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawDecoration).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (drawDecoration);
			}
		}

		static Delegate cb_requestChildFocus_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRequestChildFocus_Landroid_view_View_Handler ()
		{
			if (cb_requestChildFocus_Landroid_view_View_ == null)
				cb_requestChildFocus_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RequestChildFocus_Landroid_view_View_);
			return cb_requestChildFocus_Landroid_view_View_;
		}

		static void n_RequestChildFocus_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.RequestChildFocus (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='requestChildFocus' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("requestChildFocus", "(Landroid/view/View;)V", "GetRequestChildFocus_Landroid_view_View_Handler")]
		public virtual unsafe void RequestChildFocus (global::Android.Views.View view)
		{
			const string __id = "requestChildFocus.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_scrollToPosition_IZZ;
#pragma warning disable 0169
		static Delegate GetScrollToPosition_IZZHandler ()
		{
			if (cb_scrollToPosition_IZZ == null)
				cb_scrollToPosition_IZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZZ_V) n_ScrollToPosition_IZZ);
			return cb_scrollToPosition_IZZ;
		}

		static void n_ScrollToPosition_IZZ (IntPtr jnienv, IntPtr native__this, int position, bool isSectionHeader, bool scrollToTop)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollToPosition (position, isSectionHeader, scrollToTop);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='scrollToPosition' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("scrollToPosition", "(IZZ)V", "GetScrollToPosition_IZZHandler")]
		public virtual unsafe void ScrollToPosition (int position, bool isSectionHeader, bool scrollToTop)
		{
			const string __id = "scrollToPosition.(IZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (isSectionHeader);
				__args [2] = new JniArgumentValue (scrollToTop);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Handler ()
		{
			if (cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ == null)
				cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_);
			return cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_;
		}

		static void n_SetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adapter = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter> (native_adapter, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (adapter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter&lt;H, T, VH&gt;']]"
		[Register ("setAdapter", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter;)V", "GetSetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>", "VH extends com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewHolder"})]
		public virtual unsafe void SetAdapter (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter adapter)
		{
			const string __id = "setAdapter.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adapter);
			}
		}

		static Delegate cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Z;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ZHandler ()
		{
			if (cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Z == null)
				cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_SetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Z);
			return cb_setAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Z;
		}

		static void n_SetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_adapter, bool sticky)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adapter = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter> (native_adapter, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (adapter, sticky);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='setAdapter' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter&lt;H, T, VH&gt;'] and parameter[2][@type='boolean']]"
		[Register ("setAdapter", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter;Z)V", "GetSetAdapter_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ZHandler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>", "VH extends com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewHolder"})]
		public virtual unsafe void SetAdapter (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter adapter, bool sticky)
		{
			const string __id = "setAdapter.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((adapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapter).Handle);
				__args [1] = new JniArgumentValue (sticky);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adapter);
			}
		}

		static Delegate cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_;
#pragma warning disable 0169
		static Delegate GetSetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_Handler ()
		{
			if (cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_ == null)
				cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_);
			return cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_;
		}

		static void n_SetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_layoutManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var layoutManager = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.LayoutManager> (native_layoutManager, JniHandleOwnership.DoNotTransfer);
			__this.SetLayoutManager (layoutManager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionLayout']/method[@name='setLayoutManager' and count(parameter)=1 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView.LayoutManager']]"
		[Register ("setLayoutManager", "(Landroidx/recyclerview/widget/RecyclerView$LayoutManager;)V", "GetSetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_Handler")]
		public virtual unsafe void SetLayoutManager (global::AndroidX.RecyclerView.Widget.RecyclerView.LayoutManager layoutManager)
		{
			const string __id = "setLayoutManager.(Landroidx/recyclerview/widget/RecyclerView$LayoutManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layoutManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutManager).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layoutManager);
			}
		}

	}
}
