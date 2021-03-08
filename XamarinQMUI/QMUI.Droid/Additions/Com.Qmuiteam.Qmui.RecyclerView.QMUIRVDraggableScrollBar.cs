using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.RecyclerView {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUIRVDraggableScrollBar", DoNotGenerateAcw=true)]
	public partial class QMUIRVDraggableScrollBar : global::AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerDecoration, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout.IDrawDecoration {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/interface[@name='QMUIRVDraggableScrollBar.Callback']"
		[Register ("com/qmuiteam/qmui/recyclerView/QMUIRVDraggableScrollBar$Callback", "", "Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/interface[@name='QMUIRVDraggableScrollBar.Callback']/method[@name='onDragEnd' and count(parameter)=0]"
			[Register ("onDragEnd", "()V", "GetOnDragEndHandler:Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar/ICallbackInvoker, QMUI.Droid")]
			void OnDragEnd ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/interface[@name='QMUIRVDraggableScrollBar.Callback']/method[@name='onDragStarted' and count(parameter)=0]"
			[Register ("onDragStarted", "()V", "GetOnDragStartedHandler:Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar/ICallbackInvoker, QMUI.Droid")]
			void OnDragStarted ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/interface[@name='QMUIRVDraggableScrollBar.Callback']/method[@name='onDragToPercent' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("onDragToPercent", "(F)V", "GetOnDragToPercent_FHandler:Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar/ICallbackInvoker, QMUI.Droid")]
			void OnDragToPercent (float percent);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUIRVDraggableScrollBar$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUIRVDraggableScrollBar$Callback", typeof (ICallbackInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.recyclerView.QMUIRVDraggableScrollBar.Callback"));
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

			static Delegate cb_onDragEnd;
#pragma warning disable 0169
			static Delegate GetOnDragEndHandler ()
			{
				if (cb_onDragEnd == null)
					cb_onDragEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDragEnd);
				return cb_onDragEnd;
			}

			static void n_OnDragEnd (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDragEnd ();
			}
#pragma warning restore 0169

			IntPtr id_onDragEnd;
			public unsafe void OnDragEnd ()
			{
				if (id_onDragEnd == IntPtr.Zero)
					id_onDragEnd = JNIEnv.GetMethodID (class_ref, "onDragEnd", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDragEnd);
			}

			static Delegate cb_onDragStarted;
#pragma warning disable 0169
			static Delegate GetOnDragStartedHandler ()
			{
				if (cb_onDragStarted == null)
					cb_onDragStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDragStarted);
				return cb_onDragStarted;
			}

			static void n_OnDragStarted (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDragStarted ();
			}
#pragma warning restore 0169

			IntPtr id_onDragStarted;
			public unsafe void OnDragStarted ()
			{
				if (id_onDragStarted == IntPtr.Zero)
					id_onDragStarted = JNIEnv.GetMethodID (class_ref, "onDragStarted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDragStarted);
			}

			static Delegate cb_onDragToPercent_F;
#pragma warning disable 0169
			static Delegate GetOnDragToPercent_FHandler ()
			{
				if (cb_onDragToPercent_F == null)
					cb_onDragToPercent_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_OnDragToPercent_F);
				return cb_onDragToPercent_F;
			}

			static void n_OnDragToPercent_F (IntPtr jnienv, IntPtr native__this, float percent)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDragToPercent (percent);
			}
#pragma warning restore 0169

			IntPtr id_onDragToPercent_F;
			public unsafe void OnDragToPercent (float percent)
			{
				if (id_onDragToPercent_F == IntPtr.Zero)
					id_onDragToPercent_F = JNIEnv.GetMethodID (class_ref, "onDragToPercent", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (percent);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDragToPercent_F, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUIRVDraggableScrollBar", typeof (QMUIRVDraggableScrollBar));
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

		protected QMUIRVDraggableScrollBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/constructor[@name='QMUIRVDraggableScrollBar' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe QMUIRVDraggableScrollBar (int startMargin, int endMargin, int inwardOffset)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (startMargin);
				__args [1] = new JniArgumentValue (endMargin);
				__args [2] = new JniArgumentValue (inwardOffset);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/constructor[@name='QMUIRVDraggableScrollBar' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(IIIZZ)V", "")]
		public unsafe QMUIRVDraggableScrollBar (int startMargin, int endMargin, int inwardOffset, bool isVerticalScroll, bool isLocationInOppositeSide)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (startMargin);
				__args [1] = new JniArgumentValue (endMargin);
				__args [2] = new JniArgumentValue (inwardOffset);
				__args [3] = new JniArgumentValue (isVerticalScroll);
				__args [4] = new JniArgumentValue (isLocationInOppositeSide);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isDraggable;
#pragma warning disable 0169
		static Delegate GetIsDraggableHandler ()
		{
			if (cb_isDraggable == null)
				cb_isDraggable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDraggable);
			return cb_isDraggable;
		}

		static bool n_IsDraggable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Draggable;
		}
#pragma warning restore 0169

		static Delegate cb_setDraggable_Z;
#pragma warning disable 0169
		static Delegate GetSetDraggable_ZHandler ()
		{
			if (cb_setDraggable_Z == null)
				cb_setDraggable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDraggable_Z);
			return cb_setDraggable_Z;
		}

		static void n_SetDraggable_Z (IntPtr jnienv, IntPtr native__this, bool draggable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draggable = draggable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				const string __id = "isDraggable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set {
				const string __id = "setDraggable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isEnableScrollBarFadeInOut;
#pragma warning disable 0169
		static Delegate GetIsEnableScrollBarFadeInOutHandler ()
		{
			if (cb_isEnableScrollBarFadeInOut == null)
				cb_isEnableScrollBarFadeInOut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnableScrollBarFadeInOut);
			return cb_isEnableScrollBarFadeInOut;
		}

		static bool n_IsEnableScrollBarFadeInOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableScrollBarFadeInOut;
		}
