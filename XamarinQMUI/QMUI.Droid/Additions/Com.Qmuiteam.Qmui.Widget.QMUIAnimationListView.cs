using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIAnimationListView", DoNotGenerateAcw=true)]
	public partial class QMUIAnimationListView : global::Android.Widget.ListView {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/field[@name='mAfterVisible']"
		[Register ("mAfterVisible")]
		protected global::System.Collections.ICollection MAfterVisible {
			get {
				const string __id = "mAfterVisible.Ljava/util/Set;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaSet.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAfterVisible.Ljava/util/Set;";

				IntPtr native_value = global::Android.Runtime.JavaSet.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/field[@name='mBeforeVisible']"
		[Register ("mBeforeVisible")]
		protected global::System.Collections.ICollection MBeforeVisible {
			get {
				const string __id = "mBeforeVisible.Ljava/util/Set;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaSet.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBeforeVisible.Ljava/util/Set;";

				IntPtr native_value = global::Android.Runtime.JavaSet.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/field[@name='mDetachViewsMap']"
		[Register ("mDetachViewsMap")]
		protected global::AndroidX.Collection.LongSparseArray MDetachViewsMap {
			get {
				const string __id = "mDetachViewsMap.Landroidx/collection/LongSparseArray;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.LongSparseArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDetachViewsMap.Landroidx/collection/LongSparseArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/field[@name='mPositionMap']"
		[Register ("mPositionMap")]
		protected global::AndroidX.Collection.LongSparseArray MPositionMap {
			get {
				const string __id = "mPositionMap.Landroidx/collection/LongSparseArray;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.LongSparseArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPositionMap.Landroidx/collection/LongSparseArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/field[@name='mTopMap']"
		[Register ("mTopMap")]
		protected global::AndroidX.Collection.LongSparseArray MTopMap {
			get {
				const string __id = "mTopMap.Landroidx/collection/LongSparseArray;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.LongSparseArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTopMap.Landroidx/collection/LongSparseArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIAnimationListView.Manipulator']"
		[Register ("com/qmuiteam/qmui/widget/QMUIAnimationListView$Manipulator", "", "Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView/IManipulatorInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.widget.ListAdapter"})]
		public partial interface IManipulator : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUIAnimationListView.Manipulator']/method[@name='manipulate' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("manipulate", "(Landroid/widget/ListAdapter;)V", "GetManipulate_Landroid_widget_ListAdapter_Handler:Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView/IManipulatorInvoker, QMUI.Droid")]
			void Manipulate (global::Java.Lang.Object adapter);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIAnimationListView$Manipulator", DoNotGenerateAcw=true)]
		internal partial class IManipulatorInvoker : global::Java.Lang.Object, IManipulator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIAnimationListView$Manipulator", typeof (IManipulatorInvoker));

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

			public static IManipulator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IManipulator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUIAnimationListView.Manipulator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IManipulatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_manipulate_Landroid_widget_ListAdapter_;
#pragma warning disable 0169
			static Delegate GetManipulate_Landroid_widget_ListAdapter_Handler ()
			{
				if (cb_manipulate_Landroid_widget_ListAdapter_ == null)
					cb_manipulate_Landroid_widget_ListAdapter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Manipulate_Landroid_widget_ListAdapter_);
				return cb_manipulate_Landroid_widget_ListAdapter_;
			}

			static void n_Manipulate_Landroid_widget_ListAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView.IManipulator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var adapter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_adapter, JniHandleOwnership.DoNotTransfer);
				__this.Manipulate (adapter);
			}
#pragma warning restore 0169

			IntPtr id_manipulate_Landroid_widget_ListAdapter_;
			public unsafe void Manipulate (global::Java.Lang.Object adapter)
			{
				if (id_manipulate_Landroid_widget_ListAdapter_ == IntPtr.Zero)
					id_manipulate_Landroid_widget_ListAdapter_ = JNIEnv.GetMethodID (class_ref, "manipulate", "(Landroid/widget/ListAdapter;)V");
				IntPtr native_adapter = JNIEnv.ToLocalJniHandle (adapter);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_adapter);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_manipulate_Landroid_widget_ListAdapter_, __args);
				JNIEnv.DeleteLocalRef (native_adapter);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIAnimationListView", typeof (QMUIAnimationListView));
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

		protected QMUIAnimationListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/constructor[@name='QMUIAnimationListView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIAnimationListView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/constructor[@name='QMUIAnimationListView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIAnimationListView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/constructor[@name='QMUIAnimationListView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIAnimationListView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/constructor[@name='QMUIAnimationListView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe QMUIAnimationListView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue (defStyleRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getChangeDisappearDuration;
#pragma warning disable 0169
		static Delegate GetGetChangeDisappearDurationHandler ()
		{
			if (cb_getChangeDisappearDuration == null)
				cb_getChangeDisappearDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetChangeDisappearDuration);
			return cb_getChangeDisappearDuration;
		}

		static long n_GetChangeDisappearDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChangeDisappearDuration;
		}
#pragma warning restore 0169

		protected virtual unsafe long ChangeDisappearDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getChangeDisappearDuration' and count(parameter)=0]"
			[Register ("getChangeDisappearDuration", "()J", "GetGetChangeDisappearDurationHandler")]
			get {
				const string __id = "getChangeDisappearDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOffsetDurationUnit;
#pragma warning disable 0169
		static Delegate GetGetOffsetDurationUnitHandler ()
		{
			if (cb_getOffsetDurationUnit == null)
				cb_getOffsetDurationUnit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetOffsetDurationUnit);
			return cb_getOffsetDurationUnit;
		}

		static float n_GetOffsetDurationUnit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetDurationUnit;
		}
#pragma warning restore 0169

		static Delegate cb_setOffsetDurationUnit_F;
#pragma warning disable 0169
		static Delegate GetSetOffsetDurationUnit_FHandler ()
		{
			if (cb_setOffsetDurationUnit_F == null)
				cb_setOffsetDurationUnit_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetOffsetDurationUnit_F);
			return cb_setOffsetDurationUnit_F;
		}

		static void n_SetOffsetDurationUnit_F (IntPtr jnienv, IntPtr native__this, float offsetDurationUnit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OffsetDurationUnit = offsetDurationUnit;
		}
#pragma warning restore 0169

		public virtual unsafe float OffsetDurationUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getOffsetDurationUnit' and count(parameter)=0]"
			[Register ("getOffsetDurationUnit", "()F", "GetGetOffsetDurationUnitHandler")]
			get {
				const string __id = "getOffsetDurationUnit.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='setOffsetDurationUnit' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setOffsetDurationUnit", "(F)V", "GetSetOffsetDurationUnit_FHandler")]
			set {
				const string __id = "setOffsetDurationUnit.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRealAdapter;
#pragma warning disable 0169
		static Delegate GetGetRealAdapterHandler ()
		{
			if (cb_getRealAdapter == null)
				cb_getRealAdapter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRealAdapter);
			return cb_getRealAdapter;
		}

		static IntPtr n_GetRealAdapter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RealAdapter);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.IListAdapter RealAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getRealAdapter' and count(parameter)=0]"
			[Register ("getRealAdapter", "()Landroid/widget/ListAdapter;", "GetGetRealAdapterHandler")]
			get {
				const string __id = "getRealAdapter.()Landroid/widget/ListAdapter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_alphaObjectAnimator_Landroid_view_View_ZJZ;
#pragma warning disable 0169
		static Delegate GetAlphaObjectAnimator_Landroid_view_View_ZJZHandler ()
		{
			if (cb_alphaObjectAnimator_Landroid_view_View_ZJZ == null)
				cb_alphaObjectAnimator_Landroid_view_View_ZJZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZJZ_L) n_AlphaObjectAnimator_Landroid_view_View_ZJZ);
			return cb_alphaObjectAnimator_Landroid_view_View_ZJZ;
		}

		static IntPtr n_AlphaObjectAnimator_Landroid_view_View_ZJZ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, bool fadeIn, long duration, bool postBack)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AlphaObjectAnimator (view, fadeIn, duration, postBack));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='alphaObjectAnimator' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='boolean']]"
		[Register ("alphaObjectAnimator", "(Landroid/view/View;ZJZ)Landroid/animation/ObjectAnimator;", "GetAlphaObjectAnimator_Landroid_view_View_ZJZHandler")]
		protected virtual unsafe global::Android.Animation.ObjectAnimator AlphaObjectAnimator (global::Android.Views.View view, bool fadeIn, long duration, bool postBack)
		{
			const string __id = "alphaObjectAnimator.(Landroid/view/View;ZJZ)Landroid/animation/ObjectAnimator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (fadeIn);
				__args [2] = new JniArgumentValue (duration);
				__args [3] = new JniArgumentValue (postBack);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_getAddAnimator_Landroid_view_View_IIII;
#pragma warning disable 0169
		static Delegate GetGetAddAnimator_Landroid_view_View_IIIIHandler ()
		{
			if (cb_getAddAnimator_Landroid_view_View_IIII == null)
				cb_getAddAnimator_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIII_L) n_GetAddAnimator_Landroid_view_View_IIII);
			return cb_getAddAnimator_Landroid_view_View_IIII;
		}

		static IntPtr n_GetAddAnimator_Landroid_view_View_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int top, int position, int addOccurTop, int addOccurPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAddAnimator (view, top, position, addOccurTop, addOccurPosition));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getAddAnimator' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getAddAnimator", "(Landroid/view/View;IIII)Landroid/animation/Animator;", "GetGetAddAnimator_Landroid_view_View_IIIIHandler")]
		protected virtual unsafe global::Android.Animation.Animator GetAddAnimator (global::Android.Views.View view, int top, int position, int addOccurTop, int addOccurPosition)
		{
			const string __id = "getAddAnimator.(Landroid/view/View;IIII)Landroid/animation/Animator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (position);
				__args [3] = new JniArgumentValue (addOccurTop);
				__args [4] = new JniArgumentValue (addOccurPosition);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_getDeleteAnimator_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetDeleteAnimator_Landroid_view_View_Handler ()
		{
			if (cb_getDeleteAnimator_Landroid_view_View_ == null)
				cb_getDeleteAnimator_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeleteAnimator_Landroid_view_View_);
			return cb_getDeleteAnimator_Landroid_view_View_;
		}

		static IntPtr n_GetDeleteAnimator_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeleteAnimator (view));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getDeleteAnimator' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getDeleteAnimator", "(Landroid/view/View;)Landroid/animation/Animator;", "GetGetDeleteAnimator_Landroid_view_View_Handler")]
		protected virtual unsafe global::Android.Animation.Animator GetDeleteAnimator (global::Android.Views.View view)
		{
			const string __id = "getDeleteAnimator.(Landroid/view/View;)Landroid/animation/Animator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_getOffsetAnimator_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetGetOffsetAnimator_Landroid_view_View_IIHandler ()
		{
			if (cb_getOffsetAnimator_Landroid_view_View_II == null)
				cb_getOffsetAnimator_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_GetOffsetAnimator_Landroid_view_View_II);
			return cb_getOffsetAnimator_Landroid_view_View_II;
		}

		static IntPtr n_GetOffsetAnimator_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int oldTop, int newTop)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOffsetAnimator (view, oldTop, newTop));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getOffsetAnimator' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getOffsetAnimator", "(Landroid/view/View;II)Landroid/animation/Animator;", "GetGetOffsetAnimator_Landroid_view_View_IIHandler")]
		protected virtual unsafe global::Android.Animation.Animator GetOffsetAnimator (global::Android.Views.View view, int oldTop, int newTop)
		{
			const string __id = "getOffsetAnimator.(Landroid/view/View;II)Landroid/animation/Animator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (oldTop);
				__args [2] = new JniArgumentValue (newTop);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_getOffsetAnimator_Landroid_view_View_IIJ;
#pragma warning disable 0169
		static Delegate GetGetOffsetAnimator_Landroid_view_View_IIJHandler ()
		{
			if (cb_getOffsetAnimator_Landroid_view_View_IIJ == null)
				cb_getOffsetAnimator_Landroid_view_View_IIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIJ_L) n_GetOffsetAnimator_Landroid_view_View_IIJ);
			return cb_getOffsetAnimator_Landroid_view_View_IIJ;
		}

		static IntPtr n_GetOffsetAnimator_Landroid_view_View_IIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int oldTop, int newTop, long duration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOffsetAnimator (view, oldTop, newTop, duration));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getOffsetAnimator' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("getOffsetAnimator", "(Landroid/view/View;IIJ)Landroid/animation/Animator;", "GetGetOffsetAnimator_Landroid_view_View_IIJHandler")]
		protected virtual unsafe global::Android.Animation.Animator GetOffsetAnimator (global::Android.Views.View view, int oldTop, int newTop, long duration)
		{
			const string __id = "getOffsetAnimator.(Landroid/view/View;IIJ)Landroid/animation/Animator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (oldTop);
				__args [2] = new JniArgumentValue (newTop);
				__args [3] = new JniArgumentValue (duration);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_getPositionForId_J;
#pragma warning disable 0169
		static Delegate GetGetPositionForId_JHandler ()
		{
			if (cb_getPositionForId_J == null)
				cb_getPositionForId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_I) n_GetPositionForId_J);
			return cb_getPositionForId_J;
		}

		static int n_GetPositionForId_J (IntPtr jnienv, IntPtr native__this, long id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPositionForId (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='getPositionForId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getPositionForId", "(J)I", "GetGetPositionForId_JHandler")]
		protected virtual unsafe int GetPositionForId (long id)
		{
			const string __id = "getPositionForId.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_manipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_;
#pragma warning disable 0169
		static Delegate GetManipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_Handler ()
		{
			if (cb_manipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_ == null)
				cb_manipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Manipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_);
			return cb_manipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_;
		}

		static void n_Manipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_manipulator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var manipulator = (global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView.IManipulator)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView.IManipulator> (native_manipulator, JniHandleOwnership.DoNotTransfer);
			__this.Manipulate (manipulator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='manipulate' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIAnimationListView.Manipulator&lt;T&gt;']]"
		[Register ("manipulate", "(Lcom/qmuiteam/qmui/widget/QMUIAnimationListView$Manipulator;)V", "GetManipulate_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.widget.ListAdapter"})]
		public virtual unsafe void Manipulate (global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView.IManipulator manipulator)
		{
			const string __id = "manipulate.(Lcom/qmuiteam/qmui/widget/QMUIAnimationListView$Manipulator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((manipulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manipulator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manipulator);
			}
		}

		static Delegate cb_manipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_;
#pragma warning disable 0169
		static Delegate GetManipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_Handler ()
		{
			if (cb_manipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_ == null)
				cb_manipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ManipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_);
			return cb_manipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_;
		}

		static void n_ManipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_manipulator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var manipulator = (global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView.IManipulator)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView.IManipulator> (native_manipulator, JniHandleOwnership.DoNotTransfer);
			__this.ManipulateWithoutAnimation (manipulator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='manipulateWithoutAnimation' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUIAnimationListView.Manipulator&lt;T&gt;']]"
		[Register ("manipulateWithoutAnimation", "(Lcom/qmuiteam/qmui/widget/QMUIAnimationListView$Manipulator;)V", "GetManipulateWithoutAnimation_Lcom_qmuiteam_qmui_widget_QMUIAnimationListView_Manipulator_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.widget.ListAdapter"})]
		public virtual unsafe void ManipulateWithoutAnimation (global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView.IManipulator manipulator)
		{
			const string __id = "manipulateWithoutAnimation.(Lcom/qmuiteam/qmui/widget/QMUIAnimationListView$Manipulator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((manipulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manipulator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manipulator);
			}
		}

		static Delegate cb_setAnimationManipulateDurationLimit_I;
