using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheet : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBaseDialog {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder", DoNotGenerateAcw=true)]
		public partial class BottomGridSheetBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder, global::Android.Views.View.IOnClickListener {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/field[@name='FIRST_LINE']"
			[Register ("FIRST_LINE")]
			public const int FirstLine = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/field[@name='SECOND_LINE']"
			[Register ("SECOND_LINE")]
			public const int SecondLine = (int) 1;
			// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder.DefaultItemViewFactory']"
			[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$DefaultItemViewFactory", DoNotGenerateAcw=true)]
			public partial class DefaultItemViewFactory : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IItemViewFactory {

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$DefaultItemViewFactory", typeof (DefaultItemViewFactory));
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

				protected DefaultItemViewFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder.DefaultItemViewFactory']/constructor[@name='QMUIBottomSheet.BottomGridSheetBuilder.DefaultItemViewFactory' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe DefaultItemViewFactory ()
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

				static Delegate cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_;
#pragma warning disable 0169
				static Delegate GetCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Handler ()
				{
					if (cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ == null)
						cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_);
					return cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_;
				}

				static IntPtr n_Create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_model)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.DefaultItemViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
					var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (bottomSheet, model));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder.DefaultItemViewFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridItemModel']]"
				[Register ("create", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemView;", "GetCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Handler")]
				public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView Create (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model)
				{
					const string __id = "create.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemView;";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [2];
						__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
						__args [1] = new JniArgumentValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						global::System.GC.KeepAlive (bottomSheet);
						global::System.GC.KeepAlive (model);
					}
				}

			}

			// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.BottomGridSheetBuilder.ItemViewFactory']"
			[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$ItemViewFactory", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/BottomGridSheetBuilder/IItemViewFactoryInvoker")]
			public partial interface IItemViewFactory : IJavaObject, IJavaPeerable {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.BottomGridSheetBuilder.ItemViewFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridItemModel']]"
				[Register ("create", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemView;", "GetCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/BottomGridSheetBuilder/IItemViewFactoryInvoker, QMUI.Droid")]
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView Create (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model);

			}

			[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$ItemViewFactory", DoNotGenerateAcw=true)]
			internal partial class IItemViewFactoryInvoker : global::Java.Lang.Object, IItemViewFactory {

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$ItemViewFactory", typeof (IItemViewFactoryInvoker));

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

				public static IItemViewFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IItemViewFactory> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomGridSheetBuilder.ItemViewFactory"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IItemViewFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				static Delegate cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_;
#pragma warning disable 0169
				static Delegate GetCreate_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_Handler ()
				{
					if (cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ == null)
						cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_);
					return cb_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_;
				}

				static IntPtr n_Create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_model)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IItemViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
					var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (bottomSheet, model));
					return __ret;
				}
#pragma warning restore 0169

				IntPtr id_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_;
				public unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView Create (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model)
				{
					if (id_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ == IntPtr.Zero)
						id_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_ = JNIEnv.GetMethodID (class_ref, "create", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemView;");
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
					__args [1] = new JValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
					var __ret = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

			}


			// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.BottomGridSheetBuilder.OnSheetItemClickListener']"
			[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$OnSheetItemClickListener", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/BottomGridSheetBuilder/IOnSheetItemClickListenerInvoker")]
			public partial interface IOnSheetItemClickListener : IJavaObject, IJavaPeerable {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.BottomGridSheetBuilder.OnSheetItemClickListener']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='android.view.View']]"
				[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Landroid/view/View;)V", "GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/BottomGridSheetBuilder/IOnSheetItemClickListenerInvoker, QMUI.Droid")]
				void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1);

			}

			[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$OnSheetItemClickListener", DoNotGenerateAcw=true)]
			internal partial class IOnSheetItemClickListenerInvoker : global::Java.Lang.Object, IOnSheetItemClickListener {

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$OnSheetItemClickListener", typeof (IOnSheetItemClickListenerInvoker));

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

				public static IOnSheetItemClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IOnSheetItemClickListener> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomGridSheetBuilder.OnSheetItemClickListener"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IOnSheetItemClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_;
#pragma warning disable 0169
				static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_Handler ()
				{
					if (cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ == null)
						cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_);
					return cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_;
				}

				static void n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IOnSheetItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_p0, JniHandleOwnership.DoNotTransfer);
					var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
					__this.OnClick (p0, p1);
				}