#pragma warning restore 0169

		static Delegate cb_setEnableScrollBarFadeInOut_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableScrollBarFadeInOut_ZHandler ()
		{
			if (cb_setEnableScrollBarFadeInOut_Z == null)
				cb_setEnableScrollBarFadeInOut_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnableScrollBarFadeInOut_Z);
			return cb_setEnableScrollBarFadeInOut_Z;
		}

		static void n_SetEnableScrollBarFadeInOut_Z (IntPtr jnienv, IntPtr native__this, bool enableScrollBarFadeInOut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableScrollBarFadeInOut = enableScrollBarFadeInOut;
		}
#pragma warning restore 0169

		public virtual unsafe bool EnableScrollBarFadeInOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='isEnableScrollBarFadeInOut' and count(parameter)=0]"
			[Register ("isEnableScrollBarFadeInOut", "()Z", "GetIsEnableScrollBarFadeInOutHandler")]
			get {
				const string __id = "isEnableScrollBarFadeInOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='setEnableScrollBarFadeInOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableScrollBarFadeInOut", "(Z)V", "GetSetEnableScrollBarFadeInOut_ZHandler")]
			set {
				const string __id = "setEnableScrollBarFadeInOut.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;
#pragma warning disable 0169
		static Delegate GetAttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler ()
		{
			if (cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ == null)
				cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_);
			return cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;
		}

		static void n_AttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
			__this.AttachToRecyclerView (recyclerView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='attachToRecyclerView' and count(parameter)=1 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView']]"
		[Register ("attachToRecyclerView", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetAttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler")]
		public virtual unsafe void AttachToRecyclerView (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView)
		{
			const string __id = "attachToRecyclerView.(Landroidx/recyclerview/widget/RecyclerView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (recyclerView);
			}
		}

		static Delegate cb_attachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
#pragma warning disable 0169
		static Delegate GetAttachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler ()
		{
			if (cb_attachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ == null)
				cb_attachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AttachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_);
			return cb_attachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
		}

		static void n_AttachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stickySectionLayout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stickySectionLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (native_stickySectionLayout, JniHandleOwnership.DoNotTransfer);
			__this.AttachToStickSectionLayout (stickySectionLayout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='attachToStickSectionLayout' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout']]"
		[Register ("attachToStickSectionLayout", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V", "GetAttachToStickSectionLayout_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler")]
		public virtual unsafe void AttachToStickSectionLayout (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout stickySectionLayout)
		{
			const string __id = "attachToStickSectionLayout.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stickySectionLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stickySectionLayout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (stickySectionLayout);
			}
		}

		static Delegate cb_ensureScrollBar_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetEnsureScrollBar_Landroid_content_Context_Handler ()
		{
			if (cb_ensureScrollBar_Landroid_content_Context_ == null)
				cb_ensureScrollBar_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_EnsureScrollBar_Landroid_content_Context_);
			return cb_ensureScrollBar_Landroid_content_Context_;
		}

		static IntPtr n_EnsureScrollBar_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EnsureScrollBar (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='ensureScrollBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("ensureScrollBar", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", "GetEnsureScrollBar_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable EnsureScrollBar (global::Android.Content.Context context)
		{
			const string __id = "ensureScrollBar.(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetHandle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ == null)
				cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_V) n_Handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_);
			return cb_handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_;
		}

		static void n_Handle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_manager, int skinIndex, IntPtr native_theme)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			__this.Handle (recyclerView, manager, skinIndex, theme);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[3][@type='int'] and parameter[4][@type='android.content.res.Resources.Theme']]"
		[Register ("handle", "(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V", "GetHandle_Landroidx_recyclerview_widget_RecyclerView_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Handler")]
		public new virtual unsafe void Handle (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager manager, int skinIndex, global::Android.Content.Res.Resources.Theme theme)
		{
			const string __id = "handle.(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
				__args [1] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				__args [2] = new JniArgumentValue (skinIndex);
				__args [3] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (recyclerView);
				global::System.GC.KeepAlive (manager);
				global::System.GC.KeepAlive (theme);
			}
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ == null)
				cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_);
			return cb_onDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_parent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (c, parent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='onDraw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V", "GetOnDraw_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler")]
		public virtual unsafe void OnDraw (global::Android.Graphics.Canvas c, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout parent)
		{
			const string __id = "onDraw.(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (parent);
			}
		}

		static Delegate cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
