using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView", DoNotGenerateAcw=true)]
	public partial class QMUIDialogMenuItemView : global::Com.Qmuiteam.Qmui.Layout.QMUIConstraintLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.CheckItemView']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$CheckItemView", DoNotGenerateAcw=true)]
		public partial class CheckItemView : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$CheckItemView", typeof (CheckItemView));
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

			protected CheckItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.CheckItemView']/constructor[@name='QMUIDialogMenuItemView.CheckItemView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
			public unsafe CheckItemView (global::Android.Content.Context context, bool right)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (right);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.CheckItemView']/constructor[@name='QMUIDialogMenuItemView.CheckItemView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.CharSequence']]"
			[Register (".ctor", "(Landroid/content/Context;ZLjava/lang/CharSequence;)V", "")]
			public unsafe CheckItemView (global::Android.Content.Context context, bool right, global::Java.Lang.ICharSequence text)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;ZLjava/lang/CharSequence;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (right);
					__args [2] = new JniArgumentValue (native_text);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (text);
				}
			}

			[Register (".ctor", "(Landroid/content/Context;ZLjava/lang/CharSequence;)V", "")]
			public unsafe CheckItemView (global::Android.Content.Context context, bool right, string text)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;ZLjava/lang/CharSequence;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (right);
					__args [2] = new JniArgumentValue (native_text);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (text);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.CheckItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return CharSequence.ToLocalJniHandle (__this.TextFormatted);
			}
#pragma warning restore 0169

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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.CheckItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				__this.TextFormatted = text;
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.ICharSequence TextFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.CheckItemView']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
				get {
					const string __id = "getText.()Ljava/lang/CharSequence;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.CheckItemView']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
				[Register ("setText", "(Ljava/lang/CharSequence;)V", "GetSetText_Ljava_lang_CharSequence_Handler")]
				set {
					const string __id = "setText.(Ljava/lang/CharSequence;)V";
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

			public string Text {
				get { return TextFormatted == null ? null : TextFormatted.ToString (); }
				set {
					var jls = value == null ? null : new global::Java.Lang.String (value);
					TextFormatted = jls;
					if (jls != null) jls.Dispose ();
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.MarkItemView']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$MarkItemView", DoNotGenerateAcw=true)]
		public partial class MarkItemView : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$MarkItemView", typeof (MarkItemView));
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

			protected MarkItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.MarkItemView']/constructor[@name='QMUIDialogMenuItemView.MarkItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe MarkItemView (global::Android.Content.Context context)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.MarkItemView']/constructor[@name='QMUIDialogMenuItemView.MarkItemView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.CharSequence']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;)V", "")]
			public unsafe MarkItemView (global::Android.Content.Context context, global::Java.Lang.ICharSequence text)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (native_text);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (text);
				}
			}

			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;)V", "")]
			public unsafe MarkItemView (global::Android.Content.Context context, string text)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (native_text);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (text);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.MarkItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				__this.SetText (text);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.MarkItemView']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
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

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogMenuItemView.MenuItemViewListener']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$MenuItemViewListener", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView/IMenuItemViewListenerInvoker")]
		public partial interface IMenuItemViewListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIDialogMenuItemView.MenuItemViewListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onClick", "(I)V", "GetOnClick_IHandler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView/IMenuItemViewListenerInvoker, QMUI.Droid")]
			void OnClick (int index);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$MenuItemViewListener", DoNotGenerateAcw=true)]
		internal partial class IMenuItemViewListenerInvoker : global::Java.Lang.Object, IMenuItemViewListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$MenuItemViewListener", typeof (IMenuItemViewListenerInvoker));

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

			public static IMenuItemViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMenuItemViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIDialogMenuItemView.MenuItemViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMenuItemViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick_I;
#pragma warning disable 0169
			static Delegate GetOnClick_IHandler ()
			{
				if (cb_onClick_I == null)
					cb_onClick_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnClick_I);
				return cb_onClick_I;
			}

			static void n_OnClick_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.IMenuItemViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (index);
			}
