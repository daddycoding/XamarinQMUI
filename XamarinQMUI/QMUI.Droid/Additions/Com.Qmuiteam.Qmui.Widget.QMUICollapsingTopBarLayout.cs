using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout", DoNotGenerateAcw=true)]
	public partial class QMUICollapsingTopBarLayout : global::Android.Widget.FrameLayout, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinDispatchInterceptor, global::Com.Qmuiteam.Qmui.Widget.IWindowInsetLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Widget.FrameLayout.LayoutParams {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/field[@name='COLLAPSE_MODE_OFF']"
			[Register ("COLLAPSE_MODE_OFF")]
			public const int CollapseModeOff = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/field[@name='COLLAPSE_MODE_PARALLAX']"
			[Register ("COLLAPSE_MODE_PARALLAX")]
			public const int CollapseModeParallax = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/field[@name='COLLAPSE_MODE_PIN']"
			[Register ("COLLAPSE_MODE_PIN")]
			public const int CollapseModePin = (int) 1;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$LayoutParams", typeof (LayoutParams));
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

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/constructor[@name='QMUICollapsingTopBarLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams (global::Android.Content.Context c, global::Android.Util.IAttributeSet attrs)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
					__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (c);
					global::System.GC.KeepAlive (attrs);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/constructor[@name='QMUICollapsingTopBarLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.LayoutParams p)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$LayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/constructor[@name='QMUICollapsingTopBarLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.MarginLayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.MarginLayoutParams source)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$MarginLayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (source);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/constructor[@name='QMUICollapsingTopBarLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.widget.FrameLayout.LayoutParams']]"
			[Register (".ctor", "(Landroid/widget/FrameLayout$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Widget.FrameLayout.LayoutParams source)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/widget/FrameLayout$LayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (source);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/constructor[@name='QMUICollapsingTopBarLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe LayoutParams (int width, int height)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/constructor[@name='QMUICollapsingTopBarLayout.LayoutParams' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(III)V", "")]
			public unsafe LayoutParams (int width, int height, int gravity)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (gravity);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getCollapseMode;
#pragma warning disable 0169
			static Delegate GetGetCollapseModeHandler ()
			{
				if (cb_getCollapseMode == null)
					cb_getCollapseMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCollapseMode);
				return cb_getCollapseMode;
			}

			static int n_GetCollapseMode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CollapseMode;
			}
#pragma warning restore 0169

			static Delegate cb_setCollapseMode_I;
#pragma warning disable 0169
			static Delegate GetSetCollapseMode_IHandler ()
			{
				if (cb_setCollapseMode_I == null)
					cb_setCollapseMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCollapseMode_I);
				return cb_setCollapseMode_I;
			}

			static void n_SetCollapseMode_I (IntPtr jnienv, IntPtr native__this, int collapseMode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CollapseMode = collapseMode;
			}
#pragma warning restore 0169

			public virtual unsafe int CollapseMode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/method[@name='getCollapseMode' and count(parameter)=0]"
				[Register ("getCollapseMode", "()I", "GetGetCollapseModeHandler")]
				get {
					const string __id = "getCollapseMode.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/method[@name='setCollapseMode' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setCollapseMode", "(I)V", "GetSetCollapseMode_IHandler")]
				set {
					const string __id = "setCollapseMode.(I)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			static Delegate cb_getParallaxMultiplier;
#pragma warning disable 0169
			static Delegate GetGetParallaxMultiplierHandler ()
			{
				if (cb_getParallaxMultiplier == null)
					cb_getParallaxMultiplier = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetParallaxMultiplier);
				return cb_getParallaxMultiplier;
			}

			static float n_GetParallaxMultiplier (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ParallaxMultiplier;
			}
#pragma warning restore 0169

			static Delegate cb_setParallaxMultiplier_F;
#pragma warning disable 0169
			static Delegate GetSetParallaxMultiplier_FHandler ()
			{
				if (cb_setParallaxMultiplier_F == null)
					cb_setParallaxMultiplier_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetParallaxMultiplier_F);
				return cb_setParallaxMultiplier_F;
			}

			static void n_SetParallaxMultiplier_F (IntPtr jnienv, IntPtr native__this, float multiplier)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ParallaxMultiplier = multiplier;
			}
#pragma warning restore 0169

			public virtual unsafe float ParallaxMultiplier {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/method[@name='getParallaxMultiplier' and count(parameter)=0]"
				[Register ("getParallaxMultiplier", "()F", "GetGetParallaxMultiplierHandler")]
				get {
					const string __id = "getParallaxMultiplier.()F";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout.LayoutParams']/method[@name='setParallaxMultiplier' and count(parameter)=1 and parameter[1][@type='float']]"
				[Register ("setParallaxMultiplier", "(F)V", "GetSetParallaxMultiplier_FHandler")]
				set {
					const string __id = "setParallaxMultiplier.(F)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUICollapsingTopBarLayout.OnOffsetUpdateListener']"
		[Register ("com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$OnOffsetUpdateListener", "", "Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout/IOnOffsetUpdateListenerInvoker")]
		public partial interface IOnOffsetUpdateListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUICollapsingTopBarLayout.OnOffsetUpdateListener']/method[@name='onOffsetChanged' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUICollapsingTopBarLayout'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
			[Register ("onOffsetChanged", "(Lcom/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout;IF)V", "GetOnOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IFHandler:Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout/IOnOffsetUpdateListenerInvoker, QMUI.Droid")]
			void OnOffsetChanged (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout layout, int offset, float expandFraction);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$OnOffsetUpdateListener", DoNotGenerateAcw=true)]
		internal partial class IOnOffsetUpdateListenerInvoker : global::Java.Lang.Object, IOnOffsetUpdateListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$OnOffsetUpdateListener", typeof (IOnOffsetUpdateListenerInvoker));

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

			public static IOnOffsetUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnOffsetUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUICollapsingTopBarLayout.OnOffsetUpdateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnOffsetUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF;
#pragma warning disable 0169
			static Delegate GetOnOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IFHandler ()
			{
				if (cb_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF == null)
					cb_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIF_V) n_OnOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF);
				return cb_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF;
			}

			static void n_OnOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF (IntPtr jnienv, IntPtr native__this, IntPtr native_layout, int offset, float expandFraction)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var layout = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
				__this.OnOffsetChanged (layout, offset, expandFraction);
			}
