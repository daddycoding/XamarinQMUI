using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIViewHelper", DoNotGenerateAcw=true)]
	public partial class QMUIViewHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIViewHelper", typeof (QMUIViewHelper));
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

		protected QMUIViewHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/constructor[@name='QMUIViewHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIViewHelper ()
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

		public static unsafe bool IsLastLineSpacingExtraError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='getIsLastLineSpacingExtraError' and count(parameter)=0]"
			[Register ("getIsLastLineSpacingExtraError", "()Z", "")]
			get {
				const string __id = "getIsLastLineSpacingExtraError.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='calcViewScreenLocation' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("calcViewScreenLocation", "(Landroid/view/View;)Landroid/graphics/Rect;", "")]
		public static unsafe global::Android.Graphics.Rect CalcViewScreenLocation (global::Android.Views.View view)
		{
			const string __id = "calcViewScreenLocation.(Landroid/view/View;)Landroid/graphics/Rect;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='checkAppCompatTheme' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkAppCompatTheme", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckAppCompatTheme (global::Android.Content.Context context)
		{
			const string __id = "checkAppCompatTheme.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='clearValueAnimator' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("clearValueAnimator", "(Landroid/animation/Animator;)V", "")]
		public static unsafe void ClearValueAnimator (global::Android.Animation.Animator animator)
		{
			const string __id = "clearValueAnimator.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animator).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (animator);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='expendTouchArea' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("expendTouchArea", "(Landroid/view/View;I)V", "")]
		public static unsafe void ExpendTouchArea (global::Android.Views.View view, int expendSize)
		{
			const string __id = "expendTouchArea.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (expendSize);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='fadeIn' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.view.animation.Animation.AnimationListener'] and parameter[4][@type='boolean']]"
		[Register ("fadeIn", "(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;Z)Landroid/view/animation/AlphaAnimation;", "")]
		public static unsafe global::Android.Views.Animations.AlphaAnimation FadeIn (global::Android.Views.View view, int duration, global::Android.Views.Animations.Animation.IAnimationListener listener, bool isNeedAnimation)
		{
			const string __id = "fadeIn.(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;Z)Landroid/view/animation/AlphaAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (duration);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue (isNeedAnimation);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.AlphaAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='fadeOut' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.view.animation.Animation.AnimationListener'] and parameter[4][@type='boolean']]"
		[Register ("fadeOut", "(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;Z)Landroid/view/animation/AlphaAnimation;", "")]
		public static unsafe global::Android.Views.Animations.AlphaAnimation FadeOut (global::Android.Views.View view, int duration, global::Android.Views.Animations.Animation.IAnimationListener listener, bool isNeedAnimation)
		{
			const string __id = "fadeOut.(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;Z)Landroid/view/animation/AlphaAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (duration);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue (isNeedAnimation);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.AlphaAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='findViewFromViewStub' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("findViewFromViewStub", "(Landroid/view/View;II)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View FindViewFromViewStub (global::Android.Views.View parentView, int viewStubId, int inflatedViewId)
		{
			const string __id = "findViewFromViewStub.(Landroid/view/View;II)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parentView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentView).Handle);
				__args [1] = new JniArgumentValue (viewStubId);
				__args [2] = new JniArgumentValue (inflatedViewId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parentView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='findViewFromViewStub' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("findViewFromViewStub", "(Landroid/view/View;III)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View FindViewFromViewStub (global::Android.Views.View parentView, int viewStubId, int inflatedViewId, int inflateLayoutResId)
		{
			const string __id = "findViewFromViewStub.(Landroid/view/View;III)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((parentView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentView).Handle);
				__args [1] = new JniArgumentValue (viewStubId);
				__args [2] = new JniArgumentValue (inflatedViewId);
				__args [3] = new JniArgumentValue (inflateLayoutResId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (parentView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='generateViewId' and count(parameter)=0]"
		[Register ("generateViewId", "()I", "")]
		public static unsafe int GenerateViewId ()
		{
			const string __id = "generateViewId.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='getActivityRoot' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getActivityRoot", "(Landroid/app/Activity;)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View GetActivityRoot (global::Android.App.Activity activity)
		{
			const string __id = "getActivityRoot.(Landroid/app/Activity;)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='getDescendantRect' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.graphics.Rect']]"
		[Register ("getDescendantRect", "(Landroid/view/ViewGroup;Landroid/view/View;Landroid/graphics/Rect;)V", "")]
		public static unsafe void GetDescendantRect (global::Android.Views.ViewGroup parent, global::Android.Views.View descendant, global::Android.Graphics.Rect @out)
		{
			const string __id = "getDescendantRect.(Landroid/view/ViewGroup;Landroid/view/View;Landroid/graphics/Rect;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue ((descendant == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descendant).Handle);
				__args [2] = new JniArgumentValue ((@out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @out).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (descendant);
				global::System.GC.KeepAlive (@out);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='getOffsetHelper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getOffsetHelper", "(Landroid/view/View;)Lcom/qmuiteam/qmui/util/QMUIViewOffsetHelper;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Util.QMUIViewOffsetHelper GetOffsetHelper (global::Android.Views.View view)
		{
			const string __id = "getOffsetHelper.(Landroid/view/View;)Lcom/qmuiteam/qmui/util/QMUIViewOffsetHelper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIViewOffsetHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='getOrCreateOffsetHelper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getOrCreateOffsetHelper", "(Landroid/view/View;)Lcom/qmuiteam/qmui/util/QMUIViewOffsetHelper;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Util.QMUIViewOffsetHelper GetOrCreateOffsetHelper (global::Android.Views.View view)
		{
			const string __id = "getOrCreateOffsetHelper.(Landroid/view/View;)Lcom/qmuiteam/qmui/util/QMUIViewOffsetHelper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIViewOffsetHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='isListViewAlreadyAtBottom' and count(parameter)=1 and parameter[1][@type='android.widget.ListView']]"
		[Register ("isListViewAlreadyAtBottom", "(Landroid/widget/ListView;)Z", "")]
		public static unsafe bool IsListViewAlreadyAtBottom (global::Android.Widget.ListView listView)
		{
			const string __id = "isListViewAlreadyAtBottom.(Landroid/widget/ListView;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listView).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (listView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='playBackgroundBlinkAnimation' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("playBackgroundBlinkAnimation", "(Landroid/view/View;I)V", "")]
		public static unsafe void PlayBackgroundBlinkAnimation (global::Android.Views.View v, int bgColor)
		{
			const string __id = "playBackgroundBlinkAnimation.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue (bgColor);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (v);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='playViewBackgroundAnimation' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("playViewBackgroundAnimation", "(Landroid/view/View;IIJ)V", "")]
		public static unsafe void PlayViewBackgroundAnimation (global::Android.Views.View v, int startColor, int endColor, long duration)
		{
			const string __id = "playViewBackgroundAnimation.(Landroid/view/View;IIJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue (startColor);
				__args [2] = new JniArgumentValue (endColor);
				__args [3] = new JniArgumentValue (duration);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (v);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='playViewBackgroundAnimation' and count(parameter)=7 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.Runnable']]"
		[Register ("playViewBackgroundAnimation", "(Landroid/view/View;IIJIILjava/lang/Runnable;)V", "")]
		public static unsafe void PlayViewBackgroundAnimation (global::Android.Views.View v, int startColor, int endColor, long duration, int repeatCount, int setAnimTagId, global::Java.Lang.IRunnable endAction)
		{
			const string __id = "playViewBackgroundAnimation.(Landroid/view/View;IIJIILjava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue (startColor);
				__args [2] = new JniArgumentValue (endColor);
				__args [3] = new JniArgumentValue (duration);
				__args [4] = new JniArgumentValue (repeatCount);
				__args [5] = new JniArgumentValue (setAnimTagId);
				__args [6] = new JniArgumentValue ((endAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endAction).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (v);
				global::System.GC.KeepAlive (endAction);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='playViewBackgroundAnimation' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
		[Register ("playViewBackgroundAnimation", "(Landroid/view/View;I[II)V", "")]
		public static unsafe void PlayViewBackgroundAnimation (global::Android.Views.View v, int bgColor, int[] alphaArray, int stepDuration)
		{
			const string __id = "playViewBackgroundAnimation.(Landroid/view/View;I[II)V";
			IntPtr native_alphaArray = JNIEnv.NewArray (alphaArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue (bgColor);
				__args [2] = new JniArgumentValue (native_alphaArray);
				__args [3] = new JniArgumentValue (stepDuration);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (alphaArray != null) {
					JNIEnv.CopyArray (native_alphaArray, alphaArray);
					JNIEnv.DeleteLocalRef (native_alphaArray);
				}
				global::System.GC.KeepAlive (v);
				global::System.GC.KeepAlive (alphaArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='playViewBackgroundAnimation' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Runnable']]"
		[Register ("playViewBackgroundAnimation", "(Landroid/view/View;I[IILjava/lang/Runnable;)Landroid/animation/Animator;", "")]
		public static unsafe global::Android.Animation.Animator PlayViewBackgroundAnimation (global::Android.Views.View v, int bgColor, int[] alphaArray, int stepDuration, global::Java.Lang.IRunnable endAction)
		{
			const string __id = "playViewBackgroundAnimation.(Landroid/view/View;I[IILjava/lang/Runnable;)Landroid/animation/Animator;";
			IntPtr native_alphaArray = JNIEnv.NewArray (alphaArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue (bgColor);
				__args [2] = new JniArgumentValue (native_alphaArray);
				__args [3] = new JniArgumentValue (stepDuration);
				__args [4] = new JniArgumentValue ((endAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endAction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (alphaArray != null) {
					JNIEnv.CopyArray (native_alphaArray, alphaArray);
					JNIEnv.DeleteLocalRef (native_alphaArray);
				}
				global::System.GC.KeepAlive (v);
				global::System.GC.KeepAlive (alphaArray);
				global::System.GC.KeepAlive (endAction);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='requestApplyInsets' and count(parameter)=1 and parameter[1][@type='android.view.Window']]"
		[Register ("requestApplyInsets", "(Landroid/view/Window;)V", "")]
		public static unsafe void RequestApplyInsets (global::Android.Views.Window window)
		{
			const string __id = "requestApplyInsets.(Landroid/view/Window;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='safeRequestDisallowInterceptTouchEvent' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("safeRequestDisallowInterceptTouchEvent", "(Landroid/view/View;Z)V", "")]
		public static unsafe void SafeRequestDisallowInterceptTouchEvent (global::Android.Views.View view, bool value)
		{
			const string __id = "safeRequestDisallowInterceptTouchEvent.(Landroid/view/View;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='safeSetImageViewSelected' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='boolean']]"
		[Register ("safeSetImageViewSelected", "(Landroid/widget/ImageView;Z)V", "")]
		public static unsafe void SafeSetImageViewSelected (global::Android.Widget.ImageView imageView, bool selected)
		{
			const string __id = "safeSetImageViewSelected.(Landroid/widget/ImageView;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((imageView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageView).Handle);
				__args [1] = new JniArgumentValue (selected);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (imageView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setBackground' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackground", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void SetBackground (global::Android.Views.View view, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setBackground.(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (drawable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setBackgroundColorKeepPadding' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setBackgroundColorKeepPadding", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetBackgroundColorKeepPadding (global::Android.Views.View view, int color)
		{
			const string __id = "setBackgroundColorKeepPadding.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (color);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setBackgroundKeepingPadding' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackgroundKeepingPadding", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void SetBackgroundKeepingPadding (global::Android.Views.View view, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setBackgroundKeepingPadding.(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (drawable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setBackgroundKeepingPadding' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setBackgroundKeepingPadding", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetBackgroundKeepingPadding (global::Android.Views.View view, int backgroundResId)
		{
			const string __id = "setBackgroundKeepingPadding.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (backgroundResId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setImageViewTintColor' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setImageViewTintColor", "(Landroid/widget/ImageView;I)Landroid/graphics/ColorFilter;", "")]
		public static unsafe global::Android.Graphics.ColorFilter SetImageViewTintColor (global::Android.Widget.ImageView imageView, int tintColor)
		{
			const string __id = "setImageViewTintColor.(Landroid/widget/ImageView;I)Landroid/graphics/ColorFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((imageView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageView).Handle);
				__args [1] = new JniArgumentValue (tintColor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (imageView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setPaddingBottom' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setPaddingBottom", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetPaddingBottom (global::Android.Views.View view, int value)
		{
			const string __id = "setPaddingBottom.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setPaddingLeft' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setPaddingLeft", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetPaddingLeft (global::Android.Views.View view, int value)
		{
			const string __id = "setPaddingLeft.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setPaddingRight' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setPaddingRight", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetPaddingRight (global::Android.Views.View view, int value)
		{
			const string __id = "setPaddingRight.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='setPaddingTop' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setPaddingTop", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetPaddingTop (global::Android.Views.View view, int value)
		{
			const string __id = "setPaddingTop.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='slideIn' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.view.animation.Animation.AnimationListener'] and parameter[4][@type='boolean'] and parameter[5][@type='com.qmuiteam.qmui.util.QMUIDirection']]"
		[Register ("slideIn", "(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;ZLcom/qmuiteam/qmui/util/QMUIDirection;)Landroid/view/animation/TranslateAnimation;", "")]
		public static unsafe global::Android.Views.Animations.TranslateAnimation SlideIn (global::Android.Views.View view, int duration, global::Android.Views.Animations.Animation.IAnimationListener listener, bool isNeedAnimation, global::Com.Qmuiteam.Qmui.Util.QMUIDirection direction)
		{
			const string __id = "slideIn.(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;ZLcom/qmuiteam/qmui/util/QMUIDirection;)Landroid/view/animation/TranslateAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (duration);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue (isNeedAnimation);
				__args [4] = new JniArgumentValue ((direction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) direction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.TranslateAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (listener);
				global::System.GC.KeepAlive (direction);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='slideOut' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.view.animation.Animation.AnimationListener'] and parameter[4][@type='boolean'] and parameter[5][@type='com.qmuiteam.qmui.util.QMUIDirection']]"
		[Register ("slideOut", "(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;ZLcom/qmuiteam/qmui/util/QMUIDirection;)Landroid/view/animation/TranslateAnimation;", "")]
		public static unsafe global::Android.Views.Animations.TranslateAnimation SlideOut (global::Android.Views.View view, int duration, global::Android.Views.Animations.Animation.IAnimationListener listener, bool isNeedAnimation, global::Com.Qmuiteam.Qmui.Util.QMUIDirection direction)
		{
			const string __id = "slideOut.(Landroid/view/View;ILandroid/view/animation/Animation$AnimationListener;ZLcom/qmuiteam/qmui/util/QMUIDirection;)Landroid/view/animation/TranslateAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (duration);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue (isNeedAnimation);
				__args [4] = new JniArgumentValue ((direction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) direction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.TranslateAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (listener);
				global::System.GC.KeepAlive (direction);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewHelper']/method[@name='updateChildrenOffsetHelperOnLayout' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("updateChildrenOffsetHelperOnLayout", "(Landroid/view/ViewGroup;)V", "")]
		public static unsafe void UpdateChildrenOffsetHelperOnLayout (global::Android.Views.ViewGroup viewGroup)
		{
			const string __id = "updateChildrenOffsetHelperOnLayout.(Landroid/view/ViewGroup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((viewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewGroup).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (viewGroup);
			}
		}

	}
}
