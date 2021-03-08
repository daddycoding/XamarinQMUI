using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Grouplist {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/grouplist/QMUIGroupListSectionHeaderFooterView", DoNotGenerateAcw=true)]
	public partial class QMUIGroupListSectionHeaderFooterView : global::Android.Widget.LinearLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/grouplist/QMUIGroupListSectionHeaderFooterView", typeof (QMUIGroupListSectionHeaderFooterView));
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

		protected QMUIGroupListSectionHeaderFooterView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/constructor[@name='QMUIGroupListSectionHeaderFooterView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIGroupListSectionHeaderFooterView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/constructor[@name='QMUIGroupListSectionHeaderFooterView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIGroupListSectionHeaderFooterView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/constructor[@name='QMUIGroupListSectionHeaderFooterView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIGroupListSectionHeaderFooterView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/constructor[@name='QMUIGroupListSectionHeaderFooterView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;)V", "")]
		public unsafe QMUIGroupListSectionHeaderFooterView (global::Android.Content.Context context, global::Java.Lang.ICharSequence titleText)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_titleText);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (titleText);
			}
		}

		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;)V", "")]
		public unsafe QMUIGroupListSectionHeaderFooterView (global::Android.Content.Context context, string titleText)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_titleText);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (titleText);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/constructor[@name='QMUIGroupListSectionHeaderFooterView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;Z)V", "")]
		public unsafe QMUIGroupListSectionHeaderFooterView (global::Android.Content.Context context, global::Java.Lang.ICharSequence titleText, bool isFooter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_titleText);
				__args [2] = new JniArgumentValue (isFooter);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (titleText);
			}
		}

		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;Z)V", "")]
		public unsafe QMUIGroupListSectionHeaderFooterView (global::Android.Content.Context context, string titleText, bool isFooter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_titleText = CharSequence.ToLocalJniHandle (titleText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_titleText);
				__args [2] = new JniArgumentValue (isFooter);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titleText);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (titleText);
			}
		}

		static Delegate cb_getTextView;
#pragma warning disable 0169
		static Delegate GetGetTextViewHandler ()
		{
			if (cb_getTextView == null)
				cb_getTextView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTextView);
			return cb_getTextView;
		}

		static IntPtr n_GetTextView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView TextView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/method[@name='getTextView' and count(parameter)=0]"
			[Register ("getTextView", "()Landroid/widget/TextView;", "GetGetTextViewHandler")]
			get {
				const string __id = "getTextView.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setText_Ljava_lang_CharSequence_ == null)
				cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetText_Ljava_lang_CharSequence_);
			return cb_setText_Ljava_lang_CharSequence_;
		}

		static void n_SetText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.SetText (text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setText", "(Ljava/lang/CharSequence;)V", "GetSetText_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetText (global::Java.Lang.ICharSequence text)
		{
			const string __id = "setText.(Ljava/lang/CharSequence;)V";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
			}
		}

		public void SetText (string text)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			SetText (jls_text);
			jls_text?.Dispose ();
		}

		static Delegate cb_setTextGravity_I;
#pragma warning disable 0169
		static Delegate GetSetTextGravity_IHandler ()
		{
			if (cb_setTextGravity_I == null)
				cb_setTextGravity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTextGravity_I);
			return cb_setTextGravity_I;
		}

		static void n_SetTextGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Grouplist.QMUIGroupListSectionHeaderFooterView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextGravity (gravity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.grouplist']/class[@name='QMUIGroupListSectionHeaderFooterView']/method[@name='setTextGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextGravity", "(I)V", "GetSetTextGravity_IHandler")]
		public virtual unsafe void SetTextGravity (int gravity)
		{
			const string __id = "setTextGravity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (gravity);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
