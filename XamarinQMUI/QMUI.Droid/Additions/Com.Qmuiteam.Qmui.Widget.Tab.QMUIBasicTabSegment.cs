using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment", DoNotGenerateAcw=true)]
	public partial class QMUIBasicTabSegment : global::Android.Widget.HorizontalScrollView, global::Com.Qmuiteam.Qmui.Layout.IQMUILayout, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerView, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/field[@name='MODE_FIXED']"
		[Register ("MODE_FIXED")]
		public const int ModeFixed = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/field[@name='MODE_SCROLLABLE']"
		[Register ("MODE_SCROLLABLE")]
		public const int ModeScrollable = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/field[@name='NO_POSITION']"
		[Register ("NO_POSITION")]
		public const int NoPosition = (int) -1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/field[@name='mCurrentSelectedIndex']"
		[Register ("mCurrentSelectedIndex")]
		protected int MCurrentSelectedIndex {
			get {
				const string __id = "mCurrentSelectedIndex.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mCurrentSelectedIndex.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/field[@name='mPendingSelectedIndex']"
		[Register ("mPendingSelectedIndex")]
		protected int MPendingSelectedIndex {
			get {
				const string __id = "mPendingSelectedIndex.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mPendingSelectedIndex.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/field[@name='mSelectAnimator']"
		[Register ("mSelectAnimator")]
		protected global::Android.Animation.Animator MSelectAnimator {
			get {
				const string __id = "mSelectAnimator.Landroid/animation/Animator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSelectAnimator.Landroid/animation/Animator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/field[@name='mTabBuilder']"
		[Register ("mTabBuilder")]
		protected global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder MTabBuilder {
			get {
				const string __id = "mTabBuilder.Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTabBuilder.Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.qmuiteam.qmui.layout.IQMUILayout

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_BOTTOM']"
			[Register ("HIDE_RADIUS_SIDE_BOTTOM")]
			public const int HideRadiusSideBottom = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_LEFT']"
			[Register ("HIDE_RADIUS_SIDE_LEFT")]
			public const int HideRadiusSideLeft = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_NONE']"
			[Register ("HIDE_RADIUS_SIDE_NONE")]
			public const int HideRadiusSideNone = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_RIGHT']"
			[Register ("HIDE_RADIUS_SIDE_RIGHT")]
			public const int HideRadiusSideRight = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/interface[@name='IQMUILayout']/field[@name='HIDE_RADIUS_SIDE_TOP']"
			[Register ("HIDE_RADIUS_SIDE_TOP")]
			public const int HideRadiusSideTop = (int) 1;
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.Mode']"
		[Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$Mode", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IModeInvoker")]
		public partial interface IMode : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$Mode", DoNotGenerateAcw=true)]
		internal partial class IModeInvoker : global::Java.Lang.Object, IMode {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$Mode", typeof (IModeInvoker));

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

			public static IMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.Mode"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.OnTabClickListener']"
		[Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabClickListener", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IOnTabClickListenerInvoker")]
		public partial interface IOnTabClickListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.OnTabClickListener']/method[@name='onTabClick' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView'] and parameter[2][@type='int']]"
			[Register ("onTabClick", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)Z", "GetOnTabClick_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_IHandler:Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IOnTabClickListenerInvoker, QMUI.Droid")]
			bool OnTabClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView tabView, int index);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabClickListener", DoNotGenerateAcw=true)]
		internal partial class IOnTabClickListenerInvoker : global::Java.Lang.Object, IOnTabClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabClickListener", typeof (IOnTabClickListenerInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabClickListener"));
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// event args for com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabClickListener.onTabClick
		public partial class TabClickEventArgs : global::System.EventArgs {

			public TabClickEventArgs (bool handled, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView tabView, int index)
			{
				this.handled = handled;
				this.tabView = tabView;
				this.index = index;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView tabView;
			public global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView TabView {
				get { return tabView; }
			}

			int index;
			public int Index {
				get { return index; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment_OnTabClickListenerImplementor")]
		internal sealed partial class IOnTabClickListenerImplementor : global::Java.Lang.Object, IOnTabClickListener {

			object sender;

			public IOnTabClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment_OnTabClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TabClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnTabClick (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView tabView, int index)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new TabClickEventArgs (true, tabView, index);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnTabClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.OnTabSelectedListener']"
		[Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabSelectedListener", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IOnTabSelectedListenerInvoker")]
		public partial interface IOnTabSelectedListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.OnTabSelectedListener']/method[@name='onDoubleTap' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onDoubleTap", "(I)V", "GetOnDoubleTap_IHandler:Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IOnTabSelectedListenerInvoker, QMUI.Droid")]
			void OnDoubleTap (int index);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.OnTabSelectedListener']/method[@name='onTabReselected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTabReselected", "(I)V", "GetOnTabReselected_IHandler:Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IOnTabSelectedListenerInvoker, QMUI.Droid")]
			void OnTabReselected (int index);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.OnTabSelectedListener']/method[@name='onTabSelected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTabSelected", "(I)V", "GetOnTabSelected_IHandler:Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IOnTabSelectedListenerInvoker, QMUI.Droid")]
			void OnTabSelected (int index);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.OnTabSelectedListener']/method[@name='onTabUnselected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTabUnselected", "(I)V", "GetOnTabUnselected_IHandler:Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/IOnTabSelectedListenerInvoker, QMUI.Droid")]
			void OnTabUnselected (int index);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabSelectedListener", DoNotGenerateAcw=true)]
		internal partial class IOnTabSelectedListenerInvoker : global::Java.Lang.Object, IOnTabSelectedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabSelectedListener", typeof (IOnTabSelectedListenerInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabSelectedListener"));
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// event args for com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabSelectedListener.onDoubleTap
		public partial class DoubleTapEventArgs : global::System.EventArgs {

			public DoubleTapEventArgs (int index)
			{
				this.index = index;
			}

			int index;
			public int Index {
				get { return index; }
			}
		}

		// event args for com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabSelectedListener.onTabReselected
		public partial class TabReselectedEventArgs : global::System.EventArgs {

			public TabReselectedEventArgs (int index)
			{
				this.index = index;
			}

			int index;
			public int Index {
				get { return index; }
			}
		}

		// event args for com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabSelectedListener.onTabSelected
		public partial class TabSelectedEventArgs : global::System.EventArgs {

			public TabSelectedEventArgs (int index)
			{
				this.index = index;
			}

			int index;
			public int Index {
				get { return index; }
			}
		}

		// event args for com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabSelectedListener.onTabUnselected
		public partial class TabUnselectedEventArgs : global::System.EventArgs {

			public TabUnselectedEventArgs (int index)
			{
				this.index = index;
			}

			int index;
			public int Index {
				get { return index; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment_OnTabSelectedListenerImplementor")]
		internal sealed partial class IOnTabSelectedListenerImplementor : global::Java.Lang.Object, IOnTabSelectedListener {

			object sender;

			public IOnTabSelectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment_OnTabSelectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DoubleTapEventArgs> OnDoubleTapHandler;
#pragma warning restore 0649

			public void OnDoubleTap (int index)
			{
				var __h = OnDoubleTapHandler;
				if (__h != null)
					__h (sender, new DoubleTapEventArgs (index));
			}
#pragma warning disable 0649
			public EventHandler<TabReselectedEventArgs> OnTabReselectedHandler;
#pragma warning restore 0649

			public void OnTabReselected (int index)
			{
				var __h = OnTabReselectedHandler;
				if (__h != null)
					__h (sender, new TabReselectedEventArgs (index));
			}
#pragma warning disable 0649
			public EventHandler<TabSelectedEventArgs> OnTabSelectedHandler;
#pragma warning restore 0649

			public void OnTabSelected (int index)
			{
				var __h = OnTabSelectedHandler;
				if (__h != null)
					__h (sender, new TabSelectedEventArgs (index));
			}
#pragma warning disable 0649
			public EventHandler<TabUnselectedEventArgs> OnTabUnselectedHandler;
#pragma warning restore 0649

			public void OnTabUnselected (int index)
			{
				var __h = OnTabUnselectedHandler;
				if (__h != null)
					__h (sender, new TabUnselectedEventArgs (index));
			}

			internal static bool __IsEmpty (IOnTabSelectedListenerImplementor value)
			{
				return value.OnDoubleTapHandler == null && value.OnTabReselectedHandler == null && value.OnTabSelectedHandler == null && value.OnTabUnselectedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.TabBuilderUpdater']"
		[Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$TabBuilderUpdater", "", "Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/ITabBuilderUpdaterInvoker")]
		public partial interface ITabBuilderUpdater : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/interface[@name='QMUIBasicTabSegment.TabBuilderUpdater']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabBuilder']]"
			[Register ("update", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;)V", "GetUpdate_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_Handler:Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment/ITabBuilderUpdaterInvoker, QMUI.Droid")]
			void Update (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder builder);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$TabBuilderUpdater", DoNotGenerateAcw=true)]
		internal partial class ITabBuilderUpdaterInvoker : global::Java.Lang.Object, ITabBuilderUpdater {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$TabBuilderUpdater", typeof (ITabBuilderUpdaterInvoker));

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

			public static ITabBuilderUpdater GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITabBuilderUpdater> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.TabBuilderUpdater"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITabBuilderUpdaterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_;
#pragma warning disable 0169
			static Delegate GetUpdate_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_Handler ()
			{
				if (cb_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_ == null)
					cb_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_);
				return cb_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_;
			}

			static void n_Update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.ITabBuilderUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var builder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
				__this.Update (builder);
			}
#pragma warning restore 0169

			IntPtr id_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_;
			public unsafe void Update (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder builder)
			{
				if (id_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_ == IntPtr.Zero)
					id_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_qmuiteam_qmui_widget_tab_QMUITabBuilder_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment", typeof (QMUIBasicTabSegment));
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

		protected QMUIBasicTabSegment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/constructor[@name='QMUIBasicTabSegment' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIBasicTabSegment (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/constructor[@name='QMUIBasicTabSegment' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIBasicTabSegment (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/constructor[@name='QMUIBasicTabSegment' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIBasicTabSegment (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getDefaultSkinAttrs;
#pragma warning disable 0169
		static Delegate GetGetDefaultSkinAttrsHandler ()
		{
			if (cb_getDefaultSkinAttrs == null)
				cb_getDefaultSkinAttrs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultSkinAttrs);
			return cb_getDefaultSkinAttrs;
		}

		static IntPtr n_GetDefaultSkinAttrs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
			[Register ("getDefaultSkinAttrs", "()Landroidx/collection/SimpleArrayMap;", "GetGetDefaultSkinAttrsHandler")]
			get {
				const string __id = "getDefaultSkinAttrs.()Landroidx/collection/SimpleArrayMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasBorder;
#pragma warning disable 0169
		static Delegate GetHasBorderHandler ()
		{
			if (cb_hasBorder == null)
				cb_hasBorder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasBorder);
			return cb_hasBorder;
		}

		static bool n_HasBorder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBorder;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBorder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='hasBorder' and count(parameter)=0]"
			[Register ("hasBorder", "()Z", "GetHasBorderHandler")]
			get {
				const string __id = "hasBorder.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasBottomSeparator;
#pragma warning disable 0169
		static Delegate GetHasBottomSeparatorHandler ()
		{
			if (cb_hasBottomSeparator == null)
				cb_hasBottomSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasBottomSeparator);
			return cb_hasBottomSeparator;
		}

		static bool n_HasBottomSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBottomSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBottomSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='hasBottomSeparator' and count(parameter)=0]"
			[Register ("hasBottomSeparator", "()Z", "GetHasBottomSeparatorHandler")]
			get {
				const string __id = "hasBottomSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasLeftSeparator;
#pragma warning disable 0169
		static Delegate GetHasLeftSeparatorHandler ()
		{
			if (cb_hasLeftSeparator == null)
				cb_hasLeftSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasLeftSeparator);
			return cb_hasLeftSeparator;
		}

		static bool n_HasLeftSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasLeftSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasLeftSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='hasLeftSeparator' and count(parameter)=0]"
			[Register ("hasLeftSeparator", "()Z", "GetHasLeftSeparatorHandler")]
			get {
				const string __id = "hasLeftSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasRightSeparator;
#pragma warning disable 0169
		static Delegate GetHasRightSeparatorHandler ()
		{
			if (cb_hasRightSeparator == null)
				cb_hasRightSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasRightSeparator);
			return cb_hasRightSeparator;
		}

		static bool n_HasRightSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRightSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasRightSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='hasRightSeparator' and count(parameter)=0]"
			[Register ("hasRightSeparator", "()Z", "GetHasRightSeparatorHandler")]
			get {
				const string __id = "hasRightSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasTopSeparator;
#pragma warning disable 0169
		static Delegate GetHasTopSeparatorHandler ()
		{
			if (cb_hasTopSeparator == null)
				cb_hasTopSeparator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasTopSeparator);
			return cb_hasTopSeparator;
		}

		static bool n_HasTopSeparator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTopSeparator;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasTopSeparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='hasTopSeparator' and count(parameter)=0]"
			[Register ("hasTopSeparator", "()Z", "GetHasTopSeparatorHandler")]
			get {
				const string __id = "hasTopSeparator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHideRadiusSide;
#pragma warning disable 0169
		static Delegate GetGetHideRadiusSideHandler ()
		{
			if (cb_getHideRadiusSide == null)
				cb_getHideRadiusSide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHideRadiusSide);
			return cb_getHideRadiusSide;
		}

		static int n_GetHideRadiusSide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideRadiusSide;
		}
#pragma warning restore 0169

		static Delegate cb_setHideRadiusSide_I;
#pragma warning disable 0169
		static Delegate GetSetHideRadiusSide_IHandler ()
		{
			if (cb_setHideRadiusSide_I == null)
				cb_setHideRadiusSide_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHideRadiusSide_I);
			return cb_setHideRadiusSide_I;
		}

		static void n_SetHideRadiusSide_I (IntPtr jnienv, IntPtr native__this, int hideRadiusSide)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideRadiusSide = hideRadiusSide;
		}
#pragma warning restore 0169

		public virtual unsafe int HideRadiusSide {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getHideRadiusSide' and count(parameter)=0]"
			[Register ("getHideRadiusSide", "()I", "GetGetHideRadiusSideHandler")]
			get {
				const string __id = "getHideRadiusSide.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setHideRadiusSide' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHideRadiusSide", "(I)V", "GetSetHideRadiusSide_IHandler")]
			set {
				const string __id = "setHideRadiusSide.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMode);
			return cb_getMode;
		}

		static int n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mode;
		}
#pragma warning restore 0169

		static Delegate cb_setMode_I;
#pragma warning disable 0169
		static Delegate GetSetMode_IHandler ()
		{
			if (cb_setMode_I == null)
				cb_setMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMode_I);
			return cb_setMode_I;
		}

		static void n_SetMode_I (IntPtr jnienv, IntPtr native__this, int mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mode = mode;
		}
#pragma warning restore 0169

		public virtual unsafe int Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()I", "GetGetModeHandler")]
			get {
				const string __id = "getMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMode", "(I)V", "GetSetMode_IHandler")]
			set {
				const string __id = "setMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
			set {
				const string __id = "setRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedIndex;
#pragma warning disable 0169
		static Delegate GetGetSelectedIndexHandler ()
		{
			if (cb_getSelectedIndex == null)
				cb_getSelectedIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSelectedIndex);
			return cb_getSelectedIndex;
		}

		static int n_GetSelectedIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getSelectedIndex' and count(parameter)=0]"
			[Register ("getSelectedIndex", "()I", "GetGetSelectedIndexHandler")]
			get {
				const string __id = "getSelectedIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getShadowAlpha;
#pragma warning disable 0169
		static Delegate GetGetShadowAlphaHandler ()
		{
			if (cb_getShadowAlpha == null)
				cb_getShadowAlpha = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetShadowAlpha);
			return cb_getShadowAlpha;
		}

		static float n_GetShadowAlpha (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowAlpha;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetShadowAlpha_FHandler ()
		{
			if (cb_setShadowAlpha_F == null)
				cb_setShadowAlpha_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetShadowAlpha_F);
			return cb_setShadowAlpha_F;
		}

		static void n_SetShadowAlpha_F (IntPtr jnienv, IntPtr native__this, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowAlpha = shadowAlpha;
		}
#pragma warning restore 0169

		public virtual unsafe float ShadowAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getShadowAlpha' and count(parameter)=0]"
			[Register ("getShadowAlpha", "()F", "GetGetShadowAlphaHandler")]
			get {
				const string __id = "getShadowAlpha.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setShadowAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setShadowAlpha", "(F)V", "GetSetShadowAlpha_FHandler")]
			set {
				const string __id = "setShadowAlpha.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowColor;
#pragma warning disable 0169
		static Delegate GetGetShadowColorHandler ()
		{
			if (cb_getShadowColor == null)
				cb_getShadowColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetShadowColor);
			return cb_getShadowColor;
		}

		static int n_GetShadowColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowColor;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowColor_I;
#pragma warning disable 0169
		static Delegate GetSetShadowColor_IHandler ()
		{
			if (cb_setShadowColor_I == null)
				cb_setShadowColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShadowColor_I);
			return cb_setShadowColor_I;
		}

		static void n_SetShadowColor_I (IntPtr jnienv, IntPtr native__this, int shadowColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowColor = shadowColor;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getShadowColor' and count(parameter)=0]"
			[Register ("getShadowColor", "()I", "GetGetShadowColorHandler")]
			get {
				const string __id = "getShadowColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowColor", "(I)V", "GetSetShadowColor_IHandler")]
			set {
				const string __id = "setShadowColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowElevation;
#pragma warning disable 0169
		static Delegate GetGetShadowElevationHandler ()
		{
			if (cb_getShadowElevation == null)
				cb_getShadowElevation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetShadowElevation);
			return cb_getShadowElevation;
		}

		static int n_GetShadowElevation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowElevation;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowElevation_I;
#pragma warning disable 0169
		static Delegate GetSetShadowElevation_IHandler ()
		{
			if (cb_setShadowElevation_I == null)
				cb_setShadowElevation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetShadowElevation_I);
			return cb_setShadowElevation_I;
		}

		static void n_SetShadowElevation_I (IntPtr jnienv, IntPtr native__this, int elevation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowElevation = elevation;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowElevation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getShadowElevation' and count(parameter)=0]"
			[Register ("getShadowElevation", "()I", "GetGetShadowElevationHandler")]
			get {
				const string __id = "getShadowElevation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setShadowElevation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowElevation", "(I)V", "GetSetShadowElevation_IHandler")]
			set {
				const string __id = "setShadowElevation.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTabCount;
#pragma warning disable 0169
		static Delegate GetGetTabCountHandler ()
		{
			if (cb_getTabCount == null)
				cb_getTabCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTabCount);
			return cb_getTabCount;
		}

		static int n_GetTabCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabCount;
		}
#pragma warning restore 0169

		public virtual unsafe int TabCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getTabCount' and count(parameter)=0]"
			[Register ("getTabCount", "()I", "GetGetTabCountHandler")]
			get {
				const string __id = "getTabCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_Handler ()
		{
			if (cb_addOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_ == null)
				cb_addOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_);
			return cb_addOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_;
		}

		static void n_AddOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnTabSelectedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='addOnTabSelectedListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabSelectedListener']]"
		[Register ("addOnTabSelectedListener", "(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabSelectedListener;)V", "GetAddOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_Handler")]
		public virtual unsafe void AddOnTabSelectedListener (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener listener)
		{
			const string __id = "addOnTabSelectedListener.(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabSelectedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_addTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_;
#pragma warning disable 0169
		static Delegate GetAddTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Handler ()
		{
			if (cb_addTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ == null)
				cb_addTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_);
			return cb_addTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_;
		}

		static IntPtr n_AddTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tab = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (native_tab, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTab (tab));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='addTab' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITab']]"
		[Register ("addTab", "(Lcom/qmuiteam/qmui/widget/tab/QMUITab;)Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment;", "GetAddTab_Lcom_qmuiteam_qmui_widget_tab_QMUITab_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment AddTab (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab tab)
		{
			const string __id = "addTab.(Lcom/qmuiteam/qmui/widget/tab/QMUITab;)Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tab == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tab).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tab);
			}
		}

		static Delegate cb_clearOnTabSelectedListeners;
#pragma warning disable 0169
		static Delegate GetClearOnTabSelectedListenersHandler ()
		{
			if (cb_clearOnTabSelectedListeners == null)
				cb_clearOnTabSelectedListeners = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearOnTabSelectedListeners);
			return cb_clearOnTabSelectedListeners;
		}

		static void n_ClearOnTabSelectedListeners (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearOnTabSelectedListeners ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='clearOnTabSelectedListeners' and count(parameter)=0]"
		[Register ("clearOnTabSelectedListeners", "()V", "GetClearOnTabSelectedListenersHandler")]
		public virtual unsafe void ClearOnTabSelectedListeners ()
		{
			const string __id = "clearOnTabSelectedListeners.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearSignCountView_I;
#pragma warning disable 0169
		static Delegate GetClearSignCountView_IHandler ()
		{
			if (cb_clearSignCountView_I == null)
				cb_clearSignCountView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ClearSignCountView_I);
			return cb_clearSignCountView_I;
		}

		static void n_ClearSignCountView_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearSignCountView (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='clearSignCountView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clearSignCountView", "(I)V", "GetClearSignCountView_IHandler")]
		public virtual unsafe void ClearSignCountView (int index)
		{
			const string __id = "clearSignCountView.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createTabAdapter_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetCreateTabAdapter_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_createTabAdapter_Landroid_view_ViewGroup_ == null)
				cb_createTabAdapter_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateTabAdapter_Landroid_view_ViewGroup_);
			return cb_createTabAdapter_Landroid_view_ViewGroup_;
		}

		static IntPtr n_CreateTabAdapter_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tabParentView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tabParentView = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_tabParentView, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateTabAdapter (tabParentView));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='createTabAdapter' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("createTabAdapter", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/tab/QMUITabAdapter;", "GetCreateTabAdapter_Landroid_view_ViewGroup_Handler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter CreateTabAdapter (global::Android.Views.ViewGroup tabParentView)
		{
			const string __id = "createTabAdapter.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/tab/QMUITabAdapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tabParentView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tabParentView).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tabParentView);
			}
		}

		static Delegate cb_createTabIndicatorFromXmlInfo_ZIZZ;