#pragma warning restore 0169

			IntPtr id_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF;
			public unsafe void OnOffsetChanged (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout layout, int offset, float expandFraction)
			{
				if (id_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF == IntPtr.Zero)
					id_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF = JNIEnv.GetMethodID (class_ref, "onOffsetChanged", "(Lcom/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout;IF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (expandFraction);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOffsetChanged_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_IF, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.QMUICollapsingTopBarLayout.OnOffsetUpdateListener.onOffsetChanged
		public partial class OffsetUpdateEventArgs : global::System.EventArgs {

			public OffsetUpdateEventArgs (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout layout, int offset, float expandFraction)
			{
				this.layout = layout;
				this.offset = offset;
				this.expandFraction = expandFraction;
			}

			global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout layout;
			public global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout Layout {
				get { return layout; }
			}

			int offset;
			public int Offset {
				get { return offset; }
			}

			float expandFraction;
			public float ExpandFraction {
				get { return expandFraction; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout_OnOffsetUpdateListenerImplementor")]
		internal sealed partial class IOnOffsetUpdateListenerImplementor : global::Java.Lang.Object, IOnOffsetUpdateListener {

			object sender;

			public IOnOffsetUpdateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout_OnOffsetUpdateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<OffsetUpdateEventArgs> Handler;
#pragma warning restore 0649

			public void OnOffsetChanged (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout layout, int offset, float expandFraction)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new OffsetUpdateEventArgs (layout, offset, expandFraction));
			}

			internal static bool __IsEmpty (IOnOffsetUpdateListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout", typeof (QMUICollapsingTopBarLayout));
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

		protected QMUICollapsingTopBarLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/constructor[@name='QMUICollapsingTopBarLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUICollapsingTopBarLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/constructor[@name='QMUICollapsingTopBarLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUICollapsingTopBarLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/constructor[@name='QMUICollapsingTopBarLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUICollapsingTopBarLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getCollapsedTitleGravity;
#pragma warning disable 0169
		static Delegate GetGetCollapsedTitleGravityHandler ()
		{
			if (cb_getCollapsedTitleGravity == null)
				cb_getCollapsedTitleGravity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCollapsedTitleGravity);
			return cb_getCollapsedTitleGravity;
		}

		static int n_GetCollapsedTitleGravity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CollapsedTitleGravity;
		}
#pragma warning restore 0169

		static Delegate cb_setCollapsedTitleGravity_I;
#pragma warning disable 0169
		static Delegate GetSetCollapsedTitleGravity_IHandler ()
		{
			if (cb_setCollapsedTitleGravity_I == null)
				cb_setCollapsedTitleGravity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCollapsedTitleGravity_I);
			return cb_setCollapsedTitleGravity_I;
		}

		static void n_SetCollapsedTitleGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CollapsedTitleGravity = gravity;
		}
#pragma warning restore 0169

		public virtual unsafe int CollapsedTitleGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getCollapsedTitleGravity' and count(parameter)=0]"
			[Register ("getCollapsedTitleGravity", "()I", "GetGetCollapsedTitleGravityHandler")]
			get {
				const string __id = "getCollapsedTitleGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setCollapsedTitleGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCollapsedTitleGravity", "(I)V", "GetSetCollapsedTitleGravity_IHandler")]
			set {
				const string __id = "setCollapsedTitleGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCollapsedTitleTypeface;
#pragma warning disable 0169
		static Delegate GetGetCollapsedTitleTypefaceHandler ()
		{
			if (cb_getCollapsedTitleTypeface == null)
				cb_getCollapsedTitleTypeface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCollapsedTitleTypeface);
			return cb_getCollapsedTitleTypeface;
		}

		static IntPtr n_GetCollapsedTitleTypeface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CollapsedTitleTypeface);
		}
#pragma warning restore 0169

		static Delegate cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetCollapsedTitleTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_ == null)
				cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCollapsedTitleTypeface_Landroid_graphics_Typeface_);
			return cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetCollapsedTitleTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
			__this.CollapsedTitleTypeface = typeface;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface CollapsedTitleTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getCollapsedTitleTypeface' and count(parameter)=0]"
			[Register ("getCollapsedTitleTypeface", "()Landroid/graphics/Typeface;", "GetGetCollapsedTitleTypefaceHandler")]
			get {
				const string __id = "getCollapsedTitleTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setCollapsedTitleTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setCollapsedTitleTypeface", "(Landroid/graphics/Typeface;)V", "GetSetCollapsedTitleTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				const string __id = "setCollapsedTitleTypeface.(Landroid/graphics/Typeface;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getContentScrim;
#pragma warning disable 0169
		static Delegate GetGetContentScrimHandler ()
		{
			if (cb_getContentScrim == null)
				cb_getContentScrim = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentScrim);
			return cb_getContentScrim;
		}

		static IntPtr n_GetContentScrim (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentScrim);
		}
