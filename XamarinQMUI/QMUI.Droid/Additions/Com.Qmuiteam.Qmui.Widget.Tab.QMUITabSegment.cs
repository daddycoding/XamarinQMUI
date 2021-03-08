using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment", DoNotGenerateAcw=true)]
	public partial class QMUITabSegment : global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUITabSegment.OnTabClickListener']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$OnTabClickListener", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment/IOnTabClickListenerInvoker")]
		public partial interface IOnTabClickListener : global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$OnTabClickListener", DoNotGenerateAcw=true)]
		internal partial class IOnTabClickListenerInvoker : global::Java.Lang.Object, IOnTabClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$OnTabClickListener", typeof (IOnTabClickListenerInvoker));

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

			public static IOnTabClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTabClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUITabSegment.OnTabClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTabClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I;
#pragma warning disable 0169
			static Delegate GetOnTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_IHandler ()
			{
				if (cb_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I == null)
					cb_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_OnTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I);
				return cb_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I;
			}

			static bool n_OnTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_tabView, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.IOnTabClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tabView = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_tabView, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTabClick (tabView, index);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I;
			public unsafe bool OnTabClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView tabView, int index)
			{
				if (id_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I == IntPtr.Zero)
					id_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I = JNIEnv.GetMethodID (class_ref, "onTabClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((tabView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tabView).Handle);
				__args [1] = new JValue (index);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I, __args);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUITabSegment.OnTabSelectedListener']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$OnTabSelectedListener", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment/IOnTabSelectedListenerInvoker")]
		public partial interface IOnTabSelectedListener : global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$OnTabSelectedListener", DoNotGenerateAcw=true)]
		internal partial class IOnTabSelectedListenerInvoker : global::Java.Lang.Object, IOnTabSelectedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$OnTabSelectedListener", typeof (IOnTabSelectedListenerInvoker));

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

			public static IOnTabSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTabSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUITabSegment.OnTabSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTabSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDoubleTap_I;
#pragma warning disable 0169
			static Delegate GetOnDoubleTap_IHandler ()
			{
				if (cb_onDoubleTap_I == null)
					cb_onDoubleTap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnDoubleTap_I);
				return cb_onDoubleTap_I;
			}

			static void n_OnDoubleTap_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDoubleTap (index);
			}
#pragma warning restore 0169

			IntPtr id_onDoubleTap_I;
			public unsafe void OnDoubleTap (int index)
			{
				if (id_onDoubleTap_I == IntPtr.Zero)
					id_onDoubleTap_I = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDoubleTap_I, __args);
			}

			static Delegate cb_onTabReselected_I;
#pragma warning disable 0169
			static Delegate GetOnTabReselected_IHandler ()
			{
				if (cb_onTabReselected_I == null)
					cb_onTabReselected_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTabReselected_I);
				return cb_onTabReselected_I;
			}

			static void n_OnTabReselected_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTabReselected (index);
			}
#pragma warning restore 0169

			IntPtr id_onTabReselected_I;
			public unsafe void OnTabReselected (int index)
			{
				if (id_onTabReselected_I == IntPtr.Zero)
					id_onTabReselected_I = JNIEnv.GetMethodID (class_ref, "onTabReselected", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabReselected_I, __args);
			}

			static Delegate cb_onTabSelected_I;
#pragma warning disable 0169
			static Delegate GetOnTabSelected_IHandler ()
			{
				if (cb_onTabSelected_I == null)
					cb_onTabSelected_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTabSelected_I);
				return cb_onTabSelected_I;
			}

			static void n_OnTabSelected_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTabSelected (index);
			}
#pragma warning restore 0169

			IntPtr id_onTabSelected_I;
			public unsafe void OnTabSelected (int index)
			{
				if (id_onTabSelected_I == IntPtr.Zero)
					id_onTabSelected_I = JNIEnv.GetMethodID (class_ref, "onTabSelected", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabSelected_I, __args);
			}

			static Delegate cb_onTabUnselected_I;
#pragma warning disable 0169
			static Delegate GetOnTabUnselected_IHandler ()
			{
				if (cb_onTabUnselected_I == null)
					cb_onTabUnselected_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTabUnselected_I);
				return cb_onTabUnselected_I;
			}

			static void n_OnTabUnselected_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTabUnselected (index);
			}