#pragma warning disable 0169
		static Delegate GetCreateTabIndicatorFromXmlInfo_ZIZZHandler ()
		{
			if (cb_createTabIndicatorFromXmlInfo_ZIZZ == null)
				cb_createTabIndicatorFromXmlInfo_ZIZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZIZZ_L) n_CreateTabIndicatorFromXmlInfo_ZIZZ);
			return cb_createTabIndicatorFromXmlInfo_ZIZZ;
		}

		static IntPtr n_CreateTabIndicatorFromXmlInfo_ZIZZ (IntPtr jnienv, IntPtr native__this, bool hasIndicator, int indicatorHeight, bool indicatorTop, bool indicatorWidthFollowContent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateTabIndicatorFromXmlInfo (hasIndicator, indicatorHeight, indicatorTop, indicatorWidthFollowContent));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='createTabIndicatorFromXmlInfo' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("createTabIndicatorFromXmlInfo", "(ZIZZ)Lcom/qmuiteam/qmui/widget/tab/QMUITabIndicator;", "GetCreateTabIndicatorFromXmlInfo_ZIZZHandler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator CreateTabIndicatorFromXmlInfo (bool hasIndicator, int indicatorHeight, bool indicatorTop, bool indicatorWidthFollowContent)
		{
			const string __id = "createTabIndicatorFromXmlInfo.(ZIZZ)Lcom/qmuiteam/qmui/widget/tab/QMUITabIndicator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (hasIndicator);
				__args [1] = new JniArgumentValue (indicatorHeight);
				__args [2] = new JniArgumentValue (indicatorTop);
				__args [3] = new JniArgumentValue (indicatorWidthFollowContent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSignCount_I;
#pragma warning disable 0169
		static Delegate GetGetSignCount_IHandler ()
		{
			if (cb_getSignCount_I == null)
				cb_getSignCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetSignCount_I);
			return cb_getSignCount_I;
		}

		static int n_GetSignCount_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSignCount (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getSignCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSignCount", "(I)I", "GetGetSignCount_IHandler")]
		public virtual unsafe int GetSignCount (int index)
		{
			const string __id = "getSignCount.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getTab_I;
#pragma warning disable 0169
		static Delegate GetGetTab_IHandler ()
		{
			if (cb_getTab_I == null)
				cb_getTab_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetTab_I);
			return cb_getTab_I;
		}

		static IntPtr n_GetTab_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTab (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='getTab' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTab", "(I)Lcom/qmuiteam/qmui/widget/tab/QMUITab;", "GetGetTab_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab GetTab (int index)
		{
			const string __id = "getTab.(I)Lcom/qmuiteam/qmui/widget/tab/QMUITab;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			var attrs = global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (native_attrs, JniHandleOwnership.DoNotTransfer);
			__this.Handle (manager, skinIndex, theme, attrs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='androidx.collection.SimpleArrayMap&lt;java.lang.String, java.lang.Integer&gt;']]"
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

		static Delegate cb_isRedPointShowing_I;
#pragma warning disable 0169
		static Delegate GetIsRedPointShowing_IHandler ()
		{
			if (cb_isRedPointShowing_I == null)
				cb_isRedPointShowing_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsRedPointShowing_I);
			return cb_isRedPointShowing_I;
		}

		static bool n_IsRedPointShowing_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRedPointShowing (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='isRedPointShowing' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isRedPointShowing", "(I)Z", "GetIsRedPointShowing_IHandler")]
		public virtual unsafe bool IsRedPointShowing (int index)
		{
			const string __id = "isRedPointShowing.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_needPreventEvent;
#pragma warning disable 0169
		static Delegate GetNeedPreventEventHandler ()
		{
			if (cb_needPreventEvent == null)
				cb_needPreventEvent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NeedPreventEvent);
			return cb_needPreventEvent;
		}

		static bool n_NeedPreventEvent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedPreventEvent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='needPreventEvent' and count(parameter)=0]"
		[Register ("needPreventEvent", "()Z", "GetNeedPreventEventHandler")]
		protected virtual unsafe bool NeedPreventEvent ()
		{
			const string __id = "needPreventEvent.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_notifyDataChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataChangedHandler ()
		{
			if (cb_notifyDataChanged == null)
				cb_notifyDataChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_NotifyDataChanged);
			return cb_notifyDataChanged;
		}

		static void n_NotifyDataChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='notifyDataChanged' and count(parameter)=0]"
		[Register ("notifyDataChanged", "()V", "GetNotifyDataChangedHandler")]
		public virtual unsafe void NotifyDataChanged ()
		{
			const string __id = "notifyDataChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I;
#pragma warning disable 0169
		static Delegate GetOnClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_IHandler ()
		{
			if (cb_onClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I == null)
				cb_onClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I);
			return cb_onClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I;
		}

		static void n_OnClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnClickTab (view, index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='onClickTab' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabView'] and parameter[2][@type='int']]"
		[Register ("onClickTab", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)V", "GetOnClickTab_Lcom_qmuiteam_qmui_widget_tab_QMUITabView_IHandler")]
		protected virtual unsafe void OnClickTab (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabView view, int index)
		{
			const string __id = "onClickTab.(Lcom/qmuiteam/qmui/widget/tab/QMUITabView;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onlyShowBottomDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowBottomDivider_IIIIHandler ()
		{
			if (cb_onlyShowBottomDivider_IIII == null)
				cb_onlyShowBottomDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowBottomDivider_IIII);
			return cb_onlyShowBottomDivider_IIII;
		}

		static void n_OnlyShowBottomDivider_IIII (IntPtr jnienv, IntPtr native__this, int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowBottomDivider (bottomInsetLeft, bottomInsetRight, bottomDividerHeight, bottomDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='onlyShowBottomDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowBottomDivider", "(IIII)V", "GetOnlyShowBottomDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			const string __id = "onlyShowBottomDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (bottomInsetLeft);
				__args [1] = new JniArgumentValue (bottomInsetRight);
				__args [2] = new JniArgumentValue (bottomDividerHeight);
				__args [3] = new JniArgumentValue (bottomDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onlyShowLeftDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowLeftDivider_IIIIHandler ()
		{
			if (cb_onlyShowLeftDivider_IIII == null)
				cb_onlyShowLeftDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowLeftDivider_IIII);
			return cb_onlyShowLeftDivider_IIII;
		}

		static void n_OnlyShowLeftDivider_IIII (IntPtr jnienv, IntPtr native__this, int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowLeftDivider (leftInsetTop, leftInsetBottom, leftDividerWidth, leftDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='onlyShowLeftDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowLeftDivider", "(IIII)V", "GetOnlyShowLeftDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			const string __id = "onlyShowLeftDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (leftInsetTop);
				__args [1] = new JniArgumentValue (leftInsetBottom);
				__args [2] = new JniArgumentValue (leftDividerWidth);
				__args [3] = new JniArgumentValue (leftDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onlyShowRightDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowRightDivider_IIIIHandler ()
		{
			if (cb_onlyShowRightDivider_IIII == null)
				cb_onlyShowRightDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowRightDivider_IIII);
			return cb_onlyShowRightDivider_IIII;
		}

		static void n_OnlyShowRightDivider_IIII (IntPtr jnienv, IntPtr native__this, int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowRightDivider (rightInsetTop, rightInsetBottom, rightDividerWidth, rightDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='onlyShowRightDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowRightDivider", "(IIII)V", "GetOnlyShowRightDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			const string __id = "onlyShowRightDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (rightInsetTop);
				__args [1] = new JniArgumentValue (rightInsetBottom);
				__args [2] = new JniArgumentValue (rightDividerWidth);
				__args [3] = new JniArgumentValue (rightDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onlyShowTopDivider_IIII;
#pragma warning disable 0169
		static Delegate GetOnlyShowTopDivider_IIIIHandler ()
		{
			if (cb_onlyShowTopDivider_IIII == null)
				cb_onlyShowTopDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_OnlyShowTopDivider_IIII);
			return cb_onlyShowTopDivider_IIII;
		}

		static void n_OnlyShowTopDivider_IIII (IntPtr jnienv, IntPtr native__this, int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnlyShowTopDivider (topInsetLeft, topInsetRight, topDividerHeight, topDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='onlyShowTopDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onlyShowTopDivider", "(IIII)V", "GetOnlyShowTopDivider_IIIIHandler")]
		public virtual unsafe void OnlyShowTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			const string __id = "onlyShowTopDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (topInsetLeft);
				__args [1] = new JniArgumentValue (topInsetRight);
				__args [2] = new JniArgumentValue (topDividerHeight);
				__args [3] = new JniArgumentValue (topDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_Handler ()
		{
			if (cb_removeOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_ == null)
				cb_removeOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_);
			return cb_removeOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_;
		}

		static void n_RemoveOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnTabSelectedListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='removeOnTabSelectedListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabSelectedListener']]"
		[Register ("removeOnTabSelectedListener", "(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabSelectedListener;)V", "GetRemoveOnTabSelectedListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabSelectedListener_Handler")]
		public virtual unsafe void RemoveOnTabSelectedListener (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener listener)
		{
			const string __id = "removeOnTabSelectedListener.(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabSelectedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_replaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_;
#pragma warning disable 0169
		static Delegate GetReplaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_Handler ()
		{
			if (cb_replaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_ == null)
				cb_replaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_ReplaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_);
			return cb_replaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_;
		}

		static void n_ReplaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_model)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var model = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab> (native_model, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceTab (index, model);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='replaceTab' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.qmuiteam.qmui.widget.tab.QMUITab']]"
		[Register ("replaceTab", "(ILcom/qmuiteam/qmui/widget/tab/QMUITab;)V", "GetReplaceTab_ILcom_qmuiteam_qmui_widget_tab_QMUITab_Handler")]
		public virtual unsafe void ReplaceTab (int index, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITab model)
		{
			const string __id = "replaceTab.(ILcom/qmuiteam/qmui/widget/tab/QMUITab;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((model == null) ? IntPtr.Zero : ((global::Java.Lang.Object) model).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (model);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resetSelect;
#pragma warning disable 0169
		static Delegate GetResetSelectHandler ()
		{
			if (cb_resetSelect == null)
				cb_resetSelect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetSelect);
			return cb_resetSelect;
		}

		static void n_ResetSelect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetSelect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='resetSelect' and count(parameter)=0]"
		[Register ("resetSelect", "()V", "GetResetSelectHandler")]
		public virtual unsafe void ResetSelect ()
		{
			const string __id = "resetSelect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_selectTab_I;
#pragma warning disable 0169
		static Delegate GetSelectTab_IHandler ()
		{
			if (cb_selectTab_I == null)
				cb_selectTab_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SelectTab_I);
			return cb_selectTab_I;
		}

		static void n_SelectTab_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectTab (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='selectTab' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("selectTab", "(I)V", "GetSelectTab_IHandler")]
		public virtual unsafe void SelectTab (int index)
		{
			const string __id = "selectTab.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_selectTab_IZZ;
#pragma warning disable 0169
		static Delegate GetSelectTab_IZZHandler ()
		{
			if (cb_selectTab_IZZ == null)
				cb_selectTab_IZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZZ_V) n_SelectTab_IZZ);
			return cb_selectTab_IZZ;
		}

		static void n_SelectTab_IZZ (IntPtr jnienv, IntPtr native__this, int index, bool noAnimation, bool fromTabClick)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectTab (index, noAnimation, fromTabClick);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='selectTab' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("selectTab", "(IZZ)V", "GetSelectTab_IZZHandler")]
		public virtual unsafe void SelectTab (int index, bool noAnimation, bool fromTabClick)
		{
			const string __id = "selectTab.(IZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (noAnimation);
				__args [2] = new JniArgumentValue (fromTabClick);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int borderColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderColor (borderColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
		public virtual unsafe void SetBorderColor (int borderColor)
		{
			const string __id = "setBorderColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (borderColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBorderWidth_I;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_IHandler ()
		{
			if (cb_setBorderWidth_I == null)
				cb_setBorderWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderWidth_I);
			return cb_setBorderWidth_I;
		}

		static void n_SetBorderWidth_I (IntPtr jnienv, IntPtr native__this, int borderWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderWidth (borderWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderWidth", "(I)V", "GetSetBorderWidth_IHandler")]
		public virtual unsafe void SetBorderWidth (int borderWidth)
		{
			const string __id = "setBorderWidth.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (borderWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBottomDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetBottomDividerAlpha_IHandler ()
		{
			if (cb_setBottomDividerAlpha_I == null)
				cb_setBottomDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBottomDividerAlpha_I);
			return cb_setBottomDividerAlpha_I;
		}

		static void n_SetBottomDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBottomDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setBottomDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBottomDividerAlpha", "(I)V", "GetSetBottomDividerAlpha_IHandler")]
		public virtual unsafe void SetBottomDividerAlpha (int dividerAlpha)
		{
			const string __id = "setBottomDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultTabIconPosition_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultTabIconPosition_IHandler ()
		{
			if (cb_setDefaultTabIconPosition_I == null)
				cb_setDefaultTabIconPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDefaultTabIconPosition_I);
			return cb_setDefaultTabIconPosition_I;
		}

		static void n_SetDefaultTabIconPosition_I (IntPtr jnienv, IntPtr native__this, int iconPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultTabIconPosition (iconPosition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setDefaultTabIconPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultTabIconPosition", "(I)V", "GetSetDefaultTabIconPosition_IHandler")]
		public virtual unsafe void SetDefaultTabIconPosition (int iconPosition)
		{
			const string __id = "setDefaultTabIconPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (iconPosition);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultTextSize_II;
#pragma warning disable 0169
		static Delegate GetSetDefaultTextSize_IIHandler ()
		{
			if (cb_setDefaultTextSize_II == null)
				cb_setDefaultTextSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetDefaultTextSize_II);
			return cb_setDefaultTextSize_II;
		}

		static void n_SetDefaultTextSize_II (IntPtr jnienv, IntPtr native__this, int normalTextSize, int selectedTextSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultTextSize (normalTextSize, selectedTextSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setDefaultTextSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDefaultTextSize", "(II)V", "GetSetDefaultTextSize_IIHandler")]
		public virtual unsafe void SetDefaultTextSize (int normalTextSize, int selectedTextSize)
		{
			const string __id = "setDefaultTextSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (normalTextSize);
				__args [1] = new JniArgumentValue (selectedTextSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHeightLimit_I;
#pragma warning disable 0169
		static Delegate GetSetHeightLimit_IHandler ()
		{
			if (cb_setHeightLimit_I == null)
				cb_setHeightLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetHeightLimit_I);
			return cb_setHeightLimit_I;
		}

		static bool n_SetHeightLimit_I (IntPtr jnienv, IntPtr native__this, int heightLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetHeightLimit (heightLimit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setHeightLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeightLimit", "(I)Z", "GetSetHeightLimit_IHandler")]
		public virtual unsafe bool SetHeightLimit (int heightLimit)
		{
			const string __id = "setHeightLimit.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (heightLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setHideIndicatorWhenTabCountLessTwo_Z;
#pragma warning disable 0169
		static Delegate GetSetHideIndicatorWhenTabCountLessTwo_ZHandler ()
		{
			if (cb_setHideIndicatorWhenTabCountLessTwo_Z == null)
				cb_setHideIndicatorWhenTabCountLessTwo_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHideIndicatorWhenTabCountLessTwo_Z);
			return cb_setHideIndicatorWhenTabCountLessTwo_Z;
		}

		static void n_SetHideIndicatorWhenTabCountLessTwo_Z (IntPtr jnienv, IntPtr native__this, bool hideIndicatorWhenTabCountLessTwo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHideIndicatorWhenTabCountLessTwo (hideIndicatorWhenTabCountLessTwo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setHideIndicatorWhenTabCountLessTwo' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHideIndicatorWhenTabCountLessTwo", "(Z)V", "GetSetHideIndicatorWhenTabCountLessTwo_ZHandler")]
		public virtual unsafe void SetHideIndicatorWhenTabCountLessTwo (bool hideIndicatorWhenTabCountLessTwo)
		{
			const string __id = "setHideIndicatorWhenTabCountLessTwo.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (hideIndicatorWhenTabCountLessTwo);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_;
#pragma warning disable 0169
		static Delegate GetSetIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_Handler ()
		{
			if (cb_setIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_ == null)
				cb_setIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_);
			return cb_setIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_;
		}

		static void n_SetIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_indicator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var indicator = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator> (native_indicator, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicator (indicator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setIndicator' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabIndicator']]"
		[Register ("setIndicator", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabIndicator;)V", "GetSetIndicator_Lcom_qmuiteam_qmui_widget_tab_QMUITabIndicator_Handler")]
		public virtual unsafe void SetIndicator (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabIndicator indicator)
		{
			const string __id = "setIndicator.(Lcom/qmuiteam/qmui/widget/tab/QMUITabIndicator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (indicator);
			}
		}

		static Delegate cb_setItemSpaceInScrollMode_I;
#pragma warning disable 0169
		static Delegate GetSetItemSpaceInScrollMode_IHandler ()
		{
			if (cb_setItemSpaceInScrollMode_I == null)
				cb_setItemSpaceInScrollMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetItemSpaceInScrollMode_I);
			return cb_setItemSpaceInScrollMode_I;
		}

		static void n_SetItemSpaceInScrollMode_I (IntPtr jnienv, IntPtr native__this, int itemSpaceInScrollMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetItemSpaceInScrollMode (itemSpaceInScrollMode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setItemSpaceInScrollMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setItemSpaceInScrollMode", "(I)V", "GetSetItemSpaceInScrollMode_IHandler")]
		public virtual unsafe void SetItemSpaceInScrollMode (int itemSpaceInScrollMode)
		{
			const string __id = "setItemSpaceInScrollMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (itemSpaceInScrollMode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLeftDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetLeftDividerAlpha_IHandler ()
		{
			if (cb_setLeftDividerAlpha_I == null)
				cb_setLeftDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLeftDividerAlpha_I);
			return cb_setLeftDividerAlpha_I;
		}

		static void n_SetLeftDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLeftDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setLeftDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLeftDividerAlpha", "(I)V", "GetSetLeftDividerAlpha_IHandler")]
		public virtual unsafe void SetLeftDividerAlpha (int dividerAlpha)
		{
			const string __id = "setLeftDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_Handler ()
		{
			if (cb_setOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_ == null)
				cb_setOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_);
			return cb_setOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_;
		}

		static void n_SetOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onTabClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onTabClickListener = (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener> (native_onTabClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTabClickListener (onTabClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setOnTabClickListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.OnTabClickListener']]"
		[Register ("setOnTabClickListener", "(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabClickListener;)V", "GetSetOnTabClickListener_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_OnTabClickListener_Handler")]
		public virtual unsafe void SetOnTabClickListener (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener onTabClickListener)
		{
			const string __id = "setOnTabClickListener.(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$OnTabClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onTabClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onTabClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onTabClickListener);
			}
		}

		static Delegate cb_setOuterNormalColor_I;
#pragma warning disable 0169
		static Delegate GetSetOuterNormalColor_IHandler ()
		{
			if (cb_setOuterNormalColor_I == null)
				cb_setOuterNormalColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetOuterNormalColor_I);
			return cb_setOuterNormalColor_I;
		}

		static void n_SetOuterNormalColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOuterNormalColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setOuterNormalColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOuterNormalColor", "(I)V", "GetSetOuterNormalColor_IHandler")]
		public virtual unsafe void SetOuterNormalColor (int color)
		{
			const string __id = "setOuterNormalColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOutlineExcludePadding_Z;
#pragma warning disable 0169
		static Delegate GetSetOutlineExcludePadding_ZHandler ()
		{
			if (cb_setOutlineExcludePadding_Z == null)
				cb_setOutlineExcludePadding_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOutlineExcludePadding_Z);
			return cb_setOutlineExcludePadding_Z;
		}

		static void n_SetOutlineExcludePadding_Z (IntPtr jnienv, IntPtr native__this, bool outlineExcludePadding)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutlineExcludePadding (outlineExcludePadding);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setOutlineExcludePadding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOutlineExcludePadding", "(Z)V", "GetSetOutlineExcludePadding_ZHandler")]
		public virtual unsafe void SetOutlineExcludePadding (bool outlineExcludePadding)
		{
			const string __id = "setOutlineExcludePadding.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (outlineExcludePadding);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOutlineInset_IIII;
#pragma warning disable 0169
		static Delegate GetSetOutlineInset_IIIIHandler ()
		{
			if (cb_setOutlineInset_IIII == null)
				cb_setOutlineInset_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_SetOutlineInset_IIII);
			return cb_setOutlineInset_IIII;
		}

		static void n_SetOutlineInset_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutlineInset (left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setOutlineInset' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setOutlineInset", "(IIII)V", "GetSetOutlineInset_IIIIHandler")]
		public virtual unsafe void SetOutlineInset (int left, int top, int right, int bottom)
		{
			const string __id = "setOutlineInset.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadius_II;
#pragma warning disable 0169
		static Delegate GetSetRadius_IIHandler ()
		{
			if (cb_setRadius_II == null)
				cb_setRadius_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetRadius_II);
			return cb_setRadius_II;
		}

		static void n_SetRadius_II (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius, hideRadiusSide);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setRadius' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setRadius", "(II)V", "GetSetRadius_IIHandler")]
		public virtual unsafe void SetRadius (int radius, int hideRadiusSide)
		{
			const string __id = "setRadius.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (hideRadiusSide);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadiusAndShadow_IIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIF == null)
				cb_setRadiusAndShadow_IIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIF_V) n_SetRadiusAndShadow_IIF);
			return cb_setRadiusAndShadow_IIF;
		}

		static void n_SetRadiusAndShadow_IIF (IntPtr jnienv, IntPtr native__this, int radius, int shadowElevation, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, shadowElevation, shadowAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setRadiusAndShadow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIF)V", "GetSetRadiusAndShadow_IIFHandler")]
		public virtual unsafe void SetRadiusAndShadow (int radius, int shadowElevation, float shadowAlpha)
		{
			const string __id = "setRadiusAndShadow.(IIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (shadowElevation);
				__args [2] = new JniArgumentValue (shadowAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadiusAndShadow_IIIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIIF == null)
				cb_setRadiusAndShadow_IIIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIF_V) n_SetRadiusAndShadow_IIIF);
			return cb_setRadiusAndShadow_IIIF;
		}

		static void n_SetRadiusAndShadow_IIIF (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide, int shadowElevation, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, hideRadiusSide, shadowElevation, shadowAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setRadiusAndShadow' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIIF)V", "GetSetRadiusAndShadow_IIIFHandler")]
		public virtual unsafe void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, float shadowAlpha)
		{
			const string __id = "setRadiusAndShadow.(IIIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (hideRadiusSide);
				__args [2] = new JniArgumentValue (shadowElevation);
				__args [3] = new JniArgumentValue (shadowAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadiusAndShadow_IIIIF;
#pragma warning disable 0169
		static Delegate GetSetRadiusAndShadow_IIIIFHandler ()
		{
			if (cb_setRadiusAndShadow_IIIIF == null)
				cb_setRadiusAndShadow_IIIIF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIIF_V) n_SetRadiusAndShadow_IIIIF);
			return cb_setRadiusAndShadow_IIIIF;
		}

		static void n_SetRadiusAndShadow_IIIIF (IntPtr jnienv, IntPtr native__this, int radius, int hideRadiusSide, int shadowElevation, int shadowColor, float shadowAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadiusAndShadow (radius, hideRadiusSide, shadowElevation, shadowColor, shadowAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setRadiusAndShadow' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float']]"
		[Register ("setRadiusAndShadow", "(IIIIF)V", "GetSetRadiusAndShadow_IIIIFHandler")]
		public virtual unsafe void SetRadiusAndShadow (int radius, int hideRadiusSide, int shadowElevation, int shadowColor, float shadowAlpha)
		{
			const string __id = "setRadiusAndShadow.(IIIIF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (hideRadiusSide);
				__args [2] = new JniArgumentValue (shadowElevation);
				__args [3] = new JniArgumentValue (shadowColor);
				__args [4] = new JniArgumentValue (shadowAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRightDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetRightDividerAlpha_IHandler ()
		{
			if (cb_setRightDividerAlpha_I == null)
				cb_setRightDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRightDividerAlpha_I);
			return cb_setRightDividerAlpha_I;
		}

		static void n_SetRightDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRightDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setRightDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRightDividerAlpha", "(I)V", "GetSetRightDividerAlpha_IHandler")]
		public virtual unsafe void SetRightDividerAlpha (int dividerAlpha)
		{
			const string __id = "setRightDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSelectNoAnimation_Z;
#pragma warning disable 0169
		static Delegate GetSetSelectNoAnimation_ZHandler ()
		{
			if (cb_setSelectNoAnimation_Z == null)
				cb_setSelectNoAnimation_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSelectNoAnimation_Z);
			return cb_setSelectNoAnimation_Z;
		}

		static void n_SetSelectNoAnimation_Z (IntPtr jnienv, IntPtr native__this, bool noAnimation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectNoAnimation (noAnimation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setSelectNoAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSelectNoAnimation", "(Z)V", "GetSetSelectNoAnimation_ZHandler")]
		public virtual unsafe void SetSelectNoAnimation (bool noAnimation)
		{
			const string __id = "setSelectNoAnimation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noAnimation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowBorderOnlyBeforeL_Z;
#pragma warning disable 0169
		static Delegate GetSetShowBorderOnlyBeforeL_ZHandler ()
		{
			if (cb_setShowBorderOnlyBeforeL_Z == null)
				cb_setShowBorderOnlyBeforeL_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowBorderOnlyBeforeL_Z);
			return cb_setShowBorderOnlyBeforeL_Z;
		}

		static void n_SetShowBorderOnlyBeforeL_Z (IntPtr jnienv, IntPtr native__this, bool showBorderOnlyBeforeL)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowBorderOnlyBeforeL (showBorderOnlyBeforeL);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setShowBorderOnlyBeforeL' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowBorderOnlyBeforeL", "(Z)V", "GetSetShowBorderOnlyBeforeL_ZHandler")]
		public virtual unsafe void SetShowBorderOnlyBeforeL (bool showBorderOnlyBeforeL)
		{
			const string __id = "setShowBorderOnlyBeforeL.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showBorderOnlyBeforeL);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTopDividerAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetTopDividerAlpha_IHandler ()
		{
			if (cb_setTopDividerAlpha_I == null)
				cb_setTopDividerAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTopDividerAlpha_I);
			return cb_setTopDividerAlpha_I;
		}

		static void n_SetTopDividerAlpha_I (IntPtr jnienv, IntPtr native__this, int dividerAlpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTopDividerAlpha (dividerAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setTopDividerAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTopDividerAlpha", "(I)V", "GetSetTopDividerAlpha_IHandler")]
		public virtual unsafe void SetTopDividerAlpha (int dividerAlpha)
		{
			const string __id = "setTopDividerAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dividerAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUseThemeGeneralShadowElevation;
#pragma warning disable 0169
		static Delegate GetSetUseThemeGeneralShadowElevationHandler ()
		{
			if (cb_setUseThemeGeneralShadowElevation == null)
				cb_setUseThemeGeneralShadowElevation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetUseThemeGeneralShadowElevation);
			return cb_setUseThemeGeneralShadowElevation;
		}

		static void n_SetUseThemeGeneralShadowElevation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseThemeGeneralShadowElevation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setUseThemeGeneralShadowElevation' and count(parameter)=0]"
		[Register ("setUseThemeGeneralShadowElevation", "()V", "GetSetUseThemeGeneralShadowElevationHandler")]
		public virtual unsafe void SetUseThemeGeneralShadowElevation ()
		{
			const string __id = "setUseThemeGeneralShadowElevation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setWidthLimit_I;
#pragma warning disable 0169
		static Delegate GetSetWidthLimit_IHandler ()
		{
			if (cb_setWidthLimit_I == null)
				cb_setWidthLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_SetWidthLimit_I);
			return cb_setWidthLimit_I;
		}

		static bool n_SetWidthLimit_I (IntPtr jnienv, IntPtr native__this, int widthLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetWidthLimit (widthLimit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='setWidthLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWidthLimit", "(I)Z", "GetSetWidthLimit_IHandler")]
		public virtual unsafe bool SetWidthLimit (int widthLimit)
		{
			const string __id = "setWidthLimit.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (widthLimit);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_showSignCountView_Landroid_content_Context_II;
#pragma warning disable 0169
		static Delegate GetShowSignCountView_Landroid_content_Context_IIHandler ()
		{
			if (cb_showSignCountView_Landroid_content_Context_II == null)
				cb_showSignCountView_Landroid_content_Context_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_ShowSignCountView_Landroid_content_Context_II);
			return cb_showSignCountView_Landroid_content_Context_II;
		}

		static void n_ShowSignCountView_Landroid_content_Context_II (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int index, int count)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.ShowSignCountView (context, index, count);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='showSignCountView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("showSignCountView", "(Landroid/content/Context;II)V", "GetShowSignCountView_Landroid_content_Context_IIHandler")]
		public virtual unsafe void ShowSignCountView (global::Android.Content.Context context, int index, int count)
		{
			const string __id = "showSignCountView.(Landroid/content/Context;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (index);
				__args [2] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_tabBuilder;
#pragma warning disable 0169
		static Delegate GetTabBuilderHandler ()
		{
			if (cb_tabBuilder == null)
				cb_tabBuilder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TabBuilder);
			return cb_tabBuilder;
		}

		static IntPtr n_TabBuilder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TabBuilder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='tabBuilder' and count(parameter)=0]"
		[Register ("tabBuilder", "()Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;", "GetTabBuilderHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder TabBuilder ()
		{
			const string __id = "tabBuilder.()Lcom/qmuiteam/qmui/widget/tab/QMUITabBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_updateBottomDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateBottomDivider_IIIIHandler ()
		{
			if (cb_updateBottomDivider_IIII == null)
				cb_updateBottomDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateBottomDivider_IIII);
			return cb_updateBottomDivider_IIII;
		}

		static void n_UpdateBottomDivider_IIII (IntPtr jnienv, IntPtr native__this, int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBottomDivider (bottomInsetLeft, bottomInsetRight, bottomDividerHeight, bottomDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateBottomDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateBottomDivider", "(IIII)V", "GetUpdateBottomDivider_IIIIHandler")]
		public virtual unsafe void UpdateBottomDivider (int bottomInsetLeft, int bottomInsetRight, int bottomDividerHeight, int bottomDividerColor)
		{
			const string __id = "updateBottomDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (bottomInsetLeft);
				__args [1] = new JniArgumentValue (bottomInsetRight);
				__args [2] = new JniArgumentValue (bottomDividerHeight);
				__args [3] = new JniArgumentValue (bottomDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateBottomSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateBottomSeparatorColor_IHandler ()
		{
			if (cb_updateBottomSeparatorColor_I == null)
				cb_updateBottomSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateBottomSeparatorColor_I);
			return cb_updateBottomSeparatorColor_I;
		}

		static void n_UpdateBottomSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBottomSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateBottomSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateBottomSeparatorColor", "(I)V", "GetUpdateBottomSeparatorColor_IHandler")]
		public virtual unsafe void UpdateBottomSeparatorColor (int color)
		{
			const string __id = "updateBottomSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateIndicatorPosition_IF;
#pragma warning disable 0169
		static Delegate GetUpdateIndicatorPosition_IFHandler ()
		{
			if (cb_updateIndicatorPosition_IF == null)
				cb_updateIndicatorPosition_IF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIF_V) n_UpdateIndicatorPosition_IF);
			return cb_updateIndicatorPosition_IF;
		}

		static void n_UpdateIndicatorPosition_IF (IntPtr jnienv, IntPtr native__this, int index, float offsetPercent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateIndicatorPosition (index, offsetPercent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateIndicatorPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("updateIndicatorPosition", "(IF)V", "GetUpdateIndicatorPosition_IFHandler")]
		public virtual unsafe void UpdateIndicatorPosition (int index, float offsetPercent)
		{
			const string __id = "updateIndicatorPosition.(IF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (offsetPercent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateLeftDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateLeftDivider_IIIIHandler ()
		{
			if (cb_updateLeftDivider_IIII == null)
				cb_updateLeftDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateLeftDivider_IIII);
			return cb_updateLeftDivider_IIII;
		}

		static void n_UpdateLeftDivider_IIII (IntPtr jnienv, IntPtr native__this, int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLeftDivider (leftInsetTop, leftInsetBottom, leftDividerWidth, leftDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateLeftDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateLeftDivider", "(IIII)V", "GetUpdateLeftDivider_IIIIHandler")]
		public virtual unsafe void UpdateLeftDivider (int leftInsetTop, int leftInsetBottom, int leftDividerWidth, int leftDividerColor)
		{
			const string __id = "updateLeftDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (leftInsetTop);
				__args [1] = new JniArgumentValue (leftInsetBottom);
				__args [2] = new JniArgumentValue (leftDividerWidth);
				__args [3] = new JniArgumentValue (leftDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateLeftSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateLeftSeparatorColor_IHandler ()
		{
			if (cb_updateLeftSeparatorColor_I == null)
				cb_updateLeftSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateLeftSeparatorColor_I);
			return cb_updateLeftSeparatorColor_I;
		}

		static void n_UpdateLeftSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLeftSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateLeftSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateLeftSeparatorColor", "(I)V", "GetUpdateLeftSeparatorColor_IHandler")]
		public virtual unsafe void UpdateLeftSeparatorColor (int color)
		{
			const string __id = "updateLeftSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_;
#pragma warning disable 0169
		static Delegate GetUpdateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_Handler ()
		{
			if (cb_updateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_ == null)
				cb_updateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_);
			return cb_updateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_;
		}

		static void n_UpdateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_ (IntPtr jnienv, IntPtr native__this, IntPtr native_updater)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var updater = (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.ITabBuilderUpdater)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.ITabBuilderUpdater> (native_updater, JniHandleOwnership.DoNotTransfer);
			__this.UpdateParentTabBuilder (updater);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateParentTabBuilder' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUIBasicTabSegment.TabBuilderUpdater']]"
		[Register ("updateParentTabBuilder", "(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$TabBuilderUpdater;)V", "GetUpdateParentTabBuilder_Lcom_qmuiteam_qmui_widget_tab_QMUIBasicTabSegment_TabBuilderUpdater_Handler")]
		public virtual unsafe void UpdateParentTabBuilder (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.ITabBuilderUpdater updater)
		{
			const string __id = "updateParentTabBuilder.(Lcom/qmuiteam/qmui/widget/tab/QMUIBasicTabSegment$TabBuilderUpdater;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((updater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) updater).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (updater);
			}
		}

		static Delegate cb_updateRightDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateRightDivider_IIIIHandler ()
		{
			if (cb_updateRightDivider_IIII == null)
				cb_updateRightDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateRightDivider_IIII);
			return cb_updateRightDivider_IIII;
		}

		static void n_UpdateRightDivider_IIII (IntPtr jnienv, IntPtr native__this, int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRightDivider (rightInsetTop, rightInsetBottom, rightDividerWidth, rightDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateRightDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateRightDivider", "(IIII)V", "GetUpdateRightDivider_IIIIHandler")]
		public virtual unsafe void UpdateRightDivider (int rightInsetTop, int rightInsetBottom, int rightDividerWidth, int rightDividerColor)
		{
			const string __id = "updateRightDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (rightInsetTop);
				__args [1] = new JniArgumentValue (rightInsetBottom);
				__args [2] = new JniArgumentValue (rightDividerWidth);
				__args [3] = new JniArgumentValue (rightDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateRightSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateRightSeparatorColor_IHandler ()
		{
			if (cb_updateRightSeparatorColor_I == null)
				cb_updateRightSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateRightSeparatorColor_I);
			return cb_updateRightSeparatorColor_I;
		}

		static void n_UpdateRightSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRightSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateRightSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateRightSeparatorColor", "(I)V", "GetUpdateRightSeparatorColor_IHandler")]
		public virtual unsafe void UpdateRightSeparatorColor (int color)
		{
			const string __id = "updateRightSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateTabText_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateTabText_ILjava_lang_String_Handler ()
		{
			if (cb_updateTabText_ILjava_lang_String_ == null)
				cb_updateTabText_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_UpdateTabText_ILjava_lang_String_);
			return cb_updateTabText_ILjava_lang_String_;
		}

		static void n_UpdateTabText_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTabText (index, text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateTabText' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateTabText", "(ILjava/lang/String;)V", "GetUpdateTabText_ILjava_lang_String_Handler")]
		public virtual unsafe void UpdateTabText (int index, string text)
		{
			const string __id = "updateTabText.(ILjava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_updateTopDivider_IIII;
#pragma warning disable 0169
		static Delegate GetUpdateTopDivider_IIIIHandler ()
		{
			if (cb_updateTopDivider_IIII == null)
				cb_updateTopDivider_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_UpdateTopDivider_IIII);
			return cb_updateTopDivider_IIII;
		}

		static void n_UpdateTopDivider_IIII (IntPtr jnienv, IntPtr native__this, int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopDivider (topInsetLeft, topInsetRight, topDividerHeight, topDividerColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateTopDivider' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("updateTopDivider", "(IIII)V", "GetUpdateTopDivider_IIIIHandler")]
		public virtual unsafe void UpdateTopDivider (int topInsetLeft, int topInsetRight, int topDividerHeight, int topDividerColor)
		{
			const string __id = "updateTopDivider.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (topInsetLeft);
				__args [1] = new JniArgumentValue (topInsetRight);
				__args [2] = new JniArgumentValue (topDividerHeight);
				__args [3] = new JniArgumentValue (topDividerColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateTopSeparatorColor_I;
#pragma warning disable 0169
		static Delegate GetUpdateTopSeparatorColor_IHandler ()
		{
			if (cb_updateTopSeparatorColor_I == null)
				cb_updateTopSeparatorColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_UpdateTopSeparatorColor_I);
			return cb_updateTopSeparatorColor_I;
		}

		static void n_UpdateTopSeparatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopSeparatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUIBasicTabSegment']/method[@name='updateTopSeparatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateTopSeparatorColor", "(I)V", "GetUpdateTopSeparatorColor_IHandler")]
		public virtual unsafe void UpdateTopSeparatorColor (int color)
		{
			const string __id = "updateTopSeparatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.DoubleTapEventArgs> DoubleTap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						__CreateIOnTabSelectedListenerImplementor,
						AddOnTabSelectedListener,
						__h => __h.OnDoubleTapHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor.__IsEmpty,
						__v => RemoveOnTabSelectedListener (__v),
						__h => __h.OnDoubleTapHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.TabReselectedEventArgs> TabReselected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						__CreateIOnTabSelectedListenerImplementor,
						AddOnTabSelectedListener,
						__h => __h.OnTabReselectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor.__IsEmpty,
						__v => RemoveOnTabSelectedListener (__v),
						__h => __h.OnTabReselectedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.TabSelectedEventArgs> TabSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						__CreateIOnTabSelectedListenerImplementor,
						AddOnTabSelectedListener,
						__h => __h.OnTabSelectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor.__IsEmpty,
						__v => RemoveOnTabSelectedListener (__v),
						__h => __h.OnTabSelectedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.TabUnselectedEventArgs> TabUnselected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						__CreateIOnTabSelectedListenerImplementor,
						AddOnTabSelectedListener,
						__h => __h.OnTabUnselectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor>(
						ref weak_implementor_AddOnTabSelectedListener,
						global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor.__IsEmpty,
						__v => RemoveOnTabSelectedListener (__v),
						__h => __h.OnTabUnselectedHandler -= value);
			}
		}

		WeakReference weak_implementor_AddOnTabSelectedListener;

		global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor __CreateIOnTabSelectedListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabSelectedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.TabClickEventArgs> TabClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListenerImplementor>(
						ref weak_implementor_SetOnTabClickListener,
						__CreateIOnTabClickListenerImplementor,
						SetOnTabClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListener, global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListenerImplementor>(
						ref weak_implementor_SetOnTabClickListener,
						global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListenerImplementor.__IsEmpty,
						__v => SetOnTabClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTabClickListener;

		global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListenerImplementor __CreateIOnTabClickListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment.IOnTabClickListenerImplementor (this);
		}
#endregion
	}
}