#pragma warning restore 0169

		static Delegate cb_setContentScrim_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetContentScrim_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setContentScrim_Landroid_graphics_drawable_Drawable_ == null)
				cb_setContentScrim_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContentScrim_Landroid_graphics_drawable_Drawable_);
			return cb_setContentScrim_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetContentScrim_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.ContentScrim = drawable;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable ContentScrim {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getContentScrim' and count(parameter)=0]"
			[Register ("getContentScrim", "()Landroid/graphics/drawable/Drawable;", "GetGetContentScrimHandler")]
			get {
				const string __id = "getContentScrim.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setContentScrim' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setContentScrim", "(Landroid/graphics/drawable/Drawable;)V", "GetSetContentScrim_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setContentScrim.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getExpandedTitleGravity;
#pragma warning disable 0169
		static Delegate GetGetExpandedTitleGravityHandler ()
		{
			if (cb_getExpandedTitleGravity == null)
				cb_getExpandedTitleGravity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetExpandedTitleGravity);
			return cb_getExpandedTitleGravity;
		}

		static int n_GetExpandedTitleGravity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpandedTitleGravity;
		}
#pragma warning restore 0169

		static Delegate cb_setExpandedTitleGravity_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleGravity_IHandler ()
		{
			if (cb_setExpandedTitleGravity_I == null)
				cb_setExpandedTitleGravity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTitleGravity_I);
			return cb_setExpandedTitleGravity_I;
		}

		static void n_SetExpandedTitleGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpandedTitleGravity = gravity;
		}
#pragma warning restore 0169

		public virtual unsafe int ExpandedTitleGravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getExpandedTitleGravity' and count(parameter)=0]"
			[Register ("getExpandedTitleGravity", "()I", "GetGetExpandedTitleGravityHandler")]
			get {
				const string __id = "getExpandedTitleGravity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpandedTitleGravity", "(I)V", "GetSetExpandedTitleGravity_IHandler")]
			set {
				const string __id = "setExpandedTitleGravity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpandedTitleMarginBottom;
#pragma warning disable 0169
		static Delegate GetGetExpandedTitleMarginBottomHandler ()
		{
			if (cb_getExpandedTitleMarginBottom == null)
				cb_getExpandedTitleMarginBottom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetExpandedTitleMarginBottom);
			return cb_getExpandedTitleMarginBottom;
		}

		static int n_GetExpandedTitleMarginBottom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpandedTitleMarginBottom;
		}
#pragma warning restore 0169

		static Delegate cb_setExpandedTitleMarginBottom_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleMarginBottom_IHandler ()
		{
			if (cb_setExpandedTitleMarginBottom_I == null)
				cb_setExpandedTitleMarginBottom_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTitleMarginBottom_I);
			return cb_setExpandedTitleMarginBottom_I;
		}

		static void n_SetExpandedTitleMarginBottom_I (IntPtr jnienv, IntPtr native__this, int margin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpandedTitleMarginBottom = margin;
		}
#pragma warning restore 0169

		public virtual unsafe int ExpandedTitleMarginBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getExpandedTitleMarginBottom' and count(parameter)=0]"
			[Register ("getExpandedTitleMarginBottom", "()I", "GetGetExpandedTitleMarginBottomHandler")]
			get {
				const string __id = "getExpandedTitleMarginBottom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleMarginBottom' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpandedTitleMarginBottom", "(I)V", "GetSetExpandedTitleMarginBottom_IHandler")]
			set {
				const string __id = "setExpandedTitleMarginBottom.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpandedTitleMarginEnd;
#pragma warning disable 0169
		static Delegate GetGetExpandedTitleMarginEndHandler ()
		{
			if (cb_getExpandedTitleMarginEnd == null)
				cb_getExpandedTitleMarginEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetExpandedTitleMarginEnd);
			return cb_getExpandedTitleMarginEnd;
		}

		static int n_GetExpandedTitleMarginEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpandedTitleMarginEnd;
		}
#pragma warning restore 0169

		static Delegate cb_setExpandedTitleMarginEnd_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleMarginEnd_IHandler ()
		{
			if (cb_setExpandedTitleMarginEnd_I == null)
				cb_setExpandedTitleMarginEnd_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTitleMarginEnd_I);
			return cb_setExpandedTitleMarginEnd_I;
		}

		static void n_SetExpandedTitleMarginEnd_I (IntPtr jnienv, IntPtr native__this, int margin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpandedTitleMarginEnd = margin;
		}
#pragma warning restore 0169

		public virtual unsafe int ExpandedTitleMarginEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getExpandedTitleMarginEnd' and count(parameter)=0]"
			[Register ("getExpandedTitleMarginEnd", "()I", "GetGetExpandedTitleMarginEndHandler")]
			get {
				const string __id = "getExpandedTitleMarginEnd.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleMarginEnd' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpandedTitleMarginEnd", "(I)V", "GetSetExpandedTitleMarginEnd_IHandler")]
			set {
				const string __id = "setExpandedTitleMarginEnd.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpandedTitleMarginStart;
#pragma warning disable 0169
		static Delegate GetGetExpandedTitleMarginStartHandler ()
		{
			if (cb_getExpandedTitleMarginStart == null)
				cb_getExpandedTitleMarginStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetExpandedTitleMarginStart);
			return cb_getExpandedTitleMarginStart;
		}

		static int n_GetExpandedTitleMarginStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpandedTitleMarginStart;
		}