#pragma warning disable 0169
		static Delegate GetSetAnimationManipulateDurationLimit_IHandler ()
		{
			if (cb_setAnimationManipulateDurationLimit_I == null)
				cb_setAnimationManipulateDurationLimit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAnimationManipulateDurationLimit_I);
			return cb_setAnimationManipulateDurationLimit_I;
		}

		static void n_SetAnimationManipulateDurationLimit_I (IntPtr jnienv, IntPtr native__this, int animationManipulateDurationLimit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationManipulateDurationLimit (animationManipulateDurationLimit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='setAnimationManipulateDurationLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimationManipulateDurationLimit", "(I)V", "GetSetAnimationManipulateDurationLimit_IHandler")]
		public virtual unsafe void SetAnimationManipulateDurationLimit (int animationManipulateDurationLimit)
		{
			const string __id = "setAnimationManipulateDurationLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (animationManipulateDurationLimit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOffsetInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetOffsetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setOffsetInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setOffsetInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOffsetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setOffsetInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetOffsetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offsetInterpolator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var offsetInterpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_offsetInterpolator, JniHandleOwnership.DoNotTransfer);
			__this.SetOffsetInterpolator (offsetInterpolator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='setOffsetInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setOffsetInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetOffsetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public virtual unsafe void SetOffsetInterpolator (global::Android.Views.Animations.IInterpolator offsetInterpolator)
		{
			const string __id = "setOffsetInterpolator.(Landroid/view/animation/Interpolator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((offsetInterpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) offsetInterpolator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (offsetInterpolator);
			}
		}

		static Delegate cb_setOpenChangeDisappearAnimation_Z;
#pragma warning disable 0169
		static Delegate GetSetOpenChangeDisappearAnimation_ZHandler ()
		{
			if (cb_setOpenChangeDisappearAnimation_Z == null)
				cb_setOpenChangeDisappearAnimation_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOpenChangeDisappearAnimation_Z);
			return cb_setOpenChangeDisappearAnimation_Z;
		}

		static void n_SetOpenChangeDisappearAnimation_Z (IntPtr jnienv, IntPtr native__this, bool openChangeDisappearAnimation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIAnimationListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOpenChangeDisappearAnimation (openChangeDisappearAnimation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIAnimationListView']/method[@name='setOpenChangeDisappearAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOpenChangeDisappearAnimation", "(Z)V", "GetSetOpenChangeDisappearAnimation_ZHandler")]
		public virtual unsafe void SetOpenChangeDisappearAnimation (bool openChangeDisappearAnimation)
		{
			const string __id = "setOpenChangeDisappearAnimation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (openChangeDisappearAnimation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
