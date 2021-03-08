using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.RecyclerView {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUISwipeAction", DoNotGenerateAcw=true)]
	public partial class QMUISwipeAction : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder", DoNotGenerateAcw=true)]
		public partial class ActionBuilder : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/field[@name='HORIZONTAL']"
			[Register ("HORIZONTAL")]
			public const int Horizontal = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/field[@name='VERTICAL']"
			[Register ("VERTICAL")]
			public const int Vertical = (int) 1;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder", typeof (ActionBuilder));
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

			protected ActionBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/constructor[@name='QMUISwipeAction.ActionBuilder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ActionBuilder ()
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

			static Delegate cb_backgroundColor_I;
#pragma warning disable 0169
			static Delegate GetBackgroundColor_IHandler ()
			{
				if (cb_backgroundColor_I == null)
					cb_backgroundColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_BackgroundColor_I);
				return cb_backgroundColor_I;
			}

			static IntPtr n_BackgroundColor_I (IntPtr jnienv, IntPtr native__this, int backgroundColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BackgroundColor (backgroundColor));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='backgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("backgroundColor", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetBackgroundColor_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder BackgroundColor (int backgroundColor)
			{
				const string __id = "backgroundColor.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (backgroundColor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_backgroundColorAttr_I;
#pragma warning disable 0169
			static Delegate GetBackgroundColorAttr_IHandler ()
			{
				if (cb_backgroundColorAttr_I == null)
					cb_backgroundColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_BackgroundColorAttr_I);
				return cb_backgroundColorAttr_I;
			}

			static IntPtr n_BackgroundColorAttr_I (IntPtr jnienv, IntPtr native__this, int backgroundColorAttr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BackgroundColorAttr (backgroundColorAttr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='backgroundColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("backgroundColorAttr", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetBackgroundColorAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder BackgroundColorAttr (int backgroundColorAttr)
			{
				const string __id = "backgroundColorAttr.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (backgroundColorAttr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction;", "GetBuildHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction Build ()
			{
				const string __id = "build.()Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_icon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetIcon_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_icon_Landroid_graphics_drawable_Drawable_ == null)
					cb_icon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Icon_Landroid_graphics_drawable_Drawable_);
				return cb_icon_Landroid_graphics_drawable_Drawable_;
			}

			static IntPtr n_Icon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Icon (drawable));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("icon", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder Icon (global::Android.Graphics.Drawables.Drawable drawable)
			{
				const string __id = "icon.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (drawable);
				}
			}

			static Delegate cb_iconAttr_I;
#pragma warning disable 0169
			static Delegate GetIconAttr_IHandler ()
			{
				if (cb_iconAttr_I == null)
					cb_iconAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_IconAttr_I);
				return cb_iconAttr_I;
			}

			static IntPtr n_IconAttr_I (IntPtr jnienv, IntPtr native__this, int iconAttr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IconAttr (iconAttr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='iconAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("iconAttr", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetIconAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder IconAttr (int iconAttr)
			{
				const string __id = "iconAttr.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (iconAttr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_iconTextGap_I;
#pragma warning disable 0169
			static Delegate GetIconTextGap_IHandler ()
			{
				if (cb_iconTextGap_I == null)
					cb_iconTextGap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_IconTextGap_I);
				return cb_iconTextGap_I;
			}

			static IntPtr n_IconTextGap_I (IntPtr jnienv, IntPtr native__this, int iconTextGap)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IconTextGap (iconTextGap));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='iconTextGap' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("iconTextGap", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetIconTextGap_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder IconTextGap (int iconTextGap)
			{
				const string __id = "iconTextGap.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (iconTextGap);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_orientation_I;
#pragma warning disable 0169
			static Delegate GetOrientation_IHandler ()
			{
				if (cb_orientation_I == null)
					cb_orientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Orientation_I);
				return cb_orientation_I;
			}

			static IntPtr n_Orientation_I (IntPtr jnienv, IntPtr native__this, int orientation)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Orientation (orientation));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='orientation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("orientation", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetOrientation_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder Orientation (int orientation)
			{
				const string __id = "orientation.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (orientation);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_paddingStartEnd_I;
#pragma warning disable 0169
			static Delegate GetPaddingStartEnd_IHandler ()
			{
				if (cb_paddingStartEnd_I == null)
					cb_paddingStartEnd_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_PaddingStartEnd_I);
				return cb_paddingStartEnd_I;
			}

			static IntPtr n_PaddingStartEnd_I (IntPtr jnienv, IntPtr native__this, int paddingStartEnd)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PaddingStartEnd (paddingStartEnd));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='paddingStartEnd' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("paddingStartEnd", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetPaddingStartEnd_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder PaddingStartEnd (int paddingStartEnd)
			{
				const string __id = "paddingStartEnd.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (paddingStartEnd);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_reverseDrawOrder_Z;
#pragma warning disable 0169
			static Delegate GetReverseDrawOrder_ZHandler ()
			{
				if (cb_reverseDrawOrder_Z == null)
					cb_reverseDrawOrder_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ReverseDrawOrder_Z);
				return cb_reverseDrawOrder_Z;
			}

			static IntPtr n_ReverseDrawOrder_Z (IntPtr jnienv, IntPtr native__this, bool reverse)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ReverseDrawOrder (reverse));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='reverseDrawOrder' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("reverseDrawOrder", "(Z)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetReverseDrawOrder_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder ReverseDrawOrder (bool reverse)
			{
				const string __id = "reverseDrawOrder.(Z)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (reverse);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_swipeDirectionMinSize_I;
#pragma warning disable 0169
			static Delegate GetSwipeDirectionMinSize_IHandler ()
			{
				if (cb_swipeDirectionMinSize_I == null)
					cb_swipeDirectionMinSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SwipeDirectionMinSize_I);
				return cb_swipeDirectionMinSize_I;
			}

			static IntPtr n_SwipeDirectionMinSize_I (IntPtr jnienv, IntPtr native__this, int minSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SwipeDirectionMinSize (minSize));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='swipeDirectionMinSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swipeDirectionMinSize", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetSwipeDirectionMinSize_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder SwipeDirectionMinSize (int minSize)
			{
				const string __id = "swipeDirectionMinSize.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (minSize);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_swipeMoveInterpolator_Landroid_animation_TimeInterpolator_;
#pragma warning disable 0169
			static Delegate GetSwipeMoveInterpolator_Landroid_animation_TimeInterpolator_Handler ()
			{
				if (cb_swipeMoveInterpolator_Landroid_animation_TimeInterpolator_ == null)
					cb_swipeMoveInterpolator_Landroid_animation_TimeInterpolator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SwipeMoveInterpolator_Landroid_animation_TimeInterpolator_);
				return cb_swipeMoveInterpolator_Landroid_animation_TimeInterpolator_;
			}

			static IntPtr n_SwipeMoveInterpolator_Landroid_animation_TimeInterpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interpolator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var interpolator = (global::Android.Animation.ITimeInterpolator)global::Java.Lang.Object.GetObject<global::Android.Animation.ITimeInterpolator> (native_interpolator, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SwipeMoveInterpolator (interpolator));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='swipeMoveInterpolator' and count(parameter)=1 and parameter[1][@type='android.animation.TimeInterpolator']]"
			[Register ("swipeMoveInterpolator", "(Landroid/animation/TimeInterpolator;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetSwipeMoveInterpolator_Landroid_animation_TimeInterpolator_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder SwipeMoveInterpolator (global::Android.Animation.ITimeInterpolator interpolator)
			{
				const string __id = "swipeMoveInterpolator.(Landroid/animation/TimeInterpolator;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (interpolator);
				}
			}

			static Delegate cb_swipePxPerMS_I;
#pragma warning disable 0169
			static Delegate GetSwipePxPerMS_IHandler ()
			{
				if (cb_swipePxPerMS_I == null)
					cb_swipePxPerMS_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SwipePxPerMS_I);
				return cb_swipePxPerMS_I;
			}

			static IntPtr n_SwipePxPerMS_I (IntPtr jnienv, IntPtr native__this, int swipePxPerMS)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SwipePxPerMS (swipePxPerMS));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='swipePxPerMS' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swipePxPerMS", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetSwipePxPerMS_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder SwipePxPerMS (int swipePxPerMS)
			{
				const string __id = "swipePxPerMS.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swipePxPerMS);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_text_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetText_Ljava_lang_String_Handler ()
			{
				if (cb_text_Ljava_lang_String_ == null)
					cb_text_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Text_Ljava_lang_String_);
				return cb_text_Ljava_lang_String_;
			}

			static IntPtr n_Text_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Text (text));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='text' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("text", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetText_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder Text (string text)
			{
				const string __id = "text.(Ljava/lang/String;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				IntPtr native_text = JNIEnv.NewString (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

			static Delegate cb_textColor_I;
#pragma warning disable 0169
			static Delegate GetTextColor_IHandler ()
			{
				if (cb_textColor_I == null)
					cb_textColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextColor_I);
				return cb_textColor_I;
			}

			static IntPtr n_TextColor_I (IntPtr jnienv, IntPtr native__this, int textColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextColor (textColor));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='textColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textColor", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetTextColor_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder TextColor (int textColor)
			{
				const string __id = "textColor.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (textColor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_textColorAttr_I;
#pragma warning disable 0169
			static Delegate GetTextColorAttr_IHandler ()
			{
				if (cb_textColorAttr_I == null)
					cb_textColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextColorAttr_I);
				return cb_textColorAttr_I;
			}

			static IntPtr n_TextColorAttr_I (IntPtr jnienv, IntPtr native__this, int textColorAttr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextColorAttr (textColorAttr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='textColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textColorAttr", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetTextColorAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder TextColorAttr (int textColorAttr)
			{
				const string __id = "textColorAttr.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (textColorAttr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_textSize_I;
#pragma warning disable 0169
			static Delegate GetTextSize_IHandler ()
			{
				if (cb_textSize_I == null)
					cb_textSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_TextSize_I);
				return cb_textSize_I;
			}

			static IntPtr n_TextSize_I (IntPtr jnienv, IntPtr native__this, int textSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextSize (textSize));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='textSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textSize", "(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetTextSize_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder TextSize (int textSize)
			{
				const string __id = "textSize.(I)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (textSize);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_typeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
			static Delegate GetTypeface_Landroid_graphics_Typeface_Handler ()
			{
				if (cb_typeface_Landroid_graphics_Typeface_ == null)
					cb_typeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Typeface_Landroid_graphics_Typeface_);
				return cb_typeface_Landroid_graphics_Typeface_;
			}

			static IntPtr n_Typeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Typeface (typeface));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='typeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("typeface", "(Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetTypeface_Landroid_graphics_Typeface_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder Typeface (global::Android.Graphics.Typeface typeface)
			{
				const string __id = "typeface.(Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (typeface);
				}
			}

			static Delegate cb_useIconTint_Z;
#pragma warning disable 0169
			static Delegate GetUseIconTint_ZHandler ()
			{
				if (cb_useIconTint_Z == null)
					cb_useIconTint_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_UseIconTint_Z);
				return cb_useIconTint_Z;
			}

			static IntPtr n_UseIconTint_Z (IntPtr jnienv, IntPtr native__this, bool useIconTint)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.UseIconTint (useIconTint));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction.ActionBuilder']/method[@name='useIconTint' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("useIconTint", "(Z)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;", "GetUseIconTint_ZHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder UseIconTint (bool useIconTint)
			{
				const string __id = "useIconTint.(Z)Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction$ActionBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useIconTint);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction.ActionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUISwipeAction", typeof (QMUISwipeAction));
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

		protected QMUISwipeAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static int n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				const string __id = "getBackgroundColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBackgroundColorAttr;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorAttrHandler ()
		{
			if (cb_getBackgroundColorAttr == null)
				cb_getBackgroundColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBackgroundColorAttr);
			return cb_getBackgroundColorAttr;
		}

		static int n_GetBackgroundColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int BackgroundColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getBackgroundColorAttr' and count(parameter)=0]"
			[Register ("getBackgroundColorAttr", "()I", "GetGetBackgroundColorAttrHandler")]
			get {
				const string __id = "getBackgroundColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconAttr;
#pragma warning disable 0169
		static Delegate GetGetIconAttrHandler ()
		{
			if (cb_getIconAttr == null)
				cb_getIconAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIconAttr);
			return cb_getIconAttr;
		}

		static int n_GetIconAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int IconAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getIconAttr' and count(parameter)=0]"
			[Register ("getIconAttr", "()I", "GetGetIconAttrHandler")]
			get {
				const string __id = "getIconAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIconTextGap;
#pragma warning disable 0169
		static Delegate GetGetIconTextGapHandler ()
		{
			if (cb_getIconTextGap == null)
				cb_getIconTextGap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIconTextGap);
			return cb_getIconTextGap;
		}

		static int n_GetIconTextGap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconTextGap;
		}