#pragma warning restore 0169

		static Delegate cb_setExpandedTitleMarginStart_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleMarginStart_IHandler ()
		{
			if (cb_setExpandedTitleMarginStart_I == null)
				cb_setExpandedTitleMarginStart_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTitleMarginStart_I);
			return cb_setExpandedTitleMarginStart_I;
		}

		static void n_SetExpandedTitleMarginStart_I (IntPtr jnienv, IntPtr native__this, int margin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpandedTitleMarginStart = margin;
		}
#pragma warning restore 0169

		public virtual unsafe int ExpandedTitleMarginStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getExpandedTitleMarginStart' and count(parameter)=0]"
			[Register ("getExpandedTitleMarginStart", "()I", "GetGetExpandedTitleMarginStartHandler")]
			get {
				const string __id = "getExpandedTitleMarginStart.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleMarginStart' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpandedTitleMarginStart", "(I)V", "GetSetExpandedTitleMarginStart_IHandler")]
			set {
				const string __id = "setExpandedTitleMarginStart.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpandedTitleMarginTop;
#pragma warning disable 0169
		static Delegate GetGetExpandedTitleMarginTopHandler ()
		{
			if (cb_getExpandedTitleMarginTop == null)
				cb_getExpandedTitleMarginTop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetExpandedTitleMarginTop);
			return cb_getExpandedTitleMarginTop;
		}

		static int n_GetExpandedTitleMarginTop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpandedTitleMarginTop;
		}
#pragma warning restore 0169

		static Delegate cb_setExpandedTitleMarginTop_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleMarginTop_IHandler ()
		{
			if (cb_setExpandedTitleMarginTop_I == null)
				cb_setExpandedTitleMarginTop_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTitleMarginTop_I);
			return cb_setExpandedTitleMarginTop_I;
		}

		static void n_SetExpandedTitleMarginTop_I (IntPtr jnienv, IntPtr native__this, int margin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpandedTitleMarginTop = margin;
		}
#pragma warning restore 0169

		public virtual unsafe int ExpandedTitleMarginTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getExpandedTitleMarginTop' and count(parameter)=0]"
			[Register ("getExpandedTitleMarginTop", "()I", "GetGetExpandedTitleMarginTopHandler")]
			get {
				const string __id = "getExpandedTitleMarginTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleMarginTop' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpandedTitleMarginTop", "(I)V", "GetSetExpandedTitleMarginTop_IHandler")]
			set {
				const string __id = "setExpandedTitleMarginTop.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpandedTitleTypeface;
#pragma warning disable 0169
		static Delegate GetGetExpandedTitleTypefaceHandler ()
		{
			if (cb_getExpandedTitleTypeface == null)
				cb_getExpandedTitleTypeface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExpandedTitleTypeface);
			return cb_getExpandedTitleTypeface;
		}

		static IntPtr n_GetExpandedTitleTypeface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpandedTitleTypeface);
		}
#pragma warning restore 0169

		static Delegate cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_ == null)
				cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExpandedTitleTypeface_Landroid_graphics_Typeface_);
			return cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetExpandedTitleTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
			__this.ExpandedTitleTypeface = typeface;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface ExpandedTitleTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getExpandedTitleTypeface' and count(parameter)=0]"
			[Register ("getExpandedTitleTypeface", "()Landroid/graphics/Typeface;", "GetGetExpandedTitleTypefaceHandler")]
			get {
				const string __id = "getExpandedTitleTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setExpandedTitleTypeface", "(Landroid/graphics/Typeface;)V", "GetSetExpandedTitleTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				const string __id = "setExpandedTitleTypeface.(Landroid/graphics/Typeface;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getScrimAnimationDuration;
#pragma warning disable 0169
		static Delegate GetGetScrimAnimationDurationHandler ()
		{
			if (cb_getScrimAnimationDuration == null)
				cb_getScrimAnimationDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetScrimAnimationDuration);
			return cb_getScrimAnimationDuration;
		}

		static long n_GetScrimAnimationDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrimAnimationDuration;
		}
#pragma warning restore 0169

		static Delegate cb_setScrimAnimationDuration_J;
#pragma warning disable 0169
		static Delegate GetSetScrimAnimationDuration_JHandler ()
		{
			if (cb_setScrimAnimationDuration_J == null)
				cb_setScrimAnimationDuration_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetScrimAnimationDuration_J);
			return cb_setScrimAnimationDuration_J;
		}

		static void n_SetScrimAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long duration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrimAnimationDuration = duration;
		}
#pragma warning restore 0169

		public virtual unsafe long ScrimAnimationDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getScrimAnimationDuration' and count(parameter)=0]"
			[Register ("getScrimAnimationDuration", "()J", "GetGetScrimAnimationDurationHandler")]
			get {
				const string __id = "getScrimAnimationDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setScrimAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setScrimAnimationDuration", "(J)V", "GetSetScrimAnimationDuration_JHandler")]
			set {
				const string __id = "setScrimAnimationDuration.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScrimVisibleHeightTrigger;
#pragma warning disable 0169
		static Delegate GetGetScrimVisibleHeightTriggerHandler ()
		{
			if (cb_getScrimVisibleHeightTrigger == null)
				cb_getScrimVisibleHeightTrigger = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScrimVisibleHeightTrigger);
			return cb_getScrimVisibleHeightTrigger;
		}

		static int n_GetScrimVisibleHeightTrigger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrimVisibleHeightTrigger;
		}
