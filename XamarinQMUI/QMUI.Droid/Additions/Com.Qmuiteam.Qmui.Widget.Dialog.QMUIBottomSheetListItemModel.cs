using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheetListItemModel : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel", typeof (QMUIBottomSheetListItemModel));
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

		protected QMUIBottomSheetListItemModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/constructor[@name='QMUIBottomSheetListItemModel' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/CharSequence;Ljava/lang/String;)V", "")]
		public unsafe QMUIBottomSheetListItemModel (global::Java.Lang.ICharSequence text, string tag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_tag);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (text);
			}
		}

		[Register (".ctor", "(Ljava/lang/CharSequence;Ljava/lang/String;)V", "")]
		public unsafe QMUIBottomSheetListItemModel (string text, string tag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_tag);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (text);
			}
		}

		static Delegate cb_disabled_Z;
#pragma warning disable 0169
		static Delegate GetDisabled_ZHandler ()
		{
			if (cb_disabled_Z == null)
				cb_disabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Disabled_Z);
			return cb_disabled_Z;
		}

		static IntPtr n_Disabled_Z (IntPtr jnienv, IntPtr native__this, bool isDisabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disabled (isDisabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='disabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disabled", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetDisabled_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel Disabled (bool isDisabled)
		{
			const string __id = "disabled.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isDisabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_image_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_image_Landroid_graphics_drawable_Drawable_ == null)
				cb_image_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Image_Landroid_graphics_drawable_Drawable_);
			return cb_image_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_Image_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Image (image));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='image' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("image", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel Image (global::Android.Graphics.Drawables.Drawable image)
		{
			const string __id = "image.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

		static Delegate cb_image_I;
#pragma warning disable 0169
		static Delegate GetImage_IHandler ()
		{
			if (cb_image_I == null)
				cb_image_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Image_I);
			return cb_image_I;
		}

		static IntPtr n_Image_I (IntPtr jnienv, IntPtr native__this, int imageRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image (imageRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='image' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("image", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetImage_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel Image (int imageRes)
		{
			const string __id = "image.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_redPoint_Z;
#pragma warning disable 0169
		static Delegate GetRedPoint_ZHandler ()
		{
			if (cb_redPoint_Z == null)
				cb_redPoint_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_RedPoint_Z);
			return cb_redPoint_Z;
		}

		static IntPtr n_RedPoint_Z (IntPtr jnienv, IntPtr native__this, bool hasRedPoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RedPoint (hasRedPoint));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='redPoint' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("redPoint", "(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetRedPoint_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel RedPoint (bool hasRedPoint)
		{
			const string __id = "redPoint.(Z)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (hasRedPoint);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinImageSrcAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinImageSrcAttr_IHandler ()
		{
			if (cb_skinImageSrcAttr_I == null)
				cb_skinImageSrcAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinImageSrcAttr_I);
			return cb_skinImageSrcAttr_I;
		}

		static IntPtr n_SkinImageSrcAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinImageSrcAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='skinImageSrcAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinImageSrcAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetSkinImageSrcAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel SkinImageSrcAttr (int attr)
		{
			const string __id = "skinImageSrcAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinImageTintColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinImageTintColorAttr_IHandler ()
		{
			if (cb_skinImageTintColorAttr_I == null)
				cb_skinImageTintColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinImageTintColorAttr_I);
			return cb_skinImageTintColorAttr_I;
		}

		static IntPtr n_SkinImageTintColorAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinImageTintColorAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='skinImageTintColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinImageTintColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetSkinImageTintColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel SkinImageTintColorAttr (int attr)
		{
			const string __id = "skinImageTintColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinTextColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinTextColorAttr_IHandler ()
		{
			if (cb_skinTextColorAttr_I == null)
				cb_skinTextColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinTextColorAttr_I);
			return cb_skinTextColorAttr_I;
		}

		static IntPtr n_SkinTextColorAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinTextColorAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='skinTextColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinTextColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetSkinTextColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel SkinTextColorAttr (int attr)
		{
			const string __id = "skinTextColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Typeface (typeface));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetListItemModel']/method[@name='typeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("typeface", "(Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;", "GetTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel Typeface (global::Android.Graphics.Typeface typeface)
		{
			const string __id = "typeface.(Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetListItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetListItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (typeface);
			}
		}

	}
}