#pragma warning restore 0169

				IntPtr id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_;
				public unsafe void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1)
				{
					if (id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ == IntPtr.Zero)
						id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Landroid/view/View;)V");
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_, __args);
				}

			}

			// event args for com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomGridSheetBuilder.OnSheetItemClickListener.onClick
			public partial class SheetItemClickEventArgs : global::System.EventArgs {

				public SheetItemClickEventArgs (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1)
				{
					this.p0 = p0;
					this.p1 = p1;
				}

				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0;
				public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet P0 {
					get { return p0; }
				}

				global::Android.Views.View p1;
				public global::Android.Views.View P1 {
					get { return p1; }
				}
			}

			[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListenerImplementor")]
			internal sealed partial class IOnSheetItemClickListenerImplementor : global::Java.Lang.Object, IOnSheetItemClickListener {

				object sender;

				public IOnSheetItemClickListenerImplementor (object sender)
					: base (
						global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListenerImplementor", "()V"),
						JniHandleOwnership.TransferLocalRef)
				{
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					this.sender = sender;
				}

#pragma warning disable 0649
				public EventHandler<SheetItemClickEventArgs> Handler;
#pragma warning restore 0649

				public void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1)
				{
					var __h = Handler;
					if (__h != null)
						__h (sender, new SheetItemClickEventArgs (p0, p1));
				}

				internal static bool __IsEmpty (IOnSheetItemClickListenerImplementor value)
				{
					return value.Handler == null;
				}
			}


			// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.BottomGridSheetBuilder.Style']"
			[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$Style", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/BottomGridSheetBuilder/IStyleInvoker")]
			public partial interface IStyle : global::Java.Lang.Annotation.IAnnotation {

			}

			[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$Style", DoNotGenerateAcw=true)]
			internal partial class IStyleInvoker : global::Java.Lang.Object, IStyle {

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$Style", typeof (IStyleInvoker));

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

				public static IStyle GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IStyle> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomGridSheetBuilder.Style"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IStyleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				static Delegate cb_annotationType;
#pragma warning disable 0169
				static Delegate GetAnnotationTypeHandler ()
				{
					if (cb_annotationType == null)
						cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
					return cb_annotationType;
				}

				static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
				}
#pragma warning restore 0169

				IntPtr id_annotationType;
				public unsafe global::Java.Lang.Class AnnotationType ()
				{
					if (id_annotationType == IntPtr.Zero)
						id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
				}

				static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
				static Delegate GetEquals_Ljava_lang_Object_Handler ()
				{
					if (cb_equals_Ljava_lang_Object_ == null)
						cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
					return cb_equals_Ljava_lang_Object_;
				}

				static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
					bool __ret = __this.Equals (obj);
					return __ret;
				}
#pragma warning restore 0169

				IntPtr id_equals_Ljava_lang_Object_;
				public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
				{
					if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
						id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
					var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
					return __ret;
				}

				static Delegate cb_hashCode;
#pragma warning disable 0169
				static Delegate GetGetHashCodeHandler ()
				{
					if (cb_hashCode == null)
						cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
					return cb_hashCode;
				}

				static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.GetHashCode ();
				}
#pragma warning restore 0169

				IntPtr id_hashCode;
				public unsafe global::System.Int32 GetHashCode ()
				{
					if (id_hashCode == IntPtr.Zero)
						id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
				}

				static Delegate cb_toString;
#pragma warning disable 0169
				static Delegate GetToStringHandler ()
				{
					if (cb_toString == null)
						cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
					return cb_toString;
				}

				static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.NewString (__this.ToString ());
				}
#pragma warning restore 0169

				IntPtr id_toString;
				public unsafe global::System.String ToString ()
				{
					if (id_toString == IntPtr.Zero)
						id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				}

			}


			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder", typeof (BottomGridSheetBuilder));
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

			protected BottomGridSheetBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/constructor[@name='QMUIBottomSheet.BottomGridSheetBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe BottomGridSheetBuilder (global::Android.Content.Context context)
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

			static Delegate cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_I;
#pragma warning disable 0169
			static Delegate GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_IHandler ()
			{
				if (cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_I == null)
					cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_I);
				return cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_I;
			}

			static IntPtr n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_model, int style)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (native_model, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (model, style));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridItemModel'] and parameter[2][@type='int']]"
			[Register ("addItem", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;", "GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridItemModel_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel model, int style)
			{
				const string __id = "addItem.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
					__args [1] = new JniArgumentValue (style);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (model);
				}
			}

			static Delegate cb_addItem_ILjava_lang_CharSequence_I;
