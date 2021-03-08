using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIPagerAdapter", DoNotGenerateAcw=true)]
	public abstract partial class QMUIPagerAdapter : global::AndroidX.ViewPager.Widget.PagerAdapter {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIPagerAdapter.Action']"
		[Register ("com/qmuiteam/qmui/widget/QMUIPagerAdapter$Action", "", "Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter/IActionInvoker")]
		public partial interface IAction : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIPagerAdapter.Action']/method[@name='call' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("call", "(Ljava/lang/Object;)Z", "GetCall_Ljava_lang_Object_Handler:Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter/IActionInvoker, QMUI.Droid")]
			bool Call (global::Java.Lang.Object item);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIPagerAdapter$Action", DoNotGenerateAcw=true)]
		internal partial class IActionInvoker : global::Java.Lang.Object, IAction {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIPagerAdapter$Action", typeof (IActionInvoker));

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

			public static IAction GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAction> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUIPagerAdapter.Action"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCall_Ljava_lang_Object_Handler ()
			{
				if (cb_call_Ljava_lang_Object_ == null)
					cb_call_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Call_Ljava_lang_Object_);
				return cb_call_Ljava_lang_Object_;
			}

			static bool n_Call_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter.IAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Call (item);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_call_Ljava_lang_Object_;
			public unsafe bool Call (global::Java.Lang.Object item)
			{
				if (id_call_Ljava_lang_Object_ == IntPtr.Zero)
					id_call_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_call_Ljava_lang_Object_, __args);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIPagerAdapter", typeof (QMUIPagerAdapter));
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

		protected QMUIPagerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/constructor[@name='QMUIPagerAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIPagerAdapter ()
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

		static Delegate cb_destroy_Landroid_view_ViewGroup_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDestroy_Landroid_view_ViewGroup_ILjava_lang_Object_Handler ()
		{
			if (cb_destroy_Landroid_view_ViewGroup_ILjava_lang_Object_ == null)
				cb_destroy_Landroid_view_ViewGroup_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_Destroy_Landroid_view_ViewGroup_ILjava_lang_Object_);
			return cb_destroy_Landroid_view_ViewGroup_ILjava_lang_Object_;
		}

		static void n_Destroy_Landroid_view_ViewGroup_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Destroy (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='destroy' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("destroy", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V", "GetDestroy_Landroid_view_ViewGroup_ILjava_lang_Object_Handler")]
		protected abstract void Destroy (global::Android.Views.ViewGroup p0, int p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='destroyItem' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("destroyItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V", "")]
		public override sealed unsafe void DestroyItem (global::Android.Views.ViewGroup container, int position, global::Java.Lang.Object @object)
		{
			const string __id = "destroyItem.(Landroid/view/ViewGroup;ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((container == null) ? IntPtr.Zero : ((global::Java.Lang.Object) container).Handle);
				__args [1] = new JniArgumentValue (position);
				__args [2] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (container);
				global::System.GC.KeepAlive (@object);
			}
		}

		static Delegate cb_each_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_;
#pragma warning disable 0169
		static Delegate GetEach_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_Handler ()
		{
			if (cb_each_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_ == null)
				cb_each_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Each_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_);
			return cb_each_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_;
		}

		static void n_Each_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = (global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter.IAction)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter.IAction> (native_action, JniHandleOwnership.DoNotTransfer);
			__this.Each (action);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='each' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIPagerAdapter.Action']]"
		[Register ("each", "(Lcom/qmuiteam/qmui/widget/QMUIPagerAdapter$Action;)V", "GetEach_Lcom_qmuiteam_qmui_widget_QMUIPagerAdapter_Action_Handler")]
		public virtual unsafe void Each (global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter.IAction action)
		{
			const string __id = "each.(Lcom/qmuiteam/qmui/widget/QMUIPagerAdapter$Action;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (action);
			}
		}

		static Delegate cb_hydrate_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetHydrate_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_hydrate_Landroid_view_ViewGroup_I == null)
				cb_hydrate_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_Hydrate_Landroid_view_ViewGroup_I);
			return cb_hydrate_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_Hydrate_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Hydrate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='hydrate' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("hydrate", "(Landroid/view/ViewGroup;I)Ljava/lang/Object;", "GetHydrate_Landroid_view_ViewGroup_IHandler")]
		protected abstract global::Java.Lang.Object Hydrate (global::Android.Views.ViewGroup p0, int p1);

		static Delegate cb_populate_Landroid_view_ViewGroup_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetPopulate_Landroid_view_ViewGroup_Ljava_lang_Object_IHandler ()
		{
			if (cb_populate_Landroid_view_ViewGroup_Ljava_lang_Object_I == null)
				cb_populate_Landroid_view_ViewGroup_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Populate_Landroid_view_ViewGroup_Ljava_lang_Object_I);
			return cb_populate_Landroid_view_ViewGroup_Ljava_lang_Object_I;
		}

		static void n_Populate_Landroid_view_ViewGroup_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Populate (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='populate' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("populate", "(Landroid/view/ViewGroup;Ljava/lang/Object;I)V", "GetPopulate_Landroid_view_ViewGroup_Ljava_lang_Object_IHandler")]
		protected abstract void Populate (global::Android.Views.ViewGroup p0, global::Java.Lang.Object p1, int p2);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIPagerAdapter", DoNotGenerateAcw=true)]
	internal partial class QMUIPagerAdapterInvoker : QMUIPagerAdapter {

		public QMUIPagerAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIPagerAdapter", typeof (QMUIPagerAdapterInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='destroy' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("destroy", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V", "GetDestroy_Landroid_view_ViewGroup_ILjava_lang_Object_Handler")]
		protected override unsafe void Destroy (global::Android.Views.ViewGroup p0, int p1, global::Java.Lang.Object p2)
		{
			const string __id = "destroy.(Landroid/view/ViewGroup;ILjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='hydrate' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("hydrate", "(Landroid/view/ViewGroup;I)Ljava/lang/Object;", "GetHydrate_Landroid_view_ViewGroup_IHandler")]
		protected override unsafe global::Java.Lang.Object Hydrate (global::Android.Views.ViewGroup p0, int p1)
		{
			const string __id = "hydrate.(Landroid/view/ViewGroup;I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIPagerAdapter']/method[@name='populate' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("populate", "(Landroid/view/ViewGroup;Ljava/lang/Object;I)V", "GetPopulate_Landroid_view_ViewGroup_Ljava_lang_Object_IHandler")]
		protected override unsafe void Populate (global::Android.Views.ViewGroup p0, global::Java.Lang.Object p1, int p2)
		{
			const string __id = "populate.(Landroid/view/ViewGroup;Ljava/lang/Object;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		public override unsafe global::System.Int32 Count {
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Register ("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public override unsafe global::System.Boolean IsViewFromObject (global::Android.Views.View view, global::Java.Lang.Object @object)
		{
			const string __id = "isViewFromObject.(Landroid/view/View;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (@object);
			}
		}

	}

}
