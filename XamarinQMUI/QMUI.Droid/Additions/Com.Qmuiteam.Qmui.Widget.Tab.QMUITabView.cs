using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabView", DoNotGenerateAcw=true)]
	public partial class QMUITabView : global::Android.Widget.FrameLayout, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUITabView.Callback']"
		[Register ("com/qmuiteam/qmui/widget/tab/QMUITabView$Callback", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUITabView.Callback']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView']]"
			[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V", "GetOnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler:Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView/ICallbackInvoker, QMUI.Droid")]
			void OnClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUITabView.Callback']/method[@name='onDoubleClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView']]"
			[Register ("onDoubleClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V", "GetOnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler:Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView/ICallbackInvoker, QMUI.Droid")]
			void OnDoubleClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUITabView.Callback']/method[@name='onLongClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView']]"
			[Register ("onLongClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V", "GetOnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler:Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView/ICallbackInvoker, QMUI.Droid")]
			void OnLongClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabView$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabView$Callback", typeof (ICallbackInvoker));

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

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUITabView.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
#pragma warning disable 0169
			static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler ()
			{
				if (cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == null)
					cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_);
				return cb_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
			}

			static void n_OnClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (view);
			}
#pragma warning restore 0169

			IntPtr id_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
			public unsafe void OnClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view)
			{
				if (id_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == IntPtr.Zero)
					id_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_, __args);
			}

			static Delegate cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
#pragma warning disable 0169
			static Delegate GetOnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler ()
			{
				if (cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == null)
					cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_);
				return cb_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
			}

			static void n_OnDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
				__this.OnDoubleClick (view);
			}
#pragma warning restore 0169

			IntPtr id_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
			public unsafe void OnDoubleClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view)
			{
				if (id_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == IntPtr.Zero)
					id_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNIEnv.GetMethodID (class_ref, "onDoubleClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDoubleClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_, __args);
			}

			static Delegate cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
#pragma warning disable 0169
			static Delegate GetOnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Handler ()
			{
				if (cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == null)
					cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_);
				return cb_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
			}

			static void n_OnLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
				__this.OnLongClick (view);
			}
#pragma warning restore 0169

			IntPtr id_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_;
			public unsafe void OnLongClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view)
			{
				if (id_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ == IntPtr.Zero)
					id_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_ = JNIEnv.GetMethodID (class_ref, "onLongClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLongClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabView", typeof (QMUITabView));
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

		protected QMUITabView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/constructor[@name='QMUITabView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUITabView (global::Android.Content.Context context)
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

		static Delegate cb_getContentViewLeft;
#pragma warning disable 0169
		static Delegate GetGetContentViewLeftHandler ()
		{
			if (cb_getContentViewLeft == null)
				cb_getContentViewLeft = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetContentViewLeft);
			return cb_getContentViewLeft;
		}

		static int n_GetContentViewLeft (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentViewLeft;
		}
#pragma warning restore 0169

		public virtual unsafe int ContentViewLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='getContentViewLeft' and count(parameter)=0]"
			[Register ("getContentViewLeft", "()I", "GetGetContentViewLeftHandler")]
			get {
				const string __id = "getContentViewLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getContentViewWidth;
#pragma warning disable 0169
		static Delegate GetGetContentViewWidthHandler ()
		{
			if (cb_getContentViewWidth == null)
				cb_getContentViewWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetContentViewWidth);
			return cb_getContentViewWidth;
		}

		static int n_GetContentViewWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentViewWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int ContentViewWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='getContentViewWidth' and count(parameter)=0]"
			[Register ("getContentViewWidth", "()I", "GetGetContentViewWidthHandler")]
			get {
				const string __id = "getContentViewWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectFraction;
#pragma warning disable 0169
		static Delegate GetGetSelectFractionHandler ()
		{
			if (cb_getSelectFraction == null)
				cb_getSelectFraction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetSelectFraction);
			return cb_getSelectFraction;
		}

		static float n_GetSelectFraction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectFraction;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectFraction_F;
#pragma warning disable 0169
		static Delegate GetSetSelectFraction_FHandler ()
		{
			if (cb_setSelectFraction_F == null)
				cb_setSelectFraction_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetSelectFraction_F);
			return cb_setSelectFraction_F;
		}

		static void n_SetSelectFraction_F (IntPtr jnienv, IntPtr native__this, float fraction)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectFraction = fraction;
		}
#pragma warning restore 0169

		public virtual unsafe float SelectFraction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='getSelectFraction' and count(parameter)=0]"
			[Register ("getSelectFraction", "()F", "GetGetSelectFractionHandler")]
			get {
				const string __id = "getSelectFraction.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='setSelectFraction' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSelectFraction", "(F)V", "GetSetSelectFraction_FHandler")]
			set {
				const string __id = "setSelectFraction.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_bind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_;
#pragma warning disable 0169
		static Delegate GetBind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Handler ()
		{
			if (cb_bind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ == null)
				cb_bind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Bind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_);
			return cb_bind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_;
		}

		static void n_Bind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tab = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (native_tab, JniHandleOwnership.DoNotTransfer);
			__this.Bind (tab);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='bind' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITab']]"
		[Register ("bind", "(Lcom/qmuiteam/qmui/widget/tab/QMUITab;)V", "GetBind_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Handler")]
		public virtual unsafe void Bind (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab tab)
		{
			const string __id = "bind.(Lcom/qmuiteam/qmui/widget/tab/QMUITab;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tab == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tab).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tab);
			}
		}

		static Delegate cb_createSignCountView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreateSignCountView_Landroid_content_Context_Handler ()
		{
			if (cb_createSignCountView_Landroid_content_Context_ == null)
				cb_createSignCountView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateSignCountView_Landroid_content_Context_);
			return cb_createSignCountView_Landroid_content_Context_;
		}

		static IntPtr n_CreateSignCountView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSignCountView (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='createSignCountView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createSignCountView", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/roundwidget/QMUIRoundButton;", "GetCreateSignCountView_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Roundwidget.QMUIRoundButton CreateSignCountView (global::Android.Content.Context context)
		{
			const string __id = "createSignCountView.(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/roundwidget/QMUIRoundButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Roundwidget.QMUIRoundButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "")]
		public override sealed unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
			}
		}

		static Delegate cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_;