#pragma warning disable 0169
		static Delegate GetOnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler ()
		{
			if (cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ == null)
				cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_);
			return cb_onDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_;
		}

		static void n_OnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_parent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawOver (c, parent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='onDrawOver' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionLayout']]"
		[Register ("onDrawOver", "(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V", "GetOnDrawOver_Landroid_graphics_Canvas_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionLayout_Handler")]
		public virtual unsafe void OnDrawOver (global::Android.Graphics.Canvas c, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionLayout parent)
		{
			const string __id = "onDrawOver.(Landroid/graphics/Canvas;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (parent);
			}
		}

		static Delegate cb_setCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_Handler ()
		{
			if (cb_setCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_ == null)
				cb_setCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_);
			return cb_setCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_;
		}

		static void n_SetCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar.ICallback)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.recyclerView.QMUIRVDraggableScrollBar.Callback']]"
		[Register ("setCallback", "(Lcom/qmuiteam/qmui/recyclerView/QMUIRVDraggableScrollBar$Callback;)V", "GetSetCallback_Lcom_qmuiteam_qmui_recyclerView_QMUIRVDraggableScrollBar_Callback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar.ICallback @callback)
		{
			const string __id = "setCallback.(Lcom/qmuiteam/qmui/recyclerView/QMUIRVDraggableScrollBar$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setScrollBarDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetScrollBarDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setScrollBarDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setScrollBarDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScrollBarDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setScrollBarDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetScrollBarDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scrollBarDrawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scrollBarDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_scrollBarDrawable, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollBarDrawable (scrollBarDrawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='setScrollBarDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setScrollBarDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetScrollBarDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetScrollBarDrawable (global::Android.Graphics.Drawables.Drawable scrollBarDrawable)
		{
			const string __id = "setScrollBarDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scrollBarDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scrollBarDrawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (scrollBarDrawable);
			}
		}

		static Delegate cb_setScrollBarSkinRes_I;
#pragma warning disable 0169
		static Delegate GetSetScrollBarSkinRes_IHandler ()
		{
			if (cb_setScrollBarSkinRes_I == null)
				cb_setScrollBarSkinRes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetScrollBarSkinRes_I);
			return cb_setScrollBarSkinRes_I;
		}

		static void n_SetScrollBarSkinRes_I (IntPtr jnienv, IntPtr native__this, int scrollBarSkinRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollBarSkinRes (scrollBarSkinRes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='setScrollBarSkinRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScrollBarSkinRes", "(I)V", "GetSetScrollBarSkinRes_IHandler")]
		public virtual unsafe void SetScrollBarSkinRes (int scrollBarSkinRes)
		{
			const string __id = "setScrollBarSkinRes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (scrollBarSkinRes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScrollBarSkinTintColorRes_I;
#pragma warning disable 0169
		static Delegate GetSetScrollBarSkinTintColorRes_IHandler ()
		{
			if (cb_setScrollBarSkinTintColorRes_I == null)
				cb_setScrollBarSkinTintColorRes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetScrollBarSkinTintColorRes_I);
			return cb_setScrollBarSkinTintColorRes_I;
		}

		static void n_SetScrollBarSkinTintColorRes_I (IntPtr jnienv, IntPtr native__this, int colorRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVDraggableScrollBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollBarSkinTintColorRes (colorRes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVDraggableScrollBar']/method[@name='setScrollBarSkinTintColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScrollBarSkinTintColorRes", "(I)V", "GetSetScrollBarSkinTintColorRes_IHandler")]
		public virtual unsafe void SetScrollBarSkinTintColorRes (int colorRes)
		{
			const string __id = "setScrollBarSkinTintColorRes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (colorRes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