#pragma warning restore 0169

		public virtual unsafe int IconTextGap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getIconTextGap' and count(parameter)=0]"
			[Register ("getIconTextGap", "()I", "GetGetIconTextGapHandler")]
			get {
				const string __id = "getIconTextGap.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUseIconTint;
#pragma warning disable 0169
		static Delegate GetIsUseIconTintHandler ()
		{
			if (cb_isUseIconTint == null)
				cb_isUseIconTint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseIconTint);
			return cb_isUseIconTint;
		}

		static bool n_IsUseIconTint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUseIconTint;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUseIconTint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='isUseIconTint' and count(parameter)=0]"
			[Register ("isUseIconTint", "()Z", "GetIsUseIconTintHandler")]
			get {
				const string __id = "isUseIconTint.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				const string __id = "getOrientation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingStartEnd;
#pragma warning disable 0169
		static Delegate GetGetPaddingStartEndHandler ()
		{
			if (cb_getPaddingStartEnd == null)
				cb_getPaddingStartEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPaddingStartEnd);
			return cb_getPaddingStartEnd;
		}

		static int n_GetPaddingStartEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PaddingStartEnd;
		}
#pragma warning restore 0169

		public virtual unsafe int PaddingStartEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getPaddingStartEnd' and count(parameter)=0]"
			[Register ("getPaddingStartEnd", "()I", "GetGetPaddingStartEndHandler")]
			get {
				const string __id = "getPaddingStartEnd.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSwipeDirectionMiniSize;
#pragma warning disable 0169
		static Delegate GetGetSwipeDirectionMiniSizeHandler ()
		{
			if (cb_getSwipeDirectionMiniSize == null)
				cb_getSwipeDirectionMiniSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSwipeDirectionMiniSize);
			return cb_getSwipeDirectionMiniSize;
		}

		static int n_GetSwipeDirectionMiniSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwipeDirectionMiniSize;
		}
