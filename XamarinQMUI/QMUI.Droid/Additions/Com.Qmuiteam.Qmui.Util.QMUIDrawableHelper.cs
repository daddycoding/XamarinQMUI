using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIDrawableHelper", DoNotGenerateAcw=true)]
	public partial class QMUIDrawableHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIDrawableHelper", typeof (QMUIDrawableHelper));
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

		protected QMUIDrawableHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/constructor[@name='QMUIDrawableHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIDrawableHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='createBitmapFromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("createBitmapFromView", "(Landroid/view/View;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateBitmapFromView (global::Android.Views.View view)
		{
			const string __id = "createBitmapFromView.(Landroid/view/View;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='createBitmapFromView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("createBitmapFromView", "(Landroid/view/View;F)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateBitmapFromView (global::Android.Views.View view, float scale)
		{
			const string __id = "createBitmapFromView.(Landroid/view/View;F)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (scale);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='createBitmapFromView' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("createBitmapFromView", "(Landroid/view/View;IIII)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateBitmapFromView (global::Android.Views.View view, int leftCrop, int topCrop, int rightCrop, int bottomCrop)
		{
			const string __id = "createBitmapFromView.(Landroid/view/View;IIII)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (leftCrop);
				__args [2] = new JniArgumentValue (topCrop);
				__args [3] = new JniArgumentValue (rightCrop);
				__args [4] = new JniArgumentValue (bottomCrop);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='createBitmapSafely' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config'] and parameter[4][@type='int']]"
		[Register ("createBitmapSafely", "(IILandroid/graphics/Bitmap$Config;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateBitmapSafely (int width, int height, global::Android.Graphics.Bitmap.Config config, int retryCount)
		{
			const string __id = "createBitmapSafely.(IILandroid/graphics/Bitmap$Config;I)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [3] = new JniArgumentValue (retryCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='createCircleGradientDrawable' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("createCircleGradientDrawable", "(IIIFF)Landroid/graphics/drawable/GradientDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.GradientDrawable CreateCircleGradientDrawable (int startColor, int endColor, int radius, float centerX, float centerY)
		{
			const string __id = "createCircleGradientDrawable.(IIIFF)Landroid/graphics/drawable/GradientDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (startColor);
				__args [1] = new JniArgumentValue (endColor);
				__args [2] = new JniArgumentValue (radius);
				__args [3] = new JniArgumentValue (centerX);
				__args [4] = new JniArgumentValue (centerY);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.GradientDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='createDrawableWithSize' and count(parameter)=5 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("createDrawableWithSize", "(Landroid/content/res/Resources;IIII)Landroid/graphics/drawable/BitmapDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.BitmapDrawable CreateDrawableWithSize (global::Android.Content.Res.Resources resources, int width, int height, int cornerRadius, int filledColor)
		{
			const string __id = "createDrawableWithSize.(Landroid/content/res/Resources;IIII)Landroid/graphics/drawable/BitmapDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				__args [3] = new JniArgumentValue (cornerRadius);
				__args [4] = new JniArgumentValue (filledColor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.BitmapDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (resources);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='createItemSeparatorBg' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("createItemSeparatorBg", "(IIIZ)Landroid/graphics/drawable/LayerDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.LayerDrawable CreateItemSeparatorBg (int separatorColor, int bgColor, int separatorHeight, bool top)
		{
			const string __id = "createItemSeparatorBg.(IIIZ)Landroid/graphics/drawable/LayerDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (separatorColor);
				__args [1] = new JniArgumentValue (bgColor);
				__args [2] = new JniArgumentValue (separatorHeight);
				__args [3] = new JniArgumentValue (top);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.LayerDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='drawableToBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("drawableToBitmap", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap DrawableToBitmap (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "drawableToBitmap.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drawable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='getVectorDrawable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getVectorDrawable", "(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetVectorDrawable (global::Android.Content.Context context, int resVector)
		{
			const string __id = "getVectorDrawable.(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (resVector);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='setDrawableTintColor' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setDrawableTintColor", "(Landroid/graphics/drawable/Drawable;I)Landroid/graphics/ColorFilter;", "")]
		public static unsafe global::Android.Graphics.ColorFilter SetDrawableTintColor (global::Android.Graphics.Drawables.Drawable drawable, int tintColor)
		{
			const string __id = "setDrawableTintColor.(Landroid/graphics/drawable/Drawable;I)Landroid/graphics/ColorFilter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue (tintColor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drawable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDrawableHelper']/method[@name='vectorDrawableToBitmap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("vectorDrawableToBitmap", "(Landroid/content/Context;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap VectorDrawableToBitmap (global::Android.Content.Context context, int resVector)
		{
			const string __id = "vectorDrawableToBitmap.(Landroid/content/Context;I)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (resVector);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