#pragma warning disable 0169
		static Delegate GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_Handler ()
		{
			if (cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ == null)
				cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_V) n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_);
			return cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_;
		}

		static void n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_manager, int skinIndex, IntPtr native_theme, IntPtr native_attrs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			var attrs = global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (native_attrs, JniHandleOwnership.DoNotTransfer);
			__this.Handle (manager, skinIndex, theme, attrs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='androidx.collection.SimpleArrayMap&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V", "GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_Handler")]
		public new virtual unsafe void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager manager, int skinIndex, global::Android.Content.Res.Resources.Theme theme, global::AndroidX.Collection.SimpleArrayMap attrs)
		{
			const string __id = "handle.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				__args [1] = new JniArgumentValue (skinIndex);
				__args [2] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [3] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manager);
				global::System.GC.KeepAlive (theme);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_onDrawTab_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetOnDrawTab_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_onDrawTab_Landroid_graphics_Canvas_ == null)
				cb_onDrawTab_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDrawTab_Landroid_graphics_Canvas_);
			return cb_onDrawTab_Landroid_graphics_Canvas_;
		}

		static void n_OnDrawTab_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawTab (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='onDrawTab' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("onDrawTab", "(Landroid/graphics/Canvas;)V", "GetOnDrawTab_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void OnDrawTab (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "onDrawTab.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "")]
		protected override sealed unsafe void OnLayout (bool changed, int left, int top, int right, int bottom)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (left);
				__args [2] = new JniArgumentValue (top);
				__args [3] = new JniArgumentValue (right);
				__args [4] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLayoutSignCount_II;
#pragma warning disable 0169
		static Delegate GetOnLayoutSignCount_IIHandler ()
		{
			if (cb_onLayoutSignCount_II == null)
				cb_onLayoutSignCount_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnLayoutSignCount_II);
			return cb_onLayoutSignCount_II;
		}

		static void n_OnLayoutSignCount_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayoutSignCount (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='onLayoutSignCount' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onLayoutSignCount", "(II)V", "GetOnLayoutSignCount_IIHandler")]
		protected virtual unsafe void OnLayoutSignCount (int width, int height)
		{
			const string __id = "onLayoutSignCount.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLayoutTab_II;
#pragma warning disable 0169
		static Delegate GetOnLayoutTab_IIHandler ()
		{
			if (cb_onLayoutTab_II == null)
				cb_onLayoutTab_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnLayoutTab_II);
			return cb_onLayoutTab_II;
		}

		static void n_OnLayoutTab_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayoutTab (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='onLayoutTab' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onLayoutTab", "(II)V", "GetOnLayoutTab_IIHandler")]
		protected virtual unsafe void OnLayoutTab (int width, int height)
		{
			const string __id = "onLayoutTab.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onMeasureTab_II;
#pragma warning disable 0169
		static Delegate GetOnMeasureTab_IIHandler ()
		{
			if (cb_onMeasureTab_II == null)
				cb_onMeasureTab_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnMeasureTab_II);
			return cb_onMeasureTab_II;
		}

		static void n_OnMeasureTab_II (IntPtr jnienv, IntPtr native__this, int widthSize, int heightSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMeasureTab (widthSize, heightSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='onMeasureTab' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onMeasureTab", "(II)V", "GetOnMeasureTab_IIHandler")]
		protected virtual unsafe void OnMeasureTab (int widthSize, int heightSize)
		{
			const string __id = "onMeasureTab.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (widthSize);
				__args [1] = new JniArgumentValue (heightSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_Handler ()
		{
			if (cb_setCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_ == null)
				cb_setCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_);
			return cb_setCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_;
		}

		static void n_SetCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView.ICallback)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView.Callback']]"
		[Register ("setCallback", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView$Callback;)V", "GetSetCallback_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_Callback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView.ICallback @callback)
		{
			const string __id = "setCallback.(Lcom/qmuiteam/qmui/widget/tab/QMUITabView$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setPositionInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetPositionInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setPositionInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setPositionInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPositionInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setPositionInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetPositionInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_positionInterpolator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var positionInterpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_positionInterpolator, JniHandleOwnership.DoNotTransfer);
			__this.SetPositionInterpolator (positionInterpolator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabView']/method[@name='setPositionInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setPositionInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetPositionInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public virtual unsafe void SetPositionInterpolator (global::Android.Views.Animations.IInterpolator positionInterpolator)
		{
			const string __id = "setPositionInterpolator.(Landroid/view/animation/Interpolator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((positionInterpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) positionInterpolator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (positionInterpolator);
			}
		}

	}
}
