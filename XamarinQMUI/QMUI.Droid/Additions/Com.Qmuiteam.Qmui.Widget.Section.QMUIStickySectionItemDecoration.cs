using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Section {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionItemDecoration']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionItemDecoration", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"VH extends com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewHolder"})]
	public partial class QMUIStickySectionItemDecoration : global::AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']"
		[Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionItemDecoration$Callback", "", "Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ViewHolder extends com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewHolder"})]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='bindViewHolder' and count(parameter)=2 and parameter[1][@type='ViewHolder'] and parameter[2][@type='int']]"
			[Register ("bindViewHolder", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)V", "GetBindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			void BindViewHolder (global::Java.Lang.Object holder, int position);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='createViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
			[Register ("createViewHolder", "(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetCreateViewHolder_Landroid_view_ViewGroup_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			global::Java.Lang.Object CreateViewHolder (global::Android.Views.ViewGroup p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItemViewType", "(I)I", "GetGetItemViewType_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			int GetItemViewType (int position);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='getRelativeStickyItemPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRelativeStickyItemPosition", "(I)I", "GetGetRelativeStickyItemPosition_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			int GetRelativeStickyItemPosition (int pos);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='invalidate' and count(parameter)=0]"
			[Register ("invalidate", "()V", "GetInvalidateHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			void Invalidate ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='isHeaderItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isHeaderItem", "(I)Z", "GetIsHeaderItem_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			bool IsHeaderItem (int pos);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='onHeaderVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onHeaderVisibilityChanged", "(Z)V", "GetOnHeaderVisibilityChanged_ZHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			void OnHeaderVisibilityChanged (bool visible);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionItemDecoration.Callback']/method[@name='registerAdapterDataObserver' and count(parameter)=1 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView.AdapterDataObserver']]"
			[Register ("registerAdapterDataObserver", "(Landroidx/recyclerview/widget/RecyclerView$AdapterDataObserver;)V", "GetRegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration/ICallbackInvoker, QMUI.Droid")]
			void RegisterAdapterDataObserver (global::AndroidX.RecyclerView.Widget.RecyclerView.AdapterDataObserver p0);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionItemDecoration$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUIStickySectionItemDecoration$Callback", typeof (ICallbackInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.section.QMUIStickySectionItemDecoration.Callback"));
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

			static Delegate cb_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
#pragma warning disable 0169
			static Delegate GetBindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_IHandler ()
			{
				if (cb_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I == null)
					cb_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_BindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I);
				return cb_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
			}

			static void n_BindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var holder = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_holder, JniHandleOwnership.DoNotTransfer);
				__this.BindViewHolder (holder, position);
			}
#pragma warning restore 0169

			IntPtr id_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
			public unsafe void BindViewHolder (global::Java.Lang.Object holder, int position)
			{
				if (id_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I == IntPtr.Zero)
					id_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "bindViewHolder", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)V");
				IntPtr native_holder = JNIEnv.ToLocalJniHandle (holder);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_holder);
				__args [1] = new JValue (position);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindViewHolder_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I, __args);
				JNIEnv.DeleteLocalRef (native_holder);
			}

			static Delegate cb_createViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
			static Delegate GetCreateViewHolder_Landroid_view_ViewGroup_IHandler ()
			{
				if (cb_createViewHolder_Landroid_view_ViewGroup_I == null)
					cb_createViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_CreateViewHolder_Landroid_view_ViewGroup_I);
				return cb_createViewHolder_Landroid_view_ViewGroup_I;
			}

			static IntPtr n_CreateViewHolder_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateViewHolder (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_createViewHolder_Landroid_view_ViewGroup_I;
			public unsafe global::Java.Lang.Object CreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
			{
				if (id_createViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
					id_createViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "createViewHolder", "(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_getItemViewType_I;
#pragma warning disable 0169
			static Delegate GetGetItemViewType_IHandler ()
			{
				if (cb_getItemViewType_I == null)
					cb_getItemViewType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetItemViewType_I);
				return cb_getItemViewType_I;
			}

			static int n_GetItemViewType_I (IntPtr jnienv, IntPtr native__this, int position)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetItemViewType (position);
			}
#pragma warning restore 0169

			IntPtr id_getItemViewType_I;
			public unsafe int GetItemViewType (int position)
			{
				if (id_getItemViewType_I == IntPtr.Zero)
					id_getItemViewType_I = JNIEnv.GetMethodID (class_ref, "getItemViewType", "(I)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (position);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemViewType_I, __args);
			}

			static Delegate cb_getRelativeStickyItemPosition_I;
#pragma warning disable 0169
			static Delegate GetGetRelativeStickyItemPosition_IHandler ()
			{
				if (cb_getRelativeStickyItemPosition_I == null)
					cb_getRelativeStickyItemPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRelativeStickyItemPosition_I);
				return cb_getRelativeStickyItemPosition_I;
			}

			static int n_GetRelativeStickyItemPosition_I (IntPtr jnienv, IntPtr native__this, int pos)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRelativeStickyItemPosition (pos);
			}
