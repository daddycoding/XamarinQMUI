using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheetListAdapter : global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/field[@name='ITEM_TYPE_FOOTER']"
		[Register ("ITEM_TYPE_FOOTER")]
		public const int ItemTypeFooter = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/field[@name='ITEM_TYPE_HEADER']"
		[Register ("ITEM_TYPE_HEADER")]
		public const int ItemTypeHeader = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/field[@name='ITEM_TYPE_NORMAL']"
		[Register ("ITEM_TYPE_NORMAL")]
		public const int ItemTypeNormal = (int) 3;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheetListAdapter.OnItemClickListener']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$OnItemClickListener", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter/IOnItemClickListenerInvoker")]
		public partial interface IOnItemClickListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheetListAdapter.OnItemClickListener']/method[@name='onClick' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListAdapter.VH'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListItemModel']]"
			[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH;ILcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;)V", "GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter/IOnItemClickListenerInvoker, QMUI.Droid")]
			void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH vh, int dataPos, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel model);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$OnItemClickListener", DoNotGenerateAcw=true)]
		internal partial class IOnItemClickListenerInvoker : global::Java.Lang.Object, IOnItemClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$OnItemClickListener", typeof (IOnItemClickListenerInvoker));

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

			public static IOnItemClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnItemClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListAdapter.OnItemClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnItemClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_;
#pragma warning disable 0169
			static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Handler ()
			{
				if (cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ == null)
					cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_);
				return cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_;
			}

			static void n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vh, int dataPos, IntPtr native_model)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var vh = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH> (native_vh, JniHandleOwnership.DoNotTransfer);
				var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (vh, dataPos, model);
			}