#pragma warning disable 0169
			static Delegate GetAddItem_ILjava_lang_CharSequence_IHandler ()
			{
				if (cb_addItem_ILjava_lang_CharSequence_I == null)
					cb_addItem_ILjava_lang_CharSequence_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILI_L) n_AddItem_ILjava_lang_CharSequence_I);
				return cb_addItem_ILjava_lang_CharSequence_I;
			}

			static IntPtr n_AddItem_ILjava_lang_CharSequence_I (IntPtr jnienv, IntPtr native__this, int imageRes, IntPtr native_textAndTag, int style)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var textAndTag = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_textAndTag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (imageRes, textAndTag, style));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='addItem' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='int']]"
			[Register ("addItem", "(ILjava/lang/CharSequence;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;", "GetAddItem_ILjava_lang_CharSequence_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, global::Java.Lang.ICharSequence textAndTag, int style)
			{
				const string __id = "addItem.(ILjava/lang/CharSequence;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;";
				IntPtr native_textAndTag = CharSequence.ToLocalJniHandle (textAndTag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (imageRes);
					__args [1] = new JniArgumentValue (native_textAndTag);
					__args [2] = new JniArgumentValue (style);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_textAndTag);
					global::System.GC.KeepAlive (textAndTag);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, string textAndTag, int style)
			{
				var jls_textAndTag = textAndTag == null ? null : new global::Java.Lang.String (textAndTag);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder __result = AddItem (imageRes, jls_textAndTag, style);
				var __rsval = __result;
				jls_textAndTag?.Dispose ();
				return __rsval;
			}

			static Delegate cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_I;
#pragma warning disable 0169
			static Delegate GetAddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IHandler ()
			{
				if (cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_I == null)
					cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLI_L) n_AddItem_ILjava_lang_CharSequence_Ljava_lang_Object_I);
				return cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_I;
			}

			static IntPtr n_AddItem_ILjava_lang_CharSequence_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, int imageRes, IntPtr native_text, IntPtr native_tag, int style)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				var tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (imageRes, text, tag, style));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='addItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='int']]"
			[Register ("addItem", "(ILjava/lang/CharSequence;Ljava/lang/Object;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;", "GetAddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, global::Java.Lang.ICharSequence text, global::Java.Lang.Object tag, int style)
			{
				const string __id = "addItem.(ILjava/lang/CharSequence;Ljava/lang/Object;I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (imageRes);
					__args [1] = new JniArgumentValue (native_text);
					__args [2] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
					__args [3] = new JniArgumentValue (style);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
					global::System.GC.KeepAlive (tag);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, string text, global::Java.Lang.Object tag, int style)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder __result = AddItem (imageRes, jls_text, tag, style);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

			static Delegate cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_II;
#pragma warning disable 0169
			static Delegate GetAddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IIHandler ()
			{
				if (cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_II == null)
					cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLII_L) n_AddItem_ILjava_lang_CharSequence_Ljava_lang_Object_II);
				return cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_II;
			}

			static IntPtr n_AddItem_ILjava_lang_CharSequence_Ljava_lang_Object_II (IntPtr jnienv, IntPtr native__this, int imageRes, IntPtr native_text, IntPtr native_tag, int style, int subscriptRes)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				var tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (imageRes, text, tag, style, subscriptRes));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='addItem' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("addItem", "(ILjava/lang/CharSequence;Ljava/lang/Object;II)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;", "GetAddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IIHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, global::Java.Lang.ICharSequence text, global::Java.Lang.Object tag, int style, int subscriptRes)
			{
				const string __id = "addItem.(ILjava/lang/CharSequence;Ljava/lang/Object;II)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (imageRes);
					__args [1] = new JniArgumentValue (native_text);
					__args [2] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
					__args [3] = new JniArgumentValue (style);
					__args [4] = new JniArgumentValue (subscriptRes);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
					global::System.GC.KeepAlive (tag);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, string text, global::Java.Lang.Object tag, int style, int subscriptRes)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder __result = AddItem (imageRes, jls_text, tag, style, subscriptRes);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

			static Delegate cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_;
#pragma warning disable 0169
			static Delegate GetAddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_Handler ()
			{
				if (cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_ == null)
					cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLIIL_L) n_AddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_);
				return cb_addItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_;
			}

			static IntPtr n_AddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, int imageRes, IntPtr native_text, IntPtr native_tag, int style, int subscriptRes, IntPtr native_typeface)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				var tag = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_tag, JniHandleOwnership.DoNotTransfer);
				var typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (imageRes, text, tag, style, subscriptRes, typeface));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='addItem' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Typeface']]"
			[Register ("addItem", "(ILjava/lang/CharSequence;Ljava/lang/Object;IILandroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;", "GetAddItem_ILjava_lang_CharSequence_Ljava_lang_Object_IILandroid_graphics_Typeface_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, global::Java.Lang.ICharSequence text, global::Java.Lang.Object tag, int style, int subscriptRes, global::Android.Graphics.Typeface typeface)
			{
				const string __id = "addItem.(ILjava/lang/CharSequence;Ljava/lang/Object;IILandroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (imageRes);
					__args [1] = new JniArgumentValue (native_text);
					__args [2] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
					__args [3] = new JniArgumentValue (style);
					__args [4] = new JniArgumentValue (subscriptRes);
					__args [5] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
					global::System.GC.KeepAlive (tag);
					global::System.GC.KeepAlive (typeface);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder AddItem (int imageRes, string text, global::Java.Lang.Object tag, int style, int subscriptRes, global::Android.Graphics.Typeface typeface)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder __result = AddItem (imageRes, jls_text, tag, style, subscriptRes, typeface);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (v);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
			public virtual unsafe void OnClick (global::Android.Views.View v)
			{
				const string __id = "onClick.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (v);
				}
			}

			static Delegate cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetOnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler ()
			{
				if (cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ == null)
					cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_);
				return cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
			}

			static IntPtr n_OnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_rootLayout, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
				var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContentView (bottomSheet, rootLayout, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='onCreateContentView' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
			[Register ("onCreateContentView", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
			protected override unsafe global::Android.Views.View OnCreateContentView (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout rootLayout, global::Android.Content.Context context)
			{
				const string __id = "onCreateContentView.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
					__args [1] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
					__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (bottomSheet);
					global::System.GC.KeepAlive (rootLayout);
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_setItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_;
#pragma warning disable 0169
			static Delegate GetSetItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_Handler ()
			{
				if (cb_setItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_ == null)
					cb_setItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_);
				return cb_setItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_;
			}

			static void n_SetItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_itemViewFactory)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var itemViewFactory = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IItemViewFactory)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IItemViewFactory> (native_itemViewFactory, JniHandleOwnership.DoNotTransfer);
				__this.SetItemViewFactory (itemViewFactory);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='setItemViewFactory' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomGridSheetBuilder.ItemViewFactory']]"
			[Register ("setItemViewFactory", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$ItemViewFactory;)V", "GetSetItemViewFactory_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_ItemViewFactory_Handler")]
			public virtual unsafe void SetItemViewFactory (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IItemViewFactory itemViewFactory)
			{
				const string __id = "setItemViewFactory.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$ItemViewFactory;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((itemViewFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemViewFactory).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (itemViewFactory);
				}
			}

			static Delegate cb_setItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_;
#pragma warning disable 0169
			static Delegate GetSetItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_Handler ()
			{
				if (cb_setItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_ == null)
					cb_setItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_);
				return cb_setItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_;
			}

			static IntPtr n_SetItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_itemWidthCalculator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var itemWidthCalculator = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout.IItemWidthCalculator)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout.IItemWidthCalculator> (native_itemWidthCalculator, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetItemWidthCalculator (itemWidthCalculator));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='setItemWidthCalculator' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridLineLayout.ItemWidthCalculator']]"
			[Register ("setItemWidthCalculator", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout$ItemWidthCalculator;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;", "GetSetItemWidthCalculator_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetGridLineLayout_ItemWidthCalculator_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder SetItemWidthCalculator (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout.IItemWidthCalculator itemWidthCalculator)
			{
				const string __id = "setItemWidthCalculator.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout$ItemWidthCalculator;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((itemWidthCalculator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemWidthCalculator).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (itemWidthCalculator);
				}
			}

			static Delegate cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_;
#pragma warning disable 0169
			static Delegate GetSetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_Handler ()
			{
				if (cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_ == null)
					cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_);
				return cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_;
			}

			static IntPtr n_SetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSheetItemClickListener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var onSheetItemClickListener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IOnSheetItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IOnSheetItemClickListener> (native_onSheetItemClickListener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnSheetItemClickListener (onSheetItemClickListener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomGridSheetBuilder']/method[@name='setOnSheetItemClickListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomGridSheetBuilder.OnSheetItemClickListener']]"
			[Register ("setOnSheetItemClickListener", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$OnSheetItemClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;", "GetSetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomGridSheetBuilder_OnSheetItemClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder SetOnSheetItemClickListener (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder.IOnSheetItemClickListener onSheetItemClickListener)
			{
				const string __id = "setOnSheetItemClickListener.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder$OnSheetItemClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomGridSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((onSheetItemClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onSheetItemClickListener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomGridSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (onSheetItemClickListener);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder", DoNotGenerateAcw=true)]
		public partial class BottomListSheetBuilder : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBaseBuilder {

			// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.BottomListSheetBuilder.OnSheetItemClickListener']"
			[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder$OnSheetItemClickListener", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/BottomListSheetBuilder/IOnSheetItemClickListenerInvoker")]
			public partial interface IOnSheetItemClickListener : IJavaObject, IJavaPeerable {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.BottomListSheetBuilder.OnSheetItemClickListener']/method[@name='onClick' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
				[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Landroid/view/View;ILjava/lang/String;)V", "GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/BottomListSheetBuilder/IOnSheetItemClickListenerInvoker, QMUI.Droid")]
				void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1, int p2, string p3);

			}

			[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder$OnSheetItemClickListener", DoNotGenerateAcw=true)]
			internal partial class IOnSheetItemClickListenerInvoker : global::Java.Lang.Object, IOnSheetItemClickListener {

				static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder$OnSheetItemClickListener", typeof (IOnSheetItemClickListenerInvoker));

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

				public static IOnSheetItemClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IOnSheetItemClickListener> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomListSheetBuilder.OnSheetItemClickListener"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IOnSheetItemClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_;
#pragma warning disable 0169
				static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_Handler ()
				{
					if (cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_ == null)
						cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_V) n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_);
					return cb_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_;
				}

				static void n_OnClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
				{
					var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder.IOnSheetItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var p0 = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_p0, JniHandleOwnership.DoNotTransfer);
					var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
					var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
					__this.OnClick (p0, p1, p2, p3);
				}
#pragma warning restore 0169

				IntPtr id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_;
				public unsafe void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1, int p2, string p3)
				{
					if (id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_ == IntPtr.Zero)
						id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Landroid/view/View;ILjava/lang/String;)V");
					IntPtr native_p3 = JNIEnv.NewString (p3);
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (native_p3);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Landroid_view_View_ILjava_lang_String_, __args);
					JNIEnv.DeleteLocalRef (native_p3);
				}

			}

			// event args for com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomListSheetBuilder.OnSheetItemClickListener.onClick
			public partial class SheetItemClickEventArgs : global::System.EventArgs {

				public SheetItemClickEventArgs (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1, int p2, string p3)
				{
					this.p0 = p0;
					this.p1 = p1;
					this.p2 = p2;
					this.p3 = p3;
				}

				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0;
				public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet P0 {
					get { return p0; }
				}

				global::Android.Views.View p1;
				public global::Android.Views.View P1 {
					get { return p1; }
				}

				int p2;
				public int P2 {
					get { return p2; }
				}

				string p3;
				public string P3 {
					get { return p3; }
				}
			}

			[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListenerImplementor")]
			internal sealed partial class IOnSheetItemClickListenerImplementor : global::Java.Lang.Object, IOnSheetItemClickListener {

				object sender;

				public IOnSheetItemClickListenerImplementor (object sender)
					: base (
						global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListenerImplementor", "()V"),
						JniHandleOwnership.TransferLocalRef)
				{
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					this.sender = sender;
				}

#pragma warning disable 0649
				public EventHandler<SheetItemClickEventArgs> Handler;
#pragma warning restore 0649

				public void OnClick (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet p0, global::Android.Views.View p1, int p2, string p3)
				{
					var __h = Handler;
					if (__h != null)
						__h (sender, new SheetItemClickEventArgs (p0, p1, p2, p3));
				}

				internal static bool __IsEmpty (IOnSheetItemClickListenerImplementor value)
				{
					return value.Handler == null;
				}
			}


			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder", typeof (BottomListSheetBuilder));
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

			protected BottomListSheetBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/constructor[@name='QMUIBottomSheet.BottomListSheetBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe BottomListSheetBuilder (global::Android.Content.Context context)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/constructor[@name='QMUIBottomSheet.BottomListSheetBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
			public unsafe BottomListSheetBuilder (global::Android.Content.Context context, bool needRightMark)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (needRightMark);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_addContentFooterView_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetAddContentFooterView_Landroid_view_View_Handler ()
			{
				if (cb_addContentFooterView_Landroid_view_View_ == null)
					cb_addContentFooterView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddContentFooterView_Landroid_view_View_);
				return cb_addContentFooterView_Landroid_view_View_;
			}

			static IntPtr n_AddContentFooterView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddContentFooterView (view));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addContentFooterView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("addContentFooterView", "(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddContentFooterView_Landroid_view_View_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddContentFooterView (global::Android.Views.View view)
			{
				const string __id = "addContentFooterView.(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (view);
				}
			}

			static Delegate cb_addContentHeaderView_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetAddContentHeaderView_Landroid_view_View_Handler ()
			{
				if (cb_addContentHeaderView_Landroid_view_View_ == null)
					cb_addContentHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddContentHeaderView_Landroid_view_View_);
				return cb_addContentHeaderView_Landroid_view_View_;
			}

			static IntPtr n_AddContentHeaderView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddContentHeaderView (view));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addContentHeaderView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("addContentHeaderView", "(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddContentHeaderView_Landroid_view_View_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddContentHeaderView (global::Android.Views.View view)
			{
				const string __id = "addContentHeaderView.(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (view);
				}
			}

			static Delegate cb_addHeaderView_Landroid_view_View_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetAddHeaderView_Landroid_view_View_Handler ()
			{
				if (cb_addHeaderView_Landroid_view_View_ == null)
					cb_addHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddHeaderView_Landroid_view_View_);
				return cb_addHeaderView_Landroid_view_View_;
			}

			[Obsolete]
			static IntPtr n_AddHeaderView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeaderView (view));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addHeaderView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Obsolete (@"deprecated")]
			[Register ("addHeaderView", "(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddHeaderView_Landroid_view_View_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddHeaderView (global::Android.Views.View view)
			{
				const string __id = "addHeaderView.(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (view);
				}
			}

			static Delegate cb_addItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_Handler ()
			{
				if (cb_addItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_ == null)
					cb_addItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_);
				return cb_addItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_;
			}

			static IntPtr n_AddItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image, IntPtr native_textAndTag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_image, JniHandleOwnership.DoNotTransfer);
				var textAndTag = JNIEnv.GetString (native_textAndTag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (image, textAndTag));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.String']]"
			[Register ("addItem", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddItem_Landroid_graphics_drawable_Drawable_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (global::Android.Graphics.Drawables.Drawable image, string textAndTag)
			{
				const string __id = "addItem.(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				IntPtr native_textAndTag = JNIEnv.NewString (textAndTag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
					__args [1] = new JniArgumentValue (native_textAndTag);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_textAndTag);
					global::System.GC.KeepAlive (image);
				}
			}

			static Delegate cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_;