#pragma warning restore 0169

			IntPtr id_onClick_I;
			public unsafe void OnClick (int index)
			{
				if (id_onClick_I == IntPtr.Zero)
					id_onClick_I = JNIEnv.GetMethodID (class_ref, "onClick", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_I, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.dialog.QMUIDialogMenuItemView.MenuItemViewListener.onClick
		public partial class MenuItemViewEventArgs : global::System.EventArgs {

			public MenuItemViewEventArgs (int index)
			{
				this.index = index;
			}

			int index;
			public int Index {
				get { return index; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView_MenuItemViewListenerImplementor")]
		internal sealed partial class IMenuItemViewListenerImplementor : global::Java.Lang.Object, IMenuItemViewListener {

			object sender;

			public IMenuItemViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView_MenuItemViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MenuItemViewEventArgs> Handler;
#pragma warning restore 0649

			public void OnClick (int index)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MenuItemViewEventArgs (index));
			}

			internal static bool __IsEmpty (IMenuItemViewListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.TextItemView']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$TextItemView", DoNotGenerateAcw=true)]
		public partial class TextItemView : global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.TextItemView']/field[@name='mTextView']"
			[Register ("mTextView")]
			protected global::Android.Widget.TextView MTextView {
				get {
					const string __id = "mTextView.Landroid/widget/TextView;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mTextView.Landroid/widget/TextView;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$TextItemView", typeof (TextItemView));
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

			protected TextItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.TextItemView']/constructor[@name='QMUIDialogMenuItemView.TextItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe TextItemView (global::Android.Content.Context context)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.TextItemView']/constructor[@name='QMUIDialogMenuItemView.TextItemView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.CharSequence']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;)V", "")]
			public unsafe TextItemView (global::Android.Content.Context context, global::Java.Lang.ICharSequence text)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (native_text);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (text);
				}
			}

			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/CharSequence;)V", "")]
			public unsafe TextItemView (global::Android.Content.Context context, string text)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Ljava/lang/CharSequence;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_text = CharSequence.ToLocalJniHandle (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (native_text);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (text);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.TextItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
				__this.SetText (text);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.TextItemView']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
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

			static Delegate cb_setTextColor_I;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetSetTextColor_IHandler ()
			{
				if (cb_setTextColor_I == null)
					cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTextColor_I);
				return cb_setTextColor_I;
			}

			[Obsolete]
			static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int color)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.TextItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetTextColor (color);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.TextItemView']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Obsolete (@"deprecated")]
			[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
			public virtual unsafe void SetTextColor (int color)
			{
				const string __id = "setTextColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (color);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_setTextColorAttr_I;
#pragma warning disable 0169
			static Delegate GetSetTextColorAttr_IHandler ()
			{
				if (cb_setTextColorAttr_I == null)
					cb_setTextColorAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTextColorAttr_I);
				return cb_setTextColorAttr_I;
			}

			static void n_SetTextColorAttr_I (IntPtr jnienv, IntPtr native__this, int colorAttr)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.TextItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetTextColorAttr (colorAttr);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView.TextItemView']/method[@name='setTextColorAttr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextColorAttr", "(I)V", "GetSetTextColorAttr_IHandler")]
			public virtual unsafe void SetTextColorAttr (int colorAttr)
			{
				const string __id = "setTextColorAttr.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (colorAttr);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView", typeof (QMUIDialogMenuItemView));
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

		protected QMUIDialogMenuItemView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/constructor[@name='QMUIDialogMenuItemView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIDialogMenuItemView (global::Android.Content.Context context)
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

		static Delegate cb_isChecked;
#pragma warning disable 0169
		static Delegate GetIsCheckedHandler ()
		{
			if (cb_isChecked == null)
				cb_isChecked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsChecked);
			return cb_isChecked;
		}

		static bool n_IsChecked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Checked;
		}
#pragma warning restore 0169

		static Delegate cb_setChecked_Z;
#pragma warning disable 0169
		static Delegate GetSetChecked_ZHandler ()
		{
			if (cb_setChecked_Z == null)
				cb_setChecked_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetChecked_Z);
			return cb_setChecked_Z;
		}

		static void n_SetChecked_Z (IntPtr jnienv, IntPtr native__this, bool @checked)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Checked = @checked;
		}