#pragma warning restore 0169

		public virtual unsafe int SwipeDirectionMiniSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getSwipeDirectionMiniSize' and count(parameter)=0]"
			[Register ("getSwipeDirectionMiniSize", "()I", "GetGetSwipeDirectionMiniSizeHandler")]
			get {
				const string __id = "getSwipeDirectionMiniSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTextColor);
			return cb_getTextColor;
		}

		static int n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextColor;
		}
#pragma warning restore 0169

		public virtual unsafe int TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()I", "GetGetTextColorHandler")]
			get {
				const string __id = "getTextColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTextColorAttr;
#pragma warning disable 0169
		static Delegate GetGetTextColorAttrHandler ()
		{
			if (cb_getTextColorAttr == null)
				cb_getTextColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTextColorAttr);
			return cb_getTextColorAttr;
		}

		static int n_GetTextColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int TextColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getTextColorAttr' and count(parameter)=0]"
			[Register ("getTextColorAttr", "()I", "GetGetTextColorAttrHandler")]
			get {
				const string __id = "getTextColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTextSize);
			return cb_getTextSize;
		}

		static int n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSize;
		}
#pragma warning restore 0169

		public virtual unsafe int TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()I", "GetGetTextSizeHandler")]
			get {
				const string __id = "getTextSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				const string __id = "getTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUISwipeAction']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
			}
		}

	}
}