#pragma warning restore 0169

		static Delegate cb_setScrimVisibleHeightTrigger_I;
#pragma warning disable 0169
		static Delegate GetSetScrimVisibleHeightTrigger_IHandler ()
		{
			if (cb_setScrimVisibleHeightTrigger_I == null)
				cb_setScrimVisibleHeightTrigger_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetScrimVisibleHeightTrigger_I);
			return cb_setScrimVisibleHeightTrigger_I;
		}

		static void n_SetScrimVisibleHeightTrigger_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrimVisibleHeightTrigger = height;
		}
#pragma warning restore 0169

		public virtual unsafe int ScrimVisibleHeightTrigger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getScrimVisibleHeightTrigger' and count(parameter)=0]"
			[Register ("getScrimVisibleHeightTrigger", "()I", "GetGetScrimVisibleHeightTriggerHandler")]
			get {
				const string __id = "getScrimVisibleHeightTrigger.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setScrimVisibleHeightTrigger' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScrimVisibleHeightTrigger", "(I)V", "GetSetScrimVisibleHeightTrigger_IHandler")]
			set {
				const string __id = "setScrimVisibleHeightTrigger.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatusBarScrim;
#pragma warning disable 0169
		static Delegate GetGetStatusBarScrimHandler ()
		{
			if (cb_getStatusBarScrim == null)
				cb_getStatusBarScrim = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatusBarScrim);
			return cb_getStatusBarScrim;
		}

		static IntPtr n_GetStatusBarScrim (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StatusBarScrim);
		}
