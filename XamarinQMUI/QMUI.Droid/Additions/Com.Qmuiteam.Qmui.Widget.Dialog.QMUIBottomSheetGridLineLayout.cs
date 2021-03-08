using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridLineLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheetGridLineLayout : global::Android.Widget.LinearLayout {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheetGridLineLayout.ItemWidthCalculator']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout$ItemWidthCalculator", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout/IItemWidthCalculatorInvoker")]
		public partial interface IItemWidthCalculator : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheetGridLineLayout.ItemWidthCalculator']/method[@name='calculate' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register ("calculate", "(Landroid/content/Context;IIIII)I", "GetCalculate_Landroid_content_Context_IIIIIHandler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout/IItemWidthCalculatorInvoker, QMUI.Droid")]
			int Calculate (global::Android.Content.Context p0, int p1, int p2, int p3, int p4, int p5);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout$ItemWidthCalculator", DoNotGenerateAcw=true)]
		internal partial class IItemWidthCalculatorInvoker : global::Java.Lang.Object, IItemWidthCalculator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout$ItemWidthCalculator", typeof (IItemWidthCalculatorInvoker));

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

			public static IItemWidthCalculator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IItemWidthCalculator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridLineLayout.ItemWidthCalculator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IItemWidthCalculatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_calculate_Landroid_content_Context_IIIII;
#pragma warning disable 0169
			static Delegate GetCalculate_Landroid_content_Context_IIIIIHandler ()
			{
				if (cb_calculate_Landroid_content_Context_IIIII == null)
					cb_calculate_Landroid_content_Context_IIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIII_I) n_Calculate_Landroid_content_Context_IIIII);
				return cb_calculate_Landroid_content_Context_IIIII;
			}

			static int n_Calculate_Landroid_content_Context_IIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout.IItemWidthCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Calculate (p0, p1, p2, p3, p4, p5);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_calculate_Landroid_content_Context_IIIII;
			public unsafe int Calculate (global::Android.Content.Context p0, int p1, int p2, int p3, int p4, int p5)
			{
				if (id_calculate_Landroid_content_Context_IIIII == IntPtr.Zero)
					id_calculate_Landroid_content_Context_IIIII = JNIEnv.GetMethodID (class_ref, "calculate", "(Landroid/content/Context;IIIII)I");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calculate_Landroid_content_Context_IIIII, __args);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout", typeof (QMUIBottomSheetGridLineLayout));
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

		protected QMUIBottomSheetGridLineLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridLineLayout']/constructor[@name='QMUIBottomSheetGridLineLayout' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetGridLineLayout.ItemWidthCalculator'] and parameter[3][@type='java.util.List&lt;android.util.Pair&lt;android.view.View, android.widget.LinearLayout.LayoutParams&gt;&gt;'] and parameter[4][@type='java.util.List&lt;android.util.Pair&lt;android.view.View, android.widget.LinearLayout.LayoutParams&gt;&gt;']]"
		[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout$ItemWidthCalculator;Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe QMUIBottomSheetGridLineLayout (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout.IItemWidthCalculator widthCalculator, global::System.Collections.Generic.IList<global::Android.Util.Pair> firstLineViews, global::System.Collections.Generic.IList<global::Android.Util.Pair> secondLineViews)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridLineLayout$ItemWidthCalculator;Ljava/util/List;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_firstLineViews = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (firstLineViews);
			IntPtr native_secondLineViews = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (secondLineViews);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
				__args [1] = new JniArgumentValue ((widthCalculator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) widthCalculator).Handle);
				__args [2] = new JniArgumentValue (native_firstLineViews);
				__args [3] = new JniArgumentValue (native_secondLineViews);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_firstLineViews);
				JNIEnv.DeleteLocalRef (native_secondLineViews);
				global::System.GC.KeepAlive (bottomSheet);
				global::System.GC.KeepAlive (widthCalculator);
				global::System.GC.KeepAlive (firstLineViews);
				global::System.GC.KeepAlive (secondLineViews);
			}
		}

		static Delegate cb_createHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCreateHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_Handler ()
		{
			if (cb_createHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_ == null)
				cb_createHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_);
			return cb_createHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_;
		}

		static IntPtr n_CreateHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, IntPtr native_itemViews)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridLineLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bottomSheet = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet> (native_bottomSheet, JniHandleOwnership.DoNotTransfer);
			var itemViews = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (native_itemViews, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateHorScroller (bottomSheet, itemViews));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridLineLayout']/method[@name='createHorScroller' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheet'] and parameter[2][@type='java.util.List&lt;android.util.Pair&lt;android.view.View, android.widget.LinearLayout.LayoutParams&gt;&gt;']]"
		[Register ("createHorScroller", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Ljava/util/List;)Landroid/widget/HorizontalScrollView;", "GetCreateHorScroller_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheet_Ljava_util_List_Handler")]
		protected virtual unsafe global::Android.Widget.HorizontalScrollView CreateHorScroller (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheet bottomSheet, global::System.Collections.Generic.IList<global::Android.Util.Pair> itemViews)
		{
			const string __id = "createHorScroller.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheet;Ljava/util/List;)Landroid/widget/HorizontalScrollView;";
			IntPtr native_itemViews = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (itemViews);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bottomSheet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bottomSheet).Handle);
				__args [1] = new JniArgumentValue (native_itemViews);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.HorizontalScrollView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_itemViews);
				global::System.GC.KeepAlive (bottomSheet);
				global::System.GC.KeepAlive (itemViews);
			}
		}

	}
}