#pragma warning restore 0169

		public virtual unsafe bool Checked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/method[@name='isChecked' and count(parameter)=0]"
			[Register ("isChecked", "()Z", "GetIsCheckedHandler")]
			get {
				const string __id = "isChecked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/method[@name='setChecked' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setChecked", "(Z)V", "GetSetChecked_ZHandler")]
			set {
				const string __id = "setChecked.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMenuIndex;
#pragma warning disable 0169
		static Delegate GetGetMenuIndexHandler ()
		{
			if (cb_getMenuIndex == null)
				cb_getMenuIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMenuIndex);
			return cb_getMenuIndex;
		}

		static int n_GetMenuIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MenuIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setMenuIndex_I;
#pragma warning disable 0169
		static Delegate GetSetMenuIndex_IHandler ()
		{
			if (cb_setMenuIndex_I == null)
				cb_setMenuIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMenuIndex_I);
			return cb_setMenuIndex_I;
		}

		static void n_SetMenuIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MenuIndex = index;
		}
#pragma warning restore 0169

		public virtual unsafe int MenuIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/method[@name='getMenuIndex' and count(parameter)=0]"
			[Register ("getMenuIndex", "()I", "GetGetMenuIndexHandler")]
			get {
				const string __id = "getMenuIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/method[@name='setMenuIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMenuIndex", "(I)V", "GetSetMenuIndex_IHandler")]
			set {
				const string __id = "setMenuIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/method[@name='createItemTextView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createItemTextView", "(Landroid/content/Context;)Landroid/widget/TextView;", "")]
		public static unsafe global::Android.Widget.TextView CreateItemTextView (global::Android.Content.Context context)
		{
			const string __id = "createItemTextView.(Landroid/content/Context;)Landroid/widget/TextView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_notifyCheckChange_Z;
#pragma warning disable 0169
		static Delegate GetNotifyCheckChange_ZHandler ()
		{
			if (cb_notifyCheckChange_Z == null)
				cb_notifyCheckChange_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_NotifyCheckChange_Z);
			return cb_notifyCheckChange_Z;
		}

		static void n_NotifyCheckChange_Z (IntPtr jnienv, IntPtr native__this, bool isChecked)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyCheckChange (isChecked);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/method[@name='notifyCheckChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("notifyCheckChange", "(Z)V", "GetNotifyCheckChange_ZHandler")]
		protected virtual unsafe void NotifyCheckChange (bool isChecked)
		{
			const string __id = "notifyCheckChange.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isChecked);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_Handler ()
		{
			if (cb_setListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_ == null)
				cb_setListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_);
			return cb_setListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_;
		}

		static void n_SetListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.IMenuItemViewListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.IMenuItemViewListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIDialogMenuItemView']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIDialogMenuItemView.MenuItemViewListener']]"
		[Register ("setListener", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$MenuItemViewListener;)V", "GetSetListener_Lcom_qmuiteam_qmui_widget_dialog_QMUIDialogMenuItemView_MenuItemViewListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.IMenuItemViewListener listener)
		{
			const string __id = "setListener.(Lcom/qmuiteam/qmui/widget/dialog/QMUIDialogMenuItemView$MenuItemViewListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.IMenuItemViewListener"

		global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.IMenuItemViewListenerImplementor __CreateIMenuItemViewListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIDialogMenuItemView.IMenuItemViewListenerImplementor (this);
		}
#endregion
	}
}
