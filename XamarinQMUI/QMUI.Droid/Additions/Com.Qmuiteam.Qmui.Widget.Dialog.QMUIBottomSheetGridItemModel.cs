using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel", DoNotGenerateAcw=true)]
	public partial class QMUIBottomSheetGridItemModel : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel", typeof (QMUIBottomSheetGridItemModel));
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

		protected QMUIBottomSheetGridItemModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/constructor[@name='QMUIBottomSheetGridItemModel' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/CharSequence;Ljava/lang/Object;)V", "")]
		public unsafe QMUIBottomSheetGridItemModel (global::Java.Lang.ICharSequence text, global::Java.Lang.Object tag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (tag);
			}
		}

		[Register (".ctor", "(Ljava/lang/CharSequence;Ljava/lang/Object;)V", "")]
		public unsafe QMUIBottomSheetGridItemModel (string text, global::Java.Lang.Object tag)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/CharSequence;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (tag);
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/drawable/Drawable;", "GetGetImageHandler")]
			get {
				const string __id = "getImage.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageRes;
#pragma warning disable 0169
		static Delegate GetGetImageResHandler ()
		{
			if (cb_getImageRes == null)
				cb_getImageRes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetImageRes);
			return cb_getImageRes;
		}

		static int n_GetImageRes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageRes;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getImageRes' and count(parameter)=0]"
			[Register ("getImageRes", "()I", "GetGetImageResHandler")]
			get {
				const string __id = "getImageRes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageSkinSrcAttr;
#pragma warning disable 0169
		static Delegate GetGetImageSkinSrcAttrHandler ()
		{
			if (cb_getImageSkinSrcAttr == null)
				cb_getImageSkinSrcAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetImageSkinSrcAttr);
			return cb_getImageSkinSrcAttr;
		}

		static int n_GetImageSkinSrcAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageSkinSrcAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageSkinSrcAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getImageSkinSrcAttr' and count(parameter)=0]"
			[Register ("getImageSkinSrcAttr", "()I", "GetGetImageSkinSrcAttrHandler")]
			get {
				const string __id = "getImageSkinSrcAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageSkinTintColorAttr;
#pragma warning disable 0169
		static Delegate GetGetImageSkinTintColorAttrHandler ()
		{
			if (cb_getImageSkinTintColorAttr == null)
				cb_getImageSkinTintColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetImageSkinTintColorAttr);
			return cb_getImageSkinTintColorAttr;
		}

		static int n_GetImageSkinTintColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageSkinTintColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int ImageSkinTintColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getImageSkinTintColorAttr' and count(parameter)=0]"
			[Register ("getImageSkinTintColorAttr", "()I", "GetGetImageSkinTintColorAttrHandler")]
			get {
				const string __id = "getImageSkinTintColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSubscript;
#pragma warning disable 0169
		static Delegate GetGetSubscriptHandler ()
		{
			if (cb_getSubscript == null)
				cb_getSubscript = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscript);
			return cb_getSubscript;
		}

		static IntPtr n_GetSubscript (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Subscript);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable Subscript {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getSubscript' and count(parameter)=0]"
			[Register ("getSubscript", "()Landroid/graphics/drawable/Drawable;", "GetGetSubscriptHandler")]
			get {
				const string __id = "getSubscript.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubscriptRes;
#pragma warning disable 0169
		static Delegate GetGetSubscriptResHandler ()
		{
			if (cb_getSubscriptRes == null)
				cb_getSubscriptRes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSubscriptRes);
			return cb_getSubscriptRes;
		}

		static int n_GetSubscriptRes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscriptRes;
		}
#pragma warning restore 0169

		public virtual unsafe int SubscriptRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getSubscriptRes' and count(parameter)=0]"
			[Register ("getSubscriptRes", "()I", "GetGetSubscriptResHandler")]
			get {
				const string __id = "getSubscriptRes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSubscriptSkinSrcAttr;
#pragma warning disable 0169
		static Delegate GetGetSubscriptSkinSrcAttrHandler ()
		{
			if (cb_getSubscriptSkinSrcAttr == null)
				cb_getSubscriptSkinSrcAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSubscriptSkinSrcAttr);
			return cb_getSubscriptSkinSrcAttr;
		}

		static int n_GetSubscriptSkinSrcAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscriptSkinSrcAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int SubscriptSkinSrcAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getSubscriptSkinSrcAttr' and count(parameter)=0]"
			[Register ("getSubscriptSkinSrcAttr", "()I", "GetGetSubscriptSkinSrcAttrHandler")]
			get {
				const string __id = "getSubscriptSkinSrcAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSubscriptSkinTintColorAttr;
#pragma warning disable 0169
		static Delegate GetGetSubscriptSkinTintColorAttrHandler ()
		{
			if (cb_getSubscriptSkinTintColorAttr == null)
				cb_getSubscriptSkinTintColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSubscriptSkinTintColorAttr);
			return cb_getSubscriptSkinTintColorAttr;
		}

		static int n_GetSubscriptSkinTintColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscriptSkinTintColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int SubscriptSkinTintColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getSubscriptSkinTintColorAttr' and count(parameter)=0]"
			[Register ("getSubscriptSkinTintColorAttr", "()I", "GetGetSubscriptSkinTintColorAttrHandler")]
			get {
				const string __id = "getSubscriptSkinTintColorAttr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tag);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
			get {
				const string __id = "getTag.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TextFormatted);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence TextFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public string Text {
			get { return TextFormatted == null ? null : TextFormatted.ToString (); }
		}

		static Delegate cb_getTextSkinColorAttr;
#pragma warning disable 0169
		static Delegate GetGetTextSkinColorAttrHandler ()
		{
			if (cb_getTextSkinColorAttr == null)
				cb_getTextSkinColorAttr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTextSkinColorAttr);
			return cb_getTextSkinColorAttr;
		}

		static int n_GetTextSkinColorAttr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSkinColorAttr;
		}