#pragma warning restore 0169

			IntPtr id_onTabUnselected_I;
			public unsafe void OnTabUnselected (int index)
			{
				if (id_onTabUnselected_I == IntPtr.Zero)
					id_onTabUnselected_I = JNIEnv.GetMethodID (class_ref, "onTabUnselected", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabUnselected_I, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment.TabLayoutOnPageChangeListener']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$TabLayoutOnPageChangeListener", DoNotGenerateAcw=true)]
		public partial class TabLayoutOnPageChangeListener : global::Java.Lang.Object, global::AndroidX.ViewPager.Widget.ViewPager.IOnPageChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabSegment$TabLayoutOnPageChangeListener", typeof (TabLayoutOnPageChangeListener));
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

			protected TabLayoutOnPageChangeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment.TabLayoutOnPageChangeListener']/constructor[@name='QMUITabSegment.TabLayoutOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabSegment']]"
			[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabSegment;)V", "")]
			public unsafe TabLayoutOnPageChangeListener (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment tabSegment)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/qmuiteam/qmui/widget/tab/QMUITabSegment;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((tabSegment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tabSegment).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (tabSegment);
				}
			}

			static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
			static Delegate GetOnPageScrollStateChanged_IHandler ()
			{
				if (cb_onPageScrollStateChanged_I == null)
					cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnPageScrollStateChanged_I);
				return cb_onPageScrollStateChanged_I;
			}

			static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int state)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.TabLayoutOnPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrollStateChanged (state);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment.TabLayoutOnPageChangeListener']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler")]
			public virtual unsafe void OnPageScrollStateChanged (int state)
			{
				const string __id = "onPageScrollStateChanged.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (state);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
			static Delegate GetOnPageScrolled_IFIHandler ()
			{
				if (cb_onPageScrolled_IFI == null)
					cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIFI_V) n_OnPageScrolled_IFI);
				return cb_onPageScrolled_IFI;
			}

			static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int position, float positionOffset, int positionOffsetPixels)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.TabLayoutOnPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrolled (position, positionOffset, positionOffsetPixels);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment.TabLayoutOnPageChangeListener']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
			[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
			public virtual unsafe void OnPageScrolled (int position, float positionOffset, int positionOffsetPixels)
			{
				const string __id = "onPageScrolled.(IFI)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (position);
					__args [1] = new JniArgumentValue (positionOffset);
					__args [2] = new JniArgumentValue (positionOffsetPixels);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
			static Delegate GetOnPageSelected_IHandler ()
			{
				if (cb_onPageSelected_I == null)
					cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnPageSelected_I);
				return cb_onPageSelected_I;
			}

			static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int position)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment.TabLayoutOnPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageSelected (position);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment.TabLayoutOnPageChangeListener']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageSelected", "(I)V", "GetOnPageSelected_IHandler")]
			public virtual unsafe void OnPageSelected (int position)
			{
				const string __id = "onPageSelected.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (position);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabSegment", typeof (QMUITabSegment));
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

		protected QMUITabSegment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment']/constructor[@name='QMUITabSegment' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUITabSegment (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment']/constructor[@name='QMUITabSegment' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUITabSegment (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment']/constructor[@name='QMUITabSegment' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUITabSegment (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_;
#pragma warning disable 0169
		static Delegate GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Handler ()
		{
			if (cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ == null)
				cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_);
			return cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_;
		}

		static void n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var viewPager = global::Java.Lang.Object.GetObject<global::AndroidX.ViewPager.Widget.ViewPager> (native_viewPager, JniHandleOwnership.DoNotTransfer);
			__this.SetupWithViewPager (viewPager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment']/method[@name='setupWithViewPager' and count(parameter)=1 and parameter[1][@type='androidx.viewpager.widget.ViewPager']]"
		[Register ("setupWithViewPager", "(Landroidx/viewpager/widget/ViewPager;)V", "GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Handler")]
		public virtual unsafe void SetupWithViewPager (global::AndroidX.ViewPager.Widget.ViewPager viewPager)
		{
			const string __id = "setupWithViewPager.(Landroidx/viewpager/widget/ViewPager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((viewPager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPager).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPager);
			}
		}

		static Delegate cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z;
#pragma warning disable 0169
		static Delegate GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZHandler ()
		{
			if (cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z == null)
				cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z);
			return cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z;
		}

		static void n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager, bool useAdapterTitle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var viewPager = global::Java.Lang.Object.GetObject<global::AndroidX.ViewPager.Widget.ViewPager> (native_viewPager, JniHandleOwnership.DoNotTransfer);
			__this.SetupWithViewPager (viewPager, useAdapterTitle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment']/method[@name='setupWithViewPager' and count(parameter)=2 and parameter[1][@type='androidx.viewpager.widget.ViewPager'] and parameter[2][@type='boolean']]"
		[Register ("setupWithViewPager", "(Landroidx/viewpager/widget/ViewPager;Z)V", "GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZHandler")]
		public virtual unsafe void SetupWithViewPager (global::AndroidX.ViewPager.Widget.ViewPager viewPager, bool useAdapterTitle)
		{
			const string __id = "setupWithViewPager.(Landroidx/viewpager/widget/ViewPager;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((viewPager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPager).Handle);
				__args [1] = new JniArgumentValue (useAdapterTitle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPager);
			}
		}

		static Delegate cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZ;
#pragma warning disable 0169
		static Delegate GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZHandler ()
		{
			if (cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZ == null)
				cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_V) n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZ);
			return cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZ;
		}

		static void n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager, bool useAdapterTitle, bool autoRefresh)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var viewPager = global::Java.Lang.Object.GetObject<global::AndroidX.ViewPager.Widget.ViewPager> (native_viewPager, JniHandleOwnership.DoNotTransfer);
			__this.SetupWithViewPager (viewPager, useAdapterTitle, autoRefresh);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment']/method[@name='setupWithViewPager' and count(parameter)=3 and parameter[1][@type='androidx.viewpager.widget.ViewPager'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("setupWithViewPager", "(Landroidx/viewpager/widget/ViewPager;ZZ)V", "GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZZHandler")]
		public virtual unsafe void SetupWithViewPager (global::AndroidX.ViewPager.Widget.ViewPager viewPager, bool useAdapterTitle, bool autoRefresh)
		{
			const string __id = "setupWithViewPager.(Landroidx/viewpager/widget/ViewPager;ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((viewPager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPager).Handle);
				__args [1] = new JniArgumentValue (useAdapterTitle);
				__args [2] = new JniArgumentValue (autoRefresh);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPager);
			}
		}

	}
}
