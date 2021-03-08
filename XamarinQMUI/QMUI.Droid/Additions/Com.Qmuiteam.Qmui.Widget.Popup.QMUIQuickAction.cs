using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Popup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction", DoNotGenerateAcw=true)]
	public partial class QMUIQuickAction : global::Com.Qmuiteam.Qmui.Widget.Popup.QMUINormalPopup {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action", DoNotGenerateAcw=true)]
		public partial class Action : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action", typeof (Action));
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

			protected Action (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/constructor[@name='QMUIQuickAction.Action' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Action ()
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

			static Delegate cb_icon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetIcon_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_icon_Landroid_graphics_drawable_Drawable_ == null)
					cb_icon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Icon_Landroid_graphics_drawable_Drawable_);
				return cb_icon_Landroid_graphics_drawable_Drawable_;
			}

			static IntPtr n_Icon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var icon = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_icon, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Icon (icon));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("icon", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;", "GetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action Icon (global::Android.Graphics.Drawables.Drawable icon)
			{
				const string __id = "icon.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (icon);
				}
			}

			static Delegate cb_icon_I;
#pragma warning disable 0169
			static Delegate GetIcon_IHandler ()
			{
				if (cb_icon_I == null)
					cb_icon_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Icon_I);
				return cb_icon_I;
			}

			static IntPtr n_Icon_I (IntPtr jnienv, IntPtr native__this, int iconRes)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Icon (iconRes));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("icon", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;", "GetIcon_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action Icon (int iconRes)
			{
				const string __id = "icon.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (iconRes);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IconAttr (iconAttr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/method[@name='iconAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("iconAttr", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;", "GetIconAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action IconAttr (int iconAttr)
			{
				const string __id = "iconAttr.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (iconAttr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_iconTintColorAttr_I;
#pragma warning disable 0169
			static Delegate GetIconTintColorAttr_IHandler ()
			{
				if (cb_iconTintColorAttr_I == null)
					cb_iconTintColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_IconTintColorAttr_I);
				return cb_iconTintColorAttr_I;
			}

			static IntPtr n_IconTintColorAttr_I (IntPtr jnienv, IntPtr native__this, int iconTintColorAttr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IconTintColorAttr (iconTintColorAttr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/method[@name='iconTintColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("iconTintColorAttr", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;", "GetIconTintColorAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action IconTintColorAttr (int iconTintColorAttr)
			{
				const string __id = "iconTintColorAttr.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (iconTintColorAttr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_Handler ()
			{
				if (cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_ == null)
					cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_);
				return cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_;
			}

			static IntPtr n_OnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onClickListener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var onClickListener = (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.IOnClickListener> (native_onClickListener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnClick (onClickListener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIQuickAction.OnClickListener']]"
			[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$OnClickListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;", "GetOnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_OnClickListener_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action OnClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.IOnClickListener onClickListener)
			{
				const string __id = "onClick.(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$OnClickListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (onClickListener);
				}
			}

			static Delegate cb_text_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetText_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_text_Ljava_lang_CharSequence_ == null)
					cb_text_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Text_Ljava_lang_CharSequence_);
				return cb_text_Ljava_lang_CharSequence_;
			}

			static IntPtr n_Text_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Text (text));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/method[@name='text' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("text", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;", "GetText_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action Text (global::Java.Lang.ICharSequence text)
			{
				const string __id = "text.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;";
				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (text);
				}
			}

			public global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action Text (string text)
			{
				var jls_text = text == null ? null : new global::Java.Lang.String (text);
				global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action __result = Text (jls_text);
				var __rsval = __result;
				jls_text?.Dispose ();
				return __rsval;
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextColorAttr (textColorAttr));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.Action']/method[@name='textColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textColorAttr", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;", "GetTextColorAttr_IHandler")]
			public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action TextColorAttr (int textColorAttr)
			{
				const string __id = "textColorAttr.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (textColorAttr);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.DefaultItemView']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$DefaultItemView", DoNotGenerateAcw=true)]
		public partial class DefaultItemView : global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.ItemView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$DefaultItemView", typeof (DefaultItemView));
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

			protected DefaultItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.DefaultItemView']/constructor[@name='QMUIQuickAction.DefaultItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe DefaultItemView (global::Android.Content.Context context)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.DefaultItemView']/constructor[@name='QMUIQuickAction.DefaultItemView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe DefaultItemView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

			static Delegate cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_;
#pragma warning disable 0169
			static Delegate GetRender_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_Handler ()
			{
				if (cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ == null)
					cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_);
				return cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_;
			}

			static void n_Render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.DefaultItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var action = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (native_action, JniHandleOwnership.DoNotTransfer);
				__this.Render (action);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.DefaultItemView']/method[@name='render' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIQuickAction.Action']]"
			[Register ("render", "(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;)V", "GetRender_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_Handler")]
			public override unsafe void Render (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action)
			{
				const string __id = "render.(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.ItemView']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$ItemView", DoNotGenerateAcw=true)]
		public abstract partial class ItemView : global::Com.Qmuiteam.Qmui.Layout.QMUIConstraintLayout {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$ItemView", typeof (ItemView));
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

			protected ItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.ItemView']/constructor[@name='QMUIQuickAction.ItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe ItemView (global::Android.Content.Context context)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.ItemView']/constructor[@name='QMUIQuickAction.ItemView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe ItemView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

			static Delegate cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_;
#pragma warning disable 0169
			static Delegate GetRender_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_Handler ()
			{
				if (cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ == null)
					cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_);
				return cb_render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_;
			}

			static void n_Render_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.ItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var action = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (native_action, JniHandleOwnership.DoNotTransfer);
				__this.Render (action);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.ItemView']/method[@name='render' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIQuickAction.Action']]"
			[Register ("render", "(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;)V", "GetRender_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_Handler")]
			public abstract void Render (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$ItemView", DoNotGenerateAcw=true)]
		internal partial class ItemViewInvoker : ItemView {

			public ItemViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$ItemView", typeof (ItemViewInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction.ItemView']/method[@name='render' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIQuickAction.Action']]"
			[Register ("render", "(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;)V", "GetRender_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_Handler")]
			public override unsafe void Render (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action)
			{
				const string __id = "render.(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (action);
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/interface[@name='QMUIQuickAction.OnClickListener']"
		[Register ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$OnClickListener", "", "Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction/IOnClickListenerInvoker")]
		public partial interface IOnClickListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/interface[@name='QMUIQuickAction.OnClickListener']/method[@name='onClick' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIQuickAction'] and parameter[2][@type='com.qmuiteam.qmui.widget.popup.QMUIQuickAction.Action'] and parameter[3][@type='int']]"
			[Register ("onClick", "(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;I)V", "GetOnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_IHandler:Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction/IOnClickListenerInvoker, QMUI.Droid")]
			void OnClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction quickAction, global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action, int position);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$OnClickListener", DoNotGenerateAcw=true)]
		internal partial class IOnClickListenerInvoker : global::Java.Lang.Object, IOnClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction$OnClickListener", typeof (IOnClickListenerInvoker));

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

			public static IOnClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.popup.QMUIQuickAction.OnClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I;
#pragma warning disable 0169
			static Delegate GetOnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_IHandler ()
			{
				if (cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I == null)
					cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_OnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I);
				return cb_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I;
			}

			static void n_OnClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I (IntPtr jnienv, IntPtr native__this, IntPtr native_quickAction, IntPtr native_action, int position)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.IOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var quickAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (native_quickAction, JniHandleOwnership.DoNotTransfer);
				var action = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (native_action, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (quickAction, action, position);
			}
#pragma warning restore 0169

			IntPtr id_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I;
			public unsafe void OnClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction quickAction, global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action, int position)
			{
				if (id_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I == IntPtr.Zero)
					id_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I = JNIEnv.GetMethodID (class_ref, "onClick", "(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;I)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((quickAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) quickAction).Handle);
				__args [1] = new JValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				__args [2] = new JValue (position);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_I, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.popup.QMUIQuickAction.OnClickListener.onClick
		public partial class ClickEventArgs : global::System.EventArgs {

			public ClickEventArgs (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction quickAction, global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action, int position)
			{
				this.quickAction = quickAction;
				this.action = action;
				this.position = position;
			}

			global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction quickAction;
			public global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction QuickAction {
				get { return quickAction; }
			}

			global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action;
			public global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action Action {
				get { return action; }
			}

			int position;
			public int Position {
				get { return position; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/popup/QMUIQuickAction_OnClickListenerImplementor")]
		internal sealed partial class IOnClickListenerImplementor : global::Java.Lang.Object, IOnClickListener {

			object sender;

			public IOnClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/popup/QMUIQuickAction_OnClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction quickAction, global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action, int position)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ClickEventArgs (quickAction, action, position));
			}

			internal static bool __IsEmpty (IOnClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIQuickAction", typeof (QMUIQuickAction));
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

		protected QMUIQuickAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/constructor[@name='QMUIQuickAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public unsafe QMUIQuickAction (global::Android.Content.Context context, int width, int height)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_actionHeight_I;
#pragma warning disable 0169
		static Delegate GetActionHeight_IHandler ()
		{
			if (cb_actionHeight_I == null)
				cb_actionHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ActionHeight_I);
			return cb_actionHeight_I;
		}

		static IntPtr n_ActionHeight_I (IntPtr jnienv, IntPtr native__this, int actionHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionHeight (actionHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='actionHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("actionHeight", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;", "GetActionHeight_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction ActionHeight (int actionHeight)
		{
			const string __id = "actionHeight.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (actionHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_actionWidth_I;
#pragma warning disable 0169
		static Delegate GetActionWidth_IHandler ()
		{
			if (cb_actionWidth_I == null)
				cb_actionWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_ActionWidth_I);
			return cb_actionWidth_I;
		}

		static IntPtr n_ActionWidth_I (IntPtr jnienv, IntPtr native__this, int actionWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionWidth (actionWidth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='actionWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("actionWidth", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;", "GetActionWidth_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction ActionWidth (int actionWidth)
		{
			const string __id = "actionWidth.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (actionWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_;
#pragma warning disable 0169
		static Delegate GetAddAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_Handler ()
		{
			if (cb_addAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ == null)
				cb_addAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_);
			return cb_addAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_;
		}

		static IntPtr n_AddAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action> (native_action, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (action));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='addAction' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIQuickAction.Action']]"
		[Register ("addAction", "(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;", "GetAddAction_Lcom_qmuiteam_qmui_widget_popup_QMUIQuickAction_Action_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction AddAction (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.Action action)
		{
			const string __id = "addAction.(Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$Action;)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (action);
			}
		}

		static Delegate cb_createItemView;
#pragma warning disable 0169
		static Delegate GetCreateItemViewHandler ()
		{
			if (cb_createItemView == null)
				cb_createItemView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateItemView);
			return cb_createItemView;
		}

		static IntPtr n_CreateItemView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateItemView ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='createItemView' and count(parameter)=0]"
		[Register ("createItemView", "()Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$ItemView;", "GetCreateItemViewHandler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.ItemView CreateItemView ()
		{
			const string __id = "createItemView.()Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction$ItemView;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction.ItemView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createMoreArrowView_Z;
#pragma warning disable 0169
		static Delegate GetCreateMoreArrowView_ZHandler ()
		{
			if (cb_createMoreArrowView_Z == null)
				cb_createMoreArrowView_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_CreateMoreArrowView_Z);
			return cb_createMoreArrowView_Z;
		}

		static IntPtr n_CreateMoreArrowView_Z (IntPtr jnienv, IntPtr native__this, bool isLeft)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateMoreArrowView (isLeft));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='createMoreArrowView' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("createMoreArrowView", "(Z)Landroidx/appcompat/widget/AppCompatImageView;", "GetCreateMoreArrowView_ZHandler")]
		protected virtual unsafe global::AndroidX.AppCompat.Widget.AppCompatImageView CreateMoreArrowView (bool isLeft)
		{
			const string __id = "createMoreArrowView.(Z)Landroidx/appcompat/widget/AppCompatImageView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isLeft);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.AppCompat.Widget.AppCompatImageView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_moreArrowWidth_I;
#pragma warning disable 0169
		static Delegate GetMoreArrowWidth_IHandler ()
		{
			if (cb_moreArrowWidth_I == null)
				cb_moreArrowWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_MoreArrowWidth_I);
			return cb_moreArrowWidth_I;
		}

		static IntPtr n_MoreArrowWidth_I (IntPtr jnienv, IntPtr native__this, int moreArrowWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoreArrowWidth (moreArrowWidth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='moreArrowWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("moreArrowWidth", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;", "GetMoreArrowWidth_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction MoreArrowWidth (int moreArrowWidth)
		{
			const string __id = "moreArrowWidth.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (moreArrowWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_paddingHor_I;
#pragma warning disable 0169
		static Delegate GetPaddingHor_IHandler ()
		{
			if (cb_paddingHor_I == null)
				cb_paddingHor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_PaddingHor_I);
			return cb_paddingHor_I;
		}

		static IntPtr n_PaddingHor_I (IntPtr jnienv, IntPtr native__this, int paddingHor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaddingHor (paddingHor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='paddingHor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("paddingHor", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;", "GetPaddingHor_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction PaddingHor (int paddingHor)
		{
			const string __id = "paddingHor.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (paddingHor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showMoreArrowIfNeeded_Z;
#pragma warning disable 0169
		static Delegate GetShowMoreArrowIfNeeded_ZHandler ()
		{
			if (cb_showMoreArrowIfNeeded_Z == null)
				cb_showMoreArrowIfNeeded_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ShowMoreArrowIfNeeded_Z);
			return cb_showMoreArrowIfNeeded_Z;
		}

		static IntPtr n_ShowMoreArrowIfNeeded_Z (IntPtr jnienv, IntPtr native__this, bool showMoreArrowIfNeeded)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowMoreArrowIfNeeded (showMoreArrowIfNeeded));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIQuickAction']/method[@name='showMoreArrowIfNeeded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showMoreArrowIfNeeded", "(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;", "GetShowMoreArrowIfNeeded_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction ShowMoreArrowIfNeeded (bool showMoreArrowIfNeeded)
		{
			const string __id = "showMoreArrowIfNeeded.(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (showMoreArrowIfNeeded);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