#pragma warning restore 0169

		public virtual unsafe int TextSkinColorAttr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getTextSkinColorAttr' and count(parameter)=0]"
			[Register ("getTextSkinColorAttr", "()I", "GetGetTextSkinColorAttrHandler")]
			get {
				const string __id = "getTextSkinColorAttr.()I";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='getTypeface' and count(parameter)=0]"
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

		static Delegate cb_image_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetInvokeImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_image_Landroid_graphics_drawable_Drawable_ == null)
				cb_image_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_InvokeImage_Landroid_graphics_drawable_Drawable_);
			return cb_image_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_InvokeImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeImage (image));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='image' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("image", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetInvokeImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel InvokeImage (global::Android.Graphics.Drawables.Drawable image)
		{
			const string __id = "image.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

		static Delegate cb_image_I;
#pragma warning disable 0169
		static Delegate GetInvokeImage_IHandler ()
		{
			if (cb_image_I == null)
				cb_image_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_InvokeImage_I);
			return cb_image_I;
		}

		static IntPtr n_InvokeImage_I (IntPtr jnienv, IntPtr native__this, int imageRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeImage (imageRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='image' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("image", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetInvokeImage_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel InvokeImage (int imageRes)
		{
			const string __id = "image.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinImageSrcAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='skinImageSrcAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinImageSrcAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetSkinImageSrcAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel SkinImageSrcAttr (int attr)
		{
			const string __id = "skinImageSrcAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinImageTintColorAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='skinImageTintColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinImageTintColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetSkinImageTintColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel SkinImageTintColorAttr (int attr)
		{
			const string __id = "skinImageTintColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinSubscriptSrcAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinSubscriptSrcAttr_IHandler ()
		{
			if (cb_skinSubscriptSrcAttr_I == null)
				cb_skinSubscriptSrcAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinSubscriptSrcAttr_I);
			return cb_skinSubscriptSrcAttr_I;
		}

		static IntPtr n_SkinSubscriptSrcAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinSubscriptSrcAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='skinSubscriptSrcAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinSubscriptSrcAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetSkinSubscriptSrcAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel SkinSubscriptSrcAttr (int attr)
		{
			const string __id = "skinSubscriptSrcAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skinSubscriptTintColorAttr_I;
#pragma warning disable 0169
		static Delegate GetSkinSubscriptTintColorAttr_IHandler ()
		{
			if (cb_skinSubscriptTintColorAttr_I == null)
				cb_skinSubscriptTintColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SkinSubscriptTintColorAttr_I);
			return cb_skinSubscriptTintColorAttr_I;
		}

		static IntPtr n_SkinSubscriptTintColorAttr_I (IntPtr jnienv, IntPtr native__this, int attr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinSubscriptTintColorAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='skinSubscriptTintColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinSubscriptTintColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetSkinSubscriptTintColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel SkinSubscriptTintColorAttr (int attr)
		{
			const string __id = "skinSubscriptTintColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinTextColorAttr (attr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='skinTextColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skinTextColorAttr", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetSkinTextColorAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel SkinTextColorAttr (int attr)
		{
			const string __id = "skinTextColorAttr.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (attr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_subscript_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetInvokeSubscript_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_subscript_Landroid_graphics_drawable_Drawable_ == null)
				cb_subscript_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_InvokeSubscript_Landroid_graphics_drawable_Drawable_);
			return cb_subscript_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_InvokeSubscript_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeSubscript (image));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='subscript' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("subscript", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetInvokeSubscript_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel InvokeSubscript (global::Android.Graphics.Drawables.Drawable image)
		{
			const string __id = "subscript.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

		static Delegate cb_subscript_I;
#pragma warning disable 0169
		static Delegate GetInvokeSubscript_IHandler ()
		{
			if (cb_subscript_I == null)
				cb_subscript_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_InvokeSubscript_I);
			return cb_subscript_I;
		}

		static IntPtr n_InvokeSubscript_I (IntPtr jnienv, IntPtr native__this, int imageRes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeSubscript (imageRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='subscript' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("subscript", "(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetInvokeSubscript_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel InvokeSubscript (int imageRes)
		{
			const string __id = "subscript.(I)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_typeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetInvokeTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_typeface_Landroid_graphics_Typeface_ == null)
				cb_typeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_InvokeTypeface_Landroid_graphics_Typeface_);
			return cb_typeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_InvokeTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeTypeface (typeface));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetGridItemModel']/method[@name='typeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("typeface", "(Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;", "GetInvokeTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel InvokeTypeface (global::Android.Graphics.Typeface typeface)
		{
			const string __id = "typeface.(Landroid/graphics/Typeface;)Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetGridItemModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetGridItemModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (typeface);
			}
		}

	}
}