#pragma warning restore 0169

		static Delegate cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetStatusBarScrim_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_ == null)
				cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStatusBarScrim_Landroid_graphics_drawable_Drawable_);
			return cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetStatusBarScrim_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.StatusBarScrim = drawable;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable StatusBarScrim {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getStatusBarScrim' and count(parameter)=0]"
			[Register ("getStatusBarScrim", "()Landroid/graphics/drawable/Drawable;", "GetGetStatusBarScrimHandler")]
			get {
				const string __id = "getStatusBarScrim.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setStatusBarScrim' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setStatusBarScrim", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStatusBarScrim_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setStatusBarScrim.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static void n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_title, JniHandleOwnership.DoNotTransfer);
			__this.TitleFormatted = title;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence TitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set {
				const string __id = "setTitle.(Ljava/lang/CharSequence;)V";
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public string Title {
			get { return TitleFormatted == null ? null : TitleFormatted.ToString (); }
			set {
				var jls = value == null ? null : new global::Java.Lang.String (value);
				TitleFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_isTitleEnabled;
#pragma warning disable 0169
		static Delegate GetIsTitleEnabledHandler ()
		{
			if (cb_isTitleEnabled == null)
				cb_isTitleEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTitleEnabled);
			return cb_isTitleEnabled;
		}

		static bool n_IsTitleEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TitleEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setTitleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTitleEnabled_ZHandler ()
		{
			if (cb_setTitleEnabled_Z == null)
				cb_setTitleEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTitleEnabled_Z);
			return cb_setTitleEnabled_Z;
		}

		static void n_SetTitleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TitleEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool TitleEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='isTitleEnabled' and count(parameter)=0]"
			[Register ("isTitleEnabled", "()Z", "GetIsTitleEnabledHandler")]
			get {
				const string __id = "isTitleEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setTitleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTitleEnabled", "(Z)V", "GetSetTitleEnabled_ZHandler")]
			set {
				const string __id = "setTitleEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_;
#pragma warning disable 0169
		static Delegate GetAddOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_Handler ()
		{
			if (cb_addOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_ == null)
				cb_addOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_);
			return cb_addOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_;
		}

		static void n_AddOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddOnOffsetUpdateListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='addOnOffsetUpdateListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUICollapsingTopBarLayout.OnOffsetUpdateListener']]"
		[Register ("addOnOffsetUpdateListener", "(Lcom/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$OnOffsetUpdateListener;)V", "GetAddOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_Handler")]
		public virtual unsafe void AddOnOffsetUpdateListener (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener listener)
		{
			const string __id = "addOnOffsetUpdateListener.(Lcom/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$OnOffsetUpdateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler ()
		{
			if (cb_applySystemWindowInsets19_Landroid_graphics_Rect_ == null)
				cb_applySystemWindowInsets19_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ApplySystemWindowInsets19_Landroid_graphics_Rect_);
			return cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
		}

		static bool n_ApplySystemWindowInsets19_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_insets, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ApplySystemWindowInsets19 (insets);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='applySystemWindowInsets19' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("applySystemWindowInsets19", "(Landroid/graphics/Rect;)Z", "GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler")]
		public virtual unsafe bool ApplySystemWindowInsets19 (global::Android.Graphics.Rect insets)
		{
			const string __id = "applySystemWindowInsets19.(Landroid/graphics/Rect;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

		static Delegate cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler ()
		{
			if (cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ == null)
				cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_);
			return cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
		}

		static IntPtr n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (native_insets, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplySystemWindowInsets21 (insets));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='applySystemWindowInsets21' and count(parameter)=1 and parameter[1][@type='androidx.core.view.WindowInsetsCompat']]"
		[Register ("applySystemWindowInsets21", "(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", "GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler")]
		public virtual unsafe global::AndroidX.Core.View.WindowInsetsCompat ApplySystemWindowInsets21 (global::AndroidX.Core.View.WindowInsetsCompat insets)
		{
			const string __id = "applySystemWindowInsets21.(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

		static Delegate cb_followTopBarCommonSkin;
#pragma warning disable 0169
		static Delegate GetFollowTopBarCommonSkinHandler ()
		{
			if (cb_followTopBarCommonSkin == null)
				cb_followTopBarCommonSkin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FollowTopBarCommonSkin);
			return cb_followTopBarCommonSkin;
		}

		static void n_FollowTopBarCommonSkin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FollowTopBarCommonSkin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='followTopBarCommonSkin' and count(parameter)=0]"
		[Register ("followTopBarCommonSkin", "()V", "GetFollowTopBarCommonSkinHandler")]
		public virtual unsafe void FollowTopBarCommonSkin ()
		{
			const string __id = "followTopBarCommonSkin.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_intercept_ILandroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetIntercept_ILandroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_intercept_ILandroid_content_res_Resources_Theme_ == null)
				cb_intercept_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_Intercept_ILandroid_content_res_Resources_Theme_);
			return cb_intercept_ILandroid_content_res_Resources_Theme_;
		}

		static bool n_Intercept_ILandroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, int skinIndex, IntPtr native_theme)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Intercept (skinIndex, theme);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='intercept' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.res.Resources.Theme']]"
		[Register ("intercept", "(ILandroid/content/res/Resources$Theme;)Z", "GetIntercept_ILandroid_content_res_Resources_Theme_Handler")]
		public virtual unsafe bool Intercept (int skinIndex, global::Android.Content.Res.Resources.Theme theme)
		{
			const string __id = "intercept.(ILandroid/content/res/Resources$Theme;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (skinIndex);
				__args [1] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (theme);
			}
		}

		static Delegate cb_removeOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_Handler ()
		{
			if (cb_removeOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_ == null)
				cb_removeOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_);
			return cb_removeOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_;
		}

		static void n_RemoveOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnOffsetUpdateListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='removeOnOffsetUpdateListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUICollapsingTopBarLayout.OnOffsetUpdateListener']]"
		[Register ("removeOnOffsetUpdateListener", "(Lcom/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$OnOffsetUpdateListener;)V", "GetRemoveOnOffsetUpdateListener_Lcom_qmuiteam_qmui_widget_QMUICollapsingTopBarLayout_OnOffsetUpdateListener_Handler")]
		public virtual unsafe void RemoveOnOffsetUpdateListener (global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener listener)
		{
			const string __id = "removeOnOffsetUpdateListener.(Lcom/qmuiteam/qmui/widget/QMUICollapsingTopBarLayout$OnOffsetUpdateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setCollapsedTextColorSkinAttr_I;
#pragma warning disable 0169
		static Delegate GetSetCollapsedTextColorSkinAttr_IHandler ()
		{
			if (cb_setCollapsedTextColorSkinAttr_I == null)
				cb_setCollapsedTextColorSkinAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCollapsedTextColorSkinAttr_I);
			return cb_setCollapsedTextColorSkinAttr_I;
		}

		static void n_SetCollapsedTextColorSkinAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCollapsedTextColorSkinAttr (attr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setCollapsedTextColorSkinAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCollapsedTextColorSkinAttr", "(I)V", "GetSetCollapsedTextColorSkinAttr_IHandler")]
		public virtual unsafe void SetCollapsedTextColorSkinAttr (int attr)
		{
			const string __id = "setCollapsedTextColorSkinAttr.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCollapsedTitleTextAppearance_I;
#pragma warning disable 0169
		static Delegate GetSetCollapsedTitleTextAppearance_IHandler ()
		{
			if (cb_setCollapsedTitleTextAppearance_I == null)
				cb_setCollapsedTitleTextAppearance_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCollapsedTitleTextAppearance_I);
			return cb_setCollapsedTitleTextAppearance_I;
		}

		static void n_SetCollapsedTitleTextAppearance_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCollapsedTitleTextAppearance (resId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setCollapsedTitleTextAppearance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCollapsedTitleTextAppearance", "(I)V", "GetSetCollapsedTitleTextAppearance_IHandler")]
		public virtual unsafe void SetCollapsedTitleTextAppearance (int resId)
		{
			const string __id = "setCollapsedTitleTextAppearance.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_ == null)
				cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_);
			return cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.SetCollapsedTitleTextColor (colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setCollapsedTitleTextColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setCollapsedTitleTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetCollapsedTitleTextColor (global::Android.Content.Res.ColorStateList colors)
		{
			const string __id = "setCollapsedTitleTextColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colors == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colors).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (colors);
			}
		}

		static Delegate cb_setCollapsedTitleTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetCollapsedTitleTextColor_IHandler ()
		{
			if (cb_setCollapsedTitleTextColor_I == null)
				cb_setCollapsedTitleTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCollapsedTitleTextColor_I);
			return cb_setCollapsedTitleTextColor_I;
		}

		static void n_SetCollapsedTitleTextColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCollapsedTitleTextColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setCollapsedTitleTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCollapsedTitleTextColor", "(I)V", "GetSetCollapsedTitleTextColor_IHandler")]
		public virtual unsafe void SetCollapsedTitleTextColor (int color)
		{
			const string __id = "setCollapsedTitleTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setContentScrimColor_I;
#pragma warning disable 0169
		static Delegate GetSetContentScrimColor_IHandler ()
		{
			if (cb_setContentScrimColor_I == null)
				cb_setContentScrimColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetContentScrimColor_I);
			return cb_setContentScrimColor_I;
		}

		static void n_SetContentScrimColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentScrimColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setContentScrimColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentScrimColor", "(I)V", "GetSetContentScrimColor_IHandler")]
		public virtual unsafe void SetContentScrimColor (int color)
		{
			const string __id = "setContentScrimColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setContentScrimResource_I;
#pragma warning disable 0169
		static Delegate GetSetContentScrimResource_IHandler ()
		{
			if (cb_setContentScrimResource_I == null)
				cb_setContentScrimResource_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetContentScrimResource_I);
			return cb_setContentScrimResource_I;
		}

		static void n_SetContentScrimResource_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentScrimResource (resId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setContentScrimResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentScrimResource", "(I)V", "GetSetContentScrimResource_IHandler")]
		public virtual unsafe void SetContentScrimResource (int resId)
		{
			const string __id = "setContentScrimResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setContentScrimSkinAttr_I;
#pragma warning disable 0169
		static Delegate GetSetContentScrimSkinAttr_IHandler ()
		{
			if (cb_setContentScrimSkinAttr_I == null)
				cb_setContentScrimSkinAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetContentScrimSkinAttr_I);
			return cb_setContentScrimSkinAttr_I;
		}

		static void n_SetContentScrimSkinAttr_I (IntPtr jnienv, IntPtr native__this, int contentScrimSkinAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentScrimSkinAttr (contentScrimSkinAttr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setContentScrimSkinAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentScrimSkinAttr", "(I)V", "GetSetContentScrimSkinAttr_IHandler")]
		public virtual unsafe void SetContentScrimSkinAttr (int contentScrimSkinAttr)
		{
			const string __id = "setContentScrimSkinAttr.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (contentScrimSkinAttr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setExpandedTextColorSkinAttr_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTextColorSkinAttr_IHandler ()
		{
			if (cb_setExpandedTextColorSkinAttr_I == null)
				cb_setExpandedTextColorSkinAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTextColorSkinAttr_I);
			return cb_setExpandedTextColorSkinAttr_I;
		}

		static void n_SetExpandedTextColorSkinAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpandedTextColorSkinAttr (attr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTextColorSkinAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExpandedTextColorSkinAttr", "(I)V", "GetSetExpandedTextColorSkinAttr_IHandler")]
		public virtual unsafe void SetExpandedTextColorSkinAttr (int attr)
		{
			const string __id = "setExpandedTextColorSkinAttr.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setExpandedTitleColor_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleColor_IHandler ()
		{
			if (cb_setExpandedTitleColor_I == null)
				cb_setExpandedTitleColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTitleColor_I);
			return cb_setExpandedTitleColor_I;
		}

		static void n_SetExpandedTitleColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpandedTitleColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExpandedTitleColor", "(I)V", "GetSetExpandedTitleColor_IHandler")]
		public virtual unsafe void SetExpandedTitleColor (int color)
		{
			const string __id = "setExpandedTitleColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setExpandedTitleMargin_IIII;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleMargin_IIIIHandler ()
		{
			if (cb_setExpandedTitleMargin_IIII == null)
				cb_setExpandedTitleMargin_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_SetExpandedTitleMargin_IIII);
			return cb_setExpandedTitleMargin_IIII;
		}

		static void n_SetExpandedTitleMargin_IIII (IntPtr jnienv, IntPtr native__this, int start, int top, int end, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpandedTitleMargin (start, top, end, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleMargin' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setExpandedTitleMargin", "(IIII)V", "GetSetExpandedTitleMargin_IIIIHandler")]
		public virtual unsafe void SetExpandedTitleMargin (int start, int top, int end, int bottom)
		{
			const string __id = "setExpandedTitleMargin.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (end);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setExpandedTitleTextAppearance_I;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleTextAppearance_IHandler ()
		{
			if (cb_setExpandedTitleTextAppearance_I == null)
				cb_setExpandedTitleTextAppearance_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetExpandedTitleTextAppearance_I);
			return cb_setExpandedTitleTextAppearance_I;
		}

		static void n_SetExpandedTitleTextAppearance_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpandedTitleTextAppearance (resId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleTextAppearance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExpandedTitleTextAppearance", "(I)V", "GetSetExpandedTitleTextAppearance_IHandler")]
		public virtual unsafe void SetExpandedTitleTextAppearance (int resId)
		{
			const string __id = "setExpandedTitleTextAppearance.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetExpandedTitleTextColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_ == null)
				cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExpandedTitleTextColor_Landroid_content_res_ColorStateList_);
			return cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetExpandedTitleTextColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.SetExpandedTitleTextColor (colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setExpandedTitleTextColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setExpandedTitleTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetExpandedTitleTextColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetExpandedTitleTextColor (global::Android.Content.Res.ColorStateList colors)
		{
			const string __id = "setExpandedTitleTextColor.(Landroid/content/res/ColorStateList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colors == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colors).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (colors);
			}
		}

		static Delegate cb_setScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_;
#pragma warning disable 0169
		static Delegate GetSetScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_Handler ()
		{
			if (cb_setScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_ == null)
				cb_setScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_);
			return cb_setScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_;
		}

		static void n_SetScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scrimUpdateListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scrimUpdateListener = (global::Android.Animation.ValueAnimator.IAnimatorUpdateListener)global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator.IAnimatorUpdateListener> (native_scrimUpdateListener, JniHandleOwnership.DoNotTransfer);
			__this.SetScrimUpdateListener (scrimUpdateListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setScrimUpdateListener' and count(parameter)=1 and parameter[1][@type='android.animation.ValueAnimator.AnimatorUpdateListener']]"
		[Register ("setScrimUpdateListener", "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V", "GetSetScrimUpdateListener_Landroid_animation_ValueAnimator_AnimatorUpdateListener_Handler")]
		public virtual unsafe void SetScrimUpdateListener (global::Android.Animation.ValueAnimator.IAnimatorUpdateListener scrimUpdateListener)
		{
			const string __id = "setScrimUpdateListener.(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scrimUpdateListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scrimUpdateListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (scrimUpdateListener);
			}
		}

		static Delegate cb_setScrimsShown_Z;
#pragma warning disable 0169
		static Delegate GetSetScrimsShown_ZHandler ()
		{
			if (cb_setScrimsShown_Z == null)
				cb_setScrimsShown_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetScrimsShown_Z);
			return cb_setScrimsShown_Z;
		}

		static void n_SetScrimsShown_Z (IntPtr jnienv, IntPtr native__this, bool shown)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrimsShown (shown);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setScrimsShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScrimsShown", "(Z)V", "GetSetScrimsShown_ZHandler")]
		public virtual unsafe void SetScrimsShown (bool shown)
		{
			const string __id = "setScrimsShown.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shown);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScrimsShown_ZZ;
#pragma warning disable 0169
		static Delegate GetSetScrimsShown_ZZHandler ()
		{
			if (cb_setScrimsShown_ZZ == null)
				cb_setScrimsShown_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZ_V) n_SetScrimsShown_ZZ);
			return cb_setScrimsShown_ZZ;
		}

		static void n_SetScrimsShown_ZZ (IntPtr jnienv, IntPtr native__this, bool shown, bool animate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrimsShown (shown, animate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setScrimsShown' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("setScrimsShown", "(ZZ)V", "GetSetScrimsShown_ZZHandler")]
		public virtual unsafe void SetScrimsShown (bool shown, bool animate)
		{
			const string __id = "setScrimsShown.(ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (shown);
				__args [1] = new JniArgumentValue (animate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStatusBarScrimColor_I;
#pragma warning disable 0169
		static Delegate GetSetStatusBarScrimColor_IHandler ()
		{
			if (cb_setStatusBarScrimColor_I == null)
				cb_setStatusBarScrimColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStatusBarScrimColor_I);
			return cb_setStatusBarScrimColor_I;
		}

		static void n_SetStatusBarScrimColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusBarScrimColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setStatusBarScrimColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatusBarScrimColor", "(I)V", "GetSetStatusBarScrimColor_IHandler")]
		public virtual unsafe void SetStatusBarScrimColor (int color)
		{
			const string __id = "setStatusBarScrimColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStatusBarScrimResource_I;
#pragma warning disable 0169
		static Delegate GetSetStatusBarScrimResource_IHandler ()
		{
			if (cb_setStatusBarScrimResource_I == null)
				cb_setStatusBarScrimResource_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStatusBarScrimResource_I);
			return cb_setStatusBarScrimResource_I;
		}

		static void n_SetStatusBarScrimResource_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusBarScrimResource (resId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setStatusBarScrimResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatusBarScrimResource", "(I)V", "GetSetStatusBarScrimResource_IHandler")]
		public virtual unsafe void SetStatusBarScrimResource (int resId)
		{
			const string __id = "setStatusBarScrimResource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStatusBarScrimSkinAttr_I;
#pragma warning disable 0169
		static Delegate GetSetStatusBarScrimSkinAttr_IHandler ()
		{
			if (cb_setStatusBarScrimSkinAttr_I == null)
				cb_setStatusBarScrimSkinAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStatusBarScrimSkinAttr_I);
			return cb_setStatusBarScrimSkinAttr_I;
		}

		static void n_SetStatusBarScrimSkinAttr_I (IntPtr jnienv, IntPtr native__this, int statusBarScrimSkinAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusBarScrimSkinAttr (statusBarScrimSkinAttr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUICollapsingTopBarLayout']/method[@name='setStatusBarScrimSkinAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatusBarScrimSkinAttr", "(I)V", "GetSetStatusBarScrimSkinAttr_IHandler")]
		public virtual unsafe void SetStatusBarScrimSkinAttr (int statusBarScrimSkinAttr)
		{
			const string __id = "setStatusBarScrimSkinAttr.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (statusBarScrimSkinAttr);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.OffsetUpdateEventArgs> OffsetUpdate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener, global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListenerImplementor>(
						ref weak_implementor_AddOnOffsetUpdateListener,
						__CreateIOnOffsetUpdateListenerImplementor,
						AddOnOffsetUpdateListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListener, global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListenerImplementor>(
						ref weak_implementor_AddOnOffsetUpdateListener,
						global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListenerImplementor.__IsEmpty,
						__v => RemoveOnOffsetUpdateListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnOffsetUpdateListener;

		global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListenerImplementor __CreateIOnOffsetUpdateListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.QMUICollapsingTopBarLayout.IOnOffsetUpdateListenerImplementor (this);
		}
#endregion
	}
}