#pragma warning restore 0169

			IntPtr id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_;
			public unsafe void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH vh, int dataPos, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel model)
			{
				if (id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ == IntPtr.Zero)
					id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH;ILcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((vh == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vh).Handle);
				__args [1] = new JValue (dataPos);
				__args [2] = new JValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_ILcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListAdapter.OnItemClickListener.onClick
		public partial class ItemClickEventArgs : global::System.EventArgs {

			public ItemClickEventArgs (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH vh, int dataPos, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel model)
			{
				this.vh = vh;
				this.dataPos = dataPos;
				this.model = model;
			}

			global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH vh;
			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH Vh {
				get { return vh; }
			}

			int dataPos;
			public int DataPos {
				get { return dataPos; }
			}

			global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel model;
			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel Model {
				get { return model; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter_OnItemClickListenerImplementor")]
		internal sealed partial class IOnItemClickListenerImplementor : global::Java.Lang.Object, IOnItemClickListener {

			object sender;

			public IOnItemClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter_OnItemClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ItemClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH vh, int dataPos, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel model)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ItemClickEventArgs (vh, dataPos, model));
			}

			internal static bool __IsEmpty (IOnItemClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter.VH']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH", DoNotGenerateAcw=true)]
		public partial class VH : global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH", typeof (VH));
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

			protected VH (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter.VH']/constructor[@name='QMUIBottomSheetListAdapter.VH' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;)V", "")]
			public unsafe VH (global::Android.Views.View itemView)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/View;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((itemView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemView).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (itemView);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter", typeof (QMUIBottomSheetListAdapter));
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

		protected QMUIBottomSheetListAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/constructor[@name='QMUIBottomSheetListAdapter' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(ZZ)V", "")]
		public unsafe QMUIBottomSheetListAdapter (bool needMark, bool gravityCenter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (needMark);
				__args [1] = new JniArgumentValue (gravityCenter);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		public override unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				const string __id = "getItemCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_onBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_I;
#pragma warning disable 0169
		static Delegate GetOnBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_IHandler ()
		{
			if (cb_onBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_I == null)
				cb_onBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_I);
			return cb_onBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_I;
		}

		static void n_OnBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_I (IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (holder, position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListAdapter.VH'] and parameter[2][@type='int']]"
		[Register ("onBindViewHolder", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH;I)V", "GetOnBindViewHolder_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_VH_IHandler")]
		public override unsafe void OnBindViewHolder (global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder holder , int position)
		{
			const string __id = "onBindViewHolder.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				__args [1] = new JniArgumentValue (position);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
				cb_onCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_OnCreateViewHolder_Landroid_view_ViewGroup_I);
			return cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, int viewType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateViewHolder (parent, viewType));
			return __ret;
		}
#pragma warning restore 0169
 

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
		public override unsafe global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder OnCreateViewHolder (global::Android.Views.ViewGroup parent, int viewType)
		{
			const string __id = "onCreateViewHolder.(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$VH;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (viewType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.VH> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parent);
			}
		}

		static Delegate cb_setCheckedIndex_I;
#pragma warning disable 0169
		static Delegate GetSetCheckedIndex_IHandler ()
		{
			if (cb_setCheckedIndex_I == null)
				cb_setCheckedIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCheckedIndex_I);
			return cb_setCheckedIndex_I;
		}

		static void n_SetCheckedIndex_I (IntPtr jnienv, IntPtr native__this, int checkedIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCheckedIndex (checkedIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/method[@name='setCheckedIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCheckedIndex", "(I)V", "GetSetCheckedIndex_IHandler")]
		public virtual unsafe void SetCheckedIndex (int checkedIndex)
		{
			const string __id = "setCheckedIndex.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (checkedIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setData_Landroid_view_View_Landroid_view_View_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetData_Landroid_view_View_Landroid_view_View_Ljava_util_List_Handler ()
		{
			if (cb_setData_Landroid_view_View_Landroid_view_View_Ljava_util_List_ == null)
				cb_setData_Landroid_view_View_Landroid_view_View_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SetData_Landroid_view_View_Landroid_view_View_Ljava_util_List_);
			return cb_setData_Landroid_view_View_Landroid_view_View_Ljava_util_List_;
		}

		static void n_SetData_Landroid_view_View_Landroid_view_View_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_headerView, IntPtr native_footerView, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var headerView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_headerView, JniHandleOwnership.DoNotTransfer);
			var footerView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_footerView, JniHandleOwnership.DoNotTransfer);
			var data = global::Android.Runtime.JavaList<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel>.FromJniHandle (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (headerView, footerView, data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/method[@name='setData' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View'] and parameter[3][@type='java.util.List&lt;com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListItemModel&gt;']]"
		[Register ("setData", "(Landroid/view/View;Landroid/view/View;Ljava/util/List;)V", "GetSetData_Landroid_view_View_Landroid_view_View_Ljava_util_List_Handler")]
		public virtual unsafe void SetData (global::Android.Views.View headerView, global::Android.Views.View footerView, global::System.Collections.Generic.IList<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> data)
		{
			const string __id = "setData.(Landroid/view/View;Landroid/view/View;Ljava/util/List;)V";
			IntPtr native_data = global::Android.Runtime.JavaList<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel>.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((headerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headerView).Handle);
				__args [1] = new JniArgumentValue ((footerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) footerView).Handle);
				__args [2] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
				global::System.GC.KeepAlive (headerView);
				global::System.GC.KeepAlive (footerView);
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_setOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_Handler ()
		{
			if (cb_setOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_ == null)
				cb_setOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_);
			return cb_setOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_;
		}

		static void n_SetOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onItemClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onItemClickListener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListener> (native_onItemClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemClickListener (onItemClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListAdapter']/method[@name='setOnItemClickListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListAdapter.OnItemClickListener']]"
		[Register ("setOnItemClickListener", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$OnItemClickListener;)V", "GetSetOnItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListAdapter_OnItemClickListener_Handler")]
		public virtual unsafe void SetOnItemClickListener (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListener onItemClickListener)
		{
			const string __id = "setOnItemClickListener.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListAdapter$OnItemClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onItemClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onItemClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onItemClickListener);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.ItemClickEventArgs> ItemClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListenerImplementor>(
						ref weak_implementor_SetOnItemClickListener,
						__CreateIOnItemClickListenerImplementor,
						SetOnItemClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListenerImplementor>(
						ref weak_implementor_SetOnItemClickListener,
						global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListenerImplementor.__IsEmpty,
						__v => SetOnItemClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnItemClickListener;

		global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListenerImplementor __CreateIOnItemClickListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListAdapter.IOnItemClickListenerImplementor (this);
		}

       

        #endregion
    }
}