#pragma warning restore 0169

			IntPtr id_getRelativeStickyItemPosition_I;
			public unsafe int GetRelativeStickyItemPosition (int pos)
			{
				if (id_getRelativeStickyItemPosition_I == IntPtr.Zero)
					id_getRelativeStickyItemPosition_I = JNIEnv.GetMethodID (class_ref, "getRelativeStickyItemPosition", "(I)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pos);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRelativeStickyItemPosition_I, __args);
			}

			static Delegate cb_invalidate;
#pragma warning disable 0169
			static Delegate GetInvalidateHandler ()
			{
				if (cb_invalidate == null)
					cb_invalidate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Invalidate);
				return cb_invalidate;
			}

			static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Invalidate ();
			}
#pragma warning restore 0169

			IntPtr id_invalidate;
			public unsafe void Invalidate ()
			{
				if (id_invalidate == IntPtr.Zero)
					id_invalidate = JNIEnv.GetMethodID (class_ref, "invalidate", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invalidate);
			}

			static Delegate cb_isHeaderItem_I;
#pragma warning disable 0169
			static Delegate GetIsHeaderItem_IHandler ()
			{
				if (cb_isHeaderItem_I == null)
					cb_isHeaderItem_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsHeaderItem_I);
				return cb_isHeaderItem_I;
			}

			static bool n_IsHeaderItem_I (IntPtr jnienv, IntPtr native__this, int pos)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsHeaderItem (pos);
			}
#pragma warning restore 0169

			IntPtr id_isHeaderItem_I;
			public unsafe bool IsHeaderItem (int pos)
			{
				if (id_isHeaderItem_I == IntPtr.Zero)
					id_isHeaderItem_I = JNIEnv.GetMethodID (class_ref, "isHeaderItem", "(I)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pos);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHeaderItem_I, __args);
			}

			static Delegate cb_onHeaderVisibilityChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnHeaderVisibilityChanged_ZHandler ()
			{
				if (cb_onHeaderVisibilityChanged_Z == null)
					cb_onHeaderVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnHeaderVisibilityChanged_Z);
				return cb_onHeaderVisibilityChanged_Z;
			}

			static void n_OnHeaderVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool visible)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnHeaderVisibilityChanged (visible);
			}
#pragma warning restore 0169

			IntPtr id_onHeaderVisibilityChanged_Z;
			public unsafe void OnHeaderVisibilityChanged (bool visible)
			{
				if (id_onHeaderVisibilityChanged_Z == IntPtr.Zero)
					id_onHeaderVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onHeaderVisibilityChanged", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (visible);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHeaderVisibilityChanged_Z, __args);
			}

			static Delegate cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_;
#pragma warning disable 0169
			static Delegate GetRegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_Handler ()
			{
				if (cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ == null)
					cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_);
				return cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_;
			}

			static void n_RegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.AdapterDataObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RegisterAdapterDataObserver (p0);
			}
#pragma warning restore 0169

			IntPtr id_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_;
			public unsafe void RegisterAdapterDataObserver (global::AndroidX.RecyclerView.Widget.RecyclerView.AdapterDataObserver p0)
			{
				if (id_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ == IntPtr.Zero)
					id_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ = JNIEnv.GetMethodID (class_ref, "registerAdapterDataObserver", "(Landroidx/recyclerview/widget/RecyclerView$AdapterDataObserver;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUIStickySectionItemDecoration", typeof (QMUIStickySectionItemDecoration));
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

		protected QMUIStickySectionItemDecoration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionItemDecoration']/constructor[@name='QMUIStickySectionItemDecoration' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionItemDecoration.Callback&lt;VH&gt;']]"
		[Register (".ctor", "(Landroid/view/ViewGroup;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionItemDecoration$Callback;)V", "")]
		public unsafe QMUIStickySectionItemDecoration (global::Android.Views.ViewGroup sectionContainer, global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration.ICallback @callback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/ViewGroup;Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionItemDecoration$Callback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sectionContainer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sectionContainer).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sectionContainer);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_getStickyHeaderViewPosition;
#pragma warning disable 0169
		static Delegate GetGetStickyHeaderViewPositionHandler ()
		{
			if (cb_getStickyHeaderViewPosition == null)
				cb_getStickyHeaderViewPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStickyHeaderViewPosition);
			return cb_getStickyHeaderViewPosition;
		}

		static int n_GetStickyHeaderViewPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StickyHeaderViewPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int StickyHeaderViewPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionItemDecoration']/method[@name='getStickyHeaderViewPosition' and count(parameter)=0]"
			[Register ("getStickyHeaderViewPosition", "()I", "GetGetStickyHeaderViewPositionHandler")]
			get {
				const string __id = "getStickyHeaderViewPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTargetTop;
#pragma warning disable 0169
		static Delegate GetGetTargetTopHandler ()
		{
			if (cb_getTargetTop == null)
				cb_getTargetTop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTargetTop);
			return cb_getTargetTop;
		}

		static int n_GetTargetTop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionItemDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetTop;
		}
#pragma warning restore 0169

		public virtual unsafe int TargetTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionItemDecoration']/method[@name='getTargetTop' and count(parameter)=0]"
			[Register ("getTargetTop", "()I", "GetGetTargetTopHandler")]
			get {
				const string __id = "getTargetTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