#pragma warning disable 0169
			static Delegate GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Handler ()
			{
				if (cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ == null)
					cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_);
				return cb_addItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_;
			}

			static IntPtr n_AddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_itemModel)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var itemModel = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (native_itemModel, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (itemModel));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addItem' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetListItemModel']]"
			[Register ("addItem", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddItem_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetListItemModel_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel itemModel)
			{
				const string __id = "addItem.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((itemModel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemModel).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (itemModel);
				}
			}

			static Delegate cb_addItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZ;
#pragma warning disable 0169
			static Delegate GetAddItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZHandler ()
			{
				if (cb_addItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZ == null)
					cb_addItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLZZ_L) n_AddItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZ);
				return cb_addItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZ;
			}

			static IntPtr n_AddItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, int imageRes, IntPtr native_text, IntPtr native_tag, bool hasRedPoint, bool disabled)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (imageRes, text, tag, hasRedPoint, disabled));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addItem' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
			[Register ("addItem", "(ILjava/lang/CharSequence;Ljava/lang/String;ZZ)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddItem_ILjava_lang_CharSequence_Ljava_lang_String_ZZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (int imageRes, global::Java.Lang.ICharSequence text, string tag, bool hasRedPoint, bool disabled)
			{
				const string __id = "addItem.(ILjava/lang/CharSequence;Ljava/lang/String;ZZ)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				IntPtr native_tag = JNIEnv.NewString (tag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (imageRes);
					__args [1] = new JniArgumentValue (native_text);
					__args [2] = new JniArgumentValue (native_tag);
					__args [3] = new JniArgumentValue (hasRedPoint);
					__args [4] = new JniArgumentValue (disabled);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					JNIEnv.DeleteLocalRef (native_tag);
					global::System.GC.KeepAlive (text);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (int imageRes, string text, string tag, bool hasRedPoint, bool disabled)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder __result = AddItem (imageRes, jls_text, tag, hasRedPoint, disabled);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
			}

			static Delegate cb_addItem_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddItem_ILjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_addItem_ILjava_lang_String_Ljava_lang_String_ == null)
					cb_addItem_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_L) n_AddItem_ILjava_lang_String_Ljava_lang_String_);
				return cb_addItem_ILjava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_AddItem_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int imageRes, IntPtr native_text, IntPtr native_tag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (imageRes, text, tag));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addItem' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("addItem", "(ILjava/lang/String;Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddItem_ILjava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (int imageRes, string text, string tag)
			{
				const string __id = "addItem.(ILjava/lang/String;Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				IntPtr native_text = JNIEnv.NewString (text);
				IntPtr native_tag = JNIEnv.NewString (tag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (imageRes);
					__args [1] = new JniArgumentValue (native_text);
					__args [2] = new JniArgumentValue (native_tag);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					JNIEnv.DeleteLocalRef (native_tag);
				}
			}

			static Delegate cb_addItem_ILjava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
			static Delegate GetAddItem_ILjava_lang_String_Ljava_lang_String_ZHandler ()
			{
				if (cb_addItem_ILjava_lang_String_Ljava_lang_String_Z == null)
					cb_addItem_ILjava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLZ_L) n_AddItem_ILjava_lang_String_Ljava_lang_String_Z);
				return cb_addItem_ILjava_lang_String_Ljava_lang_String_Z;
			}

			static IntPtr n_AddItem_ILjava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int imageRes, IntPtr native_text, IntPtr native_tag, bool hasRedPoint)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (imageRes, text, tag, hasRedPoint));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
			[Register ("addItem", "(ILjava/lang/String;Ljava/lang/String;Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddItem_ILjava_lang_String_Ljava_lang_String_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (int imageRes, string text, string tag, bool hasRedPoint)
			{
				const string __id = "addItem.(ILjava/lang/String;Ljava/lang/String;Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				IntPtr native_text = JNIEnv.NewString (text);
				IntPtr native_tag = JNIEnv.NewString (tag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (imageRes);
					__args [1] = new JniArgumentValue (native_text);
					__args [2] = new JniArgumentValue (native_tag);
					__args [3] = new JniArgumentValue (hasRedPoint);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					JNIEnv.DeleteLocalRef (native_tag);
				}
			}

			static Delegate cb_addItem_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddItem_Ljava_lang_String_Handler ()
			{
				if (cb_addItem_Ljava_lang_String_ == null)
					cb_addItem_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddItem_Ljava_lang_String_);
				return cb_addItem_Ljava_lang_String_;
			}

			static IntPtr n_AddItem_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textAndTag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var textAndTag = JNIEnv.GetString (native_textAndTag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (textAndTag));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addItem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addItem", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddItem_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (string textAndTag)
			{
				const string __id = "addItem.(Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				IntPtr native_textAndTag = JNIEnv.NewString (textAndTag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_textAndTag);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_textAndTag);
				}
			}

			static Delegate cb_addItem_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddItem_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_addItem_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_addItem_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddItem_Ljava_lang_String_Ljava_lang_String_);
				return cb_addItem_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_AddItem_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_tag)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddItem (text, tag));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addItem", "(Ljava/lang/String;Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetAddItem_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder AddItem (string text, string tag)
			{
				const string __id = "addItem.(Ljava/lang/String;Ljava/lang/String;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				IntPtr native_text = JNIEnv.NewString (text);
				IntPtr native_tag = JNIEnv.NewString (tag);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_text);
					__args [1] = new JniArgumentValue (native_tag);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					JNIEnv.DeleteLocalRef (native_tag);
				}
			}

			static Delegate cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetOnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler ()
			{
				if (cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ == null)
					cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_OnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_);
				return cb_onCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_;
			}

			static IntPtr n_OnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_rootLayout, IntPtr native_context)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
				var rootLayout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (native_rootLayout, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateContentView (bottomSheet, rootLayout, context));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='onCreateContentView' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetRootLayout'] and parameter[3][@type='android.content.Context']]"
			[Register ("onCreateContentView", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;", "GetOnCreateContentView_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetRootLayout_Landroid_content_Context_Handler")]
			protected override unsafe global::Android.Views.View OnCreateContentView (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout rootLayout, global::Android.Content.Context context)
			{
				const string __id = "onCreateContentView.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;Landroid/content/Context;)Landroid/view/View;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
					__args [1] = new JniArgumentValue ((rootLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rootLayout).Handle);
					__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (bottomSheet);
					global::System.GC.KeepAlive (rootLayout);
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_setCheckedIndex_I;
#pragma warning disable 0169
			static Delegate GetSetCheckedIndex_IHandler ()
			{
				if (cb_setCheckedIndex_I == null)
					cb_setCheckedIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetCheckedIndex_I);
				return cb_setCheckedIndex_I;
			}

			static IntPtr n_SetCheckedIndex_I (IntPtr jnienv, IntPtr native__this, int checkedIndex)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCheckedIndex (checkedIndex));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='setCheckedIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCheckedIndex", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetSetCheckedIndex_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder SetCheckedIndex (int checkedIndex)
			{
				const string __id = "setCheckedIndex.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (checkedIndex);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setGravityCenter_Z;
#pragma warning disable 0169
			static Delegate GetSetGravityCenter_ZHandler ()
			{
				if (cb_setGravityCenter_Z == null)
					cb_setGravityCenter_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetGravityCenter_Z);
				return cb_setGravityCenter_Z;
			}

			static IntPtr n_SetGravityCenter_Z (IntPtr jnienv, IntPtr native__this, bool gravityCenter)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetGravityCenter (gravityCenter));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='setGravityCenter' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGravityCenter", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetSetGravityCenter_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder SetGravityCenter (bool gravityCenter)
			{
				const string __id = "setGravityCenter.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (gravityCenter);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setNeedRightMark_Z;
#pragma warning disable 0169
			static Delegate GetSetNeedRightMark_ZHandler ()
			{
				if (cb_setNeedRightMark_Z == null)
					cb_setNeedRightMark_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetNeedRightMark_Z);
				return cb_setNeedRightMark_Z;
			}

			static IntPtr n_SetNeedRightMark_Z (IntPtr jnienv, IntPtr native__this, bool needRightMark)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetNeedRightMark (needRightMark));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='setNeedRightMark' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNeedRightMark", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetSetNeedRightMark_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder SetNeedRightMark (bool needRightMark)
			{
				const string __id = "setNeedRightMark.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (needRightMark);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_;
#pragma warning disable 0169
			static Delegate GetSetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_Handler ()
			{
				if (cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_ == null)
					cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_);
				return cb_setOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_;
			}

			static IntPtr n_SetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSheetItemClickListener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var onSheetItemClickListener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder.IOnSheetItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder.IOnSheetItemClickListener> (native_onSheetItemClickListener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnSheetItemClickListener (onSheetItemClickListener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet.BottomListSheetBuilder']/method[@name='setOnSheetItemClickListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.BottomListSheetBuilder.OnSheetItemClickListener']]"
			[Register ("setOnSheetItemClickListener", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder$OnSheetItemClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;", "GetSetOnSheetItemClickListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_BottomListSheetBuilder_OnSheetItemClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder SetOnSheetItemClickListener (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder.IOnSheetItemClickListener onSheetItemClickListener)
			{
				const string __id = "setOnSheetItemClickListener.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder$OnSheetItemClickListener;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$BottomListSheetBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((onSheetItemClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onSheetItemClickListener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.BottomListSheetBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (onSheetItemClickListener);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.OnBottomSheetShowListener']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$OnBottomSheetShowListener", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/IOnBottomSheetShowListenerInvoker")]
		public partial interface IOnBottomSheetShowListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheet.OnBottomSheetShowListener']/method[@name='onShow' and count(parameter)=0]"
			[Register ("onShow", "()V", "GetOnShowHandler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet/IOnBottomSheetShowListenerInvoker, QMUI.Droid")]
			void OnShow ();

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$OnBottomSheetShowListener", DoNotGenerateAcw=true)]
		internal partial class IOnBottomSheetShowListenerInvoker : global::Java.Lang.Object, IOnBottomSheetShowListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$OnBottomSheetShowListener", typeof (IOnBottomSheetShowListenerInvoker));

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

			public static IOnBottomSheetShowListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnBottomSheetShowListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.OnBottomSheetShowListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnBottomSheetShowListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onShow;
#pragma warning disable 0169
			static Delegate GetOnShowHandler ()
			{
				if (cb_onShow == null)
					cb_onShow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnShow);
				return cb_onShow;
			}

			static void n_OnShow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnShow ();
			}
#pragma warning restore 0169

			IntPtr id_onShow;
			public unsafe void OnShow ()
			{
				if (id_onShow == IntPtr.Zero)
					id_onShow = JNIEnv.GetMethodID (class_ref, "onShow", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShow);
			}

		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet_OnBottomSheetShowListenerImplementor")]
		internal sealed partial class IOnBottomSheetShowListenerImplementor : global::Java.Lang.Object, IOnBottomSheetShowListener {

			object sender;

			public IOnBottomSheetShowListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet_OnBottomSheetShowListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnShow ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnBottomSheetShowListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheet", typeof (QMUIBottomSheet));
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

		protected QMUIBottomSheet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/constructor[@name='QMUIBottomSheet' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIBottomSheet (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/constructor[@name='QMUIBottomSheet' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe QMUIBottomSheet (global::Android.Content.Context context, int style)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (style);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getBehavior;
#pragma warning disable 0169
		static Delegate GetGetBehaviorHandler ()
		{
			if (cb_getBehavior == null)
				cb_getBehavior = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBehavior);
			return cb_getBehavior;
		}

		static IntPtr n_GetBehavior (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Behavior);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior Behavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/method[@name='getBehavior' and count(parameter)=0]"
			[Register ("getBehavior", "()Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior;", "GetGetBehaviorHandler")]
			get {
				const string __id = "getBehavior.()Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRootView;
#pragma warning disable 0169
		static Delegate GetGetRootViewHandler ()
		{
			if (cb_getRootView == null)
				cb_getRootView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRootView);
			return cb_getRootView;
		}

		static IntPtr n_GetRootView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RootView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout RootView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/method[@name='getRootView' and count(parameter)=0]"
			[Register ("getRootView", "()Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;", "GetGetRootViewHandler")]
			get {
				const string __id = "getRootView.()Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetRootLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetRootLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetAddContentView_Landroid_view_View_Handler ()
		{
			if (cb_addContentView_Landroid_view_View_ == null)
				cb_addContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddContentView_Landroid_view_View_);
			return cb_addContentView_Landroid_view_View_;
		}

		static void n_AddContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.AddContentView (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/method[@name='addContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("addContentView", "(Landroid/view/View;)V", "GetAddContentView_Landroid_view_View_Handler")]
		public virtual unsafe void AddContentView (global::Android.Views.View view)
		{
			const string __id = "addContentView.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_addContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetAddContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_Handler ()
		{
			if (cb_addContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_ == null)
				cb_addContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_);
			return cb_addContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_;
		}

		static void n_AddContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_layoutParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var layoutParams = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIPriorityLinearLayout.LayoutParams> (native_layoutParams, JniHandleOwnership.DoNotTransfer);
			__this.AddContentView (view, layoutParams);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/method[@name='addContentView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.layout.QMUIPriorityLinearLayout.LayoutParams']]"
		[Register ("addContentView", "(Landroid/view/View;Lcom/qmuiteam/qmui/layout/QMUIPriorityLinearLayout$LayoutParams;)V", "GetAddContentView_Landroid_view_View_Lcom_qmuiteam_qmui_layout_QMUIPriorityLinearLayout_LayoutParams_Handler")]
		public virtual unsafe void AddContentView (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Layout.QMUIPriorityLinearLayout.LayoutParams layoutParams)
		{
			const string __id = "addContentView.(Landroid/view/View;Lcom/qmuiteam/qmui/layout/QMUIPriorityLinearLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (layoutParams);
			}
		}

		static Delegate cb_addContentView_I;
#pragma warning disable 0169
		static Delegate GetAddContentView_IHandler ()
		{
			if (cb_addContentView_I == null)
				cb_addContentView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_AddContentView_I);
			return cb_addContentView_I;
		}

		static void n_AddContentView_I (IntPtr jnienv, IntPtr native__this, int layoutResId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddContentView (layoutResId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/method[@name='addContentView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addContentView", "(I)V", "GetAddContentView_IHandler")]
		public virtual unsafe void AddContentView (int layoutResId)
		{
			const string __id = "addContentView.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (layoutResId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_Handler ()
		{
			if (cb_setOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_ == null)
				cb_setOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_);
			return cb_setOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_;
		}

		static void n_SetOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onBottomSheetShowListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onBottomSheetShowListener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListener> (native_onBottomSheetShowListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBottomSheetShowListener (onBottomSheetShowListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/method[@name='setOnBottomSheetShowListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet.OnBottomSheetShowListener']]"
		[Register ("setOnBottomSheetShowListener", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$OnBottomSheetShowListener;)V", "GetSetOnBottomSheetShowListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_OnBottomSheetShowListener_Handler")]
		public virtual unsafe void SetOnBottomSheetShowListener (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListener onBottomSheetShowListener)
		{
			const string __id = "setOnBottomSheetShowListener.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet$OnBottomSheetShowListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onBottomSheetShowListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onBottomSheetShowListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onBottomSheetShowListener);
			}
		}

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheet']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
		public virtual unsafe void SetRadius (int radius)
		{
			const string __id = "setRadius.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radius);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListener"
		public event EventHandler BottomSheetShow {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListenerImplementor>(
						ref weak_implementor_SetOnBottomSheetShowListener,
						__CreateIOnBottomSheetShowListenerImplementor,
						SetOnBottomSheetShowListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListener, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListenerImplementor>(
						ref weak_implementor_SetOnBottomSheetShowListener,
						global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListenerImplementor.__IsEmpty,
						__v => SetOnBottomSheetShowListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnBottomSheetShowListener;

		global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListenerImplementor __CreateIOnBottomSheetShowListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet.IOnBottomSheetShowListenerImplementor (this);
		}
#endregion
	}
}
